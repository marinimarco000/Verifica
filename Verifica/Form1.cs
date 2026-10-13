namespace Verifica
{
    public partial class Form1 : Form
    {
        string[] decifrare = File.ReadAllLines("parole.txt");

        char[] lettere = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
        public Form1()
        {
            InitializeComponent();
            inizio.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;


        }

        private void lettura_Click(object sender, EventArgs e)
        {

            lettura.Visible = false;
            inizio.Visible = true;
        }

        private void inizio_Click(object sender, EventArgs e)
        {
            List<string> dadecifrare = new List<string>();


            for (int i = 2; i <= decifrare.Length; i = i + 2)// scorro array delle parole prese dal file
            {
                List<char> lavoro = new List<char>();
                string parola;
                string nuovaparola = "";
                parola = decifrare[i];
                for (int j = 0; j < parola.Length; j++)
                {
                    lavoro.Add(parola[j]);

                }
                for (int j = 0; j < lavoro.Count; j++)
                {

                    for (int k = 0; k < lettere.Length; k++)
                    {
                        if (lettere[k] == lavoro[j])
                        {
                            nuovaparola += lettere[k - 3];
                        }
                    }
                    dadecifrare.Add(nuovaparola);
                }

            }

        }
    }
}
