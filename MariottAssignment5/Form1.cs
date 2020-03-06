using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariottAssignment5
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal age = numAge.Value;
            decimal salary = numSalary.Value;
            decimal earnings = 0;

            lstOutput.Items.Clear();
            while (age < 65)
            {
                age++;
                earnings += salary;
                salary = salary * 1.05M;
            }
            if (txtName.Text != "")
            {
                lstOutput.Items.Add(name + string.Format(" will earn about {0:C2}", earnings));
            }
            else
            {
                MessageBox.Show("Please enter your Name.", "Oops");

                return;
            }
            lstOutput.Items.Clear();

            age = numAge.Value;
            if (age > 0)
            {
                lstOutput.Items.Add(name + string.Format(" will earn about {0:C2}", earnings));
            }
            else
            {
                MessageBox.Show("Please enter your Age.", "Oops");

                return;
            }
            lstOutput.Items.Clear();

            salary = numSalary.Value;
            if (salary > 0)
            {
                lstOutput.Items.Add(name + string.Format(" will earn about {0:C2}", earnings));
            }
            else
            {
                MessageBox.Show("Please enter your Starting Salary.", "Oops");

                return;
            }
        }
    }
}
