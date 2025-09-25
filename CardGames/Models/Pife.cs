using PickRandomCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Models
{
    public class Pife
    {
        public Pife()
        {
        }


        public static bool isTrinca(List<string> cards)
        {
            if (cards.Count != 3)
            {
                return false; // Enquanto não tiver 3 cartas, não se forma uma trinca
            }

            // Pega o valor da primeira carta e compara com as outras
            string firstCardValue = cards[0].Split(' ')[0];
            return cards.All(card => card.Split(' ')[0] == firstCardValue);
        }

        public static bool isSequencia(List<string> cards)
        {
            if (cards.Count < 3)
            {
                return false; // Enquanto não tiver pelo menos 3 cartas, não se forma uma sequência
            }
            // Converte os valores das cartas para números inteiros
            List<int> cardValues = cards.Select(card =>
            {
                string value = card.Split(' ')[0];
                return value switch
                {
                    "Ace" => 1,
                    "Jack" => 11,
                    "Queen" => 12,
                    "King" => 13,
                    _ => int.Parse(value)
                };
            }).ToList();
            // Ordena os valores das cartas
            cardValues.Sort();
            // Verifica se os valores são consecutivos
            for (int i = 1; i < cardValues.Count; i++)
            {
                if (cardValues[i] != cardValues[i - 1] + 1)
                {
                    return false; // Se algum valor não for consecutivo, não é uma sequência
                }
            }
            return true; // Todos os valores são consecutivos, é uma sequência
        }

        public static void PlayPife()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Pife!");
            Console.WriteLine("Você receberá 10 cartas.\n Tente formar trincas (3 cartas do mesmo valor) ou sequências (3 ou mais cartas em ordem numérica do mesmo naipe).");
            List<string> playerHand = new List<string>(CardPicker.PickSomeCards(10));
            Console.WriteLine($"Your hand: {string.Join(", ", playerHand)}");

            if (isTrinca(playerHand))
            {
                Console.WriteLine("You formed a trinca!");
            }
            else if (isSequencia(playerHand))
            {
                Console.WriteLine("You formed a sequência!");
            }
            else
            {
                Console.WriteLine("No trinca or sequência formed.");
            }
        }
    }
}
