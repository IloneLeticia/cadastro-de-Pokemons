namespace teste_de_crud
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
            titulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numeroP = new TextBox();
            nomeP = new TextBox();
            btnCadastrar = new Button();
            btnRenomear = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            dataGridView1 = new DataGridView();
            tipoP = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(187, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(390, 40);
            titulo.TabIndex = 0;
            titulo.Text = "CADASTRO DE POKÉMON";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(49, 85);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 1;
            label1.Text = "numero de serie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(287, 83);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(456, 83);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 3;
            label3.Text = "tipo:";
            // 
            // numeroP
            // 
            numeroP.Location = new Point(181, 83);
            numeroP.Name = "numeroP";
            numeroP.Size = new Size(100, 23);
            numeroP.TabIndex = 4;
            numeroP.TextChanged += numeroP_TextChanged;
            // 
            // nomeP
            // 
            nomeP.Location = new Point(345, 83);
            nomeP.Name = "nomeP";
            nomeP.Size = new Size(100, 23);
            nomeP.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(122, 153);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(93, 23);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRenomear
            // 
            btnRenomear.Location = new Point(258, 153);
            btnRenomear.Name = "btnRenomear";
            btnRenomear.Size = new Size(96, 23);
            btnRenomear.TabIndex = 8;
            btnRenomear.Text = "RENOMEAR";
            btnRenomear.UseVisualStyleBackColor = true;
            btnRenomear.Click += btnRenomear_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(388, 153);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(502, 153);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 10;
            btnListar.Text = "LISTAR";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(111, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 212);
            dataGridView1.TabIndex = 11;
            // 
            // tipoP
            // 
            tipoP.FormattingEnabled = true;
            tipoP.Items.AddRange(new object[] { "Normal", "Fogo", "Água", "Elétrico", "Planta", "Gelo", "Lutador", "Veneno", "Terrestre", "Voador", "Psíquico", "Inseto", "Pedra", "Fantasma", "Dragão", "Sombrio", "Aço", "Fada" });
            tipoP.Location = new Point(502, 83);
            tipoP.Name = "tipoP";
            tipoP.Size = new Size(121, 23);
            tipoP.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(tipoP);
            Controls.Add(dataGridView1);
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(btnRenomear);
            Controls.Add(btnCadastrar);
            Controls.Add(nomeP);
            Controls.Add(numeroP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(titulo);
            ForeColor = Color.DarkRed;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numeroP;
        private TextBox nomeP;
        private Button btnCadastrar;
        private Button btnRenomear;
        private Button btnExcluir;
        private Button btnListar;
        private DataGridView dataGridView1;
        private ComboBox tipoP;
    }
}
