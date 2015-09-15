using KB4.Ashirov.Store.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model
{
     public class Periphery: BaseModel
    {
         //Наименование переферии (мишь, клава, колонки, принтер и т.д.)
         public string PeripheryName { get; set; }
         //Модель данной переферии
         public string PeripheryModel { get; set; }
         //Дата ее выпуска на производстве
        public DateTime DateOfCreate { get; set; }


    }
}
