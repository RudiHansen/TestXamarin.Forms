using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestXamarin.Forms.Models;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(TestXamarin.Forms.Services.MockDataStore))]
namespace TestXamarin.Forms.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 001", Description="This is an item description.", User="Tim", Color=Color.Black },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 002", Description="This is an item description.", User="Dan", Color=Color.LightBlue  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 003", Description="This is an item description.", User="Christa", Color=Color.Black  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 004", Description="This is an item description.", User="Tim", Color=Color.LightBlue  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 005", Description="This is an item description.", User="Dan", Color=Color.Black  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 006", Description="This is an item description.", User="Christa", Color=Color.LightBlue  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 007", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 008", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 009", Description="This is an item description.", User="Christa" , Color=Color.White },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 010", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 011", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 012", Description="This is an item description.", User="Christa", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 013", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 014", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 015", Description="This is an item description.", User="Christa", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 016", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 017", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 018", Description="This is an item description.", User="Christa", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 019", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 020", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 031", Description="This is an item description.", User="Christa", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 032", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 033", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 034", Description="This is an item description.", User="Christa", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 035", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 036", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 037", Description="This is an item description.", User="Christa", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 038", Description="This is an item description.", User="Tim", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 039", Description="This is an item description.", User="Dan", Color=Color.White  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Task 040", Description="This is an item description.", User="Christa", Color=Color.White  },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}