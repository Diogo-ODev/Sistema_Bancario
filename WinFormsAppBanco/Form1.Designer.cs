namespace WinFormsAppBanco
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
            txtNumeroConta = new TextBox();
            groupBox1 = new GroupBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCriarConta = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 42);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero da Conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 103);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 168);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtNumeroConta
            // 
            txtNumeroConta.Location = new Point(106, 60);
            txtNumeroConta.Name = "txtNumeroConta";
            txtNumeroConta.Size = new Size(100, 23);
            txtNumeroConta.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCriarConta);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumeroConta);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 607);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(104, 121);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(104, 186);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 5;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(117, 237);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(117, 300);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(75, 23);
            btnCriarConta.TabIndex = 7;
            btnCriarConta.Text = "Criar";
            btnCriarConta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 282);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 8;
            label4.Text = "Já tem uma conta?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 663);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumeroConta;
        private GroupBox groupBox1;
        private Button btnCriarConta;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtNome;
        private Label label4;
    }
}
