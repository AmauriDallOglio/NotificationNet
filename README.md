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

-------

Fluxo de Cadastro:

O cliente envia uma requisição para cadastrar um usuário;

O sistema valida os dados;

Verifica se os campos obrigatórios estão preenchidos;

Checa se o e-mail tem um formato válido;

Se houver erros, eles são capturados como notificações e retornados em uma resposta 400 Bad Request;

Caso os dados sejam válidos, o usuário é cadastrado com sucesso, e uma resposta 200 OK é enviada com os detalhes do usuário;


## Estrutura do Projeto

Solution
│
├── CadastroUsuario.Api
│   ├── Controllers
│   │   ├── UsuariosController.cs
│   │   ├── BaseController.cs
│   │
│   ├── Program.cs
│   ├── launchSettings.json
│   ├── appsettings.json
│
├── CadastroUsuario.Domain
│   ├── Entidades
│   │   ├── Usuario.cs
│   │
│   ├── Interfaces
│   │   ├── IUsuarioRepositorio.cs
│   │   ├── IUsuarioServico.cs
│   │   ├── IResultadoOperacao
│   │   ├── IResultadoOperacaoGenerico.cs
│   │
│   ├── Servicos
│       ├── UsuarioServico.cs
│
├── CadastroUsuario.Infra
│   ├── Repositorios
│   │   ├── UsuarioRepositorio.cs
│   │
│   ├── Contexto
│       ├── GenericoContexto.cs
│
├── CadastroUsuario.Shared
│   ├── Notificacoes
│   │   ├── NotificacaoDominio.cs
│   │
│   ├── Resultados
│   │   ├── ResultadoOperacao.cs
│   │   ├── ResultadoOperacaoGenerico.cs
│   │
│   ├── Validador
│       ├── UsuarioValidador.cs



 
 

```mermaid
graph TD;
    A[Solution]
    A --> B[CadastroUsuario.Api]
    B --> B1[Controllers]
    B1 --> B2[UsuariosController.cs]
    B1 --> B3[BaseController.cs]
    B --> B4[Program.cs]
    B --> B5[launchSettings.json]
    B --> B6[appsettings.json]

    A --> C[CadastroUsuario.Domain]
    C --> C1[Entidades]
    C1 --> C2[Usuario.cs]
    C --> C3[Interfaces]
    C3 --> C4[IUsuarioRepositorio.cs]
    C3 --> C5[IUsuarioServico.cs]
    C3 --> C6[IResultadoOperacao.cs]
    C3 --> C7[IResultadoOperacaoGenerico.cs]
    C --> C8[Servicos]
    C8 --> C9[UsuarioServico.cs]

    A --> D[CadastroUsuario.Infra]
    D --> D1[Repositorios]
    D1 --> D2[UsuarioRepositorio.cs]
    D --> D3[Contexto]
    D3 --> D4[GenericoContexto.cs]

    A --> E[CadastroUsuario.Shared]
    E --> E1[Notificacoes]
    E1 --> E2[NotificacaoDominio.cs]
    E --> E3[Resultados]
    E3 --> E4[ResultadoOperacao.cs]
    E3 --> E5[ResultadoOperacaoGenerico.cs]
    E --> E6[Validador]
    E6 --> E7[UsuarioValidador.cs]

 
