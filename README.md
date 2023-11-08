/Subir para o git 
/git status 
/git add . 
/git status 
/git commit -m "" 
/git remote -v 
/git push origin main

SDK: Sistem Development Kit
ASP: Active Server Pages
Web app: Aplicação web
.NET Core CLR: Common language Runtime
MVC: Model View Controller
Web API: Web Services no estilo MVC
ORM: Object Relational Mapping
API: Access Program Interfaces
IIS: Internet Information Server - da microsoft
__________________________________________

Pesquisar sobre:
Agenda 2030 da ONU
MVC Pattern
Os 8 odiados
ASP.NET Core - fazer programas de treinamento
Arquitetura ASP.NET Core
dotnet.microsoft.com
__________________________________________

No cmd:
dotnet new mvc --no-https --output PartyInvites / 
dir / 
cd PartyInvites / 
dotnet watch run - para executar e abrir a janela no navegador / 

______________________________________________
Aula 2- 03/08/23

/ Visual studio tem que ter 'ASP.NET e desenvolvimento Web', 'processamento e armazenamentos de dados' instalados
/ 
/ Entity: entidade qualquer coisa importante no domínio da aplicação que precise ser apresentado como uma classe
/ POO: É flexível, Natural, bem elaborado e testável. Focada em objetos que interagem uns com os outros
/ Quatro principios da POO 1 Identificar as classes, 2 Separar as responsabilidades, 3 Estabelecer relacionamentos e 4 Pensar no reaproveitamento
/ ORM: Object Relational Mapping
/ Abre Ferramentas, gerenciador pacotes NuGet e instalar o "microsoft.entityframeworkcore.design", "Microsoft.EntityFrameworkCore" e o "microsoft.entityframeworkcore.sqlserver"
/ Ctrl + Shift + B para compilar as atualizações e verificar se tem falhas


_________________________________________
Aula 3- 10/08/23

/ registro.br - criar endereço web
/ 
/ Considerar o efeito tempo, dar a possibilidade de alterar os dados de usuários
/ O tempo é a quarta dimensão a ser considerada
/ 4 Pilares POO
/ Abstração: depende dos requisitos da aplicação, é oprocesso de definir classes simplificando a realidade focando no que é relevante no escopo da aplicação
/ Encapsulamento: para "esconder" os dados e detalhes da implementação de classe, para que outros métodos não dse preocupem com os detalhes da implementação, é disponibilizada para o resto do sistema através de métodos de gravação e leitura Getters e Setters
/ 

/ Assistir - H.E.R
/ 

/ Atividade: Publicar a atividede de classe da veterinária que está nos slides

___________________________________________
Aula 4 - 17/08/23

/ Assistir: Black mirror

/ POO
/ Identificação classes: verbo se refere ao método e se refere a entidade 
/ Separar as responsabilidades: cada classe tem seus atributos e ações
/ Estabelecer relacionamentos: 
/ Reaproveitar código: 

/ ORM: Object Relational Mapping
/ JSOM: JavaScript Object Notation
/ 
/ Para rodar pela primeira vez tem que estar no diretório PSIUWeb e usar o comando: dotnet ef migrations add Initial
/ Caso de erro tem que instalar o dotnet: dotnet ef migrations add Initial
/ 
/ Migrations: cria a tabela a partir da entidade
/ 
/ pro asp net core capitulo 3
/ 
/ 
/ 


___________________________________________
Aula 5 - 24/08/23


/ Atividade de fixação:
/ 1 - Crie um projeto ASP.NET MVC (template) com o nome PjLeonardoPerosaZago
/ 2 - Configure no projeto os NuGet Packages do EF Core
/ 3 - Especifique uma classe Model para Psicologo e defina um DBContext herdando do Identity 
/ 4 - Configure no APPSetings.json uma string de conexão com o SQL server
/ 5 - Defina os params de fonfig dos serviços do app no program.cs
/ 6 - Crie a Migration Initial e atualize o banco com ef
/ 
/ 


___________________________________________
Aula 6 - 31/08/23


/ Ctrl + Shift + B para testar se está compilanfdo certo
/ CRUD: Create Read Update Delete.
/ Persistir é armazenar no BD um objeto
/ Tela do usuário: View, UI - User Interface, GUI - Guide Uder Interface
/ Interface do usuário: Contrato da classe, especifica um método, não cria apenas vai servir como "adaptador"
/ Injeção de dependencia: 
/ DDL: Data definition
/ LINQ: Language Integrated Query
/ F5  para rodar
/ 
/ 
/ 

___________________________________________
Aula 7 - 21/09/23


/ Interface define um adaptador para definir os métodos como buscar paciente por Id... 
/ Método construtor tem o mesmo nome da classe
/ - Trabalhado no Index do Pacient e montado a tela de exibição da lista de pacientes
/ 
/ 
/ 
___________________________________________
Aula 8 - 28/09/23


/ Fazer o mesmo que foi feito para paciente para o Psico
/ Comando para DEBUG
/ F9 inicia o DEBUG
/ F10 passa linha
/ F11 vai para outra função
/ F5 vai até o próximo breackpoint
/ Da para arrastar a setinha de posição com o mouse
/ Razor é a engine para injetar código C# no Html
/ 
/ Atividade é fazer Controller, Insert, Index, Edit e Delete para Psico
/ 
/ 
___________________________________________
Aula 9 - 05/10/23


/ Classe POCO Plain Old C# Object
/ Método é um verbo
/ Agregação quando entidade tem relacionamento com outra mas não depende para existir
/ Sobrecarga - Overloading é usado para descrever métodos com o mesmo nome e diferentes parâmetros
/ Termo: CONTRACT - especificações dos modificadores de acesso definem o contrato da classe
/ Contrutores tem o mesmo nome da classe, um construtor sem parâmetros é definido como contrutor padrão (default constructor)
/ Dá pra fazer overloading em construtores utilizando parâmetros diferentes
/ Assinatura do método 
/ 
/ 
___________________________________________
Aula 10 - 19/10/23


/ Relacionamento entre as entidades Agregação(adiciona mas não é obrigatória. Ex: óculos) e Compisição(é necessário para existência. Ex: coração)
/ 
/ Tirar uma cópia da branch para ramificar o repositório: git checkout -b nome_da_branch
/ Transitar entre as branchs: git checkout nome_da_branch
/ Criar uma branch da branch principal
(A palavra "feature" é um diretório que vai ser criado para essas branchs): git checkout -b feature/Aula20231019
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 
/ 