# CRUD Cliente

Projeto CRUD para gerenciamento de clientes, organizado com arquitetura MVC, banco de dados relacional e interface web simples.

---

## Estrutura do Projeto

- **Controllers**  
  Controladores que recebem as requisições HTTP e coordenam as ações entre Model e View.

- **Data**  
  Configuração do banco de dados e contexto (`AppDbContext`), responsável pela persistência via Entity Framework Core.

- **Migrations**  
  Histórico das mudanças no banco de dados gerado automaticamente pelo Entity Framework Core.

- **Models**  
  Definição das entidades do sistema, como a classe `Cliente`.

- **Properties**  
  Arquivos de configuração do projeto, incluindo configurações de execução.

- **Views**  
  Arquivos de interface (Razor/HTML) que apresentam dados e formulários para interação do usuário.

---

## Funcionalidades

- Listar clientes  
- Criar novo cliente  
- Editar cliente existente  
- Excluir cliente  
- Validação básica de dados  
- Persistência dos dados no banco SQL Server

---

## Tecnologias Utilizadas

- C# com ASP.NET Core MVC  
- Entity Framework Core  
- SQL Server (LocalDB ou outra instância)  
- Razor Views (HTML + C#)

---

## Como Executar

1. Clone o repositório:

   git clone https://github.com/seu-usuario/seu-repositorio.git

3. Abra a solução no Visual Studio ou via terminal.

4. Configure a string de conexão no appsettings.json para seu banco de dados.

4.Execute as migrations para criar o banco:

   dotnet ef database update
  
5. Rode a aplicação:

   dotnet run
   
6. Abra no navegador o endereço:

   https://localhost:<porta>
   
Autor
 Ester da Costa Batista — ec747099@gmail.com
