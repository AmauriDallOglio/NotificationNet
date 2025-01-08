# NotificationNet

Este sistema descreve o gerenciamento de usuários, com validações, respostas e arquitetura extensível;

Cadastro de Usuários: Permite cadastrar usuários fornecendo informações como nome, e-mail e senha.
Realiza validações de negócio, como obrigatoriedade de campos e formato correto de e-mail.

Sistema de Notificações: Usa o padrão Domain Notifications para capturar e gerenciar mensagens de erro ou validação de maneira centralizada.
As notificações permitem retornar respostas claras para o cliente, indicando os erros encontrados.

BaseController: Centraliza a lógica comum aos controladores, como criação de respostas HTTP padronizadas e manipulação de notificações.
Facilita a manutenção e promove consistência entre as operações.

Resultados operação: Utiliza o padrão de resultados para retornar as respostas da API, garantindo um formato consistente.
Inclui informações de sucesso, falhas e dados retornados para o cliente.


Fluxo de Cadastro:
O cliente envia uma requisição para cadastrar um usuário;
O sistema valida os dados;
Verifica se os campos obrigatórios estão preenchidos;
Checa se o e-mail tem um formato válido;
Se houver erros, eles são capturados como notificações e retornados em uma resposta 400 Bad Request;
Caso os dados sejam válidos, o usuário é cadastrado com sucesso, e uma resposta 200 OK é enviada com os detalhes do usuário;
