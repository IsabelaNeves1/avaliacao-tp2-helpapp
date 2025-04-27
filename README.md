# 📘 Avaliação Técnica – Clean Architecture + Azure SQL

Este repositório contém minha entrega referente à avaliação técnica baseada no repositório original do professor:  
[https://github.com/victoricoma/avaliacao-tp2-helpapp](https://github.com/victoricoma/avaliacao-tp2-helpapp)

---

## ✅ Objetivo

Implementar os repositórios `Category` e `Product` seguindo os padrões da Clean Architecture, aplicar a migration `Initial` e conectar a aplicação com uma instância de SQL Server no SSMS.

---

## 🚀 Funcionalidades implementadas

- [x] Repositórios `CategoryRepository` e `ProductRepository`
- [x] Configurações com `EntityTypeConfiguration` para `Category` e `Product`
- [x] Injeção de dependência configurada (`DependencyInjectionAPI`)
- [x] Migration `Initial` criada com `HasData()` para categorias
- [x] Migration aplicada com sucesso no SSMS via `dotnet ef database update`

---
# 🔧 Comandos utilizados
## Criação da migration
dotnet ef migrations add Initial --project Infra.Data --startup-project WebAPI

## Aplicação no banco de dados 
dotnet ef database update --project Infra.Data --startup-project WebAPI

Banco de dados nomeado: HelpAppDb

Migration aplicada com sucesso diretamente do Visual Studio Terminal

# 🖼️ Prints de evidência 
## Aplicação bem-sucedida da migration no SSMS
![Migration](https://github.com/IsabelaNeves1/avaliacao-tp2-helpapp/blob/avaliacao-IsabelaNeves1/images/migration.png)

## Tabela Category
![Category](https://github.com/IsabelaNeves1/avaliacao-tp2-helpapp/blob/avaliacao-IsabelaNeves1/images/tabelaCategory.png)

## Tabela Product
![Product](https://github.com/IsabelaNeves1/avaliacao-tp2-helpapp/blob/avaliacao-IsabelaNeves1/images/tabelaProduct.png)

# 👨‍💻 Dados do aluno
Nome: Isabela Neves da Silva
Curso: Desenvolvimento de Sistemas – 3º Semestre

Professor: Victor Icoma

Branch da entrega: avaliacao-IsabelaNeves1

## 🧱 Estrutura da aplicação

```bash
📦 src
 ┣ 📂 Domain
 ┣ 📂 Application
 ┣ 📂 Infra
 ┃ ┣ 📂 Data
 ┃ ┃ ┣ 📂 Migrations
 ┃ ┃ ┣ 📂 Repositories
 ┃ ┃ ┗ 📂 EntityConfiguration
 ┗ 📂 WebAPI

