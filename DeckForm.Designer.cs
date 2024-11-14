namespace Assignment3
{
    partial class DeckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardsLabel = new Label();
            deckListBox = new ListBox();
            deckPictureBox = new PictureBox();
            upButton = new Button();
            downButton = new Button();
            ((System.ComponentModel.ISupportInitialize)deckPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardsLabel
            // 
            cardsLabel.AutoSize = true;
            cardsLabel.Location = new Point(58, 43);
            cardsLabel.Name = "cardsLabel";
            cardsLabel.Size = new Size(57, 25);
            cardsLabel.TabIndex = 0;
            cardsLabel.Text = "&Cards";
            // 
            // deckListBox
            // 
            deckListBox.FormattingEnabled = true;
            deckListBox.ItemHeight = 25;
            deckListBox.Location = new Point(63, 76);
            deckListBox.Name = "deckListBox";
            deckListBox.Size = new Size(314, 329);
            deckListBox.TabIndex = 1;
            deckListBox.SelectedIndexChanged += deckListBox_SelectedIndexChanged;
            // 
            // deckPictureBox
            // 
            deckPictureBox.Location = new Point(556, 180);
            deckPictureBox.Name = "deckPictureBox";
            deckPictureBox.Size = new Size(156, 226);
            deckPictureBox.TabIndex = 2;
            deckPictureBox.TabStop = false;
            // 
            // upButton
            // 
            upButton.Location = new Point(414, 76);
            upButton.Name = "upButton";
            upButton.Size = new Size(112, 34);
            upButton.TabIndex = 2;
            upButton.Text = "&Up";
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // downButton
            // 
            downButton.Location = new Point(414, 129);
            downButton.Name = "downButton";
            downButton.Size = new Size(112, 34);
            downButton.TabIndex = 3;
            downButton.Text = "&Down";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downButton);
            Controls.Add(upButton);
            Controls.Add(deckPictureBox);
            Controls.Add(deckListBox);
            Controls.Add(cardsLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeckForm";
            Text = "Deck";
            Load += DeckForm_Load;
            ((System.ComponentModel.ISupportInitialize)deckPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cardsLabel;
        private ListBox deckListBox;
        private PictureBox deckPictureBox;
        private Button upButton;
        private Button downButton;
    }
}