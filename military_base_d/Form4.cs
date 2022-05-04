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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void shipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.military_baseDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.military_baseDataSet.Items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.Shipment". При необходимости она может быть перемещена или удалена.
            this.shipmentTableAdapter.Fill(this.military_baseDataSet.Shipment);

        }

        private void item_idLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
