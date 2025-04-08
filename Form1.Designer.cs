namespace Tic_Tac_ToeProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWhoTurn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWhoWin = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.Reset_Game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(490, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(110, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lblWhoTurn
            // 
            this.lblWhoTurn.AutoSize = true;
            this.lblWhoTurn.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoTurn.ForeColor = System.Drawing.Color.White;
            this.lblWhoTurn.Location = new System.Drawing.Point(111, 211);
            this.lblWhoTurn.Name = "lblWhoTurn";
            this.lblWhoTurn.Size = new System.Drawing.Size(175, 51);
            this.lblWhoTurn.TabIndex = 2;
            this.lblWhoTurn.Tag = "1";
            this.lblWhoTurn.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(99, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Winner";
            // 
            // lblWhoWin
            // 
            this.lblWhoWin.AutoSize = true;
            this.lblWhoWin.Font = new System.Drawing.Font("Georgia", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoWin.ForeColor = System.Drawing.Color.Lime;
            this.lblWhoWin.Location = new System.Drawing.Point(100, 345);
            this.lblWhoWin.Name = "lblWhoWin";
            this.lblWhoWin.Size = new System.Drawing.Size(258, 46);
            this.lblWhoWin.TabIndex = 4;
            this.lblWhoWin.Text = "in Progress";
            this.lblWhoWin.Click += new System.EventHandler(this.lblWhoWin_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn1.Location = new System.Drawing.Point(536, 142);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(109, 108);
            this.btn1.TabIndex = 5;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn2.Location = new System.Drawing.Point(688, 142);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(109, 108);
            this.btn2.TabIndex = 6;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn3.Location = new System.Drawing.Point(851, 142);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 108);
            this.btn3.TabIndex = 7;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn4.Location = new System.Drawing.Point(536, 293);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(109, 108);
            this.btn4.TabIndex = 8;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn5.Location = new System.Drawing.Point(688, 293);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(109, 108);
            this.btn5.TabIndex = 9;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn6.Location = new System.Drawing.Point(851, 293);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(109, 108);
            this.btn6.TabIndex = 10;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn7.Location = new System.Drawing.Point(536, 442);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(109, 108);
            this.btn7.TabIndex = 11;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn8.Location = new System.Drawing.Point(688, 442);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(109, 108);
            this.btn8.TabIndex = 12;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Image = global::Tic_Tac_ToeProject.Properties.Resources.question_mark_96;
            this.btn9.Location = new System.Drawing.Point(851, 442);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(109, 108);
            this.btn9.TabIndex = 13;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // Reset_Game
            // 
            this.Reset_Game.BackColor = System.Drawing.Color.Black;
            this.Reset_Game.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Game.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset_Game.Location = new System.Drawing.Point(86, 447);
            this.Reset_Game.Name = "Reset_Game";
            this.Reset_Game.Size = new System.Drawing.Size(231, 74);
            this.Reset_Game.TabIndex = 14;
            this.Reset_Game.Text = "Reset Game";
            this.Reset_Game.UseVisualStyleBackColor = false;
            this.Reset_Game.Click += new System.EventHandler(this.Reset_Game_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1142, 656);
            this.Controls.Add(this.Reset_Game);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblWhoWin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWhoTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Pain);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhoTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWhoWin;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button Reset_Game;
    }
}

