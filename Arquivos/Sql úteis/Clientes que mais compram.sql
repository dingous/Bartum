select SUM(formas.vlForma), MAX(cliente.dsNome) from EB_LancamentoFechamentoFormasPag as formas
inner join EB_Lancamento as lancto on formas.LanctoID = lancto.LanctoID
inner join EB_Cliente as cliente on cliente.ClienteID = lancto.ClienteID
group by cliente.ClienteID
order by SUM(formas.vlForma) DESC