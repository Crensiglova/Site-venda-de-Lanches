# :fries: Projeto: Site de Venda de Lanches :hamburger:

[Clique aqui para acessar o projeto publicado no Azure](https://gclanches.azurewebsites.net/)

Este projeto é um site de vendas de lanches desenvolvido com ASP.NET Core 8. O site permite que usuários naveguem pelos produtos, adicionem itens ao carrinho, criem contas e façam login para gerenciar seus pedidos. Além disso, há uma área administrativa para gerenciamento de produtos, categorias e pedidos, bem como relatórios de vendas com gráficos.

## Funcionalidades

### Público Geral
- **Listagem de Produtos**: Navegação através de uma lista de lanches disponíveis para compra.
- **Carrinho de Compras**: Funcionalidade que permite adicionar, remover e visualizar os itens selecionados.
- **Criação e Login de Usuário**: Registro e autenticação de usuários para gerenciar pedidos e acompanhar o histórico de compras.

### Área Administrativa
- **Gestão de Produtos**: Adicionar, editar e remover produtos.
- **Gestão de Categorias**: Criar e organizar categorias de lanches.
- **Gestão de Pedidos**: Visualização e acompanhamento de todos os pedidos realizados.
- **Relatórios de Vendas**: Relatórios detalhados com gráficos para análise de vendas, incluindo métricas de desempenho e acompanhamento de categorias mais vendidas.

## Tecnologias Utilizadas
- **ASP.NET Core 8**: Framework principal utilizado para o desenvolvimento da aplicação.
- **Entity Framework Core**: ORM utilizado para mapeamento e gestão do banco de dados.
- **SQL Server**: Banco de dados utilizado para armazenar informações dos produtos, usuários, pedidos e relatórios.
- **Bootstrap**: Utilizado para o design responsivo e estilização da interface.
- **GoogleChart**: Biblioteca JavaScript usada para exibição de gráficos nos relatórios de vendas.
- **FastReport**: Biblioteca usada para exibição e criação de relatórios.

## Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/crensiglova/Site-Venda-de-Lanches.git
2. Navegue até a pasta do projeto:
   ```bash
   cd LanchesMac
3. Restaure as dependências do projeto:
   ```bash
   dotnet restore
4. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
5. Aplique as migrações para criar o banco de dados:
   ```bash
   dotnet ef database update
6. Execute a aplicação.

  ## Funcionalidades Futuras

- **Melhorias no design da página**: Planejamos aprimorar a interface de usuário e a experiência do cliente com um design mais moderno e interativo, incluindo uma melhor organização dos produtos e um layout mais intuitivo.
  
- **Integração com APIs de pagamento**: A implementação de gateways de pagamento como PayPal, Stripe, e outros, para permitir compras seguras e rápidas diretamente no site.

- **Sistema de cupons e promoções**: Um sistema que permitirá a aplicação de cupons de desconto e promoções especiais para os clientes, tanto em ocasiões específicas quanto de maneira recorrente.

- **Implementação de notificações para pedidos em tempo real**: Notificações automáticas para usuários sobre o status dos pedidos, desde a confirmação até o envio e entrega, proporcionando uma melhor experiência de acompanhamento.

## Contribuição

Sinta-se à vontade para contribuir com melhorias. Caso tenha alguma ideia ou correção.
