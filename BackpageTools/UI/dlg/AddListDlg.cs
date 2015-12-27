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
    public partial class AddListDlg : DevExpress.XtraEditors.XtraForm
    {
        public List<string> ItemList = new List<string>();
        public AddListDlg(string info)
        {
            InitializeComponent();
            lblInfo.Text = info;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string[] lines = tbData.EditValue.ToString().Split('\n');
            foreach (string line in lines)
            {
                if (line.Trim() == string.Empty)
                    continue;
                ItemList.Add(line.Trim());
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