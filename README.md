<div align="center">

# ⚡ Pokédex CRUD ⚡

### 🐾 Um sistema de cadastro de Pokémon desenvolvido em C# Windows Forms

<img src="https://img.shields.io/badge/C%23-Programming-blueviolet?style=for-the-badge&logo=csharp&logoColor=white">
<img src="https://img.shields.io/badge/.NET-Windows%20Forms-512BD4?style=for-the-badge&logo=.net&logoColor=white">
<img src="https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white">
<img src="https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white">

<br>

<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-v/black-white/animated/25.gif">

**「 Gotta code 'em all! 」**

</div>

---

## 🌟 Sobre o projeto

> Uma pequena Pokédex para grandes aventuras no mundo da programação! 🎮

Este projeto foi desenvolvido como prática de **Programação Orientada a Objetos (POO)** utilizando **C# e Windows Forms**.

A aplicação permite cadastrar e gerenciar Pokémon através de uma interface gráfica, utilizando um vetor de objetos para armazenar os dados.

---

## 🎯 Objetivo

O principal objetivo do projeto é colocar em prática conceitos fundamentais de programação, como:

```text
🧠 Programação Orientada a Objetos
📦 Classes e Objetos
🔐 Encapsulamento
🔢 Vetores de objetos
🔄 Estruturas de repetição
🔀 Estruturas condicionais
🛠️ Métodos
🖥️ Windows Forms
🗃️ Operações CRUD
```

---

## ✨ Funcionalidades

|     🔧 Função    | 📋 Descrição                         |
| :--------------: | ------------------------------------ |
| 🟢 **Cadastrar** | Adiciona um novo Pokémon à Pokédex   |
|   🔵 **Listar**  | Exibe todos os Pokémon cadastrados   |
|  🟡 **Renomear** | Altera o nome de um Pokémon          |
|  🟣 **Retipar**  | Altera o tipo de um Pokémon          |
|  🔴 **Excluir**  | Remove um Pokémon da Pokédex         |
| 🚫 **Validação** | Impede números da Pokédex duplicados |

---

## 🧩 Estrutura

```text
📁 Cadastro-Pokemon
│
├── 📄 Form1.cs
├── 📄 Form1.Designer.cs
├── 📄 Form1.resx
│
├── 🐾 Pokemon.cs
├── 📖 Pokedex.cs
│
└── 📄 Cadastro-Pokemon.sln
```

### 🐾 `Pokemon`

Representa cada Pokémon cadastrado.

```text
┌─────────────────────┐
│      POKÉMON        │
├─────────────────────┤
│ 🔢 Número           │
│ 📛 Nome             │
│ 🔥 Tipo             │
└─────────────────────┘
```

### 📖 `Pokedex`

Responsável pelo gerenciamento dos Pokémon.

```text
Cadastrar()
Renomear()
Retipar()
Listar()
Excluir()
```

### 🖥️ `Form1`

Responsável pela interface gráfica e pelos eventos dos botões.

---

## 🛠️ Tecnologias

<div align="center">

<img src="https://skillicons.dev/icons?i=cs,dotnet,visualstudio,git,github" />

</div>

---

## 💻 Como executar

### 1️⃣ Clone o repositório

```bash
git clone SEU_LINK_DO_REPOSITORIO
```

### 2️⃣ Abra o projeto

Abra o arquivo:

```text
Cadastro-Pokemon.sln
```

utilizando o **Visual Studio**.

### 3️⃣ Execute

Pressione:

```text
F5
```

ou clique em:

```text
▶ Iniciar
```

---

## 🎮 Como utilizar

### ➕ Cadastrar

Informe:

```text
Número → número na Pokédex
Nome   → nome do Pokémon
Tipo   → tipo do Pokémon
```

Depois clique em **Cadastrar**.

O sistema verifica se o número já está cadastrado antes de adicionar o Pokémon.

### ✏️ Renomear

Informe o número do Pokémon e o novo nome.

Exemplo:

```text
Número: 25
Nome: Pikachu
```

O sistema procura o Pokémon pelo número e altera seu nome.

### 🔄 Retipar

Informe o número do Pokémon e selecione um novo tipo.

### 🗑️ Excluir

Informe o número do Pokémon e clique em **Excluir**.

### 📋 Listar

Clique em **Listar** para visualizar os Pokémon cadastrados na tabela.

---

## 🧠 O que eu aprendi com esse projeto

Este projeto foi uma oportunidade para praticar a transição de um programa baseado em console para uma aplicação com **interface gráfica e eventos**.

Também foi possível trabalhar com:

* criação e utilização de classes;
* objetos armazenados em vetores;
* métodos de busca;
* validação de dados;
* alteração e exclusão de objetos;
* manipulação de componentes do Windows Forms;
* eventos de botões;
* integração entre interface e lógica de programação.

---

## 📸 Preview

<div align="center">

### 🖥️ Interface da Pokédex

> *Adicione aqui um print da aplicação.*

<img src="images/pokedex.png" width="700">

</div>

---

## 🚀 Próximas melhorias

Algumas funcionalidades que podem ser adicionadas futuramente:

* [ ] 💾 Salvar os Pokémon em arquivo
* [ ] 🔍 Pesquisar Pokémon
* [ ] 🖼️ Adicionar imagens dos Pokémon
* [ ] 📊 Melhorar a tabela de exibição
* [ ] 🎨 Criar uma interface mais temática
* [ ] 🗃️ Utilizar banco de dados
* [ ] 🌐 Criar uma API para a Pokédex

---
<div align="center">

## ✨ Alguns Pokémon cadastráveis ✨

<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png" width="100">
<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png" width="100">
<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png" width="100">
<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png" width="100">
<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/39.png" width="100">
<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png" width="100">

</div>

---

## 📚 Projeto acadêmico

Projeto desenvolvido como atividade prática para aprimoramento dos conhecimentos em **C#**, **Programação Orientada a Objetos** e **Windows Forms**.

---

<div align="center">

### ⚡ Desenvolvido com C#, café e algumas mensagens de erro. ☕💻

**Ilone Letícia**

⭐ Se este projeto foi útil para você, considere deixar uma estrela!

</div>
