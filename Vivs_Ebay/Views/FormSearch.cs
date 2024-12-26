using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivs_Ebay.Entities;
using Vivs_Ebay.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vivs_Ebay.Views
{
    public partial class FormSearch : Form
    {
        private string username;
        private bool isGuest;

        public FormSearch(bool isGuest, string username)
        {
            InitializeComponent();

            this.isGuest = isGuest;
            this.username = username;

            LoadCategories();

            
            if (isGuest)
            {
                // Hide change button for guests
                buttonAddChange.Visible = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ListingsRepo repo = new ListingsRepo();

            // Set the DisplayMember to show the Listings name in the ListBox
            listBoxResult.DisplayMember = "Title";
            listBoxResult.ValueMember = "ID";

            string searchText = textBoxSearch.Text;

            // Check if the category checkbox is selected to include category in search
            if (checkBoxIncludeCategory.Checked && comboBoxCategory.SelectedItem != null)
            {
                // Search by both title and category
                int selectedCategoryId = (int)comboBoxCategory.SelectedValue;
                listBoxResult.DataSource = repo.SearchListingsByCategoryAndTitle(selectedCategoryId, searchText);
            }
            else
            {
                // Search by title only
                listBoxResult.DataSource = repo.SearchListingsByTitle(searchText);
            }

        }

        private void LoadCategories()
        {
            ListingsRepo repo = new ListingsRepo();
            List<Categories> categories = repo.GetAllCategories();

            comboBoxCategory.DisplayMember = "CategoryName"; 
            comboBoxCategory.ValueMember = "Id"; 
            comboBoxCategory.DataSource = categories;
        }

        private void listBoxResult_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxResult.SelectedItem is Listings selectedListing)
            {
                string details = $"Title: {selectedListing.Title}\n" +
                                 $"Category: {selectedListing.Category.CategoryName}\n" +
                                 $"Description: {selectedListing.Description}\n" +
                                 $"Price: {selectedListing.Price} SEK\n" +
                                 $"Date Created: {selectedListing.DateCreated}";
                MessageBox.Show(details, "Listing Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCategorySearch_Click(object sender, EventArgs e)
        {

            ListingsRepo repo = new ListingsRepo();

            // Set the DisplayMember to show the Listings name in the ListBox
            listBoxResult.DisplayMember = "Title";
            listBoxResult.ValueMember = "ID";

            // Check if a category is selected in the ComboBox
            if (comboBoxCategory.SelectedItem != null)
            {
                int selectedCategoryId = (int)comboBoxCategory.SelectedValue;

                // Retrieve listings by the selected category and assign to the ListBox
                listBoxResult.DataSource = repo.SearchListingsByCategory(selectedCategoryId);
            }
            else
            {
                MessageBox.Show("Please choose a category and try again.");
            }
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void buttonAddChange_Click(object sender, EventArgs e)
        {
            FormChange formChange = new FormChange(isGuest, username);
            formChange.Show();
            this.Hide();
        }
    }
}
