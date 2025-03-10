# 🚀 API de Autenticação - Login SSO

Este projeto é uma API em **.NET 9** utilizando **Duende IdentityServer** para fornecer autenticação via **Google, Facebook e Microsoft** com suporte a **SSO (Single Sign-On)**.

## 📌 Tecnologias Utilizadas
- .NET 9
- Duende IdentityServer
- ASP.NET Core
- Swagger
- Autenticação OAuth2 com Google, Facebook e Microsoft

## 📂 Estrutura do Projeto
```
LoginSSO-API/
│-- Controllers/
│-- Models/
│-- Services/
│-- appsettings.json
│-- Program.cs
│-- Startup.cs (se aplicável)
```

## ⚙️ Configuração
### 1️⃣ **Clonar o Repositório**
```sh
git clone https://github.com/seu-repositorio/loginSSO-api.git
cd loginSSO-api
```

### 2️⃣ **Configurar o `appsettings.json`**
No arquivo `appsettings.json`, defina as credenciais dos provedores de autenticação:
```json
"Authentication": {
    "Google": {
        "ClientId": "SEU_GOOGLE_CLIENT_ID",
        "ClientSecret": "SEU_GOOGLE_CLIENT_SECRET"
    },
    "Facebook": {
        "AppId": "SEU_FACEBOOK_APP_ID",
        "AppSecret": "SEU_FACEBOOK_APP_SECRET"
    },
    "Microsoft": {
        "ClientId": "SEU_MICROSOFT_CLIENT_ID",
        "ClientSecret": "SEU_MICROSOFT_CLIENT_SECRET"
    }
}
```

### 3️⃣ **Configuração do IdentityServer**
O IdentityServer é configurado no `appsettings.json` para gerenciar clientes que fazem requisições de autenticação. Exemplo de configuração:
```json
"IdentityServer": {
    "Clients": [
      {
        "ClientId": "angular-app-dev",
        "AllowedGrantTypes": ["authorization_code"],
        "RedirectUris": ["http://localhost:4200/auth-callback"],
        "PostLogoutRedirectUris": ["http://localhost:4200/logout"],
        "AllowedScopes": ["openid", "profile", "email"]
      }
    ]
}
```

🔹 **Explicação dos parâmetros:**
- **ClientId**: Identificador único do cliente, no caso, a aplicação Angular.
- **AllowedGrantTypes**: Define o tipo de autenticação, sendo `authorization_code` o método mais seguro para SPAs.
- **RedirectUris**: URI para onde o usuário será redirecionado após login.
- **PostLogoutRedirectUris**: URI para onde o usuário será enviado após logout.
- **AllowedScopes**: Define quais informações podem ser acessadas, incluindo `openid`, `profile` e `email`.

### 4️⃣ **Rodar a API**
```sh
dotnet run --environment Development
```
A API estará disponível em: [http://localhost:5189](http://localhost:5189)

## 🛠 Endpoints Principais
### 🔹 **Autenticação**
- `GET /auth/google` → Redireciona para login via Google
- `GET /auth/facebook` → Redireciona para login via Facebook
- `GET /auth/microsoft` → Redireciona para login via Microsoft

## 📜 Licença
Este projeto está licenciado sob a [MIT License](LICENSE).

