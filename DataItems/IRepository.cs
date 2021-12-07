using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Scylab.Models;

namespace Scylab.DataItems
{
    public interface IRepository
    {
        IEnumerable<ItemModel> GetAllData();

        ItemModel GetItem(Guid Id);

        void AddItem(ItemModel Item);
    }
}
