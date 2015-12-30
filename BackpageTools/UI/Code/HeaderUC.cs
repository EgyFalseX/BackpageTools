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
    public partial class HeaderUC : DevExpress.XtraEditors.XtraUserControl
    {
        Datasource.dsDataTableAdapters.HeaderCategoryTableAdapter adpHeadCat = new Datasource.dsDataTableAdapters.HeaderCategoryTableAdapter();
        public HeaderUC()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            headerTableAdapter.Fill(dsData.Header);
        }
        private void UpdateRow(Datasource.dsData.ProxyRow row)
        {
            try
            {
                gridViewMain.ShowLoadingPanel();
                row.EndEdit();
                int effected = proxyTableAdapter.Update(row);
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
            UpdateRow((Datasource.dsData.ProxyRow)((DataRowView)e.Row).Row);

        }
        private void gridViewMain_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            UpdateRow((Datasource.dsData.ProxyRow)((DataRowView)e.Row).Row);
        }
        private void bbiAddBulk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dlg.AddListPostDlg dlgFrm = new dlg.AddListPostDlg("");
            if (dlgFrm.ShowDialog() == DialogResult.Cancel)
                return;
            int EffectedData = 0;
            foreach (string item in dlgFrm._itemList)
            {
                try
                {
                    int id = (int)headerTableAdapter.NewId();
                    EffectedData += headerTableAdapter.Insert(id, item);
                    if (EffectedData > 0)
                    {
                        foreach (int cat in dlgFrm._cats)
                            adpHeadCat.Insert(id, cat);
                    }
                }
                catch { }
            }
            LoadData();
            MessageBox.Show("Data added :" + EffectedData, "data saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

    }
}
