## 📚 Saber Livre – Sistema de Gerenciamento de Biblioteca

Saber Livre é um sistema desktop desenvolvido em VB.NET (Windows Forms) com integração a banco de dados Microsoft Access, criado para facilitar o controle de bibliotecas de pequeno e médio porte.

Ele oferece uma interface moderna, intuitiva e colorida, permitindo que o usuário realize o gerenciamento completo de usuários, livros, leitores e empréstimos de forma prática e visualmente agradável.


## 🎨 Design e Interface

O sistema adota um tema escuro com tons vibrantes, proporcionando conforto visual e uma experiência moderna.
Cada módulo possui uma cor própria para facilitar a identificação rápida das seções:



## ⚙️ Funcionalidades Principais

Login e autenticação simples

Gerenciamento de usuários: cadastro, edição e exclusão

Controle de livros: adicionar, pesquisar e atualizar exemplares

Registro de leitores e empréstimos

Busca rápida: sistema de pesquisa dinâmico com filtros

Interface responsiva e sem bordas, com janelas sobrepostas de forma fluida

Banco de dados Access local, fácil de transportar e fazer backup


## 🧩 Estrutura do Projeto

```shell
📦 SaberLivre
 ┣ 📂 Forms
 ┃ ┣ frmMain.vb         → Tela principal (Dashboard)
 ┃ ┣ frmLogin.vb        → Tela de autenticação
 ┃ ┣ frmUser.vb         → Módulo de usuários
 ┃ ┣ frmLivros.vb       → Módulo de livros
 ┃ ┣ frmLeitores.vb     → Módulo de leitores
 ┃ ┣ frmEmprestimos.vb  → Módulo de empréstimos
 ┃ ┗ frmPesquisa.vb     → Janela de pesquisa universal
 ┣ 📂 Database
 ┃ ┗ dbBibliotecaAtual1.accdb
 ┗ 📜 README.md
 ```

## Demonstração

![Imagem Do sistema da biblioteca](Biblioteca/assets/image.png)


## Aprendizados

O que você aprendeu construindo esse projeto? Quais desafios você enfrentou e como você superou-os?


## 💾 Requisitos

Sistema Operacional: Windows 10 ou superior

.NET Framework: 4.7.2 ou superior

Banco de Dados: Microsoft Access (.accdb)

IDE recomendada: Visual Studio

## 🚀 Como Executar

Clone este repositório ou baixe o projeto.

Abra o arquivo .sln no Visual Studio.

Configure a conexão do banco de dados no código, se necessário:

Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\...\dbBibliotecaAtual1.accdb

Execute o projeto (F5).

🧠 Tecnologias Utilizadas

VB.NET (Windows Forms)

Microsoft Access

GDI+ para estilização customizada

Icons e ilustrações vetoriais
