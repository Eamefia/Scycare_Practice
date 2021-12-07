using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Scylab.Models;
using Scylab.DataItems;

namespace Scylab.Controllers
{
    [Route("[controller]")]
    public class ItemsController
    {
        private readonly IRepository _irepository;

        private ItemsController(IRepository irepository){
            this._irepository = irepository;
        }
        
        public IEnumerable<ItemModel> GetAllData()
        {
           return _irepository.GetAllData();
        }
    }
}
