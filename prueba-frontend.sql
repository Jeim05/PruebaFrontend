CREATE DATABASE PRUEBA_FRONTEND

USE PRUEBA_FRONTEND

CREATE TABLE CARD(
    IdCard INT PRIMARY KEY IDENTITY, 
    TituloPrincipal varchar(50),
    SubTitulo varchar(255),
    TextoCardInformativo varchar(100)
)

CREATE TABLE ARTICULO (
 IdArticulo INT PRIMARY KEY IDENTITY,
 Titulo varchar(100),
 Descripcion varchar(255)
)


/*INSERSION DE ELEMENTOS EN LAS TABLAS*/
INSERT INTO CARD (TituloPrincipal, SubTitulo, TextoCardInformativo)
 VALUES(
    'Texto principal',
    'Texto secundario texto secundario texto secundario texto secundario texto secundario texto secundario',
    'Texto sobre otro elemento'
 )

 INSERT INTO ARTICULO (Titulo, Descripcion)
   VALUES (
   'Articulo 1',
   'Descripcion del articulo 1'
)


 INSERT INTO ARTICULO (Titulo, Descripcion)
   VALUES (
   'Articulo 2',
   'Descripcion del articulo 2'
   )

    INSERT INTO ARTICULO (Titulo, Descripcion)
   VALUES (
   'Articulo 3',
   'Descripcion del articulo 3'
   )

    INSERT INTO ARTICULO (Titulo, Descripcion)
   VALUES (
   'Articulo 4',
   'Descripcion del articulo 4'
   )

    INSERT INTO ARTICULO (Titulo, Descripcion)
   VALUES (
   'Articulo 5',
   'Descripcion del articulo 5'
   )

 SELECT IdCard, TituloPrincipal, SubTitulo, TextoCardInformativo FROM CARD

 SELECT * FROM ARTICULO

 SELECT IdArticulo, Titulo, Descripcion FROM ARTICULO