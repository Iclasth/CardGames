using PickRandomCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Models
{
    public class SimplifyBlackJack
    {
        public SimplifyBlackJack() 
        { 

        }

        //Método utilizado para calcular o valor das cartas
        public static int GetCardValue(string card)
        {
            // Recebe apenas o valor da carta, ignorando o naipe
            string cardValue = card.Split(' ')[0];

            // Estrutura switch para determinar o valor da carta
            // Dando um valor as cartas de figura e ao Ás
            switch (cardValue)
            {
                case "Ace":
                    return 11;
                case "Jack":
                case "Queen":
                case "King":
                    return 10;
                default:
                    return int.Parse(cardValue);
            }
        }

        public static int CalculateHandValue(List<string> hand)
        {
            int totalValue = 0;
            int aceCount = 0;
            // Calcula o valor total da mão e conta o número de Ases
            foreach (var card in hand)
            {
                int cardValue = GetCardValue(card);
                totalValue += cardValue;
                if (cardValue == 11) // Se a carta for um Ás
                {
                    aceCount++;
                }
            }
            // Ajusta o valor dos Ases de 11 para 1 se o total exceder 21
            while (totalValue > 21 && aceCount > 0)
            {
                totalValue -= 10; // Ajusta um Ás de 11 para 1
                aceCount--;
            }
            return totalValue;
        }

        public static void PlaySimplifiedBlackJack()
        {
            // Inicia o jogo com duas cartas (jogador)
            List<string> playerHand = new List<string>(CardPicker.PickSomeCards(2));
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Simplified Blackjack");
                // Mostra as cartas do jogador
                Console.WriteLine("Your hand: " + string.Join(", ", playerHand));
                int handValue = CalculateHandValue(playerHand);
                Console.WriteLine($"Total: {handValue}");
                // Verifica o estado do jogo
                if (handValue == 21)
                {
                    Console.WriteLine("Nice! You hit 21! You win!");
                    break;
                }
                else if (handValue > 21)
                {
                    Console.WriteLine("Bust! You exceeded 21. You lose!");
                    break;



                }
                // Pergunta ao jogador se ele quer "Comprar" ou "Continuar"
                Console.Write("Do you want to (H)it or (S)tand? ");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "H")
                {
                    playerHand.AddRange(CardPicker.PickSomeCards(1));
                }
                else if (choice == "S")
                {
                    Console.WriteLine($"You chose to stand with a total of {handValue}. Thanks for playing!");
                    break;
                }
                // Escolha inválida, pede novamente
                else
                {
                    Console.WriteLine("Invalid choice. Please enter H or S.");

                }
            }
        }
    }


}
