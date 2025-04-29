# EFRelationships

## Visão Geral
O projeto **EFRelationships** é uma aplicação .NET 9 que demonstra diferentes tipos de relacionamentos no Entity Framework Core. Ele inclui exemplos de relacionamentos **Um-para-Um**, **Um-para-Muitos** e **Muitos-para-Muitos** entre entidades.

## Estrutura do Projeto
O projeto está organizado da seguinte forma:

### Diretórios Principais
- **Controllers**: Contém os controladores responsáveis por gerenciar as requisições HTTP.
- **Migrations**: Contém os arquivos de migração gerados pelo Entity Framework Core.
- **Model**: Contém as classes de modelo que representam as entidades do banco de dados.
- **Properties**: Contém configurações do projeto, como `launchSettings.json`.
- **Raiz do Projeto**: Contém arquivos de configuração como `Program.cs` e `appsettings.json`.

---

## Relacionamentos Implementados

### 1. Um-para-Um (One-to-One)
- **Entidades Envolvidas**: `User` e `Profile`
- **Descrição**: Cada usuário possui um único perfil, e cada perfil pertence a um único usuário.
- **Controlador**: `OneToOneController`

### 2. Um-para-Muitos (One-to-Many)
- **Entidades Envolvidas**: `Blog` e `Post`
- **Descrição**: Um blog pode ter vários posts, mas cada post pertence a um único blog.
- **Controlador**: `OneToManyController`

### 3. Muitos-para-Muitos (Many-to-Many)
- **Entidades Envolvidas**: `Student` e `Course` (com a tabela intermediária `CourseStudent`)
- **Descrição**: Um estudante pode estar matriculado em vários cursos, e um curso pode ter vários estudantes matriculados.
- **Controlador**: `ManyToManyController`

---

## Configuração do Projeto

### Dependências
- **.NET 9**
- **Entity Framework Core**

### Configuração do Banco de Dados
O banco de dados é configurado no arquivo `appsettings.json`. Certifique-se de ajustar a string de conexão conforme necessário.

Exemplo de configuração :
