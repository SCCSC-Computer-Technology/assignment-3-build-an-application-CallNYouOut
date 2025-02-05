namespace CGaffney206Lab3
{
    partial class frmStateDetails
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
            System.Windows.Forms.Label stateIdLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label state_Flag_DescriptionLabel;
            System.Windows.Forms.Label state_FlowerLabel;
            System.Windows.Forms.Label state_BirdLabel;
            System.Windows.Forms.Label state_ColorsLabel;
            System.Windows.Forms.Label top_3_Largest_CitiesLabel;
            System.Windows.Forms.Label state_CapitolLabel;
            System.Windows.Forms.Label median_IncomeLabel;
            System.Windows.Forms.Label percentage_of_Computer_Related_Jobs_OfferedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStateDetails));
            this.statesDataSet = new CGaffney206Lab3.StatesDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new CGaffney206Lab3.StatesDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new CGaffney206Lab3.StatesDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateIdTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.state_Flag_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.state_FlowerTextBox = new System.Windows.Forms.TextBox();
            this.state_BirdTextBox = new System.Windows.Forms.TextBox();
            this.state_ColorsTextBox = new System.Windows.Forms.TextBox();
            this.top_3_Largest_CitiesTextBox = new System.Windows.Forms.TextBox();
            this.state_CapitolTextBox = new System.Windows.Forms.TextBox();
            this.median_IncomeTextBox = new System.Windows.Forms.TextBox();
            this.percentage_of_Computer_Related_Jobs_OfferedTextBox = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            stateIdLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            state_Flag_DescriptionLabel = new System.Windows.Forms.Label();
            state_FlowerLabel = new System.Windows.Forms.Label();
            state_BirdLabel = new System.Windows.Forms.Label();
            state_ColorsLabel = new System.Windows.Forms.Label();
            top_3_Largest_CitiesLabel = new System.Windows.Forms.Label();
            state_CapitolLabel = new System.Windows.Forms.Label();
            median_IncomeLabel = new System.Windows.Forms.Label();
            percentage_of_Computer_Related_Jobs_OfferedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateIdLabel
            // 
            stateIdLabel.AutoSize = true;
            stateIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateIdLabel.Location = new System.Drawing.Point(567, 108);
            stateIdLabel.Name = "stateIdLabel";
            stateIdLabel.Size = new System.Drawing.Size(128, 32);
            stateIdLabel.TabIndex = 1;
            stateIdLabel.Text = "State Id:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(600, 161);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(95, 32);
            stateLabel.TabIndex = 3;
            stateLabel.Text = "State:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            populationLabel.Location = new System.Drawing.Point(525, 223);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(170, 32);
            populationLabel.TabIndex = 5;
            populationLabel.Text = "Population:";
            // 
            // state_Flag_DescriptionLabel
            // 
            state_Flag_DescriptionLabel.AutoSize = true;
            state_Flag_DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_Flag_DescriptionLabel.Location = new System.Drawing.Point(370, 276);
            state_Flag_DescriptionLabel.Name = "state_Flag_DescriptionLabel";
            state_Flag_DescriptionLabel.Size = new System.Drawing.Size(325, 32);
            state_Flag_DescriptionLabel.TabIndex = 7;
            state_Flag_DescriptionLabel.Text = "State Flag Description:";
            // 
            // state_FlowerLabel
            // 
            state_FlowerLabel.AutoSize = true;
            state_FlowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_FlowerLabel.Location = new System.Drawing.Point(501, 343);
            state_FlowerLabel.Name = "state_FlowerLabel";
            state_FlowerLabel.Size = new System.Drawing.Size(194, 32);
            state_FlowerLabel.TabIndex = 9;
            state_FlowerLabel.Text = "State Flower:";
            // 
            // state_BirdLabel
            // 
            state_BirdLabel.AutoSize = true;
            state_BirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_BirdLabel.Location = new System.Drawing.Point(537, 388);
            state_BirdLabel.Name = "state_BirdLabel";
            state_BirdLabel.Size = new System.Drawing.Size(158, 32);
            state_BirdLabel.TabIndex = 11;
            state_BirdLabel.Text = "State Bird:";
            // 
            // state_ColorsLabel
            // 
            state_ColorsLabel.AutoSize = true;
            state_ColorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_ColorsLabel.Location = new System.Drawing.Point(504, 435);
            state_ColorsLabel.Name = "state_ColorsLabel";
            state_ColorsLabel.Size = new System.Drawing.Size(191, 32);
            state_ColorsLabel.TabIndex = 13;
            state_ColorsLabel.Text = "State Colors:";
            // 
            // top_3_Largest_CitiesLabel
            // 
            top_3_Largest_CitiesLabel.AutoSize = true;
            top_3_Largest_CitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            top_3_Largest_CitiesLabel.Location = new System.Drawing.Point(398, 486);
            top_3_Largest_CitiesLabel.Name = "top_3_Largest_CitiesLabel";
            top_3_Largest_CitiesLabel.Size = new System.Drawing.Size(296, 32);
            top_3_Largest_CitiesLabel.TabIndex = 15;
            top_3_Largest_CitiesLabel.Text = "Top 3 Largest Cities:";
            // 
            // state_CapitolLabel
            // 
            state_CapitolLabel.AutoSize = true;
            state_CapitolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_CapitolLabel.Location = new System.Drawing.Point(495, 546);
            state_CapitolLabel.Name = "state_CapitolLabel";
            state_CapitolLabel.Size = new System.Drawing.Size(200, 32);
            state_CapitolLabel.TabIndex = 17;
            state_CapitolLabel.Text = "State Capitol:";
            // 
            // median_IncomeLabel
            // 
            median_IncomeLabel.AutoSize = true;
            median_IncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            median_IncomeLabel.Location = new System.Drawing.Point(465, 600);
            median_IncomeLabel.Name = "median_IncomeLabel";
            median_IncomeLabel.Size = new System.Drawing.Size(229, 32);
            median_IncomeLabel.TabIndex = 19;
            median_IncomeLabel.Text = "Median Income:";
            // 
            // percentage_of_Computer_Related_Jobs_OfferedLabel
            // 
            percentage_of_Computer_Related_Jobs_OfferedLabel.AutoSize = true;
            percentage_of_Computer_Related_Jobs_OfferedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            percentage_of_Computer_Related_Jobs_OfferedLabel.Location = new System.Drawing.Point(-27, 651);
            percentage_of_Computer_Related_Jobs_OfferedLabel.Name = "percentage_of_Computer_Related_Jobs_OfferedLabel";
            percentage_of_Computer_Related_Jobs_OfferedLabel.Size = new System.Drawing.Size(651, 32);
            percentage_of_Computer_Related_Jobs_OfferedLabel.TabIndex = 21;
            percentage_of_Computer_Related_Jobs_OfferedLabel.Text = "Percentage of Computer-Related Jobs Offered:";
            // 
            // statesDataSet
            // 
            this.statesDataSet.DataSetName = "StatesDataSet";
            this.statesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.statesDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = CGaffney206Lab3.StatesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.statesBindingNavigatorSaveItem});
            this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesBindingNavigator.Name = "statesBindingNavigator";
            this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesBindingNavigator.Size = new System.Drawing.Size(1303, 38);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 32);
            this.statesBindingNavigatorSaveItem.Text = "Save Data";
            this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
            // 
            // stateIdTextBox
            // 
            this.stateIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateId", true));
            this.stateIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateIdTextBox.Location = new System.Drawing.Point(721, 105);
            this.stateIdTextBox.Name = "stateIdTextBox";
            this.stateIdTextBox.Size = new System.Drawing.Size(103, 39);
            this.stateIdTextBox.TabIndex = 2;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State", true));
            this.stateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.Location = new System.Drawing.Point(721, 158);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(429, 39);
            this.stateTextBox.TabIndex = 4;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Population", true));
            this.populationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationTextBox.Location = new System.Drawing.Point(721, 216);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(290, 39);
            this.populationTextBox.TabIndex = 6;
            // 
            // state_Flag_DescriptionTextBox
            // 
            this.state_Flag_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Flag Description", true));
            this.state_Flag_DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_Flag_DescriptionTextBox.Location = new System.Drawing.Point(721, 273);
            this.state_Flag_DescriptionTextBox.Name = "state_Flag_DescriptionTextBox";
            this.state_Flag_DescriptionTextBox.Size = new System.Drawing.Size(429, 39);
            this.state_Flag_DescriptionTextBox.TabIndex = 8;
            // 
            // state_FlowerTextBox
            // 
            this.state_FlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Flower", true));
            this.state_FlowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_FlowerTextBox.Location = new System.Drawing.Point(721, 340);
            this.state_FlowerTextBox.Name = "state_FlowerTextBox";
            this.state_FlowerTextBox.Size = new System.Drawing.Size(429, 39);
            this.state_FlowerTextBox.TabIndex = 10;
            // 
            // state_BirdTextBox
            // 
            this.state_BirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Bird", true));
            this.state_BirdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_BirdTextBox.Location = new System.Drawing.Point(721, 385);
            this.state_BirdTextBox.Name = "state_BirdTextBox";
            this.state_BirdTextBox.Size = new System.Drawing.Size(429, 39);
            this.state_BirdTextBox.TabIndex = 12;
            // 
            // state_ColorsTextBox
            // 
            this.state_ColorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Colors", true));
            this.state_ColorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_ColorsTextBox.Location = new System.Drawing.Point(721, 430);
            this.state_ColorsTextBox.Name = "state_ColorsTextBox";
            this.state_ColorsTextBox.Size = new System.Drawing.Size(429, 39);
            this.state_ColorsTextBox.TabIndex = 14;
            // 
            // top_3_Largest_CitiesTextBox
            // 
            this.top_3_Largest_CitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Top 3 Largest Cities", true));
            this.top_3_Largest_CitiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_3_Largest_CitiesTextBox.Location = new System.Drawing.Point(721, 483);
            this.top_3_Largest_CitiesTextBox.Name = "top_3_Largest_CitiesTextBox";
            this.top_3_Largest_CitiesTextBox.Size = new System.Drawing.Size(429, 39);
            this.top_3_Largest_CitiesTextBox.TabIndex = 16;
            // 
            // state_CapitolTextBox
            // 
            this.state_CapitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Capitol", true));
            this.state_CapitolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_CapitolTextBox.Location = new System.Drawing.Point(721, 543);
            this.state_CapitolTextBox.Name = "state_CapitolTextBox";
            this.state_CapitolTextBox.Size = new System.Drawing.Size(429, 39);
            this.state_CapitolTextBox.TabIndex = 18;
            // 
            // median_IncomeTextBox
            // 
            this.median_IncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Median Income", true));
            this.median_IncomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.median_IncomeTextBox.Location = new System.Drawing.Point(721, 597);
            this.median_IncomeTextBox.Name = "median_IncomeTextBox";
            this.median_IncomeTextBox.Size = new System.Drawing.Size(258, 39);
            this.median_IncomeTextBox.TabIndex = 20;
            // 
            // percentage_of_Computer_Related_Jobs_OfferedTextBox
            // 
            this.percentage_of_Computer_Related_Jobs_OfferedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Percentage of Computer-Related Jobs Offered", true));
            this.percentage_of_Computer_Related_Jobs_OfferedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage_of_Computer_Related_Jobs_OfferedTextBox.Location = new System.Drawing.Point(757, 648);
            this.percentage_of_Computer_Related_Jobs_OfferedTextBox.Name = "percentage_of_Computer_Related_Jobs_OfferedTextBox";
            this.percentage_of_Computer_Related_Jobs_OfferedTextBox.Size = new System.Drawing.Size(142, 39);
            this.percentage_of_Computer_Related_Jobs_OfferedTextBox.TabIndex = 22;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(520, 769);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(266, 83);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmStateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 897);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(stateIdLabel);
            this.Controls.Add(this.stateIdTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(state_Flag_DescriptionLabel);
            this.Controls.Add(this.state_Flag_DescriptionTextBox);
            this.Controls.Add(state_FlowerLabel);
            this.Controls.Add(this.state_FlowerTextBox);
            this.Controls.Add(state_BirdLabel);
            this.Controls.Add(this.state_BirdTextBox);
            this.Controls.Add(state_ColorsLabel);
            this.Controls.Add(this.state_ColorsTextBox);
            this.Controls.Add(top_3_Largest_CitiesLabel);
            this.Controls.Add(this.top_3_Largest_CitiesTextBox);
            this.Controls.Add(state_CapitolLabel);
            this.Controls.Add(this.state_CapitolTextBox);
            this.Controls.Add(median_IncomeLabel);
            this.Controls.Add(this.median_IncomeTextBox);
            this.Controls.Add(percentage_of_Computer_Related_Jobs_OfferedLabel);
            this.Controls.Add(this.percentage_of_Computer_Related_Jobs_OfferedTextBox);
            this.Controls.Add(this.statesBindingNavigator);
            this.Name = "frmStateDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Details";
            this.Load += new System.EventHandler(this.frmStateDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatesDataSet statesDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StatesDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private StatesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stateIdTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox state_Flag_DescriptionTextBox;
        private System.Windows.Forms.TextBox state_FlowerTextBox;
        private System.Windows.Forms.TextBox state_BirdTextBox;
        private System.Windows.Forms.TextBox state_ColorsTextBox;
        private System.Windows.Forms.TextBox top_3_Largest_CitiesTextBox;
        private System.Windows.Forms.TextBox state_CapitolTextBox;
        private System.Windows.Forms.TextBox median_IncomeTextBox;
        private System.Windows.Forms.TextBox percentage_of_Computer_Related_Jobs_OfferedTextBox;
        private System.Windows.Forms.Button btnReturn;
    }
}