teste de unidade
teste de integracao
testes automatizado
testes de carga

ObjetoEmTeste_MetodoComportamentoEmTeste_ComportamentoEsperado
Pedido_AdicionaPedidoItem_DeveOncrementarUnidadesSeItemJaExistente
Estoque_RetirarItem_DeveEnviarEmailSeAbaixoDe10Unidades

MetodoEmTeste_EstadoEmTeste_ComportamentoEsperado
AdicionaPedidoItem_ItemExistenteCarrinho_DeveIncrementarUnidadesDoItem
RetirarItemEstoque_EstoqueAbaixoDe10Unidades_DeveEnviarEmailDeAviso



AAA - Arrange, Act, Assert
Fluent Assertions
	result.Should().BeTrue();
[Theory][InlineData(1, 1, 2)][InlineData(4, 5, 9)]
[Trait("Categoria", "Teste")] // Trait - alterar o nome, categorizar
Verify Assertion
	calculadoraRepo.Verify(c => c.Somar(v1, v2, Times.Once);
	calculadoraRepo.Verify(c => c.Somar(It.IsAny<double>(), It.IsAny<double>()), Times.Once);
Collection Fixture
    [Collection(nameof(CustomerCollection))]
	[CollectionDefinition(nameof(CustomerCollection))]

AutoMock Fixture
Bogus - Generation of random data




    [Collection(nameof(CustomerCollection))]
