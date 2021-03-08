#language: pt-br

Funcionalidade: EcoFriendly
	Eu como usuário comprador da store
    Gostaria de ter acesso à produtos Eco-Friendly
    Assim poderia consumir produtos que respeitem a natureza

Contexto: 
	Dado Estar no site GoogleShop
	E Clicar no menu Eco-Friendy
	E Entrar na página Eco-Friendly

@SubCategoria
Cenario: Filtrar por subcategoria
	Dado Estar na página Eco-Friendly
	Quando Clicar no filtro Subcategory
	E Selecionar <subcategoria>
	Então  Apenas itens com a subcategoria <subcategoria> sendo mostrados
	Exemplos: 
	| subcategoria |
	| LifeStyle    |
	| Apparel      |
	| Stationery   |

@Limpeza
Cenario: Limpar Filtros
	Dado Estar na página Eco-Friendly
	E esta
	Quando Clicar no filtro Subcategory
	E Selecionar LifeStyle
	Então  Apenas itens com a subcategoria LifeStyle sendo mostrados

@Ordenar
Cenario: Ordenar itens
	Dado Estar na página Eco-Friendly
	Quando Clicar no filtro OrderBy
	E Selecionar <ordenar>
	Então  Itens ordenados de acordo com <ordenar>
	Exemplos: 
	| ordenar     |
	| PriceLow    |
	| PriceHigh   |
	| Title       |
	| Newest      |
	| BestSellers |
	| Title       |

@FiltrarEOrdenar
Cenario: Filtrar por subcategoria e ordenar
	Dado Estar na página Eco-Friendly
	Quando Clicar no filtro OrderBy
	E Selecionar <ordenar>
	E Clicar no filtro Subcategory
	E Selecionar <subcategoria>
	Então Apenas itens com a subcategoria <subcategoria> sendo mostrados
	E Itens ordenados de acordo com <ordenar>
	Exemplos: 
	| ordenar     | subcategoria |
	| PriceLow    |LifeStyle     |
	| PriceHigh   |Apparel       |
	| Title       |Stationery    |
	| Newest      |Apparel       |
	| BestSellers |Apparel       |
	| Title       |Apparel       |

@LimparOrdenacao
Cenario: Limpar ordenacao
	Dado Estar na página Eco-Friendly
	Quando Clicar no filtro OrderBy
	E Selecionar <ordenar>
	E Clicar no filtro Subcategory
	E Selecionar SortBy
	E Selecionar <ordenar>
	Então Apenas itens com a subcategoria <subcategoria> sendo mostrados
	E Itens ordenados de acordo com <ordenar>
	Exemplos: 
	| ordenar     | subcategoria |
	| SortBy      |LifeStyle     |
	| PriceHigh   |Apparel       |
	| Title       |Stationery    |
	| Newest      |Apparel       |
	| BestSellers |Apparel       |
	| Title       |Apparel       |

@Rolagem
Cenario: Rolar a página
	Dado Estar na página Eco-Friendly
	Quando Rolar a página	
	Então Itens novos serão mostrados

@Produto
Cenario: Clicar no produto
	Dado Estar na página Eco-Friendly
	Quando Clicar em um produto
	Então Detalhes do produto serão exibidos
