
namespace AdventureGame
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.LightGray;
            this.outputLabel.Location = new System.Drawing.Point(12, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(954, 94);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "ahhhhhhhhh";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.LightGray;
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.option1Button.ForeColor = System.Drawing.Color.Black;
            this.option1Button.Location = new System.Drawing.Point(71, 400);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(250, 50);
            this.option1Button.TabIndex = 2;
            this.option1Button.Text = "option1Button";
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.LightGray;
            this.option3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.option3Button.ForeColor = System.Drawing.Color.Black;
            this.option3Button.Location = new System.Drawing.Point(367, 500);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(250, 50);
            this.option3Button.TabIndex = 3;
            this.option3Button.Text = "option3Button";
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.LightGray;
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.option2Button.ForeColor = System.Drawing.Color.Black;
            this.option2Button.Location = new System.Drawing.Point(653, 400);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(250, 50);
            this.option2Button.TabIndex = 4;
            this.option2Button.Text = "option2Button";
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.Transparent;
            this.imageBox.ForeColor = System.Drawing.Color.Transparent;
            this.imageBox.Location = new System.Drawing.Point(12, 95);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(955, 275);
            this.imageBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Adventure Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label imageBox;
    }
}

