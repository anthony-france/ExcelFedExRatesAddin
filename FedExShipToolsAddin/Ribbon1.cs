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
                "AccountNo",
                "MeterNo",
                "APIKEY",
                "APIPassword"
            );
            
            selectedRange.Value2 = fe.GetRate(
                txtPackageWeight.Text.ToString(), 
                txtOriginZip.Text.ToString(), 
                txtOriginCounty.Text.ToString(), 
                txtDestinationZip.Text.ToString(), 
                txtDestinationCountry.Text.ToString(), 
                selectServiceType.SelectedItem.ToString()
            );
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
            
            Excel.Worksheet worksheet = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;
            
            Excel.Range rngOrigin = worksheet.get_Range("SHIPTOOLS_Origin");
            Excel.Range rngDestination = worksheet.get_Range("SHIPTOOLS_Destination");

            FedEx fe = new FedEx(
                "AccountNo",
                "MeterNo",
                "APIKEY",
                "APIPassword"
            );

            if (txtPackageWeight.Text == "" || txtPackageWeight.Text == "0") 
            {
                txtPackageWeight.Text = "2";
            }

            foreach (Excel.Range rngRow in rngOrigin.Rows) 
            {
                foreach (Excel.Range rngCol in rngDestination.Columns)
                {
                    int intCol = rngCol.Column, intRow = rngRow.Row;
                    Excel.Range rngOutput = worksheet.Cells[intRow, intCol];
                    rngOutput.Value2 = fe.GetRate(
                        txtPackageWeight.Text.ToString(),
                        System.Convert.ToString(rngRow.Value2),
                        "US",
                        System.Convert.ToString(rngCol.Value2),
                        "US",
                        selectServiceType.SelectedItem.ToString()
                    );


                }
            }

        }

    }
}
