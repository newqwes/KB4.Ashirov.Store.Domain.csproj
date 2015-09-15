using KB4.Ashirov.Store.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model
{
   public class Product: BaseModel
    {
            
        //Наименования компьютера (системного блока)
        public string ProductName { get; set; }
        //Модель и часть описания компьютера
        public string ProductModel { get; set; }
        public string ProductDescription { get; set; }

        //Дата выпуска системного блока и его комплектующих
        public DateTime DateOfCreate { get; set; }


    

    }
}
