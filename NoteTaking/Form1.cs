using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Notes : Form
    {
        DataTable table;
        
        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 335;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            title_txtbox.Clear();
            message_txtbox.Clear();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {            
            table.Rows.Add(title_txtbox.Text, message_txtbox.Text);
            title_txtbox.Clear();
            message_txtbox.Clear();
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                title_txtbox.Text = table.Rows[index].ItemArray[0].ToString();
                message_txtbox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
        }
    }
}