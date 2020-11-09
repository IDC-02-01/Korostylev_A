namespace WindowsFormsApp4
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label id_TovarLabel;
            System.Windows.Forms.Label naimenovanie_TovaraLabel;
            System.Windows.Forms.Label id_KategoriaLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label id_StatusLabel;
            this._bd_KorostylevDataSet = new WindowsFormsApp4._bd_KorostylevDataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.TovarTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.TableAdapterManager();
            this.tovarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tovarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_TovarTextBox = new System.Windows.Forms.TextBox();
            this.naimenovanie_TovaraTextBox = new System.Windows.Forms.TextBox();
            this.id_KategoriaTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.id_StatusTextBox = new System.Windows.Forms.TextBox();
            id_TovarLabel = new System.Windows.Forms.Label();
            naimenovanie_TovaraLabel = new System.Windows.Forms.Label();
            id_KategoriaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            id_StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bd_KorostylevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingNavigator)).BeginInit();
            this.tovarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bd_KorostylevDataSet
            // 
            this._bd_KorostylevDataSet.DataSetName = "_bd_KorostylevDataSet";
            this._bd_KorostylevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this._bd_KorostylevDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.DataTable1TableAdapter = null;
            this.tableAdapterManager.DomTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KategoriaTableAdapter = null;
            this.tableAdapterManager.MagazTableAdapter = null;
            this.tableAdapterManager.NakladnayaTableAdapter = null;
            this.tableAdapterManager.OblastTableAdapter = null;
            this.tableAdapterManager.OrganizateTableAdapter = null;
            this.tableAdapterManager.OthectTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = null;
            this.tableAdapterManager.RaionTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TipDokumentTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = this.tovarTableAdapter;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tovarBindingNavigator
            // 
            this.tovarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tovarBindingNavigator.BindingSource = this.tovarBindingSource;
            this.tovarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tovarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tovarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tovarBindingNavigatorSaveItem});
            this.tovarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tovarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tovarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tovarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tovarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tovarBindingNavigator.Name = "tovarBindingNavigator";
            this.tovarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tovarBindingNavigator.Size = new System.Drawing.Size(314, 25);
            this.tovarBindingNavigator.TabIndex = 0;
            this.tovarBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // tovarBindingNavigatorSaveItem
            // 
            this.tovarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tovarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tovarBindingNavigatorSaveItem.Image")));
            this.tovarBindingNavigatorSaveItem.Name = "tovarBindingNavigatorSaveItem";
            this.tovarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tovarBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tovarBindingNavigatorSaveItem.Click += new System.EventHandler(this.tovarBindingNavigatorSaveItem_Click);
            // 
            // id_TovarLabel
            // 
            id_TovarLabel.AutoSize = true;
            id_TovarLabel.Location = new System.Drawing.Point(12, 68);
            id_TovarLabel.Name = "id_TovarLabel";
            id_TovarLabel.Size = new System.Drawing.Size(49, 13);
            id_TovarLabel.TabIndex = 1;
            id_TovarLabel.Text = "id Tovar:";
            // 
            // id_TovarTextBox
            // 
            this.id_TovarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "id_Tovar", true));
            this.id_TovarTextBox.Location = new System.Drawing.Point(133, 65);
            this.id_TovarTextBox.Name = "id_TovarTextBox";
            this.id_TovarTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TovarTextBox.TabIndex = 2;
            // 
            // naimenovanie_TovaraLabel
            // 
            naimenovanie_TovaraLabel.AutoSize = true;
            naimenovanie_TovaraLabel.Location = new System.Drawing.Point(12, 94);
            naimenovanie_TovaraLabel.Name = "naimenovanie_TovaraLabel";
            naimenovanie_TovaraLabel.Size = new System.Drawing.Size(115, 13);
            naimenovanie_TovaraLabel.TabIndex = 3;
            naimenovanie_TovaraLabel.Text = "Naimenovanie Tovara:";
            // 
            // naimenovanie_TovaraTextBox
            // 
            this.naimenovanie_TovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Naimenovanie_Tovara", true));
            this.naimenovanie_TovaraTextBox.Location = new System.Drawing.Point(133, 91);
            this.naimenovanie_TovaraTextBox.Name = "naimenovanie_TovaraTextBox";
            this.naimenovanie_TovaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.naimenovanie_TovaraTextBox.TabIndex = 4;
            // 
            // id_KategoriaLabel
            // 
            id_KategoriaLabel.AutoSize = true;
            id_KategoriaLabel.Location = new System.Drawing.Point(12, 120);
            id_KategoriaLabel.Name = "id_KategoriaLabel";
            id_KategoriaLabel.Size = new System.Drawing.Size(66, 13);
            id_KategoriaLabel.TabIndex = 5;
            id_KategoriaLabel.Text = "id Kategoria:";
            // 
            // id_KategoriaTextBox
            // 
            this.id_KategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "id_Kategoria", true));
            this.id_KategoriaTextBox.Location = new System.Drawing.Point(133, 117);
            this.id_KategoriaTextBox.Name = "id_KategoriaTextBox";
            this.id_KategoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_KategoriaTextBox.TabIndex = 6;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(12, 146);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(35, 13);
            cenaLabel.TabIndex = 7;
            cenaLabel.Text = "Cena:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(133, 143);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cenaTextBox.TabIndex = 8;
            // 
            // id_StatusLabel
            // 
            id_StatusLabel.AutoSize = true;
            id_StatusLabel.Location = new System.Drawing.Point(12, 172);
            id_StatusLabel.Name = "id_StatusLabel";
            id_StatusLabel.Size = new System.Drawing.Size(51, 13);
            id_StatusLabel.TabIndex = 9;
            id_StatusLabel.Text = "id Status:";
            // 
            // id_StatusTextBox
            // 
            this.id_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "id_Status", true));
            this.id_StatusTextBox.Location = new System.Drawing.Point(133, 169);
            this.id_StatusTextBox.Name = "id_StatusTextBox";
            this.id_StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_StatusTextBox.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 272);
            this.Controls.Add(id_TovarLabel);
            this.Controls.Add(this.id_TovarTextBox);
            this.Controls.Add(naimenovanie_TovaraLabel);
            this.Controls.Add(this.naimenovanie_TovaraTextBox);
            this.Controls.Add(id_KategoriaLabel);
            this.Controls.Add(this.id_KategoriaTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(id_StatusLabel);
            this.Controls.Add(this.id_StatusTextBox);
            this.Controls.Add(this.tovarBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this._bd_KorostylevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingNavigator)).EndInit();
            this.tovarBindingNavigator.ResumeLayout(false);
            this.tovarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _bd_KorostylevDataSet _bd_KorostylevDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private _bd_KorostylevDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private _bd_KorostylevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tovarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tovarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_TovarTextBox;
        private System.Windows.Forms.TextBox naimenovanie_TovaraTextBox;
        private System.Windows.Forms.TextBox id_KategoriaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox id_StatusTextBox;
    }
}