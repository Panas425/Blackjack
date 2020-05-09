using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logics_Layer;

namespace Assignment1
{
    public partial class HomesForSale : Form
    {
        /// <summary>
        /// Declaring variables
        /// </summary>
        private BuildingManager buildingManager = new BuildingManager();
        private InputData inputData;
        private DataController controller;
        private SaveFileDialog saveDialog = new SaveFileDialog();
        private OpenFileDialog openDialog = new OpenFileDialog();
        private string filePath;
        private bool savedUpToDate = false;

        public HomesForSale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomesForSale_Load(object sender, EventArgs e)
        {
            controller = new DataController(buildingManager);
            inputData = new InputData(controller);
            openDialog.Filter = "Data Files (*.bin)|*.bin";
            openDialog.Title = "Open a file";
            saveDialog.AddExtension = true;
            buildingManager.SetDataFromDatabase();
            InitGUI();
        }

        /// <summary>
        /// Initialize gui controllers
        /// </summary>
        private void InitGUI()
        {
            countriesComboBox.Items.AddRange(InputData.GetCountries());
            countriesComboBox.SelectedIndex = 0;

            categoryComboBox.Items.AddRange(InputData.GetCategories());
            categoryComboBox.SelectedIndex = 0;

            legalComboBox.Items.AddRange(InputData.GetOwnerships());
            legalComboBox.SelectedIndex = 0;

            ChangeBuildingType(0);

            searchTypeComboBox.Items.AddRange(InputData.GetBothBuildingTypes());
            searchTypeComboBox.SelectedIndex = 0;

            UpdateTables();
        }

        /// <summary>
        /// Resets the GUI
        /// </summary>
        private void ResetGUI()
        {
            countriesComboBox.Items.Clear();
            categoryComboBox.Items.Clear();
            legalComboBox.Items.Clear();
            searchTypeComboBox.Items.Clear();
            cityTextBox.ResetText();
            streetTextBox.ResetText();
            zipCodeTextBox.ResetText();
            searchCityTextBox.ResetText();
            buildingManager.DisplayList();
            InitGUI();
        }


        /// <summary>
        /// Changing the building's type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBuildingType(categoryComboBox.SelectedIndex);
        }

        /// <summary>
        /// Changing the building's type
        /// </summary>
        /// <param name="isCommercialBuilding"></param>
        private void ChangeBuildingType(int isCommercialBuilding)
        {
            typeComboBox.Items.Clear();
            typeComboBox.Items.AddRange(InputData.GetBuildingTypes(isCommercialBuilding));
            typeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// adds new building
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (InputDataIsCorrect())
            {
                if (inputData.AddBuilding())
                {
                    buildingManager.DisplayList();
                    UpdateTables();
                    savedUpToDate = false;
                }
            }
        }

        /// <summary>
        /// edits building that is selected in the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (localTable.SelectedRows.Count == 1) // Are there even a building object to edit?
            {
                if (InputDataIsCorrect())
                {
                    string buildingID = localTable.SelectedCells[0].Value.ToString();

                    if (inputData.EditBuilding(buildingID))
                    {
                        buildingManager.DisplayList();
                        UpdateTables();
                        savedUpToDate = false;
                    }
                }
            }
        }

        /// <summary>
        /// Checks if the input data is correct by the user
        /// </summary>
        /// <returns></returns>
        private bool InputDataIsCorrect()
        {
            if (inputData.ReadBuildningInput(typeComboBox, countriesComboBox, cityTextBox.Text, streetTextBox.Text, zipCodeTextBox.Text, legalComboBox))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes selected building from the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (localTable.SelectedRows.Count > 0)
            {
                string buildingID = localTable.SelectedCells[0].Value.ToString();

                if (inputData.RemoveBuilding(buildingID))
                {
                    buildingManager.DisplayList();
                    UpdateTables();
                    savedUpToDate = false;
                }
            }
        }

        /// <summary>
        /// searching buildings by typing city and/or type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            inputData.Search(searchCityTextBox.Text, searchTypeComboBox.GetItemText(searchTypeComboBox.SelectedItem));
            UpdateTables();
        }


        /// <summary>
        /// resets the search results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            buildingManager.DisplayList();
            UpdateTables();
        }

        /// <summary>
        /// allow only numbers in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// get data from a selected building and display it in the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localTable_SelectionChanged(object sender, EventArgs e)
        {
            if (localTable.SelectedRows.Count == 1) // Are there even a building to get data from
            {
                if (localTable.SelectedCells[1].Value != null) // At start up there can be a problem to retrieve data
                {
                    try
                    {
                        countriesComboBox.SelectedItem = localTable.SelectedCells[1].Value.ToString().Trim();
                        cityTextBox.Text = localTable.SelectedCells[2].Value.ToString().Trim();
                        streetTextBox.Text = localTable.SelectedCells[3].Value.ToString().Trim();
                        zipCodeTextBox.Text = localTable.SelectedCells[4].Value.ToString().Trim();
                        categoryComboBox.SelectedItem = localTable.SelectedCells[5].Value.ToString().Trim();
                        typeComboBox.SelectedItem = localTable.SelectedCells[6].Value.ToString().Trim();
                        legalComboBox.SelectedItem = localTable.SelectedCells[7].Value.ToString().Trim();
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// Asking the user to save the current data or not
        /// then the method ResetGUI is invoked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile(SaveOrNot());
            ResetGUI();
        }

        /// <summary>
        /// Asking the user to saved the current data or not before opening a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile(SaveOrNot());
        }

        /// <summary>
        /// If therer are data in the table the application will ask the user to save or not to save current data
        /// </summary>
        /// <returns></returns>
        private bool SaveOrNot()
        {
            if (localTable.RowCount != 0)
            {
                if (savedUpToDate)
                {
                    return true;
                }
                else if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Saving data to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// Ask the user to save any place in the computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs(false);
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs(true);
        }

        /// <summary>
        /// Asking the user to save the current data or not then all the data is removed from the table
        /// </summary>
        /// <param name="save"></param>
        public void NewFile(bool save)
        {
            if (save)
            {
                SaveFile();
            }
            SQLQuery.DeleteAllObjects();
            buildingManager.DeleteAll();
            ClearTable();
            filePath = null;
            savedUpToDate = true;
            buildingManager.DisplayList();
        }

        /// <summary>
        /// Asking the user to save the current data or not before opening a new file
        /// </summary>
        /// <param name="save"></param>
        public void OpenFile(bool save)
        {
            if (save)
            {
                SaveFile();
            }

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                localTable.ClearSelection();
                filePath = openDialog.FileName;

                try
                {

                    buildingManager.BinaryDeSerialization(filePath);
                    buildingManager.UpdateDatabase();
                    buildingManager.DisplayList();
                    ResetGUI();
                    savedUpToDate = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        /// <summary>
        /// Saving the file, if the file isnt saved in the computer the user will be asked to name and place the file in the computer
        /// </summary>
        public void SaveFile()
        {
            if (String.IsNullOrEmpty(filePath))
            {
                SaveFileAs(false);
            }
            else
            {
                try
                {
                    buildingManager.BinarySerialization(filePath);
                    savedUpToDate = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        /// <summary>
        /// Saving a file in any places in the computer
        /// </summary>
        public void SaveFileAs(bool saveAsXML)
        {
            if (buildingManager.Count > 0)
            {
                if (saveAsXML)
                {
                    saveDialog.Filter = "XML (*.xml)|*.xml";
                    saveDialog.DefaultExt = ".xml";
                }
                else
                {
                    saveDialog.Filter = "(*.bin)|*.bin";
                    saveDialog.DefaultExt = "bin";
                }

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveDialog.FileName;

                    if (saveAsXML)
                    {
                        try
                        {
                            buildingManager.XMLSerialize(filePath);
                            savedUpToDate = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                    }
                    else
                    {
                        try
                        {
                            buildingManager.BinarySerialization(filePath);
                            savedUpToDate = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data is avaiable, not able to save");
            }
        }

        /// <summary>
        /// Clears the table
        /// </summary>
        private void ClearTable()
        {
            localTable.Rows.Clear();
        }

        /// <summary>
        /// Updates GUI
        /// </summary>
        public void UpdateTables()
        {
            ClearTable();
            List<string> list = buildingManager.GetDisplayList();

            if (list != null)
            {
                for (int row = 0; row < list.Count; row++)
                {
                    localTable.Rows.Add();

                    for (int col = 0; col < localTable.ColumnCount; col++)
                    {
                        localTable[col, row].Value = list[row].Split(',').ToArray()[col];
                    }
                }
            }
        }

        /// <summary>
        /// Before closing the application the user will be asked to save the data or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveOrNot())
            {
                SaveFile();
            }
            Close();
        }
    }
}
