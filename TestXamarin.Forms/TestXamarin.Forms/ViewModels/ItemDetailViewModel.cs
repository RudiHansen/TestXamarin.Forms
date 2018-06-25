using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestXamarin.Forms.Models;

namespace TestXamarin.Forms.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
