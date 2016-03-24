using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Isam
{
    class CComboBoxItem
    {
        public CComboBoxItem(string value, string text)
        {
            Text = text;
            Value = value;
        }

        public string Text
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
