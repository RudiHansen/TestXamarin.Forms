using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using TestXamarin.Forms.Models;
using TestXamarin.Forms.Views;

namespace TestXamarin.Forms.ViewModels
{
    public class UsersViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public Command LoadItemsCommand { get; set; }
        public UsersViewModel()
        {
            Title = "Browse";
            Users = new ObservableCollection<User>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await Task.Run(() => 
                {
                    Users.Clear();
                    Users.Add(new User { Name = "Tim", Description = "Tim Parson" });
                    Users.Add(new User { Name = "Dan", Description = "Dan Parson" });
                    Users.Add(new User { Name = "Christa", Description = "Christa Parson" });
                });
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
