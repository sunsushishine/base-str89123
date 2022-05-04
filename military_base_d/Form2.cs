using System;
using System.Windows.Forms;

namespace military_base_d
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.military_baseDataSet);
        }

        private void itemsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.military_baseDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "military_baseDataSet.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.military_baseDataSet.Items);
        }
    }
}
