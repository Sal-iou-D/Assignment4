using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Deck
    {
        private List<Card> cards;
        private ImageList imageList;

        public Deck(ImageList imageList)
        {
            this.imageList = imageList;
            cards = new List<Card>();
            //Shuffle();
        }

 
        public void Shuffle()
        {
            cards.Clear();
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                string cardName = imageList.Images.Keys[i];
                cards.Add(new Card(i, imageList.Images[i], cardName));
            }
            JustShuffle();
            
            
        }

        public void JustShuffle()
        {
            Random random = new Random();

            for (int i = 0; i < cards.Count; i++)
            {
                int randomIndex = random.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }

        
        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                return Card.NoCard; 
            }
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }

        
        public bool SaveHand(string filename, Card[] hand)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Card card in hand)
                    {
                        writer.WriteLine(card.Id);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       
        public bool LoadHand(string filename, Card[] hand)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    int i = 0;
                    while ((line = reader.ReadLine()) != null && i < hand.Length)
                    {
                        if (int.TryParse(line, out int cardId) && cardId >= 0 && cardId < imageList.Images.Count)
                        {
                            string cardName = imageList.Images.Keys[cardId];
                            hand[i] = new Card(cardId, imageList.Images[cardId], cardName);
                        }
                        else
                        {
                            hand[i] = Card.NoCard;
                        }
                        i++;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int Count => cards.Count;

        public Card GetCard(int index)
        {
            return (index >= 0 && index < cards.Count) ? cards[index] : Card.NoCard;
        }

        public void SwapCards(int index1, int index2)
        {
            if (index1 >= 0 && index1 < cards.Count && index2 >= 0 && index2 < cards.Count)
            {
                (cards[index1], cards[index2]) = (cards[index2], cards[index1]);
            }
        }

    }
}
