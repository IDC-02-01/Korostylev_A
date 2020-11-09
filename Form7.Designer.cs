namespace WindowsFormsApp4
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label id_PostavshikLabel;
            System.Windows.Forms.Label postavshikLabel;
            System.Windows.Forms.Label id_adressLabel;
            this._bd_KorostylevDataSet = new WindowsFormsApp4._bd_KorostylevDataSet();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.PostavshikTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.TableAdapterManager();
            this.postavshikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.postavshikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_PostavshikTextBox = new System.Windows.Forms.TextBox();
            this.postavshikTextBox = new System.Windows.Forms.TextBox();
            this.id_adressTextBox = new System.Windows.Forms.TextBox();
            id_PostavshikLabel = new System.Windows.Forms.Label();
            postavshikLabel = new System.Windows.Forms.Label();
            id_adressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bd_KorostylevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).BeginInit();
            this.postavshikBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bd_KorostylevDataSet
            // 
            this._bd_KorostylevDataSet.DataSetName = "_bd_KorostylevDataSet";
            this._bd_KorostylevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this._bd_KorostylevDataSet;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PostavshikTableAdapter = this.postavshikTableAdapter;
            this.tableAdapterManager.RaionTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TipDokumentTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp4._bd_KorostylevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postavshikBindingNavigator
            // 
            this.postavshikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postavshikBindingNavigator.BindingSource = this.postavshikBindingSource;
            this.postavshikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postavshikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postavshikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postavshikBindingNavigatorSaveItem});
            this.postavshikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postavshikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postavshikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postavshikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postavshikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postavshikBindingNavigator.Name = "postavshikBindingNavigator";
            this.postavshikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postavshikBindingNavigator.Size = new System.Drawing.Size(328, 25);
            this.postavshikBindingNavigator.TabIndex = 0;
            this.postavshikBindingNavigator.Text = "bindingNavigator1";
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
            // postavshikBindingNavigatorSaveItem
            // 
            this.postavshikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postavshikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postavshikBindingNavigatorSaveItem.Image")));
            this.postavshikBindingNavigatorSaveItem.Name = "postavshikBindingNavigatorSaveItem";
            this.postavshikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.postavshikBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postavshikBindingNavigatorSaveItem.Click += new System.EventHandler(this.postavshikBindingNavigatorSaveItem_Click_1);
            // 
            // id_PostavshikLabel
            // 
            id_PostavshikLabel.AutoSize = true;
            id_PostavshikLabel.Location = new System.Drawing.Point(12, 52);
            id_PostavshikLabel.Name = "id_PostavshikLabel";
            id_PostavshikLabel.Size = new System.Drawing.Size(73, 13);
            id_PostavshikLabel.TabIndex = 1;
            id_PostavshikLabel.Text = "id Postavshik:";
            // 
            // id_PostavshikTextBox
            // 
            this.id_PostavshikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "id_Postavshik", true));
            this.id_PostavshikTextBox.Location = new System.Drawing.Point(91, 49);
            this.id_PostavshikTextBox.Name = "id_PostavshikTextBox";
            this.id_PostavshikTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_PostavshikTextBox.TabIndex = 2;
            // 
            // postavshikLabel
            // 
            postavshikLabel.AutoSize = true;
            postavshikLabel.Location = new System.Drawing.Point(12, 78);
            postavshikLabel.Name = "postavshikLabel";
            postavshikLabel.Size = new System.Drawing.Size(62, 13);
            postavshikLabel.TabIndex = 3;
            postavshikLabel.Text = "Postavshik:";
            // 
            // postavshikTextBox
            // 
            this.postavshikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Postavshik", true));
            this.postavshikTextBox.Location = new System.Drawing.Point(91, 75);
            this.postavshikTextBox.Name = "postavshikTextBox";
            this.postavshikTextBox.Size = new System.Drawing.Size(100, 20);
            this.postavshikTextBox.TabIndex = 4;
            // 
            // id_adressLabel
            // 
            id_adressLabel.AutoSize = true;
            id_adressLabel.Location = new System.Drawing.Point(12, 104);
            id_adressLabel.Name = "id_adressLabel";
            id_adressLabel.Size = new System.Drawing.Size(52, 13);
            id_adressLabel.TabIndex = 5;
            id_adressLabel.Text = "id adress:";
            // 
            // id_adressTextBox
            // 
            this.id_adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "id_adress", true));
            this.id_adressTextBox.Location = new System.Drawing.Point(91, 101);
            this.id_adressTextBox.Name = "id_adressTextBox";
            this.id_adressTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_adressTextBox.TabIndex = 6;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 171);
            this.Controls.Add(id_PostavshikLabel);
            this.Controls.Add(this.id_PostavshikTextBox);
            this.Controls.Add(postavshikLabel);
            this.Controls.Add(this.postavshikTextBox);
            this.Controls.Add(id_adressLabel);
            this.Controls.Add(this.id_adressTextBox);
            this.Controls.Add(this.postavshikBindingNavigator);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this._bd_KorostylevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).EndInit();
            this.postavshikBindingNavigator.ResumeLayout(false);
            this.postavshikBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _bd_KorostylevDataSet _bd_KorostylevDataSet;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private _bd_KorostylevDataSetTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private _bd_KorostylevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postavshikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postavshikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_PostavshikTextBox;
        private System.Windows.Forms.TextBox postavshikTextBox;
        private System.Windows.Forms.TextBox id_adressTextBox;
    }
}