# NexusIdentity

Uma API REST moderna para gerenciamento de usuários, desenvolvida com ASP.NET Core 8.0 e Entity Framework Core.

## 📋 Sobre o Projeto

NexusIdentity é uma aplicação web API que fornece operações CRUD completas para gerenciamento de usuários. Construída seguindo as melhores práticas do ASP.NET Core, utiliza Entity Framework Core com SQLite para persistência de dados.

## 🚀 Tecnologias

- **.NET 8.0** - Framework principal
- **ASP.NET Core Web API** - Para criação de APIs RESTful
- **Entity Framework Core 8.0** - ORM para acesso a dados
- **SQLite** - Banco de dados leve e portátil
- **Swagger/OpenAPI** - Documentação interativa da API

## 📦 Dependências

```xml
- Microsoft.AspNetCore.OpenApi (8.0.22)
- Microsoft.EntityFrameworkCore.Design (8.0.0)
- Microsoft.EntityFrameworkCore.Sqlite (8.0.0)
- Swashbuckle.AspNetCore (6.6.2)
```

## 🛠️ Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior

## 🔧 Instalação

1. Clone o repositório:

```bash
git clone https://github.com/hyarlei/exus-identity-dotnet.git
cd NexusIdentity
```

1. Restaure as dependências:

```bash
dotnet restore
```

1. Execute as migrações do banco de dados:

```bash
dotnet ef database update
```

1. Execute a aplicação:

```bash
dotnet run
```

A API estará disponível em:

- **HTTPS**: <https://localhost:5001>
- **HTTP**: <http://localhost:5000>
- **Swagger UI**: <https://localhost:5001/swagger>

## 📚 Endpoints da API

### Usuários

| Método | Endpoint | Descrição |
| -------- | ---------- | ----------- |
| `GET` | `/api/user` | Lista todos os usuários |
| `GET` | `/api/user/{id}` | Busca usuário por ID |
| `POST` | `/api/user` | Cria um novo usuário |
| `PUT` | `/api/user/{id}` | Atualiza um usuário existente |
| `DELETE` | `/api/user/{id}` | Remove um usuário |

### Exemplos de Requisições

#### Criar Usuário

```http
POST /api/user
Content-Type: application/json

{
  "name": "João Silva",
  "email": "joao.silva@example.com"
}
```

#### Atualizar Usuário

```http
PUT /api/user/1
Content-Type: application/json

{
  "id": 1,
  "name": "João Silva Santos",
  "email": "joao.santos@example.com"
}
```

#### Listar Todos os Usuários

```http
GET /api/user
```

#### Buscar Usuário por ID

```http
GET /api/user/1
```

#### Deletar Usuário

```http
DELETE /api/user/1
```

## 🗄️ Estrutura do Banco de Dados

### Tabela: Users

| Coluna | Tipo | Descrição |
| -------- | ------ | ----------- |
| Id | INTEGER | Chave primária (auto-incremento) |
| Name | TEXT | Nome do usuário |
| Email | TEXT | E-mail do usuário |

## 📁 Estrutura do Projeto

```NexusIdentity/
├── Controllers/
│   └── UserController.cs       # Endpoints da API
├── Data/
│   └── AppDbContext.cs         # Contexto do Entity Framework
├── Migrations/                 # Migrações do banco de dados
├── Models/
│   └── User.cs                 # Modelo de dados do usuário
├── Properties/
│   └── launchSettings.json     # Configurações de inicialização
├── appsettings.json            # Configurações da aplicação
├── appsettings.Development.json
├── Program.cs                  # Ponto de entrada da aplicação
└── NexusIdentity.csproj        # Arquivo de projeto
```

## 🔨 Comandos Úteis

### Criar uma nova migração

```bash
dotnet ef migrations add NomeDaMigracao
```

### Aplicar migrações

```bash
dotnet ef database update
```

### Reverter última migração

```bash
dotnet ef migrations remove
```

### Compilar o projeto

```bash
dotnet build
```

### Executar testes

```bash
dotnet test
```

## 🌐 Ambientes

A aplicação está configurada para dois ambientes:

- **Development**: Com Swagger habilitado para testes e documentação
- **Production**: Otimizado para produção

## 📝 Configuração

As configurações podem ser ajustadas nos arquivos:

- `appsettings.json` - Configurações gerais
- `appsettings.Development.json` - Configurações de desenvolvimento

### String de Conexão

Por padrão, a aplicação usa SQLite com o arquivo `app.db`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=app.db"
  }
}
```

## 🤝 Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para:

1. Fazer um fork do projeto
2. Criar uma branch para sua feature (`git checkout -b feature/MinhaFeature`)
3. Commit suas mudanças (`git commit -m 'Adiciona MinhaFeature'`)
4. Push para a branch (`git push origin feature/MinhaFeature`)
5. Abrir um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT.

## 👤 Autor

### Hyarlei Silva

- GitHub: [@hyarlei](https://github.com/hyarlei)

## 📞 Suporte

Para reportar bugs ou solicitar features, por favor abra uma [issue](https://github.com/hyarlei/exus-identity-dotnet/issues).

---

Desenvolvido com ❤️ usando ASP.NET Core
