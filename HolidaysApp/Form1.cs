using BUS;
using DTO;
using System.Data;

namespace HolidaysApp
{
    public partial class Form1 : Form
    {   
        private bus bs1 = new bus();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = bs1.ReadAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasEmptyTextbox = false;
            int i = 0;
            TextBox[] textBoxes = { 
                textBox1, 
                textBox2, 
                textBox3, 
                textBox4, 
                textBox5, 
                textBox6, 
                textBox7, 
                textBox8 
            };

            foreach (var textBox in textBoxes)
            {
                i++;
                
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    hasEmptyTextbox = true;
                   
                    MessageBox.Show("Lỗi! Dữ liệu ô thứ "+i+" trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    textBox.Focus();
                    
                }
            }
            if (!hasEmptyTextbox)
            {
                holidays hl1 = new holidays();
                hl1.Holiday_date = textBox2.Text;
                hl1.Holiday_name_group = textBox3.Text;
                hl1.Holiday_name_en = textBox4.Text;
                hl1.Holiday_name_vi = textBox5.Text;
                hl1.Remark = textBox6.Text;
                hl1.Updated_by = textBox7.Text;
                hl1.Updated_date = DateTime.Parse(textBox8.Text); 
                bool result = bus.Create(hl1);
                if (result)
                {
                    MessageBox.Show("Create success", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = bs1.ReadAll();
                }
                else
                {
                    MessageBox.Show("Create fail", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool hasEmptyTextbox = false;
            int i = 0;
            TextBox[] textBoxes = {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8
            };

            foreach (var textBox in textBoxes)
            {
                i++;

                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    hasEmptyTextbox = true;

                    MessageBox.Show("Lỗi! Dữ liệu ô thứ " + i + " trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox.Focus();

                }
            }
            if (!hasEmptyTextbox)
            {
                holidays hl1 = new holidays();
                hl1.ID = int.Parse(textBox1.Text);
                hl1.Holiday_date = textBox2.Text;
                hl1.Holiday_name_group = textBox3.Text;
                hl1.Holiday_name_en = textBox4.Text;
                hl1.Holiday_name_vi = textBox5.Text;
                hl1.Remark = textBox6.Text;
                hl1.Updated_by = textBox7.Text;
                hl1.Updated_date = DateTime.Parse(textBox8.Text);
                bool result = bus.Update(hl1);
                if (result)
                {
                    MessageBox.Show("Update success","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dataGridView1.DataSource = bs1.ReadAll();
                }
                else
                {
                    MessageBox.Show("Update fail !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool hasEmptyTextbox = false;
            int i = 0;
            TextBox[] textBoxes = {
                textBox1,
            };

            foreach (var textBox in textBoxes)
            {
                i++;

                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    hasEmptyTextbox = true;

                    MessageBox.Show("Lỗi! Dữ liệu ô thứ " + i + " trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox.Focus();

                }
            }
            if (!hasEmptyTextbox)
            {
               
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                   string ID = row.Cells[0].Value?.ToString() ?? "";

                    bool result = bus.Delete(ID);
                    if (result)
                    {
                        MessageBox.Show("Delete success", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Delete fail", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dataGridView1.DataSource = bs1.ReadAll();

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i = i + 2)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.DefaultCellStyle.BackColor = Color.FromArgb(255,192,255);
            }
        }
    }
}