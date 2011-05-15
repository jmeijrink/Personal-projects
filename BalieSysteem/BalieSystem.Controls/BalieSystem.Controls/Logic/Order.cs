using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalieSystem.Logic
{
    public class Order
    {
        DateTime _date = DateTime.Now;
        string _user;
        List<OrderLine> _orderLines = new List<OrderLine>();


    }
}
