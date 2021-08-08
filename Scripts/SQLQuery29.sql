/****** Script for SelectTopNRows command from SSMS  ******/


SELECT TOP (1000) [id]
      ,[Nombre]
      ,[Fecha_Publicacion]
      ,[id_Autor]
      ,[id_Editorial]
  FROM [BibliotecaParcial2].[dbo].[Libros]
  