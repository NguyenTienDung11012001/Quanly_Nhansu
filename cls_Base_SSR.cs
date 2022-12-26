using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhansu
{
    public class cls_Base_SSR
    {
        public static void ManagerControl(Form frm, int state)
        {
            switch (state)
            {
                case 1:
                    ID_Search_State(frm);
                    break;
                case 2:
                    Name_Search_State(frm);
                    break;
                case 3:
                    Done_Search_State(frm);
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
                    if (name.Substring(0, 5) == "txtMa")
                    {
                        c.Enabled = true;
                        c.BackColor = Color.White;
                    }
                    else
                    {
                        c.Enabled = false;
                        c.BackColor = Color.FromArgb(61, 61, 59);
                    }
                    c.Text = "";
                }

                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (name.Substring(0, 5) == "rdoMa")
                        rb.Checked = true;
                    else
                        rb.Checked = false;
                }

                if (c is DataGridView)
                    c.Enabled = true;

                if (c is Button)
                {
                    if (name != "btnStt" && name != "btnReport")
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
            }
        }

        private static void ID_Search_State(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                string name = (string)c.Name;
                if (c is TextBox)
                {
                    if (name.Substring(0, 5) == "txtMa")
                    {
                        c.Enabled = true;
                        c.BackColor = Color.White;
                    }
                    else
                    {
                        c.Enabled = false;
                        c.BackColor = Color.FromArgb(61, 61, 59);
                    }
                    c.Text = "";
                }

                if (c is Button)
                {
                    if (name != "btnStt" && name != "btnReport")
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
            }
        }

        private static void Name_Search_State(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                string name = (string)c.Name;
                if (c is TextBox)
                {
                    if (name.Substring(0, 5) == "txtMa")
                    {
                        c.Enabled = false;
                        c.BackColor = Color.FromArgb(61, 61, 59);
                    }
                    else
                    {
                        c.Enabled = true;
                        c.BackColor = Color.White;
                    }
                    c.Text = "";
                }

                if (c is Button)
                {
                    if (name != "btnStt" && name != "btnReport")
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
            }
        }

        private static void Done_Search_State(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.BackColor = Color.FromArgb(102, 102, 98);
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
