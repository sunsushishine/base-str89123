
namespace military_base_d
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label name_companyLabel;
            System.Windows.Forms.Label name_shipperLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label date_shippingLabel;
            System.Windows.Forms.Label item_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.military_baseDataSet = new military_base_d.military_baseDataSet();
            this.shippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippersTableAdapter = new military_base_d.military_baseDataSetTableAdapters.ShippersTableAdapter();
            this.tableAdapterManager = new military_base_d.military_baseDataSetTableAdapters.TableAdapterManager();
            this.itemsTableAdapter = new military_base_d.military_baseDataSetTableAdapters.ItemsTableAdapter();
            this.shippersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shippersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.name_companyTextBox = new System.Windows.Forms.TextBox();
            this.name_shipperTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.date_shippingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            name_companyLabel = new System.Windows.Forms.Label();
            name_shipperLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            date_shippingLabel = new System.Windows.Forms.Label();
            item_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.military_baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingNavigator)).BeginInit();
            this.shippersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name_companyLabel
            // 
            name_companyLabel.AutoSize = true;
            name_companyLabel.Location = new System.Drawing.Point(13, 48);
            name_companyLabel.Name = "name_companyLabel";
            name_companyLabel.Size = new System.Drawing.Size(139, 13);
            name_companyLabel.TabIndex = 1;
            name_companyLabel.Text = "Наименование компании:";
            // 
            // name_shipperLabel
            // 
            name_shipperLabel.AutoSize = true;
            name_shipperLabel.Location = new System.Drawing.Point(22, 74);
            name_shipperLabel.Name = "name_shipperLabel";
            name_shipperLabel.Size = new System.Drawing.Size(104, 13);
            name_shipperLabel.TabIndex = 3;
            name_shipperLabel.Text = "ФИО отправителя:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(17, 100);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(122, 13);
            phone_numberLabel.TabIndex = 5;
            phone_numberLabel.Text = "Телефон отправителя:";
            // 
            // date_shippingLabel
            // 
            date_shippingLabel.AutoSize = true;
            date_shippingLabel.Location = new System.Drawing.Point(22, 127);
            date_shippingLabel.Name = "date_shippingLabel";
            date_shippingLabel.Size = new System.Drawing.Size(86, 13);
            date_shippingLabel.TabIndex = 7;
            date_shippingLabel.Text = "Дата отправки:";
            // 
            // item_idLabel
            // 
            item_idLabel.AutoSize = true;
            item_idLabel.Location = new System.Drawing.Point(13, 152);
            item_idLabel.Name = "item_idLabel";
            item_idLabel.Size = new System.Drawing.Size(82, 13);
            item_idLabel.TabIndex = 9;
            item_idLabel.Text = "Номер товара:";
            // 
            // military_baseDataSet
            // 
            this.military_baseDataSet.DataSetName = "military_baseDataSet";
            this.military_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shippersBindingSource
            // 
            this.shippersBindingSource.DataMember = "Shippers";
            this.shippersBindingSource.DataSource = this.military_baseDataSet;
            // 
            // shippersTableAdapter
            // 
            this.shippersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.ShipmentTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = this.shippersTableAdapter;
            this.tableAdapterManager.UpdateOrder = military_base_d.military_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // shippersBindingNavigator
            // 
            this.shippersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shippersBindingNavigator.BindingSource = this.shippersBindingSource;
            this.shippersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shippersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shippersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.shippersBindingNavigatorSaveItem});
            this.shippersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shippersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shippersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shippersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shippersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shippersBindingNavigator.Name = "shippersBindingNavigator";
            this.shippersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shippersBindingNavigator.Size = new System.Drawing.Size(548, 25);
            this.shippersBindingNavigator.TabIndex = 0;
            this.shippersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // shippersBindingNavigatorSaveItem
            // 
            this.shippersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shippersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shippersBindingNavigatorSaveItem.Image")));
            this.shippersBindingNavigatorSaveItem.Name = "shippersBindingNavigatorSaveItem";
            this.shippersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shippersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.shippersBindingNavigatorSaveItem.Click += new System.EventHandler(this.shippersBindingNavigatorSaveItem_Click);
            // 
            // name_companyTextBox
            // 
            this.name_companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shippersBindingSource, "name_company", true));
            this.name_companyTextBox.Location = new System.Drawing.Point(158, 45);
            this.name_companyTextBox.Name = "name_companyTextBox";
            this.name_companyTextBox.Size = new System.Drawing.Size(355, 20);
            this.name_companyTextBox.TabIndex = 2;
            // 
            // name_shipperTextBox
            // 
            this.name_shipperTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shippersBindingSource, "name_shipper", true));
            this.name_shipperTextBox.Location = new System.Drawing.Point(132, 71);
            this.name_shipperTextBox.Name = "name_shipperTextBox";
            this.name_shipperTextBox.Size = new System.Drawing.Size(381, 20);
            this.name_shipperTextBox.TabIndex = 4;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shippersBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(145, 97);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(368, 20);
            this.phone_numberTextBox.TabIndex = 6;
            // 
            // date_shippingDateTimePicker
            // 
            this.date_shippingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.shippersBindingSource, "date_shipping", true));
            this.date_shippingDateTimePicker.Location = new System.Drawing.Point(114, 123);
            this.date_shippingDateTimePicker.Name = "date_shippingDateTimePicker";
            this.date_shippingDateTimePicker.Size = new System.Drawing.Size(399, 20);
            this.date_shippingDateTimePicker.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.shippersBindingSource, "item_id", true));
            this.comboBox1.DataSource = this.itemsBindingSource;
            this.comboBox1.DisplayMember = "name_item";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(412, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "id_product";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.military_baseDataSet;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 206);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(item_idLabel);
            this.Controls.Add(date_shippingLabel);
            this.Controls.Add(this.date_shippingDateTimePicker);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(name_shipperLabel);
            this.Controls.Add(this.name_shipperTextBox);
            this.Controls.Add(name_companyLabel);
            this.Controls.Add(this.name_companyTextBox);
            this.Controls.Add(this.shippersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Таблица \"Отправка на склад\"";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.military_baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingNavigator)).EndInit();
            this.shippersBindingNavigator.ResumeLayout(false);
            this.shippersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private military_baseDataSet military_baseDataSet;
        private System.Windows.Forms.BindingSource shippersBindingSource;
        private military_baseDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter;
        private military_baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shippersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton shippersBindingNavigatorSaveItem;
        private military_baseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox name_companyTextBox;
        private System.Windows.Forms.TextBox name_shipperTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.DateTimePicker date_shippingDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
    }
}