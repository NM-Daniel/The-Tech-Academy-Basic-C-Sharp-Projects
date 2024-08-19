using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino2
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\natha\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\TwentyOne\TwentyOne\Log\log.txt", true)) //
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            } //Automatically disposes of the resources once this bracket is hit
            Deck.Cards.RemoveAt(0);
        }
    }
}
