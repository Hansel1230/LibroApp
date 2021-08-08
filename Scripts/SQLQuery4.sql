/****** Script for SelectTopNRows command from SSMS  ******/
SELECT Libros.[id]
      ,Libros.[Nombre]
      ,Libros.[Fecha_Publicacion]
      ,Autores1.Nombre as Nombre_Autor
      ,Editoriales.Nombre as Nombre_Editorial
  FROM [BibliotecaParcial2].[dbo].[Libros]
  inner join [BibliotecaParcial2].[dbo].Autores1 on ( Libros.[id_Autor] = Autores1.id)
  inner join [BibliotecaParcial2].[dbo].Editoriales on ( Libros.id_Editorial = Editoriales.id)