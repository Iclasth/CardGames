# 🃏 Card Games in .NET

## 📌 Project Overview (English)

This project is a **console application** built in **C#** where you can play two card games:

* **Simplified Blackjack (21)** ♠️♥️♦️♣️
* **Pife** 🃏

The project is divided into three main classes inside the `Models` folder:

1. **CardPicker** 🃏

   * Responsible for generating random card values and suits.
   * Provides the `PickSomeCards(int numberOfCards)` method that returns an array of randomly chosen cards.

2. **SimplifyBlackjack** 🂡

   * Contains the **logic for the simplified Blackjack**, including summing card values and handling Aces.
   * Provides methods to evaluate a hand and determine if the player has won, lost, or continues.

3. **Pife** 🃏

   * Contains the **logic for Pife**, including detecting **Sets (Trincas)** and **Sequences (Sequências)**.
   * Provides methods to check valid combinations of cards.

4. **Program.cs** 💻

   * Interacts with the user via console input/output.
   * Allows the user to choose between playing **SimplifiedBlackjack** or **Pife**.
   * Calls the respective class to handle the game logic.



## 🛠️ Technologies Used

* C# (.NET)
* Console Application
* Collections: **Lists** and **Arrays**
* Static methods



## 🚀 How to Run

1. Clone this repository or copy the source code.
2. Open the project in **Visual Studio** or any C# IDE.
3. Run the program.
4. Choose the game you want to play.
5. Follow the prompts in the console.

Example output:

```
Welcome! Choose a game:
1 - Simplified Blackjack
2 - Pife
```



## 📜 Code Structure

* **Models/CardPicker.cs** 🃏 → Generates random cards.
* **Models/SimplifyBlackjack.cs** 🂡 → Implements Blackjack game logic.
* **Models/Pife.cs** 🃏 → Implements Pife game logic.
* **Program.cs** 💻 → Main program loop and user interaction.



# 🃏 Jogos de Cartas em .NET

## 📌 Visão Geral do Projeto (Português)

Este projeto é uma **aplicação de console** feita em **C#**, onde você pode jogar dois jogos de cartas:

* **Vinte e Um (Simplified Blackjack)** ♠️♥️♦️♣️
* **Pife** 🃏

O projeto é dividido em três classes principais dentro da pasta `Models`:

1. **CardPicker** 🃏

   * Responsável por gerar valores e naipes aleatórios das cartas.
   * Disponibiliza o método `PickSomeCards(int numberOfCards)` que retorna um array com as cartas sorteadas.

2. **SimplifyBlackjack** 🂡

   * Contém a **lógica do Blackjack simplificado (Vinte e um)**, incluindo a soma das cartas e o tratamento de Aces.
   * Fornece métodos para avaliar a mão e determinar se o jogador ganhou, perdeu ou continua.

3. **Pife** 🃏

   * Contém a **lógica do Pife**, incluindo verificação de **Trincas** e **Sequências**.
   * Fornece métodos para validar combinações de cartas.

4. **Program.cs** 💻

   * Faz a interação com o usuário via console.
   * Permite ao usuário escolher entre jogar **Vinte e Um** ou **Pife**.
   * Chama a classe correspondente para executar a lógica do jogo.



## 🛠️ Tecnologias Utilizadas

* C# (.NET)
* Aplicação de Console
* Coleções: **Listas e Arrays**
* Métodos estáticos



## 🚀 Como Executar

1. Clone este repositório ou copie o código-fonte.
2. Abra o projeto no **Visual Studio** ou qualquer IDE de C#.
3. Execute o programa.
4. Escolha o jogo que deseja jogar.
5. Siga as instruções no console.

Exemplo de saída:

```
Bem-vindo! Escolha um jogo:
1 - Vinte e Um
2 - Pife
```



## 📜 Estrutura do Código

* **Models/CardPicker.cs** 🃏 → Gera cartas aleatórias.
* **Models/SimplifyBlackjack.cs** 🂡 → Implementa a lógica do Blackjack.
* **Models/Pife.cs** 🃏 → Implementa a lógica do Pife.
* **Program.cs** 💻 → Loop principal e interação com o usuário.
