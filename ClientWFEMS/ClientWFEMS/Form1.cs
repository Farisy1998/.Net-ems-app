using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Data;
using System.Data.SqlClient;
using IRemoteEMS;

namespace ClientWFEMS
{
    public partial class Form1 : Form
    {
        HTTPREG objch = new HTTPREG();
        IRemote obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void binsert_Click(object sender, EventArgs e)
        {
            if(tname.Text=="")
            {
                MessageBox.Show("Please fill the Employee Name field");
            }
            else if(tdes.Text=="")
            {
                MessageBox.Show("Please fill the Employee Destination field");
            }
            else if(tsal.Text=="")
            {
                MessageBox.Show("Please fill the Employee Salary field");
            }
            else
            {
                string emp_name = tname.Text;
                string emp_des = tdes.Text;
                int emp_sal = Int32.Parse(tsal.Text);
                string insert_query = "insert into tbl_emp values('" + emp_name + "','" + emp_des + "','" + emp_sal + "')";
                obj = (IRemote)Activator.GetObject(typeof(IRemote), "http://localhost:123/db_oper");
                obj.insert(insert_query);
                MessageBox.Show("Values inserted Successfully");
            }   
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            if(tid.Text=="")
            {
                MessageBox.Show("Please fill the Employee Id field");
            }
            else if(fieldbox.Text=="Select the field")
            {
                MessageBox.Show("Please select the Filed");
            }
            else if(tval.Text=="")
            {
                MessageBox.Show("Please fill the Value field");
            }
            else
            {
                int emp_id;
                emp_id = Int32.Parse(tid.Text);
                if (fieldbox.Text == "emp_sal")
                {
                    int value = Int32.Parse(tval.Text);
                    string update_query = "update tbl_emp set "+fieldbox.Text+ "=" +value+ " where emp_id="+emp_id;
                    obj = (IRemote)Activator.GetObject(typeof(IRemote), "http://localhost:123/db_oper");
                    obj.update(update_query);
                    MessageBox.Show("Values updated Successfully");
                }
                else
                {
                    string value = tval.Text;
                    string update_query = "update tbl_emp set " + fieldbox.Text + "='" + value + "' where emp_id=" + emp_id;
                    obj = (IRemote)Activator.GetObject(typeof(IRemote), "http://localhost:123/db_oper");
                    obj.update(update_query);
                    MessageBox.Show("Values updated Successfully");
                }
                
            }   
        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void bexit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            if(dtid.Text=="")
            {
                MessageBox.Show("Please fill the Employee Id field");
            }
            else
            {
                int emp_id = Int32.Parse(dtid.Text);
                string delete_query = "delete from tbl_emp where emp_id=" + emp_id;
                obj = (IRemote)Activator.GetObject(typeof(IRemote), "http://localhost:123/db_oper");
                obj.delete(delete_query);
                MessageBox.Show("Values deleted Successfully");
            }
        }

        private void bexit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bview_Click(object sender, EventArgs e)
        {
            string select_query = "select * from tbl_emp";
            obj = (IRemote)Activator.GetObject(typeof(IRemote), "http://localhost:123/db_oper");
            dgv1.DataSource = obj.select(select_query);
        }

        private void bexit4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    class HTTPREG
    {
        public HTTPREG()
        {
            HttpChannel ch = new HttpChannel();
            ChannelServices.RegisterChannel(ch);
        }
    }
}
