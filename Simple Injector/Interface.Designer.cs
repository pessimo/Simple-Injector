namespace Simple_Injector
{
    partial class Interface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenProcessesGroupBox = new System.Windows.Forms.GroupBox();
            this.ProcessDataGrid = new System.Windows.Forms.DataGridView();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.InjectorGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.DLLFileTextBox = new System.Windows.Forms.TextBox();
            this.InjectDLLButton = new System.Windows.Forms.Button();
            this.UploadDLLButton = new System.Windows.Forms.Button();
            this.SelectedProcessTextBox = new System.Windows.Forms.TextBox();
            this.DLLFileLabel = new System.Windows.Forms.Label();
            this.SelectedProcessLabel = new System.Windows.Forms.Label();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CloseAfterInjectCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoInjectCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenProcessesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDataGrid)).BeginInit();
            this.InjectorGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 71);
            this.panel1.TabIndex = 0;
            // 
            // OpenProcessesGroupBox
            // 
            this.OpenProcessesGroupBox.Controls.Add(this.ProcessDataGrid);
            this.OpenProcessesGroupBox.Location = new System.Drawing.Point(13, 75);
            this.OpenProcessesGroupBox.Name = "OpenProcessesGroupBox";
            this.OpenProcessesGroupBox.Size = new System.Drawing.Size(200, 404);
            this.OpenProcessesGroupBox.TabIndex = 1;
            this.OpenProcessesGroupBox.TabStop = false;
            this.OpenProcessesGroupBox.Text = "Open Processes";
            // 
            // ProcessDataGrid
            // 
            this.ProcessDataGrid.AllowUserToAddRows = false;
            this.ProcessDataGrid.AllowUserToDeleteRows = false;
            this.ProcessDataGrid.AllowUserToResizeColumns = false;
            this.ProcessDataGrid.AllowUserToResizeRows = false;
            this.ProcessDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProcessDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProcessDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProcessDataGrid.Location = new System.Drawing.Point(6, 19);
            this.ProcessDataGrid.Name = "ProcessDataGrid";
            this.ProcessDataGrid.ReadOnly = true;
            this.ProcessDataGrid.RowHeadersVisible = false;
            this.ProcessDataGrid.ShowCellErrors = false;
            this.ProcessDataGrid.ShowEditingIcon = false;
            this.ProcessDataGrid.ShowRowErrors = false;
            this.ProcessDataGrid.Size = new System.Drawing.Size(188, 379);
            this.ProcessDataGrid.TabIndex = 0;
            // 
            // FileDialog
            // 
            this.FileDialog.InitialDirectory = "@\"C:\\\"";
            this.FileDialog.Title = "Select a DLL File";
            // 
            // InjectorGroupBox
            // 
            this.InjectorGroupBox.Controls.Add(this.SelectedProcessLabel);
            this.InjectorGroupBox.Controls.Add(this.DLLFileLabel);
            this.InjectorGroupBox.Controls.Add(this.SelectedProcessTextBox);
            this.InjectorGroupBox.Controls.Add(this.UploadDLLButton);
            this.InjectorGroupBox.Controls.Add(this.InjectDLLButton);
            this.InjectorGroupBox.Controls.Add(this.DLLFileTextBox);
            this.InjectorGroupBox.Location = new System.Drawing.Point(220, 75);
            this.InjectorGroupBox.Name = "InjectorGroupBox";
            this.InjectorGroupBox.Size = new System.Drawing.Size(192, 153);
            this.InjectorGroupBox.TabIndex = 2;
            this.InjectorGroupBox.TabStop = false;
            this.InjectorGroupBox.Text = "Injector";
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Location = new System.Drawing.Point(220, 301);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Size = new System.Drawing.Size(192, 178);
            this.StatusGroupBox.TabIndex = 3;
            this.StatusGroupBox.TabStop = false;
            this.StatusGroupBox.Text = "Status";
            // 
            // DLLFileTextBox
            // 
            this.DLLFileTextBox.Location = new System.Drawing.Point(5, 35);
            this.DLLFileTextBox.Name = "DLLFileTextBox";
            this.DLLFileTextBox.ReadOnly = true;
            this.DLLFileTextBox.Size = new System.Drawing.Size(182, 20);
            this.DLLFileTextBox.TabIndex = 0;
            // 
            // InjectDLLButton
            // 
            this.InjectDLLButton.Location = new System.Drawing.Point(98, 125);
            this.InjectDLLButton.Name = "InjectDLLButton";
            this.InjectDLLButton.Size = new System.Drawing.Size(89, 23);
            this.InjectDLLButton.TabIndex = 1;
            this.InjectDLLButton.Text = "Inject DLL";
            this.InjectDLLButton.UseVisualStyleBackColor = true;
            // 
            // UploadDLLButton
            // 
            this.UploadDLLButton.Location = new System.Drawing.Point(5, 125);
            this.UploadDLLButton.Name = "UploadDLLButton";
            this.UploadDLLButton.Size = new System.Drawing.Size(89, 23);
            this.UploadDLLButton.TabIndex = 2;
            this.UploadDLLButton.Text = "Choose DLL";
            this.UploadDLLButton.UseVisualStyleBackColor = true;
            this.UploadDLLButton.Click += new System.EventHandler(this.UploadDLLButton_Click);
            // 
            // SelectedProcessTextBox
            // 
            this.SelectedProcessTextBox.Location = new System.Drawing.Point(5, 85);
            this.SelectedProcessTextBox.Name = "SelectedProcessTextBox";
            this.SelectedProcessTextBox.ReadOnly = true;
            this.SelectedProcessTextBox.Size = new System.Drawing.Size(182, 20);
            this.SelectedProcessTextBox.TabIndex = 3;
            // 
            // DLLFileLabel
            // 
            this.DLLFileLabel.AutoSize = true;
            this.DLLFileLabel.Location = new System.Drawing.Point(2, 19);
            this.DLLFileLabel.Name = "DLLFileLabel";
            this.DLLFileLabel.Size = new System.Drawing.Size(46, 13);
            this.DLLFileLabel.TabIndex = 4;
            this.DLLFileLabel.Text = "DLL File\r\n";
            // 
            // SelectedProcessLabel
            // 
            this.SelectedProcessLabel.AutoSize = true;
            this.SelectedProcessLabel.Location = new System.Drawing.Point(2, 69);
            this.SelectedProcessLabel.Name = "SelectedProcessLabel";
            this.SelectedProcessLabel.Size = new System.Drawing.Size(90, 13);
            this.SelectedProcessLabel.TabIndex = 5;
            this.SelectedProcessLabel.Text = "Selected Process";
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.AutoInjectCheckBox);
            this.OptionsGroupBox.Controls.Add(this.CloseAfterInjectCheckBox);
            this.OptionsGroupBox.Location = new System.Drawing.Point(220, 229);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(192, 71);
            this.OptionsGroupBox.TabIndex = 4;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // CloseAfterInjectCheckBox
            // 
            this.CloseAfterInjectCheckBox.AutoSize = true;
            this.CloseAfterInjectCheckBox.Location = new System.Drawing.Point(5, 19);
            this.CloseAfterInjectCheckBox.Name = "CloseAfterInjectCheckBox";
            this.CloseAfterInjectCheckBox.Size = new System.Drawing.Size(106, 17);
            this.CloseAfterInjectCheckBox.TabIndex = 0;
            this.CloseAfterInjectCheckBox.Text = "Close After Inject";
            this.CloseAfterInjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoInjectCheckBox
            // 
            this.AutoInjectCheckBox.AutoSize = true;
            this.AutoInjectCheckBox.Location = new System.Drawing.Point(5, 43);
            this.AutoInjectCheckBox.Name = "AutoInjectCheckBox";
            this.AutoInjectCheckBox.Size = new System.Drawing.Size(77, 17);
            this.AutoInjectCheckBox.TabIndex = 1;
            this.AutoInjectCheckBox.Text = "Auto Inject";
            this.AutoInjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 491);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.StatusGroupBox);
            this.Controls.Add(this.InjectorGroupBox);
            this.Controls.Add(this.OpenProcessesGroupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.Text = "Simple Injector";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.OpenProcessesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDataGrid)).EndInit();
            this.InjectorGroupBox.ResumeLayout(false);
            this.InjectorGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox OpenProcessesGroupBox;
        private System.Windows.Forms.DataGridView ProcessDataGrid;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.GroupBox InjectorGroupBox;
        private System.Windows.Forms.GroupBox StatusGroupBox;
        private System.Windows.Forms.Button UploadDLLButton;
        private System.Windows.Forms.Button InjectDLLButton;
        private System.Windows.Forms.TextBox DLLFileTextBox;
        private System.Windows.Forms.TextBox SelectedProcessTextBox;
        private System.Windows.Forms.Label SelectedProcessLabel;
        private System.Windows.Forms.Label DLLFileLabel;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox AutoInjectCheckBox;
        private System.Windows.Forms.CheckBox CloseAfterInjectCheckBox;
    }
}

