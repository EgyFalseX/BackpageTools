using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackpageTools
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UI.Code.ProxyUC docProxyCtr = new UI.Code.ProxyUC();
        UI.Code.LoginInfoUC docLoginInfoCtr = new UI.Code.LoginInfoUC();
        UI.Code.PostListUC docPostListCtr = new UI.Code.PostListUC();
        UI.Code.CityUC docCityCtr = new UI.Code.CityUC();
        UI.Code.CategoryUC docCategoryCtr = new UI.Code.CategoryUC();

        public FormMain()
        {
            InitializeComponent();
        }
        private void ActivateDoc(string controlName, string caption, Image img)
        {
            try
            {
                foreach (var doc in tabbedViewMain.Documents)
                {
                    if (doc.ControlName == controlName)
                        return;
                }
                DevExpress.XtraBars.Docking2010.Views.Tabbed.Document nDoc = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
                nDoc.Caption = caption;
                nDoc.Image = img;
                nDoc.ControlName = controlName;
                tabbedViewMain.Documents.Add(nDoc);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void tabbedViewMain_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Control != null)
                return;
            if (e.Document.ControlName == "ProxyUC")
            {
                e.Control = docProxyCtr;
            }
            else if (e.Document.ControlName == "LoginInfoUC")
            {
                e.Control = docLoginInfoCtr;
            }
            else if (e.Document.ControlName == "PostListUC")
            {
                e.Control = docPostListCtr;
            }
            else if (e.Document.ControlName == "CityUC")
            {
                e.Control = docCityCtr;
            }
            else if (e.Document.ControlName == "CategoryUC")
            {
                e.Control = docCategoryCtr;
            }
        }

        private void bbiProxy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            docProxyCtr = new UI.Code.ProxyUC();
            ActivateDoc(docProxyCtr.Name, e.Item.Caption, e.Item.Glyph);
        }
        private void bbiLoginInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            docLoginInfoCtr = new UI.Code.LoginInfoUC();
            ActivateDoc(docLoginInfoCtr.Name, e.Item.Caption, e.Item.Glyph);
        }
        private void bbiPostList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            docPostListCtr = new UI.Code.PostListUC();
            ActivateDoc(docPostListCtr.Name, e.Item.Caption, e.Item.Glyph);
        }
        private void bbiCity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            docCityCtr = new UI.Code.CityUC();
            ActivateDoc(docCityCtr.Name, e.Item.Caption, e.Item.Glyph);
        }
        private void bbiCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            docCategoryCtr = new UI.Code.CategoryUC();
            ActivateDoc(docCategoryCtr.Name, e.Item.Caption, e.Item.Glyph);
        }

    }
}
