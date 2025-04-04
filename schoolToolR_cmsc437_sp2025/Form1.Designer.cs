namespace schoolToolR_cmsc437_sp2025
{
    partial class Form1
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
            btnCards = new Button();
            btnNotes = new Button();
            btnNoteToCard = new Button();
            btnOptions = new Button();
            SuspendLayout();
            // 
            // btnCards
            // 
            btnCards.Location = new Point(12, 12);
            btnCards.Name = "btnCards";
            btnCards.Size = new Size(206, 139);
            btnCards.TabIndex = 0;
            btnCards.Text = "Flashcards";
            btnCards.UseVisualStyleBackColor = true;
            btnCards.Click += btnCards_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(240, 12);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(206, 139);
            btnNotes.TabIndex = 0;
            btnNotes.Text = "Notebook";
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnNoteToCard
            // 
            btnNoteToCard.Location = new Point(126, 200);
            btnNoteToCard.Name = "btnNoteToCard";
            btnNoteToCard.Size = new Size(206, 139);
            btnNoteToCard.TabIndex = 0;
            btnNoteToCard.Text = "Note-2-Card";
            btnNoteToCard.UseVisualStyleBackColor = true;
            btnNoteToCard.Click += btnNoteToCard_Click;
            // 
            // btnOptions
            // 
            btnOptions.Location = new Point(665, 409);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(123, 29);
            btnOptions.TabIndex = 1;
            btnOptions.Text = "Options";
            btnOptions.UseVisualStyleBackColor = true;
            btnOptions.Click += btnOptions_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOptions);
            Controls.Add(btnNoteToCard);
            Controls.Add(btnNotes);
            Controls.Add(btnCards);
            Name = "Form1";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCards;
        private Button btnNotes;
        private Button btnNoteToCard;
        private Button btnOptions;
    }
}
