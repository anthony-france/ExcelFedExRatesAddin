using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using System.Net;
using System.IO;
using System.Collections;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace FedExShipToolsAddin
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnInsertRateSingle_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Range selectedRange = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;

            FedEx fe = new FedEx(
                "meterno",
                "acctno",
                "apikey",
                "apipassword"
            );

            if (txtPackageWeight.Text.Trim().Length == 0 || txtPackageWeight.Text == "0")
            {
                txtPackageWeight.Text = "1";
            }

            if (txtOriginZip.Text.Trim().Length != 5)
            {
                MessageBox.Show("Please set a valid origin zip code.");
                return;
            }

            if (txtDestinationZip.Text.Trim().Length != 5)
            {
                MessageBox.Show("Please set a valid destination zip code.");
                return;
            }

            if (txtOriginCountry.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please set a valid origin country code.");
                return;
            }

            if (txtDestinationCountry.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please set a valid destination country code.");
                return;
            }

            try
            {
                selectedRange.Value2 = fe.GetRate(
                    txtPackageWeight.Text.ToString(),
                    txtOriginZip.Text.ToString(),
                    txtOriginCountry.Text.ToString(),
                    txtDestinationZip.Text.ToString(),
                    txtDestinationCountry.Text.ToString(),
                    selectServiceType.SelectedItem.ToString()
                );
            }
            catch
            {
                selectedRange.Value2 = "err";
            }
        }

        private void btnSetDestinationRange_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Tools.Excel.Worksheet worksheet =
                Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);

            Excel.Range selectedRange = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
            selectedRange.Name = "SHIPTOOLS_Destination";
        }

        private void btnSetOutputRange_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Tools.Excel.Worksheet worksheet =
                Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);

            Excel.Range selectedRange = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
            selectedRange.Name = "SHIPTOOLS_Output";
        }

        private void btnSetOriginRange_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Tools.Excel.Worksheet worksheet =
                 Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1]);

            Excel.Range selectedRange = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
            selectedRange.Name = "SHIPTOOLS_Origin";
        }

        private void btnInsetRateMatrix_Click(object sender, RibbonControlEventArgs e)
        {
            //Setup variables
            Excel.Worksheet worksheet = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;
            Excel.Range rngOrigin;
            Excel.Range rngDestination;

            try
            {
                rngOrigin = worksheet.get_Range("SHIPTOOLS_Origin");
            }
            catch
            {
                MessageBox.Show("Please setup the origin range before using the autofill.");
                return;
            }

            try
            {
                rngDestination = worksheet.get_Range("SHIPTOOLS_Destination");
            }
            catch
            {
                MessageBox.Show("Please setup the destination range before using the autofill.");
                return;
            }

            if (rngOrigin.Rows.Count * rngDestination.Columns.Count <= 0)
            {
                MessageBox.Show("No cells to fill.");
                return;
            }

            //Setup FedEx Object.
            FedEx fe = new FedEx(
                "meterno",
                "acctno",
                "apikey",
                "apipassword"
            );

            // Check to see if package weight was set, needs to be at least 1.
            if (txtPackageWeight.Text == "" || txtPackageWeight.Text == "0")
            {
                txtPackageWeight.Text = "1";
            }

            foreach (Excel.Range rngRow in rngOrigin.Rows)
            {
                foreach (Excel.Range rngCol in rngDestination.Columns)
                {
                    //Setup Variables
                    int intCol = rngCol.Column, intRow = rngRow.Row;
                    Excel.Range rngOutput = worksheet.Cells[intRow, intCol];

                    //Fill in output cell with fedex rate quote.
                    try
                    {
                        rngOutput.Value2 = fe.GetRate(
                            txtPackageWeight.Text.ToString(),
                            System.Convert.ToString(rngRow.Value2),
                            "US",
                            System.Convert.ToString(rngCol.Value2),
                            "US",
                            selectServiceType.SelectedItem.ToString()
                        );
                    }
                    catch
                    {
                        rngOutput.Value2 = "err";
                    }
                    rngOutput.Show();

                    // Don't hammer the server, wait 1/4 of a second between each request.
                    System.Threading.Thread.Sleep(250);

                } //end rngCol foreach
            } // end rngRow foreach
        }
    }
}
