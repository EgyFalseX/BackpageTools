using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackpageTools.UI.Code
{
    public partial class PostListUC : DevExpress.XtraEditors.XtraUserControl
    {
        public PostListUC()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            postListTableAdapter.Fill(dsData.PostList);
        }
        private void UpdateRow(Datasource.dsData.PostListRow row)
        {
            try
            {
                gridViewMain.ShowLoadingPanel();
                row.EndEdit();
                int effected = postListTableAdapter.Update(row);
                if (effected == 0)
                {
                    MessageBox.Show("No data saved ...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (gridViewMain.LoadingPanelVisible)
                gridViewMain.HideLoadingPanel();
        }
        private void gridViewMain_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            UpdateRow((Datasource.dsData.PostListRow)((DataRowView)e.Row).Row);
        }
        private void gridViewMain_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            UpdateRow((Datasource.dsData.PostListRow)((DataRowView)e.Row).Row);
        }
        private void bbiAddBulk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dlg.AddListDlg dlgFrm = new dlg.AddListDlg("You must enter category:link");
            if (dlgFrm.ShowDialog() == DialogResult.Cancel)
                return;
            int EffectedData = 0;
            foreach (string item in dlgFrm.ItemList)
            {
                try
                {
                    string[] cells = item.Split(':');
                    if (cells.Length < 2)
                    {
                        MessageBox.Show("Wrong data formate" + Environment.NewLine + "You must enter category:link", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    EffectedData += postListTableAdapter.Insert(cells[0], cells[1]);
                }
                catch { }
            }
            LoadData();
            MessageBox.Show("Data added :" + EffectedData, "data saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
