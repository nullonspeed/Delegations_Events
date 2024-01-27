using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLib
{
    public interface MyUcInterface
    {
        public MyModel UCModel { get; set; }
        public void ValueChangeFromOutside(object sender, MyEventArgs e);
    }
}
