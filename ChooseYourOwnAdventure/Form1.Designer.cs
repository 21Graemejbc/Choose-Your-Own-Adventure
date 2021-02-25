
namespace ChooseYourOwnAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.storyOutput = new System.Windows.Forms.Label();
            this.promptOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.blueOutput = new System.Windows.Forms.Label();
            this.redOutput = new System.Windows.Forms.Label();
            this.greenOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // storyOutput
            // 
            this.storyOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyOutput.Location = new System.Drawing.Point(9, 10);
            this.storyOutput.Name = "storyOutput";
            this.storyOutput.Size = new System.Drawing.Size(782, 98);
            this.storyOutput.TabIndex = 1;
            this.storyOutput.Text = "You wake up with a concussion, it seems you were knocked out during the evacuatio" +
    "ns and are the last one remaining onboard the ship";
            // 
            // promptOutput
            // 
            this.promptOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptOutput.Location = new System.Drawing.Point(9, 412);
            this.promptOutput.Name = "promptOutput";
            this.promptOutput.Size = new System.Drawing.Size(775, 65);
            this.promptOutput.TabIndex = 2;
            this.promptOutput.Text = "Do you want to attempt to leave the station in a shuttle or try to conduct repair" +
    "s?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChooseYourOwnAdventure.Properties.Resources.Blue_Button;
            this.pictureBox1.Location = new System.Drawing.Point(9, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainImage
            // 
            this.mainImage.Image = global::ChooseYourOwnAdventure.Properties.Resources.S0;
            this.mainImage.Location = new System.Drawing.Point(9, 91);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(783, 314);
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChooseYourOwnAdventure.Properties.Resources.Green_Button;
            this.pictureBox2.Location = new System.Drawing.Point(9, 574);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChooseYourOwnAdventure.Properties.Resources.Red_Button;
            this.pictureBox3.Location = new System.Drawing.Point(9, 527);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // blueOutput
            // 
            this.blueOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueOutput.Location = new System.Drawing.Point(57, 480);
            this.blueOutput.Name = "blueOutput";
            this.blueOutput.Size = new System.Drawing.Size(735, 41);
            this.blueOutput.TabIndex = 6;
            this.blueOutput.Text = "Repair";
            // 
            // redOutput
            // 
            this.redOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redOutput.Location = new System.Drawing.Point(57, 527);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(735, 41);
            this.redOutput.TabIndex = 7;
            this.redOutput.Text = "Escape";
            // 
            // greenOutput
            // 
            this.greenOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenOutput.Location = new System.Drawing.Point(57, 574);
            this.greenOutput.Name = "greenOutput";
            this.greenOutput.Size = new System.Drawing.Size(735, 41);
            this.greenOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.greenOutput);
            this.Controls.Add(this.redOutput);
            this.Controls.Add(this.blueOutput);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.promptOutput);
            this.Controls.Add(this.storyOutput);
            this.Controls.Add(this.mainImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Screaming Firehawk";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.Label storyOutput;
        private System.Windows.Forms.Label promptOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label blueOutput;
        private System.Windows.Forms.Label redOutput;
        private System.Windows.Forms.Label greenOutput;
    }
}

