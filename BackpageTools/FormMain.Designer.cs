﻿namespace BackpageTools
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiProxy = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLoginInfo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPostList = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCity = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCategoryItem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPosts = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCode = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCode = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupPostEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManagerMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedViewMain = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMain
            // 
            this.ribbonControlMain.ExpandCollapseItem.Id = 0;
            this.ribbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMain.ExpandCollapseItem,
            this.bbiProxy,
            this.bbiLoginInfo,
            this.bbiPostList,
            this.bbiCity,
            this.bbiCategoryItem,
            this.bbiPosts,
            this.bbiMail});
            this.ribbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMain.MaxItemId = 8;
            this.ribbonControlMain.Name = "ribbonControlMain";
            this.ribbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCode});
            this.ribbonControlMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControlMain.Size = new System.Drawing.Size(1014, 143);
            // 
            // bbiProxy
            // 
            this.bbiProxy.Caption = "Proxy";
            this.bbiProxy.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiProxy.Glyph = global::BackpageTools.Properties.Resources.Proxy16;
            this.bbiProxy.Id = 1;
            this.bbiProxy.LargeGlyph = global::BackpageTools.Properties.Resources.Proxy32;
            this.bbiProxy.Name = "bbiProxy";
            this.bbiProxy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProxy_ItemClick);
            // 
            // bbiLoginInfo
            // 
            this.bbiLoginInfo.Caption = "LoginInfo";
            this.bbiLoginInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiLoginInfo.Glyph = global::BackpageTools.Properties.Resources.contact_16x16;
            this.bbiLoginInfo.Id = 2;
            this.bbiLoginInfo.LargeGlyph = global::BackpageTools.Properties.Resources.contact_32x32;
            this.bbiLoginInfo.Name = "bbiLoginInfo";
            this.bbiLoginInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLoginInfo_ItemClick);
            // 
            // bbiPostList
            // 
            this.bbiPostList.Caption = "Posts List";
            this.bbiPostList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPostList.Glyph = global::BackpageTools.Properties.Resources.openhyperlink_16x16;
            this.bbiPostList.Id = 3;
            this.bbiPostList.LargeGlyph = global::BackpageTools.Properties.Resources.openhyperlink_32x32;
            this.bbiPostList.Name = "bbiPostList";
            this.bbiPostList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPostList_ItemClick);
            // 
            // bbiCity
            // 
            this.bbiCity.Caption = "City";
            this.bbiCity.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiCity.Glyph = global::BackpageTools.Properties.Resources.bolocalization_16x16;
            this.bbiCity.Id = 4;
            this.bbiCity.LargeGlyph = global::BackpageTools.Properties.Resources.bolocalization_32x32;
            this.bbiCity.Name = "bbiCity";
            this.bbiCity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCity_ItemClick);
            // 
            // bbiCategoryItem
            // 
            this.bbiCategoryItem.Caption = "Category Item";
            this.bbiCategoryItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiCategoryItem.Glyph = global::BackpageTools.Properties.Resources.boemployee_16x16;
            this.bbiCategoryItem.Id = 5;
            this.bbiCategoryItem.LargeGlyph = global::BackpageTools.Properties.Resources.boemployee_32x32;
            this.bbiCategoryItem.Name = "bbiCategoryItem";
            this.bbiCategoryItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCategoryItem_ItemClick);
            // 
            // bbiPosts
            // 
            this.bbiPosts.Caption = "Posts Parts";
            this.bbiPosts.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPosts.Glyph = global::BackpageTools.Properties.Resources.bonote_16x16;
            this.bbiPosts.Id = 6;
            this.bbiPosts.LargeGlyph = global::BackpageTools.Properties.Resources.bonote_32x32;
            this.bbiPosts.Name = "bbiPosts";
            this.bbiPosts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPosts_ItemClick);
            // 
            // bbiMail
            // 
            this.bbiMail.Caption = "Mail";
            this.bbiMail.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiMail.Glyph = global::BackpageTools.Properties.Resources.mail_16x16;
            this.bbiMail.Id = 7;
            this.bbiMail.LargeGlyph = global::BackpageTools.Properties.Resources.mail_32x32;
            this.bbiMail.Name = "bbiMail";
            this.bbiMail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMail_ItemClick);
            // 
            // ribbonPageCode
            // 
            this.ribbonPageCode.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCode,
            this.ribbonPageGroupPostEdit});
            this.ribbonPageCode.Name = "ribbonPageCode";
            this.ribbonPageCode.Text = "Code";
            // 
            // ribbonPageGroupCode
            // 
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiProxy);
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiCategoryItem);
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiPostList);
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiMail);
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiLoginInfo);
            this.ribbonPageGroupCode.ItemLinks.Add(this.bbiCity);
            this.ribbonPageGroupCode.Name = "ribbonPageGroupCode";
            this.ribbonPageGroupCode.Text = "Code";
            // 
            // ribbonPageGroupPostEdit
            // 
            this.ribbonPageGroupPostEdit.ItemLinks.Add(this.bbiPosts);
            this.ribbonPageGroupPostEdit.Name = "ribbonPageGroupPostEdit";
            this.ribbonPageGroupPostEdit.Text = "Post Component";
            // 
            // documentManagerMain
            // 
            this.documentManagerMain.ContainerControl = this;
            this.documentManagerMain.MenuManager = this.ribbonControlMain;
            this.documentManagerMain.View = this.tabbedViewMain;
            this.documentManagerMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedViewMain});
            // 
            // tabbedViewMain
            // 
            this.tabbedViewMain.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabbedViewMain_QueryControl);
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 763);
            this.Controls.Add(this.ribbonControlMain);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControlMain;
            this.Text = "BackpageTools Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCode;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCode;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManagerMain;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedViewMain;
        private DevExpress.XtraBars.BarButtonItem bbiProxy;
        private DevExpress.XtraBars.BarButtonItem bbiLoginInfo;
        private DevExpress.XtraBars.BarButtonItem bbiPostList;
        private DevExpress.XtraBars.BarButtonItem bbiCity;
        private DevExpress.XtraBars.BarButtonItem bbiCategoryItem;
        private DevExpress.XtraBars.BarButtonItem bbiPosts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPostEdit;
        private DevExpress.XtraBars.BarButtonItem bbiMail;
    }
}

