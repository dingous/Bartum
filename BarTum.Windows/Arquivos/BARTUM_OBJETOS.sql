-- SQL Manager Lite for SQL Server 3.8.0.4
-- ---------------------------------------
-- Host      : LOCALHOST\BARTUM
-- Database  : BARTUM
-- Version   : Microsoft SQL Server  10.50.4000.0


--
-- Definition for table EB_Estado : 
--

CREATE TABLE [dbo].[EB_Estado] (
  [EstadoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsNome] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dsSigla] char(2) COLLATE Latin1_General_CI_AS NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Cidade : 
--

CREATE TABLE [dbo].[EB_Cidade] (
  [CidadeID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [EstadoID] decimal(11, 0) NOT NULL,
  [dsNome] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Bairro : 
--

CREATE TABLE [dbo].[EB_Bairro] (
  [BairroID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [CidadeID] decimal(11, 0) NOT NULL,
  [dsNome] varchar(120) COLLATE Latin1_General_CI_AS NOT NULL,
  [nrTaxaEntrega] decimal(13, 2) NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Balcao : 
--

CREATE TABLE [dbo].[EB_Balcao] (
  [BalcaoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsBalcao] varchar(100) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]


--
-- Definition for table EB_CadastroMesa : 
--

CREATE TABLE [dbo].[EB_CadastroMesa] (
  [MesaID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsMesa] varchar(100) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Caixa : 
--

CREATE TABLE [dbo].[EB_Caixa] (
  [CaixaID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dtCaixa] date NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Usuario : 
--

CREATE TABLE [dbo].[EB_Usuario] (
  [UsuarioID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [EmpresaID] decimal(11, 0) NOT NULL,
  [dsNome] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dsLogin] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dsSenha] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrStatus] decimal(1, 0) NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_CaixaHistoricoFechamento : 
--

CREATE TABLE [dbo].[EB_CaixaHistoricoFechamento] (
  [HistoricoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [CaixaID] decimal(11, 0) NULL,
  [UsuarioIDAbertura] decimal(11, 0) NULL,
  [dtCaixaAbertura] datetime NULL,
  [UsuarioIDFechamento] decimal(11, 0) NULL,
  [dtCaixaFechamento] datetime NULL,
  [fechamentoSaldoComputado] decimal(11, 2) NULL,
  [fechamentoTotalFisicoCaixa] decimal(11, 2) NULL,
  [fechamentoFundoCaixa] decimal(11, 2) NULL,
  [fechamentoDiferenca] decimal(11, 2) NULL,
  [dsStatus] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [vlCaixa] decimal(13, 2) NULL,
  [vlAberturaCaixa] decimal(13, 2) NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Contato : 
--

CREATE TABLE [dbo].[EB_Contato] (
  [ContatoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [nrTelefone1] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [nrTelefone2] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [nrTelefone3] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [nrTelefone4] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [nrCelular] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [dsNomeContato] varchar(30) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Endereco : 
--

CREATE TABLE [dbo].[EB_Endereco] (
  [EnderecoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [CidadeID] decimal(11, 0) NULL,
  [BairroID] decimal(11, 0) NULL,
  [ClienteID] decimal(11, 0) NULL,
  [dsLogradouro] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dsComplemento] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrNumero] varchar(11) COLLATE Latin1_General_CI_AS NULL,
  [nrCEP] varchar(9) COLLATE Latin1_General_CI_AS NULL,
  [dsRegiao] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [dsReferencias] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [flEnderecoPrincipal] bit NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Cliente : 
--

CREATE TABLE [dbo].[EB_Cliente] (
  [ClienteID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [EnderecoID] decimal(11, 0) NULL,
  [ContatoID] decimal(11, 0) NULL,
  [UsuarioID] decimal(11, 0) NULL,
  [dsNome] varchar(150) COLLATE Latin1_General_CI_AS NOT NULL,
  [dtNascimento] datetime NULL,
  [nrCpfCpnj] varchar(11) COLLATE Latin1_General_CI_AS NULL,
  [dsEmail] varchar(150) COLLATE Latin1_General_CI_AS NULL,
  [dtCadastro] datetime NOT NULL,
  [nrStatus] decimal(18, 0) NULL,
  [convenio] bit NULL,
  [flExcluido] bit NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_ClienteOcorrencias : 
--

CREATE TABLE [dbo].[EB_ClienteOcorrencias] (
  [OcorrenciaID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [ClienteID] decimal(11, 0) NOT NULL,
  [dsOcorrencia] varchar(max) COLLATE Latin1_General_CI_AS NOT NULL,
  [dtOcorrencia] datetime NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_ConfiguracoesSistema : 
--

CREATE TABLE [dbo].[EB_ConfiguracoesSistema] (
  [ConfID] decimal(11, 0) NOT NULL,
  [impressaoCabecalho] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [impressaoRodape] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [flTaxaServicoAtiva] bit NULL,
  [ServidorIP] varchar(20) COLLATE Latin1_General_CI_AS NULL,
  [ServidorPorta] int NULL
)
ON [PRIMARY]


--
-- Definition for table EB_ContaCorrente : 
--

CREATE TABLE [dbo].[EB_ContaCorrente] (
  [ContaID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsDescricao] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrContaNumero] decimal(20, 0) NULL,
  [dtReferencia] datetime NULL,
  [mnSaldoInicial] decimal(11, 3) NULL,
  [mnLimite] decimal(11, 3) NULL,
  [dsAgencia] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dsNomeGerente] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrTelefone] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dtCadastro] datetime NULL
)
ON [PRIMARY]


--
-- Definition for table EB_ContaTipoLancto : 
--

CREATE TABLE [dbo].[EB_ContaTipoLancto] (
  [TipoLanctoID] decimal(11, 0) NOT NULL,
  [dsTipoLancto] varchar(100) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]


--
-- Definition for table EB_ContaLancto : 
--

CREATE TABLE [dbo].[EB_ContaLancto] (
  [LanctoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [ContaID] decimal(11, 0) NOT NULL,
  [TipoLanctoID] decimal(11, 0) NOT NULL,
  [nrValor] float NULL,
  [dsObservacao] varchar(max) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]


--
-- Definition for table EB_ContasDestDesconto : 
--

CREATE TABLE [dbo].[EB_ContasDestDesconto] (
  [DestDescontoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsDestinoDesconto] varchar(200) COLLATE Latin1_General_CI_AS NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_TipoLancto : 
--

CREATE TABLE [dbo].[EB_TipoLancto] (
  [TipoLanctoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsTipoLancto] varchar(100) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]


--
-- Definition for table EB_PlanoContas : 
--

CREATE TABLE [dbo].[EB_PlanoContas] (
  [PlanoContaID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [TipoLanctoID] decimal(11, 0) NOT NULL,
  [Pai] decimal(11, 0) NULL,
  [dsPlanoConta] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [flPadraoSaida] bit NULL
)
ON [PRIMARY]


--
-- Definition for table EB_FormaPagamentoCondicao : 
--

CREATE TABLE [dbo].[EB_FormaPagamentoCondicao] (
  [CondicaoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsCondicaoPagamento] varchar(200) COLLATE Latin1_General_CI_AS NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_FormaPagamento : 
--

CREATE TABLE [dbo].[EB_FormaPagamento] (
  [FormaPagamentoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [CondicaoID] decimal(11, 0) NULL,
  [dsForma] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [ordem] int NULL,
  [flMostrarnoContas] bit NULL,
  [dtCadastro] datetime NULL,
  [Flexcluido] bit NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Fornecedor : 
--

CREATE TABLE [dbo].[EB_Fornecedor] (
  [FornecedorID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsNomeFantasia] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dsRazaoSocial] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrCNPJ] decimal(11, 0) NULL,
  [nrInsEstadual] decimal(11, 0) NULL,
  [nrTelefone] varchar(14) COLLATE Latin1_General_CI_AS NULL,
  [nrFax] varchar(14) COLLATE Latin1_General_CI_AS NULL,
  [nrCelular] varchar(14) COLLATE Latin1_General_CI_AS NULL,
  [nrNomeContato] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dsLogradouro] varchar(120) COLLATE Latin1_General_CI_AS NULL,
  [dsCidade] varchar(120) COLLATE Latin1_General_CI_AS NULL,
  [dsUfEstado] varchar(2) COLLATE Latin1_General_CI_AS NULL,
  [nrCEP] varchar(10) COLLATE Latin1_General_CI_AS NULL,
  [dsEmail] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dsSite] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dsObservacao] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [dtCadastro] datetime NULL
)
ON [PRIMARY]


--
-- Definition for table EB_LancamentoStatus : 
--

CREATE TABLE [dbo].[EB_LancamentoStatus] (
  [StatusID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsStatus] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Entregador : 
--

CREATE TABLE [dbo].[EB_Entregador] (
  [EntregadorID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsNome] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dsEndereco] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrTelefoneFixo] char(18) COLLATE Latin1_General_CI_AS NULL,
  [nrTelefoneCelular] char(18) COLLATE Latin1_General_CI_AS NULL,
  [dtCadastro] datetime NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Garcon : 
--

CREATE TABLE [dbo].[EB_Garcon] (
  [GarconID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsNome] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dsEndereco] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [nrTelefone] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrCelular] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrComissao] float NOT NULL,
  [dtCadastro] datetime NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_TipoVenda : 
--

CREATE TABLE [dbo].[EB_TipoVenda] (
  [TipoVendaID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsTipoVenda] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dtCadastro] datetime NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Lancamento : 
--

CREATE TABLE [dbo].[EB_Lancamento] (
  [LanctoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [CaixaID] decimal(11, 0) NOT NULL,
  [MesaID] decimal(11, 0) NULL,
  [TipoVendaID] decimal(11, 0) NOT NULL,
  [TipoLanctoID] decimal(11, 0) NOT NULL,
  [GarconID] decimal(11, 0) NULL,
  [BalcaoID] decimal(11, 0) NULL,
  [EntregadorID] decimal(11, 0) NULL,
  [UsuarioID] decimal(11, 0) NULL,
  [StatusID] decimal(11, 0) NULL,
  [ClienteID] decimal(11, 0) NULL,
  [nrOcupantes] decimal(11, 0) NULL,
  [dtLancto] datetime NULL,
  [dtFimLancto] datetime NULL,
  [dsNomeClienteBalcao] varchar(200) COLLATE Latin1_General_CI_AS NULL,
  [dsObservacao] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [FechaTotalConsumo] decimal(13, 2) NULL,
  [FechaAcrescimo] decimal(13, 2) NULL,
  [FechaDescontos] decimal(13, 2) NULL,
  [FechaAdiantamento] decimal(13, 2) NULL,
  [FechaTotalPago] decimal(13, 2) NULL,
  [FechaTroco] decimal(13, 2) NULL,
  [FechaCouver] decimal(13, 2) NULL,
  [FechaTotalVendaFinalizada] decimal(11, 2) NULL,
  [flVendaCancelada] bit DEFAULT 0 NOT NULL,
  [flComissaoGarconFoiPaga] bit NULL,
  [ComandaID] decimal(11, 0) NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Contas : 
--

CREATE TABLE [dbo].[EB_Contas] (
  [contasID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [pai] decimal(11, 0) NULL,
  [lanctoID] decimal(11, 0) NULL,
  [clienteID] decimal(11, 0) NULL,
  [FornecedorID] decimal(11, 0) NULL,
  [FormaPagamentoID] decimal(11, 0) NULL,
  [PlanoContaID] decimal(11, 0) NULL,
  [TipoLanctoID] decimal(11, 0) NULL,
  [usuarioID] decimal(11, 0) NOT NULL,
  [dtlancto] datetime NULL,
  [descricao] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [vlConta] decimal(13, 2) NULL,
  [dtVencimento] datetime NULL,
  [observacoes] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [dtPagamentoOuRecebimento] datetime NULL,
  [fechaValorPago] decimal(13, 2) NULL,
  [DestDescontoID] decimal(11, 0) NULL,
  [DestOuOrigDescontoContaCorrenteID] decimal(11, 0) NULL,
  [flBaixada] bit NOT NULL,
  [CaixaID] decimal(11, 0) NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Empresa : 
--

CREATE TABLE [dbo].[EB_Empresa] (
  [EmpresaID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsNomeFantasia] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dsRazaoSocial] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [nrCnpj] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [tel1] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [tel2] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [cel] varchar(30) COLLATE Latin1_General_CI_AS NULL,
  [dsEmail] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [dsEndereco] varchar(200) COLLATE Latin1_General_CI_AS NULL,
  [dsBairro] varchar(150) COLLATE Latin1_General_CI_AS NULL,
  [DsCidade] varchar(150) COLLATE Latin1_General_CI_AS NULL,
  [siglaUF] varchar(2) COLLATE Latin1_General_CI_AS NULL,
  [inscEstadual] varchar(150) COLLATE Latin1_General_CI_AS NULL
)
ON [PRIMARY]


--
-- Definition for table EB_TipoProduto : 
--

CREATE TABLE [dbo].[EB_TipoProduto] (
  [TipoProdutoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsTipoProduto] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_GrupoProduto : 
--

CREATE TABLE [dbo].[EB_GrupoProduto] (
  [GrupoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsGrupo] varchar(100) COLLATE Latin1_General_CI_AS NULL,
  [pai] decimal(11, 0) NULL,
  [flExcluido] bit NULL
)
ON [PRIMARY]


--
-- Definition for table EB_OrigemProduto : 
--

CREATE TABLE [dbo].[EB_OrigemProduto] (
  [OrigemID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [dsOrigem] varchar(100) COLLATE Latin1_General_CI_AS NOT NULL,
  [dsImpressora] varchar(200) COLLATE Latin1_General_CI_AS NULL,
  [flMostrar] bit NOT NULL,
  [impressaoObrigatoria] bit NOT NULL,
  [impressoraPedidos] bit NOT NULL,
  [tamanhoPapelImpressoraMilimetros] decimal(11, 0) NULL,
  [flPossuiAcentuacao] bit NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Produto : 
--

CREATE TABLE [dbo].[EB_Produto] (
  [ProdutoID] decimal(11, 0) NOT NULL,
  [nrCodigoBarras] decimal(20, 0) NULL,
  [OrigemID] decimal(11, 0) NOT NULL,
  [GrupoID] decimal(11, 0) NULL,
  [FornecedorID] decimal(11, 0) NULL,
  [TipoProdutoID] decimal(11, 0) NULL,
  [dsProduto] varchar(120) COLLATE Latin1_General_CI_AS NOT NULL,
  [nrUnidade] int NOT NULL,
  [nrPrecoCusto] decimal(13, 2) NULL,
  [nrPrecoVenda] decimal(13, 2) NULL,
  [nrEstoqueMin] decimal(11, 0) NULL,
  [nrEstoqueMax] decimal(11, 0) NULL,
  [nrEstoqueAtual] decimal(11, 0) NOT NULL,
  [dtCadastro] datetime NULL,
  [flExcluido] bit NULL
)
ON [PRIMARY]


--
-- Definition for table EB_EstoqueLancto : 
--

CREATE TABLE [dbo].[EB_EstoqueLancto] (
  [EstoqueLanctoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [TipoMovID] decimal(11, 0) NOT NULL,
  [UsuarioID] decimal(11, 0) NOT NULL,
  [FornecedorID] decimal(11, 0) NULL,
  [nrNota] varchar(200) COLLATE Latin1_General_CI_AS NULL,
  [dtLancto] datetime NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_EstoqueLancItens : 
--

CREATE TABLE [dbo].[EB_EstoqueLancItens] (
  [EstoqueLanctoItemID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [EstoqueLanctoID] decimal(11, 0) NULL,
  [ProdutoID] decimal(11, 0) NOT NULL,
  [nrQuantidade] decimal(11, 0) NOT NULL,
  [nrPrCusto] decimal(11, 2) NOT NULL,
  [vlTotal] decimal(11, 2) NOT NULL,
  [dtLancto] datetime NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_Impressoras : 
--

CREATE TABLE [dbo].[EB_Impressoras] (
  [ImpressoraID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [TipoProdutoID] decimal(11, 0) NULL,
  [dsImpressora] varchar(150) COLLATE Latin1_General_CI_AS NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_LancamentoAdiantamentos : 
--

CREATE TABLE [dbo].[EB_LancamentoAdiantamentos] (
  [AdiantamentoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [LanctoID] decimal(11, 0) NOT NULL,
  [FormaPagamentoID] decimal(11, 0) NOT NULL,
  [vlTotalAPagarContaNoMomento] decimal(13, 2) NOT NULL,
  [vlPagamentoCliente] decimal(13, 2) NOT NULL,
  [vlRecebidoCliente] decimal(13, 2) NOT NULL,
  [vlTroco] decimal(13, 2) NULL,
  [dsObservacao] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [dtDataHora] datetime NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_LancamentoCaixaBanco : 
--

CREATE TABLE [dbo].[EB_LancamentoCaixaBanco] (
  [LanctoCaixaBancoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [TipoLanctoID] decimal(11, 0) NULL,
  [formaPagamentoID] decimal(11, 0) NOT NULL,
  [ContasDestDescontoID] decimal(11, 0) NOT NULL,
  [dsDescricao] varchar(max) COLLATE Latin1_General_CI_AS NOT NULL,
  [dtLancto] datetime NOT NULL,
  [vlValor] decimal(11, 2) NOT NULL,
  [dtInsercao] datetime NOT NULL,
  [CaixaID] decimal(11, 0) NULL
)
ON [PRIMARY]


--
-- Definition for table EB_LancamentoFechamentoFormasPag : 
--

CREATE TABLE [dbo].[EB_LancamentoFechamentoFormasPag] (
  [fechamentoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [LanctoID] decimal(11, 0) NOT NULL,
  [FormaPagamentoID] decimal(11, 0) NOT NULL,
  [vlForma] decimal(13, 2) NOT NULL,
  [FlOrigemAdiantamento] bit NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_LancamentoItens : 
--

CREATE TABLE [dbo].[EB_LancamentoItens] (
  [LanctoItemID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [PaiID] decimal(11, 0) DEFAULT 0 NOT NULL,
  [LanctoID] decimal(11, 0) NULL,
  [ProdutoID] decimal(11, 0) NULL,
  [Quantidade] decimal(11, 0) NOT NULL,
  [nrPrecoVenda] decimal(13, 2) NOT NULL,
  [Total] decimal(13, 2) NOT NULL,
  [dsObservacao] varchar(max) COLLATE Latin1_General_CI_AS NULL,
  [dtDataHora] datetime NULL,
  [flParaViagem] bit NOT NULL,
  [flFoiImpresso] bit DEFAULT 0 NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_LanctoPedidos : 
--

CREATE TABLE [dbo].[EB_LanctoPedidos] (
  [PedidoID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [ClienteID] decimal(11, 0) NOT NULL,
  [EnderecoID] decimal(11, 0) NOT NULL,
  [LanctoID] decimal(11, 0) NOT NULL,
  [flRecebido] bit NOT NULL,
  [flPagoAoEntregador] bit NOT NULL
)
ON [PRIMARY]


--
-- Definition for table EB_ProdutoComp : 
--

CREATE TABLE [dbo].[EB_ProdutoComp] (
  [ProdutoCompID] decimal(11, 0) IDENTITY(1, 1) NOT NULL,
  [ProdutoPrincipalID] decimal(11, 0) NOT NULL,
  [ProdutoID] decimal(11, 0) NULL,
  [Quantidade] decimal(11, 0) NULL
)
ON [PRIMARY]


--
-- Definition for table sysdiagrams : 
--

CREATE TABLE [dbo].[sysdiagrams] (
  [name] nvarchar(128) COLLATE Latin1_General_CI_AS NOT NULL,
  [principal_id] int NOT NULL,
  [diagram_id] int IDENTITY(1, 1) NOT NULL,
  [version] int NULL,
  [definition] varbinary(max) NULL
)
ON [PRIMARY]


--
-- Definition for stored procedure PR_CONSULTA_CLIENTE : 
--


exec('

--SET ANSI_NULLS ON
--SET QUOTED_IDENTIFIER ON


CREATE PROCEDURE dbo.PR_CONSULTA_CLIENTE
	 
     @CRITERIO VARCHAR(100) = NULL
   

AS


BEGIN
 
SELECT 
	CLIENTE.CLIENTEID,
	CLIENTE.DSNOME,
	(ENDERECO.DSLOGRADOURO + '', '' + ENDERECO.NRNUMERO + '' - ''+ BAIRRO.DSNOME + '' - '' +  CIDADE.DSNOME + '' - '' +  ESTADO.DSSIGLA) [DSLOGRADOURO],
	CLIENTE.DTNASCIMENTO,
	CLIENTE.NRCPFCPNJ,
	CLIENTE.DSEMAIL,
	CLIENTE.DTCADASTRO,
	CONTATO.NRTELEFONE1,
    CONTATO.NRTELEFONE2,
    CONTATO.NRTELEFONE3,
    CONTATO.NRTELEFONE4,
    CONTATO.NRCELULAR
FROM 
	EB_CLIENTE AS CLIENTE(NOLOCK)
	INNER JOIN EB_ENDERECO AS ENDERECO (NOLOCK)
		ON CLIENTE.ENDERECOID =  ENDERECO.ENDERECOID
	INNER JOIN EB_BAIRRO AS BAIRRO (NOLOCK)
		ON BAIRRO.BAIRROID =  ENDERECO.BAIRROID
	INNER JOIN EB_CIDADE AS CIDADE (NOLOCK)
		ON CIDADE.CIDADEID =  BAIRRO.CIDADEID
	INNER JOIN EB_ESTADO AS ESTADO (NOLOCK)
		ON ESTADO.ESTADOID =  CIDADE.ESTADOID
	INNER JOIN EB_CONTATO AS CONTATO (NOLOCK)
		ON CLIENTE.CONTATOID =  CONTATO.CONTATOID
	INNER JOIN EB_USUARIO AS USUARIO (NOLOCK)
		ON CLIENTE.USUARIOID =  USUARIO.USUARIOID
WHERE
	1=1
	AND 
	(
		CLIENTE.DSNOME LIKE @CRITERIO
		OR DSLOGRADOURO LIKE @CRITERIO
		OR CLIENTE.NRCPFCPNJ LIKE @CRITERIO
		OR CLIENTE.DSEMAIL LIKE @CRITERIO
		OR CONTATO.NRTELEFONE1 LIKE @CRITERIO
		OR CONTATO.NRTELEFONE2 LIKE @CRITERIO
		OR CONTATO.NRTELEFONE3 LIKE @CRITERIO
		OR CONTATO.NRTELEFONE4 LIKE @CRITERIO
		OR CONTATO.NRCELULAR LIKE @CRITERIO
	)
	
			
        
END')


--
-- Definition for stored procedure PR_MESAS_OCUPAS : 
--
--exec('
--SET ANSI_NULLS ON
--SET QUOTED_IDENTIFIER ON

--GO

--CREATE PROCEDURE dbo.PR_MESAS_OCUPAS
--AS
--BEGIN
-- SELECT 
--	 eb_cadastromesa.MesaID AS MesaID,
--     eb_lancamento.LanctoID AS LanctoID,
--     eb_lancamento.StatusID AS StatusID
--FROM 
--	EB_CadastroMesa (NOLOCK)
--    LEFT JOIN EB_Lancamento (NOLOCK)
--		ON EB_CadastroMesa.MesaID = EB_Lancamento.MesaID
--WHERE
--	1=1
--	AND EB_Lancamento.StatusID != 3
--	AND EB_CadastroMesa.MesaID IS NOT NULL
--	AND EB_Lancamento.flVendaCancelada = 0
--	AND EB_Lancamento.TipoVendaID = 1
--ORDER BY 
--	EB_CadastroMesa.MesaID
                        
--END')




--
-- Definition for indices : 
--

ALTER TABLE [dbo].[EB_Estado]
ADD PRIMARY KEY CLUSTERED ([EstadoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Cidade]
ADD PRIMARY KEY CLUSTERED ([CidadeID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Bairro]
ADD PRIMARY KEY CLUSTERED ([BairroID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Balcao]
ADD PRIMARY KEY CLUSTERED ([BalcaoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_CadastroMesa]
ADD PRIMARY KEY CLUSTERED ([MesaID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Caixa]
ADD PRIMARY KEY CLUSTERED ([CaixaID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Usuario]
ADD PRIMARY KEY CLUSTERED ([UsuarioID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_CaixaHistoricoFechamento_idx] ON [dbo].[EB_CaixaHistoricoFechamento]
  ([UsuarioIDAbertura])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_CaixaHistoricoFechamento_idx2] ON [dbo].[EB_CaixaHistoricoFechamento]
  ([dtCaixaAbertura])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_CaixaHistoricoFechamento_idx3] ON [dbo].[EB_CaixaHistoricoFechamento]
  ([dtCaixaFechamento])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_CaixaHistoricoFechamento_idx4] ON [dbo].[EB_CaixaHistoricoFechamento]
  ([CaixaID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD PRIMARY KEY CLUSTERED ([HistoricoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Contato]
ADD PRIMARY KEY CLUSTERED ([ContatoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Endereco]
ADD PRIMARY KEY CLUSTERED ([EnderecoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Cliente]
ADD PRIMARY KEY CLUSTERED ([ClienteID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_ClienteOcorrencias]
ADD PRIMARY KEY CLUSTERED ([OcorrenciaID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_ConfiguracoesSistema]
ADD PRIMARY KEY CLUSTERED ([ConfID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_ContaCorrente]
ADD PRIMARY KEY CLUSTERED ([ContaID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_ContaTipoLancto]
ADD PRIMARY KEY CLUSTERED ([TipoLanctoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_ContaLancto]
ADD PRIMARY KEY CLUSTERED ([LanctoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_ContasDestDesconto]
ADD PRIMARY KEY CLUSTERED ([DestDescontoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_TipoLancto]
ADD PRIMARY KEY CLUSTERED ([TipoLanctoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_PlanoContas]
ADD PRIMARY KEY CLUSTERED ([PlanoContaID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_FormaPagamentoCondicao]
ADD PRIMARY KEY CLUSTERED ([CondicaoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_FormaPagamento]
ADD PRIMARY KEY CLUSTERED ([FormaPagamentoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Fornecedor]
ADD PRIMARY KEY CLUSTERED ([FornecedorID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_LancamentoStatus]
ADD PRIMARY KEY CLUSTERED ([StatusID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Entregador]
ADD PRIMARY KEY CLUSTERED ([EntregadorID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Garcon]
ADD PRIMARY KEY CLUSTERED ([GarconID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_TipoVenda]
ADD PRIMARY KEY CLUSTERED ([TipoVendaID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx] ON [dbo].[EB_Lancamento]
  ([MesaID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx10] ON [dbo].[EB_Lancamento]
  ([StatusID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx11] ON [dbo].[EB_Lancamento]
  ([ComandaID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx2] ON [dbo].[EB_Lancamento]
  ([CaixaID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx3] ON [dbo].[EB_Lancamento]
  ([TipoLanctoID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx4] ON [dbo].[EB_Lancamento]
  ([TipoVendaID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx5] ON [dbo].[EB_Lancamento]
  ([GarconID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx6] ON [dbo].[EB_Lancamento]
  ([BalcaoID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx7] ON [dbo].[EB_Lancamento]
  ([EntregadorID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx8] ON [dbo].[EB_Lancamento]
  ([UsuarioID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_Lancamento_idx9] ON [dbo].[EB_Lancamento]
  ([ClienteID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Lancamento]
ADD PRIMARY KEY CLUSTERED ([LanctoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Contas]
ADD PRIMARY KEY CLUSTERED ([contasID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Empresa]
ADD PRIMARY KEY CLUSTERED ([EmpresaID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_TipoProduto]
ADD PRIMARY KEY CLUSTERED ([TipoProdutoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_GrupoProduto]
ADD PRIMARY KEY CLUSTERED ([GrupoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_OrigemProduto]
ADD PRIMARY KEY CLUSTERED ([OrigemID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Produto]
ADD PRIMARY KEY CLUSTERED ([ProdutoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD PRIMARY KEY CLUSTERED ([EstoqueLanctoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_EstoqueLancItens]
ADD PRIMARY KEY CLUSTERED ([EstoqueLanctoItemID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_Impressoras]
ADD PRIMARY KEY CLUSTERED ([ImpressoraID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_LancamentoAdiantamentos]
ADD PRIMARY KEY CLUSTERED ([AdiantamentoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD PRIMARY KEY CLUSTERED ([LanctoCaixaBancoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag]
ADD PRIMARY KEY CLUSTERED ([fechamentoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_LancamentoItens_idx] ON [dbo].[EB_LancamentoItens]
  ([LanctoID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_LancamentoItens_idx2] ON [dbo].[EB_LancamentoItens]
  ([ProdutoID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_LancamentoItens_idx3] ON [dbo].[EB_LancamentoItens]
  ([PaiID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_LancamentoItens]
ADD PRIMARY KEY CLUSTERED ([LanctoItemID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_LanctoPedidos_idx] ON [dbo].[EB_LanctoPedidos]
  ([ClienteID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_LanctoPedidos_idx2] ON [dbo].[EB_LanctoPedidos]
  ([LanctoID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


CREATE NONCLUSTERED INDEX [EB_LanctoPedidos_idx3] ON [dbo].[EB_LanctoPedidos]
  ([EnderecoID])
WITH (
  PAD_INDEX = OFF,
  DROP_EXISTING = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  SORT_IN_TEMPDB = OFF,
  ONLINE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD PRIMARY KEY CLUSTERED ([PedidoID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[EB_ProdutoComp]
ADD PRIMARY KEY CLUSTERED ([ProdutoCompID])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


ALTER TABLE [dbo].[sysdiagrams]
ADD PRIMARY KEY CLUSTERED ([diagram_id])
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]


--
-- Definition for foreign keys : 
--

ALTER TABLE [dbo].[EB_Cidade]
ADD FOREIGN KEY ([EstadoID]) 
  REFERENCES [dbo].[EB_Estado] ([EstadoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Bairro]
ADD FOREIGN KEY ([CidadeID]) 
  REFERENCES [dbo].[EB_Cidade] ([CidadeID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD CONSTRAINT [EB_CaixaHistoricoFechamento_fk] FOREIGN KEY ([UsuarioIDAbertura]) 
  REFERENCES [dbo].[EB_Usuario] ([UsuarioID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD CONSTRAINT [EB_CaixaHistoricoFechamento_fk2] FOREIGN KEY ([UsuarioIDFechamento]) 
  REFERENCES [dbo].[EB_Usuario] ([UsuarioID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_CaixaHistoricoFechamento]
ADD CONSTRAINT [FK_EB_CaixaHistoricoFechamento_fk2] FOREIGN KEY ([CaixaID]) 
  REFERENCES [dbo].[EB_Caixa] ([CaixaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Endereco]
ADD FOREIGN KEY ([BairroID]) 
  REFERENCES [dbo].[EB_Bairro] ([BairroID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Endereco]
ADD FOREIGN KEY ([CidadeID]) 
  REFERENCES [dbo].[EB_Cidade] ([CidadeID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Endereco]
ADD CONSTRAINT [FK_EB_Endereco_fk] FOREIGN KEY ([ClienteID]) 
  REFERENCES [dbo].[EB_Cliente] ([ClienteID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Cliente]
ADD FOREIGN KEY ([ContatoID]) 
  REFERENCES [dbo].[EB_Contato] ([ContatoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Cliente]
ADD FOREIGN KEY ([EnderecoID]) 
  REFERENCES [dbo].[EB_Endereco] ([EnderecoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Cliente]
ADD FOREIGN KEY ([UsuarioID]) 
  REFERENCES [dbo].[EB_Usuario] ([UsuarioID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_ClienteOcorrencias]
ADD FOREIGN KEY ([ClienteID]) 
  REFERENCES [dbo].[EB_Cliente] ([ClienteID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_ContaLancto]
ADD FOREIGN KEY ([ContaID]) 
  REFERENCES [dbo].[EB_ContaCorrente] ([ContaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_ContaLancto]
ADD FOREIGN KEY ([TipoLanctoID]) 
  REFERENCES [dbo].[EB_ContaTipoLancto] ([TipoLanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_PlanoContas]
ADD CONSTRAINT [FK_EB_PlanoContas_fk] FOREIGN KEY ([TipoLanctoID]) 
  REFERENCES [dbo].[EB_TipoLancto] ([TipoLanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_PlanoContas]
ADD CONSTRAINT [FK_EB_PlanoContas_fk2] FOREIGN KEY ([Pai]) 
  REFERENCES [dbo].[EB_PlanoContas] ([PlanoContaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_FormaPagamento]
ADD CONSTRAINT [EB_FormaPagamento_fk] FOREIGN KEY ([CondicaoID]) 
  REFERENCES [dbo].[EB_FormaPagamentoCondicao] ([CondicaoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD FOREIGN KEY ([CaixaID]) 
  REFERENCES [dbo].[EB_Caixa] ([CaixaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD FOREIGN KEY ([EntregadorID]) 
  REFERENCES [dbo].[EB_Entregador] ([EntregadorID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD FOREIGN KEY ([GarconID]) 
  REFERENCES [dbo].[EB_Garcon] ([GarconID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD FOREIGN KEY ([MesaID]) 
  REFERENCES [dbo].[EB_CadastroMesa] ([MesaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD FOREIGN KEY ([TipoLanctoID]) 
  REFERENCES [dbo].[EB_TipoLancto] ([TipoLanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD FOREIGN KEY ([TipoVendaID]) 
  REFERENCES [dbo].[EB_TipoVenda] ([TipoVendaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD FOREIGN KEY ([UsuarioID]) 
  REFERENCES [dbo].[EB_Usuario] ([UsuarioID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_BALCA] FOREIGN KEY ([BalcaoID]) 
  REFERENCES [dbo].[EB_Balcao] ([BalcaoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_CLIEN] FOREIGN KEY ([ClienteID]) 
  REFERENCES [dbo].[EB_Cliente] ([ClienteID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Lancamento]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_LANCA] FOREIGN KEY ([StatusID]) 
  REFERENCES [dbo].[EB_LancamentoStatus] ([StatusID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [EB_Contas_fk] FOREIGN KEY ([CaixaID]) 
  REFERENCES [dbo].[EB_Caixa] ([CaixaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_CLIEN] FOREIGN KEY ([clienteID]) 
  REFERENCES [dbo].[EB_Cliente] ([ClienteID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_FORMA] FOREIGN KEY ([FormaPagamentoID]) 
  REFERENCES [dbo].[EB_FormaPagamento] ([FormaPagamentoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_LANCA] FOREIGN KEY ([lanctoID]) 
  REFERENCES [dbo].[EB_Lancamento] ([LanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_PLANO] FOREIGN KEY ([PlanoContaID]) 
  REFERENCES [dbo].[EB_PlanoContas] ([PlanoContaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_CONTA_REFERENCE_EB_TIPOL] FOREIGN KEY ([TipoLanctoID]) 
  REFERENCES [dbo].[EB_TipoLancto] ([TipoLanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_Contas_fk] FOREIGN KEY ([FornecedorID]) 
  REFERENCES [dbo].[EB_Fornecedor] ([FornecedorID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_Contas_fk2] FOREIGN KEY ([DestDescontoID]) 
  REFERENCES [dbo].[EB_ContasDestDesconto] ([DestDescontoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Contas]
ADD CONSTRAINT [FK_EB_Contas_fk4] FOREIGN KEY ([DestOuOrigDescontoContaCorrenteID]) 
  REFERENCES [dbo].[EB_ContaCorrente] ([ContaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_GrupoProduto]
ADD CONSTRAINT [FK_EB_GrupoProduto_fk] FOREIGN KEY ([pai]) 
  REFERENCES [dbo].[EB_GrupoProduto] ([GrupoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Produto]
ADD FOREIGN KEY ([FornecedorID]) 
  REFERENCES [dbo].[EB_Fornecedor] ([FornecedorID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Produto]
ADD FOREIGN KEY ([GrupoID]) 
  REFERENCES [dbo].[EB_GrupoProduto] ([GrupoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Produto]
ADD FOREIGN KEY ([OrigemID]) 
  REFERENCES [dbo].[EB_OrigemProduto] ([OrigemID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Produto]
ADD FOREIGN KEY ([TipoProdutoID]) 
  REFERENCES [dbo].[EB_TipoProduto] ([TipoProdutoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD CONSTRAINT [FK_EB_EstoqueLancto_fk] FOREIGN KEY ([TipoMovID]) 
  REFERENCES [dbo].[EB_TipoLancto] ([TipoLanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD CONSTRAINT [FK_EB_EstoqueLancto_fk2] FOREIGN KEY ([FornecedorID]) 
  REFERENCES [dbo].[EB_Fornecedor] ([FornecedorID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_EstoqueLancto]
ADD CONSTRAINT [FK_EB_EstoqueLancto_fk3] FOREIGN KEY ([UsuarioID]) 
  REFERENCES [dbo].[EB_Usuario] ([UsuarioID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_EstoqueLancItens]
ADD CONSTRAINT [FK_EB_EstoqueLanctoItens_fk] FOREIGN KEY ([EstoqueLanctoID]) 
  REFERENCES [dbo].[EB_EstoqueLancto] ([EstoqueLanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_EstoqueLancItens]
ADD CONSTRAINT [FK_EB_EstoqueLanctoItens_fk2] FOREIGN KEY ([ProdutoID]) 
  REFERENCES [dbo].[EB_Produto] ([ProdutoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_Impressoras]
ADD CONSTRAINT [FK_EB_IMPRE_REFERENCE_EB_TIPOP] FOREIGN KEY ([TipoProdutoID]) 
  REFERENCES [dbo].[EB_TipoProduto] ([TipoProdutoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoAdiantamentos]
ADD CONSTRAINT [FK_EB_LancamentoAdiantamentos_fk] FOREIGN KEY ([LanctoID]) 
  REFERENCES [dbo].[EB_Lancamento] ([LanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoAdiantamentos]
ADD CONSTRAINT [FK_EB_LancamentoAdiantamentos_fk2] FOREIGN KEY ([FormaPagamentoID]) 
  REFERENCES [dbo].[EB_FormaPagamento] ([FormaPagamentoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [EB_LancamentoCaixaBanco_fk] FOREIGN KEY ([CaixaID]) 
  REFERENCES [dbo].[EB_Caixa] ([CaixaID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk] FOREIGN KEY ([TipoLanctoID]) 
  REFERENCES [dbo].[EB_TipoLancto] ([TipoLanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk2] FOREIGN KEY ([formaPagamentoID]) 
  REFERENCES [dbo].[EB_FormaPagamento] ([FormaPagamentoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoCaixaBanco]
ADD CONSTRAINT [FK_EN_LancamentoCaixaBanco_fk3] FOREIGN KEY ([ContasDestDescontoID]) 
  REFERENCES [dbo].[EB_ContasDestDesconto] ([DestDescontoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_FORMA] FOREIGN KEY ([FormaPagamentoID]) 
  REFERENCES [dbo].[EB_FormaPagamento] ([FormaPagamentoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoFechamentoFormasPag]
ADD CONSTRAINT [FK_EB_LANCA_REFERENCE_EB_LANCA_FECHA] FOREIGN KEY ([LanctoID]) 
  REFERENCES [dbo].[EB_Lancamento] ([LanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LancamentoItens]
ADD FOREIGN KEY ([LanctoID]) 
  REFERENCES [dbo].[EB_Lancamento] ([LanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE CASCADE


ALTER TABLE [dbo].[EB_LancamentoItens]
ADD FOREIGN KEY ([ProdutoID]) 
  REFERENCES [dbo].[EB_Produto] ([ProdutoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD CONSTRAINT [FK_EB_LanctoPedidos_fk] FOREIGN KEY ([ClienteID]) 
  REFERENCES [dbo].[EB_Cliente] ([ClienteID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD CONSTRAINT [FK_EB_LanctoPedidos_fk2] FOREIGN KEY ([EnderecoID]) 
  REFERENCES [dbo].[EB_Endereco] ([EnderecoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_LanctoPedidos]
ADD CONSTRAINT [FK_EB_LanctoPedidos_fk3] FOREIGN KEY ([LanctoID]) 
  REFERENCES [dbo].[EB_Lancamento] ([LanctoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_ProdutoComp]
ADD CONSTRAINT [FK_EB_PRODU_REFERENCE_EB_PRODU] FOREIGN KEY ([ProdutoID]) 
  REFERENCES [dbo].[EB_Produto] ([ProdutoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


ALTER TABLE [dbo].[EB_ProdutoComp]
ADD CONSTRAINT [FK_EB_ProdutoComp_fk] FOREIGN KEY ([ProdutoPrincipalID]) 
  REFERENCES [dbo].[EB_Produto] ([ProdutoID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION


