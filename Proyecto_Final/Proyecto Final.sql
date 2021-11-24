

CREATE DATABASE  empresaxyz;
use empresaxyz;
CREATE TABLE  usuarios
(

)

CREATE  TABLE personas
(
id_persona INT IDENTITY PRIMARY KEY ,
nombre VARCHAR (50) ,
apellido VARCHAR (50) ,
ci VARCHAR (25) NOT NULL ,
telefono VARCHAR (20),
usuario VARCHAR (25) ,
contrasena VARCHAR(25) ,
login INT
);

DROP TABLE  personas
CREATE TABLE productos
(

);
select *
from usuarios;

use empresaxyz;

INSERT INTO personas (nombre, apellido, CI, telefono, usuario, contrasena, login) VALUES  ('José Félix','Sarmiento Mamani','9119638','60580189','Felicks','36541',1)
                        "'nom'","'ape'","'ci'", "'tel'", "'user'", "'contra'", "'log'"

INSERT INTO personas VALUES ('Antonio', 'Garcia', '541238', '78453215', 'garcia', '4444', 0;

INSERT INTO personasPrueba ()

SELECT Count(*)
FROM personas
WHERE usuario = 'Felicks'
  AND contrasena = '36541'
  AND login = 1;


INSERT  INTO usuarioPrueba (usuario, contrasena, login, ci) VALUES  ('Felicks','123',1,'9119638')


DELETE usuarioPrueba from usuarioPrueba WHERE  ci='9119638'

UPDATE personas
SET nombre     = '"+nom+"',
    apellido   = '"+nom+"',
    ci='"+nom+"',
    telefono='"+nom+"',
    usuario='"+nom+"',
    contrasena ='"+nom+"',
    login      ='"+nom+"';
UPDATE personas
SET nombre     = '"+nom+"',
    apellido   = '"+nom+"',
    telefono='"+nom+"',
    usuario='"+nom+"',
    contrasena ='"+nom+"',
    login      ='"+nom+"'
WHERE ci = '"+ci+"';

DELETE
FROM personas
WHERE ci = '"+ci+"';


CREATE TABLE inventario
(
    id        INT IDENTITY PRIMARY KEY,
    producto  NVARCHAR(150) NOT NULL,
    categoria NVARCHAR(150) NOT NULL,
    precio    float         NOT NULL,
    cantidad  int           NOT NULL,
    codigo NVARCHAR (50) NOT NULL
);


USE empresaxyz;

CREATE TABLE cliente
(
    id_cliente      INT IDENTITY PRIMARY KEY,
    nombreCliente   VARCHAR(100),
    apellidoCliente VARCHAR(100),
    telefonoCliente VARCHAR(100),
    correoCliente   VARCHAR(100),
    Descuento       VARCHAR(100),
    canCompras      VARCHAR(100),
    codigoCliente   VARCHAR(100),
);
DROP  TABLE  cliente
--------------------------------------------------------------------------------

CREATE TABLE facturacion
(
    id_facturacion   INT IDENTITY PRIMARY KEY,
    codigo           NVARCHAR(100),
    producto         NVARCHAR(100),
    precioUnidad     FLOAT,
    cantidad         INT,
    cliente          NVARCHAR(100),
    descuentoCliente FLOAT,
    montoTotal       FLOAT,
    numFactura INT,
    codigoCliente     NVARCHAR(100),
    id_cliente INT,
foreign key (id_cliente) REFERENCES  cliente (id_cliente)
)
DROP TABLE  facturacion;

----PRUEBA  --------
CREATE TABLE personasPrueba
(
    ci         VARCHAR(55) NOT NULL PRIMARY KEY ,
    id_persona INT IDENTITY,
    nombre     VARCHAR(50),
    apellido   VARCHAR(50),
    telefono   VARCHAR(20),
    cargo VARCHAR (50)
);


CREATE TABLE usuarioPrueba
(
    id_usuario INT IDENTITY PRIMARY KEY ,
    usuario VARCHAR (25) ,
contrasena VARCHAR(25) ,
login INT,
    ci VARCHAR(55),
FOREIGN KEY (ci) references personasPrueba (ci)
)


DROP TABLE usuarioPrueba;
DROP  TABLE personasPrueba;



INSERT INTO personasPrueba (ci, nombre, apellido, telefono, cargo) VALUES ('José Félix','Sarmiento Mamani','9119638','60580189','logistica');

INSERT INTO usuarioPrueba (usuario, contrasena, login, ci) VALUES ('Felicks','123',1,'9119638');

INSERT INTO personasPrueba VALUES ('','','','','');
INSERT INTO usuarioPrueba VALUES ('','','');

INSERT INTO personasPrueba (ci, nombre, apellido, telefono, cargo) VALUES ('54123','Antonio ','Villarán','+591 7561874','Administrador');
INSERT INTO usuarioPrueba VALUES ('Mark','54123','1','54123')


SELECT per.ci, per.nombre, per.apellido,per.telefono, per.cargo, usu.usuario FROM personasPrueba as per, usuarioPrueba AS usu;




INSERT INTO personasPrueba VALUES ('"+nom+"','"+ape+"','"+ci+"','"+tel+ "','" + cargo + "');
INSERT INTO usuarioPrueba VALUES ('" + user + "','" + contra + "','" + log + "','" + ci + "')

DELETE from personasPrueba WHERE ci='Antonio';
DELETE from usuarioPrueba WHERE ci='54123';

--Error  detectando en el select

SELECT per.ci, per.nombre, per.apellido,per.telefono, per.cargo, usu.usuario
FROM personasPrueba INNER JOIN usuarioPrueba uP on personasPrueba.ci = uP.ci

---Arreglando error

SELECT per.ci, per.nombre, per.apellido,per.telefono, per.cargo, usu.usuario
FROM personasPrueba as per INNER JOIN usuarioPrueba AS usu on per.ci = usu.ci

-------------------------------------------------------------------------------------
SELECT DISTINCT TOP 1 numFactura FROM facturacion order by  numFactura DESC ;

SELECT (SELECT DISTINCT TOP 1 numFactura FROM facturacion order by  numFactura DESC )+1 AS numFactura


-------------------------------------------------------------------------------------
----INSERTAR REGISTROS DE PRODUCTOS-------------------
-------------------------------------------------------------------------------------

INSERT INTO inventario (producto, categoria, precio, cantidad, codigo) VALUES ('Set4CameraLAN','Electronico','540','4','CM-045');
INSERT INTO inventario (producto, categoria, precio, cantidad, codigo) VALUES ('rep Coder','Electronico','150','10','CM-100');
INSERT INTO inventario (producto, categoria, precio, cantidad, codigo) VALUES ('Mouse','Electronico','10','10','M-100');

DELETE  inventario where producto ='mouse'

-------------------------------------



----INSERTAR REGISTRO DE CLIENTE----

INSERT INTO  cliente (nombreCliente, apellidoCliente, telefonoCliente, correoCliente, codigoCliente, Descuento, canCompras) VALUES ('Antonio','Villarán','+54 54129874','aVil@prueba.com','54321','0','0')
INSERT INTO  cliente (nombreCliente, apellidoCliente, telefonoCliente, correoCliente, codigoCliente, Descuento, canCompras) VALUES ('Diego','Villarán','+54 9749874','Diegol@prueba.com','54322','0,5','4')
INSERT INTO  cliente (nombreCliente, apellidoCliente, telefonoCliente, correoCliente, Descuento, canCompras, codigoCliente) VALUES ('Diego','Villarán','+54 9749874','Diegol@prueba.com','0,5','0','54322')
INSERT INTO  cliente (nombreCliente, apellidoCliente, telefonoCliente, correoCliente, Descuento, canCompras, codigoCliente) VALUES  ('Antonio','Villarán','+54 54129874','aVil@prueba.com','0,0','0','54321')
DELETE cliente where telefonoCliente='+54 9749874';


------NOTA-----
-----UTILIZAR , PARA MARCAR DECIMAL Y NO UN PUNTO------

---Generar un registro de factura-
USE empresaxyz
DROP TABLE facturacion;

CREATE TABLE facturacion
(
    id_facturacion   INT IDENTITY PRIMARY KEY,
    codigo           NVARCHAR(100),
    producto         NVARCHAR(100),
    precioUnidad     FLOAT,
    cantidad         INT,
    descuento        FLOAT,
    cliente          NVARCHAR(100),
    descuentoCliente FLOAT,
    montoTotal       VARCHAR(200),
    numFactura       INT
);



INSERT INTO  facturacion (codigo, producto, precioUnidad, cantidad, descuento,cliente, codigoCliente, descuentoCliente, montoTotal, numFactura) VALUES ('CM-100','rep Coder',150,2,0,'Antonio','54321',0,230,1)



---Consutla par e obtenr el descuento y cdatos del clietne

SELECT cl.nombreCliente + ' ' + cl.apellidoCliente  AS nombre, cl.Descuento FROM cliente AS cl WHERE  codigoCliente='';


---------------------------


SELECT cl.nombreCliente + ' ' + cl.apellidoCliente  AS nombre, cl.Descuento FROM cliente AS cl WHERE  codigoCliente='54322'
SELECT * from inventario WHERE codigo= 'CM-100'



    USE empresaxyz


DROP  TABLE  facturacion

----------inserts dentro de C#--------

INSERT INTO facturacion (codigo, producto, precioUnidad, cantidad, descuento,cliente, descuentoCliente, montoTotal, numFactura)
VALUES ('"+fact.codigo+"','"fact.producto"','"+fact.PrecioUnidad+"','"+Convert.ToInt32(fact.codigo)+"','"+Convert.ToDouble(fact.descuento)+"','"+fact.Cliente+"','"+Convert.ToDouble(fact.ClienteDesc)+"','Convert.ToDouble(fact.Total)','"Convert.ToInt32(fact.NFactura)"';
INSERT INTO  facturacion (codigo, producto, precioUnidad, cantidad, cliente, descuentoCliente, montoTotal, numFactura,codigoCliente)
VALUES ('"+fact.codigo+"','"fact.producto"','"+fact.PrecioUnidad+"','"+Convert.ToInt32(fact.canitdad)+"','"fact.cliente"','"+Convert.ToDouble(fact.clienteDescuento+"','"+Convert.ToDouble(fact.Total)+"','"+Convert.ToInt32(fact.NFactura))+"')



Insert into Facturacion (Codigo,Producto,PrecioxUnidad,Cantidad,Descuento" +
                        ",Cliente,DescuentoCliente,MontoTotal ,NumFactura ) " +
                        " values ('" + fact.Codigo + "', '" + fact.Producto + "'," +
                        "" + Convert.ToDouble(fact.PrecioxUnidad) + "," + Convert.ToInt32(fact.Cantidad) + "," + Convert.ToDouble(fact.Descuento) +
                        "'" + fact.Cliente + "'," + Convert.ToDouble(fact.Clientdesc) + "," +
                        "" + Convert.ToDouble(fact.Total) + "," + Convert.ToInt32(fact.Nfactura) + ")";




CREATE  OR ALTER VIEW vistatotal(
    SELECT per.*, up.usuario, up.login
    FROM personasPrueba AS per
    INNER JOIN usuarioPrueba uP on per.ci = uP.ci)






