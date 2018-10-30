# Avaliação


## Introdução

Este projeto reflete um dos desafios realizados como parte de um processo seletivo para uma empresa na Cidade de Blumenau-SC.

Buscou-se atender os requisitos solicitados, além de ter sido adicionado conhecimentos como concernentes a gestão de projetos, gerência de configuração, entre outros.


## Cenário

Você trabalha em uma Empresa de Estacionamentos de Carros, onde tudo ainda é realizado de forma manual. O chefe do departamento financeiro decidiu que chegou a hora de desenvolver um sistema simples apenas para o controle do estacionamento, onde o usuário poderá registrar a entrada e saída dos veículos.

Sua função é elaborar um algoritmo que o usuário deve registrar a placa do carro, a data e hora que o carro entrou no estacionamento, e, da mesma forma a data e hora que o carro está dando saída do estacionamento. 

Por conseguinte, deve ser calculados o tempo de permanência, bem como o valor a ser pago.


## Regras

* Os valores praticados pelo estacionamento devem ser parametrizados em uma tabela de preços com controle vigência. Por exemplo: Valores válidos para o período de 01/01/2018 até 31/12/2018;
* A tabela de preço deve contemplar o valor da hora inicial e valor da hora adicional;
* Deve-se utilizar a data de entrada do veículo como referência para buscar a tabela de preços que foi parametrizada;
* Quando o tempo total de permanência no estacionamento for igual ou inferior a 30 minutos, será cobrado metade do valor da hora inicial;
* O valor da hora adicional possui uma tolerância de 10 minutos para cada 1 hora. 

**Exemplificando**: Suponha que o valor da hora seja R$ 2,00 e o valor de cada hora adicional seja R$ 1,00. Os resultados calculados ficariam assim:

* 30 minutos, será cobrado R$ 1,00;
* 1 hora, será cobrado R$ 2,00;
* 1 hora e 10 minutos, será cobrado R$ 2,00;
* 1 hora e 15 minutos, será cobrado R$ 3,00;
* 2 horas e 5 minutos valor R$ 3,00;
* 2 horas e 15 minutos valor R$ 4,00.


## Observação

* Deve-se utilizar a placa do veículo como chave de busca;


## Requisitos

* O Front-End e a sua Usabilidade (UX do Frontend) não serão critérios avaliados, mas o sistema deve possuir uma interface desktop ou web para registrar as entradas, saídas e parametrizações. Isto ficará a critério do desenvolvedor;
* O Back-End deve ser escrito em Linguagem C# e usando Tecnologia .NET;
* Se possível utilizar conceitos de mercado como DDD, TDD, divisão das camadas, modelagem, design patterns, algum Framework ORM e outros fatores que serão levados em conta;


## Sobre o projeto

O Projeto Parking, tem o intuito de demonstrar uma aplicação em .Net Core para realizar cálculo e controle de um estacionamento.


## Recursos utilizados no desenvolvimento da aplicação:

**Ferramentas**

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Visual Studio 2017                        |[Guia][GuiaVS2017]                |[IDE][IDEVS2017]  |
|SQL Server 2017                           |[Guia][GuiaSQL2017]               |[IDE][IDESQL2017] |


**Tecnologias**

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|ASP.NET Core 2.0                          |[Guia][GuiaASPNetCore]            |N/A               |
|Entity Framework Core 2.0                 |[Guia][GuiaEntityCore]            |N/A               |
|Migration                                 |[Guia][GuiaMigrations]            |N/A               |
|AutoMapper                                |N/A                               |N/A               |
|Flunt                                     |N/A                               |N/A               |
|FluentAssertions                          |N/A                               |N/A               |
|NSubstitute                               |N/A                               |N/A               |


**Arquiteturas e Conceitos**

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Conceitos de DDD (Domain Driven Design)   |[Tutorial][GuiaDDD]               |N/A               |
|Conceitos de TDD (Test Driven Design)     |N/A                               |N/A               |
|Repositório de Dados (Repository Pattern) |[Tutorial][GuiaRepositoryPattern] |N/A               |
|SOLID                                     |N/A                               |N/A               |
|Clean Code                                |N/A                               |N/A               |


## :star: Mendigo de estrelas

Se você gostou deste projeto ou te ajudou de alguma forma com algum conceito, clica na estrelinha, isso ajuda muito.


## Tem alguma pergunta ou sugestão de melhoria neste projeto?

Sinta-se à vontade em abrir um [issue][DefeitoParking] ou [pull request][PullRequest].


[//]: # (Links de referências para o quadro de recursos utilizados)

[GuiaVS2017]: <https://docs.microsoft.com/pt-br/visualstudio/ide/>
[IDEVS2017]: <https://www.visualstudio.com/pt-br/downloads/>
[GuiaCSharp]: <https://docs.microsoft.com/pt-br/dotnet/csharp/>
[GuiaDDD]: <http://www.agileandart.com/2010/07/16/ddd-introducao-a-domain-driven-design/>
[GuiaASPNetCore]: <https://docs.microsoft.com/pt-br/dotnet/core/>
[GuiaEntityCore]: <https://docs.microsoft.com/pt-br/dotnet/framework/>
[GuiaRepositoryPattern]: <https://code.msdn.microsoft.com/windowsdesktop/Implementando-Repositrio-aabcdbce>
[GuiaMigrations]: <https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/>
[GuiaSQL2017]: <https://docs.microsoft.com/pt-br/sql/sql-server/sql-server-technical-documentation>
[IDESQL2017]: <https://www.microsoft.com/pt-br/sql-server/sql-server-downloads>


[//]: # (Links de referências aos problemas neste projeto)

[DefeitoParking]: <https://github.com/alexandredorea/Parking/issues>
[PullRequest]: <https://github.com/alexandredorea/Parking/pulls>
