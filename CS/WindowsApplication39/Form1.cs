using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWizard;

namespace WindowsApplication39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearWizardPageCollection(wizardControl1.Pages);
            WizardPage newPage = new WizardPage();
            newPage.Text = "This is new wizard page";
            wizardControl1.Pages.Add(newPage);
        }

        private void ClearWizardPageCollection(WizardPageCollection wizardPageCollection)
        {
            for (int i = wizardPageCollection.Count  - 1; i >= 0; i--)
            {
                wizardPageCollection[i].Dispose(); 
            }
        }
    }
}