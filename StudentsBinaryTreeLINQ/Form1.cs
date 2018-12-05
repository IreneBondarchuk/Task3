using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BinaryTree;
using StudentsInfo;

namespace StudentsBinaryTreeLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                       
        }

        Tree<Student> studTree = new Tree<Student> { };
        BindingSource studentsBindingSource = new BindingSource();

        private void bt_LoadData_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }

                StudentsInfoFromJSON info = new StudentsInfoFromJSON(path);
                List<Student> students = info.StudentsList;
                studTree = new Tree<Student>(students);
                studentsBindingSource.DataSource = studTree.ToList();
                dgv_Data.DataSource = studentsBindingSource;
                dgv_Data.AutoGenerateColumns = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
        }


       
        private void dgv_Data_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string propertyName = dgv_Data.Columns[e.ColumnIndex].DataPropertyName;

            List<Student> studs = (List<Student>)studentsBindingSource.DataSource;

            studs = studs.OrderBy(propertyName).ToList();

            studentsBindingSource.DataSource = studs;

        }
    }
    }

