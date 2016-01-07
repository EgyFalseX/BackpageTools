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
        public List<string> _headerList = new List<string>();
        public List<string> _bodyList = new List<string>();
        public List<string> _footerList = new List<string>();
        public List<int> _cats = new List<int>();
        public AddListPostDlg(string info, List<int> Cats = null)
        {
            InitializeComponent();
            
            // TODO: This line of code loads data into the 'dsQry.QryCategory' table. You can move, or remove it, as needed.
            this.categoryItemTableAdapter.Fill(this.dsData.CategoryItem);
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
            else
            {
                tbHeadser.EditValue = tbBody.EditValue = tbFooter.EditValue = string.Empty;
            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string[] lines;
            //Header
            lines = tbHeadser.EditValue.ToString().Split(';');
            foreach (string line in lines)
            {
                if (line.Trim() == string.Empty)
                    continue;
                _headerList.Add(line.Trim());
            }
            //Body
            lines = tbBody.EditValue.ToString().Split(';');
            foreach (string line in lines)
            {
                if (line.Trim() == string.Empty)
                    continue;
                _bodyList.Add(line.Trim());
            }
            //Footer
            lines = tbFooter.EditValue.ToString().Split(';');
            foreach (string line in lines)
            {
                if (line.Trim() == string.Empty)
                    continue;
                _footerList.Add(line.Trim());
            }
            foreach (System.Data.DataRowView item in clbc.CheckedItems)
            {
                Datasource.dsData.CategoryItemRow row = (Datasource.dsData.CategoryItemRow)item.Row;
                _cats.Add((int)row.CategoryItemId);
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