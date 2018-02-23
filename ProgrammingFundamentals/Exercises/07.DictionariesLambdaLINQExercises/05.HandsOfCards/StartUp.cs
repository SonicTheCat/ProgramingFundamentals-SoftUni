namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(':');
         
            Dictionary<string, List<string>> playersScores = new Dictionary<string, List<string>>();
           
            while (input[0] != "JOKER")
            {
                var name = input[0];
                var cards = input[1].Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!playersScores.ContainsKey(name))
                {
                    playersScores.Add(name, cards);
                }
                else
                {
                    playersScores[name].AddRange(cards);
                }
                input = Console.ReadLine().Split(':');
            }
            foreach (var pairKeyValue in playersScores)
            {
                var cardType = 0;
                var cardPower = 0;
                var uniqeCards = playersScores[pairKeyValue.Key].Distinct().ToList();
                var sum = 0;
                foreach (var card in uniqeCards)
                {
                    if (card[card.Length - 1] == 'S') cardType = 4;
                    else if (card[card.Length - 1] == 'H') cardType = 3;
                    else if (card[card.Length - 1] == 'D') cardType = 2;
                    else if (card[card.Length - 1] == 'C') cardType = 1;

                    if (card[0] == '1') cardPower = 10;
                    else if (card[0] == '2') cardPower = 2;
                    else if(card[0] == '3') cardPower = 3;
                    else if(card[0] == '4') cardPower = 4;
                    else if(card[0] == '5') cardPower = 5;
                    else if (card[0] == '6') cardPower = 6;
                    else if (card[0] == '7') cardPower = 7;
                    else if (card[0] == '8') cardPower = 8;
                    else if (card[0] == '9') cardPower = 9;
                    else if (card[0] == 'J') cardPower = 11;
                    else if (card[0] == 'Q') cardPower = 12;
                    else if (card[0] == 'K') cardPower = 13;
                    else if (card[0] == 'A') cardPower = 14;
                    sum += cardPower * cardType;
                }
                Console.WriteLine($"{pairKeyValue.Key}: {sum}");
            }
        }
    }
}
