using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2
{
    public class Deck
    {
        //This constructor will assign values to properties upon creation.
        public Deck() //This deck constructor will run when a Deck object is created
        {
            //Could build a full deck like this but it is a lot of code
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
            
            //Old process for creating a deck before enum Suit and Face
            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            //List<string> Faces = new List<string>()
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven",
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};
            //foreach (string face in Faces)
            //{
            //    foreach (string suit in Suits)
            //    {
            //        Card card = new Card();
            //        card.Suit = suit;
            //        card.Face = face;
            //        Cards.Add(card);
            //    }
            //}
        }
        
        public List<Card> Cards { get; set; } //Deck has a property Cards that is a List of the object type Card

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); //Selects an int between 0 and to one less than the number of cards that are left
                    TempList.Add(Cards[randomIndex]); //Adds the card at the randomIndex in the Cards List to the TempList
                    Cards.RemoveAt(randomIndex); //Removes that card from the Cards List
                }
                Cards = TempList;
            }

        }

    }
}
