namespace MovieCritic
{
    partial class CustomControl1
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
            this.userFilmControl1 = new MovieCritic.UserFilmControl();
            this.SuspendLayout();
            // 
            // userFilmControl1
            // 
            this.userFilmControl1.BackColor = System.Drawing.Color.Black;
            this.userFilmControl1.Location = new System.Drawing.Point(0, 0);
            this.userFilmControl1.Name = "userFilmControl1";
            this.userFilmControl1.Size = new System.Drawing.Size(771, 172);
            this.userFilmControl1.TabIndex = 0;
            this.userFilmControl1.Text = "userFilmControl1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserFilmControl userFilmControl1;
    }
}
