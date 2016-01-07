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
    public partial class AddListCategoryDlg : DevExpress.XtraEditors.XtraForm
    {
        public List<int> _cats = new List<int>();
        public AddListCategoryDlg(string info)
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'dsData.CategoryItem' table. You can move, or remove it, as needed.
            this.categoryItemTableAdapter.Fill(this.dsData.CategoryItem);
            lblInfo.Text = info;
            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
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