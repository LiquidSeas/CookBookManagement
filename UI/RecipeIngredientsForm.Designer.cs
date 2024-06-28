namespace CookBook.UI
{
    partial class RecipeIngredientsForm
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
            label2 = new Label();
            AllIngredientsLbx = new ListBox();
            RecipeIngredientsLbx = new ListBox();
            RemoveIngredientBtn = new Button();
            AddIngredientBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 44);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 0;
            label1.Text = "All Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 360);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // AllIngredientsLbx
            // 
            AllIngredientsLbx.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AllIngredientsLbx.FormattingEnabled = true;
            AllIngredientsLbx.ItemHeight = 15;
            AllIngredientsLbx.Location = new Point(39, 88);
            AllIngredientsLbx.Margin = new Padding(3, 4, 3, 4);
            AllIngredientsLbx.Name = "AllIngredientsLbx";
            AllIngredientsLbx.Size = new Size(121, 154);
            AllIngredientsLbx.TabIndex = 2;
            // 
            // RecipeIngredientsLbx
            // 
            RecipeIngredientsLbx.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RecipeIngredientsLbx.FormattingEnabled = true;
            RecipeIngredientsLbx.ItemHeight = 15;
            RecipeIngredientsLbx.Location = new Point(214, 88);
            RecipeIngredientsLbx.Margin = new Padding(3, 4, 3, 4);
            RecipeIngredientsLbx.Name = "RecipeIngredientsLbx";
            RecipeIngredientsLbx.Size = new Size(121, 154);
            RecipeIngredientsLbx.TabIndex = 3;
            // 
            // RemoveIngredientBtn
            // 
            RemoveIngredientBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveIngredientBtn.Location = new Point(214, 266);
            RemoveIngredientBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveIngredientBtn.Name = "RemoveIngredientBtn";
            RemoveIngredientBtn.Size = new Size(120, 24);
            RemoveIngredientBtn.TabIndex = 4;
            RemoveIngredientBtn.Text = "Remove Ingredient";
            RemoveIngredientBtn.UseVisualStyleBackColor = true;
            // 
            // AddIngredientBtn
            // 
            AddIngredientBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddIngredientBtn.Location = new Point(39, 266);
            AddIngredientBtn.Margin = new Padding(3, 4, 3, 4);
            AddIngredientBtn.Name = "AddIngredientBtn";
            AddIngredientBtn.Size = new Size(120, 24);
            AddIngredientBtn.TabIndex = 5;
            AddIngredientBtn.Text = "Add Ingredient";
            AddIngredientBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 44);
            label3.Name = "label3";
            label3.Size = new Size(192, 30);
            label3.TabIndex = 6;
            label3.Text = "Recipe Ingredients";
            label3.Click += label3_Click;
            // 
            // RecipeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 748);
            Controls.Add(label3);
            Controls.Add(AddIngredientBtn);
            Controls.Add(RemoveIngredientBtn);
            Controls.Add(RecipeIngredientsLbx);
            Controls.Add(AllIngredientsLbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeIngredientsForm";
            Text = "RecipeIngredientsForm";
            Load += RecipeIngredientsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox AllIngredientsLbx;
        private ListBox RecipeIngredientsLbx;
        private Button RemoveIngredientBtn;
        private Button AddIngredientBtn;
        private Label label3;
    }
}