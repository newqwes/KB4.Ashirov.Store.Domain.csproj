using KB4.Ashirov.Store.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model
{
    public class Role: BaseModel
    {
        //Роль(категория) товара, пример: для офиса или для дома, игр и т.п.
        public string Name { get; set; }


    }
}
