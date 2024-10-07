using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateStudent
{
    public partial class Form1 : Form
    {
        private List<CStudent> m_lststudents = new List<CStudent>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ldlName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void callback_btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void callback_btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length < 2 ||
                txtStudentId.Text.Length<2 ||
                txtProfile.Text.Length < 2 )
                {
                return; 
            }

            CStudent student = new CStudent();
            student.m_strId = txtStudentId.Text;
            student.m_strName = txtName.Text;
            student.m_strDescription = txtProfile.Text;

            m_lststudents.Add(student); 

            lstStudentId.Items.Clear();
            foreach(CStudent std in m_lststudents)
            {
                string strId = std.m_strId;
                lstStudentId.Items.Add(strId);
            }
         }

        private void callback_lstStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstStudentId.SelectedItems.Count>0)
            {
                string strId = lstStudentId.SelectedItems[0] as string;
                if (strId != null)
                {
                    MessageBox.Show("Velue : " + strId);
                }
            }
        }
    }
}
