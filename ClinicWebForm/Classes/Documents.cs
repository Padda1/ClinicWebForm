using ClinicWebForm.Models;
using ClinicWebForm.Utils;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Classes
{
    public class Documents
    {
        //private string directory = @"C:\Users\pnoke\Documents\Visual Studio 2013\Projects\ClinicWebForm\ClinicWebForm\DocumentTemplates\";

        public string HouseholdRegistrationForm(Health health)
        {
            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document WordDoc = appWord.Documents.Open(AppUtils.WordTemplateDirectory + @"HouseholdRegistrationForm.docx", ReadOnly: false, Visible: true);

            WordDoc.Activate();

            foreach (Bookmark bookMark in WordDoc.Bookmarks)
            {
                if (bookMark.Name == "OfficialHouseRegNo")
                {
                    //bookMark.Range.Text = health.OfficialHouseRegNo;
                    bookMark.Range.Text = health.OFFICIAL_HOUSE_REG_NO;
                }

                if (bookMark.Name == "ChwIdNo")
                {
                    //bookMark.Range.Text = health.ChwIdNo;
                    bookMark.Range.Text = health.CHW_ID_NO;
                }

                if (bookMark.Name == "DateOfVisit")
                {
                    //bookMark.Range.Text = health.DateOfVisit.ToString("yyyy-MM-dd");
                    bookMark.Range.Text = health.DATE_OF_VISIT;
                }
            }

            string pdfName = AppUtils.WordTemplateDirectory + @"HouseholdRegistrationForm.pdf";
            WordDoc.ExportAsFixedFormat(pdfName, WdExportFormat.wdExportFormatPDF);

            object saveOption = WdSaveOptions.wdDoNotSaveChanges;
            object originalFormat = WdOriginalFormat.wdOriginalDocumentFormat;
            object routeDocument = false;

            WordDoc.Close(ref saveOption, ref originalFormat, ref routeDocument);
            appWord.Quit();
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(appWord);

            return pdfName;
        }
    }
}