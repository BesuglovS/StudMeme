namespace lawstud
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BottomTextLabel = new System.Windows.Forms.Label();
            this.BottomTextBox = new System.Windows.Forms.TextBox();
            this.TopTextLabel = new System.Windows.Forms.Label();
            this.UpperTextBox = new System.Windows.Forms.TextBox();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.LawStPicture = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ControlsPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LawStPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.SaveButton);
            this.ControlsPanel.Controls.Add(this.BottomTextLabel);
            this.ControlsPanel.Controls.Add(this.BottomTextBox);
            this.ControlsPanel.Controls.Add(this.TopTextLabel);
            this.ControlsPanel.Controls.Add(this.UpperTextBox);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(656, 100);
            this.ControlsPanel.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(410, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(234, 56);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // BottomTextLabel
            // 
            this.BottomTextLabel.AutoSize = true;
            this.BottomTextLabel.Location = new System.Drawing.Point(12, 51);
            this.BottomTextLabel.Name = "BottomTextLabel";
            this.BottomTextLabel.Size = new System.Drawing.Size(69, 13);
            this.BottomTextLabel.TabIndex = 3;
            this.BottomTextLabel.Text = "Текст снизу";
            // 
            // BottomTextBox
            // 
            this.BottomTextBox.Location = new System.Drawing.Point(92, 48);
            this.BottomTextBox.MaxLength = 50;
            this.BottomTextBox.Name = "BottomTextBox";
            this.BottomTextBox.Size = new System.Drawing.Size(312, 20);
            this.BottomTextBox.TabIndex = 2;
            this.BottomTextBox.TextChanged += new System.EventHandler(this.BottomTextBoxTextChanged);
            // 
            // TopTextLabel
            // 
            this.TopTextLabel.AutoSize = true;
            this.TopTextLabel.Location = new System.Drawing.Point(12, 15);
            this.TopTextLabel.Name = "TopTextLabel";
            this.TopTextLabel.Size = new System.Drawing.Size(74, 13);
            this.TopTextLabel.TabIndex = 1;
            this.TopTextLabel.Text = "Текст сверху";
            // 
            // UpperTextBox
            // 
            this.UpperTextBox.Location = new System.Drawing.Point(92, 12);
            this.UpperTextBox.MaxLength = 50;
            this.UpperTextBox.Name = "UpperTextBox";
            this.UpperTextBox.Size = new System.Drawing.Size(312, 20);
            this.UpperTextBox.TabIndex = 0;
            this.UpperTextBox.TextChanged += new System.EventHandler(this.UpperTextBoxTextChanged);
            // 
            // PicturePanel
            // 
            this.PicturePanel.Controls.Add(this.LawStPicture);
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicturePanel.Location = new System.Drawing.Point(0, 100);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(656, 606);
            this.PicturePanel.TabIndex = 1;
            // 
            // LawStPicture
            // 
            this.LawStPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LawStPicture.Location = new System.Drawing.Point(0, 0);
            this.LawStPicture.Name = "LawStPicture";
            this.LawStPicture.Size = new System.Drawing.Size(656, 606);
            this.LawStPicture.TabIndex = 0;
            this.LawStPicture.TabStop = false;
            this.LawStPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.LawStPicturePaint);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "jpg";
            this.saveFileDialog.Filter = "Файлы jpg|*.jpg";
            this.saveFileDialog.Title = "Сохранить мем :-)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 706);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.ControlsPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "СТУДЕНТ-МЕМ";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LawStPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.PictureBox LawStPicture;
        private System.Windows.Forms.Label BottomTextLabel;
        private System.Windows.Forms.TextBox BottomTextBox;
        private System.Windows.Forms.Label TopTextLabel;
        private System.Windows.Forms.TextBox UpperTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

