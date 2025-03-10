# 🚀 Aplicação Frontend - Login SSO

Este projeto é um **frontend Angular 19 Standalone** para autenticação via **Google, Facebook e Microsoft** usando **Single Sign-On (SSO)**.

## 📌 Tecnologias Utilizadas
- Angular 19 (Standalone)
- Bootstrap
- FontAwesome
- TypeScript
- Angular Router

## 📂 Estrutura do Projeto
```
LoginSSO-App/
│-- src/
│   │-- app/
│   │   │-- components/
│   │   │-- services/
│   │   │-- app.routes.ts
│   │   │-- app.component.ts
│   │-- assets/
│   │-- environments/
│-- angular.json
│-- package.json
```

## ⚙️ Configuração
### 1️⃣ **Clonar o Repositório**
```sh
git clone https://github.com/seu-repositorio/loginSSO-app.git
cd loginSSO-app
```

### 2️⃣ **Instalar Dependências**
```sh
npm install
```

### 3️⃣ **Configurar o `environment.ts`**
No arquivo `src/environments/environment.ts`, configure a API base:
```typescript
export const environment = {
  production: false,
  apiBase: 'http://localhost:5189/auth' // URL da API .NET
};
```
Para Produção, edite `environment.prod.ts`:
```typescript
export const environment = {
  production: true,
  apiBase: 'https://seu-dominio.com/auth'
};
```

### 4️⃣ **Instalação e Configuração dos Provedores de Autenticação**
Para permitir login com Google, Facebook e Microsoft, é necessário configurar credenciais nos provedores:

#### 🔹 **Google**
1. Acesse [Google Developers Console](https://console.cloud.google.com/)
2. Crie um novo projeto e ative a API de autenticação
3. No menu **Credenciais**, crie um **OAuth 2.0 Client ID**
4. Configure a **URI de redirecionamento** como `http://localhost:5189/auth/google`
5. Copie o `Client ID` e `Client Secret` e configure no **backend**

#### 🔹 **Facebook**
1. Acesse [Facebook for Developers](https://developers.facebook.com/)
2. Crie um novo aplicativo
3. Vá para **Configurações → Básico** e adicione um **ID do App** e **Chave Secreta**
4. Configure a **URI de redirecionamento** como `http://localhost:5189/auth/facebook`
5. Copie as credenciais e configure no **backend**

#### 🔹 **Microsoft**
1. Acesse [Azure Portal](https://portal.azure.com/)
2. Crie um novo registro de aplicativo no **Azure Active Directory**
3. Adicione um **URI de redirecionamento** como `http://localhost:5189/auth/microsoft`
4. Gere um `Client ID` e `Client Secret` e configure no **backend**

### 5️⃣ **Rodar a Aplicação**
```sh
ng serve --configuration=development --open
```
A aplicação estará disponível em: [http://localhost:4200](http://localhost:4200)

## 🛠 Funcionalidades Principais
### 🔹 **Tela de Login**
- Opção de login via **Google, Facebook e Microsoft**
- UI moderna com **Bootstrap e FontAwesome**

### 🔹 **Fluxo de Autenticação**
- Redireciona o usuário para a API de autenticação
- Após login, exibe a tela "Logado com sucesso!"

## 📜 Licença
Este projeto está licenciado sob a [MIT License](LICENSE).

