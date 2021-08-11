
namespace BotForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.vTbCaptura1 = new System.Windows.Forms.TextBox();
            this.vTbResposta1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vBtn1 = new System.Windows.Forms.Button();
            this.vLb3 = new System.Windows.Forms.Label();
            this.vTbCaptura2 = new System.Windows.Forms.TextBox();
            this.vTbCaptura3 = new System.Windows.Forms.TextBox();
            this.vTbResposta3 = new System.Windows.Forms.TextBox();
            this.vTbResposta2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO AO BOT WHATSAPP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vTbCaptura1
            // 
            this.vTbCaptura1.Location = new System.Drawing.Point(12, 76);
            this.vTbCaptura1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vTbCaptura1.Name = "vTbCaptura1";
            this.vTbCaptura1.Size = new System.Drawing.Size(164, 23);
            this.vTbCaptura1.TabIndex = 1;
            // 
            // vTbResposta1
            // 
            this.vTbResposta1.Location = new System.Drawing.Point(352, 76);
            this.vTbResposta1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vTbResposta1.Name = "vTbResposta1";
            this.vTbResposta1.Size = new System.Drawing.Size(327, 23);
            this.vTbResposta1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira a Palavra de Captura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira a Resposta Que Deseja";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // vBtn1
            // 
            this.vBtn1.Location = new System.Drawing.Point(347, 262);
            this.vBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vBtn1.Name = "vBtn1";
            this.vBtn1.Size = new System.Drawing.Size(161, 22);
            this.vBtn1.TabIndex = 5;
            this.vBtn1.Text = "OK";
            this.vBtn1.UseVisualStyleBackColor = true;
            this.vBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vLb3
            // 
            this.vLb3.AutoSize = true;
            this.vLb3.Location = new System.Drawing.Point(514, 266);
            this.vLb3.Name = "vLb3";
            this.vLb3.Size = new System.Drawing.Size(196, 15);
            this.vLb3.TabIndex = 6;
            this.vLb3.Text = "Abrindo Chat WhatsApp Aguarde ...";
            this.vLb3.Visible = false;
            this.vLb3.Click += new System.EventHandler(this.label4_Click);
            // 
            // vTbCaptura2
            // 
            this.vTbCaptura2.Location = new System.Drawing.Point(12, 103);
            this.vTbCaptura2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vTbCaptura2.Name = "vTbCaptura2";
            this.vTbCaptura2.Size = new System.Drawing.Size(164, 23);
            this.vTbCaptura2.TabIndex = 7;
            // 
            // vTbCaptura3
            // 
            this.vTbCaptura3.Location = new System.Drawing.Point(12, 130);
            this.vTbCaptura3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vTbCaptura3.Name = "vTbCaptura3";
            this.vTbCaptura3.Size = new System.Drawing.Size(164, 23);
            this.vTbCaptura3.TabIndex = 8;
            // 
            // vTbResposta3
            // 
            this.vTbResposta3.Location = new System.Drawing.Point(352, 130);
            this.vTbResposta3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vTbResposta3.Name = "vTbResposta3";
            this.vTbResposta3.Size = new System.Drawing.Size(327, 23);
            this.vTbResposta3.TabIndex = 9;
            this.vTbResposta3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // vTbResposta2
            // 
            this.vTbResposta2.Location = new System.Drawing.Point(352, 103);
            this.vTbResposta2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vTbResposta2.Name = "vTbResposta2";
            this.vTbResposta2.Size = new System.Drawing.Size(327, 23);
            this.vTbResposta2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.vTbResposta2);
            this.Controls.Add(this.vTbResposta3);
            this.Controls.Add(this.vTbCaptura3);
            this.Controls.Add(this.vTbCaptura2);
            this.Controls.Add(this.vLb3);
            this.Controls.Add(this.vBtn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vTbResposta1);
            this.Controls.Add(this.vTbCaptura1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vTbCaptura1;
        private System.Windows.Forms.TextBox vTbResposta1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button vBtn1;
        private System.Windows.Forms.Label vLb3;
        private System.Windows.Forms.TextBox vTbCaptura2;
        private System.Windows.Forms.TextBox vTbCaptura3;
        private System.Windows.Forms.TextBox vTbResposta3;
        private System.Windows.Forms.TextBox vTbResposta2;
    }
}

