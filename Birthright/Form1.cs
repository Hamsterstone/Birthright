using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Birthright
{
    public partial class Form1 : Form
    {
        Database myDatabase = new Database();
        public Form1()
        {
            InitializeComponent();
            LoadDatabase();
            //ccbProvinceSecondaryTerrain.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ccb_ItemCheck);
            SetUpComboBoxes();
        }


        private void SetUpComboBoxes()
        {
            int count = 0;
            foreach (KeyValuePair<string, GameInfo.TerrainType> terrainDictionaryElement in GameInfo.Terrain)
            {
                string terrainName = terrainDictionaryElement.Value.TerrainName;
                CCBoxItem item = new CCBoxItem(terrainName,count);
                cbxProvinceTerrain.Items.Add(terrainName);
                cbxTest.Items.Add(terrainName);
                ccbProvinceSecondaryTerrain.Items.Add(item);
                count++;

            }
            foreach (string holdingType in GameInfo.HoldingTypes)
            {
                cbxHoldingType.Items.Add(holdingType);
            }


            // If more then 5 items, add a scroll bar to the dropdown.
            ccbProvinceSecondaryTerrain.MaxDropDownItems = 5;
            // Make the "Name" property the one to display, rather than the ToString() representation.
            ccbProvinceSecondaryTerrain.DisplayMember = "Name";
            ccbProvinceSecondaryTerrain.ValueSeparator = ", ";
             
        }

        public void LoadDatabase()
        {
            dgvMain.DataSource = null;

            try
            {
                dgvMain.DataSource = myDatabase.FillDatatable("CombinedView");
                dgvMain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvRulers.DataSource = myDatabase.FillDatatable("Ruler");
                dgvRulers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvRealms.DataSource = myDatabase.FillDatatable("Realm");
                dgvRealms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvProvinces.DataSource = myDatabase.FillDatatable("Province");
                dgvProvinces.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvHoldings.DataSource = myDatabase.FillDatatable("Holding");
                dgvHoldings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView fakeDataGridView = sender as DataGridView;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                if (sender == dgvRulers)
                {

                    //if you are clicking on a row and not outside it
                    if (e.RowIndex >= 0)
                    {
                        lblRulerIDText.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtRulerName.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtRulerAbbreviation.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        

                    }
                }
                else if (sender == dgvRealms)
                {
                    if (e.RowIndex >= 0)
                    {
                        lblRealmIDText.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtRealmName.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtRealmOwner.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        

                    }
                }
                else if (sender == dgvProvinces)
                {
                    if (e.RowIndex >= 0)
                    {
                        lblProvinceIDText.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtProvinceName.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtProvinceSize.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        cbxProvinceTerrain.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        SetCheckedComboBoxCheckedItems(fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                        txtProvinceOwner.Text = fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtProvinceLoyalty.Text = fakeDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        cbxProvinceRoad.Checked= Convert.ToBoolean( fakeDataGridView.Rows[e.RowIndex].Cells[7].Value);
                    }
                }
                else if (sender == dgvHoldings)
                {
                    if (e.RowIndex >= 0)
                    {
                        lblHoldingIDText.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cbxHoldingType.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtHoldingSize.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtHoldingOwner.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetCheckedComboBoxCheckedItems(string items)
        {
            List<string> things = items.Split(',').Select(p => p.Trim()).ToList();
            
            for (int i = 0; i < ccbProvinceSecondaryTerrain.Items.Count; i++)
            {
               
            
                if (things.Contains(ccbProvinceSecondaryTerrain.Items[i].ToString()))
                {
                    ccbProvinceSecondaryTerrain.SetItemCheckState(ccbProvinceSecondaryTerrain.Items.IndexOf(ccbProvinceSecondaryTerrain.Items[i]),CheckState.Checked) ;
                }
                else { ccbProvinceSecondaryTerrain.SetItemCheckState(ccbProvinceSecondaryTerrain.Items.IndexOf(ccbProvinceSecondaryTerrain.Items[i]), CheckState.Unchecked); }
            }

        }



        //search for text as typed in 
        public void SearchBoxTyping(object sender, EventArgs e)
        {
            TextBox fakeTextBox = sender as TextBox;
            dgvMain.DataSource = null;
            try
            {
                switch (fakeTextBox.Name)
                {
                    case "txtFindProvince":

                        dgvMain.DataSource = myDatabase.SearchForItem("Province", txtFindProvince.Text);
                        dgvMain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;
                    //case "txtFindCustomer":
                    //    dgvCustomers.DataSource = myDatabase.SearchForItem("Customer", txtFindCustomer.Text);
                    //    dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    //    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdminButton_Click(object sender, EventArgs e)
        {
            Button fakeButton = sender as Button;
            


            Dictionary<string, string> dictData = new Dictionary<string, string>();

            dictData.Add("RulerID", lblRulerIDText.Text);
            dictData.Add("RulerName", txtRulerName.Text);
            dictData.Add("RulerAbbreviation", txtRulerAbbreviation.Text);
            dictData.Add("RealmID", lblRealmIDText.Text);
            dictData.Add("RealmName", txtRealmName.Text);
            dictData.Add("RealmOwner", txtRealmOwner.Text);
            dictData.Add("ProvinceID", lblProvinceIDText.Text);
            dictData.Add("ProvinceName", txtProvinceName.Text);
            dictData.Add("ProvinceSize", txtProvinceSize.Text);
            dictData.Add("ProvinceTerrain", GameInfo.TerrainNameCorrector(cbxProvinceTerrain.Text));
            dictData.Add("ProvinceSecondaryTerrain", GameInfo.SecondaryTerrainNameCorrector(ccbProvinceSecondaryTerrain.Text));
            dictData.Add("ProvinceOwner", txtProvinceOwner.Text);
            dictData.Add("ProvinceLoyalty", txtProvinceLoyalty.Text);
            dictData.Add("ProvinceRoad", cbxProvinceRoad.Checked.ToString());
            dictData.Add("HoldingID", lblHoldingIDText.Text);
            dictData.Add("HoldingType", cbxHoldingType.Text);
            dictData.Add("HoldingSize", txtHoldingSize.Text);
            dictData.Add("HoldingOwner", txtHoldingOwner.Text);
            dictData.Add("HoldingLocation",txtHoldingLocaton.Text);



            string buttonName = fakeButton.Text;
            //TODO Reactivate for database 
            // myDatabase.AdminTools(dictData, buttonName);
            LoadDatabase();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            // GameInfo newGameInfo=new GameInfo();
            //lbxTest.Items.Add("Plains " + GameInfo.Terrain["Plains"].MaxPop+" "+GameInfo.Terrain["Plains"].MoveCost+" " + GameInfo.Terrain["Plains"].SourcePotential);
            //lbxTest.Items.Add(GameInfo.TerrainNameCorrector(ccbProvinceSecondaryTerrain.Text));
            //lbxTest.Items.Add(GameInfo.SecondaryTerrainNameCorrector(ccbProvinceSecondaryTerrain.Text));

        }
    }
}
/*// load views on tab click
        private void TabClick(object sender, EventArgs e)
        {
        }

        //search boxes:
        //flick to tab 
        public void SearchBoxClicked(object sender, EventArgs e)
        {
            TextBox fakeTextBox = sender as TextBox;
            if (fakeTextBox.Name == "txtFindMovie")
            {
                tabControl1.SelectedTab = tabPageMovies;
                txtFindMovie.Focus();
            }
            else if (fakeTextBox.Name == "txtFindCustomer")
            {
                tabControl1.SelectedTab = tabPageCustomers;
                txtFindCustomer.Focus();
            }
        }

        

        public void RentalSelect_Clicked(object sender, EventArgs e)
        {
            RentalSelect();
        }
        public void RentalSelect()
        {
           
                switch (rbtRentalCurrent.Checked)
                {
                    case true:
                        dgvRentals.DataSource = myDatabase.RentalDataSelect("NOTAll");
                        dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;
                    case false:
                        dgvRentals.DataSource = myDatabase.RentalDataSelect("All");
                        dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;
             
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView fakeDataGridView = sender as DataGridView;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                if (sender == dgvMovies)
                {

                    //if you are clicking on a row and not outside it
                    if (e.RowIndex >= 0)
                    {
                        txtMovieID.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtMovieRating.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtMovieTitle.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtMovieYear.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtMovieRentalCost.Text = "$"+Convert.ToString(RentalCalculator(txtMovieYear.Text));
                        //fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtMovieCopies.Text = fakeDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        txtMoviePlot.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtMovieGenres.Text = fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        
                    }
                }else if (sender == dgvCustomers)
                {
                    if (e.RowIndex >= 0)
                    {
                        txtCustID.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCustFirstname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCustLastname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtCustAddress.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtCustPhone.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtCustDOB.Text= fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

                    }
                }else if (sender == dgvRentals)
                {
                    if (e.RowIndex >= 0)
                    {

                        txtMovieID.Text = "";
                        txtMovieRating.Text = "";
                        txtMovieYear.Text = "";
                        txtMovieRentalCost.Text = "";
                        txtMovieCopies.Text = "";
                        txtMoviePlot.Text = "";
                        txtMovieGenres.Text = "";
                        txtCustID.Text = "";
                        txtCustAddress.Text = "";
                        txtCustPhone.Text = "";
                        

                        txtRentalID.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCustFirstname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCustLastname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtMovieTitle.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtRentalDateRented.Text = DateTime.Parse( fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()).ToShortDateString();//.ToString();
                        //txtRentalDateReturned.Text = fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtRentalDateReturned.Text = DateTime.Parse(fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()).ToShortDateString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //new rental: pass date,movieID and CustID to DB method

        public void btnIssueRental_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                MessageBox.Show("Select a single date.");

            }
            else
            {
                if (OkToRent()==false)
                {
                    MessageBox.Show("Rental Denied");
                }
                else
                {
                    DateTime date = monthCalendar1.SelectionStart;
                    int movieID = Convert.ToInt32(txtMovieID.Text);
                    int customerID = Convert.ToInt32(txtCustID.Text);
                    //Note: Make sure you pass movieID&CustomerID in the right order or everything goes pear shaped.
                    myDatabase.CreateNewRental(movieID, customerID, date);
                    LoadDatabase();
                }
            }
        }

        public bool OkToRent()
        {
            if (txtCustDOB.Text != "" && IsOldEnough(DateTime.Parse(txtCustDOB.Text), txtMovieRating.Text) == false)
            {
                DialogResult dialogResult = MessageBox.Show("Allow rental?",
                    "WARNING: Customer may be too young to rent this movie.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return true;
                }
                 return false;
            }
            return true;
        }

        public bool IsOldEnough(DateTime dob, string rating)
        {
           TimeSpan ageTimespan = DateTime.Now.Subtract(dob);
            int age = ageTimespan.Days/365;
            int ratingAge = ratingDictionary[rating];
            if (age > ratingAge)
            {
                return true;
            }
            //MessageBox.Show(age.ToString());
            return false;
        }
        //return rental: pass rental ID and date to db method
        public void btnReturnRental_Click(object sender, EventArgs e)
        {
            DataGridView fakeDataGridView = dgvRentals;
            if (monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                MessageBox.Show("Select a single date.");

            }
            


                else
                {
                    DateTime date = monthCalendar1.SelectionStart;
                    int rentalID =
                        Convert.ToInt32(
                            fakeDataGridView.Rows[fakeDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    myDatabase.ReturnRental(rentalID, date);
                    LoadDatabase();
                }
            
        }

        private void btnAdminOnOff_Click(object sender, EventArgs e)
        {
            if (btnDeleteCustomer.Enabled == false) {
                using (Form passwordForm = new PasswordForm())
                {//RE-ENABLE FOR FULL PROGRAM
                   // if (passwordForm.ShowDialog() == DialogResult.OK)
                    {

                        btnAddCustomer.Enabled = true;
                        btnUpdateCustomer.Enabled = true;
                        btnDeleteCustomer.Enabled = true;
                        btnAddMovie.Enabled = true;
                        btnUpdateMovie.Enabled = true;
                        btnDeleteMovie.Enabled = true;
                        btnUpdateRental.Enabled = true;
                        btnDeleteRental.Enabled = true;
                    }
                }

            }else if (btnDeleteCustomer.Enabled == true)
            {//RE-ENABLE FOR FULL PROGRAM
               // DialogResult dialogResult = MessageBox.Show("", "Turn off Admin controls?", MessageBoxButtons.YesNo);
               // if (dialogResult == DialogResult.Yes)
                {
                    btnAddCustomer.Enabled = false;
                    btnUpdateCustomer.Enabled = false;
                    btnDeleteCustomer.Enabled = false;
                    btnAddMovie.Enabled = false;
                    btnUpdateMovie.Enabled = false;
                    btnDeleteMovie.Enabled = false;
                    btnUpdateRental.Enabled = false;
                    btnDeleteRental.Enabled = false;
                }
               
            }



            
        }

        public int RentalCalculator(string movieYear)
        {
            int year = 0;
            try
            {
                year = int.Parse(movieYear);
               // MessageBox.Show(Convert.ToString(year));
            }
            catch
            {
                MessageBox.Show("Year format not supported");
            }
            int rentCost=0;
            if (DateTime.Now.Year - year > 5)
            {
                rentCost = 2;
            }
            else rentCost = 5;
            return rentCost;
        }
        //edit movie click: open new form to add/update/delete movies.
        //edit customers as above
        private void btnAdminButton_Click(object sender, EventArgs e)
        {
            Button fakeButton = sender as Button;
            string[] data = new[]
            {
                txtCustID.Text, txtCustFirstname.Text, txtCustLastname.Text, txtCustAddress.Text, txtCustPhone.Text,
                txtCustDOB.Text, txtMovieID.Text, txtMovieTitle.Text, txtMovieYear.Text, txtMoviePlot.Text,
                txtMovieRating.Text, txtMovieCopies.Text, txtMovieGenres.Text, txtMovieRentalCost.Text, txtRentalID.Text,
                txtRentalDateRented.Text, txtRentalDateReturned.Text
            };


            Dictionary<string, string> dictData = new Dictionary<string, string>();
            
            dictData.Add("CustID",txtCustID.Text);
            dictData.Add("CustFirstname", txtCustFirstname.Text);
            dictData.Add("CustLastname", txtCustLastname.Text);
            dictData.Add("CustAddress", txtCustAddress.Text);
            dictData.Add("CustPhone", txtCustPhone.Text);
            dictData.Add("CustDOB", txtCustDOB.Text);
            dictData.Add("MovieID", txtMovieID.Text);
            dictData.Add("MovieTitle", txtMovieTitle.Text);
            dictData.Add("MovieYear", txtMovieYear.Text);
            dictData.Add("MoviePlot", txtMoviePlot.Text);
            dictData.Add("MovieRating", txtMovieRating.Text);
            dictData.Add("MovieCopies", txtMovieCopies.Text);
            dictData.Add("MovieGenres", txtMovieGenres.Text);
            dictData.Add("MovieRentalCost", txtMovieRentalCost.Text);
            dictData.Add("RentalID", txtRentalID.Text);
            dictData.Add("RentalDateRented", txtRentalDateRented.Text);
            dictData.Add("RentalDateReturned", txtRentalDateReturned.Text);



            string buttonName = fakeButton.Text;

            myDatabase.AdminTools(dictData,buttonName);
            LoadDatabase();
        }
        public void ReportSelect_Clicked(object sender, EventArgs e)
        {
            RadioButton fakeRadioButton=sender as RadioButton;
            string name = fakeRadioButton.Name;
            ReportSelect(name);
        }
        public void ReportSelect(string name)
        {

            switch (name)
            {
                case "rbtMostPopMovie":
                    dgvReports.DataSource = myDatabase.ReportSelect("MostPopMov");
                    dgvReports.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;
                case "rbtRentalsByCust":
                    dgvReports.DataSource = myDatabase.ReportSelect("CustMostRent");
                    dgvReports.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;

            }
        }
        //private void btnTest_Click(object sender, EventArgs e)
        //{
        //    IsOldEnough(DateTime.Parse(txtCustDOB.Text), txtMovieRating.Text);
        //}
    }
}*/
