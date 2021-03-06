Use [GD1C2013]    /* Utilizamos una base de datos EXTERNA,la base a la cual se dirigiran las proximas consultas SQL en el proceso actual. */
Go 
/* Signo de finalizacion de lotes de sentencia*/

Create Schema DATACENTER AUTHORIZATION [gd]   /* Creamos un Schema nuevo(Modelo de Datos/contiene Tablas,Indices y demas estructuras de negocio) ; El usuario que poseera el schema (OWNER) sera: GD*/   
Go

/*------------------INICIO DE CREACION DE TABLAS--------------------*/

/*------------------------------------------------------------------*/
/*-----------------------CREAMOS TABLA FUNC-------------------------*/

CREATE TABLE DATACENTER.Funcionalidad
(func_id int IDENTITY (1,1) PRIMARY KEY NOT NULL,
func_nombre nvarchar(255) NOT NULL)
GO

/*------------------------------------------------------------------*/
/*------------------------CREAMOS TABLA ROL-------------------------*/

CREATE TABLE DATACENTER.Rol
(rol_id int IDENTITY (1,1) PRIMARY KEY NOT NULL,
rol_nombre nvarchar(255) NOT NULL,
rol_estado char NOT NULL)
GO

/*------------------------------------------------------------------*/
/*----------------CREAMOS TABLA FUNCXROL----------------------------*/

CREATE TABLE DATACENTER.FuncionalidadPorRol
(fxrol_rol_id int NOT NULL, 
fxrol_func_id int NOT NULL, 
fxrol_estado char NOT NULL,
FOREIGN KEY(fxrol_rol_id) references DATACENTER.Rol (rol_id),
FOREIGN KEY(fxrol_func_id) references DATACENTER.Funcionalidad (func_id),
PRIMARY KEY (fxrol_rol_id, fxrol_func_id)
)
GO


/*--------------------------------------------------------------------------*/
/*-----------------CREAMOS TABLA USUARIO NO CLIENTE-------------------------*/

CREATE TABLE DATACENTER.Usuario
(usu_username nvarchar(255) NOT NULL,
usu_password nvarchar(255) NOT NULL, 
usu_cant_intentos int NOT NULL, 
usu_rol_id int NOT NULL, 
PRIMARY KEY (usu_username),
FOREIGN KEY (usu_rol_id) REFERENCES DATACENTER.Rol (rol_id))
GO

/*--------------------------------------------------------------------------*/
/*-----------------CREAMOS TABLA USUARIO CLIENTE----------------------------*/

CREATE TABLE DATACENTER.Cliente
(cli_dni numeric(18,0) NOT NULL,
cli_rol_id int NOT NULL DEFAULT 2, --Los Clientes tienen ID_ROL = 2
cli_nombre nvarchar(255) NULL,
cli_apellido nvarchar(255) NULL,
cli_dir nvarchar(255) NULL,
cli_telefono nvarchar(255) NULL,
cli_mail nvarchar(255) NULL, 
cli_fecha_nac datetime NULL,
cli_puntos_acum int NULL,
cli_condicion char NULL,     --puede ser J jubilado o P pensionado
cli_discapacitado char NULL, --puede ser discap D o no N
cli_sexo char NULL,
FOREIGN KEY (cli_rol_id) REFERENCES DATACENTER.Rol (rol_id),
PRIMARY KEY (cli_dni))
GO

/*------------------------------------------------------------------*/
/*-----------------CREAMOS TABLA PREMIO-----------------------------*/

CREATE TABLE DATACENTER.Premio
(prem_id int IDENTITY (1,1) NOT NULL,
prem_nombre nvarchar(255) NULL,
prem_costo_puntos int NULL,
prem_stock int NULL,
PRIMARY KEY (prem_id)
)
GO

/*------------------------------------------------------------------*/

/*-------------------CREAMOS TABLA CANJE----------------------------*/


CREATE TABLE DATACENTER.Canje
(canj_id int NOT NULL,
canj_cli_dni numeric (18,0) NOT NULL,
canj_prem_id int NOT NULL,
canj_cant_retirada int NULL,
canj_fecha datetime NULL
FOREIGN KEY (canj_cli_dni) REFERENCES DATACENTER.Cliente (cli_dni),
FOREIGN KEY (canj_prem_id) REFERENCES DATACENTER.Premio (prem_id),
PRIMARY KEY (canj_id, canj_prem_id))
GO

/*------------------------------------------------------------------*/
/*-----------------CREAMOS TABLA TIPO TARJETA-----------------------*/

CREATE TABLE DATACENTER.TipoTarjeta
(tipo_id int IDENTITY (1,1) NOT NULL PRIMARY KEY,
tipo_descripcion nvarchar(255) NULL,
tipo_cuotas char NULL
)
GO
/*------------------------------------------------------------------*/
/*-----------------CREAMOS TABLA SERVICIO---------------------------*/

CREATE TABLE DATACENTER.Servicio
(serv_id int IDENTITY (1,1) PRIMARY KEY NOT NULL ,
serv_tipo nvarchar(255) NULL,
serv_porc_adicional numeric (18,2) NULL
)
GO

/*------------------------------------------------------------------*/
/*---------------------CREAMOS TABLA CIUDAD-------------------------*/

CREATE TABLE DATACENTER.Ciudad
(ciu_nombre nvarchar(255) NOT NULL PRIMARY KEY)
GO

/*------------------------------------------------------------------*/
/*-----------------CREAMOS TABLA RECORRIDO--------------------------*/

CREATE TABLE DATACENTER.Recorrido
(reco_cod numeric(18,0) NOT NULL,
reco_serv_id int NOT NULL,
reco_origen nvarchar(255) NOT NULL,
reco_destino nvarchar(255) NOT NULL,
reco_precio_base_kg numeric(18,2) NULL,
reco_precio_base_pasaje numeric (18,2) NULL,
reco_estado CHAR NULL,
FOREIGN KEY (reco_serv_id) REFERENCES DATACENTER.Servicio (serv_id),
FOREIGN KEY (reco_origen) REFERENCES DATACENTER.Ciudad (ciu_nombre),
FOREIGN KEY (reco_destino) REFERENCES DATACENTER.Ciudad (ciu_nombre),
PRIMARY KEY (reco_cod)
)
GO



/*------------------------------------------------------------------*/
/*-------------------CREAMOS TABLA MARCA----------------------------*/

CREATE TABLE DATACENTER.Marca
(marc_id int IDENTITY (1,1) NOT NULL PRIMARY KEY,
marc_nombre nvarchar(255) NULL
)
GO

/*------------------------------------------------------------------*/
/*-------------------CREAMOS TABLA MICRO----------------------------*/

CREATE TABLE DATACENTER.Micro
(mic_patente nvarchar(255) NOT NULL,
mic_marc_id int NOT NULL,
mic_serv_id int NOT NULL,
mic_cant_butacas int NULL,
mic_cant_kg_disponibles numeric (18,0) NULL,
mic_modelo nvarchar(255) NULL,
mic_nro int IDENTITY (1,1) NOT NULL,  
mic_fecha_alta datetime NULL,
mic_fecha_baja_def datetime NULL,
FOREIGN KEY (mic_marc_id) REFERENCES DATACENTER.Marca (marc_id),
FOREIGN KEY (mic_serv_id) REFERENCES DATACENTER.Servicio (serv_id),
PRIMARY KEY (mic_patente)
)
GO

/*------------------------------------------------------------------*/
/*----------------CREAMOS TABLA ESTADOMICRO-------------------------*/

CREATE TABLE DATACENTER.EstadoMicro
(est_id int IDENTITY (1,1) NOT NULL,
est_mic_patente nvarchar(255) NOT NULL,
est_fecha_fuera_serv datetime NULL,
est_fecha_reingreso datetime NULL,
FOREIGN KEY (est_mic_patente) REFERENCES DATACENTER.Micro (mic_patente),
PRIMARY KEY (est_id)
)
GO

/*------------------------------------------------------------------*/
/*-------------------CREAMOS TABLA BUTACA---------------------------*/

CREATE TABLE DATACENTER.Butaca
(but_nro numeric (18,0) NOT NULL,
but_mic_patente nvarchar(255) NOT NULL,
but_tipo nvarchar(255) NULL,
but_piso numeric (18,0) NULL,
FOREIGN KEY (but_mic_patente) REFERENCES DATACENTER.Micro (mic_patente),
PRIMARY KEY (but_nro, but_mic_patente)
)
GO


/*------------------------------------------------------------------*/
/*---------------------CREAMOS TABLA VIAJE-------------------------*/

CREATE TABLE DATACENTER.Viaje
(viaj_id int IDENTITY (1,1) NOT NULL,
viaj_mic_patente nvarchar(255) NOT NULL,
viaj_reco_cod numeric(18,0) NOT NULL,
viaj_fecha_salida datetime NULL,
viaj_fecha_lleg_estimada datetime NULL,
viaj_fecha_llegada datetime NULL,
viaj_estado CHAR NULL DEFAULT 'H',   --En la migracion suponemos todos los viajes habilitados
FOREIGN KEY (viaj_mic_patente) REFERENCES DATACENTER.Micro (mic_patente), 
FOREIGN KEY (viaj_reco_cod) REFERENCES DATACENTER.Recorrido (reco_cod),
PRIMARY KEY (viaj_id)
)
GO
/*------------------------------------------------------------------*/
/*-----------------CREAMOS TABLA COMPRA-----------------------------*/

CREATE TABLE DATACENTER.Compra
(comp_id int IDENTITY (1,1) NOT NULL,
comp_comprador_dni numeric (18,0) NOT NULL,
comp_tipo_tarj_id int  NULL,
comp_viaj_id int  NOT NULL, --COLUMNA AGREGADA TEMPORALMENTE PARA OPTIMIZAR LA MIGRACION
comp_cant_pasajes int NULL,
comp_cant_total_kg numeric (18,0) NULL, 
comp_costo_total numeric (18,2) NULL,
comp_fecha_compra datetime NULL,
comp_codigo_pas_paq numeric (18,0) NOT NULL, --COLUMNA AGREGADA TEMPORALMENTE PARA OPTIMIZAR LA MIGRACION
FOREIGN KEY (comp_comprador_dni) REFERENCES DATACENTER.Cliente (cli_dni),
FOREIGN KEY (comp_tipo_tarj_id) REFERENCES DATACENTER.TipoTarjeta (tipo_id),
PRIMARY KEY (comp_id)
)
GO


/*------------------------------------------------------------------*/

/*------------------------------------------------------------------*/


/*---------------------CREAMOS TABLA PASAJE-------------------------*/

CREATE TABLE DATACENTER.Pasaje
(pas_cod numeric(18,0) NOT NULL,
pas_nro_butaca numeric (18,0) NOT NULL,
pas_micro_patente nvarchar(255) NOT NULL,
pas_cli_dni numeric (18,0) NOT NULL,
pas_compra_id int NOT NULL,
pas_precio numeric(18,2) NULL,
pas_viaj_id int  NOT NULL,
FOREIGN KEY (pas_viaj_id) REFERENCES DATACENTER.Viaje (viaj_id),
FOREIGN KEY (pas_nro_butaca, pas_micro_patente) REFERENCES DATACENTER.Butaca (but_nro, but_mic_patente),
FOREIGN KEY (pas_cli_dni) REFERENCES DATACENTER.Cliente (cli_dni),
FOREIGN KEY (pas_compra_id) REFERENCES DATACENTER.Compra (comp_id),
PRIMARY KEY (pas_cod)
)
GO

/*------------------------------------------------------------------*/
/*---------------------CREAMOS TABLA PAQUETE-------------------------*/

CREATE TABLE DATACENTER.Paquete
(paq_cod numeric(18,0) NOT NULL,
paq_comp_id int NOT NULL,
paq_precio numeric (18,2) NULL,
paq_kg numeric (18,0)NULL,
paq_viaj_id int  NOT NULL,
FOREIGN KEY (paq_viaj_id) REFERENCES DATACENTER.Viaje (viaj_id),
FOREIGN KEY (paq_comp_id) REFERENCES DATACENTER.Compra (comp_id),
PRIMARY KEY (paq_cod)
)
GO

/*------------------------------------------------------------------*/
/*---------------------CREAMOS TABLA DEVOLUCION-------------------------*/

CREATE TABLE DATACENTER.Devolucion
(dev_id int NOT NULL,
dev_cod_PasPaq numeric(18,0) NOT NULL,
dev_tipo_devuelto nvarchar(255) NOT NULL,	--INDICA PAQUETE O PASAJE QUE SE REGISTRA EN LA DEVOLUCION
dev_comp_id int NOT NULL,
dev_fecha datetime NULL,
dev_motivo nvarchar(255) NULL,
FOREIGN KEY (dev_comp_id) REFERENCES DATACENTER.Compra (comp_id),
PRIMARY KEY (dev_id, dev_cod_PasPaq, dev_tipo_devuelto)
)
GO
/*------------------------------------------------------------------*/
/*---------------------CREAMOS TABLA ARRIBO-------------------------*/

CREATE TABLE DATACENTER.Arribo
(arri_fecha_llegada datetime NOT NULL,   
arri_mic_patente nvarchar(255) NOT NULL,         --DATO INGRESADO EN LA TERMINAL DE LLEGADA NO ES FK
arri_viaj_id int NOT NULL,
arri_ciu_arribada nvarchar(255) NOT NULL, 
FOREIGN KEY (arri_viaj_id) REFERENCES DATACENTER.Viaje (viaj_id),          --SEGUN DER ES FK => CONSULTA TABLA VIAJE
PRIMARY KEY (arri_fecha_llegada, arri_mic_patente)
)
GO 

/* ---------------------PRUEBAS-------------------------- */

--AGREGAMOS FUNCIONALIDADES 
INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('ABM Rol')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('ABM Micro')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('ABM Recorrido')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('Compra')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('Estadisticas')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('Registrar Arribo')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('Registrar Devolucion/Cancelacion')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('Canje Premio')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('Generar Viaje')
GO

INSERT INTO DATACENTER.Funcionalidad(func_nombre) --no ponemos ID ya que se autoincrementa
VALUES ('Consultar Puntos Pasajero Frecuente')
GO

--AGREGAMOS ROLES

INSERT INTO DATACENTER.Rol(rol_nombre, rol_estado) --no ponemos ID ya que se autoincrementa
VALUES ('Administrador', 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.Rol(rol_nombre, rol_estado) --no ponemos ID ya que se autoincrementa
VALUES ('Cliente', 'H') --H HABILITADO D DESHABILITADO
GO

--ASOCIAMOS ROLES CON FUNCIONES

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 1, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 2, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 3, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 4, 'H') --H HABILITADO D DESHABILITADO
GO
INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 5, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 6, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 7, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 8, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 9, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (1, 10, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (2, 4, 'H') --H HABILITADO D DESHABILITADO
GO

INSERT INTO DATACENTER.FuncionalidadPorRol(fxrol_rol_id,fxrol_func_id, fxrol_estado)
VALUES (2, 10, 'H') --H HABILITADO D DESHABILITADO
GO
----INSERTAMOS ADMINISTRADORES 
INSERT INTO DATACENTER.Usuario(usu_username, usu_password, usu_cant_intentos, usu_rol_id)
VALUES ('frann96','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0,1)

INSERT INTO DATACENTER.Usuario(usu_username, usu_password, usu_cant_intentos, usu_rol_id)
VALUES ('dieguito12','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0,1)

INSERT INTO DATACENTER.Usuario(usu_username, usu_password, usu_cant_intentos, usu_rol_id)
VALUES ('maty32','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0,1)

INSERT INTO DATACENTER.Usuario(usu_username, usu_password, usu_cant_intentos, usu_rol_id)
VALUES ('ani18','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0,1)


--AGREGAMOS PREMIOS

INSERT INTO 
DATACENTER.Premio(prem_nombre, prem_costo_puntos, prem_stock)
VALUES ('Televisor Led 32', 100, 50)
GO

INSERT INTO 
DATACENTER.Premio(prem_nombre, prem_costo_puntos, prem_stock)
VALUES ('Notebook Lenovo G470', 150, 30)
GO

--AGREGAMOS TIPO DE TARJETA
--H Habilitada para comprar en cuotas
--D Deshabilitada para comprar en cuotas

INSERT INTO 
DATACENTER.TipoTarjeta (tipo_descripcion, tipo_cuotas)
VALUES ('Mastercard', 'H')

INSERT INTO 
DATACENTER.TipoTarjeta (tipo_descripcion, tipo_cuotas)
VALUES ('American Express', 'D')

INSERT INTO 
DATACENTER.TipoTarjeta (tipo_descripcion, tipo_cuotas)
VALUES ('Visa', 'H')

INSERT INTO 
DATACENTER.TipoTarjeta (tipo_descripcion, tipo_cuotas)
VALUES ('Italcred', 'D')

INSERT INTO 
DATACENTER.TipoTarjeta (tipo_descripcion, tipo_cuotas)
VALUES ('Cabal', 'H')

/*------------------------------------------------------------------*/
/*-----------------MIGRACION DE CLIENTES----------------------------*/

INSERT INTO DATACENTER.Cliente(cli_dni, cli_nombre, cli_apellido, cli_dir, cli_telefono, cli_mail, cli_fecha_Nac)
	SELECT DISTINCT cli_Dni, cli_Nombre, cli_Apellido, cli_Dir, cli_Telefono, cli_Mail, Cli_Fecha_Nac
	FROM gd_esquema.Maestra
GO

--SETEAMOS LOS PUNTOS ACUMULADOS EN 0 PARA INICIALIZARLOS
UPDATE DATACENTER.Cliente
SET cli_puntos_acum = 0
GO

/*------------------------------------------------------------------*/
/*----------------MIGRACION DE SERVICIO-----------------------------*/

INSERT INTO DATACENTER.Servicio(serv_tipo, serv_porc_adicional)
	SELECT DISTINCT(Tipo_Servicio), ROUND(((Pasaje_Precio-Recorrido_Precio_BasePasaje)/Recorrido_Precio_BasePasaje)*100,0)
	FROM gd_esquema.Maestra
	WHERE Recorrido_Precio_BasePasaje <> 0
	ORDER BY 2
GO

/*------------------------------------------------------------------*/
/*----------------MIGRACION DE MARCA-----------------------------*/
INSERT INTO DATACENTER.Marca(marc_nombre)
	SELECT distinct Micro_Marca
	FROM gd_esquema.Maestra
go

/*------------------------------------------------------------------*/
/*----------------MIGRACION DE CIUDAD-------------------------------*/

INSERT INTO DATACENTER.Ciudad(ciu_nombre)
	SELECT DISTINCT Recorrido_Ciudad_Destino -- Vale esto xq ciudades_Destino son las mismas que ciudades_Origen
	FROM gd_esquema.Maestra
GO

/*------------------------------------------------------------------*/
/*----------------MIGRACION DE MICRO--------------------------------*/

			-- CREA LA VISTA NECESARIA PARA LA MIGRACION --
CREATE VIEW Micros_Migrados(Micro_Patente, Micro_Modelo, Micro_KG_Disponibles, Micro_Cant_Butacas, Micro_Marca, Micro_Tipo_Serv) AS
select distinct Micro_Patente, Micro_Modelo, Micro_KG_Disponibles, MAX(butaca_nro) as Micro_Cant_Butacas, Micro_Marca, Tipo_Servicio
from gd_esquema.Maestra
group by Micro_Patente, Micro_Modelo, Micro_KG_Disponibles, Micro_Marca, Tipo_Servicio
go

			-- AHORA SI REALIZAMOS LA MIGRACION EN BASE A LOS CAMPOS NECESARIOS --
insert into DATACENTER.Micro(mic_patente, mic_modelo, mic_cant_kg_disponibles, mic_cant_butacas, mic_marc_id, mic_serv_id, mic_fecha_alta)
select Micro_Patente, Micro_Modelo, Micro_KG_Disponibles, Micro_Cant_Butacas, marc_Id, serv_Id, NULL -- SE LO SETEO A NULL Y DESPUES VEO!!!!!
from micros_migrados join DATACENTER.Marca on Micro_Marca = marc_nombre join DATACENTER.Servicio on Micro_Tipo_Serv = serv_tipo
go

/*------------------------------------------------------------------*/
/*----------------MIGRACION DE RECORRIDO-----------------------------*/

INSERT INTO DATACENTER.Recorrido(reco_cod, reco_serv_id, reco_origen, reco_destino, reco_precio_base_kg, reco_precio_base_pasaje)
	SELECT DISTINCT t1.Recorrido_Codigo, serv_Id, t1.Recorrido_Ciudad_Origen, t1.Recorrido_Ciudad_Destino, t1.Recorrido_Precio_BaseKG, t2.Recorrido_Precio_BasePasaje
	FROM gd_esquema.Maestra t1 join gd_esquema.Maestra t2 ON (t1.Recorrido_Codigo = t2.Recorrido_Codigo) join DATACENTER.Servicio on t1.Tipo_Servicio = serv_tipo
	WHERE (t1.Recorrido_Precio_BaseKG <> '0' and t2.Recorrido_Precio_BasePasaje <> '0') 
	ORDER BY 1
GO

/*------------------------------------------------------------------*/
/*----------------HABILITAMOS LOS RECORRIDOS-----------------------------*/
UPDATE DATACENTER.Recorrido
SET reco_estado = 'H'
GO

CREATE FUNCTION DATACENTER.get_id_viaje (@mic_patente nvarchar(255), @reco_cod numeric(18,0), @fecha_salida datetime, @fecha_lleg_estimada datetime, @fecha_llegada datetime)
RETURNS int
BEGIN
	RETURN (SELECT viaj_id
	FROM DATACENTER.Viaje
	WHERE viaj_mic_patente=@mic_patente AND viaj_reco_cod=@reco_cod AND viaj_fecha_salida=@fecha_salida AND viaj_fecha_lleg_estimada=@fecha_lleg_estimada AND viaj_fecha_llegada=@fecha_llegada)
END
GO

/*------------------------------------------------------------------*/
/*-------------------MIGRACION DE VIAJE-----------------------------*/
INSERT INTO DATACENTER.Viaje(viaj_mic_patente, viaj_reco_cod, viaj_fecha_salida, viaj_fecha_lleg_estimada, viaj_fecha_llegada)
	SELECT DISTINCT Micro_Patente, Recorrido_Codigo, FechaSalida, Fecha_LLegada_Estimada, FechaLLegada
	FROM gd_esquema.Maestra
GO

/*------------------------------------------------------------------*/
/*----------------MIGRACION COMPRA-----------------------------*/

INSERT INTO DATACENTER.Compra(comp_cant_pasajes, comp_cant_total_kg, comp_viaj_id, comp_comprador_dni, comp_costo_total, comp_fecha_compra, comp_codigo_pas_paq)
SELECT 1 AS cant_pasajes, Paquete_KG AS cant_total_kg, (
SELECT viaj_id
FROM DATACENTER.Viaje
WHERE viaj_mic_patente=Micro_Patente  AND viaj_reco_cod=Recorrido_Codigo AND viaj_fecha_salida=FechaSalida AND viaj_fecha_lleg_estimada=Fecha_LLegada_Estimada AND viaj_fecha_llegada=FechaLLegada
),
Cli_Dni AS comprador_Dni , Pasaje_Precio AS costo_total, Pasaje_FechaCompra AS fecha_compra, Pasaje_Codigo
FROM gd_esquema.Maestra
WHERE  Pasaje_Codigo<>0 --NOS REFERIMOS A PASAJES
UNION ALL --POR SI SE DA ALGUNA REPETICION ; "UNION" ME DEVUELVE LA UNION DE LAS CONSULTAS PERO SIN REPETICIONES (DISTINCT)
SELECT 0 AS cant_pasajes,Paquete_KG AS cant_total_kg, 
(SELECT viaj_id
FROM DATACENTER.Viaje
WHERE viaj_mic_patente=Micro_Patente  AND viaj_reco_cod=Recorrido_Codigo AND viaj_fecha_salida=FechaSalida AND viaj_fecha_lleg_estimada=Fecha_LLegada_Estimada AND viaj_fecha_llegada=FechaLLegada
),
Cli_Dni AS comprador_Dni, Paquete_Precio AS costo_total, Paquete_FechaCompra AS fecha_compra, Paquete_Codigo
FROM gd_esquema.Maestra
WHERE  Pasaje_Codigo=0 --NOS REFERIMOS A PAQUETE
GO 
/*------------------------------------------------------------------*/
/*---------------------MIGRACION BUTACA-----------------------------*/


INSERT INTO DATACENTER.Butaca(but_nro, but_mic_patente, but_tipo, but_piso) 
	SELECT DISTINCT  Butaca_Nro, Micro_Patente,  Butaca_Tipo, Butaca_Piso
	FROM gd_esquema.Maestra, DATACENTER.Micro
	WHERE Butaca_Tipo <> '0'  --PARA QUE NO REPITA LA BUTACA NRO 0 CUANDO ENVIAN ENCOMIENDAS
	ORDER BY Micro_Patente, Butaca_Nro
GO



/*------------------------------------------------------------------*/
/*----------------MIGRACION DE PASAJE-------------------------------*/
INSERT INTO DATACENTER.Pasaje(pas_cod, pas_nro_butaca, pas_micro_patente, pas_cli_dni, pas_compra_id, pas_precio, pas_viaj_id)
	SELECT M.Pasaje_Codigo, M.Butaca_Nro, M.Micro_Patente, M.Cli_Dni, C.comp_Id, M.Pasaje_Precio, C.comp_viaj_id
 	FROM gd_esquema.Maestra M join DATACENTER.Compra C on M.Cli_Dni = C.comp_comprador_Dni AND  C.comp_cant_pasajes = 1 AND C.comp_Codigo_Pas_Paq = M.Pasaje_Codigo
 	ORDER BY  Pasaje_Codigo, Cli_Dni, C.comp_Id
GO

/*------------------------------------------------------------------*/
/*---------------------MIGRACION DE PAQUETE-------------------------*/

INSERT INTO DATACENTER.Paquete (paq_cod, paq_comp_id, paq_precio, paq_kg, paq_viaj_id)
	SELECT comp_Codigo_Pas_Paq, comp_Id, comp_costo_Total, comp_cant_total_KG, comp_viaj_id
	FROM DATACENTER.Compra
	WHERE comp_cant_total_KG <> 0
GO



--Eliminamos columnas extras en COMPRA que fue utilizada para OPTIMIZAR la Migracion
ALTER TABLE DATACENTER.Compra
DROP COLUMN comp_codigo_pas_paq, comp_viaj_id
GO


/*-------------------------------------------------------------------*/
/*-------------------------STORED PROCEDURE--------------------------*/

CREATE PROCEDURE DATACENTER.update_cant_intentos_fallidos @usu_username nvarchar(255), @cant_intentos int
AS
BEGIN
	UPDATE DATACENTER.Usuario
	SET usu_cant_intentos = @cant_intentos
	WHERE usu_username = @usu_username
END
GO

CREATE PROCEDURE DATACENTER.insert_Rol(@rol_nombre nvarchar(255))
AS
BEGIN
		INSERT DATACENTER.Rol (rol_nombre, rol_estado)
		VALUES (@rol_nombre, 'H')
END
GO

CREATE PROCEDURE DATACENTER.insert_funcxrol (@id_rol int, @func_id int)
AS
BEGIN
	INSERT DATACENTER.FuncionalidadPorRol( fxrol_rol_id, fxrol_func_id, fxrol_estado)
	VALUES (@id_rol, @func_id, 'H')
END
GO

CREATE PROCEDURE DATACENTER.delete_funcxrol @rol_id int, @func_id int
AS
BEGIN
	DELETE DATACENTER.FuncionalidadPorRol
	WHERE fxrol_rol_id = @rol_id AND fxrol_func_id = @func_id
END
GO

CREATE PROCEDURE DATACENTER.delete_Rol @id_rol int
AS
BEGIN
	DELETE DATACENTER.FuncionalidadPorRol
	WHERE fxrol_rol_id= @id_rol

	DELETE DATACENTER.Rol
	WHERE rol_id = @id_rol
END
GO

CREATE PROCEDURE DATACENTER.update_rol @rol_id int, @rol_nombre nvarchar(255), @rol_estado char
AS
BEGIN
	UPDATE DATACENTER.Rol
	SET rol_nombre = @rol_nombre, rol_estado = @rol_estado
	WHERE rol_id = @rol_id
END
GO


CREATE PROCEDURE DATACENTER.get_listado_viaje @ciu_origen nvarchar(255), @ciu_destino nvarchar(255), @fecha_salida nvarchar(255)
AS
BEGIN
SELECT viaj_id,viaj_fecha_salida, reco_origen, reco_destino,serv_tipo, mic_cant_butacas + 1 -
(
	SELECT COUNT(pas_viaj_id)
	FROM DATACENTER.Pasaje
	WHERE pas_viaj_id = viaj_id
) AS butacas_Disponibles, mic_cant_kg_disponibles-
(
	SELECT isnull(SUM(paq_kg),0)
	FROM DATACENTER.Paquete
	WHERE paq_viaj_id = viaj_id
) AS kg_Disponibles
FROM DATACENTER.Viaje JOIN DATACENTER.Recorrido ON (viaj_reco_cod = reco_cod)
	 JOIN DATACENTER.Micro ON (mic_patente= viaj_mic_patente)
	 JOIN DATACENTER.Servicio ON (reco_serv_id= serv_id)
WHERE reco_origen = @ciu_origen AND reco_destino= @ciu_destino
	  AND DAY(viaj_fecha_salida) = DAY(@fecha_salida)
	  AND MONTH(viaj_fecha_salida) = MONTH(@fecha_salida)
	  AND YEAR(viaj_fecha_salida) = YEAR(@fecha_salida)
	  AND viaj_estado = 'H'
	   
END
GO

CREATE PROCEDURE DATACENTER.cargar_campos_cliente @cli_dni numeric(18,0)
AS
BEGIN 
	SELECT C.cli_nombre, C.cli_apellido, C.cli_dir, C.cli_telefono, C.cli_mail , C.cli_fecha_nac, C.cli_sexo, C.cli_discapacitado, C.cli_condicion
	FROM DATACENTER.Cliente C
	WHERE C.cli_dni = @cli_dni
END
GO

CREATE PROCEDURE DATACENTER.get_butacas @cod_viaje int
AS
BEGIN
SELECT but_nro AS Nro_Butaca, but_tipo AS Tipo, but_piso AS Nro_Piso
FROM DATACENTER.Viaje JOIN DATACENTER.Micro ON (viaj_mic_patente = mic_patente)
	 JOIN DATACENTER.Butaca ON (mic_patente = but_mic_patente)
WHERE viaj_id = @cod_viaje AND NOT but_nro IN (select pas_nro_butaca from DATACENTER.Pasaje where pas_viaj_id=@cod_viaje)
END

go

CREATE FUNCTION DATACENTER.estado_puntos(@inicio datetime, @fin datetime2)
RETURNS nvarchar(10)
AS
BEGIN
	DECLARE @estado nvarchar(10) = ''
	IF(DATEDIFF(DD,@inicio,@fin) <= 365)
	BEGIN
		SET @estado = 'VIGENTES'
	END
	ELSE
	BEGIN
		SET @estado = 'VENCIDOS'
	END
	RETURN @estado
END
GO


CREATE PROCEDURE DATACENTER.get_porcentaje @viaj_id int
AS
BEGIN
	SELECT reco_precio_base_pasaje+((serv_porc_adicional *reco_precio_base_pasaje)/ 100)
		   FROM DATACENTER.Recorrido JOIN DATACENTER.Viaje ON (reco_cod=viaj_reco_cod)
				JOIN DATACENTER.Servicio ON (reco_serv_id=serv_id)
		   WHERE viaj_id=@viaj_id
END
GO

CREATE PROCEDURE DATACENTER.insert_Cliente @cli_dni numeric(18,0),@cli_nombre nvarchar(255), @cli_apellido nvarchar(255), @cli_dir nvarchar(255), @cli_telefono nvarchar(255), @cli_mail nvarchar(255), @cli_fecha_nac nvarchar(255), @cli_sexo nvarchar(5), @discapacitado nvarchar(5), @condicion nvarchar(5)
AS
BEGIN

	INSERT DATACENTER.Cliente (cli_dni, cli_rol_id, cli_nombre, cli_apellido, cli_dir, cli_telefono, cli_mail, cli_fecha_nac, cli_puntos_acum,  cli_sexo, cli_discapacitado)
	VALUES (@cli_dni,2,@cli_nombre,@cli_apellido, @cli_dir, @cli_telefono,@cli_mail, convert(datetime,@cli_fecha_nac), 0,convert (char, @cli_sexo), CONVERT(char, @discapacitado))
	
END
GO

CREATE PROCEDURE DATACENTER.update_Cliente @cli_dni numeric(18,0),@cli_nombre nvarchar(255), @cli_apellido nvarchar(255), @cli_dir nvarchar(255), @cli_telefono nvarchar(255), @cli_mail nvarchar(255), @cli_fecha_nac nvarchar(255), @cli_sexo nvarchar(5), @discapacitado nvarchar(5), @condicion nvarchar (5)
AS
BEGIN
	
	UPDATE DATACENTER.Cliente
	SET cli_nombre = @cli_nombre, cli_apellido=@cli_apellido, cli_dir=@cli_dir, cli_telefono=@cli_telefono, cli_mail=@cli_mail, cli_fecha_nac=convert(datetime,@cli_fecha_nac), cli_sexo=convert (char, @cli_sexo), cli_discapacitado = convert (char, @discapacitado), cli_condicion = convert(char, @condicion)
	WHERE cli_dni=@cli_dni
END
GO

CREATE PROCEDURE DATACENTER.get_costo_encomienda @viaj_id int, @paq_kg nvarchar(255)
AS
BEGIN
	SELECT reco_precio_base_kg * convert(numeric(18,0),@paq_kg)
		   FROM DATACENTER.Recorrido JOIN DATACENTER.Viaje ON (reco_cod=viaj_reco_cod)
		   WHERE viaj_id=@viaj_id
END
GO

CREATE PROCEDURE DATACENTER.get_kg_disponibles @viaj_id int
AS
BEGIN
	SELECT mic_cant_kg_disponibles - (select SUM (paq_kg) from DATACENTER.Paquete where paq_viaj_id = @viaj_id)
	FROM  DATACENTER.Viaje JOIN DATACENTER.Micro ON (mic_patente=viaj_mic_patente)
	WHERE viaj_id= @viaj_id
END
GO

CREATE PROCEDURE DATACENTER.check_tipo_tarjeta @tipo_id int
AS
BEGIN
	SELECT tipo_cuotas 
	FROM DATACENTER.TipoTarjeta 
	WHERE tipo_id = @tipo_id
END
GO

CREATE PROCEDURE DATACENTER.insert_compra (@comprador_dni numeric(18,0), @tipo_tarj_id int, @cant_pasajes int, @cant_total_kg numeric(18,0), @costo_total numeric(18,2), @fecha_actual datetime)
AS
BEGIN 
	IF (@tipo_tarj_id = 0)
	BEGIN
		INSERT INTO DATACENTER.Compra(comp_comprador_dni,comp_cant_pasajes, comp_cant_total_kg,comp_costo_total,  comp_fecha_compra)
		VALUES
		(@comprador_dni, @cant_pasajes, @cant_total_kg,@costo_total, @fecha_actual)
	END
	ELSE
	BEGIN
		INSERT INTO DATACENTER.Compra(comp_comprador_dni, comp_tipo_tarj_id, comp_cant_pasajes, comp_cant_total_kg,comp_costo_total,  comp_fecha_compra)
		VALUES
		(@comprador_dni, @tipo_tarj_id, @cant_pasajes, @cant_total_kg,@costo_total, @fecha_actual)
	END
	SELECT @@IDENTITY AS Id_compra_Ingresado
END
GO

CREATE PROCEDURE DATACENTER.insert_pasaje(@nro_butaca numeric(18,0),@micro_patente nvarchar(255), @cli_dni numeric(18,0), @pas_compra int, @pas_precio numeric(18,2), @viaj_id int)
AS
BEGIN 
	DECLARE @pas_codigo numeric(18,0)
	SET @pas_codigo = (SELECT MAX(pas_cod) FROM DATACENTER.Pasaje) + 1
	INSERT INTO 
	DATACENTER.Pasaje(pas_cod,pas_nro_butaca,pas_micro_patente, pas_cli_dni, pas_compra_id, pas_precio, pas_viaj_id)	
	VALUES
	(@pas_codigo, @nro_butaca,@micro_patente, @cli_dni, @pas_compra, @pas_precio, @viaj_id)
	
	SELECT @pas_codigo
END
GO

CREATE PROCEDURE DATACENTER.get_micro_patente (@viaje_id int)
AS
BEGIN
	SELECT viaj_mic_patente
	FROM DATACENTER.Viaje
	WHERE viaj_id = @viaje_id
END
GO

CREATE PROCEDURE DATACENTER.insert_paquete (@comp_id int, @precio numeric(18,2), @paq_kg numeric(18,0), @viaj_id int)
AS
BEGIN 
	DECLARE @paquete_cod numeric(18,0)
	SET @paquete_cod = (SELECT MAX(paq_cod) FROM DATACENTER.Paquete) + 1
	INSERT INTO 
	DATACENTER.Paquete(paq_cod, paq_comp_id, paq_precio, paq_kg, paq_viaj_id)	
	VALUES
	(@paquete_cod , @comp_id, @precio, @paq_kg, @viaj_id)	
	
	SELECT @paquete_cod
END
GO

create function DATACENTER.totalPuntosVencidos(@dni numeric(18,0), @FECHA_SISTEMA DATETIME)--AGREGADA LA FECHA DEL SISTEMA
returns int
as
begin
	return (select isnull(sum(cast(round(p.paq_precio/5,0) as numeric(18,0))),0) 
			from DATACENTER.Paquete p join DATACENTER.Arribo a 
			on a.arri_viaj_id = p.paq_viaj_id join DATACENTER.Compra c on c.comp_id = p.paq_comp_id and c.comp_comprador_dni = @dni join DATACENTER.Viaje v 
			on v.viaj_id = a.arri_viaj_id 
			WHERE DATACENTER.estado_puntos(A.arri_fecha_llegada, @FECHA_SISTEMA) = 'VENCIDOS')
			+
			(SELECT ISNULL(SUM(cast(round((p.pas_precio/5),0) as numeric(18,0))),0) 
			FROM DATACENTER.Arribo a JOIN DATACENTER.Pasaje p 
			ON p.pas_viaj_id = a.arri_viaj_id and p.pas_cli_dni = @dni 
			WHERE DATACENTER.estado_puntos(A.arri_fecha_llegada, @FECHA_SISTEMA) = 'VENCIDOS')			
end


go

create function DATACENTER.totalPuntos(@dni numeric(18,0))
returns int
begin
	return	((select isnull(sum(cast(round(p.paq_precio/5,0) as numeric(18,0))),0) 
			from DATACENTER.Paquete p join DATACENTER.Arribo a 
			on a.arri_viaj_id = p.paq_viaj_id join DATACENTER.Compra c on c.comp_id = p.paq_comp_id and c.comp_comprador_dni = @dni join DATACENTER.Viaje v 
			on v.viaj_id = a.arri_viaj_id 
			)
			+
			(SELECT ISNULL(SUM(cast(round((p.pas_precio/5),0) as numeric(18,0))),0) 
			FROM DATACENTER.Arribo a JOIN DATACENTER.Pasaje p 
			ON p.pas_viaj_id = a.arri_viaj_id and p.pas_cli_dni = @dni
			))
end
go

create procedure DATACENTER.update_fecha_llegada(@fecha datetime, @viaje int)
as
begin
	update DATACENTER.Viaje
	set viaj_fecha_llegada = @fecha
	where viaj_id = @viaje
end

go

create procedure DATACENTER.registrarPuntos(@viajeId int)
as
begin	
	update DATACENTER.Cliente
	set cli_puntos_acum += ((select isnull(sum(cast(round(p.paq_precio/5,0) as numeric(18,0))),0) 
															from DATACENTER.Paquete p join DATACENTER.Arribo a 
															on a.arri_viaj_id = p.paq_viaj_id join DATACENTER.Compra c 
															on c.comp_id = p.paq_comp_id and c.comp_comprador_dni = cli_dni join DATACENTER.Viaje v 
															on v.viaj_id = a.arri_viaj_id 
															where v.viaj_id = @viajeId)			
															+
															(SELECT ISNULL(SUM(cast(round((p.pas_precio/5),0) as numeric(18,0))),0) 
															FROM DATACENTER.Arribo a JOIN DATACENTER.Pasaje p 
															ON p.pas_viaj_id = a.arri_viaj_id and p.pas_cli_dni = cli_dni
															where a.arri_viaj_id = @viajeId))
	where cli_dni in (
				select distinct p.pas_cli_dni
				from DATACENTER.Pasaje p join DATACENTER.Arribo a 
				on a.arri_viaj_id = p.pas_viaj_id and a.arri_viaj_id = @viajeId				
				union all
				select distinct c.cli_dni
				from DATACENTER.Cliente c join DATACENTER.Compra co 
				on co.comp_comprador_dni = c.cli_dni join DATACENTER.Paquete pa
				on pa.paq_comp_id = co.comp_id join DATACENTER.Arribo a
				on a.arri_viaj_id = pa.paq_viaj_id and a.arri_viaj_id = @viajeId
				)
end
go

create procedure DATACENTER.actualizarPuntos(@dni numeric(18,0), @FECHA_SISTEMA datetime)
as
begin
	update DATACENTER.Cliente
	set cli_puntos_acum = ((select DATACENTER.totalPuntos(@dni))-(select DATACENTER.totalPuntosVencidos(@dni, @FECHA_SISTEMA)))
	where cli_dni = @dni
end

go 

--ESTE TRIGGER ES PARA EL PUNTO 8 "REGISTRO DE LLEGADA A DESTINO"
--PARA TODOS LOS CLIENTES QUE VIAJARON O MANDARON ENCOMIENDAS, LES ACUMULA LOS PUNTOS POR ESE VIAJE
create trigger DATACENTER.llegadaADestino
on DATACENTER.Arribo
after insert
as
begin
	declare @fechaLlegada datetime = '', @patente nvarchar(255) = '', @viaje int = 0, @destino nvarchar(255) = ''
	declare @fetch int = 0
	declare cur cursor
	for select i.arri_fecha_llegada, i.arri_mic_patente, i.arri_viaj_id, i.arri_ciu_arribada from inserted i
	OPEN cur
	FETCH CUR INTO @fechaLlegada, @patente, @viaje, @destino
	SET @fetch = @@FETCH_STATUS
	while @fetch = 0
	begin
		exec DATACENTER.update_fecha_llegada @fechaLlegada, @viaje		
		exec DATACENTER.registrarPuntos @viaje
		FETCH CUR INTO @fechaLlegada, @patente, @viaje, @destino
		SET @fetch = @@FETCH_STATUS
	end
	close cur
	deallocate cur
end

go



create function DATACENTER.verificaStock(@premNombre nvarchar(255), @premCantidad int)
returns int
begin
	declare @stockActual int
	set @stockActual=(select prem_stock from DATACENTER.Premio where prem_nombre=@premNombre)
	return abs(@stockActual-@premCantidad)
end
go


create procedure DATACENTER.canjeaPremio(@premNombre nvarchar(255),@dniCliente numeric(18,0),@nuevoStock int,@premCantidad int,@idCanjeNuevo int,@fechaSist datetime)
as
begin
	declare @idPremio int
	set @idPremio= (select prem_id from DATACENTER.Premio where prem_nombre=@premNombre)

	UPDATE DATACENTER.Premio
	SET prem_stock=@nuevoStock
	where prem_nombre=@premNombre

	INSERT INTO DATACENTER.Canje(canj_id,canj_cli_dni,canj_prem_id,canj_cant_retirada,canj_fecha)
	VALUES (@idCanjeNuevo,@dniCliente,@idPremio,@premCantidad,@fechaSist)
end
go


create function DATACENTER.microDisponible(@patente nvarchar(255), @fechaFS datetime, @fechaR datetime)
returns nvarchar(255)
begin
	declare @micMarcaId int
	declare @micServId int
	declare @micCantButacas int
	set @micMarcaId = (select mic_marc_id from DATACENTER.Micro where mic_patente=@patente)
	set @micServId = (select mic_serv_id from DATACENTER.Micro where mic_patente=@patente)
	set @micCantButacas = (select mic_cant_butacas from DATACENTER.Micro where mic_patente=@patente)
	
	declare cursorPatentes cursor
	for select mic_patente,viaj_fecha_salida,viaj_fecha_lleg_estimada from DATACENTER.Micro join DATACENTER.Viaje on (mic_patente=viaj_mic_patente) where viaj_estado='H' and mic_patente<>@patente and mic_marc_id=@micMarcaId and mic_serv_id=@micServId and mic_cant_butacas>=@micCantButacas
	open cursorPatentes
	declare @ocupado int
	set @ocupado=0
	declare @patenteMicro nvarchar(255)
	declare @viajFechaSalida datetime
	declare @viajFechaLlegEstim datetime
	fetch cursorPatentes into @patenteMicro,@viajFechaSalida,@viajFechaLlegEstim
	declare @microDisponible nvarchar(255)
	set @microDisponible = @patenteMicro
	declare @microEncontrado nvarchar(255)
	set @microEncontrado = ''
	
	if (@fechaR<>null)
	begin
	while (@@FETCH_STATUS = 0)
	begin
		if ((@viajFechaSalida between @fechaFS and @fechaR) and (@viajFechaLlegEstim between @fechaFS and @fechaR))
			set @ocupado=1;
		
		fetch cursorPatentes into @patenteMicro,@viajFechaSalida,@viajFechaLlegEstim
		if (@@FETCH_STATUS <> 0)
			break
		if (@patenteMicro<>@microDisponible and @ocupado=0)
		begin
			set @microEncontrado=@microDisponible
			break
		end
		else
		begin
			if(@patenteMicro<>@microDisponible)
			set @microDisponible=@patenteMicro
		end
	end
	end
	else
	begin
	while (@@FETCH_STATUS = 0)
	begin
		if (@viajFechaLlegEstim > @fechaFS)
			set @ocupado=1;
		
		fetch cursorPatentes into @patenteMicro,@viajFechaSalida,@viajFechaLlegEstim
		if (@@FETCH_STATUS <> 0)
			break
		if (@patenteMicro<>@microDisponible and @ocupado=0)
		begin
			set @microEncontrado=@microDisponible
			break
		end
		else
		begin
			if(@patenteMicro<>@microDisponible)
			set @microDisponible=@patenteMicro
		end
	end
	
	end
	
	close cursorPatentes
	deallocate cursorPatentes
	return @microEncontrado
end
go


create procedure DATACENTER.registrarNuevoMicro(@patenteNueva nvarchar(255),@patenteAReemplazar nvarchar(255),@fechaSist datetime)
as
begin
	declare @micMarcaId int
	declare @micServId int
	declare @micCantButacas int
	declare @micCantKg int
	declare @micModelo nvarchar(255)
	
	set @micMarcaId = (select mic_marc_id from DATACENTER.Micro where mic_patente=@patenteAReemplazar)
	set @micServId = (select mic_serv_id from DATACENTER.Micro where mic_patente=@patenteAReemplazar)
	set @micCantButacas = (select mic_cant_butacas from DATACENTER.Micro where mic_patente=@patenteAReemplazar)
	set @micCantKg = (select mic_cant_kg_disponibles from DATACENTER.Micro where mic_patente=@patenteAReemplazar)
	set @micModelo = (select mic_modelo from DATACENTER.Micro where mic_patente=@patenteAReemplazar)
	
	INSERT INTO DATACENTER.Micro(mic_patente,mic_marc_id,mic_serv_id,mic_cant_butacas,mic_cant_kg_disponibles,mic_modelo,mic_fecha_alta,mic_fecha_baja_def)
	VALUES (@patenteNueva,@micMarcaId,@micServId,@micCantButacas,@micCantKg,@micModelo,@fechaSist,null)
end
go


create function DATACENTER.estadoBaja(@fechaBajaNueva datetime,@patente nvarchar(255))
returns int
begin
	declare @baja int
	set @baja = 0
	declare @fechaBajaMicro datetime
	set @fechaBajaMicro = (SELECT mic_fecha_baja_def from DATACENTER.Micro where mic_patente=@patente)
	if (year(@fechaBajaMicro)<year(@fechaBajaNueva)) and (month(@fechaBajaMicro)<month(@fechaBajaNueva)) and day(@fechaBajaMicro)<day(@fechaBajaNueva)
		set @baja=1
	return @baja
end
go

create procedure DATACENTER.registraDevolucionParcial(@fechaDev nvarchar(255),@nroCompra int,@tipoItem nvarchar(255),@codItem numeric(18,0),@motivoDev nvarchar(255))
as
begin
	declare @ultimoIdDev int
	declare @idDev int
	set @idDev = 1;
	if ((select COUNT(*) from DATACENTER.Devolucion where dev_comp_id=@nroCompra) = 0)
	begin
		set @ultimoIdDev = (select max(dev_id) from DATACENTER.Devolucion)
		if @ultimoIdDev <> null
			set @idDev = @ultimoIdDev + 1			
	end
	else
		set @idDev = (select top 1 dev_id from DATACENTER.Devolucion where dev_comp_id=@nroCompra)
	
	-- Agrego devolucin efectiva
	INSERT INTO DATACENTER.Devolucion(dev_id,dev_cod_PasPaq,dev_tipo_devuelto,dev_comp_id,dev_fecha,dev_motivo)
	VALUES (@idDev,@codItem,@tipoItem,@nroCompra,CONVERT(datetime,@fechaDev,121) ,@motivoDev)
	
	-- Actualizo el costo total de la compra y la cantidad de pasajes y total de kg
	declare @costoTotal numeric(18,2)
	set @costoTotal = (select comp_costo_total from DATACENTER.Compra where comp_id=@nroCompra)
	declare @montoADescontar numeric(18,2)
	
	if (@tipoItem = 'Pasaje')
	begin
		set @montoADescontar = (select pas_precio from DATACENTER.Pasaje where pas_compra_id=@nroCompra and pas_cod=@codItem)
		declare @cantPasajes int
		set @cantPasajes = (select comp_cant_pasajes from DATACENTER.Compra where comp_id=@nroCompra)
		set @cantPasajes = @cantPasajes - 1
		set @costoTotal = (select comp_costo_total from DATACENTER.Compra where comp_id=@nroCompra)
		set @costoTotal = @costoTotal - @montoADescontar
		
		UPDATE DATACENTER.Compra
		SET comp_cant_pasajes=@cantPasajes, comp_costo_total=@costoTotal
		where comp_id=@nroCompra
		
		--DELETE FROM DATACENTER.Pasaje
		--where pas_compra_id=@nroCompra and pas_cod=@codItem
	end
	else
	begin
		set @montoADescontar = (select paq_precio from DATACENTER.Paquete where paq_comp_id=@nroCompra and paq_cod=@codItem)
		set @costoTotal = (select comp_costo_total from DATACENTER.Compra where comp_id=@nroCompra)
		set @costoTotal = @costoTotal - @montoADescontar
		
		UPDATE DATACENTER.Compra
		SET comp_cant_total_kg=0, comp_costo_total=@costoTotal
		where comp_id=@nroCompra
		
		--DELETE FROM DATACENTER.Paquete
		--where paq_comp_id=@nroCompra and paq_cod=@codItem
	end

end
go


create procedure DATACENTER.registraDevolucionTotal(@fechaDev nvarchar(255),@nroCompra int,@motivoDev nvarchar(255))
as
begin
	declare @tipoItem nvarchar(255)
	declare @codItem numeric(18,0)
	declare cursorItems cursor
	for (
		(select 'Paquete', paq_cod
		 from DATACENTER.Paquete 
		 where paq_comp_id=@nroCompra)
		union
		(select 'Pasaje', pas_cod
		 from DATACENTER.Pasaje
		 where pas_compra_id=@nroCompra)
	)
	open cursorItems
	fetch cursorItems into @tipoItem,@codItem
	while (@@FETCH_STATUS = 0)
	begin
		exec DATACENTER.registraDevolucionParcial @fechaDev,@nroCompra,@tipoItem,@codItem,@motivoDev
		fetch cursorItems into @tipoItem,@codItem
	end
	close cursorItems
	deallocate cursorItems
end
go


create procedure DATACENTER.cancelaViajesXMicro(@patente nvarchar(255),@fechaFS datetime, @fechaR datetime, @fechaSist datetime)
as
begin
	declare @nroCompra int
	declare @tipoItem nvarchar(255)
	declare @codItem numeric(18,0)
	declare @motivoDev nvarchar(255)
	set @motivoDev='Se cancela el viaje por baja de micro.'

	if (@fechaR <> null)
	begin --Trata los casos de BAJAS DEFINITIVAS
		declare cursorViajes cursor
		for (
			(select paq_comp_id,'Paquete'
			 from DATACENTER.Viaje join DATACENTER.Paquete on (viaj_id=paq_viaj_id)
			 where viaj_mic_patente=@patente and viaj_estado='H' and ((viaj_fecha_salida between @fechaFS and @fechaR) or (viaj_fecha_lleg_estimada between @fechaFS and @fechaR)))
			union
			(select pas_compra_id,'Pasaje'
			 from DATACENTER.Viaje join DATACENTER.Pasaje on (viaj_id=pas_viaj_id)
			 where viaj_mic_patente=@patente and viaj_estado='H' and ((viaj_fecha_salida between @fechaFS and @fechaR) or (viaj_fecha_lleg_estimada between @fechaFS and @fechaR)))

			) 
	end
	else
	begin -- Trata los casos de BAJA POR FUERA DE SERIVICIO
		declare cursorViajes cursor
		for (
			(select paq_comp_id,'Paquete'
			 from DATACENTER.Viaje join DATACENTER.Paquete on (viaj_id=paq_viaj_id)
			 where viaj_mic_patente=@patente and viaj_estado='H' and ((viaj_fecha_salida > @fechaFS) or (viaj_fecha_lleg_estimada > @fechaFS)))
			union
			(select pas_compra_id,'Pasaje'
			 from DATACENTER.Viaje join DATACENTER.Pasaje on (viaj_id=pas_viaj_id)
			 where viaj_mic_patente=@patente and viaj_estado='H' and ((viaj_fecha_salida > @fechaFS) or (viaj_fecha_lleg_estimada > @fechaFS)))
			) 	
	end
			
	open cursorViajes
	fetch cursorViajes into @nroCompra,@tipoItem
	while (@@FETCH_STATUS = 0)
	begin
		exec DATACENTER.registraDevolucionParcial @fechaSist,@nroCompra,@tipoItem,@motivoDev
		fetch cursorViajes into @nroCompra,@tipoItem
	end

	close cursorViajes
	deallocate cursorViajes
end
go
CREATE FUNCTION DATACENTER.fechaInicioSemestre(@anio nvarchar(6),@semestre int)
returns datetime
begin
	declare @fecha datetime = ''
	if(@semestre = 1)
	begin
		set @fecha = @anio+'01'+'01'
	end
	else
	begin
		set @fecha = @anio+'07'+'01'
	end
	return @fecha
end

go

CREATE FUNCTION DATACENTER.fechaFinSemestre(@anio nvarchar(6), @semestre int)
returns datetime
begin
	declare @fecha datetime = ''
	if(@semestre = 1)
	begin
		set @fecha = @anio+'06'+'30'
	end
	else
	begin
		set @fecha = @anio+'12'+'31'
	end
	return @fecha
end
go

create function DATACENTER.puntosParaSemestre(@anio nvarchar(6),@semestre int, @dni numeric(18,0))
returns int
begin
	return	(select isnull(sum(cast(round(p.paq_precio/5,0) as numeric(18,0))),0) 
			from DATACENTER.Paquete p join DATACENTER.Arribo a 
			on a.arri_viaj_id = p.paq_viaj_id join DATACENTER.Compra c on c.comp_id = p.paq_comp_id and c.comp_comprador_dni = @dni join DATACENTER.Viaje v 
			on v.viaj_id = a.arri_viaj_id and v.viaj_fecha_llegada between DATACENTER.fechaInicioSemestre(@anio, @semestre) and DATACENTER.fechaFinSemestre(@anio, @semestre)
			)
			+
			(SELECT ISNULL(SUM(cast(round((p.pas_precio/5),0) as numeric(18,0))),0) 
			FROM DATACENTER.Arribo a JOIN DATACENTER.Pasaje p 
			ON p.pas_viaj_id = a.arri_viaj_id and p.pas_cli_dni = @dni and a.arri_fecha_llegada between DATACENTER.fechaInicioSemestre(@anio, @semestre) and DATACENTER.fechaFinSemestre(@anio, @semestre)
			)
end

go
--PARA EL TOP 5 MICROS CON DIAS FUERA DE SERVICIO. ESTABLECE SI LAS FECHAS CAEN EN EL SEMESTRE PARA SUMAR LOS DIAS
create function DATACENTER.sumaDias(@fuera datetime, @reinicio datetime, @inicioSemestre datetime, @finSemestre datetime)
returns bit
begin
	declare @condicion bit = 1 -- 1 verdadero (suma dias), 0 es falso (no suma)
	if((@fuera is null) or (@fuera > @finSemestre) or (@reinicio < @inicioSemestre))
	begin
		set @condicion = 0
		return @condicion
	end
	if((@fuera < @inicioSemestre) and (@reinicio is null))
	begin
		set @condicion = 1
		return @condicion
	end
	if((@fuera < @inicioSemestre) and (@reinicio <= @finSemestre))
	begin
		set @condicion = 1
		return @condicion
	end
	if((@fuera >= @inicioSemestre) and (@reinicio >= @finSemestre))
	begin
		set @condicion = 1
		return @condicion
	end
	if((@fuera >= @inicioSemestre) and (@reinicio <= @finSemestre))
	begin
		set @condicion = 1
		return @condicion
	end
	if((@fuera <= @inicioSemestre) and (@reinicio >= @finSemestre))
	begin
		set @condicion = 1
		return @condicion
	end
	return @condicion
end

go

--SUMO LOS DIAS QUE ESTUVO FUERA DE SERVICIO
create function DATACENTER.diasFueraDeServicio(@fuera datetime, @reinicio datetime, @inicioSemestre datetime, @finSemestre datetime, @FECHA_SISTEMA DATETIME)
returns int
begin
	declare @dias int = 0
	if((@fuera <= @inicioSemestre)and (@reinicio is null))
	begin
		set @dias = datediff(d,@inicioSemestre, @FECHA_SISTEMA)
		return @dias
	end
	if((@fuera <= @inicioSemestre) and (@reinicio >= @finSemestre))
	begin
		set @dias = datediff(d,@inicioSemestre, @finSemestre)
		return @dias
	end
	if((@fuera <= @inicioSemestre) and (@reinicio <= @finSemestre))
	begin
		set @dias = datediff(d,@inicioSemestre,@reinicio)
		return @dias
	end
	if((@fuera >= @inicioSemestre) and (@reinicio >= @finSemestre))
	begin
		set @dias = datediff(d,@fuera, @finSemestre)
		return @dias
	end
	if((@fuera >= @inicioSemestre) and (@reinicio <= @finSemestre))
	begin
		set @dias = datediff(d,@fuera, @reinicio)
	end
	return @dias
end

GO

/*-------------------------------------------------------------------*/
/*-------------------------STORED PROCEDURE (MATI)--------------------------*/
CREATE PROCEDURE DATACENTER.insert_recorrido @cod numeric(18,0), @orig nvarchar(255), @dest nvarchar(255), @serv int, @pr_pas numeric(18,2), @pr_enco numeric(18,2)
AS
BEGIN
  DECLARE @est CHAR
  SET @est = 'H'
  INSERT INTO DATACENTER.Recorrido (reco_cod, reco_serv_id, reco_origen, reco_destino, reco_precio_base_pasaje, reco_precio_base_kg, reco_estado)
  VALUES ( @cod, @serv, @orig, @dest, @pr_pas, @pr_enco, @est)
END
GO

/*-------------------------------------------------------------------*/
/*-------------------------STORED PROCEDURE (MATI)--------------------------*/

CREATE PROCEDURE DATACENTER.update_recorrido @cod numeric(18,0), @orig nvarchar(255), @dest nvarchar(255), @serv int, @pr_pas numeric(18,2), @pr_enco numeric(18,2)
AS
BEGIN

  DECLARE @precio_pas NUMERIC(18,2),
          @precio_enco NUMERIC(18,2)

  UPDATE DATACENTER.Recorrido
  SET reco_origen = @orig, reco_destino = @dest, reco_serv_id = @serv, reco_precio_base_pasaje = @pr_pas, reco_precio_base_kg = @pr_enco
  WHERE reco_cod = @cod
 
  SELECT @precio_pas = reco_precio_base_pasaje, @precio_enco = reco_precio_base_kg
  FROM DATACENTER.Recorrido
  WHERE reco_cod = @cod
  
 
  IF @precio_pas <> @pr_pas
  UPDATE DATACENTER.Recorrido
  SET reco_precio_base_pasaje = @pr_pas
  WHERE reco_cod = @cod
  
  IF @precio_enco <> @pr_enco
  UPDATE DATACENTER.Recorrido
  SET reco_precio_base_kg = @pr_enco
  WHERE reco_cod = @cod
  
  
END
GO

/*-------------------------------------------------------------------*/
/*-------------------------STORED PROCEDURE (MATI)--------------------------*/
CREATE PROCEDURE DATACENTER.update_estado_reco @cod NUMERIC(18,0), @estado_reco CHAR, @fechaSist NVARCHAR(255)
AS
BEGIN

  UPDATE DATACENTER.Recorrido
  SET reco_estado = @estado_reco
  WHERE reco_cod = @cod
  
  DECLARE @fechaHoy DATETIME
  SET @fechaHoy = CONVERT(DATETIME, @fechaSist, 121)
  
  DECLARE @tipo_item_pas NVARCHAR(255)
  SET @tipo_item_pas = 'Pasaje'
  
  
  DECLARE @tipo_item_paq NVARCHAR(255)
  SET @tipo_item_paq = 'Paquete'
  
  DECLARE @motivo NVARCHAR(255)
  SET @motivo = 'Baja de recorrido'
  
  DECLARE @compra_id INT
  DECLARE @pas_cod NUMERIC(18,0)
  DECLARE cur_viaj_pas CURSOR
  FOR (SELECT pas_compra_id, pas_cod
       FROM DATACENTER.viaje JOIN DATACENTER.Pasaje ON pas_viaj_id = viaj_id
       WHERE viaj_estado <> 'D' AND viaj_reco_cod = @cod AND viaj_fecha_salida >= @fechaHoy)
       
  OPEN cur_viaj_pas
  
  FETCH FROM cur_viaj_pas
  INTO @compra_id, @pas_cod

  WHILE @@FETCH_STATUS = 0
    BEGIN
      EXEC DATACENTER.registraDevolucionParcial @fechaHoy, @compra_id, @tipo_item_pas, @pas_cod, @motivo
      FETCH FROM cur_viaj_pas
      INTO @compra_id, @pas_cod
    END
  
  CLOSE cur_viaj_pas
  DEALLOCATE cur_viaj_pas
  
  
  DECLARE @paq_cod NUMERIC(18,0)
  DECLARE cur_viaj_paq CURSOR
  FOR (SELECT paq_comp_id, paq_cod
       FROM DATACENTER.viaje JOIN DATACENTER.Paquete ON paq_viaj_id = viaj_id
       WHERE viaj_estado <> 'D' AND viaj_reco_cod = @cod AND viaj_fecha_salida >= @fechaHoy)
       
  OPEN cur_viaj_paq
  
  FETCH FROM cur_viaj_paq
  INTO @compra_id, @paq_cod

  WHILE @@FETCH_STATUS = 0
    BEGIN
      EXEC DATACENTER.registraDevolucionParcial @fechaHoy, @compra_id, @tipo_item_paq, @paq_cod, @motivo
      FETCH FROM cur_viaj_paq
      INTO @compra_id, @paq_cod
    END
  
  CLOSE cur_viaj_paq
  DEALLOCATE cur_viaj_paq
  
  UPDATE DATACENTER.Viaje
  SET viaj_estado = 'D'
  WHERE viaj_estado <> 'D' AND viaj_reco_cod = @cod AND viaj_fecha_salida >= @fechaHoy
  
END
GO

/*-------------------------------------------------------------------*/
/*-------------------------STORED PROCEDURE (MATI)--------------------------*/ 
CREATE PROCEDURE DATACENTER.habilitar_estado_reco @cod NUMERIC(18,0), @estado_reco CHAR
AS
BEGIN

  UPDATE DATACENTER.Recorrido
  SET reco_estado = @estado_reco
  WHERE reco_cod = @cod

END
GO -- NUEVOOOOOOOOO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

/*-------------------------------------------------------------------*/
/*-------------------------STORED PROCEDURE (MATI)--------------------------*/
CREATE PROCEDURE DATACENTER.insert_viaje @fecha_sal DATETIME, @fecha_lleg DATETIME, @cod_reco NUMERIC(18,0), @patente NVARCHAR (255)
AS
BEGIN

INSERT INTO DATACENTER.Viaje (viaj_mic_patente, viaj_reco_cod, viaj_fecha_salida, viaj_fecha_lleg_estimada)
VALUES (@patente, @cod_reco, @fecha_sal, @fecha_lleg)

END
GO

/*-------------------------------------------------------------------*/
/*-------------------------TRIGGER (MATI)--------------------------*/
CREATE TRIGGER DATACENTER.act_precio_reco
ON DATACENTER.Recorrido
AFTER UPDATE
AS
BEGIN

  DECLARE @cod NUMERIC (18,0)
  DECLARE @origen NVARCHAR(255)
  DECLARE @destino NVARCHAR (255)
  DECLARE @precio_pasa NUMERIC (18,2)
  DECLARE @precio_enco NUMERIC (18,2)

  SELECT @cod = reco_cod, @origen = reco_origen, @destino = reco_destino, @precio_pasa = reco_precio_base_pasaje, @precio_enco = reco_precio_base_kg
  FROM inserted

  IF UPDATE(reco_precio_base_pasaje)
  BEGIN
    UPDATE DATACENTER.Recorrido
    SET reco_precio_base_pasaje = @precio_pasa
    WHERE reco_origen = @origen AND reco_destino = @destino AND reco_cod <> @cod 
  END
  
  IF UPDATE(reco_precio_base_kg)
  BEGIN
    UPDATE DATACENTER.Recorrido
    SET reco_precio_base_kg = @precio_enco
    WHERE reco_origen = @origen AND reco_destino = @destino AND reco_cod <> @cod 
  END

END
GO

/*------------------------AGREGADO PARA LA ACTUALIZACION DE FECHA DE ALTA DE MICRO --------------------*/
CREATE PROCEDURE DATACENTER.update_fecha_alta_micro (@fecha_alta nvarchar(255))
AS
BEGIN
	--Verificamos si alguna fecha de alta es null de serlo actualizamos
	IF (select count(mic_patente) from DATACENTER.Micro where  mic_fecha_alta IS NULL ) != 0
	BEGIN
			UPDATE DATACENTER.Micro
			SET mic_fecha_alta = CONVERT(datetime, @fecha_alta, 121)
	END
END
