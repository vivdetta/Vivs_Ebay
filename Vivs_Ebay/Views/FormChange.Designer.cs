namespace Vivs_Ebay.Views
{
    partial class FormChange
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
            listBoxUserListings = new ListBox();
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelPrice = new Label();
            labelListingDescription = new Label();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            textBoxPrice = new TextBox();
            textBoxListingDescription = new TextBox();
            labelUserListings = new Label();
            labelAddOrChange = new Label();
            buttonCreate = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonBackToSearch = new Button();
            SuspendLayout();
            // 
            // listBoxUserListings
            // 
            listBoxUserListings.FormattingEnabled = true;
            listBoxUserListings.ItemHeight = 25;
            listBoxUserListings.Location = new Point(46, 93);
            listBoxUserListings.Name = "listBoxUserListings";
            listBoxUserListings.Size = new Size(452, 429);
            listBoxUserListings.TabIndex = 0;
            listBoxUserListings.MouseClick += listBoxUserListings_MouseClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(574, 93);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(44, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(574, 121);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(314, 31);
            textBoxTitle.TabIndex = 2;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(574, 175);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(238, 25);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price (in SEK - numbers only)";
            // 
            // labelListingDescription
            // 
            labelListingDescription.AutoSize = true;
            labelListingDescription.Location = new Point(574, 258);
            labelListingDescription.Name = "labelListingDescription";
            labelListingDescription.Size = new Size(217, 25);
            labelListingDescription.TabIndex = 4;
            labelListingDescription.Text = "Description of your listing";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(574, 489);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(314, 33);
            comboBoxCategory.TabIndex = 5;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(574, 461);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(84, 25);
            labelCategory.TabIndex = 6;
            labelCategory.Text = "Category";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(574, 203);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(314, 31);
            textBoxPrice.TabIndex = 7;
            // 
            // textBoxListingDescription
            // 
            textBoxListingDescription.Location = new Point(574, 286);
            textBoxListingDescription.Multiline = true;
            textBoxListingDescription.Name = "textBoxListingDescription";
            textBoxListingDescription.Size = new Size(314, 159);
            textBoxListingDescription.TabIndex = 8;
            // 
            // labelUserListings
            // 
            labelUserListings.AutoSize = true;
            labelUserListings.Location = new Point(46, 55);
            labelUserListings.Name = "labelUserListings";
            labelUserListings.Size = new Size(116, 25);
            labelUserListings.TabIndex = 9;
            labelUserListings.Text = "Your Listings!";
            // 
            // labelAddOrChange
            // 
            labelAddOrChange.AutoSize = true;
            labelAddOrChange.Location = new Point(576, 56);
            labelAddOrChange.Name = "labelAddOrChange";
            labelAddOrChange.Size = new Size(231, 25);
            labelAddOrChange.TabIndex = 10;
            labelAddOrChange.Text = "Add or Change your listing!";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(713, 561);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(175, 55);
            buttonCreate.TabIndex = 11;
            buttonCreate.Text = "Create New Listing";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(495, 561);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(163, 55);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete Listing";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(283, 561);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(151, 55);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update Listing";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonBackToSearch
            // 
            buttonBackToSearch.Location = new Point(63, 564);
            buttonBackToSearch.Name = "buttonBackToSearch";
            buttonBackToSearch.Size = new Size(174, 52);
            buttonBackToSearch.TabIndex = 14;
            buttonBackToSearch.Text = "Back to Search";
            buttonBackToSearch.UseVisualStyleBackColor = true;
            buttonBackToSearch.Click += buttonBackToSearch_Click;
            // 
            // FormChange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(968, 655);
            Controls.Add(buttonBackToSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(labelAddOrChange);
            Controls.Add(labelUserListings);
            Controls.Add(textBoxListingDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(labelCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelListingDescription);
            Controls.Add(labelPrice);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Controls.Add(listBoxUserListings);
            Name = "FormChange";
            Text = "FormChange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxUserListings;
        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelPrice;
        private Label labelListingDescription;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private TextBox textBoxPrice;
        private TextBox textBoxListingDescription;
        private Label labelUserListings;
        private Label labelAddOrChange;
        private Button buttonCreate;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonBackToSearch;
    }
}