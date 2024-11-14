using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class DeckForm : Form

    {
        private Deck deck;
        public DeckForm(Deck deck)
        {
            InitializeComponent();
            this.deck = deck;

        }

        //private Deck deck;
        //deck = new Deck();

        public void UpdateDeck()
        {
            deckListBox.Items.Clear();
            for (int i = 0; i < deck.Count; i++)
            {
                deckListBox.Items.Add(deck.GetCard(i));
            }
        }
        private void DeckForm_Load(object sender, EventArgs e)
        {
            UpdateDeck();
        }

        private void deckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card? card = (Card?)deckListBox.SelectedItem;
            deckPictureBox.Image = card?.CardImage;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = deckListBox.SelectedIndex;
            if (selectedIndex > 0)
            {
                deck.SwapCards(selectedIndex, selectedIndex - 1);
                UpdateDeck();
                deckListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = deckListBox.SelectedIndex;
            if (selectedIndex < deck.Count - 1)
            {
                deck.SwapCards(selectedIndex, selectedIndex + 1);
                UpdateDeck();
                deckListBox.SelectedIndex = selectedIndex + 1;
            }
        }
    }
}
