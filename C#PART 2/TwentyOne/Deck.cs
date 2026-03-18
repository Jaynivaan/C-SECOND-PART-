using System;

using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();

        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public void Deal(List<Card> hand)
        {
            throw new NotImplementedException(); 
        }
    }
}