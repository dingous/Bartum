
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
            'CARTÃO',
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
            'CHEQUE PRÉ',
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
            'CONVÊNIO',
           7
           ,0
           ,GETDATE()
           ,0
           )
GO


