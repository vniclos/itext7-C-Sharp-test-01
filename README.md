# ITEXT 7 - test-01
 Itext 7  c# integration text
 Example for general proposite, 
 
 integration of Itex 7 with microsoft visual stdudio , writed in C.
 
 
 - Itext 7 is distributed with licence AGPL , visit https://itextpdf.com/ for more information.
 - Visual studio Comunity is a free version software by Microsoft  visit https://visualstudio.microsoft.com for more information.
 
This example has two projects 
 
 - **testudines_pdf_lib.prj** : A small library for do interface with tex 7 more simple
 - **testudines_pdf_test.prj** : A small windows form software for testing the library.

you need install itext 7 NuGet packet as  extension for compile this sofware with Microsoft Visual Studio enviroment.

Here the code por simple use in windows form
``` c
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testudines.pdf;
namespace testudines_pdf_test
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            scnDirTemp.Text = System.IO.Path.GetTempPath();
        }



        private void ScnBtnTestOne_Click(object sender, EventArgs e)
        {
            scnFileNameTarget.Text = "Building Pdf...";
            ClsPdfBuilder oPdf = new ClsPdfBuilder(scnDirTemp.Text);
            oPdf.fnc_00_Start(scnDirTarget.Text, scnFileNameSort.Text,
                scnMetaTitle.Text, scnMetaAutor.Text, scnMetaCreator.Text, scnMetaKeyWords.Text, scnMetaSubject.Text);
            oPdf.fnc_AddTitle(1, scnDocTitle.Text);
            oPdf.fnc_AddText(scnDocTextLorem.Text);
            oPdf.fnc_AddTitle(2, scnDocTitle.Text+" 2");
            oPdf.fnc_AddText(scnDocTextLorem.Text);
            oPdf.fnc_99_End();
            scnFileNameTarget.Text = oPdf.FileNameTarget;
        }

     

        private void Label5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://itextpdf.com");
            Process.Start(sInfo);
        }

        private void ScnBtnTestOneOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(scnFileNameTarget.Text);
        }
``` c
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testudines.pdf;
namespace testudines_pdf_test
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            scnDirTemp.Text = System.IO.Path.GetTempPath();
        }



        private void ScnBtnTestOne_Click(object sender, EventArgs e)
        {
            scnFileNameTarget.Text = "Building Pdf...";
            ClsPdfBuilder oPdf = new ClsPdfBuilder(scnDirTemp.Text);
            oPdf.fnc_00_Start(scnDirTarget.Text, scnFileNameSort.Text,
                scnMetaTitle.Text, scnMetaAutor.Text, scnMetaCreator.Text, scnMetaKeyWords.Text, scnMetaSubject.Text);
            oPdf.fnc_AddTitle(1, scnDocTitle.Text);
            oPdf.fnc_AddText(scnDocTextLorem.Text);
            oPdf.fnc_AddTitle(2, scnDocTitle.Text+" 2");
            oPdf.fnc_AddText(scnDocTextLorem.Text);
            oPdf.fnc_99_End();
            scnFileNameTarget.Text = oPdf.FileNameTarget;
        }

     

        private void Label5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://itextpdf.com");
            Process.Start(sInfo);
        }

        private void ScnBtnTestOneOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(scnFileNameTarget.Text);
        }

    
    }
}

}
}

 
 The library code

```
/*
 CONVENTION 
 1 variables of classs start in m_
 2  get function of variables are like variables name without m_
 3 functions of class start with fnc for diference of functions
   of other libraries
 4 

 // study samples
 https://stackoverflow.com/questions/50445436/itext7-end-page-events-are-called-when-document-is-closed?noredirect=1&lq=1

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iText.IO.Font;
using iText.Kernel.Geom;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
namespace testudines.pdf
{
    public class ClsPdfBuilder
    {
        private String m_DirTemp = "";
        private String m_DirTarget = "";
        private String m_FileNameSort;
        private String m_FileNameTemp = "";
        private String m_FileNameTarget = "";
        public String  FileNameTarget { get { return m_FileNameTarget; } }

        private string m_DocMetaTitle = "";
        public String DocMetaTitle { get { return m_DocMetaTitle; } }
        private String m_DocMetaAuthor = "";
        public String DocMetaAuthor { get { return m_DocMetaAuthor; } }
        private string m_DocMetaCreator = "";
        public String DocMetaCreator { get { return m_DocMetaCreator; } }
        private String m_DocMetaKeyWords = "";
        public String DocMetaKeyWords { get { return m_DocMetaKeyWords; } }
        private string m_DocMetaSubject = "";
        public String DocMetaSubject { get { return m_DocMetaSubject; } }

        private bool m_IsError = false;
        /// <summary>
        /// Return "" if the las operatiorn has not error else
        /// return error message
        /// </summary>
        public bool IsError { get { return m_IsError; } }
        /// <summary>
        /// Return true if the las operation has error else false
        /// </summary>
        private String m_ErrorMsg = "";
        public String ErrorMsg { get { return m_ErrorMsg; } }
        private PdfFont m_font_Helv = PdfFontFactory.CreateFont(FontConstants.HELVETICA);
        private PdfFont m_font_HelvBold = PdfFontFactory.CreateFont(FontConstants.HELVETICA);
        private PdfFont m_font_Times = PdfFontFactory.CreateFont(FontConstants.TIMES_ROMAN);

        private PdfWriter m_PdfWriter;
        private PdfDocument m_PdfDoc;
        private Document m_Document;
        private PdfDocumentInfo m_info;

        /// <summary>
        /// Constructor, 
        /// </summary>
        /// <param name="pDirTemp"> Directory where create temporal files</param>
        public ClsPdfBuilder(String pDirTemp)
        {
            m_DirTemp = pDirTemp;
        }
        ~ClsPdfBuilder() { }

        /// <summary>
        /// Start new pdf, create try create enviroment and objects
        /// </summary>
        /// <param name="pDirTarget">Directory where copy pdf at the end process</param>
        /// <param name="pFileNameSort">Short filenae of pdf like helloworld.pdf</param>
        /// <param name="pDocMetaTitle">Short filenae of pdf like helloworld.pdf</param>
        /// <param name="pDocMetaAuthor">Autor of file</param>
        /// <param name="pDocMetaCreator">Cretor of file</param>
        /// <param name="pDocMetaKeyWords">Separeted coma values</param>
        /// <param name="pDocMetaSubject">Litle description</param>
        public bool fnc_00_Start(String pDirTarget, String pFileNameSort, String pDocMetaTitle, String pDocMetaAuthor, String pDocMetaCreator, String pDocMetaKeyWords, String pDocMetaSubject)
        {
            fncToolClearLastError();
            m_DirTarget = pDirTarget;
            m_FileNameSort = pFileNameSort;
            m_DocMetaTitle = pDocMetaTitle;
            m_DocMetaAuthor = pDocMetaAuthor;
            m_DocMetaCreator = pDocMetaCreator;
            m_DocMetaKeyWords = pDocMetaKeyWords;
            m_DocMetaSubject = pDocMetaSubject;
            m_FileNameTemp = fncToolPathCombine(m_DirTemp, pFileNameSort);
            m_FileNameTarget = fncToolPathCombine(pDirTarget, pFileNameSort);
            // creation global objects, and directories ... and set metas
            try
            {
                System.IO.Directory.CreateDirectory(m_DirTemp);
                System.IO.Directory.CreateDirectory(pDirTarget);
                if (System.IO.File.Exists(m_FileNameTemp)) { System.IO.File.Delete(m_FileNameTemp); }
                m_PdfWriter = new PdfWriter(m_FileNameTemp);
                m_PdfDoc = new PdfDocument(m_PdfWriter);
                m_info=m_PdfDoc.GetDocumentInfo();
                m_info.SetTitle ( m_DocMetaTitle);
                m_info.SetAuthor(pDocMetaAuthor);
                m_info.SetCreator(pDocMetaCreator);
                m_info.SetKeywords(pDocMetaKeyWords);
                m_info.SetSubject(pDocMetaSubject);


                m_Document = new Document(m_PdfDoc, PageSize.A4);
            }
            catch (Exception xcpt)
            {
                m_IsError = true;
                m_ErrorMsg = xcpt.Message;
            }

            return !m_IsError;
        }

        public void fnc_AddTitle(uint pItem, String pTitle)
        {
            Paragraph p = new Paragraph();
            Text tItem = new Text(pItem.ToString() + ".-   ");
            Text tTitle = new Text(pTitle.Trim());
            tItem.SetFontSize(12);
            //tItem.SetBold();
            tItem.SetFont(m_font_Times);

            tTitle.SetFont(m_font_Times);
            tTitle.SetFontSize(12);
            tTitle.SetBold();
            p.SetBorderBottom(new iText.Layout.Borders.SolidBorder(1));
            p.Add(tItem);
            p.Add(tTitle);

            m_Document.Add(p);
        }
        public void fnc_AddText(String pText)
        {
            m_Document.Add(new Paragraph(pText));
        }
        /// <summary>
        /// Close temporal document and try to copy to 
        /// target , may be excption if target document 
        /// is in use, cant access...
        /// </summary>
        /// <returns>true if all is ok else false
        /// if error the mesage are saved in ErrorMsg
        /// </returns>
        public bool fnc_99_End()
        {
            fncToolClearLastError();
            m_Document.Close();
            try
            {
                System.IO.File.Copy(m_FileNameTemp, m_FileNameTarget, true);
            }
            catch (Exception xcpt)
            {
                m_IsError = true;
                m_ErrorMsg = xcpt.Message;
            }

            return m_IsError;
        }
        /// <summary>
        ///  Build full file path, combine directory and filename short with 
        ///  some prevention of errors like // or not end in .pdf
        /// </summary>
        /// <param name="pDir"> Directory</param>
        /// <param name="pFilenameShort">File name short</param>
        /// <returns>Full file path</returns>
        private String fncToolPathCombine(String pDir, String pFilenameShort)
        {
            String fullPath = pDir.Trim().Replace("\\", "/"); // normalization
            if (!fullPath.EndsWith("/")) { fullPath += "/"; }
            if (!pFilenameShort.ToLower().EndsWith(".pdf")) { pFilenameShort += ".pdf"; }
            fullPath += pFilenameShort;
            return fullPath;
        }
        /// <summary>
        /// Reset before errror flags saved in the variables
        /// m_IsError and m_ErrorMsg
        /// </summary>
        private void fncToolClearLastError() { m_ErrorMsg = ""; m_IsError = false; }






    }

}
 ```
 
 
 
