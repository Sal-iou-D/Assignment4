namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dealButton = new Button();
            saveHandButton = new Button();
            loadHandButton = new Button();
            keep1CheckBox = new CheckBox();
            keep2CheckBox = new CheckBox();
            keep3CheckBox = new CheckBox();
            keep4CheckBox = new CheckBox();
            keep5CheckBox = new CheckBox();
            cardImageList = new ImageList(components);
            card1PictureBox = new PictureBox();
            card2PictureBox = new PictureBox();
            card3PictureBox = new PictureBox();
            card4PictureBox = new PictureBox();
            card5PictureBox = new PictureBox();
            showDeckButton = new Button();
            ((System.ComponentModel.ISupportInitialize)card1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card4PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card5PictureBox).BeginInit();
            SuspendLayout();
            // 
            // dealButton
            // 
            dealButton.Location = new Point(36, 24);
            dealButton.Margin = new Padding(4);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(141, 80);
            dealButton.TabIndex = 0;
            dealButton.Text = "&Deal";
            dealButton.UseVisualStyleBackColor = true;
            dealButton.Click += dealButtonClick;
            // 
            // saveHandButton
            // 
            saveHandButton.Location = new Point(656, 22);
            saveHandButton.Margin = new Padding(4);
            saveHandButton.Name = "saveHandButton";
            saveHandButton.Size = new Size(141, 81);
            saveHandButton.TabIndex = 2;
            saveHandButton.Text = "&Save Hand";
            saveHandButton.UseVisualStyleBackColor = true;
            saveHandButton.Click += SaveHandButtonClick;
            // 
            // loadHandButton
            // 
            loadHandButton.Location = new Point(828, 24);
            loadHandButton.Margin = new Padding(4);
            loadHandButton.Name = "loadHandButton";
            loadHandButton.Size = new Size(141, 81);
            loadHandButton.TabIndex = 3;
            loadHandButton.Text = "&Load Hand";
            loadHandButton.UseVisualStyleBackColor = true;
            loadHandButton.Click += LoadHandButtonClick;
            // 
            // keep1CheckBox
            // 
            keep1CheckBox.AutoSize = true;
            keep1CheckBox.Location = new Point(36, 210);
            keep1CheckBox.Margin = new Padding(4);
            keep1CheckBox.Name = "keep1CheckBox";
            keep1CheckBox.Size = new Size(92, 29);
            keep1CheckBox.TabIndex = 4;
            keep1CheckBox.Text = "Keep &1";
            keep1CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep2CheckBox
            // 
            keep2CheckBox.AutoSize = true;
            keep2CheckBox.Location = new Point(235, 210);
            keep2CheckBox.Margin = new Padding(4);
            keep2CheckBox.Name = "keep2CheckBox";
            keep2CheckBox.Size = new Size(92, 29);
            keep2CheckBox.TabIndex = 5;
            keep2CheckBox.Text = "Keep &2";
            keep2CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep3CheckBox
            // 
            keep3CheckBox.AutoSize = true;
            keep3CheckBox.Location = new Point(425, 210);
            keep3CheckBox.Margin = new Padding(4);
            keep3CheckBox.Name = "keep3CheckBox";
            keep3CheckBox.Size = new Size(91, 29);
            keep3CheckBox.TabIndex = 6;
            keep3CheckBox.Text = "keep &3";
            keep3CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep4CheckBox
            // 
            keep4CheckBox.AutoSize = true;
            keep4CheckBox.Location = new Point(616, 210);
            keep4CheckBox.Margin = new Padding(4);
            keep4CheckBox.Name = "keep4CheckBox";
            keep4CheckBox.Size = new Size(92, 29);
            keep4CheckBox.TabIndex = 7;
            keep4CheckBox.Text = "Keep &4";
            keep4CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep5CheckBox
            // 
            keep5CheckBox.AutoSize = true;
            keep5CheckBox.Location = new Point(812, 210);
            keep5CheckBox.Margin = new Padding(4);
            keep5CheckBox.Name = "keep5CheckBox";
            keep5CheckBox.Size = new Size(92, 29);
            keep5CheckBox.TabIndex = 8;
            keep5CheckBox.Text = "Keep &5";
            keep5CheckBox.UseVisualStyleBackColor = true;
            // 
            // cardImageList
            // 
            cardImageList.ColorDepth = ColorDepth.Depth32Bit;
            cardImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardImageList.ImageStream");
            cardImageList.TransparentColor = Color.Transparent;
            cardImageList.Images.SetKeyName(0, "King of Clubs");
            cardImageList.Images.SetKeyName(1, "Ace of Clubs");
            cardImageList.Images.SetKeyName(2, "2 of Clubs");
            cardImageList.Images.SetKeyName(3, "3 of Clubs");
            cardImageList.Images.SetKeyName(4, "4 of Clubs");
            cardImageList.Images.SetKeyName(5, "5 of Clubs");
            cardImageList.Images.SetKeyName(6, "6 of Clubs");
            cardImageList.Images.SetKeyName(7, "7 of Clubs");
            cardImageList.Images.SetKeyName(8, "8 of Clubs");
            cardImageList.Images.SetKeyName(9, "9 of Clubs");
            cardImageList.Images.SetKeyName(10, "10 of Clubs");
            cardImageList.Images.SetKeyName(11, "Jack of Clubs");
            cardImageList.Images.SetKeyName(12, "Queen of Clubs");
            cardImageList.Images.SetKeyName(13, "King of Diamonds");
            cardImageList.Images.SetKeyName(14, "Ace of Diamonds");
            cardImageList.Images.SetKeyName(15, "2 of Diamonds");
            cardImageList.Images.SetKeyName(16, "3 of Diamonds");
            cardImageList.Images.SetKeyName(17, "4 of Diamonds");
            cardImageList.Images.SetKeyName(18, "5 of Diamonds");
            cardImageList.Images.SetKeyName(19, "6 of Diamonds");
            cardImageList.Images.SetKeyName(20, "7 of Diamonds");
            cardImageList.Images.SetKeyName(21, "8 of Diamonds");
            cardImageList.Images.SetKeyName(22, "9 of Diamonds");
            cardImageList.Images.SetKeyName(23, "10 of Diamonds");
            cardImageList.Images.SetKeyName(24, "Jack of Diamonds");
            cardImageList.Images.SetKeyName(25, "Queen of Diamonds");
            cardImageList.Images.SetKeyName(26, "King of Hearts");
            cardImageList.Images.SetKeyName(27, "Ace of Hearts");
            cardImageList.Images.SetKeyName(28, "2 of Hearts\n");
            cardImageList.Images.SetKeyName(29, "3 of Hearts\n");
            cardImageList.Images.SetKeyName(30, "4 of Hearts\n");
            cardImageList.Images.SetKeyName(31, "5 of Hearts\n");
            cardImageList.Images.SetKeyName(32, "6 of Hearts\n");
            cardImageList.Images.SetKeyName(33, "7 of Hearts\n");
            cardImageList.Images.SetKeyName(34, "8 of Hearts\n");
            cardImageList.Images.SetKeyName(35, "9 of Hearts\n");
            cardImageList.Images.SetKeyName(36, "10 of Hearts\n");
            cardImageList.Images.SetKeyName(37, "Jack of Hearts\n");
            cardImageList.Images.SetKeyName(38, "Queen of Hearts\n");
            cardImageList.Images.SetKeyName(39, "King of Spades\n");
            cardImageList.Images.SetKeyName(40, "Aces of Spades\n");
            cardImageList.Images.SetKeyName(41, "2 of Spades\n");
            cardImageList.Images.SetKeyName(42, "3 of Spades\n");
            cardImageList.Images.SetKeyName(43, "4 of Spades\n");
            cardImageList.Images.SetKeyName(44, "5 of Spades\n");
            cardImageList.Images.SetKeyName(45, "6 of Spades\n");
            cardImageList.Images.SetKeyName(46, "7 of Spades\n");
            cardImageList.Images.SetKeyName(47, "8 of Spades\n");
            cardImageList.Images.SetKeyName(48, "9 of Spades\n");
            cardImageList.Images.SetKeyName(49, "10 of Spades\n");
            cardImageList.Images.SetKeyName(50, "Jack of Spades\n");
            cardImageList.Images.SetKeyName(51, "Queen of Spades\n");
            // 
            // card1PictureBox
            // 
            card1PictureBox.Location = new Point(36, 248);
            card1PictureBox.Margin = new Padding(4);
            card1PictureBox.Name = "card1PictureBox";
            card1PictureBox.Size = new Size(156, 226);
            card1PictureBox.TabIndex = 8;
            card1PictureBox.TabStop = false;
            card1PictureBox.Click += card1PictureBoxClick;
            // 
            // card2PictureBox
            // 
            card2PictureBox.Location = new Point(235, 248);
            card2PictureBox.Margin = new Padding(4);
            card2PictureBox.Name = "card2PictureBox";
            card2PictureBox.Size = new Size(156, 226);
            card2PictureBox.TabIndex = 9;
            card2PictureBox.TabStop = false;
            card2PictureBox.Click += card2PictureBoxClick;
            // 
            // card3PictureBox
            // 
            card3PictureBox.Location = new Point(425, 248);
            card3PictureBox.Margin = new Padding(4);
            card3PictureBox.Name = "card3PictureBox";
            card3PictureBox.Size = new Size(156, 226);
            card3PictureBox.TabIndex = 10;
            card3PictureBox.TabStop = false;
            card3PictureBox.Click += card3PictureBoxClick;
            // 
            // card4PictureBox
            // 
            card4PictureBox.Location = new Point(616, 248);
            card4PictureBox.Margin = new Padding(4);
            card4PictureBox.Name = "card4PictureBox";
            card4PictureBox.Size = new Size(156, 226);
            card4PictureBox.TabIndex = 11;
            card4PictureBox.TabStop = false;
            card4PictureBox.Click += card4PictureBoxClick;
            // 
            // card5PictureBox
            // 
            card5PictureBox.Location = new Point(812, 248);
            card5PictureBox.Margin = new Padding(4);
            card5PictureBox.Name = "card5PictureBox";
            card5PictureBox.Size = new Size(156, 226);
            card5PictureBox.TabIndex = 12;
            card5PictureBox.TabStop = false;
            card5PictureBox.Click += card5PictureBoxClick;
            // 
            // showDeckButton
            // 
            showDeckButton.Location = new Point(338, 26);
            showDeckButton.Name = "showDeckButton";
            showDeckButton.Size = new Size(141, 79);
            showDeckButton.TabIndex = 1;
            showDeckButton.Text = "S&how Deck";
            showDeckButton.UseVisualStyleBackColor = true;
            showDeckButton.Click += ShowDeckbuttonClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(showDeckButton);
            Controls.Add(card5PictureBox);
            Controls.Add(card4PictureBox);
            Controls.Add(card3PictureBox);
            Controls.Add(card2PictureBox);
            Controls.Add(card1PictureBox);
            Controls.Add(keep5CheckBox);
            Controls.Add(keep4CheckBox);
            Controls.Add(keep3CheckBox);
            Controls.Add(keep2CheckBox);
            Controls.Add(keep1CheckBox);
            Controls.Add(loadHandButton);
            Controls.Add(saveHandButton);
            Controls.Add(dealButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Poker Hand Simulator";
            ((System.ComponentModel.ISupportInitialize)card1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card4PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card5PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dealButton;
        private Button saveHandButton;
        private Button loadHandButton;
        private CheckBox keep1CheckBox;
        private CheckBox keep2CheckBox;
        private CheckBox keep3CheckBox;
        private CheckBox keep4CheckBox;
        private CheckBox keep5CheckBox;
        private PictureBox card1PictureBox;
        private PictureBox card2PictureBox;
        private PictureBox card3PictureBox;
        private PictureBox card4PictureBox;
        private PictureBox card5PictureBox;
        private Button showDeckButton;
        public ImageList cardImageList;
    }
}
