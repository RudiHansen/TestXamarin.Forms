using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TestXamarin.Forms.Models;
using TestXamarin.Forms.ViewModels;
using System.Collections.Generic;

namespace TestXamarin.Forms.Views
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{
        public string[] users = { "Tim", "Dan", "Christa" };

        public class User
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public List<User> userList = new List<User>();

        ItemDetailViewModel viewModel;


        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
            userList.Add(new User { Name = "Tim", Description = "Tim Parson" });
            userList.Add(new User { Name = "Dan", Description = "Dan Parson" });
            userList.Add(new User { Name = "Christa", Description = "Christa Parson" });
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}