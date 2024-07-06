namespace CareerTide
{
    partial class NewApplicationGUI
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
            this.TopDockPB = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.applyForLB = new System.Windows.Forms.Label();
            this.atLB = new System.Windows.Forms.Label();
            this.positionTB = new System.Windows.Forms.TextBox();
            this.cpnTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopDockPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TopDockPB
            // 
            this.TopDockPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopDockPB.Image = global::CareerTide.Properties.Resources.red_and_black_background;
            this.TopDockPB.Location = new System.Drawing.Point(0, 0);
            this.TopDockPB.Name = "TopDockPB";
            this.TopDockPB.Size = new System.Drawing.Size(1127, 57);
            this.TopDockPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopDockPB.TabIndex = 3;
            this.TopDockPB.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = global::CareerTide.Properties.Resources.red_and_black_background;
            this.pictureBox4.Location = new System.Drawing.Point(0, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 530);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // applyForLB
            // 
            this.applyForLB.AutoSize = true;
            this.applyForLB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyForLB.Location = new System.Drawing.Point(133, 70);
            this.applyForLB.Name = "applyForLB";
            this.applyForLB.Size = new System.Drawing.Size(80, 24);
            this.applyForLB.TabIndex = 11;
            this.applyForLB.Text = "Apply for";
            // 
            // atLB
            // 
            this.atLB.AutoSize = true;
            this.atLB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atLB.Location = new System.Drawing.Point(133, 110);
            this.atLB.Name = "atLB";
            this.atLB.Size = new System.Drawing.Size(26, 24);
            this.atLB.TabIndex = 12;
            this.atLB.Text = "At";
            // 
            // positionTB
            // 
            this.positionTB.Location = new System.Drawing.Point(219, 72);
            this.positionTB.Name = "positionTB";
            this.positionTB.ReadOnly = true;
            this.positionTB.Size = new System.Drawing.Size(202, 22);
            this.positionTB.TabIndex = 13;
            // 
            // cpnTB
            // 
            this.cpnTB.Location = new System.Drawing.Point(165, 112);
            this.cpnTB.Name = "cpnTB";
            this.cpnTB.ReadOnly = true;
            this.cpnTB.Size = new System.Drawing.Size(256, 22);
            this.cpnTB.TabIndex = 14;
            // 
            // NewApplicationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 587);
            this.Controls.Add(this.cpnTB);
            this.Controls.Add(this.positionTB);
            this.Controls.Add(this.atLB);
            this.Controls.Add(this.applyForLB);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TopDockPB);
            this.Name = "NewApplicationGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewApplicationGUI";
            this.Load += new System.EventHandler(this.NewApplicationGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopDockPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopDockPB;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label applyForLB;
        private System.Windows.Forms.Label atLB;
        private System.Windows.Forms.TextBox positionTB;
        private System.Windows.Forms.TextBox cpnTB;
    }
}