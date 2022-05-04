using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_base_d
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void shippersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shippersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.military_baseDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.military_baseDataSet.Items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.Shippers". При необходимости она может быть перемещена или удалена.
            this.shippersTableAdapter.Fill(this.military_baseDataSet.Shippers);

        }
    }
}
