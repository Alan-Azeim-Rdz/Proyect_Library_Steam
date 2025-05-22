namespace Proyect_Library_Steam
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
            BtnSearchGame = new Button();
            BtnShowGeneralGames = new Button();
            SuspendLayout();
            // 
            // BtnSearchGame
            // 
            BtnSearchGame.Location = new Point(152, 381);
            BtnSearchGame.Name = "BtnSearchGame";
            BtnSearchGame.Size = new Size(223, 111);
            BtnSearchGame.TabIndex = 0;
            BtnSearchGame.Text = "Buscar juego";
            BtnSearchGame.UseVisualStyleBackColor = true;
            BtnSearchGame.Click += BtnSearchGame_Click;
            // 
            // BtnShowGeneralGames
            // 
            BtnShowGeneralGames.Location = new Point(651, 381);
            BtnShowGeneralGames.Name = "BtnShowGeneralGames";
            BtnShowGeneralGames.Size = new Size(223, 111);
            BtnShowGeneralGames.TabIndex = 3;
            BtnShowGeneralGames.Text = "Biblioteca general";
            BtnShowGeneralGames.UseVisualStyleBackColor = true;
            BtnShowGeneralGames.Click += BtnShowGeneralGames_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_from_1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 637);
            Controls.Add(BtnShowGeneralGames);
            Controls.Add(BtnSearchGame);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSearchGame;
        private Button BtnShowGeneralGames;
    }
}
