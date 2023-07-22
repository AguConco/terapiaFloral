namespace terapia_floral.Formularios
{
    partial class nueva_flor
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
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.Animated = true;
            this.btn_cancelar.AutoRoundedCorners = true;
            this.btn_cancelar.BorderRadius = 25;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelar.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_cancelar.Location = new System.Drawing.Point(83, 569);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(180, 52);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Animated = true;
            this.btn_agregar.AutoRoundedCorners = true;
            this.btn_agregar.BorderRadius = 25;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = System.Drawing.Color.ForestGreen;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(269, 569);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(232, 52);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(80, 60, 80, 60);
            this.panel1.Size = new System.Drawing.Size(584, 684);
            this.panel1.TabIndex = 1;
            // 
            // nueva_flor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 684);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(600, 700);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "nueva_flor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.nueva_flor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        private System.Windows.Forms.Panel panel1;
    }
}