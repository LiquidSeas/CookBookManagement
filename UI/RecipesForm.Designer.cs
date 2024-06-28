namespace CookBook.UI
{
    partial class RecipesForm
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
            label1 = new Label();
            AddRecipeTypeBtn = new Button();
            label2 = new Label();
            NameTxt = new TextBox();
            RecipeTypeCbx = new ComboBox();
            DescriptionTxt = new RichTextBox();
            label3 = new Label();
            RecipePictureBox = new PictureBox();
            label4 = new Label();
            AddRecipeBtn = new Button();
            RecipeIngredientsBtn = new Button();
            ClearAllFieldsBtn = new Button();
            RecipeFilterCbx = new ComboBox();
            RecipesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "NAME";
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(699, 58);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(60, 23);
            AddRecipeTypeBtn.TabIndex = 2;
            AddRecipeTypeBtn.Text = "ADD";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 62);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "TYPE";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(556, 20);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(203, 23);
            NameTxt.TabIndex = 4;
            // 
            // RecipeTypeCbx
            // 
            RecipeTypeCbx.FormattingEnabled = true;
            RecipeTypeCbx.Location = new Point(556, 59);
            RecipeTypeCbx.Name = "RecipeTypeCbx";
            RecipeTypeCbx.Size = new Size(137, 23);
            RecipeTypeCbx.TabIndex = 5;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(556, 97);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(203, 87);
            DescriptionTxt.TabIndex = 6;
            DescriptionTxt.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 132);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "DESCRIPTION";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(556, 190);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(203, 71);
            RecipePictureBox.TabIndex = 8;
            RecipePictureBox.TabStop = false;
            RecipePictureBox.Click += RecipePictureBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 215);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "IMAGE";
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Location = new Point(556, 276);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(203, 23);
            AddRecipeBtn.TabIndex = 10;
            AddRecipeBtn.Text = "Add recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // RecipeIngredientsBtn
            // 
            RecipeIngredientsBtn.Location = new Point(556, 305);
            RecipeIngredientsBtn.Name = "RecipeIngredientsBtn";
            RecipeIngredientsBtn.Size = new Size(203, 23);
            RecipeIngredientsBtn.TabIndex = 11;
            RecipeIngredientsBtn.Text = "Recipe ingredients";
            RecipeIngredientsBtn.UseVisualStyleBackColor = true;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(556, 334);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(203, 23);
            ClearAllFieldsBtn.TabIndex = 12;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // RecipeFilterCbx
            // 
            RecipeFilterCbx.FormattingEnabled = true;
            RecipeFilterCbx.Location = new Point(31, 25);
            RecipeFilterCbx.Name = "RecipeFilterCbx";
            RecipeFilterCbx.Size = new Size(436, 23);
            RecipeFilterCbx.TabIndex = 13;
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RecipesGrid.Location = new Point(31, 62);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.RowTemplate.Height = 25;
            RecipesGrid.Size = new Size(436, 295);
            RecipesGrid.TabIndex = 14;
            RecipesGrid.CellClick += RecipesGrid_CellClick;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RecipesGrid);
            Controls.Add(RecipeFilterCbx);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(RecipeIngredientsBtn);
            Controls.Add(AddRecipeBtn);
            Controls.Add(label4);
            Controls.Add(RecipePictureBox);
            Controls.Add(label3);
            Controls.Add(DescriptionTxt);
            Controls.Add(RecipeTypeCbx);
            Controls.Add(NameTxt);
            Controls.Add(label2);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(label1);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddRecipeTypeBtn;
        private Label label2;
        private TextBox NameTxt;
        private ComboBox RecipeTypeCbx;
        private RichTextBox DescriptionTxt;
        private Label label3;
        private PictureBox RecipePictureBox;
        private Label label4;
        private Button AddRecipeBtn;
        private Button RecipeIngredientsBtn;
        private Button ClearAllFieldsBtn;
        private ComboBox RecipeFilterCbx;
        private DataGridView RecipesGrid;
    }
}