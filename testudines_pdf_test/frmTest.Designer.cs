namespace testudines_pdf_test
{
    partial class frmTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.scnFileNameTarget = new System.Windows.Forms.TextBox();
            this.scnFileNameSort = new System.Windows.Forms.TextBox();
            this.scnDirTarget = new System.Windows.Forms.TextBox();
            this.scnDirTemp = new System.Windows.Forms.TextBox();
            this.scnFileNameSortTit = new System.Windows.Forms.Label();
            this.scnDirTargetTit = new System.Windows.Forms.Label();
            this.scnDirTempTit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scnMetaCreator = new System.Windows.Forms.TextBox();
            this.scnMetaCreatorTit = new System.Windows.Forms.Label();
            this.scnMetaSubject = new System.Windows.Forms.TextBox();
            this.scnMetaSubjectTit = new System.Windows.Forms.Label();
            this.scnMetaKeyWords = new System.Windows.Forms.TextBox();
            this.sccnMetaKeywordsTit = new System.Windows.Forms.Label();
            this.scnMetaAutor = new System.Windows.Forms.TextBox();
            this.scnMetaAuthorTit = new System.Windows.Forms.Label();
            this.scnMetaTitle = new System.Windows.Forms.TextBox();
            this.scnMetaTitleTit = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scnBtnTestOneOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scnBtnTestOne = new System.Windows.Forms.Button();
            this.scnDocTextLorem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scnDocTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.scnFileNameTarget);
            this.groupBox1.Controls.Add(this.scnFileNameSort);
            this.groupBox1.Controls.Add(this.scnDirTarget);
            this.groupBox1.Controls.Add(this.scnDirTemp);
            this.groupBox1.Controls.Add(this.scnFileNameSortTit);
            this.groupBox1.Controls.Add(this.scnDirTargetTit);
            this.groupBox1.Controls.Add(this.scnDirTempTit);
            this.groupBox1.Location = new System.Drawing.Point(32, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories and file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pdf Created";
            // 
            // scnFileNameTarget
            // 
            this.scnFileNameTarget.BackColor = System.Drawing.SystemColors.Info;
            this.scnFileNameTarget.Location = new System.Drawing.Point(140, 119);
            this.scnFileNameTarget.Name = "scnFileNameTarget";
            this.scnFileNameTarget.ReadOnly = true;
            this.scnFileNameTarget.Size = new System.Drawing.Size(363, 20);
            this.scnFileNameTarget.TabIndex = 11;
            // 
            // scnFileNameSort
            // 
            this.scnFileNameSort.Location = new System.Drawing.Point(140, 92);
            this.scnFileNameSort.Name = "scnFileNameSort";
            this.scnFileNameSort.Size = new System.Drawing.Size(363, 20);
            this.scnFileNameSort.TabIndex = 10;
            this.scnFileNameSort.Text = "helloworld.pdf";
            // 
            // scnDirTarget
            // 
            this.scnDirTarget.Location = new System.Drawing.Point(140, 61);
            this.scnDirTarget.Name = "scnDirTarget";
            this.scnDirTarget.Size = new System.Drawing.Size(363, 20);
            this.scnDirTarget.TabIndex = 9;
            this.scnDirTarget.Text = "c:\\pdf\\target";
            // 
            // scnDirTemp
            // 
            this.scnDirTemp.Location = new System.Drawing.Point(140, 28);
            this.scnDirTemp.Name = "scnDirTemp";
            this.scnDirTemp.Size = new System.Drawing.Size(363, 20);
            this.scnDirTemp.TabIndex = 8;
            this.scnDirTemp.Text = "c:\\pdf\\temp";
            // 
            // scnFileNameSortTit
            // 
            this.scnFileNameSortTit.AutoSize = true;
            this.scnFileNameSortTit.Location = new System.Drawing.Point(12, 92);
            this.scnFileNameSortTit.Name = "scnFileNameSortTit";
            this.scnFileNameSortTit.Size = new System.Drawing.Size(80, 13);
            this.scnFileNameSortTit.TabIndex = 3;
            this.scnFileNameSortTit.Text = "File Name short";
            // 
            // scnDirTargetTit
            // 
            this.scnDirTargetTit.AutoSize = true;
            this.scnDirTargetTit.Location = new System.Drawing.Point(12, 64);
            this.scnDirTargetTit.Name = "scnDirTargetTit";
            this.scnDirTargetTit.Size = new System.Drawing.Size(80, 13);
            this.scnDirTargetTit.TabIndex = 2;
            this.scnDirTargetTit.Text = "DirectoryTarget";
            // 
            // scnDirTempTit
            // 
            this.scnDirTempTit.AutoSize = true;
            this.scnDirTempTit.Location = new System.Drawing.Point(12, 35);
            this.scnDirTempTit.Name = "scnDirTempTit";
            this.scnDirTempTit.Size = new System.Drawing.Size(92, 13);
            this.scnDirTempTit.TabIndex = 1;
            this.scnDirTempTit.Text = "Directory temporal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scnMetaCreator);
            this.groupBox2.Controls.Add(this.scnMetaCreatorTit);
            this.groupBox2.Controls.Add(this.scnMetaSubject);
            this.groupBox2.Controls.Add(this.scnMetaSubjectTit);
            this.groupBox2.Controls.Add(this.scnMetaKeyWords);
            this.groupBox2.Controls.Add(this.sccnMetaKeywordsTit);
            this.groupBox2.Controls.Add(this.scnMetaAutor);
            this.groupBox2.Controls.Add(this.scnMetaAuthorTit);
            this.groupBox2.Controls.Add(this.scnMetaTitle);
            this.groupBox2.Controls.Add(this.scnMetaTitleTit);
            this.groupBox2.Location = new System.Drawing.Point(32, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 156);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meta tags";
            // 
            // scnMetaCreator
            // 
            this.scnMetaCreator.Location = new System.Drawing.Point(123, 69);
            this.scnMetaCreator.Name = "scnMetaCreator";
            this.scnMetaCreator.Size = new System.Drawing.Size(380, 20);
            this.scnMetaCreator.TabIndex = 21;
            this.scnMetaCreator.Text = "Author names, ";
            // 
            // scnMetaCreatorTit
            // 
            this.scnMetaCreatorTit.AutoSize = true;
            this.scnMetaCreatorTit.Location = new System.Drawing.Point(12, 70);
            this.scnMetaCreatorTit.Name = "scnMetaCreatorTit";
            this.scnMetaCreatorTit.Size = new System.Drawing.Size(41, 13);
            this.scnMetaCreatorTit.TabIndex = 20;
            this.scnMetaCreatorTit.Text = "Creator";
            // 
            // scnMetaSubject
            // 
            this.scnMetaSubject.Location = new System.Drawing.Point(122, 121);
            this.scnMetaSubject.Name = "scnMetaSubject";
            this.scnMetaSubject.Size = new System.Drawing.Size(381, 20);
            this.scnMetaSubject.TabIndex = 19;
            this.scnMetaSubject.Tag = "";
            this.scnMetaSubject.Text = "This is my first tray for testing ITEXT 7 a pdf friendly enviroment";
            // 
            // scnMetaSubjectTit
            // 
            this.scnMetaSubjectTit.AutoSize = true;
            this.scnMetaSubjectTit.Location = new System.Drawing.Point(10, 124);
            this.scnMetaSubjectTit.Name = "scnMetaSubjectTit";
            this.scnMetaSubjectTit.Size = new System.Drawing.Size(43, 13);
            this.scnMetaSubjectTit.TabIndex = 18;
            this.scnMetaSubjectTit.Text = "Subject";
            // 
            // scnMetaKeyWords
            // 
            this.scnMetaKeyWords.Location = new System.Drawing.Point(122, 95);
            this.scnMetaKeyWords.Name = "scnMetaKeyWords";
            this.scnMetaKeyWords.Size = new System.Drawing.Size(381, 20);
            this.scnMetaKeyWords.TabIndex = 17;
            this.scnMetaKeyWords.Tag = "";
            this.scnMetaKeyWords.Text = "Itext 7, C#, testing ";
            // 
            // sccnMetaKeywordsTit
            // 
            this.sccnMetaKeywordsTit.AutoSize = true;
            this.sccnMetaKeywordsTit.Location = new System.Drawing.Point(9, 95);
            this.sccnMetaKeywordsTit.Name = "sccnMetaKeywordsTit";
            this.sccnMetaKeywordsTit.Size = new System.Drawing.Size(53, 13);
            this.sccnMetaKeywordsTit.TabIndex = 16;
            this.sccnMetaKeywordsTit.Text = "Keywords";
            // 
            // scnMetaAutor
            // 
            this.scnMetaAutor.Location = new System.Drawing.Point(122, 45);
            this.scnMetaAutor.Name = "scnMetaAutor";
            this.scnMetaAutor.Size = new System.Drawing.Size(381, 20);
            this.scnMetaAutor.TabIndex = 15;
            this.scnMetaAutor.Text = "Author names, ";
            // 
            // scnMetaAuthorTit
            // 
            this.scnMetaAuthorTit.AutoSize = true;
            this.scnMetaAuthorTit.Location = new System.Drawing.Point(9, 47);
            this.scnMetaAuthorTit.Name = "scnMetaAuthorTit";
            this.scnMetaAuthorTit.Size = new System.Drawing.Size(38, 13);
            this.scnMetaAuthorTit.TabIndex = 14;
            this.scnMetaAuthorTit.Text = "Author";
            // 
            // scnMetaTitle
            // 
            this.scnMetaTitle.Location = new System.Drawing.Point(122, 19);
            this.scnMetaTitle.Name = "scnMetaTitle";
            this.scnMetaTitle.Size = new System.Drawing.Size(381, 20);
            this.scnMetaTitle.TabIndex = 13;
            this.scnMetaTitle.Text = "Testing Itext 7";
            // 
            // scnMetaTitleTit
            // 
            this.scnMetaTitleTit.AutoSize = true;
            this.scnMetaTitleTit.Location = new System.Drawing.Point(9, 19);
            this.scnMetaTitleTit.Name = "scnMetaTitleTit";
            this.scnMetaTitleTit.Size = new System.Drawing.Size(27, 13);
            this.scnMetaTitleTit.TabIndex = 12;
            this.scnMetaTitleTit.Text = "Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scnBtnTestOneOpen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.scnBtnTestOne);
            this.groupBox3.Controls.Add(this.scnDocTextLorem);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.scnDocTitle);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(771, 131);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test One";
            // 
            // scnBtnTestOneOpen
            // 
            this.scnBtnTestOneOpen.Location = new System.Drawing.Point(677, 51);
            this.scnBtnTestOneOpen.Name = "scnBtnTestOneOpen";
            this.scnBtnTestOneOpen.Size = new System.Drawing.Size(75, 23);
            this.scnBtnTestOneOpen.TabIndex = 39;
            this.scnBtnTestOneOpen.Tag = "Before ckick this Click on Create pdf";
            this.scnBtnTestOneOpen.Text = "Open";
            this.scnBtnTestOneOpen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Text More";
            // 
            // scnBtnTestOne
            // 
            this.scnBtnTestOne.Location = new System.Drawing.Point(677, 22);
            this.scnBtnTestOne.Name = "scnBtnTestOne";
            this.scnBtnTestOne.Size = new System.Drawing.Size(75, 23);
            this.scnBtnTestOne.TabIndex = 36;
            this.scnBtnTestOne.Text = "Create pdf test one";
            this.scnBtnTestOne.UseVisualStyleBackColor = true;
            this.scnBtnTestOne.Click += new System.EventHandler(this.ScnBtnTestOne_Click);
            // 
            // scnDocTextLorem
            // 
            this.scnDocTextLorem.Location = new System.Drawing.Point(116, 43);
            this.scnDocTextLorem.Multiline = true;
            this.scnDocTextLorem.Name = "scnDocTextLorem";
            this.scnDocTextLorem.Size = new System.Drawing.Size(555, 75);
            this.scnDocTextLorem.TabIndex = 35;
            this.scnDocTextLorem.Text = resources.GetString("scnDocTextLorem.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Text More";
            // 
            // scnDocTitle
            // 
            this.scnDocTitle.Location = new System.Drawing.Point(116, 19);
            this.scnDocTitle.Name = "scnDocTitle";
            this.scnDocTitle.Size = new System.Drawing.Size(555, 20);
            this.scnDocTitle.TabIndex = 33;
            this.scnDocTitle.Text = "Hello world From  Itext 7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-99, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Text Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Only for testing proposite ITEXT 7 and C#";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 507);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(752, 48);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "ITEXT 7 program is free software; you can redistribute it and/or modify it under " +
    "the terms of the GNU Affero General Public License version 3 as published by the" +
    " Free Software Foundation";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(187, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Visit  https://itextpdf.com";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTest";
            this.Text = "ITEXT 7 + C# + testudines.pdf.ClsPdfBuilder ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox scnFileNameSort;
        private System.Windows.Forms.TextBox scnDirTarget;
        private System.Windows.Forms.TextBox scnDirTemp;
        private System.Windows.Forms.Label scnFileNameSortTit;
        private System.Windows.Forms.Label scnDirTargetTit;
        private System.Windows.Forms.Label scnDirTempTit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox scnMetaSubject;
        private System.Windows.Forms.Label scnMetaSubjectTit;
        private System.Windows.Forms.TextBox scnMetaKeyWords;
        private System.Windows.Forms.Label sccnMetaKeywordsTit;
        private System.Windows.Forms.TextBox scnMetaAutor;
        private System.Windows.Forms.Label scnMetaAuthorTit;
        private System.Windows.Forms.TextBox scnMetaTitle;
        private System.Windows.Forms.Label scnMetaTitleTit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox scnDocTextLorem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scnDocTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button scnBtnTestOne;
        private System.Windows.Forms.TextBox scnMetaCreator;
        private System.Windows.Forms.Label scnMetaCreatorTit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox scnFileNameTarget;
        private System.Windows.Forms.Button scnBtnTestOneOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

