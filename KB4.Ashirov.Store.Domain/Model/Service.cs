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
        public Computer Repair { get; set; }
        //сервис по ремонту мониторов
        public Monitor Repair { get; set; }
        //сервис по ремонту комплектующих
        public Periphery Repair { get; set; }
        //склад, либо место ремонта одно и тоже
        public Stock Stock { get; set; }
    }
}
