using CookBook.HELPER;
using DataAccessLayer.CONTRACTS;
using DataAccessLayer.CUSTOMQUERYRESULTS;
using DataAccessLayer.REPOSITORIES;
using DomainModel.MODELS;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace CookBook.UI
{
    public partial class RecipesForm : Form
    {
        //For any method under this class that need to work with RecipeTypes
        //will have access to this variable -->"_recipeTypeRepository "

        private readonly IRecipeTypesRepository _recipeTypeRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IRecipeRepository _recipeRepository;
        public RecipesForm(IRecipeTypesRepository recipeTypeRepository, IServiceProvider
            serviceProvider, IRecipeRepository recipeRepository)
        {
            InitializeComponent();
            _recipeTypeRepository = recipeTypeRepository;
            _recipeRepository = recipeRepository;
            _serviceProvider = serviceProvider;
            _recipeRepository.OnError += message => MessageBox.Show(message);


        }

        //private void OnErrorOccured(string message)
        //{
        //    MessageBox.Show(message);
        //}

        private Image _placeholderImage
        {
            get
            {   //executingAssemblyLocation...assembly any project in solution
                var executingAssemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var imagePath = Path.Combine(executingAssemblyLocation, "Assets\\IMAGES\\Image_placeholder.jpeg");
                return Image.FromFile(imagePath);
            }
        }
        private bool _isUserImageAdded = false;

        //METHOD TO DISPLAY RECIPE TYPES INSIDE COMBO BOX
        private async void RefreshRecipeTypes()
        {
            RecipeTypeCbx.DataSource = await _recipeTypeRepository.GetRecipeTypes();
            RecipeTypeCbx.DisplayMember = "Name";

        }
        //RecipesForm FORM LOAD EVENT
        private void RecipesForm_Load(object sender, EventArgs e)
        {
            CustomizeGridAppearance();
            RefreshRecipeTypes();
            RefreshRecipesGrid();
            RecipePictureBox.Image = _placeholderImage;
            RecipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void RefreshRecipesGrid()
        {
            RecipesGrid.DataSource = await _recipeRepository.GetRecipe();

        }

        private async void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<RecipesTypesForm>();
            form.FormClosed += OnRecipeTypeFormClosed;
            form.ShowDialog();
        }

        private void OnRecipeTypeFormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshRecipeTypes();
        }

        private async void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            byte[] image = null;
            if (_isUserImageAdded == true)
                image = ImageHelpers.CovertToDbImage(RecipePictureBox.ImageLocation);
            int recipeTypeId = ((RecipeType)RecipeTypeCbx.SelectedItem).Id;

            Recipe recipe = new Recipe(NameTxt.Text, DescriptionTxt.Text, image, recipeTypeId);
            await _recipeRepository.AddRecipe(recipe);
            ClearAllFields();

            RefreshRecipesGrid();
        }

        private void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            DescriptionTxt.Text = string.Empty;
            RecipePictureBox.Image = _placeholderImage;
            _isUserImageAdded = false;
        }

        private bool IsValid()
        {
            bool isValid = true;
            string message = "";

            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                isValid = false;
                message += "Please enter name.\n\n";
            }
            if (string.IsNullOrEmpty(DescriptionTxt.Text))
            {
                isValid = false;
                message += "Please enter Description.\n\n";
            }
            if (!isValid)
                MessageBox.Show(message);




            return isValid;
        }

        private void RecipePictureBox_Click(object sender, EventArgs e)
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Please select an image",
                Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RecipePictureBox.ImageLocation = openFileDialog.FileName;
                    RecipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    _isUserImageAdded = true;

                }

            }

        }

        private void ClearAllFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void CustomizeGridAppearance()
        {
            RecipesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RecipesGrid.AutoGenerateColumns = false;
            RecipesGrid.Columns.Clear();

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                Visible = false

            };
            columns[1] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            };
            columns[2] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            };
            columns[3] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Type",
                HeaderText = "Type"
            };

            columns[4] = new DataGridViewButtonColumn()
            {
                Text = "Edit",
                Name = "EditBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            columns[5] = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                Name = "DeleteBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            RecipesGrid.RowHeadersVisible = false;
            RecipesGrid.Columns.Clear();
            RecipesGrid.Columns.AddRange(columns);

        }

        private async void RecipesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0 && RecipesGrid.CurrentCell is DataGridViewButtonCell)
                {
                RecipeWithType clickedRecipe = (RecipeWithType)RecipesGrid.Rows[e.RowIndex].DataBoundItem;

                    if (RecipesGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                    {
                    await _recipeRepository.DeleteRecipe(clickedRecipe.Id);
                     RefreshRecipesGrid();
                    }
                    else if (RecipesGrid.CurrentCell.OwningColumn.Name == "EditBtn")
                    {
                        FillFormForEdit(clickedRecipe);
                    }
                }
            
        }

        private void FillFormForEdit(RecipeWithType clickedRecipe)
        {
            NameTxt.Text = clickedRecipe.Name;
            DescriptionTxt.Text = clickedRecipe.Description;
            if (clickedRecipe.Image != null)
                RecipePictureBox.Image = ImageHelpers.ConvertFromDbImage(clickedRecipe.Image);
            else
                RecipePictureBox.Image = _placeholderImage;
        }
    }


}
