delete from EB_Endereco
delete from EB_Contato
delete  from EB_Cliente


select * from EB_Endereco
select * from EB_Cliente
select * from EB_Contato

DBCC CHECKIDENT ('EB_Contato', RESEED, 0)
DBCC CHECKIDENT ('EB_Cliente', RESEED, 0)
DBCC CHECKIDENT ('EB_Endereco', RESEED, 0)

SET IDENTITY_INSERT PD_CLIENTE ON