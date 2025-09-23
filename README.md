## Projeto base para manutenção e evolução de banco de dados

## Pontos principais
* Conexão com o banco de dados: Arquivo ContextoBancoDados.cs
* Tabela de controle das migrações de banco de dados executadas: __EFMigrationsHistory
* Para usar SQL Server: UseSqlServer do arquivo ContextoBancoDados.cs
* Para usar PostgreSQL: UseNpgsql do arquivo ContextoBancoDados.cs

## Via dotnet CLI ou Terminal do VSCode
* **dotnet tool install --global dotnet-ef** [ Habilitar o cli via dotnet ef - Executar apenas uma vez ]
* **dotnet ef migrations add NomeDaMigracao** [ Criar uma migração. Sempre que quiser uma nova alteração no banco de dados ]
* **dotnet ef database update** [ Atualizar as migrações de banco de dados. Sempre que quiser efetivar no banco as mudanças ]
* Observar para estar no diretório do projeto que contém as migrações

## Via Visual Studio (Package Manager Console)
* Executar os comandos no Package Manager Console (View -> Other Windows -> Package Manager Console)
* **Add-Migration NomeDaMigraca**o [ Criar uma migração. Sempre que quiser uma nova alteração no banco de dados ]
* **Update-Database** [ Atualizar as migrações de banco de dados. Sempre que quiser efetivar no banco as mudanças ]
* Observar para marcar o projeto que contem as migrações de banco de dados

## Alterações no appsettings.json não aparecem para commit no repositório local
git update-index --assume-unchanged gcodb/appsettings.json
