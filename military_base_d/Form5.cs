using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace military_base_d
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.military_baseDataSet.Items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.Shippers". При необходимости она может быть перемещена или удалена.
            this.shippersTableAdapter.Fill(this.military_baseDataSet.Shippers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.military_baseDataSet.View_1);

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void button1_Click(object sender, EventArgs e)
        {

            COL = new System.Windows.Forms.DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 5:
                    COL = dataGridViewTextBoxColumn6;
                    break;

            }
            if (radioButton1.Checked)
                view_1DataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                view_1DataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_1BindingSource.Filter = "name_item='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_1BindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < view_1DataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < view_1DataGridView.RowCount - 1; j++)
                {
                    view_1DataGridView[i, j].Style.BackColor = Color.White;
                    view_1DataGridView[i, j].Style.BackColor = Color.Black;
                }
            }
            for (int i = 0; i < view_1DataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < view_1DataGridView.RowCount - 1; j++)
                {
                    if (view_1DataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        view_1DataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        view_1DataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path;
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < view_1DataGridView.RowCount + 1; i++)
            {
                for (int j = 1; j < view_1DataGridView.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = view_1DataGridView.Rows[i - 1].Cells[j - 1].Value;
                }
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Файлы Excel (*.xls; *.xlsx) | *.xls; *.xlsx";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveDialog.FileName;
                    workbook.SaveAs(path);
                }
            }

            excelapp.AlertBeforeOverwriting = false;
            excelapp.Quit();
        }
    }
}
