# Aplicação (CRUD) 
Ferramentas: Framework ASP.NET Core MVC para criação de aplicação WEB. Template Engine Razor, layout Bootstrap e integração com o Banco de Dados MySQL

## Antes de Começar
### Certifique-se que você:
Tenha o Visual Studio 2019 instalado | `https://visualstudio.microsoft.com/pt-br/`
Xampp Control Panel v3.3.0 instalado | `https://www.apachefriends.org/pt_br/index.html`

## Começando
1. Clone a aplicação no seu workspace local
2. Inicie (show / hide) o MySql e o Apache no Xampp. 
	Para acompanhar a migração, em MySql no Xampp, clique em Admin para entrar no `http://localhost/phpmyadmin/`

3. Na pasta Clientes, abra o arquivo Clientes.sln no Visual Studio
4. No terminal do Package Manager Console, digite `Add-Migration Initial` e tecle "Enter"
	em seguida, digite no terminal `Update-Database` para atualizar a migração (BD)

## Recursos da API 
`/Customers` - Listar clientes
`/Departments` - Lista departamento dos clientes

### Tanto para /Customers quanto para /Departments temos:	
`/Create` - Cadastrar cliente com todos os atributos (Name, CPF, RG, BirthDate, Contacts, Adress, RedesSociais, DepartmentId)
`/Delete` - Deleta o cadastro do cliente
`/Details` - Informa detalhes do Cliente

### Buscas
`/CustomersRecords` - Busca clientes por data
`/CustomersRecords/SimpleSearch` - Busca Simples
`/CustomersRecords/GroupingSearch` - Busca Agrupada por Department
