
namespace WilianMiranda01.VISTA
{
    partial class FmrOperaciones
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkjfhk = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuma.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.Location = new System.Drawing.Point(0, 0);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(197, 74);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "SUMA";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSuma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 413);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "RESTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkjfhk);
            this.panel2.Controls.Add(this.txtResultado);
            this.panel2.Controls.Add(this.txtDato2);
            this.panel2.Controls.Add(this.txtDato1);
            this.panel2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(311, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 255);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESULTADO:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa un segundo dato:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkjfhk
            // 
            this.chkjfhk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkjfhk.AutoSize = true;
            this.chkjfhk.Location = new System.Drawing.Point(3, 4);
            this.chkjfhk.Name = "chkjfhk";
            this.chkjfhk.Size = new System.Drawing.Size(199, 30);
            this.chkjfhk.TabIndex = 3;
            this.chkjfhk.Text = "Ingresa un dato:";
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Location = new System.Drawing.Point(6, 209);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(295, 37);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDato2
            // 
            this.txtDato2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDato2.Location = new System.Drawing.Point(6, 110);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(295, 37);
            this.txtDato2.TabIndex = 1;
            // 
            // txtDato1
            // 
            this.txtDato1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDato1.Location = new System.Drawing.Point(6, 37);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(295, 37);
            this.txtDato1.TabIndex = 0;
            this.txtDato1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FmrOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 413);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FmrOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrOperaciones";
            this.Load += new System.EventHandler(this.FmrOperaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chkjfhk;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSuma;
        public System.Windows.Forms.Button button1;
    }
}