INSERT INTO [EasyBar].[dbo].[EB_Fornecedor]
           ([dsNomeFantasia]
           ,[dsRazaoSocial]
           ,[nrCNPJ]
           ,[nrInsEstadual]
           ,[nrTelefone]
           ,[nrFax]
           ,[nrCelular]
           ,[nrNomeContato]
           ,[dsLogradouro]
           ,[dsCidade]
           ,[dsUfEstado]
           ,[nrCEP]
           ,[dsEmail]
           ,[dsSite]
           ,[dsObservacao]
           ,[dtCadastro])
     VALUES
           ('FORNECEDOR 1',
           'FORNECEDOR 1',
           0000000000,
           0000000000,
           '',
           '',
           '',
           '',
           '',
           'CIDADE',
           'UF',
           '38180-000',
           '',
           'www.google.com.br',
           '',
           getdate())
GO


