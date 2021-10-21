# Golden Raspberry Awards - WebApi
WebApi dedicada ao teste de habilidades backend .Net Core para a TEXO IT, atendendo a proposta geral:
"Desenvolva uma API RESTful para possibilitar a leitura da lista de indicados e vencedores da categoria Pior Filme do Golden Raspberry Awards."

Conforme item 4 do requisito não funcional, segue abaixo instruções para executar o projeto.

## Ambiente
O projeto foi desenvolvido na IDE Visual Studio 2019 na plataforma .Net Core 5.
Assim como o repositório a solução também foi nomeada como GRA, acrônimo de Golden Raspberry Awards.

## GRA.WebApi
O projeto WebApi consiste em dois passos: Ao iniciar é executado a carga do CSV que alimenta a base de dados em memória, é necessário informar o caminho onde está localizado o CSV na máquina, para isso foi criado uma chave no appsettings.json chamada PathCSV, vide exemplo abaixo:

![image](https://user-images.githubusercontent.com/10923101/138201142-581f6a04-0498-4376-99c0-437a7aaf63d4.png)

Ao executar a aplicação, o navegador exibirá a documentação da API definida via Swagger.
Basta acionar o único método disponível e a API irá realizar a ação da funcionalidade, vide exemplo abaixo:

![image](https://user-images.githubusercontent.com/10923101/138201567-f3a45b0c-5d3e-4d56-90c7-0be37da689b5.png)

## GRA.Test
O projeto Test está definido com um teste sem parâmetros, portanto para a execução basta clicar com o botão direito em cima do projeto e selecionar "Run Tests"
