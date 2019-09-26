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

 
 

```
 
 
