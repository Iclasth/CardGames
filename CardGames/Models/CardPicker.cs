using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards.Models
{
    public class CardPicker
    {
        public CardPicker()
        {

        }
            static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            //Gera um número aleatório entre 1 e 4
            int value = random.Next(1, 5);
            //Retorna o naipe correspondente ao número gerado
            switch (value)
            {
                case 1:
                    return "Hearts";
                case 2:
                    return "Diamonds";
                case 3:
                    return "Clubs";
                case 4:
                    return "Spades";
                default:
                    return "Unknown";
            }
        }

        private static string RandomValue()
        {
            //Gera um número aleatório entre 1 e 13
            int value = random.Next(1, 14);
            
            //Retorna o valor correspondente ao número gerado
            switch (value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return value.ToString();
            }
        }
    }
}
