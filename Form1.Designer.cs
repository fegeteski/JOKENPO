namespace JOKENPÔ
{
    partial class jokenpo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jokenpo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pt_jogador = new System.Windows.Forms.Label();
            this.pt_cpu = new System.Windows.Forms.Label();
            this.pic_maq = new System.Windows.Forms.PictureBox();
            this.pic_jogador = new System.Windows.Forms.PictureBox();
            this.bt_tesoura = new System.Windows.Forms.Button();
            this.bt_papel = new System.Windows.Forms.Button();
            this.bt_pedra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_jogador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "JOGADOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pt_jogador
            // 
            this.pt_jogador.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt_jogador.Location = new System.Drawing.Point(192, 109);
            this.pt_jogador.Name = "pt_jogador";
            this.pt_jogador.Size = new System.Drawing.Size(40, 20);
            this.pt_jogador.TabIndex = 7;
            this.pt_jogador.Text = "0";
            this.pt_jogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pt_cpu
            // 
            this.pt_cpu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pt_cpu.Location = new System.Drawing.Point(281, 110);
            this.pt_cpu.Name = "pt_cpu";
            this.pt_cpu.Size = new System.Drawing.Size(40, 20);
            this.pt_cpu.TabIndex = 8;
            this.pt_cpu.Text = "0";
            this.pt_cpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_maq
            // 
            this.pic_maq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_maq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_maq.Location = new System.Drawing.Point(345, 42);
            this.pic_maq.Name = "pic_maq";
            this.pic_maq.Size = new System.Drawing.Size(150, 150);
            this.pic_maq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_maq.TabIndex = 4;
            this.pic_maq.TabStop = false;
            // 
            // pic_jogador
            // 
            this.pic_jogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_jogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_jogador.Location = new System.Drawing.Point(12, 42);
            this.pic_jogador.Name = "pic_jogador";
            this.pic_jogador.Size = new System.Drawing.Size(150, 150);
            this.pic_jogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_jogador.TabIndex = 3;
            this.pic_jogador.TabStop = false;
            // 
            // bt_tesoura
            // 
            this.bt_tesoura.BackColor = System.Drawing.SystemColors.Control;
            this.bt_tesoura.BackgroundImage = global::JOKENPÔ.Properties.Resources.TESOURA;
            this.bt_tesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_tesoura.Location = new System.Drawing.Point(375, 237);
            this.bt_tesoura.Name = "bt_tesoura";
            this.bt_tesoura.Size = new System.Drawing.Size(120, 120);
            this.bt_tesoura.TabIndex = 2;
            this.bt_tesoura.Tag = "2";
            this.bt_tesoura.UseVisualStyleBackColor = false;
            this.bt_tesoura.Click += new System.EventHandler(this.click_jogada);
            // 
            // bt_papel
            // 
            this.bt_papel.BackColor = System.Drawing.SystemColors.Control;
            this.bt_papel.BackgroundImage = global::JOKENPÔ.Properties.Resources.PAPEL;
            this.bt_papel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_papel.Location = new System.Drawing.Point(196, 237);
            this.bt_papel.Name = "bt_papel";
            this.bt_papel.Size = new System.Drawing.Size(120, 120);
            this.bt_papel.TabIndex = 1;
            this.bt_papel.Tag = "1";
            this.bt_papel.UseVisualStyleBackColor = false;
            this.bt_papel.Click += new System.EventHandler(this.click_jogada);
            // 
            // bt_pedra
            // 
            this.bt_pedra.BackColor = System.Drawing.SystemColors.Control;
            this.bt_pedra.BackgroundImage = global::JOKENPÔ.Properties.Resources.PEDRA;
            this.bt_pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pedra.Location = new System.Drawing.Point(12, 237);
            this.bt_pedra.Name = "bt_pedra";
            this.bt_pedra.Size = new System.Drawing.Size(120, 120);
            this.bt_pedra.TabIndex = 0;
            this.bt_pedra.Tag = "0";
            this.bt_pedra.UseVisualStyleBackColor = false;
            this.bt_pedra.Click += new System.EventHandler(this.click_jogada);
            // 
            // jokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 372);
            this.Controls.Add(this.pt_cpu);
            this.Controls.Add(this.pt_jogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_maq);
            this.Controls.Add(this.pic_jogador);
            this.Controls.Add(this.bt_tesoura);
            this.Controls.Add(this.bt_papel);
            this.Controls.Add(this.bt_pedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "jokenpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOKENPÔ";
            ((System.ComponentModel.ISupportInitialize)(this.pic_maq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_jogador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_pedra;
        private System.Windows.Forms.Button bt_papel;
        private System.Windows.Forms.Button bt_tesoura;
        private System.Windows.Forms.PictureBox pic_jogador;
        private System.Windows.Forms.PictureBox pic_maq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pt_jogador;
        private System.Windows.Forms.Label pt_cpu;
    }
}

