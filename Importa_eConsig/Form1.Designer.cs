namespace Importa_eConsig
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox3 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            dgvDados = new DataGridView();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(338, 329);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 0;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(12, 329);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(610, 178);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDados);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(602, 150);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Folha";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonFace;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(4, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 16);
            textBox3.TabIndex = 3;
            textBox3.Text = "Ano/Mês:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(65, 12);
            maskedTextBox1.Mask = "0000/00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(70, 23);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(-4, 0);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(606, 150);
            dgvDados.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(141, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(609, 383);
            Controls.Add(button2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(tabControl1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Importa eConsignado";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox1;
        private DataGridView dgvDados;
        private Button button2;
    }
}
