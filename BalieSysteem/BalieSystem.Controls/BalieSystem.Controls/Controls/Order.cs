using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace BalieSystem.Controls
{
    /// <summary>
    /// Summary description for Order
    /// </summary>
    public class Order : System.Web.UI.WebControls.WebControl
    {
        DateTime _orderDate = DateTime.Now;
        int? _supplier = null;
        string _user = null;

        public Order()
        {
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
            }
        }

        public int? Supplier
        {
            get
            {
                return _supplier;
            }
            set
            {
                _supplier = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            // perform all tasks necessary to render successfully

        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            base.RenderControl(writer);
            //Render the control
            writer.Write("boe");
        }

        private void RenderOrderLine()
        {

        }

        public void GetMostRecentOrder()
        {

        }
    }
}