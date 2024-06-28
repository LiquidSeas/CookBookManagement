using DataAccessLayer.CONTRACTS;
using DataAccessLayer.REPOSITORIES;
using DomainModel.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class RecipesTypesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypeRepository;
        public RecipesTypesForm(IRecipeTypesRepository recipeTypeRepository)
        {
            InitializeComponent();
            _recipeTypeRepository = recipeTypeRepository;

            //HANDLER->> OnErrorOccured Of the event OnError
            //_recipeTypeRepository.OnError += OnErrorOccured;
            //lambda expression(=>)
            _recipeTypeRepository.OnError += (message)=> MessageBox.Show(message);
        }

        //private void OnErrorOccured(string message)
        //{
        //    MessageBox.Show(message);
        //}

        private void RecipesTypesForm_Load(object sender, EventArgs e)
        {
            RefreshRecipesTypesList();
        }

        private async void RefreshRecipesTypesList()
        {


            RecipeTypesLbx.DataSource = await _recipeTypeRepository.GetRecipeTypes();
            RecipeTypesLbx.DisplayMember = "Name";

        }

        private async void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewTypeTxt.Text))
                return;
            RecipeType recipeType = new RecipeType();
            recipeType.Name = NewTypeTxt.Text;
            await _recipeTypeRepository.AddRecipeTypes(recipeType);
            RefreshRecipesTypesList();
            NewTypeTxt.Text = null;


        }
        
    }
}
