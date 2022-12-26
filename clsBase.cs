using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhansu
{
    public class clsBase
    {
        public static void ManagerControl(Form frm, int state)
        {
            switch (state)
            {
                case 1:
                    InsertState(frm);
                    break;
                case 2:
                    UpdateState(frm);
                    break;
                default:
                    NewState(frm);
                    break;
            }
        }
        private static void NewState(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                string name = (string)c.Name;
                if (c is TextBox)
                {
                    c.Enabled = false;
                    c.BackColor = Color.FromArgb(61,61,59);
                    c.Text = "";
                }
                if (c is DataGridView)
                    c.Enabled = true;

                if (c is Button)
                {
                    if (name != "btnLuu" && name != "btnHuy")
                    {
                        c.Enabled = true;
                        c.BackColor = Color.FromArgb(102, 102, 98); 
                    }
                    else
                    {
                        c.Enabled = false;
                        c.BackColor = Color.FromArgb(61, 61, 59); 
                    }
                }

                if (c is ComboBox)
                {
                    c.Enabled = false;
                }

                if (c is DateTimePicker)
                {
                    c.Enabled = false;
                }
            }
        }

        private static void InsertState(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                string name = (string)c.Name;
                if (c is TextBox)
                {
                    c.Enabled = true;
                    c.BackColor = Color.White;
                }

                if (c is DataGridView)
                    c.Enabled = false;

                if (c is Button)
                {
                    if (name != "btnLuu" && name != "btnHuy")
                    {
                        c.Enabled = false;
                        c.BackColor = Color.FromArgb(61, 61, 59); 
                    }
                    else
                    {
                        c.Enabled = true;
                        c.BackColor = Color.FromArgb(102,102,98); 
                    }
                }

                if (c is ComboBox)
                {
                    c.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    c.Enabled = true;
                }
            }
        }

        private static void UpdateState(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                string name = (string)c.Name;
                if (c is TextBox)
                {
                    if (name.Substring(0, 5) == "txtMa")
                    {
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = true;
                        c.BackColor = Color.White; 
                    }
                }

                if (c is DataGridView)
                    c.Enabled = false;

                if (c is Button)
                {
                    if (name != "btnLuu" && name != "btnHuy")
                    {
                        c.Enabled = false;
                        c.BackColor = Color.FromArgb(61, 61, 59);
                    }
                    else
                    {
                        c.Enabled = true;
                        c.BackColor = Color.FromArgb(102,102,98);
                    }
                }

                if (c is ComboBox)
                {
                    c.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    c.Enabled = true;
                }
            }
        }

        public static void CloseForm(Form frm)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                frm.Close();
        }
    }
}
