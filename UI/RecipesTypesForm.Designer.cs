﻿namespace CookBook.UI
{
    partial class RecipesTypesForm
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
            NewTypeTxt = new TextBox();
            RecipeTypesLbx = new ListBox();
            AddRecipeTypeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // NewTypeTxt
            // 
            NewTypeTxt.Location = new Point(78, 12);
            NewTypeTxt.Name = "NewTypeTxt";
            NewTypeTxt.Size = new Size(151, 23);
            NewTypeTxt.TabIndex = 1;
            // 
            // RecipeTypesLbx
            // 
            RecipeTypesLbx.FormattingEnabled = true;
            RecipeTypesLbx.ItemHeight = 15;
            RecipeTypesLbx.Location = new Point(25, 53);
            RecipeTypesLbx.Name = "RecipeTypesLbx";
            RecipeTypesLbx.Size = new Size(204, 184);
            RecipeTypesLbx.TabIndex = 2;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(25, 265);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(204, 23);
            AddRecipeTypeBtn.TabIndex = 3;
            AddRecipeTypeBtn.Text = "ADD";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipesTypesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipeTypesLbx);
            Controls.Add(NewTypeTxt);
            Controls.Add(label1);
            Name = "RecipesTypesForm";
            Text = "RecipesTypesForm";
            Load += RecipesTypesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewTypeTxt;
        private ListBox RecipeTypesLbx;
        private Button AddRecipeTypeBtn;
    }
}