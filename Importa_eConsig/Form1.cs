using System.IO;
using System.Windows.Forms;

namespace Importa_eConsig
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            openFileDialog1.Title = "Selecione o arquivo JSON";
            openFileDialog1.Filter = "Arquivos JSON (*.json)|*.json|Todos os arquivos (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string caminhoSelecinado = openFileDialog1.FileName;
                textBox1.Text = caminhoSelecinado;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
    }
}
