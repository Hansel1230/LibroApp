USE [BibliotecaParcial2]
GO

INSERT INTO [dbo].[Libros]
           ([Nombre]
           ,[Fecha_Publicacion]
           ,[id_Autor]
           ,[id_Editorial])
     VALUES
           ('La Bella y la Bestia','2020/03/14',4,1),
		   ('El Principito','2018/12/29',1,3),
		   ('Mil Noches de soledad','2015/07/09',3,2)
GO


