using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Card
    {
        public int Id { get; private set; }
        public Image? CardImage { get; private set; }
        public string Name { get; }


        public Card(int id, Image? cardImage, string name)
        {
            Id = id;
            CardImage = cardImage;
            Name = name;
        }
        public static Card NoCard => new Card(-1, null, "No Card");

        public override string ToString()
        {
            return Name;
        }
    }
}
