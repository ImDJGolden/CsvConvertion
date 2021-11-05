using Microsoft.VisualBasic.FileIO;
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

namespace CsvConvertion
{
    public partial class CSVConverter : Form
    {
        public int SelectedReeks = 0;
        public bool ReeksIdAdded = false;
        public string ExportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output.csv");
        public CSVConverter()
        {
            InitializeComponent();
        }

        private void Btn_SelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                string SourceURL = "";

                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable dtNew = new DataTable();
                        dtNew = GetDataTableFromCsvFile(dialog.FileName);
                        
                        Txt_File.Text = dialog.SafeFileName;
                        SourceURL = dialog.FileName;

                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                        {
                            Dgv_CsvFile.DataSource = dtNew;
                        }
                        
                        if (Dgv_CsvFile.Rows.Count == 0)
                        {
                            MessageBox.Show("Geen data in csv Bestand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Gekozen bestand is ongeldig. Kies een csv Bestand.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error");
            }
        }

        public static DataTable GetDataTableFromCsvFile(string fileName)
        {
            DataTable csvData = new DataTable();

            try
            {
                if (fileName.EndsWith("csv"))
                {
                    using (TextFieldParser csvReader = new TextFieldParser(fileName))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;

                        //read Column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            //'Naam ruiter' split into 'Voornaam' en 'Achternaam'
                            if (column == "Naam ruiter")                //Full name
                            {
                                csvData.Columns.Add("Voornaam");        //First name
                                csvData.Columns.Add("Achternaam");      //Last name
                            }
                            else
                            {
                                DataColumn datacolumn = new DataColumn(column);
                                datacolumn.AllowDBNull = true;

                                csvData.Columns.Add(datacolumn);
                            }
                        }

                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length - 1; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }

                            //Split: fieldData[0] -> split op 1ste spatie
                            string[] splitted = fieldData[0].Split(new[] { ' ' }, 2);

                            Array.Resize(ref fieldData, 5);

                            fieldData[4] = fieldData[3];
                            fieldData[3] = fieldData[2];
                            fieldData[2] = fieldData[1];
                            fieldData[1] = splitted[1];
                            fieldData[0] = splitted[0];

                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error");
            }
            return csvData;
        }

        private void Rb_Reeks30_CheckedChanged(object sender, EventArgs e)
        {
            SelectedReeks = 1;
        }

        private void Rb_Reeks50_CheckedChanged(object sender, EventArgs e)
        {
            SelectedReeks = 2;
        }

        private void Rb_Reeks70_CheckedChanged(object sender, EventArgs e)
        {
            SelectedReeks = 3;
        }

        private void Rb_Reeks85_CheckedChanged(object sender, EventArgs e)
        {
            SelectedReeks = 4;
        }

        private void Rb_Reeks95_CheckedChanged(object sender, EventArgs e)
        {
            SelectedReeks = 5;
        }

        private void Rb_Reeks105_CheckedChanged(object sender, EventArgs e)
        {
            SelectedReeks = 6;
        }

        private void Rb_Reeks115_CheckedChanged(object sender, EventArgs e)
        {
            SelectedReeks = 7;
        }

        private void Btn_AddReeksId_Click(object sender, EventArgs e)
        {
            if (Dgv_CsvFile.Rows.Count != 0)
            {
                if (SelectedReeks != 0)
                {
                    Dgv_CsvFile.Columns.Add("Wedstrijd nummer", "Wedstrijd nummer");

                    for (int i = 0; i < Dgv_CsvFile.Rows.Count - 1; i++)
                    {
                        Dgv_CsvFile.Rows[i].Cells[5].Value = SelectedReeks;
                    }

                    AdjustColumnOrder();
                    ReeksIdAdded = true;
                    Btn_AddReeksId.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Kies een Reeks.", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Importeer eerst een csv Bestand.", "Warning");
            }
        }

        private void Btn_ExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_CsvFile.Rows.Count != 0)
                {
                    if (ReeksIdAdded)
                    {
                        try
                        {
                            //Put Columns in order of display
                            List<DataGridViewColumn> columnsInOrder = new List<DataGridViewColumn>();

                            foreach (DataGridViewColumn c in Dgv_CsvFile.Columns)
                            {
                                columnsInOrder.Add(c);
                            }

                            columnsInOrder = columnsInOrder.OrderBy(c => c.DisplayIndex).ToList();

                            //Read Rows into lines of string to export to csv
                            List<string> CsvExportLines = new List<string>();

                            foreach (DataGridViewRow row in Dgv_CsvFile.Rows)
                            {
                                List<string> valuesInOrder = new List<string>();

                                foreach (DataGridViewColumn col in columnsInOrder)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        valuesInOrder.Add(row.Cells[col.Index].Value.ToString());
                                    }
                                }

                                CsvExportLines.Add(string.Join(";", valuesInOrder.ToArray()));
                            }

                            StreamWriter Output = File.AppendText(ExportPath);

                            try
                            {
                                for (int i = 0; i <= CsvExportLines.Count - 2; i++)
                                {
                                    Output.WriteLine(CsvExportLines[i]);
                                }

                                //Clear DataGridView
                                ClearWinForm();

                                MessageBox.Show("Data is succesvol geëxporteerd naar de output.csv", "Succes");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"{ex}", "Error");
                            }
                            finally
                            {
                                Output.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex}", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Voeg eerst de wedstrijd nummer toe.");
                    }
                }
                else
                {
                    MessageBox.Show("Importeer eerst een csv Bestand.", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error");
            }
        }

        private void AdjustColumnOrder()
        {
            //Change order
            Dgv_CsvFile.Columns["Voornaam"].DisplayIndex = 0;           //Display 0     Real 0
            Dgv_CsvFile.Columns["Achternaam"].DisplayIndex = 1;         //Display 1     Real 1
            Dgv_CsvFile.Columns["Naam paard"].DisplayIndex = 2;         //Display 2     Real 2
            Dgv_CsvFile.Columns["Wedstrijd nummer"].DisplayIndex = 3;   //Display 3     Real 5
            Dgv_CsvFile.Columns["Volgorde"].DisplayIndex = 4;           //Display 4     Real 4
            Dgv_CsvFile.Columns["Type"].DisplayIndex = 5;               //Display 5     Real 3

            //Change header value
            Dgv_CsvFile.Columns[4].HeaderCell.Value = "Startnummer";
        }

        private void ClearWinForm()
        {
            //Clear DataGridView
            Dgv_CsvFile.DataSource = null;
            Dgv_CsvFile.Columns.Remove("Wedstrijd nummer");

            //Clear UI
            Txt_File.Text = null;
            Btn_AddReeksId.Enabled = true;

            //Uncheck All
            Rb_Reeks30.Checked = false;
            Rb_Reeks50.Checked = false;
            Rb_Reeks70.Checked = false;
            Rb_Reeks85.Checked = false;
            Rb_Reeks95.Checked = false;
            Rb_Reeks105.Checked = false;
            Rb_Reeks115.Checked = false;

            SelectedReeks = 0;
            ReeksIdAdded = false;
        }
    }
}
