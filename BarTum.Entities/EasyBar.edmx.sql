-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/10/2012 17:28:41
-- Generated from EDMX file: D:\Sistema_TI\EasyBar\EasyBar.Entities\EasyBar.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EasyBarPontoM];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EB_CaixaHistoricoFechamento_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento] DROP CONSTRAINT [FK_EB_CaixaHistoricoFechamento_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_CaixaHistoricoFechamento_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento] DROP CONSTRAINT [FK_EB_CaixaHistoricoFechamento_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_Contas_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_Contas_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_FormaPagamento_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_FormaPagamento] DROP CONSTRAINT [FK_EB_FormaPagamento_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LancamentoCaixaBanco_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoCaixaBanco] DROP CONSTRAINT [FK_EB_LancamentoCaixaBanco_fk];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Bairro__Cidad__25518C17]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Bairro] DROP CONSTRAINT [FK__EB_Bairro__Cidad__25518C17];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Cidade__Estad__245D67DE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Cidade] DROP CONSTRAINT [FK__EB_Cidade__Estad__245D67DE];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Client__Clien__2EDAF651]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_ClienteOcorrencias] DROP CONSTRAINT [FK__EB_Client__Clien__2EDAF651];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Client__Conta__2BFE89A6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Cliente] DROP CONSTRAINT [FK__EB_Client__Conta__2BFE89A6];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Client__Ender__2CF2ADDF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Cliente] DROP CONSTRAINT [FK__EB_Client__Ender__2CF2ADDF];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Client__Usuar__2DE6D218]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Cliente] DROP CONSTRAINT [FK__EB_Client__Usuar__2DE6D218];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_ContaL__Conta__2FCF1A8A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_ContaLancto] DROP CONSTRAINT [FK__EB_ContaL__Conta__2FCF1A8A];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_ContaL__TipoL__30C33EC3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_ContaLancto] DROP CONSTRAINT [FK__EB_ContaL__TipoL__30C33EC3];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Endere__Bairr__29221CFB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Endereco] DROP CONSTRAINT [FK__EB_Endere__Bairr__29221CFB];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Endere__Cidad__2A164134]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Endereco] DROP CONSTRAINT [FK__EB_Endere__Cidad__2A164134];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__Caixa__3493CFA7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK__EB_Lancam__Caixa__3493CFA7];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__Entre__3587F3E0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK__EB_Lancam__Entre__3587F3E0];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__Garco__367C1819]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK__EB_Lancam__Garco__367C1819];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__Lanct__70A8B9AE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoItens] DROP CONSTRAINT [FK__EB_Lancam__Lanct__70A8B9AE];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__MesaI__37703C52]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK__EB_Lancam__MesaI__37703C52];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__Produ__59C55456]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoItens] DROP CONSTRAINT [FK__EB_Lancam__Produ__59C55456];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__TipoL__3864608B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK__EB_Lancam__TipoL__3864608B];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__TipoV__395884C4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK__EB_Lancam__TipoV__395884C4];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Lancam__Usuar__3A4CA8FD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK__EB_Lancam__Usuar__3A4CA8FD];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Produt__Forne__47A6A41B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Produto] DROP CONSTRAINT [FK__EB_Produt__Forne__47A6A41B];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Produt__Grupo__489AC854]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Produto] DROP CONSTRAINT [FK__EB_Produt__Grupo__489AC854];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Produt__Orige__498EEC8D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Produto] DROP CONSTRAINT [FK__EB_Produt__Orige__498EEC8D];
GO
IF OBJECT_ID(N'[dbo].[FK__EB_Produt__TipoP__4A8310C6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Produto] DROP CONSTRAINT [FK__EB_Produt__TipoP__4A8310C6];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_CaixaHistoricoFechamento_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento] DROP CONSTRAINT [FK_EB_CaixaHistoricoFechamento_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_CONTA_REFERENCE_EB_CLIEN]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_CLIEN];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_CONTA_REFERENCE_EB_FORMA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_FORMA];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_CONTA_REFERENCE_EB_LANCA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_LANCA];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_CONTA_REFERENCE_EB_PLANO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_PLANO];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_CONTA_REFERENCE_EB_TIPOL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_TIPOL];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_Contas_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_Contas_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_Contas_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_Contas_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_Contas_fk4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Contas] DROP CONSTRAINT [FK_EB_Contas_fk4];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_Endereco_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Endereco] DROP CONSTRAINT [FK_EB_Endereco_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_EstoqueLancto_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_EstoqueLancto] DROP CONSTRAINT [FK_EB_EstoqueLancto_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_EstoqueLancto_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_EstoqueLancto] DROP CONSTRAINT [FK_EB_EstoqueLancto_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_EstoqueLancto_fk3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_EstoqueLancto] DROP CONSTRAINT [FK_EB_EstoqueLancto_fk3];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_EstoqueLanctoItens_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_EstoqueLancItens] DROP CONSTRAINT [FK_EB_EstoqueLanctoItens_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_EstoqueLanctoItens_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_EstoqueLancItens] DROP CONSTRAINT [FK_EB_EstoqueLanctoItens_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_GrupoProduto_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_GrupoProduto] DROP CONSTRAINT [FK_EB_GrupoProduto_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_IMPRE_REFERENCE_EB_TIPOP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Impressoras] DROP CONSTRAINT [FK_EB_IMPRE_REFERENCE_EB_TIPOP];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LANCA_REFERENCE_EB_BALCA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_BALCA];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LANCA_REFERENCE_EB_CLIEN]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_CLIEN];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LANCA_REFERENCE_EB_FORMA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag] DROP CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_FORMA];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LANCA_REFERENCE_EB_LANCA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_Lancamento] DROP CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_LANCA];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LANCA_REFERENCE_EB_LANCA_FECHA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag] DROP CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_LANCA_FECHA];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LancamentoAdiantamentos_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoAdiantamentos] DROP CONSTRAINT [FK_EB_LancamentoAdiantamentos_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LancamentoAdiantamentos_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoAdiantamentos] DROP CONSTRAINT [FK_EB_LancamentoAdiantamentos_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LanctoPedidos_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LanctoPedidos] DROP CONSTRAINT [FK_EB_LanctoPedidos_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LanctoPedidos_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LanctoPedidos] DROP CONSTRAINT [FK_EB_LanctoPedidos_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_LanctoPedidos_fk3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LanctoPedidos] DROP CONSTRAINT [FK_EB_LanctoPedidos_fk3];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_PlanoContas_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_PlanoContas] DROP CONSTRAINT [FK_EB_PlanoContas_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_PlanoContas_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_PlanoContas] DROP CONSTRAINT [FK_EB_PlanoContas_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_PRODU_REFERENCE_EB_PRODU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_ProdutoComp] DROP CONSTRAINT [FK_EB_PRODU_REFERENCE_EB_PRODU];
GO
IF OBJECT_ID(N'[dbo].[FK_EB_ProdutoComp_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_ProdutoComp] DROP CONSTRAINT [FK_EB_ProdutoComp_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EN_LancamentoCaixaBanco_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoCaixaBanco] DROP CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_EN_LancamentoCaixaBanco_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoCaixaBanco] DROP CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_EN_LancamentoCaixaBanco_fk3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EB_LancamentoCaixaBanco] DROP CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk3];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EB_Bairro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Bairro];
GO
IF OBJECT_ID(N'[dbo].[EB_Balcao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Balcao];
GO
IF OBJECT_ID(N'[dbo].[EB_CadastroMesa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_CadastroMesa];
GO
IF OBJECT_ID(N'[dbo].[EB_Caixa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Caixa];
GO
IF OBJECT_ID(N'[dbo].[EB_CaixaHistoricoFechamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_CaixaHistoricoFechamento];
GO
IF OBJECT_ID(N'[dbo].[EB_Cidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Cidade];
GO
IF OBJECT_ID(N'[dbo].[EB_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Cliente];
GO
IF OBJECT_ID(N'[dbo].[EB_ClienteOcorrencias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_ClienteOcorrencias];
GO
IF OBJECT_ID(N'[dbo].[EB_ConfiguracoesSistema]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_ConfiguracoesSistema];
GO
IF OBJECT_ID(N'[dbo].[EB_ContaCorrente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_ContaCorrente];
GO
IF OBJECT_ID(N'[dbo].[EB_ContaLancto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_ContaLancto];
GO
IF OBJECT_ID(N'[dbo].[EB_Contas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Contas];
GO
IF OBJECT_ID(N'[dbo].[EB_ContasDestDesconto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_ContasDestDesconto];
GO
IF OBJECT_ID(N'[dbo].[EB_ContaTipoLancto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_ContaTipoLancto];
GO
IF OBJECT_ID(N'[dbo].[EB_Contato]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Contato];
GO
IF OBJECT_ID(N'[dbo].[EB_Empresa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Empresa];
GO
IF OBJECT_ID(N'[dbo].[EB_Endereco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Endereco];
GO
IF OBJECT_ID(N'[dbo].[EB_Entregador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Entregador];
GO
IF OBJECT_ID(N'[dbo].[EB_Estado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Estado];
GO
IF OBJECT_ID(N'[dbo].[EB_EstoqueLancItens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_EstoqueLancItens];
GO
IF OBJECT_ID(N'[dbo].[EB_EstoqueLancto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_EstoqueLancto];
GO
IF OBJECT_ID(N'[dbo].[EB_FormaPagamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_FormaPagamento];
GO
IF OBJECT_ID(N'[dbo].[EB_FormaPagamentoCondicao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_FormaPagamentoCondicao];
GO
IF OBJECT_ID(N'[dbo].[EB_Fornecedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Fornecedor];
GO
IF OBJECT_ID(N'[dbo].[EB_Garcon]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Garcon];
GO
IF OBJECT_ID(N'[dbo].[EB_GrupoProduto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_GrupoProduto];
GO
IF OBJECT_ID(N'[dbo].[EB_Impressoras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Impressoras];
GO
IF OBJECT_ID(N'[dbo].[EB_Lancamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Lancamento];
GO
IF OBJECT_ID(N'[dbo].[EB_LancamentoAdiantamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_LancamentoAdiantamentos];
GO
IF OBJECT_ID(N'[dbo].[EB_LancamentoCaixaBanco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_LancamentoCaixaBanco];
GO
IF OBJECT_ID(N'[dbo].[EB_LancamentoFechamentoFormasPag]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_LancamentoFechamentoFormasPag];
GO
IF OBJECT_ID(N'[dbo].[EB_LancamentoItens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_LancamentoItens];
GO
IF OBJECT_ID(N'[dbo].[EB_LancamentoStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_LancamentoStatus];
GO
IF OBJECT_ID(N'[dbo].[EB_LanctoPedidos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_LanctoPedidos];
GO
IF OBJECT_ID(N'[dbo].[EB_OrigemProduto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_OrigemProduto];
GO
IF OBJECT_ID(N'[dbo].[EB_PlanoContas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_PlanoContas];
GO
IF OBJECT_ID(N'[dbo].[EB_Produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Produto];
GO
IF OBJECT_ID(N'[dbo].[EB_ProdutoComp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_ProdutoComp];
GO
IF OBJECT_ID(N'[dbo].[EB_TipoLancto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_TipoLancto];
GO
IF OBJECT_ID(N'[dbo].[EB_TipoProduto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_TipoProduto];
GO
IF OBJECT_ID(N'[dbo].[EB_TipoVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_TipoVenda];
GO
IF OBJECT_ID(N'[dbo].[EB_Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EB_Usuario];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EB_Bairro'
CREATE TABLE [dbo].[EB_Bairro] (
    [BairroID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [CidadeID] decimal(11,0)  NOT NULL,
    [dsNome] varchar(120)  NOT NULL,
    [nrTaxaEntrega] decimal(13,2)  NOT NULL
);
GO

-- Creating table 'EB_Balcao'
CREATE TABLE [dbo].[EB_Balcao] (
    [BalcaoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsBalcao] varchar(100)  NULL
);
GO

-- Creating table 'EB_CadastroMesa'
CREATE TABLE [dbo].[EB_CadastroMesa] (
    [MesaID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsMesa] varchar(100)  NULL
);
GO

-- Creating table 'EB_Caixa'
CREATE TABLE [dbo].[EB_Caixa] (
    [CaixaID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dtCaixa] datetime  NOT NULL
);
GO

-- Creating table 'EB_CaixaHistoricoFechamento'
CREATE TABLE [dbo].[EB_CaixaHistoricoFechamento] (
    [HistoricoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [CaixaID] decimal(11,0)  NULL,
    [UsuarioIDAbertura] decimal(11,0)  NULL,
    [dtCaixaAbertura] datetime  NULL,
    [UsuarioIDFechamento] decimal(11,0)  NULL,
    [dtCaixaFechamento] datetime  NULL,
    [fechamentoSaldoComputado] decimal(11,2)  NULL,
    [fechamentoTotalFisicoCaixa] decimal(11,2)  NULL,
    [fechamentoFundoCaixa] decimal(11,2)  NULL,
    [fechamentoDiferenca] decimal(11,2)  NULL,
    [dsStatus] varchar(30)  NULL,
    [vlCaixa] decimal(13,2)  NULL,
    [vlAberturaCaixa] decimal(13,2)  NULL
);
GO

-- Creating table 'EB_Cidade'
CREATE TABLE [dbo].[EB_Cidade] (
    [CidadeID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [EstadoID] decimal(11,0)  NOT NULL,
    [dsNome] varchar(100)  NOT NULL
);
GO

-- Creating table 'EB_Cliente'
CREATE TABLE [dbo].[EB_Cliente] (
    [ClienteID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [EnderecoID] decimal(11,0)  NULL,
    [ContatoID] decimal(11,0)  NULL,
    [UsuarioID] decimal(11,0)  NULL,
    [dsNome] varchar(150)  NOT NULL,
    [dtNascimento] datetime  NULL,
    [nrCpfCpnj] varchar(11)  NULL,
    [dsEmail] varchar(150)  NULL,
    [dtCadastro] datetime  NOT NULL,
    [nrStatus] decimal(18,0)  NULL,
    [convenio] bit  NULL,
    [flExcluido] bit  NOT NULL
);
GO

-- Creating table 'EB_ClienteOcorrencias'
CREATE TABLE [dbo].[EB_ClienteOcorrencias] (
    [OcorrenciaID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [ClienteID] decimal(11,0)  NOT NULL,
    [dsOcorrencia] varchar(max)  NOT NULL,
    [dtOcorrencia] datetime  NOT NULL
);
GO

-- Creating table 'EB_ConfiguracoesSistema'
CREATE TABLE [dbo].[EB_ConfiguracoesSistema] (
    [ConfID] decimal(11,0)  NOT NULL,
    [impressaoCabecalho] varchar(max)  NULL,
    [impressaoRodape] varchar(max)  NULL,
    [flTaxaServicoAtiva] bit  NULL,
    [ServidorIP] varchar(20)  NULL,
    [ServidorPorta] int  NULL
);
GO

-- Creating table 'EB_ContaCorrente'
CREATE TABLE [dbo].[EB_ContaCorrente] (
    [ContaID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsDescricao] varchar(100)  NULL,
    [nrContaNumero] decimal(20,0)  NULL,
    [dtReferencia] datetime  NULL,
    [mnSaldoInicial] decimal(11,3)  NULL,
    [mnLimite] decimal(11,3)  NULL,
    [dsAgencia] varchar(100)  NULL,
    [dsNomeGerente] varchar(100)  NULL,
    [nrTelefone] varchar(100)  NULL,
    [dtCadastro] datetime  NULL
);
GO

-- Creating table 'EB_ContaLancto'
CREATE TABLE [dbo].[EB_ContaLancto] (
    [LanctoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [ContaID] decimal(11,0)  NOT NULL,
    [TipoLanctoID] decimal(11,0)  NOT NULL,
    [nrValor] float  NULL,
    [dsObservacao] varchar(max)  NULL
);
GO

-- Creating table 'EB_Contas'
CREATE TABLE [dbo].[EB_Contas] (
    [contasID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [pai] decimal(11,0)  NULL,
    [lanctoID] decimal(11,0)  NULL,
    [clienteID] decimal(11,0)  NULL,
    [FornecedorID] decimal(11,0)  NULL,
    [FormaPagamentoID] decimal(11,0)  NULL,
    [PlanoContaID] decimal(11,0)  NULL,
    [TipoLanctoID] decimal(11,0)  NULL,
    [usuarioID] decimal(11,0)  NOT NULL,
    [dtlancto] datetime  NULL,
    [descricao] varchar(max)  NULL,
    [vlConta] decimal(13,2)  NULL,
    [dtVencimento] datetime  NULL,
    [observacoes] varchar(max)  NULL,
    [dtPagamentoOuRecebimento] datetime  NULL,
    [fechaValorPago] decimal(13,2)  NULL,
    [DestDescontoID] decimal(11,0)  NULL,
    [DestOuOrigDescontoContaCorrenteID] decimal(11,0)  NULL,
    [flBaixada] bit  NOT NULL,
    [CaixaID] decimal(11,0)  NULL
);
GO

-- Creating table 'EB_ContasDestDesconto'
CREATE TABLE [dbo].[EB_ContasDestDesconto] (
    [DestDescontoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsDestinoDesconto] varchar(200)  NOT NULL
);
GO

-- Creating table 'EB_ContaTipoLancto'
CREATE TABLE [dbo].[EB_ContaTipoLancto] (
    [TipoLanctoID] decimal(11,0)  NOT NULL,
    [dsTipoLancto] varchar(100)  NULL
);
GO

-- Creating table 'EB_Contato'
CREATE TABLE [dbo].[EB_Contato] (
    [ContatoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [nrTelefone1] varchar(30)  NULL,
    [nrTelefone2] varchar(30)  NULL,
    [nrTelefone3] varchar(30)  NULL,
    [nrTelefone4] varchar(30)  NULL,
    [nrCelular] varchar(30)  NULL,
    [dsNomeContato] varchar(30)  NULL
);
GO

-- Creating table 'EB_Empresa'
CREATE TABLE [dbo].[EB_Empresa] (
    [EmpresaID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsNomeFantasia] varchar(100)  NOT NULL,
    [dsRazaoSocial] varchar(100)  NULL,
    [nrCnpj] varchar(100)  NULL,
    [tel1] varchar(30)  NULL,
    [tel2] varchar(30)  NULL,
    [cel] varchar(30)  NULL,
    [dsEmail] varchar(100)  NULL,
    [dsEndereco] varchar(200)  NULL,
    [dsBairro] varchar(150)  NULL,
    [DsCidade] varchar(150)  NULL,
    [siglaUF] varchar(2)  NULL,
    [inscEstadual] varchar(150)  NULL
);
GO

-- Creating table 'EB_Endereco'
CREATE TABLE [dbo].[EB_Endereco] (
    [EnderecoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [CidadeID] decimal(11,0)  NULL,
    [BairroID] decimal(11,0)  NULL,
    [ClienteID] decimal(11,0)  NULL,
    [dsLogradouro] varchar(100)  NULL,
    [dsComplemento] varchar(100)  NULL,
    [nrNumero] int  NULL,
    [nrCEP] varchar(9)  NULL,
    [dsRegiao] varchar(max)  NULL,
    [dsReferencias] varchar(max)  NULL,
    [flEnderecoPrincipal] bit  NOT NULL
);
GO

-- Creating table 'EB_Entregador'
CREATE TABLE [dbo].[EB_Entregador] (
    [EntregadorID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsNome] varchar(100)  NOT NULL,
    [dsEndereco] varchar(100)  NULL,
    [nrTelefoneFixo] char(18)  NULL,
    [nrTelefoneCelular] char(18)  NULL,
    [dtCadastro] datetime  NOT NULL
);
GO

-- Creating table 'EB_Estado'
CREATE TABLE [dbo].[EB_Estado] (
    [EstadoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsNome] varchar(100)  NOT NULL,
    [dsSigla] char(2)  NOT NULL
);
GO

-- Creating table 'EB_EstoqueLancItens'
CREATE TABLE [dbo].[EB_EstoqueLancItens] (
    [EstoqueLanctoItemID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [EstoqueLanctoID] decimal(11,0)  NULL,
    [ProdutoID] decimal(11,0)  NOT NULL,
    [nrQuantidade] decimal(11,0)  NOT NULL,
    [nrPrCusto] decimal(11,2)  NOT NULL,
    [vlTotal] decimal(11,2)  NOT NULL,
    [dtLancto] datetime  NOT NULL
);
GO

-- Creating table 'EB_EstoqueLancto'
CREATE TABLE [dbo].[EB_EstoqueLancto] (
    [EstoqueLanctoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [TipoMovID] decimal(11,0)  NOT NULL,
    [UsuarioID] decimal(11,0)  NOT NULL,
    [FornecedorID] decimal(11,0)  NULL,
    [nrNota] varchar(200)  NULL,
    [dtLancto] datetime  NOT NULL
);
GO

-- Creating table 'EB_FormaPagamento'
CREATE TABLE [dbo].[EB_FormaPagamento] (
    [FormaPagamentoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [CondicaoID] decimal(11,0)  NULL,
    [dsForma] varchar(100)  NOT NULL,
    [ordem] int  NULL,
    [flMostrarnoContas] bit  NULL,
    [dtCadastro] datetime  NULL,
    [Flexcluido] bit  NOT NULL
);
GO

-- Creating table 'EB_FormaPagamentoCondicao'
CREATE TABLE [dbo].[EB_FormaPagamentoCondicao] (
    [CondicaoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsCondicaoPagamento] varchar(200)  NOT NULL
);
GO

-- Creating table 'EB_Fornecedor'
CREATE TABLE [dbo].[EB_Fornecedor] (
    [FornecedorID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsNomeFantasia] varchar(100)  NOT NULL,
    [dsRazaoSocial] varchar(100)  NULL,
    [nrCNPJ] decimal(11,0)  NULL,
    [nrInsEstadual] decimal(11,0)  NULL,
    [nrTelefone] varchar(14)  NULL,
    [nrFax] varchar(14)  NULL,
    [nrCelular] varchar(14)  NULL,
    [nrNomeContato] varchar(100)  NULL,
    [dsLogradouro] varchar(120)  NULL,
    [dsCidade] varchar(120)  NULL,
    [dsUfEstado] varchar(2)  NULL,
    [nrCEP] varchar(10)  NULL,
    [dsEmail] varchar(100)  NULL,
    [dsSite] varchar(100)  NULL,
    [dsObservacao] varchar(max)  NULL,
    [dtCadastro] datetime  NULL
);
GO

-- Creating table 'EB_Garcon'
CREATE TABLE [dbo].[EB_Garcon] (
    [GarconID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsNome] varchar(100)  NOT NULL,
    [dsEndereco] varchar(100)  NOT NULL,
    [nrTelefone] varchar(100)  NULL,
    [nrCelular] varchar(100)  NULL,
    [nrComissao] float  NOT NULL,
    [dtCadastro] datetime  NOT NULL
);
GO

-- Creating table 'EB_GrupoProduto'
CREATE TABLE [dbo].[EB_GrupoProduto] (
    [GrupoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsGrupo] varchar(100)  NULL,
    [pai] decimal(11,0)  NULL,
    [flExcluido] bit  NULL
);
GO

-- Creating table 'EB_Impressoras'
CREATE TABLE [dbo].[EB_Impressoras] (
    [ImpressoraID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [TipoProdutoID] decimal(11,0)  NULL,
    [dsImpressora] varchar(150)  NOT NULL
);
GO

-- Creating table 'EB_Lancamento'
CREATE TABLE [dbo].[EB_Lancamento] (
    [LanctoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [CaixaID] decimal(11,0)  NOT NULL,
    [MesaID] decimal(11,0)  NULL,
    [TipoVendaID] decimal(11,0)  NOT NULL,
    [TipoLanctoID] decimal(11,0)  NOT NULL,
    [GarconID] decimal(11,0)  NULL,
    [BalcaoID] decimal(11,0)  NULL,
    [EntregadorID] decimal(11,0)  NULL,
    [UsuarioID] decimal(11,0)  NULL,
    [StatusID] decimal(11,0)  NULL,
    [ClienteID] decimal(11,0)  NULL,
    [ComandaID] decimal(11,0)  NULL,
    [nrOcupantes] decimal(11,0)  NULL,
    [dtLancto] datetime  NULL,
    [dtFimLancto] datetime  NULL,
    [dsNomeClienteBalcao] varchar(200)  NULL,
    [dsObservacao] varchar(max)  NULL,
    [FechaTotalConsumo] decimal(13,2)  NULL,
    [FechaAcrescimo] decimal(13,2)  NULL,
    [FechaDescontos] decimal(13,2)  NULL,
    [FechaAdiantamento] decimal(13,2)  NULL,
    [FechaTotalPago] decimal(13,2)  NULL,
    [FechaTroco] decimal(13,2)  NULL,
    [FechaCouver] decimal(13,2)  NULL,
    [FechaTotalVendaFinalizada] decimal(11,2)  NULL,
    [flVendaCancelada] bit  NOT NULL,
    [flComissaoGarconFoiPaga] bit  NULL
);
GO

-- Creating table 'EB_LancamentoAdiantamentos'
CREATE TABLE [dbo].[EB_LancamentoAdiantamentos] (
    [AdiantamentoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [LanctoID] decimal(11,0)  NOT NULL,
    [FormaPagamentoID] decimal(11,0)  NOT NULL,
    [vlTotalAPagarContaNoMomento] decimal(13,2)  NOT NULL,
    [vlPagamentoCliente] decimal(13,2)  NOT NULL,
    [vlRecebidoCliente] decimal(13,2)  NOT NULL,
    [vlTroco] decimal(13,2)  NULL,
    [dsObservacao] varchar(max)  NULL,
    [dtDataHora] datetime  NOT NULL
);
GO

-- Creating table 'EB_LancamentoCaixaBanco'
CREATE TABLE [dbo].[EB_LancamentoCaixaBanco] (
    [LanctoCaixaBancoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [TipoLanctoID] decimal(11,0)  NULL,
    [formaPagamentoID] decimal(11,0)  NOT NULL,
    [ContasDestDescontoID] decimal(11,0)  NOT NULL,
    [dsDescricao] varchar(max)  NOT NULL,
    [dtLancto] datetime  NOT NULL,
    [vlValor] decimal(11,2)  NOT NULL,
    [dtInsercao] datetime  NOT NULL,
    [CaixaID] decimal(11,0)  NULL
);
GO

-- Creating table 'EB_LancamentoFechamentoFormasPag'
CREATE TABLE [dbo].[EB_LancamentoFechamentoFormasPag] (
    [fechamentoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [LanctoID] decimal(11,0)  NOT NULL,
    [FormaPagamentoID] decimal(11,0)  NOT NULL,
    [vlForma] decimal(13,2)  NOT NULL,
    [FlOrigemAdiantamento] bit  NOT NULL
);
GO

-- Creating table 'EB_LancamentoItens'
CREATE TABLE [dbo].[EB_LancamentoItens] (
    [LanctoItemID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [PaiID] decimal(11,0)  NOT NULL,
    [LanctoID] decimal(11,0)  NULL,
    [ProdutoID] decimal(11,0)  NULL,
    [Quantidade] decimal(11,0)  NOT NULL,
    [nrPrecoVenda] decimal(13,2)  NOT NULL,
    [Total] decimal(13,2)  NOT NULL,
    [dsObservacao] varchar(max)  NULL,
    [dtDataHora] datetime  NULL,
    [flParaViagem] bit  NOT NULL,
    [flFoiImpresso] bit  NOT NULL
);
GO

-- Creating table 'EB_LancamentoStatus'
CREATE TABLE [dbo].[EB_LancamentoStatus] (
    [StatusID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsStatus] varchar(100)  NOT NULL
);
GO

-- Creating table 'EB_LanctoPedidos'
CREATE TABLE [dbo].[EB_LanctoPedidos] (
    [PedidoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [ClienteID] decimal(11,0)  NOT NULL,
    [EnderecoID] decimal(11,0)  NOT NULL,
    [LanctoID] decimal(11,0)  NOT NULL,
    [flRecebido] bit  NOT NULL,
    [flPagoAoEntregador] bit  NOT NULL
);
GO

-- Creating table 'EB_OrigemProduto'
CREATE TABLE [dbo].[EB_OrigemProduto] (
    [OrigemID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsOrigem] varchar(100)  NOT NULL,
    [dsImpressora] varchar(200)  NULL,
    [flMostrar] bit  NOT NULL,
    [impressaoObrigatoria] bit  NOT NULL,
    [impressoraPedidos] bit  NOT NULL,
    [tamanhoPapelImpressoraMilimetros] decimal(11,0)  NULL,
    [flPossuiAcentuacao] bit  NOT NULL
);
GO

-- Creating table 'EB_PlanoContas'
CREATE TABLE [dbo].[EB_PlanoContas] (
    [PlanoContaID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [TipoLanctoID] decimal(11,0)  NOT NULL,
    [Pai] decimal(11,0)  NULL,
    [dsPlanoConta] varchar(100)  NOT NULL,
    [flPadraoSaida] bit  NULL
);
GO

-- Creating table 'EB_Produto'
CREATE TABLE [dbo].[EB_Produto] (
    [ProdutoID] decimal(11,0)  NOT NULL,
    [nrCodigoBarras] decimal(20,0)  NULL,
    [OrigemID] decimal(11,0)  NOT NULL,
    [GrupoID] decimal(11,0)  NULL,
    [FornecedorID] decimal(11,0)  NULL,
    [TipoProdutoID] decimal(11,0)  NULL,
    [dsProduto] varchar(120)  NOT NULL,
    [nrUnidade] int  NOT NULL,
    [nrPrecoCusto] decimal(13,2)  NULL,
    [nrPrecoVenda] decimal(13,2)  NULL,
    [nrEstoqueMin] decimal(11,0)  NULL,
    [nrEstoqueMax] decimal(11,0)  NULL,
    [nrEstoqueAtual] decimal(11,0)  NOT NULL,
    [dtCadastro] datetime  NULL,
    [flExcluido] bit  NULL
);
GO

-- Creating table 'EB_ProdutoComp'
CREATE TABLE [dbo].[EB_ProdutoComp] (
    [ProdutoCompID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [ProdutoPrincipalID] decimal(11,0)  NOT NULL,
    [ProdutoID] decimal(11,0)  NULL,
    [Quantidade] decimal(11,0)  NULL
);
GO

-- Creating table 'EB_TipoLancto'
CREATE TABLE [dbo].[EB_TipoLancto] (
    [TipoLanctoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsTipoLancto] varchar(100)  NULL
);
GO

-- Creating table 'EB_TipoProduto'
CREATE TABLE [dbo].[EB_TipoProduto] (
    [TipoProdutoID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsTipoProduto] varchar(100)  NOT NULL
);
GO

-- Creating table 'EB_TipoVenda'
CREATE TABLE [dbo].[EB_TipoVenda] (
    [TipoVendaID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [dsTipoVenda] varchar(100)  NOT NULL,
    [dtCadastro] datetime  NOT NULL
);
GO

-- Creating table 'EB_Usuario'
CREATE TABLE [dbo].[EB_Usuario] (
    [UsuarioID] decimal(11,0) IDENTITY(1,1) NOT NULL,
    [EmpresaID] decimal(11,0)  NOT NULL,
    [dsNome] varchar(100)  NOT NULL,
    [dsLogin] varchar(100)  NULL,
    [dsSenha] varchar(100)  NULL,
    [nrStatus] decimal(1,0)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BairroID] in table 'EB_Bairro'
ALTER TABLE [dbo].[EB_Bairro]
ADD CONSTRAINT [PK_EB_Bairro]
    PRIMARY KEY CLUSTERED ([BairroID] ASC);
GO

-- Creating primary key on [BalcaoID] in table 'EB_Balcao'
ALTER TABLE [dbo].[EB_Balcao]
ADD CONSTRAINT [PK_EB_Balcao]
    PRIMARY KEY CLUSTERED ([BalcaoID] ASC);
GO

-- Creating primary key on [MesaID] in table 'EB_CadastroMesa'
ALTER TABLE [dbo].[EB_CadastroMesa]
ADD CONSTRAINT [PK_EB_CadastroMesa]
    PRIMARY KEY CLUSTERED ([MesaID] ASC);
GO

-- Creating primary key on [CaixaID] in table 'EB_Caixa'
ALTER TABLE [dbo].[EB_Caixa]
ADD CONSTRAINT [PK_EB_Caixa]
    PRIMARY KEY CLUSTERED ([CaixaID] ASC);
GO

-- Creating primary key on [HistoricoID] in table 'EB_CaixaHistoricoFechamento'
ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD CONSTRAINT [PK_EB_CaixaHistoricoFechamento]
    PRIMARY KEY CLUSTERED ([HistoricoID] ASC);
GO

-- Creating primary key on [CidadeID] in table 'EB_Cidade'
ALTER TABLE [dbo].[EB_Cidade]
ADD CONSTRAINT [PK_EB_Cidade]
    PRIMARY KEY CLUSTERED ([CidadeID] ASC);
GO

-- Creating primary key on [ClienteID] in table 'EB_Cliente'
ALTER TABLE [dbo].[EB_Cliente]
ADD CONSTRAINT [PK_EB_Cliente]
    PRIMARY KEY CLUSTERED ([ClienteID] ASC);
GO

-- Creating primary key on [OcorrenciaID] in table 'EB_ClienteOcorrencias'
ALTER TABLE [dbo].[EB_ClienteOcorrencias]
ADD CONSTRAINT [PK_EB_ClienteOcorrencias]
    PRIMARY KEY CLUSTERED ([OcorrenciaID] ASC);
GO

-- Creating primary key on [ConfID] in table 'EB_ConfiguracoesSistema'
ALTER TABLE [dbo].[EB_ConfiguracoesSistema]
ADD CONSTRAINT [PK_EB_ConfiguracoesSistema]
    PRIMARY KEY CLUSTERED ([ConfID] ASC);
GO

-- Creating primary key on [ContaID] in table 'EB_ContaCorrente'
ALTER TABLE [dbo].[EB_ContaCorrente]
ADD CONSTRAINT [PK_EB_ContaCorrente]
    PRIMARY KEY CLUSTERED ([ContaID] ASC);
GO

-- Creating primary key on [LanctoID] in table 'EB_ContaLancto'
ALTER TABLE [dbo].[EB_ContaLancto]
ADD CONSTRAINT [PK_EB_ContaLancto]
    PRIMARY KEY CLUSTERED ([LanctoID] ASC);
GO

-- Creating primary key on [contasID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [PK_EB_Contas]
    PRIMARY KEY CLUSTERED ([contasID] ASC);
GO

-- Creating primary key on [DestDescontoID] in table 'EB_ContasDestDesconto'
ALTER TABLE [dbo].[EB_ContasDestDesconto]
ADD CONSTRAINT [PK_EB_ContasDestDesconto]
    PRIMARY KEY CLUSTERED ([DestDescontoID] ASC);
GO

-- Creating primary key on [TipoLanctoID] in table 'EB_ContaTipoLancto'
ALTER TABLE [dbo].[EB_ContaTipoLancto]
ADD CONSTRAINT [PK_EB_ContaTipoLancto]
    PRIMARY KEY CLUSTERED ([TipoLanctoID] ASC);
GO

-- Creating primary key on [ContatoID] in table 'EB_Contato'
ALTER TABLE [dbo].[EB_Contato]
ADD CONSTRAINT [PK_EB_Contato]
    PRIMARY KEY CLUSTERED ([ContatoID] ASC);
GO

-- Creating primary key on [EmpresaID] in table 'EB_Empresa'
ALTER TABLE [dbo].[EB_Empresa]
ADD CONSTRAINT [PK_EB_Empresa]
    PRIMARY KEY CLUSTERED ([EmpresaID] ASC);
GO

-- Creating primary key on [EnderecoID] in table 'EB_Endereco'
ALTER TABLE [dbo].[EB_Endereco]
ADD CONSTRAINT [PK_EB_Endereco]
    PRIMARY KEY CLUSTERED ([EnderecoID] ASC);
GO

-- Creating primary key on [EntregadorID] in table 'EB_Entregador'
ALTER TABLE [dbo].[EB_Entregador]
ADD CONSTRAINT [PK_EB_Entregador]
    PRIMARY KEY CLUSTERED ([EntregadorID] ASC);
GO

-- Creating primary key on [EstadoID] in table 'EB_Estado'
ALTER TABLE [dbo].[EB_Estado]
ADD CONSTRAINT [PK_EB_Estado]
    PRIMARY KEY CLUSTERED ([EstadoID] ASC);
GO

-- Creating primary key on [EstoqueLanctoItemID] in table 'EB_EstoqueLancItens'
ALTER TABLE [dbo].[EB_EstoqueLancItens]
ADD CONSTRAINT [PK_EB_EstoqueLancItens]
    PRIMARY KEY CLUSTERED ([EstoqueLanctoItemID] ASC);
GO

-- Creating primary key on [EstoqueLanctoID] in table 'EB_EstoqueLancto'
ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD CONSTRAINT [PK_EB_EstoqueLancto]
    PRIMARY KEY CLUSTERED ([EstoqueLanctoID] ASC);
GO

-- Creating primary key on [FormaPagamentoID] in table 'EB_FormaPagamento'
ALTER TABLE [dbo].[EB_FormaPagamento]
ADD CONSTRAINT [PK_EB_FormaPagamento]
    PRIMARY KEY CLUSTERED ([FormaPagamentoID] ASC);
GO

-- Creating primary key on [CondicaoID] in table 'EB_FormaPagamentoCondicao'
ALTER TABLE [dbo].[EB_FormaPagamentoCondicao]
ADD CONSTRAINT [PK_EB_FormaPagamentoCondicao]
    PRIMARY KEY CLUSTERED ([CondicaoID] ASC);
GO

-- Creating primary key on [FornecedorID] in table 'EB_Fornecedor'
ALTER TABLE [dbo].[EB_Fornecedor]
ADD CONSTRAINT [PK_EB_Fornecedor]
    PRIMARY KEY CLUSTERED ([FornecedorID] ASC);
GO

-- Creating primary key on [GarconID] in table 'EB_Garcon'
ALTER TABLE [dbo].[EB_Garcon]
ADD CONSTRAINT [PK_EB_Garcon]
    PRIMARY KEY CLUSTERED ([GarconID] ASC);
GO

-- Creating primary key on [GrupoID] in table 'EB_GrupoProduto'
ALTER TABLE [dbo].[EB_GrupoProduto]
ADD CONSTRAINT [PK_EB_GrupoProduto]
    PRIMARY KEY CLUSTERED ([GrupoID] ASC);
GO

-- Creating primary key on [ImpressoraID] in table 'EB_Impressoras'
ALTER TABLE [dbo].[EB_Impressoras]
ADD CONSTRAINT [PK_EB_Impressoras]
    PRIMARY KEY CLUSTERED ([ImpressoraID] ASC);
GO

-- Creating primary key on [LanctoID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [PK_EB_Lancamento]
    PRIMARY KEY CLUSTERED ([LanctoID] ASC);
GO

-- Creating primary key on [AdiantamentoID] in table 'EB_LancamentoAdiantamentos'
ALTER TABLE [dbo].[EB_LancamentoAdiantamentos]
ADD CONSTRAINT [PK_EB_LancamentoAdiantamentos]
    PRIMARY KEY CLUSTERED ([AdiantamentoID] ASC);
GO

-- Creating primary key on [LanctoCaixaBancoID] in table 'EB_LancamentoCaixaBanco'
ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [PK_EB_LancamentoCaixaBanco]
    PRIMARY KEY CLUSTERED ([LanctoCaixaBancoID] ASC);
GO

-- Creating primary key on [fechamentoID] in table 'EB_LancamentoFechamentoFormasPag'
ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag]
ADD CONSTRAINT [PK_EB_LancamentoFechamentoFormasPag]
    PRIMARY KEY CLUSTERED ([fechamentoID] ASC);
GO

-- Creating primary key on [LanctoItemID] in table 'EB_LancamentoItens'
ALTER TABLE [dbo].[EB_LancamentoItens]
ADD CONSTRAINT [PK_EB_LancamentoItens]
    PRIMARY KEY CLUSTERED ([LanctoItemID] ASC);
GO

-- Creating primary key on [StatusID] in table 'EB_LancamentoStatus'
ALTER TABLE [dbo].[EB_LancamentoStatus]
ADD CONSTRAINT [PK_EB_LancamentoStatus]
    PRIMARY KEY CLUSTERED ([StatusID] ASC);
GO

-- Creating primary key on [PedidoID] in table 'EB_LanctoPedidos'
ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD CONSTRAINT [PK_EB_LanctoPedidos]
    PRIMARY KEY CLUSTERED ([PedidoID] ASC);
GO

-- Creating primary key on [OrigemID] in table 'EB_OrigemProduto'
ALTER TABLE [dbo].[EB_OrigemProduto]
ADD CONSTRAINT [PK_EB_OrigemProduto]
    PRIMARY KEY CLUSTERED ([OrigemID] ASC);
GO

-- Creating primary key on [PlanoContaID] in table 'EB_PlanoContas'
ALTER TABLE [dbo].[EB_PlanoContas]
ADD CONSTRAINT [PK_EB_PlanoContas]
    PRIMARY KEY CLUSTERED ([PlanoContaID] ASC);
GO

-- Creating primary key on [ProdutoID] in table 'EB_Produto'
ALTER TABLE [dbo].[EB_Produto]
ADD CONSTRAINT [PK_EB_Produto]
    PRIMARY KEY CLUSTERED ([ProdutoID] ASC);
GO

-- Creating primary key on [ProdutoCompID] in table 'EB_ProdutoComp'
ALTER TABLE [dbo].[EB_ProdutoComp]
ADD CONSTRAINT [PK_EB_ProdutoComp]
    PRIMARY KEY CLUSTERED ([ProdutoCompID] ASC);
GO

-- Creating primary key on [TipoLanctoID] in table 'EB_TipoLancto'
ALTER TABLE [dbo].[EB_TipoLancto]
ADD CONSTRAINT [PK_EB_TipoLancto]
    PRIMARY KEY CLUSTERED ([TipoLanctoID] ASC);
GO

-- Creating primary key on [TipoProdutoID] in table 'EB_TipoProduto'
ALTER TABLE [dbo].[EB_TipoProduto]
ADD CONSTRAINT [PK_EB_TipoProduto]
    PRIMARY KEY CLUSTERED ([TipoProdutoID] ASC);
GO

-- Creating primary key on [TipoVendaID] in table 'EB_TipoVenda'
ALTER TABLE [dbo].[EB_TipoVenda]
ADD CONSTRAINT [PK_EB_TipoVenda]
    PRIMARY KEY CLUSTERED ([TipoVendaID] ASC);
GO

-- Creating primary key on [UsuarioID] in table 'EB_Usuario'
ALTER TABLE [dbo].[EB_Usuario]
ADD CONSTRAINT [PK_EB_Usuario]
    PRIMARY KEY CLUSTERED ([UsuarioID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CidadeID] in table 'EB_Bairro'
ALTER TABLE [dbo].[EB_Bairro]
ADD CONSTRAINT [FK__EB_Bairro__Cidad__25518C17]
    FOREIGN KEY ([CidadeID])
    REFERENCES [dbo].[EB_Cidade]
        ([CidadeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Bairro__Cidad__25518C17'
CREATE INDEX [IX_FK__EB_Bairro__Cidad__25518C17]
ON [dbo].[EB_Bairro]
    ([CidadeID]);
GO

-- Creating foreign key on [BairroID] in table 'EB_Endereco'
ALTER TABLE [dbo].[EB_Endereco]
ADD CONSTRAINT [FK__EB_Endere__Bairr__29221CFB]
    FOREIGN KEY ([BairroID])
    REFERENCES [dbo].[EB_Bairro]
        ([BairroID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Endere__Bairr__29221CFB'
CREATE INDEX [IX_FK__EB_Endere__Bairr__29221CFB]
ON [dbo].[EB_Endereco]
    ([BairroID]);
GO

-- Creating foreign key on [BalcaoID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_BALCA]
    FOREIGN KEY ([BalcaoID])
    REFERENCES [dbo].[EB_Balcao]
        ([BalcaoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LANCA_REFERENCE_EB_BALCA'
CREATE INDEX [IX_FK_EB_LANCA_REFERENCE_EB_BALCA]
ON [dbo].[EB_Lancamento]
    ([BalcaoID]);
GO

-- Creating foreign key on [MesaID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK__EB_Lancam__MesaI__37703C52]
    FOREIGN KEY ([MesaID])
    REFERENCES [dbo].[EB_CadastroMesa]
        ([MesaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__MesaI__37703C52'
CREATE INDEX [IX_FK__EB_Lancam__MesaI__37703C52]
ON [dbo].[EB_Lancamento]
    ([MesaID]);
GO

-- Creating foreign key on [CaixaID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_Contas_fk]
    FOREIGN KEY ([CaixaID])
    REFERENCES [dbo].[EB_Caixa]
        ([CaixaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_Contas_fk'
CREATE INDEX [IX_FK_EB_Contas_fk]
ON [dbo].[EB_Contas]
    ([CaixaID]);
GO

-- Creating foreign key on [CaixaID] in table 'EB_LancamentoCaixaBanco'
ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [FK_EB_LancamentoCaixaBanco_fk]
    FOREIGN KEY ([CaixaID])
    REFERENCES [dbo].[EB_Caixa]
        ([CaixaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LancamentoCaixaBanco_fk'
CREATE INDEX [IX_FK_EB_LancamentoCaixaBanco_fk]
ON [dbo].[EB_LancamentoCaixaBanco]
    ([CaixaID]);
GO

-- Creating foreign key on [CaixaID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK__EB_Lancam__Caixa__3493CFA7]
    FOREIGN KEY ([CaixaID])
    REFERENCES [dbo].[EB_Caixa]
        ([CaixaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__Caixa__3493CFA7'
CREATE INDEX [IX_FK__EB_Lancam__Caixa__3493CFA7]
ON [dbo].[EB_Lancamento]
    ([CaixaID]);
GO

-- Creating foreign key on [CaixaID] in table 'EB_CaixaHistoricoFechamento'
ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD CONSTRAINT [FK_EB_CaixaHistoricoFechamento_fk2]
    FOREIGN KEY ([CaixaID])
    REFERENCES [dbo].[EB_Caixa]
        ([CaixaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CaixaHistoricoFechamento_fk2'
CREATE INDEX [IX_FK_EB_CaixaHistoricoFechamento_fk2]
ON [dbo].[EB_CaixaHistoricoFechamento]
    ([CaixaID]);
GO

-- Creating foreign key on [UsuarioIDAbertura] in table 'EB_CaixaHistoricoFechamento'
ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD CONSTRAINT [FK_EB_CaixaHistoricoFechamento_fk]
    FOREIGN KEY ([UsuarioIDAbertura])
    REFERENCES [dbo].[EB_Usuario]
        ([UsuarioID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CaixaHistoricoFechamento_fk'
CREATE INDEX [IX_FK_EB_CaixaHistoricoFechamento_fk]
ON [dbo].[EB_CaixaHistoricoFechamento]
    ([UsuarioIDAbertura]);
GO

-- Creating foreign key on [UsuarioIDFechamento] in table 'EB_CaixaHistoricoFechamento'
ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD CONSTRAINT [FK_EB_CaixaHistoricoFechamento_fk2]
    FOREIGN KEY ([UsuarioIDFechamento])
    REFERENCES [dbo].[EB_Usuario]
        ([UsuarioID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CaixaHistoricoFechamento_fk2'
CREATE INDEX [IX_FK_EB_CaixaHistoricoFechamento_fk2]
ON [dbo].[EB_CaixaHistoricoFechamento]
    ([UsuarioIDFechamento]);
GO

-- Creating foreign key on [EstadoID] in table 'EB_Cidade'
ALTER TABLE [dbo].[EB_Cidade]
ADD CONSTRAINT [FK__EB_Cidade__Estad__245D67DE]
    FOREIGN KEY ([EstadoID])
    REFERENCES [dbo].[EB_Estado]
        ([EstadoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Cidade__Estad__245D67DE'
CREATE INDEX [IX_FK__EB_Cidade__Estad__245D67DE]
ON [dbo].[EB_Cidade]
    ([EstadoID]);
GO

-- Creating foreign key on [CidadeID] in table 'EB_Endereco'
ALTER TABLE [dbo].[EB_Endereco]
ADD CONSTRAINT [FK__EB_Endere__Cidad__2A164134]
    FOREIGN KEY ([CidadeID])
    REFERENCES [dbo].[EB_Cidade]
        ([CidadeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Endere__Cidad__2A164134'
CREATE INDEX [IX_FK__EB_Endere__Cidad__2A164134]
ON [dbo].[EB_Endereco]
    ([CidadeID]);
GO

-- Creating foreign key on [ClienteID] in table 'EB_ClienteOcorrencias'
ALTER TABLE [dbo].[EB_ClienteOcorrencias]
ADD CONSTRAINT [FK__EB_Client__Clien__2EDAF651]
    FOREIGN KEY ([ClienteID])
    REFERENCES [dbo].[EB_Cliente]
        ([ClienteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Client__Clien__2EDAF651'
CREATE INDEX [IX_FK__EB_Client__Clien__2EDAF651]
ON [dbo].[EB_ClienteOcorrencias]
    ([ClienteID]);
GO

-- Creating foreign key on [ContatoID] in table 'EB_Cliente'
ALTER TABLE [dbo].[EB_Cliente]
ADD CONSTRAINT [FK__EB_Client__Conta__2BFE89A6]
    FOREIGN KEY ([ContatoID])
    REFERENCES [dbo].[EB_Contato]
        ([ContatoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Client__Conta__2BFE89A6'
CREATE INDEX [IX_FK__EB_Client__Conta__2BFE89A6]
ON [dbo].[EB_Cliente]
    ([ContatoID]);
GO

-- Creating foreign key on [EnderecoID] in table 'EB_Cliente'
ALTER TABLE [dbo].[EB_Cliente]
ADD CONSTRAINT [FK__EB_Client__Ender__2CF2ADDF]
    FOREIGN KEY ([EnderecoID])
    REFERENCES [dbo].[EB_Endereco]
        ([EnderecoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Client__Ender__2CF2ADDF'
CREATE INDEX [IX_FK__EB_Client__Ender__2CF2ADDF]
ON [dbo].[EB_Cliente]
    ([EnderecoID]);
GO

-- Creating foreign key on [UsuarioID] in table 'EB_Cliente'
ALTER TABLE [dbo].[EB_Cliente]
ADD CONSTRAINT [FK__EB_Client__Usuar__2DE6D218]
    FOREIGN KEY ([UsuarioID])
    REFERENCES [dbo].[EB_Usuario]
        ([UsuarioID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Client__Usuar__2DE6D218'
CREATE INDEX [IX_FK__EB_Client__Usuar__2DE6D218]
ON [dbo].[EB_Cliente]
    ([UsuarioID]);
GO

-- Creating foreign key on [clienteID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_CLIEN]
    FOREIGN KEY ([clienteID])
    REFERENCES [dbo].[EB_Cliente]
        ([ClienteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CONTA_REFERENCE_EB_CLIEN'
CREATE INDEX [IX_FK_EB_CONTA_REFERENCE_EB_CLIEN]
ON [dbo].[EB_Contas]
    ([clienteID]);
GO

-- Creating foreign key on [ClienteID] in table 'EB_Endereco'
ALTER TABLE [dbo].[EB_Endereco]
ADD CONSTRAINT [FK_EB_Endereco_fk]
    FOREIGN KEY ([ClienteID])
    REFERENCES [dbo].[EB_Cliente]
        ([ClienteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_Endereco_fk'
CREATE INDEX [IX_FK_EB_Endereco_fk]
ON [dbo].[EB_Endereco]
    ([ClienteID]);
GO

-- Creating foreign key on [ClienteID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_CLIEN]
    FOREIGN KEY ([ClienteID])
    REFERENCES [dbo].[EB_Cliente]
        ([ClienteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LANCA_REFERENCE_EB_CLIEN'
CREATE INDEX [IX_FK_EB_LANCA_REFERENCE_EB_CLIEN]
ON [dbo].[EB_Lancamento]
    ([ClienteID]);
GO

-- Creating foreign key on [ClienteID] in table 'EB_LanctoPedidos'
ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD CONSTRAINT [FK_EB_LanctoPedidos_fk]
    FOREIGN KEY ([ClienteID])
    REFERENCES [dbo].[EB_Cliente]
        ([ClienteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LanctoPedidos_fk'
CREATE INDEX [IX_FK_EB_LanctoPedidos_fk]
ON [dbo].[EB_LanctoPedidos]
    ([ClienteID]);
GO

-- Creating foreign key on [ContaID] in table 'EB_ContaLancto'
ALTER TABLE [dbo].[EB_ContaLancto]
ADD CONSTRAINT [FK__EB_ContaL__Conta__2FCF1A8A]
    FOREIGN KEY ([ContaID])
    REFERENCES [dbo].[EB_ContaCorrente]
        ([ContaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_ContaL__Conta__2FCF1A8A'
CREATE INDEX [IX_FK__EB_ContaL__Conta__2FCF1A8A]
ON [dbo].[EB_ContaLancto]
    ([ContaID]);
GO

-- Creating foreign key on [DestOuOrigDescontoContaCorrenteID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_Contas_fk4]
    FOREIGN KEY ([DestOuOrigDescontoContaCorrenteID])
    REFERENCES [dbo].[EB_ContaCorrente]
        ([ContaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_Contas_fk4'
CREATE INDEX [IX_FK_EB_Contas_fk4]
ON [dbo].[EB_Contas]
    ([DestOuOrigDescontoContaCorrenteID]);
GO

-- Creating foreign key on [TipoLanctoID] in table 'EB_ContaLancto'
ALTER TABLE [dbo].[EB_ContaLancto]
ADD CONSTRAINT [FK__EB_ContaL__TipoL__30C33EC3]
    FOREIGN KEY ([TipoLanctoID])
    REFERENCES [dbo].[EB_ContaTipoLancto]
        ([TipoLanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_ContaL__TipoL__30C33EC3'
CREATE INDEX [IX_FK__EB_ContaL__TipoL__30C33EC3]
ON [dbo].[EB_ContaLancto]
    ([TipoLanctoID]);
GO

-- Creating foreign key on [FormaPagamentoID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_FORMA]
    FOREIGN KEY ([FormaPagamentoID])
    REFERENCES [dbo].[EB_FormaPagamento]
        ([FormaPagamentoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CONTA_REFERENCE_EB_FORMA'
CREATE INDEX [IX_FK_EB_CONTA_REFERENCE_EB_FORMA]
ON [dbo].[EB_Contas]
    ([FormaPagamentoID]);
GO

-- Creating foreign key on [lanctoID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_LANCA]
    FOREIGN KEY ([lanctoID])
    REFERENCES [dbo].[EB_Lancamento]
        ([LanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CONTA_REFERENCE_EB_LANCA'
CREATE INDEX [IX_FK_EB_CONTA_REFERENCE_EB_LANCA]
ON [dbo].[EB_Contas]
    ([lanctoID]);
GO

-- Creating foreign key on [PlanoContaID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_PLANO]
    FOREIGN KEY ([PlanoContaID])
    REFERENCES [dbo].[EB_PlanoContas]
        ([PlanoContaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CONTA_REFERENCE_EB_PLANO'
CREATE INDEX [IX_FK_EB_CONTA_REFERENCE_EB_PLANO]
ON [dbo].[EB_Contas]
    ([PlanoContaID]);
GO

-- Creating foreign key on [TipoLanctoID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_TIPOL]
    FOREIGN KEY ([TipoLanctoID])
    REFERENCES [dbo].[EB_TipoLancto]
        ([TipoLanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_CONTA_REFERENCE_EB_TIPOL'
CREATE INDEX [IX_FK_EB_CONTA_REFERENCE_EB_TIPOL]
ON [dbo].[EB_Contas]
    ([TipoLanctoID]);
GO

-- Creating foreign key on [FornecedorID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_Contas_fk]
    FOREIGN KEY ([FornecedorID])
    REFERENCES [dbo].[EB_Fornecedor]
        ([FornecedorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_Contas_fk'
CREATE INDEX [IX_FK_EB_Contas_fk]
ON [dbo].[EB_Contas]
    ([FornecedorID]);
GO

-- Creating foreign key on [DestDescontoID] in table 'EB_Contas'
ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_Contas_fk2]
    FOREIGN KEY ([DestDescontoID])
    REFERENCES [dbo].[EB_ContasDestDesconto]
        ([DestDescontoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_Contas_fk2'
CREATE INDEX [IX_FK_EB_Contas_fk2]
ON [dbo].[EB_Contas]
    ([DestDescontoID]);
GO

-- Creating foreign key on [ContasDestDescontoID] in table 'EB_LancamentoCaixaBanco'
ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk3]
    FOREIGN KEY ([ContasDestDescontoID])
    REFERENCES [dbo].[EB_ContasDestDesconto]
        ([DestDescontoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EN_LancamentoCaixaBanco_fk3'
CREATE INDEX [IX_FK_EN_LancamentoCaixaBanco_fk3]
ON [dbo].[EB_LancamentoCaixaBanco]
    ([ContasDestDescontoID]);
GO

-- Creating foreign key on [EnderecoID] in table 'EB_LanctoPedidos'
ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD CONSTRAINT [FK_EB_LanctoPedidos_fk2]
    FOREIGN KEY ([EnderecoID])
    REFERENCES [dbo].[EB_Endereco]
        ([EnderecoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LanctoPedidos_fk2'
CREATE INDEX [IX_FK_EB_LanctoPedidos_fk2]
ON [dbo].[EB_LanctoPedidos]
    ([EnderecoID]);
GO

-- Creating foreign key on [EntregadorID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK__EB_Lancam__Entre__3587F3E0]
    FOREIGN KEY ([EntregadorID])
    REFERENCES [dbo].[EB_Entregador]
        ([EntregadorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__Entre__3587F3E0'
CREATE INDEX [IX_FK__EB_Lancam__Entre__3587F3E0]
ON [dbo].[EB_Lancamento]
    ([EntregadorID]);
GO

-- Creating foreign key on [EstoqueLanctoID] in table 'EB_EstoqueLancItens'
ALTER TABLE [dbo].[EB_EstoqueLancItens]
ADD CONSTRAINT [FK_EB_EstoqueLanctoItens_fk]
    FOREIGN KEY ([EstoqueLanctoID])
    REFERENCES [dbo].[EB_EstoqueLancto]
        ([EstoqueLanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_EstoqueLanctoItens_fk'
CREATE INDEX [IX_FK_EB_EstoqueLanctoItens_fk]
ON [dbo].[EB_EstoqueLancItens]
    ([EstoqueLanctoID]);
GO

-- Creating foreign key on [ProdutoID] in table 'EB_EstoqueLancItens'
ALTER TABLE [dbo].[EB_EstoqueLancItens]
ADD CONSTRAINT [FK_EB_EstoqueLanctoItens_fk2]
    FOREIGN KEY ([ProdutoID])
    REFERENCES [dbo].[EB_Produto]
        ([ProdutoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_EstoqueLanctoItens_fk2'
CREATE INDEX [IX_FK_EB_EstoqueLanctoItens_fk2]
ON [dbo].[EB_EstoqueLancItens]
    ([ProdutoID]);
GO

-- Creating foreign key on [TipoMovID] in table 'EB_EstoqueLancto'
ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD CONSTRAINT [FK_EB_EstoqueLancto_fk]
    FOREIGN KEY ([TipoMovID])
    REFERENCES [dbo].[EB_TipoLancto]
        ([TipoLanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_EstoqueLancto_fk'
CREATE INDEX [IX_FK_EB_EstoqueLancto_fk]
ON [dbo].[EB_EstoqueLancto]
    ([TipoMovID]);
GO

-- Creating foreign key on [FornecedorID] in table 'EB_EstoqueLancto'
ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD CONSTRAINT [FK_EB_EstoqueLancto_fk2]
    FOREIGN KEY ([FornecedorID])
    REFERENCES [dbo].[EB_Fornecedor]
        ([FornecedorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_EstoqueLancto_fk2'
CREATE INDEX [IX_FK_EB_EstoqueLancto_fk2]
ON [dbo].[EB_EstoqueLancto]
    ([FornecedorID]);
GO

-- Creating foreign key on [UsuarioID] in table 'EB_EstoqueLancto'
ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD CONSTRAINT [FK_EB_EstoqueLancto_fk3]
    FOREIGN KEY ([UsuarioID])
    REFERENCES [dbo].[EB_Usuario]
        ([UsuarioID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_EstoqueLancto_fk3'
CREATE INDEX [IX_FK_EB_EstoqueLancto_fk3]
ON [dbo].[EB_EstoqueLancto]
    ([UsuarioID]);
GO

-- Creating foreign key on [CondicaoID] in table 'EB_FormaPagamento'
ALTER TABLE [dbo].[EB_FormaPagamento]
ADD CONSTRAINT [FK_EB_FormaPagamento_fk]
    FOREIGN KEY ([CondicaoID])
    REFERENCES [dbo].[EB_FormaPagamentoCondicao]
        ([CondicaoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_FormaPagamento_fk'
CREATE INDEX [IX_FK_EB_FormaPagamento_fk]
ON [dbo].[EB_FormaPagamento]
    ([CondicaoID]);
GO

-- Creating foreign key on [FormaPagamentoID] in table 'EB_LancamentoFechamentoFormasPag'
ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_FORMA]
    FOREIGN KEY ([FormaPagamentoID])
    REFERENCES [dbo].[EB_FormaPagamento]
        ([FormaPagamentoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LANCA_REFERENCE_EB_FORMA'
CREATE INDEX [IX_FK_EB_LANCA_REFERENCE_EB_FORMA]
ON [dbo].[EB_LancamentoFechamentoFormasPag]
    ([FormaPagamentoID]);
GO

-- Creating foreign key on [FormaPagamentoID] in table 'EB_LancamentoAdiantamentos'
ALTER TABLE [dbo].[EB_LancamentoAdiantamentos]
ADD CONSTRAINT [FK_EB_LancamentoAdiantamentos_fk2]
    FOREIGN KEY ([FormaPagamentoID])
    REFERENCES [dbo].[EB_FormaPagamento]
        ([FormaPagamentoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LancamentoAdiantamentos_fk2'
CREATE INDEX [IX_FK_EB_LancamentoAdiantamentos_fk2]
ON [dbo].[EB_LancamentoAdiantamentos]
    ([FormaPagamentoID]);
GO

-- Creating foreign key on [formaPagamentoID] in table 'EB_LancamentoCaixaBanco'
ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk2]
    FOREIGN KEY ([formaPagamentoID])
    REFERENCES [dbo].[EB_FormaPagamento]
        ([FormaPagamentoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EN_LancamentoCaixaBanco_fk2'
CREATE INDEX [IX_FK_EN_LancamentoCaixaBanco_fk2]
ON [dbo].[EB_LancamentoCaixaBanco]
    ([formaPagamentoID]);
GO

-- Creating foreign key on [FornecedorID] in table 'EB_Produto'
ALTER TABLE [dbo].[EB_Produto]
ADD CONSTRAINT [FK__EB_Produt__Forne__47A6A41B]
    FOREIGN KEY ([FornecedorID])
    REFERENCES [dbo].[EB_Fornecedor]
        ([FornecedorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Produt__Forne__47A6A41B'
CREATE INDEX [IX_FK__EB_Produt__Forne__47A6A41B]
ON [dbo].[EB_Produto]
    ([FornecedorID]);
GO

-- Creating foreign key on [GarconID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK__EB_Lancam__Garco__367C1819]
    FOREIGN KEY ([GarconID])
    REFERENCES [dbo].[EB_Garcon]
        ([GarconID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__Garco__367C1819'
CREATE INDEX [IX_FK__EB_Lancam__Garco__367C1819]
ON [dbo].[EB_Lancamento]
    ([GarconID]);
GO

-- Creating foreign key on [GrupoID] in table 'EB_Produto'
ALTER TABLE [dbo].[EB_Produto]
ADD CONSTRAINT [FK__EB_Produt__Grupo__489AC854]
    FOREIGN KEY ([GrupoID])
    REFERENCES [dbo].[EB_GrupoProduto]
        ([GrupoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Produt__Grupo__489AC854'
CREATE INDEX [IX_FK__EB_Produt__Grupo__489AC854]
ON [dbo].[EB_Produto]
    ([GrupoID]);
GO

-- Creating foreign key on [pai] in table 'EB_GrupoProduto'
ALTER TABLE [dbo].[EB_GrupoProduto]
ADD CONSTRAINT [FK_EB_GrupoProduto_fk]
    FOREIGN KEY ([pai])
    REFERENCES [dbo].[EB_GrupoProduto]
        ([GrupoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_GrupoProduto_fk'
CREATE INDEX [IX_FK_EB_GrupoProduto_fk]
ON [dbo].[EB_GrupoProduto]
    ([pai]);
GO

-- Creating foreign key on [TipoProdutoID] in table 'EB_Impressoras'
ALTER TABLE [dbo].[EB_Impressoras]
ADD CONSTRAINT [FK_EB_IMPRE_REFERENCE_EB_TIPOP]
    FOREIGN KEY ([TipoProdutoID])
    REFERENCES [dbo].[EB_TipoProduto]
        ([TipoProdutoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_IMPRE_REFERENCE_EB_TIPOP'
CREATE INDEX [IX_FK_EB_IMPRE_REFERENCE_EB_TIPOP]
ON [dbo].[EB_Impressoras]
    ([TipoProdutoID]);
GO

-- Creating foreign key on [LanctoID] in table 'EB_LancamentoItens'
ALTER TABLE [dbo].[EB_LancamentoItens]
ADD CONSTRAINT [FK__EB_Lancam__Lanct__70A8B9AE]
    FOREIGN KEY ([LanctoID])
    REFERENCES [dbo].[EB_Lancamento]
        ([LanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__Lanct__70A8B9AE'
CREATE INDEX [IX_FK__EB_Lancam__Lanct__70A8B9AE]
ON [dbo].[EB_LancamentoItens]
    ([LanctoID]);
GO

-- Creating foreign key on [TipoLanctoID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK__EB_Lancam__TipoL__3864608B]
    FOREIGN KEY ([TipoLanctoID])
    REFERENCES [dbo].[EB_TipoLancto]
        ([TipoLanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__TipoL__3864608B'
CREATE INDEX [IX_FK__EB_Lancam__TipoL__3864608B]
ON [dbo].[EB_Lancamento]
    ([TipoLanctoID]);
GO

-- Creating foreign key on [TipoVendaID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK__EB_Lancam__TipoV__395884C4]
    FOREIGN KEY ([TipoVendaID])
    REFERENCES [dbo].[EB_TipoVenda]
        ([TipoVendaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__TipoV__395884C4'
CREATE INDEX [IX_FK__EB_Lancam__TipoV__395884C4]
ON [dbo].[EB_Lancamento]
    ([TipoVendaID]);
GO

-- Creating foreign key on [UsuarioID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK__EB_Lancam__Usuar__3A4CA8FD]
    FOREIGN KEY ([UsuarioID])
    REFERENCES [dbo].[EB_Usuario]
        ([UsuarioID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__Usuar__3A4CA8FD'
CREATE INDEX [IX_FK__EB_Lancam__Usuar__3A4CA8FD]
ON [dbo].[EB_Lancamento]
    ([UsuarioID]);
GO

-- Creating foreign key on [StatusID] in table 'EB_Lancamento'
ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_LANCA]
    FOREIGN KEY ([StatusID])
    REFERENCES [dbo].[EB_LancamentoStatus]
        ([StatusID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LANCA_REFERENCE_EB_LANCA'
CREATE INDEX [IX_FK_EB_LANCA_REFERENCE_EB_LANCA]
ON [dbo].[EB_Lancamento]
    ([StatusID]);
GO

-- Creating foreign key on [LanctoID] in table 'EB_LancamentoFechamentoFormasPag'
ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_LANCA_FECHA]
    FOREIGN KEY ([LanctoID])
    REFERENCES [dbo].[EB_Lancamento]
        ([LanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LANCA_REFERENCE_EB_LANCA_FECHA'
CREATE INDEX [IX_FK_EB_LANCA_REFERENCE_EB_LANCA_FECHA]
ON [dbo].[EB_LancamentoFechamentoFormasPag]
    ([LanctoID]);
GO

-- Creating foreign key on [LanctoID] in table 'EB_LancamentoAdiantamentos'
ALTER TABLE [dbo].[EB_LancamentoAdiantamentos]
ADD CONSTRAINT [FK_EB_LancamentoAdiantamentos_fk]
    FOREIGN KEY ([LanctoID])
    REFERENCES [dbo].[EB_Lancamento]
        ([LanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LancamentoAdiantamentos_fk'
CREATE INDEX [IX_FK_EB_LancamentoAdiantamentos_fk]
ON [dbo].[EB_LancamentoAdiantamentos]
    ([LanctoID]);
GO

-- Creating foreign key on [LanctoID] in table 'EB_LanctoPedidos'
ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD CONSTRAINT [FK_EB_LanctoPedidos_fk3]
    FOREIGN KEY ([LanctoID])
    REFERENCES [dbo].[EB_Lancamento]
        ([LanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_LanctoPedidos_fk3'
CREATE INDEX [IX_FK_EB_LanctoPedidos_fk3]
ON [dbo].[EB_LanctoPedidos]
    ([LanctoID]);
GO

-- Creating foreign key on [TipoLanctoID] in table 'EB_LancamentoCaixaBanco'
ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk]
    FOREIGN KEY ([TipoLanctoID])
    REFERENCES [dbo].[EB_TipoLancto]
        ([TipoLanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EN_LancamentoCaixaBanco_fk'
CREATE INDEX [IX_FK_EN_LancamentoCaixaBanco_fk]
ON [dbo].[EB_LancamentoCaixaBanco]
    ([TipoLanctoID]);
GO

-- Creating foreign key on [ProdutoID] in table 'EB_LancamentoItens'
ALTER TABLE [dbo].[EB_LancamentoItens]
ADD CONSTRAINT [FK__EB_Lancam__Produ__59C55456]
    FOREIGN KEY ([ProdutoID])
    REFERENCES [dbo].[EB_Produto]
        ([ProdutoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Lancam__Produ__59C55456'
CREATE INDEX [IX_FK__EB_Lancam__Produ__59C55456]
ON [dbo].[EB_LancamentoItens]
    ([ProdutoID]);
GO

-- Creating foreign key on [OrigemID] in table 'EB_Produto'
ALTER TABLE [dbo].[EB_Produto]
ADD CONSTRAINT [FK__EB_Produt__Orige__498EEC8D]
    FOREIGN KEY ([OrigemID])
    REFERENCES [dbo].[EB_OrigemProduto]
        ([OrigemID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Produt__Orige__498EEC8D'
CREATE INDEX [IX_FK__EB_Produt__Orige__498EEC8D]
ON [dbo].[EB_Produto]
    ([OrigemID]);
GO

-- Creating foreign key on [TipoLanctoID] in table 'EB_PlanoContas'
ALTER TABLE [dbo].[EB_PlanoContas]
ADD CONSTRAINT [FK_EB_PlanoContas_fk]
    FOREIGN KEY ([TipoLanctoID])
    REFERENCES [dbo].[EB_TipoLancto]
        ([TipoLanctoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_PlanoContas_fk'
CREATE INDEX [IX_FK_EB_PlanoContas_fk]
ON [dbo].[EB_PlanoContas]
    ([TipoLanctoID]);
GO

-- Creating foreign key on [Pai] in table 'EB_PlanoContas'
ALTER TABLE [dbo].[EB_PlanoContas]
ADD CONSTRAINT [FK_EB_PlanoContas_fk2]
    FOREIGN KEY ([Pai])
    REFERENCES [dbo].[EB_PlanoContas]
        ([PlanoContaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_PlanoContas_fk2'
CREATE INDEX [IX_FK_EB_PlanoContas_fk2]
ON [dbo].[EB_PlanoContas]
    ([Pai]);
GO

-- Creating foreign key on [TipoProdutoID] in table 'EB_Produto'
ALTER TABLE [dbo].[EB_Produto]
ADD CONSTRAINT [FK__EB_Produt__TipoP__4A8310C6]
    FOREIGN KEY ([TipoProdutoID])
    REFERENCES [dbo].[EB_TipoProduto]
        ([TipoProdutoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__EB_Produt__TipoP__4A8310C6'
CREATE INDEX [IX_FK__EB_Produt__TipoP__4A8310C6]
ON [dbo].[EB_Produto]
    ([TipoProdutoID]);
GO

-- Creating foreign key on [ProdutoID] in table 'EB_ProdutoComp'
ALTER TABLE [dbo].[EB_ProdutoComp]
ADD CONSTRAINT [FK_EB_PRODU_REFERENCE_EB_PRODU]
    FOREIGN KEY ([ProdutoID])
    REFERENCES [dbo].[EB_Produto]
        ([ProdutoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_PRODU_REFERENCE_EB_PRODU'
CREATE INDEX [IX_FK_EB_PRODU_REFERENCE_EB_PRODU]
ON [dbo].[EB_ProdutoComp]
    ([ProdutoID]);
GO

-- Creating foreign key on [ProdutoPrincipalID] in table 'EB_ProdutoComp'
ALTER TABLE [dbo].[EB_ProdutoComp]
ADD CONSTRAINT [FK_EB_ProdutoComp_fk]
    FOREIGN KEY ([ProdutoPrincipalID])
    REFERENCES [dbo].[EB_Produto]
        ([ProdutoID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EB_ProdutoComp_fk'
CREATE INDEX [IX_FK_EB_ProdutoComp_fk]
ON [dbo].[EB_ProdutoComp]
    ([ProdutoPrincipalID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------