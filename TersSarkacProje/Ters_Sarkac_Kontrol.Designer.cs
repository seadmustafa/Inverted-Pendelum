namespace TersSarkacProjeFormUygulamasi
{
    partial class Ters_Sarkac_Kontrol
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
            this.components = new System.ComponentModel.Container();
            this.btnSimBaslat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtIlkAci = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModelYukle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimBaslat
            // 
            this.btnSimBaslat.Location = new System.Drawing.Point(18, 408);
            this.btnSimBaslat.Name = "btnSimBaslat";
            this.btnSimBaslat.Size = new System.Drawing.Size(111, 31);
            this.btnSimBaslat.TabIndex = 0;
            this.btnSimBaslat.Text = "Simülasyonu Başlat";
            this.btnSimBaslat.UseVisualStyleBackColor = true;
            this.btnSimBaslat.Click += new System.EventHandler(this.btnSimBaslat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(157, 330);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 108);
            this.listBox1.TabIndex = 1;
            // 
            // txtIlkAci
            // 
            this.txtIlkAci.Location = new System.Drawing.Point(98, 330);
            this.txtIlkAci.Name = "txtIlkAci";
            this.txtIlkAci.Size = new System.Drawing.Size(34, 20);
            this.txtIlkAci.TabIndex = 2;
            this.txtIlkAci.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "-4";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zedGraphControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zedGraphControl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.zedGraphControl1.IsScrollY2 = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(658, 302);
            this.zedGraphControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İlk Açı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "İlk Hız :";
            // 
            // btnModelYukle
            // 
            this.btnModelYukle.Location = new System.Drawing.Point(528, 331);
            this.btnModelYukle.Name = "btnModelYukle";
            this.btnModelYukle.Size = new System.Drawing.Size(10, 14);
            this.btnModelYukle.TabIndex = 8;
            this.btnModelYukle.Text = "Model Yükle";
            this.btnModelYukle.UseVisualStyleBackColor = true;
            this.btnModelYukle.Visible = false;
            this.btnModelYukle.Click += new System.EventHandler(this.btnModelYukle_Click);
            // 
            // Ters_Sarkac_Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 451);
            this.Controls.Add(this.btnModelYukle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtIlkAci);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSimBaslat);
            this.Name = "Ters_Sarkac_Kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ters Sarkaçların Bulanık Mantık Kontrol Simulasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimBaslat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtIlkAci;
        private System.Windows.Forms.TextBox textBox2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModelYukle;
    }
}

