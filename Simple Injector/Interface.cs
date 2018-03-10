using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System;

namespace Simple_Injector
{
    public partial class Interface : Form
    {
        private readonly DataTable _processTable = new DataTable("processTable");
       
        private string _dllPath;

        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            InitializeDataTable();

            // Set the datasource of the datagrid

            ProcessDataGrid.DataSource = _processTable;

            PopulateDataTable();

            // Sort the processes

            ProcessDataGrid.Sort(ProcessDataGrid.Columns["Name"], ListSortDirection.Ascending);
        }

        private void InitializeDataTable()
        {
            // Add columns to datatable

            _processTable.Columns.Add("Name", typeof(string));
        }

        private void PopulateDataTable()
        {
            // Populate the datatable

            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                _processTable.Rows.Add(process.ProcessName);
            }

        }

        private void ProcessDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the process that has been clicked

            var process = ProcessDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Set the text of SelectedProcessTextBox to the process name

            SelectedProcessTextBox.Text = Convert.ToString(process.FormattedValue);

        }

        private void ChooseDLLButton_Click(object sender, EventArgs e)
        {
            // Open a file dialog

            FileDialog.ShowDialog();

            // Get the file path of the chosen dll

            var dll = _dllPath = FileDialog.FileName;

            // Set the text of DLLFileTextBox to the dll name

            DLLFileTextBox.Text = Path.GetFileNameWithoutExtension(dll);
        }

        private void InjectDLLButton_Click(object sender, EventArgs e)
        {
            // Get the chosen process

            var processName = SelectedProcessTextBox.Text;

            Injector.Inject(processName, _dllPath);

        }

        private void CloseAfterInjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AutoInjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
