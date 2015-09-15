using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB4.Ashirov.Store.Domain.Model.Common
{
    public abstract class BaseModel
    {
        //считываем с БД наименования (ID), а также други данных, всех принадлежностей(товаров) магазина
        public int Id { get; set; }
    }
}
