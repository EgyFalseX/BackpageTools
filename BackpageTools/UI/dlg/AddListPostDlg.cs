using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BackpageTools.UI.dlg
{
    public partial class AddListPostDlg : DevExpress.XtraEditors.XtraForm
    {
        public List<string> _itemList = new List<string>();
        public List<int> _cats = new List<int>();
        public AddListPostDlg(string info, List<int> Cats = null)
        {
            // TODO: This line of code loads data into the 'dsQry.QryCategory' table. You can move, or remove it, as needed.
            this.qryCategoryTableAdapter.Fill(this.dsQry.QryCategory);
            InitializeComponent();
            lblInfo.Text = info;
            
            if (Cats != null)
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in clbc.Items)
                {
                    foreach (int cat in Cats)
                    {
                        if ((int)item.Value == cat)
                        {
                            item.CheckState = CheckState.Checked;
                            break;
                        }
                    }
                }
            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string[] lines = tbData.EditValue.ToString().Split('\n');
            foreach (string line in lines)
            {
                if (line.Trim() == string.Empty)
                    continue;
                _itemList.Add(line.Trim());
            }
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in clbc.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    _cats.Add((int)item.Value);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            return;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            return;
        }
        
    }
}