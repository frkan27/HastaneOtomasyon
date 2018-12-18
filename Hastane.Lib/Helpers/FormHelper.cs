using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.Lib.Helpers
{
   public static class FormHelper
    {
        public static void FormuTemizle(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else if (control is ComboBox cmb)
                    cmb.SelectedIndex = -1;
                else if (control is ListBox lst)
                    lst.SelectedIndex = -1;
                else if (control is DateTimePicker dtp)
                    dtp.Value = DateTime.Now;
                else if (control is CheckedListBox chk)
                    chk.SelectedIndex = -1;
                else if (control is PictureBox pcb)
                    pcb.Image = null;
            }
        }
        public static void ListBoxYenile<T>(ListBox lstBox, List<T> data) where T : Kisi
        {
            lstBox.DataSource = data;
        }
    }
}
