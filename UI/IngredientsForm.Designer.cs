namespace CookBook.UI
{
    partial class IngredientsForm
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
            NameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TypeTxt = new TextBox();
            AddToFridgeBtn = new Button();
            WeightPer100gNum = new NumericUpDown();
            KcalPer100gNum = new NumericUpDown();
            PricePer100gNum = new NumericUpDown();
            IngredientsGrid = new DataGridView();
            hScrollBar1 = new HScrollBar();
            SearchTxt = new TextBox();
            EditIngredientBtn = new Button();
            ClearAllFieldsBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)WeightPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(649, 41);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(123, 23);
            NameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(500, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(500, 78);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(500, 117);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 3;
            label3.Text = "Weight (g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(500, 156);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 4;
            label4.Text = "Kcal (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(500, 184);
            label5.Name = "label5";
            label5.Size = new Size(138, 28);
            label5.TabIndex = 5;
            label5.Text = "Price per 100g";
            // 
            // TypeTxt
            // 
            TypeTxt.Location = new Point(649, 78);
            TypeTxt.Name = "TypeTxt";
            TypeTxt.Size = new Size(123, 23);
            TypeTxt.TabIndex = 6;
            // 
            // AddToFridgeBtn
            // 
            AddToFridgeBtn.Location = new Point(649, 231);
            AddToFridgeBtn.Name = "AddToFridgeBtn";
            AddToFridgeBtn.Size = new Size(123, 23);
            AddToFridgeBtn.TabIndex = 9;
            AddToFridgeBtn.Text = "Add To Fridge";
            AddToFridgeBtn.UseVisualStyleBackColor = true;
            AddToFridgeBtn.Click += AddToFridgeBtn_Click;
            // 
            // WeightPer100gNum
            // 
            WeightPer100gNum.DecimalPlaces = 2;
            WeightPer100gNum.Location = new Point(649, 117);
            WeightPer100gNum.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            WeightPer100gNum.Name = "WeightPer100gNum";
            WeightPer100gNum.Size = new Size(123, 23);
            WeightPer100gNum.TabIndex = 10;
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.DecimalPlaces = 2;
            KcalPer100gNum.Location = new Point(649, 156);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(123, 23);
            KcalPer100gNum.TabIndex = 11;
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(649, 185);
            PricePer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(123, 23);
            PricePer100gNum.TabIndex = 12;
            // 
            // IngredientsGrid
            // 
            IngredientsGrid.BackgroundColor = SystemColors.ActiveCaption;
            IngredientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsGrid.Location = new Point(52, 53);
            IngredientsGrid.Name = "IngredientsGrid";
            IngredientsGrid.RowTemplate.Height = 25;
            IngredientsGrid.Size = new Size(403, 253);
            IngredientsGrid.TabIndex = 13;
            IngredientsGrid.CellClick += IngredientsGrid_CellClick;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(716, 0);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(8, 8);
            hScrollBar1.TabIndex = 14;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(52, 24);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "Type ingredient name to search";
            SearchTxt.Size = new Size(403, 23);
            SearchTxt.TabIndex = 15;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // EditIngredientBtn
            // 
            EditIngredientBtn.Location = new Point(649, 231);
            EditIngredientBtn.Name = "EditIngredientBtn";
            EditIngredientBtn.Size = new Size(123, 23);
            EditIngredientBtn.TabIndex = 16;
            EditIngredientBtn.Text = "Edit";
            EditIngredientBtn.UseVisualStyleBackColor = true;
            EditIngredientBtn.Click += EditIngredientBtn_Click;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(649, 271);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(123, 23);
            ClearAllFieldsBtn.TabIndex = 17;
            ClearAllFieldsBtn.Text = "Clear all";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(EditIngredientBtn);
            Controls.Add(SearchTxt);
            Controls.Add(hScrollBar1);
            Controls.Add(IngredientsGrid);
            Controls.Add(PricePer100gNum);
            Controls.Add(KcalPer100gNum);
            Controls.Add(WeightPer100gNum);
            Controls.Add(AddToFridgeBtn);
            Controls.Add(TypeTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameTxt);
            Name = "IngredientsForm";
            Text = "IngredientsForm";
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)WeightPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TypeTxt;
        private Button AddToFridgeBtn;
        private NumericUpDown WeightPer100gNum;
        private NumericUpDown KcalPer100gNum;
        private NumericUpDown PricePer100gNum;
        private DataGridView IngredientsGrid;
        private HScrollBar hScrollBar1;
        private TextBox SearchTxt;
        private Button EditIngredientBtn;
        private Button ClearAllFieldsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}