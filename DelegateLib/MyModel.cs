using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLib
{
    public class MyModel
    {
        public EventHandler<MyEventArgs>? ValueChangedInformOthers;
        private double _ModelValue;

		public double ModelValue
		{
			get { return _ModelValue; }
			set {

                if (_ModelValue == value) return;
                
                double delta = _ModelValue - value;
                _ModelValue = value;
                //Wenn sich jemand beim Delegate angemeldet hat, dann wird er mittels Delegate / Event informiert
                ValueChangedInformOthers?.Invoke(this, new MyEventArgs { Value = value, Delta = delta, Description = "No Description" });

            }
		}

	}
}
