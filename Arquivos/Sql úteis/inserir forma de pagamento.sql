
INSERT INTO [EasyBar].[dbo].[EB_FormaPagamento]
            ([CondicaoID]
           ,[dsForma]
           ,[ordem]
           ,[flMostrarnoContas]
          ,[dtCadastro]
           ,[Flexcluido]
           )
     VALUES
           (1,
           'DINHEIRO',
           1
           ,1
           ,GETDATE()
           ,0
           )
GO


INSERT INTO [EasyBar].[dbo].[EB_FormaPagamento]
           ([CondicaoID]
           ,[dsForma]
           ,[ordem]
           ,[flMostrarnoContas]
          ,[dtCadastro]
           ,[Flexcluido]
           )
     VALUES
            (1,
            'CHEQUE',
            2
           ,1
           ,GETDATE()
           ,0
           )
GO


INSERT INTO [EasyBar].[dbo].[EB_FormaPagamento]
            ([CondicaoID]
           ,[dsForma]
           ,[ordem]
           ,[flMostrarnoContas]
          ,[dtCadastro]
           ,[Flexcluido]
           )
     VALUES
            (1,
            'CART�O',
           3
           ,1
           ,GETDATE()
           ,0
           )
GO


INSERT INTO [EasyBar].[dbo].[EB_FormaPagamento]
           ([CondicaoID]
           ,[dsForma]
           ,[ordem]
           ,[flMostrarnoContas]
          ,[dtCadastro]
           ,[Flexcluido]
			)
     VALUES
            (1,
            'CHEQUE PR�',
           4
           ,1
           ,GETDATE()
           ,0
           )
GO


INSERT INTO [EasyBar].[dbo].[EB_FormaPagamento]
           ([CondicaoID]
           ,[dsForma]
           ,[ordem]
           ,[flMostrarnoContas]
          ,[dtCadastro]
           ,[Flexcluido]
           )
     VALUES
            (1,
            'TICKET',
           5
           ,1
           ,GETDATE()
           ,0
          )
GO


INSERT INTO [EasyBar].[dbo].[EB_FormaPagamento]
           ([CondicaoID]
           ,[dsForma]
           ,[ordem]
           ,[flMostrarnoContas]
          ,[dtCadastro]
           ,[Flexcluido]
           )
     VALUES
            (3,
            'CONSUMO INTERNO',
           6
           ,0
           ,GETDATE()
           ,0
           )
GO


INSERT INTO [EasyBar].[dbo].[EB_FormaPagamento]
           ([CondicaoID]
           ,[dsForma]
           ,[ordem]
           ,[flMostrarnoContas]
          ,[dtCadastro]
           ,[Flexcluido]
           )
     VALUES
            (2,
            'CONV�NIO',
           7
           ,0
           ,GETDATE()
           ,0
           )
GO


