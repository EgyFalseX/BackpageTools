namespace BackpageTools.UI.Code
{
    partial class PostEditorUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new BackpageTools.Datasource.dsData();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPostAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostPartTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPostPartTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.postPartTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiAddBulk = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditPostCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.postsTableAdapter = new BackpageTools.Datasource.dsDataTableAdapters.PostsTableAdapter();
            this.postPartTypeTableAdapter = new BackpageTools.Datasource.dsDataTableAdapters.PostPartTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPostPartTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPartTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.postsBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 24);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditPostPartTypeId});
            this.gridControlMain.Size = new System.Drawing.Size(536, 326);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.dsData;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPostAutoId,
            this.colPostText,
            this.colPostPartTypeId});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click to add new";
            this.gridViewMain.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewMain.OptionsImageLoad.AsyncLoad = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewMain_RowDeleted);
            this.gridViewMain.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewMain_RowUpdated);
            // 
            // colPostAutoId
            // 
            this.colPostAutoId.AppearanceCell.Options.UseTextOptions = true;
            this.colPostAutoId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostAutoId.AppearanceHeader.Options.UseTextOptions = true;
            this.colPostAutoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostAutoId.Caption = "id";
            this.colPostAutoId.FieldName = "PostAutoId";
            this.colPostAutoId.Name = "colPostAutoId";
            this.colPostAutoId.Visible = true;
            this.colPostAutoId.VisibleIndex = 0;
            // 
            // colPostText
            // 
            this.colPostText.AppearanceCell.Options.UseTextOptions = true;
            this.colPostText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostText.AppearanceHeader.Options.UseTextOptions = true;
            this.colPostText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostText.Caption = "Post Text";
            this.colPostText.FieldName = "PostText";
            this.colPostText.Name = "colPostText";
            this.colPostText.Visible = true;
            this.colPostText.VisibleIndex = 1;
            this.colPostText.Width = 212;
            // 
            // colPostPartTypeId
            // 
            this.colPostPartTypeId.AppearanceCell.Options.UseTextOptions = true;
            this.colPostPartTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostPartTypeId.AppearanceHeader.Options.UseTextOptions = true;
            this.colPostPartTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostPartTypeId.Caption = "Post Type";
            this.colPostPartTypeId.ColumnEdit = this.repositoryItemLookUpEditPostPartTypeId;
            this.colPostPartTypeId.FieldName = "PostPartTypeId";
            this.colPostPartTypeId.Name = "colPostPartTypeId";
            this.colPostPartTypeId.Visible = true;
            this.colPostPartTypeId.VisibleIndex = 2;
            this.colPostPartTypeId.Width = 124;
            // 
            // repositoryItemLookUpEditPostPartTypeId
            // 
            this.repositoryItemLookUpEditPostPartTypeId.AutoHeight = false;
            this.repositoryItemLookUpEditPostPartTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPostPartTypeId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PostPartTypeName", "Name", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditPostPartTypeId.DataSource = this.postPartTypeBindingSource;
            this.repositoryItemLookUpEditPostPartTypeId.DisplayMember = "PostPartTypeName";
            this.repositoryItemLookUpEditPostPartTypeId.Name = "repositoryItemLookUpEditPostPartTypeId";
            this.repositoryItemLookUpEditPostPartTypeId.NullText = "";
            this.repositoryItemLookUpEditPostPartTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditPostPartTypeId.ValueMember = "PostPartTypeId";
            // 
            // postPartTypeBindingSource
            // 
            this.postPartTypeBindingSource.DataMember = "PostPartType";
            this.postPartTypeBindingSource.DataSource = this.dsData;
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAddBulk,
            this.bbiEditPostCategory});
            this.barManagerMain.MainMenu = this.bar2;
            this.barManagerMain.MaxItemId = 2;
            this.barManagerMain.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddBulk),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEditPostCategory)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiAddBulk
            // 
            this.bbiAddBulk.Caption = "Add Bulk";
            this.bbiAddBulk.Glyph = global::BackpageTools.Properties.Resources.addfile_16x16;
            this.bbiAddBulk.Id = 0;
            this.bbiAddBulk.LargeGlyph = global::BackpageTools.Properties.Resources.addfile_32x32;
            this.bbiAddBulk.Name = "bbiAddBulk";
            this.bbiAddBulk.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAddBulk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddBulk_ItemClick);
            // 
            // bbiEditPostCategory
            // 
            this.bbiEditPostCategory.Caption = "Edit selected post\'s category";
            this.bbiEditPostCategory.Glyph = global::BackpageTools.Properties.Resources.editname_16x16;
            this.bbiEditPostCategory.Id = 1;
            this.bbiEditPostCategory.Name = "bbiEditPostCategory";
            this.bbiEditPostCategory.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiEditPostCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditPostCategory_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(536, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 350);
            this.barDockControlBottom.Size = new System.Drawing.Size(536, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 326);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(536, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 326);
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // postPartTypeTableAdapter
            // 
            this.postPartTypeTableAdapter.ClearBeforeFill = true;
            // 
            // PostEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PostEditorUC";
            this.Size = new System.Drawing.Size(536, 373);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPostPartTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPartTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private Datasource.dsData dsData;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiAddBulk;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private Datasource.dsDataTableAdapters.PostsTableAdapter postsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPostAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPostText;
        private DevExpress.XtraGrid.Columns.GridColumn colPostPartTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPostPartTypeId;
        private System.Windows.Forms.BindingSource postPartTypeBindingSource;
        private Datasource.dsDataTableAdapters.PostPartTypeTableAdapter postPartTypeTableAdapter;
        private DevExpress.XtraBars.BarButtonItem bbiEditPostCategory;
    }
}
