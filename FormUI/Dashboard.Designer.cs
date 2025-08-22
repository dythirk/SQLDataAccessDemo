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
            firstNameInsLabel = new Label();
            firstNameInsText = new TextBox();
            lastNameInsLabel = new Label();
            lastNameInsText = new TextBox();
            emailAddressInsLabel = new Label();
            emailAddressInsText = new TextBox();
            phoneNumberInsLabel = new Label();
            phoneNumberInsText = new TextBox();
            insertRecordButton = new Button();
            SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            peopleFoundListbox.FormattingEnabled = true;
            peopleFoundListbox.ItemHeight = 37;
            peopleFoundListbox.Location = new Point(109, 150);
            peopleFoundListbox.Name = "peopleFoundListbox";
            peopleFoundListbox.Size = new Size(526, 263);
            peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(431, 23);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(204, 43);
            lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(109, 23);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(147, 38);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(269, 83);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(184, 44);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // firstNameInsLabel
            // 
            firstNameInsLabel.AutoSize = true;
            firstNameInsLabel.Location = new Point(105, 441);
            firstNameInsLabel.Name = "firstNameInsLabel";
            firstNameInsLabel.Size = new Size(151, 38);
            firstNameInsLabel.TabIndex = 5;
            firstNameInsLabel.Text = "First Name";
            // 
            // firstNameInsText
            // 
            firstNameInsText.Location = new Point(427, 441);
            firstNameInsText.Name = "firstNameInsText";
            firstNameInsText.Size = new Size(204, 43);
            firstNameInsText.TabIndex = 4;
            // 
            // lastNameInsLabel
            // 
            lastNameInsLabel.AutoSize = true;
            lastNameInsLabel.Location = new Point(105, 499);
            lastNameInsLabel.Name = "lastNameInsLabel";
            lastNameInsLabel.Size = new Size(147, 38);
            lastNameInsLabel.TabIndex = 7;
            lastNameInsLabel.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            lastNameInsText.Location = new Point(427, 499);
            lastNameInsText.Name = "lastNameInsText";
            lastNameInsText.Size = new Size(204, 43);
            lastNameInsText.TabIndex = 6;
            // 
            // emailAddressInsLabel
            // 
            emailAddressInsLabel.AutoSize = true;
            emailAddressInsLabel.Location = new Point(105, 557);
            emailAddressInsLabel.Name = "emailAddressInsLabel";
            emailAddressInsLabel.Size = new Size(190, 38);
            emailAddressInsLabel.TabIndex = 9;
            emailAddressInsLabel.Text = "Email Address";
            emailAddressInsLabel.Click += emailAddressInsLabel_Click;
            // 
            // emailAddressInsText
            // 
            emailAddressInsText.Location = new Point(427, 557);
            emailAddressInsText.Name = "emailAddressInsText";
            emailAddressInsText.Size = new Size(204, 43);
            emailAddressInsText.TabIndex = 8;
            // 
            // phoneNumberInsLabel
            // 
            phoneNumberInsLabel.AutoSize = true;
            phoneNumberInsLabel.Location = new Point(105, 619);
            phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            phoneNumberInsLabel.Size = new Size(206, 38);
            phoneNumberInsLabel.TabIndex = 11;
            phoneNumberInsLabel.Text = "Phone Number";
            // 
            // phoneNumberInsText
            // 
            phoneNumberInsText.Location = new Point(427, 619);
            phoneNumberInsText.Name = "phoneNumberInsText";
            phoneNumberInsText.Size = new Size(204, 43);
            phoneNumberInsText.TabIndex = 10;
            // 
            // insertRecordButton
            // 
            insertRecordButton.Location = new Point(269, 699);
            insertRecordButton.Name = "insertRecordButton";
            insertRecordButton.Size = new Size(184, 44);
            insertRecordButton.TabIndex = 12;
            insertRecordButton.Text = "Insert";
            insertRecordButton.UseVisualStyleBackColor = true;
            insertRecordButton.Click += insertRecordButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 832);
            Controls.Add(insertRecordButton);
            Controls.Add(phoneNumberInsLabel);
            Controls.Add(phoneNumberInsText);
            Controls.Add(emailAddressInsLabel);
            Controls.Add(emailAddressInsText);
            Controls.Add(lastNameInsLabel);
            Controls.Add(lastNameInsText);
            Controls.Add(firstNameInsLabel);
            Controls.Add(firstNameInsText);
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
        private Label firstNameInsLabel;
        private TextBox firstNameInsText;
        private Label lastNameInsLabel;
        private TextBox lastNameInsText;
        private Label emailAddressInsLabel;
        private TextBox emailAddressInsText;
        private Label phoneNumberInsLabel;
        private TextBox phoneNumberInsText;
        private Button insertRecordButton;
    }
}
