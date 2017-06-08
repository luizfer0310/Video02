namespace video02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.certo1 = new System.Windows.Forms.Button();
            this.errado1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.certo2 = new System.Windows.Forms.Button();
            this.errado2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.certo3 = new System.Windows.Forms.Button();
            this.errado3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assista o video abaixo e Responda";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(45, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(286, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.youtube.com/watch?v=hfxfJ7Qa4sg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1- Qual tecnica utilizada para mander o foco em uma atividade ?";
            // 
            // certo1
            // 
            this.certo1.Location = new System.Drawing.Point(57, 77);
            this.certo1.Name = "certo1";
            this.certo1.Size = new System.Drawing.Size(75, 23);
            this.certo1.TabIndex = 3;
            this.certo1.Text = "Pomodoro";
            this.certo1.UseVisualStyleBackColor = true;
            this.certo1.Click += new System.EventHandler(this.certo1_Click);
            // 
            // errado1
            // 
            this.errado1.Location = new System.Drawing.Point(139, 77);
            this.errado1.Name = "errado1";
            this.errado1.Size = new System.Drawing.Size(75, 23);
            this.errado1.TabIndex = 4;
            this.errado1.Text = "Exadoro";
            this.errado1.UseVisualStyleBackColor = true;
            this.errado1.Click += new System.EventHandler(this.errado1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2- Qual tempo utilizado na tecnica de pomodoro ?";
            this.label3.Visible = false;
            // 
            // certo2
            // 
            this.certo2.Location = new System.Drawing.Point(139, 139);
            this.certo2.Name = "certo2";
            this.certo2.Size = new System.Drawing.Size(75, 23);
            this.certo2.TabIndex = 6;
            this.certo2.Text = "25 Minutos";
            this.certo2.UseVisualStyleBackColor = true;
            this.certo2.Visible = false;
            this.certo2.Click += new System.EventHandler(this.certo2_Click);
            // 
            // errado2
            // 
            this.errado2.Location = new System.Drawing.Point(57, 139);
            this.errado2.Name = "errado2";
            this.errado2.Size = new System.Drawing.Size(75, 23);
            this.errado2.TabIndex = 7;
            this.errado2.Text = "10 Minutos";
            this.errado2.UseVisualStyleBackColor = true;
            this.errado2.Visible = false;
            this.errado2.Click += new System.EventHandler(this.errado2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "3- Qual tempo de pausa dos 3 primeiros pomodoro ?";
            this.label4.Visible = false;
            // 
            // certo3
            // 
            this.certo3.Location = new System.Drawing.Point(57, 203);
            this.certo3.Name = "certo3";
            this.certo3.Size = new System.Drawing.Size(75, 23);
            this.certo3.TabIndex = 9;
            this.certo3.Text = "5 minutos";
            this.certo3.UseVisualStyleBackColor = true;
            this.certo3.Visible = false;
            this.certo3.Click += new System.EventHandler(this.certo3_Click);
            // 
            // errado3
            // 
            this.errado3.Location = new System.Drawing.Point(139, 202);
            this.errado3.Name = "errado3";
            this.errado3.Size = new System.Drawing.Size(75, 23);
            this.errado3.TabIndex = 10;
            this.errado3.Text = "10 Minutos";
            this.errado3.UseVisualStyleBackColor = true;
            this.errado3.Visible = false;
            this.errado3.Click += new System.EventHandler(this.errado3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 233);
            this.Controls.Add(this.errado3);
            this.Controls.Add(this.certo3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errado2);
            this.Controls.Add(this.certo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errado1);
            this.Controls.Add(this.certo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quiz Video 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button certo1;
        private System.Windows.Forms.Button errado1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button certo2;
        private System.Windows.Forms.Button errado2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button certo3;
        private System.Windows.Forms.Button errado3;
    }
}

