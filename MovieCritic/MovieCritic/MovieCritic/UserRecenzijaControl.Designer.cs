namespace MovieCritic
{
    partial class UserRecenzijaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRecenzijaControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAutor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDatum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richtxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtAutor
            // 
            this.txtAutor.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAutor.BorderColorIdle = System.Drawing.Color.MediumAquamarine;
            this.txtAutor.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAutor.BorderThickness = 3;
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAutor.ForeColor = System.Drawing.Color.White;
            this.txtAutor.isPassword = false;
            this.txtAutor.Location = new System.Drawing.Point(133, 104);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(154, 35);
            this.txtAutor.TabIndex = 1;
            this.txtAutor.Text = "autor";
            this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDatum
            // 
            this.txtDatum.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDatum.BorderColorIdle = System.Drawing.Color.MediumAquamarine;
            this.txtDatum.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDatum.BorderThickness = 3;
            this.txtDatum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDatum.ForeColor = System.Drawing.Color.White;
            this.txtDatum.isPassword = false;
            this.txtDatum.Location = new System.Drawing.Point(304, 104);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(154, 35);
            this.txtDatum.TabIndex = 2;
            this.txtDatum.Text = "datum";
            this.txtDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(353, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "datum:";
            // 
            // richtxt
            // 
            this.richtxt.BackColor = System.Drawing.Color.Black;
            this.richtxt.ForeColor = System.Drawing.Color.White;
            this.richtxt.Location = new System.Drawing.Point(133, 153);
            this.richtxt.Name = "richtxt";
            this.richtxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richtxt.Size = new System.Drawing.Size(325, 82);
            this.richtxt.TabIndex = 5;
            this.richtxt.Text = "";
            // 
            // UserRecenzijaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.richtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserRecenzijaControl";
            this.Size = new System.Drawing.Size(594, 363);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAutor;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richtxt;
    }
}
