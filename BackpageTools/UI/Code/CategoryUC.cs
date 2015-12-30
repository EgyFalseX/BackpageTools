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
    public partial class CategoryUC : DevExpress.XtraEditors.XtraUserControl
    {

        public CategoryUC()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            categoryTableAdapter.Fill(dsData.Category);
        }
        private void UpdateRow(Datasource.dsData.CategoryRow row)
        {
            try
            {
                gridViewMain.ShowLoadingPanel();
                row.EndEdit();
                int effected = categoryTableAdapter.Update(row);
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
            UpdateRow((Datasource.dsData.CategoryRow)((DataRowView)e.Row).Row);
        }
        private void gridViewMain_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            UpdateRow((Datasource.dsData.CategoryRow)((DataRowView)e.Row).Row);
        }
        private void bbiAddBulk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dlg.AddListDlg dlgFrm = new dlg.AddListDlg("You must enter Section:SectionId:Category:CategoryId");
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
                        MessageBox.Show("Wrong data formate" + Environment.NewLine + "You must enter Section:SectionId:Category:CategoryId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    EffectedData += categoryTableAdapter.Insert(cells[0], cells[1], cells[2], cells[3]);
                }
                catch { }
            }
            LoadData();
            MessageBox.Show("Data added :" + EffectedData, "data saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
