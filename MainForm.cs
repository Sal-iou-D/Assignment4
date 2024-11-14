namespace Assignment3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            deck = new Deck(cardImageList);
            deck.Shuffle();
            DealAtStart();

        }
        private Deck deck;

        private DeckForm deckForm;



        private Card[] hand = new Card[5];

        private const string FILE_PATH = @"C:\Users\Saliou Diop\source\repos\Assignment4\SaveHands\";

        private void dealButtonClick(object sender, EventArgs e)
        {

            ShuffleNoCardKept();
            for (int i = 0; i < hand.Length; i++)
            {
                if (!KeptTheCard(i))
                {
                    hand[i] = deck.DealCard();
                }
            }

            UpdateHandDisplay();

            if (deckForm != null && !deckForm.IsDisposed)
            {
                deckForm.UpdateDeck();
            }



        }

        private void ShuffleNoCardKept()
        {
            bool anyKeepCheked = keep1CheckBox.Checked || keep2CheckBox.Checked || keep3CheckBox.Checked || 
                keep4CheckBox.Checked || keep5CheckBox.Checked;

            if(!anyKeepCheked)
            {
                deck.JustShuffle();
            }
        }

        private bool KeptTheCard(int index)
        {
            switch (index)
            {
                case 0: return keep1CheckBox.Checked;
                case 1: return keep2CheckBox.Checked;
                case 2: return keep3CheckBox.Checked;
                case 3: return keep4CheckBox.Checked;
                case 4: return keep5CheckBox.Checked;
                default: return false;
            }
        }

        private void UpdateHandDisplay()
        {
            card1PictureBox.Image = hand[0].CardImage;
            card2PictureBox.Image = hand[1].CardImage;
            card3PictureBox.Image = hand[2].CardImage;
            card4PictureBox.Image = hand[3].CardImage;
            card5PictureBox.Image = hand[4].CardImage;
        }

        private void DealAtStart()
        {
            for (int i = 0; i < hand.Length; i++)
            {
                hand[i] = deck.DealCard();
            }
            UpdateHandDisplay();
        }

        private void SaveHandButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = FILE_PATH,
                DefaultExt = "txt",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!deck.SaveHand(saveFileDialog.FileName, hand))
                {
                    MessageBox.Show("Error saving hand", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadHandButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = FILE_PATH,
                DefaultExt = "txt",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!deck.LoadHand(openFileDialog.FileName, hand))
                {
                    MessageBox.Show("Error loading hand", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UpdateHandDisplay();
                }
            }
        }

        private void ShowDeckbuttonClick(object sender, EventArgs e)
        {

            if (deckForm == null || deckForm.IsDisposed)
            {
                deckForm = new DeckForm(deck);
                deckForm.Show();
            }
            else if (!deckForm.Visible)
            {
                deckForm.Show();
            }
            else
            {
                deckForm.BringToFront();
            }

        }

        private void card1PictureBoxClick(object sender, EventArgs e)
        {
            keep1CheckBox.Checked = !keep1CheckBox.Checked;
        }

        private void card2PictureBoxClick(object sender, EventArgs e)
        {
            keep2CheckBox.Checked = !keep2CheckBox.Checked;
        }

        private void card3PictureBoxClick(object sender, EventArgs e)
        {
            keep3CheckBox.Checked = !keep3CheckBox.Checked;
        }

        private void card4PictureBoxClick(object sender, EventArgs e)
        {
            keep4CheckBox.Checked = !keep4CheckBox.Checked;
        }

        private void card5PictureBoxClick(object sender, EventArgs e)
        {
            keep5CheckBox.Checked = !keep5CheckBox.Checked;
        }
    }
}
