using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagementSystem
{
    public partial class Form1 : Form
    {
        Person p = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(txtAge.Text)) >= 5 && (Convert.ToInt32(txtAge.Text)) <= 60)
            {

                try
                {
                    p.Id = Convert.ToInt32(txtId.Text);
                    p.Name = txtName.Text;
                    p.Age = Convert.ToInt32(txtAge.Text);
                    MessageBox.Show("Saved Successfully", "Person Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid data", "Person Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }

            else
            
                MessageBox.Show("Age eligibility should be 5 to 60", "Person Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lblReadId.Text="Id:" + p.Id.ToString();
            lblReadName.Text = "Name:" + comboBox1.Text+ p.Name.ToString();
            lblReadAge.Text ="Age:" + p.Age.ToString();
            if ((Convert.ToInt32(txtAge.Text)) <= 17) 
            {
                lblReadAge.BackColor = Color.Red;
             }
            else
            
                lblReadAge.BackColor = Color.Green;
          }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text= string.Empty;
            txtAge.Text= string.Empty;
            comboBox1.Text= string.Empty;
            lblReadId.Text=lblReadName.Text=lblReadAge.Text= string.Empty;
            lblReadAge.BackColor = Color.White;
         }

        private void lblReadAge_Click(object sender, EventArgs e)
        {
           // if((Convert.ToInt32(txtAge.Text))<18)
              //  {
              //  lblReadAge.BackColor = Color.Red;

            //}
        }
    }
}
