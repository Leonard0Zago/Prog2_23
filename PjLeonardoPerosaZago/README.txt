Como criar uma aplicação web .NET

Abre o Visual studio e cria um novo projeto do tipo ASP.NET MVC na versão 6.0 do .NET.
Abre o gerenciador de pacote NuGet e instala os seguintes pacotes:
  Microsoft.AspNetCore.Identity.EntityFrameworkCore
  Microsoft.EntityFrameworkCore
  Microsoft.EntityFrameworkCore.Design
  Microsoft.EntityFrameworkCore.SqlServer

Todos na mesma versão do dotnet instalado. Para testar se todas as instalações foram bem sucedidas Ctrl + Shift + B.
Na pasta Models crie uma nova classe AppUser para definir os parâmetros para a criação de um novo usuário. 
Também crie Psico para definir os parâmetros dessa classe.
Crie uma pasta Data e nela crie uma classe AppDbContyext, essa classe serve para definir o que será usado no DB e quais tabelas deverão ser criadas.
No appsetting.json criar um usuário inicial para conseguir acessar o sistema pela primeira vez como admin.
No program.cs criar o builder da tabela do DB.
Para criar a Migration tem que abrir to terminal do APP e usar o comando 'dotnet tool install --global dotnet-ef' para a tualizar e o 'dotnet ef migrations add Initial' para criar um codelo do DB.
Para atualizar o DB usar o comando 'dotnet ef database update'.
