
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
            this.blueOutput = new System.Windows.Forms.Label();
            this.redOutput = new System.Windows.Forms.Label();
            this.greenOutput = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.PictureBox();
            this.greenButton = new System.Windows.Forms.PictureBox();
            this.blueButton = new System.Windows.Forms.PictureBox();
            this.mainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // storyOutput
            // 
            this.storyOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyOutput.Location = new System.Drawing.Point(9, 10);
            this.storyOutput.Name = "storyOutput";
            this.storyOutput.Size = new System.Drawing.Size(782, 98);
            this.storyOutput.TabIndex = 1;
            this.storyOutput.Text = resources.GetString("storyOutput.Text");
            // 
            // promptOutput
            // 
            this.promptOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptOutput.Location = new System.Drawing.Point(9, 412);
            this.promptOutput.Name = "promptOutput";
            this.promptOutput.Size = new System.Drawing.Size(775, 65);
            this.promptOutput.TabIndex = 2;
            this.promptOutput.Text = "Do you want to attempt to leave the ship in a shuttle? Or, try to conduct repairs" +
    "?";
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
            this.redOutput.Text = "Escape (risky)";
            // 
            // greenOutput
            // 
            this.greenOutput.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenOutput.Location = new System.Drawing.Point(57, 574);
            this.greenOutput.Name = "greenOutput";
            this.greenOutput.Size = new System.Drawing.Size(735, 41);
            this.greenOutput.TabIndex = 8;
            // 
            // redButton
            // 
            this.redButton.Image = global::ChooseYourOwnAdventure.Properties.Resources.Red_Button;
            this.redButton.Location = new System.Drawing.Point(9, 527);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(42, 41);
            this.redButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redButton.TabIndex = 5;
            this.redButton.TabStop = false;
            // 
            // greenButton
            // 
            this.greenButton.Image = global::ChooseYourOwnAdventure.Properties.Resources.Green_Button;
            this.greenButton.Location = new System.Drawing.Point(9, 574);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(42, 41);
            this.greenButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenButton.TabIndex = 4;
            this.greenButton.TabStop = false;
            this.greenButton.Visible = false;
            // 
            // blueButton
            // 
            this.blueButton.Image = global::ChooseYourOwnAdventure.Properties.Resources.Blue_Button;
            this.blueButton.Location = new System.Drawing.Point(9, 480);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(42, 41);
            this.blueButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueButton.TabIndex = 3;
            this.blueButton.TabStop = false;
            // 
            // mainImage
            // 
            this.mainImage.Image = global::ChooseYourOwnAdventure.Properties.Resources.S0;
            this.mainImage.Location = new System.Drawing.Point(126, 97);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(549, 291);
            this.mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.greenOutput);
            this.Controls.Add(this.redOutput);
            this.Controls.Add(this.blueOutput);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.promptOutput);
            this.Controls.Add(this.storyOutput);
            this.Controls.Add(this.mainImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Screaming Firehawk";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.Label storyOutput;
        private System.Windows.Forms.Label promptOutput;
        private System.Windows.Forms.PictureBox blueButton;
        private System.Windows.Forms.PictureBox greenButton;
        private System.Windows.Forms.PictureBox redButton;
        private System.Windows.Forms.Label blueOutput;
        private System.Windows.Forms.Label redOutput;
        private System.Windows.Forms.Label greenOutput;
    }
}

