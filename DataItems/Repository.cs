using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor.RichTextEditor;
using Scylab.Models;

namespace Scylab.DataItems
{
    public class Repository : IRepository
    {
        List<ItemModel> Items = new List<ItemModel>(){
                new ItemModel {Id = Guid.NewGuid(), ItemName = "Laboratory", ItemCategory = "LaboratoryTest", ItemQuantity = 100, Unit = 1, NetAmount = 100, Tax = "VAT", GrossAmount = 200 },
                new ItemModel {Id = Guid.NewGuid(), ItemName = "Malaria", ItemCategory = "Consultation", ItemQuantity = 190, Unit = 1, NetAmount = 90, Tax = "Direct Payment", GrossAmount = 190 },
                new ItemModel {Id = Guid.NewGuid(), ItemName = "Typhoid", ItemCategory = "LaboratoryTest", ItemQuantity = 100, Unit = 1, NetAmount = 100, Tax = "VAT", GrossAmount = 200 },
                new ItemModel {Id = Guid.NewGuid(), ItemName = "Malaria", ItemCategory = "Consultation", ItemQuantity = 190, Unit = 1, NetAmount = 90, Tax = "Direct Payment", GrossAmount = 190 },
    };
        public IEnumerable<ItemModel> GetAllData(){
            return Items;
        }
        public ItemModel GetItem(Guid Id)
        {
           ItemModel item_find =  Items.Find(x=> x.Id == Id);
            return item_find;
        }

        public void AddItem(ItemModel Item)
        {
            ItemModel new_item = Item;
            Items.Add(new_item);
        }
    }
}
