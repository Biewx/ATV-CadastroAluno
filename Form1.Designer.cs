namespace ATV_CadastroAlunos
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
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridAlunos = new DataGridView();
            txtData = new MaskedTextBox();
            txtNome = new TextBox();
            txtCurso = new TextBox();
            txtTelefone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridAlunos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 55);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 98);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 142);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Curso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 183);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(123, 235);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Listar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(230, 235);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(338, 235);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(450, 235);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Limpar";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridAlunos
            // 
            dataGridAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAlunos.Location = new Point(44, 270);
            dataGridAlunos.Name = "dataGridAlunos";
            dataGridAlunos.Size = new Size(470, 150);
            dataGridAlunos.TabIndex = 13;
            // 
            // txtData
            // 
            txtData.ForeColor = SystemColors.WindowFrame;
            txtData.Location = new Point(163, 95);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(142, 23);
            txtData.TabIndex = 0;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(163, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(142, 23);
            txtNome.TabIndex = 14;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(163, 139);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(142, 23);
            txtCurso.TabIndex = 15;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(163, 180);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(142, 23);
            txtTelefone.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 432);
            Controls.Add(txtTelefone);
            Controls.Add(txtCurso);
            Controls.Add(txtNome);
            Controls.Add(txtData);
            Controls.Add(dataGridAlunos);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cadastro";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridAlunos;
        private MaskedTextBox txtData;
        private TextBox txtNome;
        private TextBox txtCurso;
        private TextBox txtTelefone;
    }
}
