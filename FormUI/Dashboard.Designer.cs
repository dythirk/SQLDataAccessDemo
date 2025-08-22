namespace FormUI
{
    partial class Dashboard
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
            peopleFoundListbox = new ListBox();
            lastNameText = new TextBox();
            lastNameLabel = new Label();
            searchButton = new Button();
            SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            peopleFoundListbox.FormattingEnabled = true;
            peopleFoundListbox.ItemHeight = 37;
            peopleFoundListbox.Location = new Point(109, 218);
            peopleFoundListbox.Name = "peopleFoundListbox";
            peopleFoundListbox.Size = new Size(526, 263);
            peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(431, 65);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(204, 43);
            lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(109, 65);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(147, 38);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(271, 168);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(184, 44);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 832);
            Controls.Add(searchButton);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameText);
            Controls.Add(peopleFoundListbox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "SQL Data Access Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox peopleFoundListbox;
        private TextBox lastNameText;
        private Label lastNameLabel;
        private Button searchButton;
    }
}
