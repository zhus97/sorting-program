using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{





    public partial class Form1 : Form
    {
        static string[] headers = new string[6]; //column headers

        const int MAX_LINES_FILE = 50000;
        string[] AllLines = new string[MAX_LINES_FILE];
        string[] columns;
        AVLTree<Company> companies = new AVLTree<Company>();
        Company company;
        LinkedList<string> Buyers;









        public Form1()
        {
            InitializeComponent();
        }










        private void Form1_Load(object sender, EventArgs e)
        {
            companyNamesListBox.SelectedIndexChanged += companyNamesListBox_SelectedIndexChanged_1;

        }











        private void loadFileButton_Click(object sender, EventArgs e)
        {
            

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    AllLines = File.ReadAllLines(ofd.FileName);
                    foreach (string line in AllLines)
                    {
                        if (line.StartsWith("Company")) //found first line - headers
                        {
                            headers = line.Split(',');
                        }

                        else
                        {
                            //split data using commas
                            columns = line.Split(',');

                            // read the full set of buyers
                            Buyers = new LinkedList<string>();
                            string[] buyers = columns[5].Split(';', '[', ']');

                            foreach (string partner in buyers)
                            {
                                if (partner != "")
                                {

                                    Buyers.AddLast(partner);

                                }


                            }

                            company = new Company(columns[0], int.Parse(columns[1]), int.Parse(columns[2]), int.Parse(columns[3]), int.Parse(columns[4]), Buyers);

                          
                            //Insert companies in AVL tree
                            companies.InsertItem(company);
                          

                            //Insert names of companies into list box
                            companyNamesListBox.Items.Add(company);

                            //Sort names alphabetically
                            companyNamesListBox.Sorted = true;

                            

                        }

                    }
                }
            }
               
            

            

          
            //Display height of tree
            heightTextBox.Text = companies.Height().ToString();

            //Display number of companies
            numCompaniesTextBox.Text = companies.Count().ToString();


        }

 










        private void companyNamesListBox_SelectedIndexChanged_1 (object sender, EventArgs e)
        {
            Company curCompany = (Company) companyNamesListBox.SelectedItem;
            
            //When user clicks on item in listbox, display details of specific item in their corresponding text boxes
            if (curCompany != null)
            {
                companyNameTextBox.Text = curCompany.name;
                companyNetIncomeTextBox.Text = curCompany.netIncome.ToString();
                CompanyOperatingIncomeTextBox.Text = curCompany.operatingIncome.ToString();
                companyTotalAssetsTextBox.Text = curCompany.totalAssets.ToString();
                companyNumEmployeesTextBox.Text = curCompany.numEmployees.ToString();

                string displayBuyers = "";
                int count = 0;


                //foreach loop to display LinkedList in correct format
                foreach (string b in curCompany.buyers)
                {

                    if(count == 0)
                    {
                        displayBuyers += "[";
                        
                    }

                    else if (count < curCompany.buyers.Count)

                    {
                        displayBuyers += ";";
                    }

                    displayBuyers += b ;

                    if (count == curCompany.buyers.Count - 1)
                    {
                        displayBuyers += "]";
                    }

                    count++;

                    
                }



                companyBuyersTextBox.Text = displayBuyers.ToString();
                
            }








        }









        private void removeButton_Click(object sender, EventArgs e)
        {
            Company curCompany = (Company)companyNamesListBox.SelectedItem;
            

            if (companyNamesListBox.SelectedIndex != -1)
            {
                //Remove company from avl tree
                companies.RemoveItem(curCompany);

                //Remove name of company from listbox
                companyNamesListBox.Items.RemoveAt(companyNamesListBox.SelectedIndex);

                //Set object details' text boxes to null after deleting it
                companyNameTextBox.Text = null;
                companyNetIncomeTextBox.Text = null;
                CompanyOperatingIncomeTextBox.Text = null;
                companyTotalAssetsTextBox.Text = null;
                companyNumEmployeesTextBox.Text = null;
                companyBuyersTextBox.Text = null;

                //Update height and number of companies
                heightTextBox.Text = companies.Height().ToString();
                numCompaniesTextBox.Text = companies.Count().ToString();

                //Inform user that they have successfully removed company
                MessageBox.Show("Company " + curCompany.name + " removed!");

            }

            


        }

       









        private void editButton_Click(object sender, EventArgs e)
        {
            Company curCompany = (Company)companyNamesListBox.SelectedItem;

            //remove the selected company from the tree
            companies.RemoveItem(curCompany);

            LinkedList<string> newBuyers = new LinkedList<string>();
            string[] buyers = companyBuyersTextBox.Text.Split(';', '[', ']');

            foreach (string partner in buyers)
            {
                if (partner != "")
                {

                    newBuyers.AddLast(partner);

                }


            }

            //Parse the new details and insert them into the avl tree
            Company newCompany = new Company(companyNameTextBox.Text, int.Parse(companyNetIncomeTextBox.Text), int.Parse(CompanyOperatingIncomeTextBox.Text), int.Parse(companyTotalAssetsTextBox.Text), int.Parse(companyNumEmployeesTextBox.Text), newBuyers);
            companies.InsertItem(newCompany);

            //remove the current company selected from the listbox
            companyNamesListBox.Items.Remove(curCompany);

            //add the new company to the listbox
            companyNamesListBox.Items.Add(newCompany);

            //Set object details' text boxes to null after deleting it
            companyNameTextBox.Text = null;
            companyNetIncomeTextBox.Text = null;
            CompanyOperatingIncomeTextBox.Text = null;
            companyTotalAssetsTextBox.Text = null;
            companyNumEmployeesTextBox.Text = null;
            companyBuyersTextBox.Text = null;

            //Let user know that they have edited a company
            MessageBox.Show("Company succesfully edited!");




        }






        //Code to find company by name
        private void searchCompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            //find value in listbox that matches search box text
            foreach(Company c in companyNamesListBox.Items)
            {
                if(c.name.Contains(searchCompanyTextBox.Text))
                {
                    filteredListBox.Items.Add(c);
                }
            }

            filteredListBox.Items.Clear();

            foreach (Company c in companyNamesListBox.Items)
            {
                if(c.name.StartsWith(searchCompanyTextBox.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    filteredListBox.Items.Add(c);
                    
                }
 
            }

            if (searchCompanyTextBox.Text == "")
            {
                filteredListBox.Items.Clear();
            }


        }

        private void filteredListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Company curCompany = (Company)filteredListBox.SelectedItem;

            //When user clicks on item in listbox, display details of specific item in their corresponding text boxes
            if (curCompany != null)
            {
                companyNameTextBox.Text = curCompany.name;
                companyNetIncomeTextBox.Text = curCompany.netIncome.ToString();
                CompanyOperatingIncomeTextBox.Text = curCompany.operatingIncome.ToString();
                companyTotalAssetsTextBox.Text = curCompany.totalAssets.ToString();
                companyNumEmployeesTextBox.Text = curCompany.numEmployees.ToString();

                string displayBuyers = "";
                int count = 0;


                //foreach loop to display LinkedList in correct format
                foreach (string b in curCompany.buyers)
                {

                    if (count == 0)
                    {
                        displayBuyers += "[";

                    }

                    else if (count < curCompany.buyers.Count)

                    {
                        displayBuyers += ";";
                    }

                    displayBuyers += b;

                    if (count == curCompany.buyers.Count - 1)
                    {
                        displayBuyers += "]";
                    }

                    count++;


                }



                companyBuyersTextBox.Text = displayBuyers.ToString();

            }
        }
    }

}