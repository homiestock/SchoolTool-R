namespace schoolToolR_cmsc437_sp2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            // card main menu opens
            flashcardMenuForm flashcards = new flashcardMenuForm();
            flashcards.Show();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            // note main menu opens
            notebookMenuForm notebook = new notebookMenuForm();
            notebook.Show();
        }

        private void btnNoteToCard_Click(object sender, EventArgs e)
        {
            // note-2-card menu opens
            notetocardMenuForm n2c = new notetocardMenuForm();
            n2c.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // options, about, accessability menu opens
            optionsMenuForm options = new optionsMenuForm();
            options.Show();
        }
    }
}
