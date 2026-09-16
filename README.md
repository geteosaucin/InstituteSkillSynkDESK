# InstituteSkillSynkDESK & AplicacaoWeb

Este repositório contém o código-fonte do sistema corporativo/educacional construído em C#, contemplando uma interface Desktop (Windows Forms) e uma Aplicação Web (MVC).

## 🚀 Tecnologias Utilizadas
* **C# / .NET**
* **Windows Forms** (Desktop)
* **ASP.NET MVC** (Web)
* **SQL Server** (Banco de Dados)
* **Entity Framework**

## 📋 Pré-requisitos
Para executar este projeto, você precisará ter instalado em sua máquina:
* [Visual Studio](https://visualstudio.microsoft.com/pt-br/) (2019 ou superior) com os workloads de desenvolvimento Desktop e Web.
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) e [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms).

## ⚙️ Como executar o projeto

### 1. Configuração do Banco de Dados
O sistema já conta com um script completo que cria a estrutura do banco (Tabelas de Cursos, Operadores, Usuários) e insere as cargas de dados iniciais.
1. Abra o SQL Server Management Studio (SSMS).
2. Vá em `File` > `Open` > `File...` e selecione o arquivo `script_banco.sql` localizado na pasta `Database` deste repositório.
3. Clique em **Execute** (ou aperte `F5`). 
4. O banco de dados `PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446` será criado automaticamente com todos os registros de teste.

### 2. Configuração da Aplicação
1. Clone este repositório:
   ```bash
   git clone [https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git](https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git)