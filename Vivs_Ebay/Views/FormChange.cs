using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivs_Ebay.Entities;
using Vivs_Ebay.Repository;

namespace Vivs_Ebay.Views
{
    public partial class FormChange : Form
    {
        private bool isGuest;
        private string username;
        public FormChange(bool isGuest, string username)
        {
            InitializeComponent();
            this.isGuest = isGuest;
            this.username = username;

            LoadCategories();

            // Load listings for the specific user if they are not a guest
            if (!isGuest)
            {
                LoadUserListings(username);
            }
        }
        private void LoadUserListings(string username)
        {

            ListingsRepo repo = new ListingsRepo();


            List<Listings> userListings = repo.GetListingsByUser(username);

            // Bind the listings to the list box
            listBoxUserListings.DisplayMember = "Title"; // or any property you want to display
            listBoxUserListings.ValueMember = "ID"; // assuming each listing has an ID
            listBoxUserListings.DataSource = userListings;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            

            string title = textBoxTitle.Text;
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            string description = textBoxListingDescription.Text;

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            decimal price;


            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price of 0 or more.");
                return;
            }



            int categoryId = (int)comboBoxCategory.SelectedValue;

            DataContext context = new DataContext();

            int userId = context.GetUserIdByUsername(username);

            Listings newListing = new Listings
            {
                Title = title,
                Description = description,
                Price = price,
                Category = new Categories { Id = categoryId },
                UserID = userId,
                DateCreated = DateTime.Now
            };

            ListingsRepo repo = new ListingsRepo();
            repo.AddListing(newListing);


            MessageBox.Show("Listing created successfully!");

            LoadUserListings(username); 
            ClearTextBoxes();


        }

        private void listBoxUserListings_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxUserListings.SelectedItem is Listings selectedListing)
            {
                textBoxTitle.Text = selectedListing.Title;
                textBoxPrice.Text = selectedListing.Price.ToString();
                textBoxListingDescription.Text = selectedListing.Description;
                comboBoxCategory.SelectedValue = selectedListing.Category.Id; 
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxUserListings.SelectedItem is Listings selectedListing)
            {
                // confirmation message text
                string listingDetails = $"Title: {selectedListing.Title}\n" +
                                        $"Price: {selectedListing.Price} SEK\n" +
                                        $"Description: {selectedListing.Description}\n" +
                                        $"Category: {selectedListing.Category.CategoryName}\n\n" +
                                        "Are you sure you want to delete this listing?";

                DialogResult result = MessageBox.Show(listingDetails, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Proceed with deletion if the user clicks OK
                if (result == DialogResult.OK)
                {
                    ListingsRepo repo = new ListingsRepo();

                    // Pass the listing ID to delete the listing
                    repo.DeleteListing(selectedListing.Id); 
                    MessageBox.Show("Listing deleted successfully!");


                    LoadUserListings(username);

                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select a listing to delete.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxUserListings.SelectedItem is Listings selectedListing)
            {
                // Collect new values from the text boxes


                string newTitle = textBoxTitle.Text;
                if (string.IsNullOrEmpty(newTitle))
                {
                    MessageBox.Show("Please enter a title.");
                    return;
                }

                string newDescription = textBoxListingDescription.Text;

                if (string.IsNullOrEmpty(newDescription))
                {
                    MessageBox.Show("Please enter a description.");
                    return;
                }

                decimal newPrice;

                // Validate the price input
                if (!decimal.TryParse(textBoxPrice.Text, out newPrice) || newPrice < 0)
                {
                    MessageBox.Show("Please enter a valid price of 0 or more.");
                    return;
                }

                int newCategoryId = (int)comboBoxCategory.SelectedValue;

                // Prepare the confirmation message with old and new values
                string confirmationMessage = $"Current Details:\n" +
                                             $"Title: {selectedListing.Title}\n" +
                                             $"Price: {selectedListing.Price} SEK\n" +
                                             $"Description: {selectedListing.Description}\n" +
                                             $"Category: {selectedListing.Category.CategoryName}\n\n" +
                                             $"New Details:\n" +
                                             $"Title: {newTitle}\n" +
                                             $"Price: {newPrice} SEK\n" +
                                             $"Description: {newDescription}\n" +
                                             $"Category: {comboBoxCategory.Text}\n\n" +
                                             "Do you want to update this listing?";

                
                DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Update", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Update selectedListing object with new values
                    selectedListing.Title = newTitle;
                    selectedListing.Description = newDescription;
                    selectedListing.Price = newPrice;
                    selectedListing.Category = new Categories
                    { Id = newCategoryId, CategoryName = comboBoxCategory.Text };

                    // Call the update method with the updated Listings object
                    ListingsRepo repo = new ListingsRepo();
                    repo.UpdateListing(selectedListing);

                    LoadUserListings(username);
                    ClearTextBoxes();

                    MessageBox.Show("Listing updated successfully!");


                }
                else
                {
                    MessageBox.Show("Please select a listing to update.");
                }
            }

        }

        private void ClearTextBoxes()
        {
            textBoxTitle.Clear();
            textBoxPrice.Clear();
            textBoxListingDescription.Clear();
        }

        private void buttonBackToSearch_Click(object sender, EventArgs e)
        {

            FormSearch formSearch = new FormSearch(isGuest, username);
            formSearch.Show();
            this.Hide();
        }
    }
}
