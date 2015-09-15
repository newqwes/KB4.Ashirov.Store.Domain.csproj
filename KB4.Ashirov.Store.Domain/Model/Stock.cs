using KB4.Ashirov.Store.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model
{
    public class Stock: BaseModel
    {
        //название склада, можно указать компанию либо сервис так же адрес
        public string Name { get; set; }
        //выбор услуги
        public StockType Type { get; set; }

        List<Service> Services { get; set; }
    }
}
