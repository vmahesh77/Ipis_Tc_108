﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArecaIPIS.Classes;
using ArecaIPIS.DAL;

namespace ArecaIPIS.Forms
{
    public partial class frmDataLogReport : Form
    {
        private PaginationHelperClass paginationHelper;
        private DataTable reportData;
        private const string PlaceholderText = "Search here...";
        DatalogReportDb datalogReportDb = new DatalogReportDb();
        private int initialDataGridViewHeight;

        public frmDataLogReport()
        {
            InitializeComponent();

            dtpFrom.CustomFormat = " ";
            dtpTo.CustomFormat = " ";
            reportData = new DataTable();
            initialDataGridViewHeight = dGVDataLogReport.Height;
        }
        private void frmDataLogReport_Load(object sender, EventArgs e)
        {
            cmbExport.SelectedIndex = 0;
            dGVDataLogReport.EnableHeadersVisualStyles = false;
            dGVDataLogReport.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
            cdtpFrom.DateTimeSelected += cdtpFrom_DateTimeSelected;
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                cdtpFrom.Visible = false;
                string fromtxt = txtFromdate.Text;
                string totxt = txtToDate.Text;
                DateTime? fromValue = null;
                DateTime? toValue = null;
                if (!string.IsNullOrEmpty(fromtxt) && !string.IsNullOrEmpty(totxt))
                {
                    fromValue = (DateTime.Parse(fromtxt));
                    toValue = (DateTime.Parse(totxt));
                }

                if (txtFromdate.Text == "" || txtToDate.Text == "")
                {
                    MessageBox.Show("Please Select from and to Date");
                }
                else if (fromValue > toValue)
                {
                    MessageBox.Show("Please Select To-Date greater than From-Date");
                }
                else if (fromValue == toValue)
                {
                    MessageBox.Show("From-DateTime and To-DateTime can't be same");
                }
                else
                {
                    txtSearch.Text = PlaceholderText;
                    txtSearch.ForeColor = Color.Gray;
                    cmbExport.SelectedIndex = 0;
                    dGVDataLogReport.Visible = true;
                    pnlPagination.Visible = true;

                    string fromDate = txtFromdate.Text;
                    string toDate = txtToDate.Text;
                    showData(fromDate, toDate);


                    pnlNoDisplay.Visible = false;
                    txtSearch.Visible = true;
                    btnSearch.Visible = true;
                    btnDropdown.Visible = true;

                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }

        private void UpdateDataGridView()
        {
            try
            {


                DataTable currentPageData = paginationHelper.GetCurrentPageData();

                dGVDataLogReport.AutoGenerateColumns = true;
                dGVDataLogReport.DataSource = currentPageData;

                int dataGridViewNewHeight;

                // Adjust the height of the DataGridView
                if (currentPageData.Rows.Count < visibleRowsCount)
                {
                    dataGridViewNewHeight = (currentPageData.Rows.Count * dGVDataLogReport.RowTemplate.Height)
                                            + dGVDataLogReport.ColumnHeadersHeight
                                            + 2;
                }
                else
                {
                    dataGridViewNewHeight = (visibleRowsCount * dGVDataLogReport.RowTemplate.Height)
                                            + dGVDataLogReport.ColumnHeadersHeight
                                            + 2;
                }


                dGVDataLogReport.Height = dataGridViewNewHeight;

                //float widthPercentage = (float)dGVDataLogReport.Width / currentPageData.Columns.Count;

                //foreach (DataGridViewColumn column in dGVDataLogReport.Columns)
                //{
                //    column.Width = (int)widthPercentage;
                //}

                if (dGVDataLogReport.Columns.Count > 0)
                {
                    float totalWidth = dGVDataLogReport.Width;

                    int firstColumnWidth = 80;

                    float remainingWidth = totalWidth - firstColumnWidth;

                    if (dGVDataLogReport.Columns.Count > 2)
                    {
                        float widthPercentage = remainingWidth / (dGVDataLogReport.Columns.Count - 1);

                        dGVDataLogReport.Columns[0].Width = firstColumnWidth;

                        for (int i = 1; i < dGVDataLogReport.Columns.Count; i++)
                        {
                            dGVDataLogReport.Columns[i].Width = (int)widthPercentage;
                        }
                    }

                }
                paginationHelper.UpdatePaginationControls(pnlPagination, OnPageChanged);
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }
        private void OnPageChanged(int page)
        {
            paginationHelper.LoadDataForPage(page);
            UpdateDataGridView();

        }


        int visibleRowsCount = 0;

        public void showData( string fromDate, string toDate)
        {
            try
            {

                DataTable DatalogReports = datalogReportDb.GetDataLogReport(fromDate, toDate);


                dGVDataLogReport.Columns.Clear();

                if (DatalogReports != null && DatalogReports.Rows.Count > 0)
                {
                    dGVDataLogReport.AutoGenerateColumns = true;
                    reportData.Clear();
                    reportData.Columns.Clear();
                    dGVDataLogReport.Height = initialDataGridViewHeight;

                    reportData = DatalogReports.Copy();
                    visibleRowsCount = (dGVDataLogReport.Height / dGVDataLogReport.RowTemplate.Height) - 1;

                    paginationHelper = new PaginationHelperClass(reportData, visibleRowsCount);
                    UpdateDataGridView();


                    lblNoDataDisplay.Visible = false;
                    pnlPagination.Visible = true;
                }
                else
                {
                    lblNoDataDisplay.Visible = true;
                    pnlPagination.Visible = false;


                    reportData = DatalogReports.Copy();

                    foreach (DataColumn column in DatalogReports.Columns)
                    {
                        dGVDataLogReport.Columns.Add(column.ColumnName, column.ColumnName);
                        dGVDataLogReport.Columns[column.ColumnName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    dGVDataLogReport.DataSource = null;

                }
                chkFilter.Items.Clear();
                foreach (DataColumn column in reportData.Columns)
                {

                    chkFilter.Items.Add(column.ColumnName);

                }

                for (int i = 0; i < chkFilter.Items.Count; i++)
                {
                    chkFilter.SetItemChecked(i, true);
                    chkFilter.BackColor = Color.LightSalmon;
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }

        private List<string> selectedColumns = new List<string>();
        private void PerformSearchAndFilter(string searchText)
        {
            try
            {


                DataTable filteredDataTable = reportData.Clone();

                string searchLowerCase = searchText.ToLower();

                foreach (DataRow row in reportData.Rows)
                {
                    bool matchFound = false;

                    foreach (string column in selectedColumns)
                    {
                        string cellValue = row[column].ToString().ToLower();

                        if (cellValue.Contains(searchLowerCase))
                        {
                            matchFound = true;
                            break;
                        }
                    }

                    if (matchFound)
                    {
                        filteredDataTable.ImportRow(row);

                    }
                }
                paginationHelper = new PaginationHelperClass(filteredDataTable, visibleRowsCount);
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }

        private string previousSearchText = string.Empty;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtSearch.Text == PlaceholderText)
                {
                    return;
                }

                if (reportData.Rows.Count == 0)
                {
                    dGVDataLogReport.Columns.Clear();
                    btnCross.Visible = true;
                    btnSearch.Visible = false;

                    lblNoDataDisplay.Visible = true;
                    pnlPagination.Visible = false;

                    foreach (DataColumn column in reportData.Columns)
                    {
                        dGVDataLogReport.Columns.Add(column.ColumnName, column.ColumnName);
                        dGVDataLogReport.Columns[column.ColumnName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    dGVDataLogReport.DataSource = null;

                    return;
                }

                string searchText = txtSearch.Text.Trim();
                selectedColumns.Clear();

                foreach (var item in chkFilter.CheckedItems)
                {
                    string columnName = item.ToString();

                    if (!selectedColumns.Contains(columnName))
                    {
                        selectedColumns.Add(columnName);
                    }
                }

                if (searchText != previousSearchText)
                {
                    PerformSearchAndFilter(searchText);
                    previousSearchText = searchText;
                }


                bool matchFound = CheckIfDataMatchesSearch();
                lblNoDataDisplay.Visible = !matchFound;


                btnCross.Visible = true;
                btnSearch.Visible = false;



                bool CheckIfDataMatchesSearch()
                {
                    if (string.IsNullOrWhiteSpace(searchText))
                    {
                        return true;
                    }

                    searchText = searchText.ToLower();

                    foreach (DataRow row in reportData.Rows)
                    {
                        foreach (string column in selectedColumns)
                        {
                            string cellValue = row[column].ToString().ToLower();

                            if (cellValue.Contains(searchText))
                            {
                                return true;
                            }
                        }
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }



        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = dtpFrom.Value;
                txtFromdate.Text = dt.ToString("dd-MMM-yy HH:mm:ss");
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = dtpTo.Value;
                txtToDate.Text = dt.ToString("dd-MMM-yy HH:mm:ss");
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }



        public static bool chkvisible = true;
        private void btnDropdown_Click(object sender, EventArgs e)
        {
            try
            {


                if (chkvisible)
                {
                    chkFilter.Visible = true;
                    chkvisible = false;
                }
                else
                {
                    chkFilter.Visible = false;
                    chkvisible = true;
                }

            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            try
            {

                txtSearch.Text = PlaceholderText;
                txtSearch.ForeColor = Color.Gray;
                if (reportData.Rows.Count != 0)
                {
                    paginationHelper = new PaginationHelperClass(reportData, 9);
                    UpdateDataGridView();
                    lblNoDataDisplay.Visible = false;
                    btnCross.Visible = false;
                    btnSearch.Visible = true;
                }
                else
                {
                    lblNoDataDisplay.Visible = true;
                    btnCross.Visible = false;
                    btnSearch.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            try
            {

                if (txtSearch.Text == PlaceholderText)
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = PlaceholderText;
                    txtSearch.ForeColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnCross.Visible = true;
            btnSearch.Visible = false;
        }

        private void chkDatalogFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
         
        }

        private void chkDatalogFilter_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void chkDatalogFilter_Leave(object sender, EventArgs e)
        {
            chkFilter.Visible = false;
        }

        private void pnlNoDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDataLogReport_Leave(object sender, EventArgs e)
        {
            chkFilter.Visible = false;
        }

        private void chkDatalogFilter_MouseLeave(object sender, EventArgs e)
        {
            chkFilter.Visible = false;
        }

        private void cmbExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedOption = cmbExport.SelectedItem.ToString().ToUpper();
                switch (selectedOption)
                {
                    case "PDF":
                        SaveFileDialogForPDF();
                        break;
                    case "XLSX":
                        SaveFileDialogForExcel(".xlsx");
                        break;
                    case "XLS":
                        SaveFileDialogForExcel(".xls");
                        break;
                        //default:
                        //    MessageBox.Show("Invalid export option selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    break;
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }

        private void SaveFileDialogForPDF()
        {
            try
            {
                if (reportData != null && reportData.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";


                    string fixedDirectory = @"C:\Reports\";
                    if (!Directory.Exists(fixedDirectory))
                    {
                        Directory.CreateDirectory(fixedDirectory);
                    }


                    sfd.InitialDirectory = fixedDirectory;

                    string fileName = "DataLogReport" + DateTime.Now.ToString("_" + "dd" + "_" + "MM" + "_" + "yyyy" + "_" + "HH" + "_" + "mm" + "_" + "ss") + ".pdf";
                    sfd.FileName = fileName;
                    string header = "DataLog Report";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        ExportPDFClass.ExportToPDF(sfd.FileName, header, reportData);
                    }
                }
                else
                {
                    MessageBox.Show("No data available to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }


        private void SaveFileDialogForExcel(string extension)
        {
            try
            {
                if (reportData != null && reportData.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";

                    string fixedDirectory = @"C:\Reports\";
                    if (!Directory.Exists(fixedDirectory))
                    {
                        Directory.CreateDirectory(fixedDirectory);
                    }


                    sfd.InitialDirectory = fixedDirectory;


                    string fileName = "DataLogReport" + DateTime.Now.ToString("_" + "dd" + "_" + "MM" + "_" + "yyyy" + "_" + "HH" + "_" + "mm" + "_" + "ss") + extension; // Change file extension to .xlsx
                    sfd.FileName = fileName;
                    string header = "DataLog Report";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (extension == ".xls")
                        {
                            ExportPDFClass.ExportToExcel(sfd.FileName, header, reportData);
                        }
                        else
                        {
                            ExportPDFClass.ExportToExcel(sfd.FileName, header, reportData);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data available to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }
        }
        private bool isToDateDMRClicked = false;
        private void txtFromdate_Click(object sender, EventArgs e)
        {
            cdtpFrom.Reset();
            isToDateDMRClicked = false;
            cdtpFrom.Location = new Point(65, 44);
            cdtpFrom.Visible = true;
        }

        private void txtToDate_Click(object sender, EventArgs e)
        {
            cdtpFrom.Reset();
            isToDateDMRClicked = true;
            cdtpFrom.Location = new Point(340, 44);
            cdtpFrom.Visible = true;
        }

        private void cdtpFrom_DateTimeSelected(object sender, string finalDateTimeString)
        {

            if (isToDateDMRClicked)
            {
                txtToDate.Text = finalDateTimeString;
            }
            else
            {
                txtFromdate.Text = finalDateTimeString;
            }
        }

        private void cmbExport_Click(object sender, EventArgs e)
        {
            cdtpFrom.Visible = false;
        }

        private void dGVDataLogReport_Click(object sender, EventArgs e)
        {
            cdtpFrom.Visible = false;
        }

        private void pnlNoDisplay_Click(object sender, EventArgs e)
        {
            cdtpFrom.Visible = false;
        }

        private void pnlDataLogReport_Click(object sender, EventArgs e)
        {
            cdtpFrom.Visible = false;
        }
    }
}
