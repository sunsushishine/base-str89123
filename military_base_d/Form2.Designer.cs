
namespace military_base_d
{
    partial class Form2
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
            System.Windows.Forms.Label id_productLabel;
            System.Windows.Forms.Label name_itemLabel;
            System.Windows.Forms.Label amount_itemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.military_baseDataSet = new military_base_d.military_baseDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new military_base_d.military_baseDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new military_base_d.military_baseDataSetTableAdapters.TableAdapterManager();
            this.itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.itemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_productTextBox = new System.Windows.Forms.TextBox();
            this.name_itemTextBox = new System.Windows.Forms.TextBox();
            this.amount_itemTextBox = new System.Windows.Forms.TextBox();
            id_productLabel = new System.Windows.Forms.Label();
            name_itemLabel = new System.Windows.Forms.Label();
            amount_itemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.military_baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).BeginInit();
            this.itemsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_productLabel
            // 
            id_productLabel.AutoSize = true;
            id_productLabel.Location = new System.Drawing.Point(12, 42);
            id_productLabel.Name = "id_productLabel";
            id_productLabel.Size = new System.Drawing.Size(93, 13);
            id_productLabel.TabIndex = 1;
            id_productLabel.Text = "Номер продукта:";
            // 
            // name_itemLabel
            // 
            name_itemLabel.AutoSize = true;
            name_itemLabel.Location = new System.Drawing.Point(11, 68);
            name_itemLabel.Name = "name_itemLabel";
            name_itemLabel.Size = new System.Drawing.Size(135, 13);
            name_itemLabel.TabIndex = 3;
            name_itemLabel.Text = "Наименования продукта:";
            // 
            // amount_itemLabel
            // 
            amount_itemLabel.AutoSize = true;
            amount_itemLabel.Location = new System.Drawing.Point(11, 94);
            amount_itemLabel.Name = "amount_itemLabel";
            amount_itemLabel.Size = new System.Drawing.Size(99, 13);
            amount_itemLabel.TabIndex = 5;
            amount_itemLabel.Text = "Кол-во продуктов:";
            // 
            // military_baseDataSet
            // 
            this.military_baseDataSet.DataSetName = "military_baseDataSet";
            this.military_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.military_baseDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.ShipmentTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = military_base_d.military_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemsBindingNavigator
            // 
            this.itemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemsBindingNavigator.BindingSource = this.itemsBindingSource;
            this.itemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemsBindingNavigatorSaveItem});
            this.itemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsBindingNavigator.Name = "itemsBindingNavigator";
            this.itemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsBindingNavigator.Size = new System.Drawing.Size(423, 25);
            this.itemsBindingNavigator.TabIndex = 0;
            this.itemsBindingNavigator.Text = "bindingNavigator1";
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
            // itemsBindingNavigatorSaveItem
            // 
            this.itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsBindingNavigatorSaveItem.Image")));
            this.itemsBindingNavigatorSaveItem.Name = "itemsBindingNavigatorSaveItem";
            this.itemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.itemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemsBindingNavigatorSaveItem_Click_1);
            // 
            // id_productTextBox
            // 
            this.id_productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "id_product", true));
            this.id_productTextBox.Location = new System.Drawing.Point(111, 39);
            this.id_productTextBox.Name = "id_productTextBox";
            this.id_productTextBox.Size = new System.Drawing.Size(300, 20);
            this.id_productTextBox.TabIndex = 2;
            // 
            // name_itemTextBox
            // 
            this.name_itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "name_item", true));
            this.name_itemTextBox.Location = new System.Drawing.Point(152, 65);
            this.name_itemTextBox.Name = "name_itemTextBox";
            this.name_itemTextBox.Size = new System.Drawing.Size(259, 20);
            this.name_itemTextBox.TabIndex = 4;
            // 
            // amount_itemTextBox
            // 
            this.amount_itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "amount_item", true));
            this.amount_itemTextBox.Location = new System.Drawing.Point(111, 91);
            this.amount_itemTextBox.Name = "amount_itemTextBox";
            this.amount_itemTextBox.Size = new System.Drawing.Size(300, 20);
            this.amount_itemTextBox.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 170);
            this.Controls.Add(amount_itemLabel);
            this.Controls.Add(this.amount_itemTextBox);
            this.Controls.Add(name_itemLabel);
            this.Controls.Add(this.name_itemTextBox);
            this.Controls.Add(id_productLabel);
            this.Controls.Add(this.id_productTextBox);
            this.Controls.Add(this.itemsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Таблица \"Товары на складе\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.military_baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).EndInit();
            this.itemsBindingNavigator.ResumeLayout(false);
            this.itemsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private military_baseDataSet military_baseDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private military_baseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private military_baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itemsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_productTextBox;
        private System.Windows.Forms.TextBox name_itemTextBox;
        private System.Windows.Forms.TextBox amount_itemTextBox;
    }
}