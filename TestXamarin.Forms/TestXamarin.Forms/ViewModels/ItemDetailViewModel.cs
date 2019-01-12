using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using TestXamarin.Forms.Models;

namespace TestXamarin.Forms.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public IList<User> Users { get { return UserData.Users; } }

        User selectedUser;

        public User SelectedUser
        {
            get
            {
                selectedUser = Users.Where(x => x.Name == Item.User).FirstOrDefault();
                return selectedUser;
            }
            set
            {
                if (selectedUser != value)
                {
                    selectedUser = value;
                    Item.User = selectedUser.Name;
                    OnPropertyChanged();
                }
            }
        }

        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
