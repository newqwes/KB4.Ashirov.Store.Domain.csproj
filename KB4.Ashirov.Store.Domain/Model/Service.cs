using KB4.Ashirov.Store.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model
{
    public class Service: BaseModel
    {
        //сервис по ремонту системного блока
        public List<Product> Repair { get; set; }
    }
}
