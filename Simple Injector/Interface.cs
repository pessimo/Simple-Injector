using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Simple_Injector
{
    public partial class Interface : Form
    {
        private DataTable processTable = new DataTable("processTable");

        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, System.EventArgs e)
        {
            InitializeDataTable();

            // Set the datasource of the datagrid

            ProcessDataGrid.DataSource = processTable;

            PopulateDataTable();

            // Sort the processes

            ProcessDataGrid.Sort(ProcessDataGrid.Columns["Name"], ListSortDirection.Ascending);
        }

        private void UploadDLLButton_Click(object sender, System.EventArgs e)
        {
            // Open a file dialog

            FileDialog.ShowDialog();

            // Get the file path of the chosen dll

            var DLL = FileDialog.FileName;
        }

        private void InitializeDataTable()
        {
            // Add columns to datatable

            processTable.Columns.Add("Name", typeof(string));
        }

        private void PopulateDataTable()
        {
            // Populate the datatable

            var processes = Process.GetProcesses();

            foreach(var process in processes)
            {
                processTable.Rows.Add(process.ProcessName);
            }

        }  
    }
}
