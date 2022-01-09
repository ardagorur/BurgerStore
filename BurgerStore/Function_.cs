using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerStore
{
    public static class Function_
    {
        public static void Clear(Control.ControlCollection controlCollection)
        {
            foreach (var item in controlCollection)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Text ="Küçük";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).Items.Clear();
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
            }
        }


        //    private static Dictionary<Type, Action<Control>> controldefaults = new Dictionary<Type, Action<Control>>() {
        //        {typeof(TextBox), c => ((TextBox)c).Clear()},
        //        {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
        //        {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
        //        {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
        //        {typeof(GroupBox), c => ((GroupBox)c).Controls.Clear()},
        //        {typeof(Panel), c => ((Panel)c).Controls.Clear()}
        //};

        //    private static void FindAndInvoke(Type type, Control control)
        //    {
        //        if (controldefaults.ContainsKey(type))
        //        {
        //            controldefaults[type].Invoke(control);
        //        }
        //    }

        //    public static void ClearControls(this Control.ControlCollection controls)
        //    {
        //        foreach (Control control in controls)
        //        {
        //            FindAndInvoke(control.GetType(), control);
        //        }
        //    }

        //    public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        //    {
        //        if (!controldefaults.ContainsKey(typeof(T))) return;

        //        foreach (Control control in controls)
        //        {
        //            if (control.GetType().Equals(typeof(T)))
        //            {
        //                FindAndInvoke(typeof(T), control);
        //            }
        //        }

        //    }
    }
}
