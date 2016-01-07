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
    public partial class PostEditorUC : DevExpress.XtraEditors.XtraUserControl
    {
        Datasource.dsDataTableAdapters.PostCategoryTableAdapter adpPostCat = new Datasource.dsDataTableAdapters.PostCategoryTableAdapter();
        public PostEditorUC()
        {
            InitializeComponent();
            postPartTypeTableAdapter.Fill(dsData.PostPartType);
            LoadData();
        }
        private void LoadData()
        {
            postsTableAdapter.Fill(dsData.Posts);
        }
        private void UpdateRow(Datasource.dsData.PostsRow row)
        {
            try
            {
                gridViewMain.ShowLoadingPanel();
                row.EndEdit();
                int effected = postsTableAdapter.Update(row);
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
            UpdateRow((Datasource.dsData.PostsRow)((DataRowView)e.Row).Row);

        }
        private void gridViewMain_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            UpdateRow((Datasource.dsData.PostsRow)((DataRowView)e.Row).Row);
        }
        private void bbiAddBulk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dlg.AddListPostDlg dlgFrm = new dlg.AddListPostDlg("");
            if (dlgFrm.ShowDialog() == DialogResult.Cancel)
                return;
            int EffectedData = 0;
            //Header
            foreach (string item in dlgFrm._headerList)
            {
                try
                {
                    int id = (int)postsTableAdapter.NewId();
                    int result = postsTableAdapter.Insert(id, item, (int)Core.Types.PostPartType.Header);
                    if (result > 0)
                    {
                        EffectedData += result;
                        foreach (int cat in dlgFrm._cats)
                            adpPostCat.Insert(id, cat);
                    }
                }
                catch { }
            }
            //Body
            foreach (string item in dlgFrm._bodyList)
            {
                try
                {
                    int id = (int)postsTableAdapter.NewId();
                    int result = postsTableAdapter.Insert(id, item, (int)Core.Types.PostPartType.Body);
                    if (result > 0)
                    {
                        EffectedData += result;
                        foreach (int cat in dlgFrm._cats)
                            adpPostCat.Insert(id, cat);
                    }
                }
                catch { }
            }
            //Footer
            foreach (string item in dlgFrm._footerList)
            {
                try
                {
                    int id = (int)postsTableAdapter.NewId();
                    int result = postsTableAdapter.Insert(id, item, (int)Core.Types.PostPartType.Footer);
                    if (result > 0)
                    {
                        EffectedData += result;
                        foreach (int cat in dlgFrm._cats)
                            adpPostCat.Insert(id, cat);
                    }
                }
                catch { }
            }
            LoadData();
            MessageBox.Show("Data added :" + EffectedData, "data saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void bbiEditPostCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewMain.GetSelectedRows() == null || gridViewMain.GetSelectedRows().Length == 0)
                return;
            dlg.AddListCategoryDlg dlg = new dlg.AddListCategoryDlg("You must check items to selected it");
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                foreach (int inx in gridViewMain.GetSelectedRows())
                {
                    Datasource.dsData.PostsRow row = (Datasource.dsData.PostsRow)((DataRowView)gridViewMain.GetRow(inx)).Row;
                    adpPostCat.DeleteByPostAutoId(row.PostAutoId);
                    foreach (int cat in dlg._cats)
                        adpPostCat.Insert(row.PostAutoId, cat);
                }
                MessageBox.Show("Data updated ...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
