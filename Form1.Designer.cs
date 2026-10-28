namespace Cadastro_De_Notas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Boletim = new DataGridView();
            estudante = new DataGridViewTextBoxColumn();
            Diciplina = new DataGridViewTextBoxColumn();
            nota = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Boletim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do estudante";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 23);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Diciplina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 23);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota (0 a 10)";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(316, 41);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(74, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 86);
            button1.Name = "button1";
            button1.Size = new Size(100, 41);
            button1.TabIndex = 7;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(149, 86);
            button2.Name = "button2";
            button2.Size = new Size(100, 41);
            button2.TabIndex = 8;
            button2.Text = "Remover Selecionar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(290, 86);
            button3.Name = "button3";
            button3.Size = new Size(100, 41);
            button3.TabIndex = 9;
            button3.Text = "Limpar Todos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Boletim
            // 
            Boletim.AccessibleDescription = "";
            Boletim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Boletim.BackgroundColor = Color.White;
            Boletim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Boletim.Columns.AddRange(new DataGridViewColumn[] { estudante, Diciplina, nota });
            Boletim.GridColor = Color.Black;
            Boletim.Location = new Point(12, 155);
            Boletim.Name = "Boletim";
            Boletim.Size = new Size(378, 121);
            Boletim.TabIndex = 10;
            Boletim.CellContentClick += dataGridView1_CellContentClick;
            // 
            // estudante
            // 
            estudante.HeaderText = "estudante";
            estudante.Name = "estudante";
            // 
            // Diciplina
            // 
            Diciplina.HeaderText = "Diciplina";
            Diciplina.Name = "Diciplina";
            // 
            // nota
            // 
            nota.HeaderText = "nota";
            nota.Name = "nota";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Algoritmos", "Programação C#", "Banco de Dados", "Estruturas de Dados" });
            comboBox1.Location = new Point(162, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 308);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(378, 148);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 290);
            label4.Name = "label4";
            label4.Size = new Size(256, 15);
            label4.TabIndex = 13;
            label4.Text = "Resumo das coleções e matriz de desempenho:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(406, 479);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(Boletim);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Cadastro de Notas - Array e coleções";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Boletim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView Boletim;
        private DataGridViewTextBoxColumn estudante;
        private DataGridViewTextBoxColumn Diciplina;
        private DataGridViewTextBoxColumn nota;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Label label4;
    }
}
