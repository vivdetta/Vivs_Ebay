namespace Vivs_Ebay.Views
{
    partial class FormSearch
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
            listBoxResult = new ListBox();
            labelSearchItem = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonAddChange = new Button();
            buttonBackToLogin = new Button();
            labelSearchResult = new Label();
            comboBoxCategory = new ComboBox();
            buttonCategorySearch = new Button();
            checkBoxIncludeCategory = new CheckBox();
            SuspendLayout();
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 25;
            listBoxResult.Location = new Point(71, 72);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(451, 429);
            listBoxResult.TabIndex = 0;
            listBoxResult.MouseClick += listBoxResult_MouseClick;
            // 
            // labelSearchItem
            // 
            labelSearchItem.AutoSize = true;
            labelSearchItem.Location = new Point(561, 44);
            labelSearchItem.Name = "labelSearchItem";
            labelSearchItem.Size = new Size(161, 25);
            labelSearchItem.TabIndex = 1;
            labelSearchItem.Text = "Search for an item!";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(561, 116);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(336, 31);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(937, 116);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(164, 31);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Title Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAddChange
            // 
            buttonAddChange.Location = new Point(595, 289);
            buttonAddChange.Name = "buttonAddChange";
            buttonAddChange.Size = new Size(246, 65);
            buttonAddChange.TabIndex = 4;
            buttonAddChange.Text = "Add or Change a listing";
            buttonAddChange.UseVisualStyleBackColor = true;
            buttonAddChange.Click += buttonAddChange_Click;
            // 
            // buttonBackToLogin
            // 
            buttonBackToLogin.Location = new Point(872, 289);
            buttonBackToLogin.Name = "buttonBackToLogin";
            buttonBackToLogin.Size = new Size(210, 65);
            buttonBackToLogin.TabIndex = 7;
            buttonBackToLogin.Text = "Back to Login Screen";
            buttonBackToLogin.UseVisualStyleBackColor = true;
            buttonBackToLogin.Click += buttonBackToLogin_Click;
            // 
            // labelSearchResult
            // 
            labelSearchResult.AutoSize = true;
            labelSearchResult.Location = new Point(71, 44);
            labelSearchResult.Name = "labelSearchResult";
            labelSearchResult.Size = new Size(116, 25);
            labelSearchResult.TabIndex = 8;
            labelSearchResult.Text = "Search Result";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(561, 190);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(339, 33);
            comboBoxCategory.TabIndex = 9;
            // 
            // buttonCategorySearch
            // 
            buttonCategorySearch.Location = new Point(937, 190);
            buttonCategorySearch.Name = "buttonCategorySearch";
            buttonCategorySearch.Size = new Size(164, 33);
            buttonCategorySearch.TabIndex = 10;
            buttonCategorySearch.Text = "Category Search";
            buttonCategorySearch.UseVisualStyleBackColor = true;
            buttonCategorySearch.Click += buttonCategorySearch_Click;
            // 
            // checkBoxIncludeCategory
            // 
            checkBoxIncludeCategory.AutoSize = true;
            checkBoxIncludeCategory.Location = new Point(561, 79);
            checkBoxIncludeCategory.Name = "checkBoxIncludeCategory";
            checkBoxIncludeCategory.Size = new Size(285, 29);
            checkBoxIncludeCategory.TabIndex = 11;
            checkBoxIncludeCategory.Text = "Include Category in Title Search";
            checkBoxIncludeCategory.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1132, 606);
            Controls.Add(checkBoxIncludeCategory);
            Controls.Add(buttonCategorySearch);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelSearchResult);
            Controls.Add(buttonBackToLogin);
            Controls.Add(buttonAddChange);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearchItem);
            Controls.Add(listBoxResult);
            Name = "FormSearch";
            Text = "FormSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxResult;
        private Label labelSearchItem;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonAddChange;
        private Button buttonBackToLogin;
        private Label labelSearchResult;
        private ComboBox comboBoxCategory;
        private Button buttonCategorySearch;
        private CheckBox checkBoxIncludeCategory;
    }
}