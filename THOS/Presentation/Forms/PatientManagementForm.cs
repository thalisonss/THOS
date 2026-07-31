using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THOS.Controls;

namespace THOS.Forms
{
    public partial class PatientManagementForm : Form
    {
        public PatientManagementForm()
        {
            InitializeComponent();
        }

        private void PatientManagementForm_Load(object sender, EventArgs e)
        {
            PatientRegistrationControl uc = new PatientRegistrationControl { Dock = DockStyle.Fill };
            tabPage1.Controls.Add(uc);
        }
    }
}
