/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [CategoryID]
      ,[CategoryName]
      ,[Description]
      ,[Picture]
  FROM [NORTHWND].[dbo].[Categories]