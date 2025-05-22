using System.Text;

namespace Proyect_Library_Steam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearchGame_Click(object sender, EventArgs e)
        {
            Search_Games shearch_Games = new Search_Games();
            shearch_Games.ShowDialog();
        }

        private void BtnShowGeneralGames_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.ShowDialog();

        }
    }
}
