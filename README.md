# Sistema de Gerenciamento de Carteirinha  

Este é um sistema desenvolvido em **C# Web MVC**, utilizando **MySQL** como banco de dados.  

## 📌 Pré-requisitos  

Antes de executar o projeto, certifique-se de ter os seguintes requisitos instalados:  

- [.NET SDK](https://dotnet.microsoft.com/download)  
- [MySQL](https://www.mysql.com/downloads/)  

## ⚙️ Configuração da String de Conexão  

A string de conexão está localizada no arquivo `SistemaCarteirinha/Properties/launchSettings.json`. Edite conforme seu ambiente e modo de execução:  

```json
"environmentVariables": {
    "ASPNETCORE_ENVIRONMENT": "Development",
    "ConnectionString": "server=localhost;database=SISTEMA_CARTEIRINHA;user=root;password=root"
}
```
## 🗄️ Banco de Dados
Crie o banco de dados e a tabela utilizando o seguinte script SQL:

```sql
CREATE DATABASE SISTEMA_CARTEIRINHA;
USE SISTEMA_CARTEIRINHA;

CREATE TABLE PESSOA(
	ID_CLIENTE INTEGER PRIMARY KEY AUTO_INCREMENT,
    CNPJ VARCHAR(11) UNIQUE,
    RAZAO_SOCIAL VARCHAR(50),
    NOME_FANTASIA VARCHAR(50),
    CPF VARCHAR(11) UNIQUE,
    NOME VARCHAR(50),
    SEXO VARCHAR(1),
    DT_NASCIMENTO DATE,
    RG VARCHAR(8),
    ENDERECO VARCHAR(50),
    TELEFONE VARCHAR(11),
    EMAIL VARCHAR(50)
);
```
