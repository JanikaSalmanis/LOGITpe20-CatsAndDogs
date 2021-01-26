namespace CatsAndDogs
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
            this.dogPicture = new System.Windows.Forms.PictureBox();
            this.GetADog = new System.Windows.Forms.Button();
            this.catPicture = new System.Windows.Forms.PictureBox();
            this.GetACat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPicture
            // 
            this.dogPicture.Location = new System.Drawing.Point(494, 12);
            this.dogPicture.Name = "dogPicture";
            this.dogPicture.Size = new System.Drawing.Size(457, 485);
            this.dogPicture.TabIndex = 0;
            this.dogPicture.TabStop = false;
            // 
            // GetADog
            // 
            this.GetADog.Location = new System.Drawing.Point(600, 519);
            this.GetADog.Name = "GetADog";
            this.GetADog.Size = new System.Drawing.Size(264, 46);
            this.GetADog.TabIndex = 2;
            this.GetADog.Text = "Get dog image";
            this.GetADog.UseVisualStyleBackColor = true;
            this.GetADog.Click += new System.EventHandler(this.GetADog_Click);
            // 
            // catPicture
            // 
            this.catPicture.Location = new System.Drawing.Point(12, 12);
            this.catPicture.Name = "catPicture";
            this.catPicture.Size = new System.Drawing.Size(436, 485);
            this.catPicture.TabIndex = 3;
            this.catPicture.TabStop = false;
            // 
            // GetACat
            // 
            this.GetACat.Location = new System.Drawing.Point(87, 519);
            this.GetACat.Name = "GetACat";
            this.GetACat.Size = new System.Drawing.Size(264, 44);
            this.GetACat.TabIndex = 4;
            this.GetACat.Text = "Get Cat image";
            this.GetACat.UseVisualStyleBackColor = true;
            this.GetACat.Click += new System.EventHandler(this.GetACat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 627);
            this.Controls.Add(this.GetACat);
            this.Controls.Add(this.catPicture);
            this.Controls.Add(this.GetADog);
            this.Controls.Add(this.dogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogPicture;
        private System.Windows.Forms.Button GetADog;
        private System.Windows.Forms.PictureBox catPicture;
        private System.Windows.Forms.Button GetACat;
    }
}

