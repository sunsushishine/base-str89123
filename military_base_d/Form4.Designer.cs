
namespace military_base_d
{
    partial class Form4
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
            System.Windows.Forms.Label item_idLabel;
            System.Windows.Forms.Label name_shipperLabel;
            System.Windows.Forms.Label name_storehouseLabel;
            System.Windows.Forms.Label date_sendingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.military_baseDataSet = new military_base_d.military_baseDataSet();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTableAdapter = new military_base_d.military_baseDataSetTableAdapters.ShipmentTableAdapter();
            this.tableAdapterManager = new military_base_d.military_baseDataSetTableAdapters.TableAdapterManager();
            this.itemsTableAdapter = new military_base_d.military_baseDataSetTableAdapters.ItemsTableAdapter();
            this.shipmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.shipmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.name_shipperTextBox = new System.Windows.Forms.TextBox();
            this.name_storehouseTextBox = new System.Windows.Forms.TextBox();
            this.date_sendingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            item_idLabel = new System.Windows.Forms.Label();
            name_shipperLabel = new System.Windows.Forms.Label();
            name_storehouseLabel = new System.Windows.Forms.Label();
            date_sendingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.military_baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingNavigator)).BeginInit();
            this.shipmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // item_idLabel
            // 
            item_idLabel.AutoSize = true;
            item_idLabel.Location = new System.Drawing.Point(12, 50);
            item_idLabel.Name = "item_idLabel";
            item_idLabel.Size = new System.Drawing.Size(93, 13);
            item_idLabel.TabIndex = 1;
            item_idLabel.Text = "Номер продукта:";
            item_idLabel.Click += new System.EventHandler(this.item_idLabel_Click);
            // 
            // name_shipperLabel
            // 
            name_shipperLabel.AutoSize = true;
            name_shipperLabel.Location = new System.Drawing.Point(1, 77);
            name_shipperLabel.Name = "name_shipperLabel";
            name_shipperLabel.Size = new System.Drawing.Size(104, 13);
            name_shipperLabel.TabIndex = 3;
            name_shipperLabel.Text = "ФИО отправителя:";
            // 
            // name_storehouseLabel
            // 
            name_storehouseLabel.AutoSize = true;
            name_storehouseLabel.Location = new System.Drawing.Point(9, 103);
            name_storehouseLabel.Name = "name_storehouseLabel";
            name_storehouseLabel.Size = new System.Drawing.Size(125, 13);
            name_storehouseLabel.TabIndex = 5;
            name_storehouseLabel.Text = "Наименование склада:";
            // 
            // date_sendingLabel
            // 
            date_sendingLabel.AutoSize = true;
            date_sendingLabel.Location = new System.Drawing.Point(29, 130);
            date_sendingLabel.Name = "date_sendingLabel";
            date_sendingLabel.Size = new System.Drawing.Size(104, 13);
            date_sendingLabel.TabIndex = 7;
            date_sendingLabel.Text = "Дата отправления:";
            // 
            // military_baseDataSet
            // 
            this.military_baseDataSet.DataSetName = "military_baseDataSet";
            this.military_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.military_baseDataSet;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.ShipmentTableAdapter = this.shipmentTableAdapter;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = military_base_d.military_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // shipmentBindingNavigator
            // 
            this.shipmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shipmentBindingNavigator.BindingSource = this.shipmentBindingSource;
            this.shipmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shipmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shipmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.shipmentBindingNavigatorSaveItem});
            this.shipmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shipmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shipmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shipmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shipmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shipmentBindingNavigator.Name = "shipmentBindingNavigator";
            this.shipmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shipmentBindingNavigator.Size = new System.Drawing.Size(528, 25);
            this.shipmentBindingNavigator.TabIndex = 0;
            this.shipmentBindingNavigator.Text = "bindingNavigator1";
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
            // shipmentBindingNavigatorSaveItem
            // 
            this.shipmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shipmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shipmentBindingNavigatorSaveItem.Image")));
            this.shipmentBindingNavigatorSaveItem.Name = "shipmentBindingNavigatorSaveItem";
            this.shipmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shipmentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.shipmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.shipmentBindingNavigatorSaveItem_Click);
            // 
            // name_shipperTextBox
            // 
            this.name_shipperTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipmentBindingSource, "name_shipper", true));
            this.name_shipperTextBox.Location = new System.Drawing.Point(106, 74);
            this.name_shipperTextBox.Name = "name_shipperTextBox";
            this.name_shipperTextBox.Size = new System.Drawing.Size(380, 20);
            this.name_shipperTextBox.TabIndex = 4;
            // 
            // name_storehouseTextBox
            // 
            this.name_storehouseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipmentBindingSource, "name_storehouse", true));
            this.name_storehouseTextBox.Location = new System.Drawing.Point(140, 100);
            this.name_storehouseTextBox.Name = "name_storehouseTextBox";
            this.name_storehouseTextBox.Size = new System.Drawing.Size(346, 20);
            this.name_storehouseTextBox.TabIndex = 6;
            // 
            // date_sendingDateTimePicker
            // 
            this.date_sendingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.shipmentBindingSource, "date_sending", true));
            this.date_sendingDateTimePicker.Location = new System.Drawing.Point(140, 126);
            this.date_sendingDateTimePicker.Name = "date_sendingDateTimePicker";
            this.date_sendingDateTimePicker.Size = new System.Drawing.Size(346, 20);
            this.date_sendingDateTimePicker.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.shipmentBindingSource, "item_id", true));
            this.comboBox1.DataSource = this.itemsBindingSource;
            this.comboBox1.DisplayMember = "name_item";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "id_product";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.military_baseDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 195);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(date_sendingLabel);
            this.Controls.Add(this.date_sendingDateTimePicker);
            this.Controls.Add(name_storehouseLabel);
            this.Controls.Add(this.name_storehouseTextBox);
            this.Controls.Add(name_shipperLabel);
            this.Controls.Add(this.name_shipperTextBox);
            this.Controls.Add(item_idLabel);
            this.Controls.Add(this.shipmentBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Таблица \"Отправка со склада\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.military_baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingNavigator)).EndInit();
            this.shipmentBindingNavigator.ResumeLayout(false);
            this.shipmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private military_baseDataSet military_baseDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private military_baseDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private military_baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shipmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton shipmentBindingNavigatorSaveItem;
        private military_baseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox name_shipperTextBox;
        private System.Windows.Forms.TextBox name_storehouseTextBox;
        private System.Windows.Forms.DateTimePicker date_sendingDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
    }
}