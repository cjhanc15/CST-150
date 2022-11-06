namespace Activity1
{
    partial class Questionaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionaire));
            this.submitButton = new System.Windows.Forms.Button();
            this.submitLabel = new System.Windows.Forms.Label();
            this.favoriteColorsCheckList = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.randomImage = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.randomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(564, 773);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(428, 119);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitLabel
            // 
            this.submitLabel.AutoSize = true;
            this.submitLabel.Location = new System.Drawing.Point(626, 895);
            this.submitLabel.Name = "submitLabel";
            this.submitLabel.Size = new System.Drawing.Size(148, 32);
            this.submitLabel.TabIndex = 1;
            this.submitLabel.Text = "Submit form";
            this.submitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // favoriteColorsCheckList
            // 
            this.favoriteColorsCheckList.FormattingEnabled = true;
            this.favoriteColorsCheckList.Items.AddRange(new object[] {
            "Pink",
            "Purple",
            "Blue",
            "Green",
            "Yellow",
            "Red"});
            this.favoriteColorsCheckList.Location = new System.Drawing.Point(564, 191);
            this.favoriteColorsCheckList.Name = "favoriteColorsCheckList";
            this.favoriteColorsCheckList.Size = new System.Drawing.Size(428, 184);
            this.favoriteColorsCheckList.TabIndex = 2;
            this.favoriteColorsCheckList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(564, 696);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(428, 39);
            this.dateTimePicker.TabIndex = 3;
            // 
            // randomImage
            // 
            this.randomImage.Image = ((System.Drawing.Image)(resources.GetObject("randomImage.Image")));
            this.randomImage.Location = new System.Drawing.Point(564, 426);
            this.randomImage.Name = "randomImage";
            this.randomImage.Size = new System.Drawing.Size(428, 212);
            this.randomImage.TabIndex = 4;
            this.randomImage.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(564, 103);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(428, 39);
            this.textBox.TabIndex = 5;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Questionaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 1003);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.randomImage);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.favoriteColorsCheckList);
            this.Controls.Add(this.submitLabel);
            this.Controls.Add(this.submitButton);
            this.Name = "Questionaire";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.randomImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitButton;
        private Label submitLabel;
        private CheckedListBox favoriteColorsCheckList;
        private DateTimePicker dateTimePicker;
        private PictureBox randomImage;
        private TextBox textBox;
    }
}