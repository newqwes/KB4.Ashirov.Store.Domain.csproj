using KB4.Ashirov.Store.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model
{
    public class Computer: BaseModel

    {
        //Наименования компьютера (системного блока)
        public string ComputerName { get; set; }
        //Модель и часть описания компьютера
        public string ComputerModel { get; set; }
        //Дата выпуска системного блока и его комплектующих
        public DateTime DateOfCreate { get; set; }


    }
}
