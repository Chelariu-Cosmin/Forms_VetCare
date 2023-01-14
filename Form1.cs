using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VetCate.NET
{
    public partial class IncomeVET : Form
    {
        //MS Access Database Connection String

        String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Master\.net\Crud-prez_2\VetCate.NET\BDDVet.accdb";

        OleDbConnection accessDatabaseConnection = null;
        public IncomeVET()
        {
            //Initializing MS Access Database Connection
            accessDatabaseConnection = new OleDbConnection(connectionString);
            InitializeComponent();
        }

        public void openConnection()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNrAdministrari_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNrAdministrari_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filterExpr = string.Empty;
            if (!String.IsNullOrEmpty(txtVaccin.Text))
            {
                filterExpr = "DenumireVaccin = '" + txtVaccin.Text + "' ";
            }
            if (!String.IsNullOrEmpty(txtAnotimp.Text))
            {
                filterExpr += !string.IsNullOrEmpty(filterExpr) ? " AND " : " ";
                filterExpr += "Anotimp = '" + txtAnotimp.Text + "' ";
            }

            DataView dv = this.vetDataSet.Tables[0].DefaultView;
            dv.RowFilter = filterExpr;
            ddtGrid.DataSource = dv;
        }

        private void txtVaccin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDenumireVaccin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetDataSet.Vaccinuri' table. You can move, or remove it, as needed.
            this.vaccinuriTableAdapter.Fill(this.vetDataSet.Vaccinuri);

        }

        private void ddtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if the row cell content is clicked
          /*  if (e.RowIndex >= 0)*/
            
                DataGridViewRow datagridviewrow =ddtGrid.Rows[e.RowIndex];
                vaccinIDText.Text = datagridviewrow.Cells[0].Value.ToString();
                denumireVaccinText.Text = datagridviewrow.Cells[1].Value.ToString();
                anotimpText.Text = datagridviewrow.Cells[2].Value.ToString();
                numarAdministrariText.Text = datagridviewrow.Cells[3].Value.ToString();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                String insertDataIntoMicrosoftAccessDatabase = "INSERT INTO Vaccinuri(DenumireVaccin, Anotimp, NumarAdministrari, PerioadaAdministrare, PacientID) VALUES (?,?,?,?,?)";
                //Check If One Or More Fields Are Empty
                if (denumireVaccinText.Text == String.Empty || anotimpText.Text == String.Empty || numarAdministrariText.Text == String.Empty || txtPerioada.Text == String.Empty || txtPacientID.Text == String.Empty)
                {
                    MessageBox.Show("One Or More Empty Field MAke sure all fields are filled............");
                }
                else
                {
                    OleDbCommand insertDataComand = new OleDbCommand(insertDataIntoMicrosoftAccessDatabase, accessDatabaseConnection);
                    insertDataComand.Parameters.AddWithValue("@DenumireVaccin", OleDbType.VarChar).Value = denumireVaccinText.Text;
                    insertDataComand.Parameters.AddWithValue("@Anotimp", OleDbType.VarChar).Value = anotimpText.Text;
                    insertDataComand.Parameters.AddWithValue("@NumarAdministrari", OleDbType.Numeric).Value = numarAdministrariText.Text;
                    insertDataComand.Parameters.AddWithValue("@PerioadaAdministrare", OleDbType.Numeric).Value = txtPerioada.Text;
                    insertDataComand.Parameters.AddWithValue("@PacientID", OleDbType.Numeric).Value = txtPacientID.Text;

                    //Opening Access Database Connection
                    accessDatabaseConnection.Open();
                    int insertDataToAccessDatabase = insertDataComand.ExecuteNonQuery();
                    //If data Has been inserted to the database output the following message
                    if (insertDataToAccessDatabase > 0)
                    {
                        MessageBox.Show("Data Inserted To MS-Access Database Susccessfully.........");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                //Finally Close MS Access Database Connection
                if (accessDatabaseConnection != null)
                {
                    accessDatabaseConnection.Close();
                }
            }
            // this.vaccinuriTableAdapter.Fill(this.vetDataSet.Vaccinuri);
            //Refreshing Datagridview after inserting new row
            PopulateGridView();


            //Clear Input Fields PictureBox And Textboxes
            //clearInputFields();*/
        }
        public void PopulateGridView()
        {
            try
            {
                accessDatabaseConnection.Open();
                String selectQuery = "SELECT * FROM Vaccinuri";
                OleDbCommand selectDataComand = new OleDbCommand(selectQuery, accessDatabaseConnection);

                selectDataComand.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(selectDataComand);
                DataTable vaccinuri = new DataTable();
                da.Fill(vaccinuri);
                ddtGrid.DataSource = vaccinuri;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                if (accessDatabaseConnection != null)
                {
                    accessDatabaseConnection.Close();
                }
            }

        }
        private void clearInputFields()
        {
            vaccinIDText.Clear();
            denumireVaccinText.Clear();
            anotimpText.Clear();
            numarAdministrariText.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String deleteDataFromMSAccessDatabaseQuery = "DELETE  FROM Vaccinuri WHERE VaccinID =? ";
            if (vaccinIDText.Text == String.Empty)
            {
                MessageBox.Show("First Click On DatagridView Row Cell Or Make Sure ID Field Is Not Empty.......");
            }
            else
            {
                try
                {
                    OleDbCommand deleteDataFromMSAccessDatabaseOleDbCommand = new OleDbCommand(deleteDataFromMSAccessDatabaseQuery, accessDatabaseConnection);
                    deleteDataFromMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("@ID", OleDbType.Integer).Value = Convert.ToInt32(vaccinIDText.Text);
                    //Opening Access Database Connection
                    accessDatabaseConnection.Open();
                    int deleteDataFromMSAccessDatabase = deleteDataFromMSAccessDatabaseOleDbCommand.ExecuteNonQuery();
                    //If data Has been Deleted from the database output the following message
                    if (deleteDataFromMSAccessDatabase > 0)
                    {
                        MessageBox.Show("Data Deleted From MS-Access Database Susccessfully.........");
                        //Clear Input fields After Deleting the Data From MS Access Database
                        clearInputFields();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    //Finally Close MS Access Database Connection
                    if (accessDatabaseConnection != null)
                    {
                        accessDatabaseConnection.Close();
                    }
                }
                //Refreshing Datagridview after Deleting a row
                PopulateGridView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String updateVaccinInfo = "UPDATE Vaccinuri SET DenumireVaccin=@DenumireVaccin, Anotimp=@Anotimp, NumarAdministrari=@NumarAdministrari WHERE VaccinID=@VaccinID";

            if (vaccinIDText.Text == String.Empty)
            {
                MessageBox.Show("First Click On DatagridView Row Cell Or Make Sure ID Field Is Not Empty.......");
            }
            else
            {
                try
                {
                    //Opening Access Database Connection
                    accessDatabaseConnection.Open();
                    //Check If One Or More Fields Are Empty
                    if (denumireVaccinText.Text == String.Empty || anotimpText.Text == String.Empty || numarAdministrariText.Text == String.Empty)
                    {
                        MessageBox.Show("One Or More Empty Field Make sure all fields are filled............");
                    }
                    else
                    {
                        OleDbCommand updateDataInMSAccessDatabaseOleDbCommand = new OleDbCommand(updateVaccinInfo, accessDatabaseConnection);
                        updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("@VaccinID", OleDbType.Integer).Value = Convert.ToInt32(vaccinIDText.Text);
                        updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("@DenumireVaccin", OleDbType.VarChar).Value = denumireVaccinText.Text;
                        updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("@Anotimp", OleDbType.VarChar).Value = anotimpText.Text;
                        updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("@NumarAdministrari", OleDbType.Integer).Value = Convert.ToInt32(numarAdministrariText.Text);
                        updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("@PerioadaAdministrare", OleDbType.Numeric).Value = txtPerioada.Text;
                        updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("@PacientID", OleDbType.Numeric).Value = txtPacientID.Text;

                        updateDataInMSAccessDatabaseOleDbCommand.ExecuteNonQuery();                                        
                        {
                            MessageBox.Show("Data Updated In MS-Access Database Susccessfully.........");
                            clearInputFields();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                finally
                {
                    //Finally Close MS Access Database Connection
                    if (accessDatabaseConnection != null)
                    {
                        accessDatabaseConnection.Close();
                    }
                }
                //Refreshing Datagridview after Updating a row
                PopulateGridView();
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application exportDataGridViewToExcelApplication = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook exportDataGridViewToExcelWorkbook = exportDataGridViewToExcelApplication.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet exportDataGridViewToExcelWorksheet = null;
                exportDataGridViewToExcelApplication.Visible = true;
                exportDataGridViewToExcelWorksheet = exportDataGridViewToExcelWorkbook.Sheets["Sheet1"];
                exportDataGridViewToExcelWorksheet = exportDataGridViewToExcelWorkbook.ActiveSheet;
                exportDataGridViewToExcelWorksheet.Name = "ExportedExcelFromDataGridView";

                try
                {
                    for (int i = 0; i <= ddtGrid.Columns.Count - 1; i++)
                    {
                        exportDataGridViewToExcelWorksheet.Cells[1, i + 1] = ddtGrid.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < ddtGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j <= ddtGrid.Columns.Count - 1; j++)
                        {
                            if (ddtGrid.Rows[i].Cells[j].Value != null)
                            {
                                exportDataGridViewToExcelWorksheet.Cells[i + 2, j + 1] = ddtGrid.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                exportDataGridViewToExcelWorksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Dialog Box For Saving Excel File
                    SaveFileDialog exportDataGridViewToExcelSaveDialog = new SaveFileDialog();
                    //Dialog Box Title
                    exportDataGridViewToExcelSaveDialog.Title = "Save Excel File";
                    //Supported Excel File Extensions
                    exportDataGridViewToExcelSaveDialog.Filter = "Excel files (*.xlsx;*.xls;*.xlm)|*.xlsx;*.xls;*.xlm";
                    //Default Excel File Extension
                    exportDataGridViewToExcelSaveDialog.DefaultExt = ".xlsx";
                    //Excel File Name
                    exportDataGridViewToExcelSaveDialog.FileName = "ExportedExcelFileFromDataGridView";

                    if (exportDataGridViewToExcelSaveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        exportDataGridViewToExcelWorkbook.SaveAs(exportDataGridViewToExcelSaveDialog.FileName);
                        MessageBox.Show("DataGridView Exported To Excel File Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    //Release Resources
                    exportDataGridViewToExcelWorksheet = null;
                    exportDataGridViewToExcelWorkbook.Close();
                    exportDataGridViewToExcelApplication.Quit();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void anotimpText_TextChanged(object sender, EventArgs e)
        {

        }

        private void vaccinIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vaccinIDText.Clear();
            denumireVaccinText.Clear();
            anotimpText.Clear();
            numarAdministrariText.Clear();
        }

        private void numarAdministrariLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            DataView dv = new DataView();
            dv = this.vetDataSet.Tables[0].DefaultView;

            if (cmb.SelectedItem.ToString() == "VaccinID")
            {
                dv.Sort = "[VaccinID] DESC";              
            }
            else
            {
                dv.Sort = "[NumarAdministrari] DESC";
            }
            this.ddtGrid.DataSource = dv;
        }

        private void ddtGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait! Your data is in process.");
                accessDatabaseConnection.Open();
                OleDbCommand dataComand = new OleDbCommand();
                dataComand.Connection = accessDatabaseConnection;
                String selectQuery = "SELECT * FROM Vaccinuri";
                dataComand.CommandText = selectQuery;

                OleDbDataReader reader = dataComand.ExecuteReader();
                while(reader.Read())
                {
                    chart1.Series["NumarAdministrari"].Points.AddXY(reader["PacientID"].ToString(), reader["NumarAdministrari"].ToString());
                }

                accessDatabaseConnection.Close();
                

                /*  chart1.Series["PacientID"].XValueMember = "PacientID";
                  chart1.Series["NumarAdministrari"].YValueMembers = "NumarAdministrari";

                  chart1.DataSource = vetDataSet.Vaccinuri;
                  chart1.DataBind();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (ddtGrid.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(ddtGrid.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in ddtGrid.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in ddtGrid.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
 