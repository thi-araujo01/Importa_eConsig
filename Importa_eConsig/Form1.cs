using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Importa_eConsig
{
    public partial class Form1 : Form {
        string string_conection = "Server=200.201.215.117,14335;Database=Humanus_Crown_SIMU;User Id=2easy_mensag;Password=rt9m64x2wd3i;TrustServerCertificate=True;";
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

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnTest_Click(object sender, EventArgs e) {

            try {
                using (SqlConnection connection = new SqlConnection(string_conection)) {
                    connection.Open();
                    MessageBox.Show("Conectado com sucesso!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
