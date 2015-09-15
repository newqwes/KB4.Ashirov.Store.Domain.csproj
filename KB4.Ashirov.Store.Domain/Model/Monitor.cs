using KB4.Ashirov.Store.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model
{
    public class Monitor: BaseModel
    {
        //Фирма монитора
        public string MonitorName { get; set; }
        //Модель монитора
        public string MonitorModel { get; set; }
        //Дата выпукса монитора
        public DateTime DateOfCreate { get; set; }

    }
}
