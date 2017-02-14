using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Cardgame
    {
        public Dictionary<int, Card> Cards;
        public string[] cardTypes = new string[] { "Club", "Spade", "Diamond", "Heart" };
        public Cardgame()
        {
            Cards = new Dictionary<int, Card>();
        }
        /// <summary>
        /// Korttien sekoitus
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary">Dictionary to shuffle</param>
        public static void Shuffle<TKey, TValue>(ref Dictionary<TKey, TValue> dictionary )
        {
            KeyValuePair<TKey, TValue>[] valuePairs = dictionary.ToArray(); //Kirjaston avain ja arvoparit taulukkoon
            Random rand = new Random();

            for (int i = valuePairs.Length - 1; i >= 0; --i)
            {
                int j = rand.Next(0, i + 1);
                KeyValuePair<TKey, TValue> temp = valuePairs[i]; // temp on viimeinen pari taulukossa
                valuePairs[i] = valuePairs[j]; // viimeinen par on satunnainen valilta 0-i+1
                valuePairs[j] = temp; // sama satunnainen paikka on temp
            }

            dictionary = valuePairs.ToDictionary(k => k.Key, k => k.Value); // Tehdaan taulukko kirjastoksi uusilla paikoilla
        }
    }
    class Card : Cardgame
    {
        public string CardType { get; set; }
        public int CardNum { get; set; }
        public Card() { }
        public Card(string cardType)
        {
            CardType = cardType;
        }
    }
}
