namespace WindowsFormsApp4
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
            System.Windows.Forms.Label id_MagazLabel;
            System.Windows.Forms.Label prihod_magazLabel;
            System.Windows.Forms.Label opt_cenaLabel;
            System.Windows.Forms.Label ostat_magazLabel;
            System.Windows.Forms.Label id_TovarLabel;
            System.Windows.Forms.Label id_ChekLabel;
            System.Windows.Forms.Label id_KategoriaLabel;
            System.Windows.Forms.Label id_TipdocumentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this._bd_KorostylevDataSet = new WindowsFormsApp4._bd_KorostylevDataSet();
            this.magazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazTableAdapter = new WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.MagazTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.TableAdapterManager();
            this.magazBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.magazBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_MagazTextBox = new System.Windows.Forms.TextBox();
            this.prihod_magazTextBox = new System.Windows.Forms.TextBox();
            this.opt_cenaTextBox = new System.Windows.Forms.TextBox();
            this.ostat_magazTextBox = new System.Windows.Forms.TextBox();
            this.id_TovarTextBox = new System.Windows.Forms.TextBox();
            this.id_ChekTextBox = new System.Windows.Forms.TextBox();
            this.id_KategoriaTextBox = new System.Windows.Forms.TextBox();
            this.id_TipdocumentTextBox = new System.Windows.Forms.TextBox();
            id_MagazLabel = new System.Windows.Forms.Label();
            prihod_magazLabel = new System.Windows.Forms.Label();
            opt_cenaLabel = new System.Windows.Forms.Label();
            ostat_magazLabel = new System.Windows.Forms.Label();
            id_TovarLabel = new System.Windows.Forms.Label();
            id_ChekLabel = new System.Windows.Forms.Label();
            id_KategoriaLabel = new System.Windows.Forms.Label();
            id_TipdocumentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bd_KorostylevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingNavigator)).BeginInit();
            this.magazBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_MagazLabel
            // 
            id_MagazLabel.AutoSize = true;
            id_MagazLabel.Location = new System.Drawing.Point(12, 76);
            id_MagazLabel.Name = "id_MagazLabel";
            id_MagazLabel.Size = new System.Drawing.Size(53, 13);
            id_MagazLabel.TabIndex = 1;
            id_MagazLabel.Text = "id Magaz:";
            // 
            // prihod_magazLabel
            // 
            prihod_magazLabel.AutoSize = true;
            prihod_magazLabel.Location = new System.Drawing.Point(12, 102);
            prihod_magazLabel.Name = "prihod_magazLabel";
            prihod_magazLabel.Size = new System.Drawing.Size(74, 13);
            prihod_magazLabel.TabIndex = 3;
            prihod_magazLabel.Text = "Prihod magaz:";
            // 
            // opt_cenaLabel
            // 
            opt_cenaLabel.AutoSize = true;
            opt_cenaLabel.Location = new System.Drawing.Point(12, 128);
            opt_cenaLabel.Name = "opt_cenaLabel";
            opt_cenaLabel.Size = new System.Drawing.Size(54, 13);
            opt_cenaLabel.TabIndex = 5;
            opt_cenaLabel.Text = "Opt cena:";
            // 
            // ostat_magazLabel
            // 
            ostat_magazLabel.AutoSize = true;
            ostat_magazLabel.Location = new System.Drawing.Point(12, 154);
            ostat_magazLabel.Name = "ostat_magazLabel";
            ostat_magazLabel.Size = new System.Drawing.Size(69, 13);
            ostat_magazLabel.TabIndex = 7;
            ostat_magazLabel.Text = "Ostat magaz:";
            // 
            // id_TovarLabel
            // 
            id_TovarLabel.AutoSize = true;
            id_TovarLabel.Location = new System.Drawing.Point(12, 180);
            id_TovarLabel.Name = "id_TovarLabel";
            id_TovarLabel.Size = new System.Drawing.Size(49, 13);
            id_TovarLabel.TabIndex = 9;
            id_TovarLabel.Text = "id Tovar:";
            // 
            // id_ChekLabel
            // 
            id_ChekLabel.AutoSize = true;
            id_ChekLabel.Location = new System.Drawing.Point(12, 206);
            id_ChekLabel.Name = "id_ChekLabel";
            id_ChekLabel.Size = new System.Drawing.Size(46, 13);
            id_ChekLabel.TabIndex = 11;
            id_ChekLabel.Text = "id Chek:";
            // 
            // id_KategoriaLabel
            // 
            id_KategoriaLabel.AutoSize = true;
            id_KategoriaLabel.Location = new System.Drawing.Point(12, 232);
            id_KategoriaLabel.Name = "id_KategoriaLabel";
            id_KategoriaLabel.Size = new System.Drawing.Size(66, 13);
            id_KategoriaLabel.TabIndex = 13;
            id_KategoriaLabel.Text = "id Kategoria:";
            // 
            // id_TipdocumentLabel
            // 
            id_TipdocumentLabel.AutoSize = true;
            id_TipdocumentLabel.Location = new System.Drawing.Point(12, 258);
            id_TipdocumentLabel.Name = "id_TipdocumentLabel";
            id_TipdocumentLabel.Size = new System.Drawing.Size(83, 13);
            id_TipdocumentLabel.TabIndex = 15;
            id_TipdocumentLabel.Text = "id Tipdocument:";
            // 
            // _bd_KorostylevDataSet
            // 
            this._bd_KorostylevDataSet.DataSetName = "_bd_KorostylevDataSet";
            this._bd_KorostylevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazBindingSource
            // 
            this.magazBindingSource.DataMember = "Magaz";
            this.magazBindingSource.DataSource = this._bd_KorostylevDataSet;
            // 
            // magazTableAdapter
            // 
            this.magazTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MagazTableAdapter = this.magazTableAdapter;
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
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // magazBindingNavigator
            // 
            this.magazBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.magazBindingNavigator.BindingSource = this.magazBindingSource;
            this.magazBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.magazBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.magazBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.magazBindingNavigatorSaveItem});
            this.magazBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.magazBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.magazBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.magazBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.magazBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.magazBindingNavigator.Name = "magazBindingNavigator";
            this.magazBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.magazBindingNavigator.Size = new System.Drawing.Size(307, 25);
            this.magazBindingNavigator.TabIndex = 0;
            this.magazBindingNavigator.Text = "bindingNavigator1";
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
            // magazBindingNavigatorSaveItem
            // 
            this.magazBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.magazBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("magazBindingNavigatorSaveItem.Image")));
            this.magazBindingNavigatorSaveItem.Name = "magazBindingNavigatorSaveItem";
            this.magazBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.magazBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.magazBindingNavigatorSaveItem.Click += new System.EventHandler(this.magazBindingNavigatorSaveItem_Click);
            // 
            // id_MagazTextBox
            // 
            this.id_MagazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Magaz", true));
            this.id_MagazTextBox.Location = new System.Drawing.Point(101, 73);
            this.id_MagazTextBox.Name = "id_MagazTextBox";
            this.id_MagazTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_MagazTextBox.TabIndex = 2;
            // 
            // prihod_magazTextBox
            // 
            this.prihod_magazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Prihod_magaz", true));
            this.prihod_magazTextBox.Location = new System.Drawing.Point(101, 99);
            this.prihod_magazTextBox.Name = "prihod_magazTextBox";
            this.prihod_magazTextBox.Size = new System.Drawing.Size(100, 20);
            this.prihod_magazTextBox.TabIndex = 4;
            // 
            // opt_cenaTextBox
            // 
            this.opt_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Opt_cena", true));
            this.opt_cenaTextBox.Location = new System.Drawing.Point(101, 125);
            this.opt_cenaTextBox.Name = "opt_cenaTextBox";
            this.opt_cenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.opt_cenaTextBox.TabIndex = 6;
            // 
            // ostat_magazTextBox
            // 
            this.ostat_magazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Ostat_magaz", true));
            this.ostat_magazTextBox.Location = new System.Drawing.Point(101, 151);
            this.ostat_magazTextBox.Name = "ostat_magazTextBox";
            this.ostat_magazTextBox.Size = new System.Drawing.Size(100, 20);
            this.ostat_magazTextBox.TabIndex = 8;
            // 
            // id_TovarTextBox
            // 
            this.id_TovarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Tovar", true));
            this.id_TovarTextBox.Location = new System.Drawing.Point(101, 177);
            this.id_TovarTextBox.Name = "id_TovarTextBox";
            this.id_TovarTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TovarTextBox.TabIndex = 10;
            // 
            // id_ChekTextBox
            // 
            this.id_ChekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Chek", true));
            this.id_ChekTextBox.Location = new System.Drawing.Point(101, 203);
            this.id_ChekTextBox.Name = "id_ChekTextBox";
            this.id_ChekTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ChekTextBox.TabIndex = 12;
            // 
            // id_KategoriaTextBox
            // 
            this.id_KategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Kategoria", true));
            this.id_KategoriaTextBox.Location = new System.Drawing.Point(101, 229);
            this.id_KategoriaTextBox.Name = "id_KategoriaTextBox";
            this.id_KategoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_KategoriaTextBox.TabIndex = 14;
            // 
            // id_TipdocumentTextBox
            // 
            this.id_TipdocumentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Tipdocument", true));
            this.id_TipdocumentTextBox.Location = new System.Drawing.Point(101, 255);
            this.id_TipdocumentTextBox.Name = "id_TipdocumentTextBox";
            this.id_TipdocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TipdocumentTextBox.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 325);
            this.Controls.Add(id_MagazLabel);
            this.Controls.Add(this.id_MagazTextBox);
            this.Controls.Add(prihod_magazLabel);
            this.Controls.Add(this.prihod_magazTextBox);
            this.Controls.Add(opt_cenaLabel);
            this.Controls.Add(this.opt_cenaTextBox);
            this.Controls.Add(ostat_magazLabel);
            this.Controls.Add(this.ostat_magazTextBox);
            this.Controls.Add(id_TovarLabel);
            this.Controls.Add(this.id_TovarTextBox);
            this.Controls.Add(id_ChekLabel);
            this.Controls.Add(this.id_ChekTextBox);
            this.Controls.Add(id_KategoriaLabel);
            this.Controls.Add(this.id_KategoriaTextBox);
            this.Controls.Add(id_TipdocumentLabel);
            this.Controls.Add(this.id_TipdocumentTextBox);
            this.Controls.Add(this.magazBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this._bd_KorostylevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingNavigator)).EndInit();
            this.magazBindingNavigator.ResumeLayout(false);
            this.magazBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _bd_KorostylevDataSet _bd_KorostylevDataSet;
        private System.Windows.Forms.BindingSource magazBindingSource;
        private _bd_KorostylevDataSetTableAdapters.MagazTableAdapter magazTableAdapter;
        private _bd_KorostylevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator magazBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton magazBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_MagazTextBox;
        private System.Windows.Forms.TextBox prihod_magazTextBox;
        private System.Windows.Forms.TextBox opt_cenaTextBox;
        private System.Windows.Forms.TextBox ostat_magazTextBox;
        private System.Windows.Forms.TextBox id_TovarTextBox;
        private System.Windows.Forms.TextBox id_ChekTextBox;
        private System.Windows.Forms.TextBox id_KategoriaTextBox;
        private System.Windows.Forms.TextBox id_TipdocumentTextBox;
    }
}