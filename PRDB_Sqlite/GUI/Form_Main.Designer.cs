namespace PRDB_Sqlite.GUI
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl_Tuyen_Independence = new DevExpress.XtraBars.Ribbon.RibbonControl();
            //các nút lệnh trên ribbon để thực hiện các thao tác như tạo mới, mở, lưu, xóa, đóng cơ sở dữ liệu, lược đồ, quan hệ hoặc truy vấn.
            this.barButtonItemNewDB = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenDB = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSaveDB = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCloseDb = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewScheme = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditScheme = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenScheme = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteScheme = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCloseCurrentScheme = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewRelation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditRelation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenRelation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteRelation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCloseCurrentRelation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNewQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSaveQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExcuteQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCloseCurrentQuery = new DevExpress.XtraBars.BarButtonItem();

            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem_Hoi_Ignor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Hoi_independence = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Hoi_mutualexclusion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Tuyen_ignorance = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Tuyen_mutualexclusion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Tru_ignorance = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Tru_independence = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Tru_mutualexclusion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Bang_ignorance = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Bang_independence = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Bang_mutualexclusion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Tuyen_independence = new DevExpress.XtraBars.BarButtonItem();
            // Trang chứa các nút lệnh cho thao tác với cơ sở dữ liệu.
            this.ribbonPageDB = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            //Các trang chứa các nút lệnh cho thao tác với lược đồ
            this.ribbonPageScheme = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            //Các trang chứa các nút lệnh cho thao tác với quan hệ.
            this.ribbonPageRelation = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNewRelation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSaveRelation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupOpenRelation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDeleteRelation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCloseCurrentRelation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            //Các trang chứa các nút lệnh cho thao tác với truy vấn.
            this.ribbonPageQuery = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup20 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup21 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup22 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup23 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupConjuntion = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDisjunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup24 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup25 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();

            //Một control chia màn hình thành hai phần, thường được sử dụng để hiển thị dữ liệu theo cấu trúc cây (treeview) ở một bên và chi tiết dữ liệu ở bên kia.
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            //Hiển thị danh sách các mục dưới dạng cây thư mục, có thể là các cơ sở dữ liệu, lược đồ hoặc quan hệ.
            this.TreeView = new System.Windows.Forms.TreeView();
            //Dùng để hiển thị các điều khiển như các nút điều hướng dữ liệu (Home, Previous, Next, End).
            this.ToolStripTitleOV = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.xtraTabDatabase = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageScheme = new DevExpress.XtraTab.XtraTabPage();
            //Sử dụng để hiển thị thông tin lược đồ như thuộc tính, kiểu dữ liệu, miền giá trị (domain) và mô tả.
            this.gridControlScheme = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPrimary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumnAttribute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageRelation = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BindingNavigatorData = new System.Windows.Forms.ToolStrip();
            this.btn_Data_Home = new System.Windows.Forms.ToolStripButton();
            this.btn_Data_Pre = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDataRowNumberIndicator = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Data_Next = new System.Windows.Forms.ToolStripButton();
            this.btn_Data_End = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Data_DeleteRow = new System.Windows.Forms.ToolStripButton();
            this.Btn_Data_ClearData = new System.Windows.Forms.ToolStripButton();
            this.Btn_Data_UpdateData = new System.Windows.Forms.ToolStripButton();
            //Hiển thị dữ liệu của các quan hệ xác suất, cho phép thao tác và chỉnh sửa trực tiếp giá trị và xác suất.
            this.GridViewData = new System.Windows.Forms.DataGridView();
            this.GridViewValue = new System.Windows.Forms.DataGridView();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMinProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValue = new DevExpress.XtraEditors.MemoEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.xtraTabPageQuery = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            //Một RichTextBox để nhập các câu truy vấn.
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.xtraTabControlQueryResult = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageQueryResult = new DevExpress.XtraTab.XtraTabPage();
            //Hiển thị kết quả truy vấn.
            this.GridViewResult = new System.Windows.Forms.DataGridView();
            this.MessageQuery = new DevExpress.XtraTab.XtraTabPage();
            //Hiển thị thông báo lỗi hoặc kết quả trong quá trình thực thi truy vấn.
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            //Định nghĩa các menu ngữ cảnh (chuột phải) cho các thao tác trên cơ sở dữ liệu, lược đồ, quan hệ và truy vấn (ví dụ: mở, xóa, đổi tên).
            this.ContextMenu_Database = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuDB_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuDB_CloseDB = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Schema = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuSchema_NewSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuSchema_DelSchemas = new System.Windows.Forms.ToolStripMenuItem();
            this.openSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_SchemaNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuSchNode_EditSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuSchNode_OpenSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuSchNode_DeleteSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Relation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuRelation_NewRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuRelation_DeleteRelations = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_RelationNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuRelNode_OpenRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuRelNode_DeleteRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuRelNode_RenameRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Query = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuQuery_NewQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuQuery_DeleteQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_QueryNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuQueryNode_OpenQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuQuery_DeleteQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuQuery_RenameQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList_TreeView = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl_Tuyen_Independence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.ToolStripTitleOV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabDatabase)).BeginInit();
            this.xtraTabDatabase.SuspendLayout();
            this.xtraTabPageScheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xtraTabPageRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.BindingNavigatorData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            this.xtraTabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlQueryResult)).BeginInit();
            this.xtraTabControlQueryResult.SuspendLayout();
            this.xtraTabPageQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResult)).BeginInit();
            this.MessageQuery.SuspendLayout();
            this.ContextMenu_Database.SuspendLayout();
            this.ContextMenu_Schema.SuspendLayout();
            this.ContextMenu_SchemaNode.SuspendLayout();
            this.ContextMenu_Relation.SuspendLayout();
            this.ContextMenu_RelationNode.SuspendLayout();
            this.ContextMenu_Query.SuspendLayout();
            this.contextMenu_QueryNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            //Đây là một thành phần của DevExpress dùng để quản lý phong cách (skin) giao diện của toàn bộ ứng dụng.
            // 
            // defaultLookAndFeel1
            // 
            //thiết lập để áp dụng phong cách giao diện cụ thể. Trong trường hợp này, phong cách được chọn là "Office 2007 Blue", mang lại giao diện giống như Office 2007 với màu xanh dương chủ đạo.
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // ribbonControl_Tuyen_Independence
            // 
            //Đây là thanh Ribbon của DevExpress, cung cấp giao diện người dùng hiện đại với các tab và nhóm lệnh.
            //Đặt văn bản cho nút ứng dụng (nếu có). Ở đây, giá trị được đặt là null, nghĩa là không có văn bản hiển thị.
            this.ribbonControl_Tuyen_Independence.ApplicationButtonText = null;
            //Đặt ID cho nút mở rộng/thu gọn Ribbon.
            this.ribbonControl_Tuyen_Independence.ExpandCollapseItem.Id = 0;
            //Thiết lập font chữ cho Ribbon, ở đây sử dụng "Lucida Sans Unicode" với kích thước 8.25pt và kiểu chữ thường.
            this.ribbonControl_Tuyen_Independence.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //Items.AddRange: Thêm một loạt các BarItem (nút lệnh) vào Ribbon. Các BarItem này bao gồm các nút để quản lý
            //cơ sở dữ liệu (barButtonItemNewDB, barButtonItemOpenDB,...), lược đồ (barButtonItemNewScheme,...), quan hệ (barButtonItemNewRelation,...), và truy vấn (barButtonItemNewQuery,...).
            this.ribbonControl_Tuyen_Independence.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl_Tuyen_Independence.ExpandCollapseItem,
            this.ribbonControl_Tuyen_Independence.SearchEditItem,
            this.barButtonItemNewDB,
            this.barButtonItemOpenDB,
            this.barButtonItemSaveDB,
            this.barButtonItemCloseDb,
            this.barButtonItemExit,
            this.barButtonItem6,
            this.barButtonItemNewScheme,
            this.barButtonItemEditScheme,
            this.barButtonItemOpenScheme,
            this.barButtonItemDeleteScheme,
            this.barButtonItemCloseCurrentScheme,
            this.barButtonItem7,
            this.barButtonItemNewRelation,
            this.barButtonItemEditRelation,
            this.barButtonItemOpenRelation,
            this.barButtonItemDeleteRelation,
            this.barButtonItemCloseCurrentRelation,
            this.barButtonItem8,
            this.barButtonItemNewQuery,
            this.barButtonItemSaveQuery,
            this.barButtonItemOpenQuery,
            this.barButtonItemDeleteQuery,
            this.barButtonItemExcuteQuery,
            this.barButtonItemCloseCurrentQuery,
            this.barButtonGroup1,
            this.barButtonItem_Hoi_Ignor,
            this.barButtonItem_Hoi_independence,
            this.barButtonItem_Hoi_mutualexclusion,
            this.barButtonItem_Tuyen_ignorance,
            this.barButtonItem_Tuyen_mutualexclusion,
            this.barButtonItem_Tru_ignorance,
            this.barButtonItem_Tru_independence,
            this.barButtonItem_Tru_mutualexclusion,
            this.barButtonItem_Bang_ignorance,
            this.barButtonItem_Bang_independence,
            this.barButtonItem_Bang_mutualexclusion,
            this.barButtonItem_Tuyen_independence});
            //Đặt vị trí của Ribbon trên form, ở đây là góc trên bên trái (0, 0).
            this.ribbonControl_Tuyen_Independence.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl_Tuyen_Independence.MaxItemId = 46;
            this.ribbonControl_Tuyen_Independence.Name = "ribbonControl_Tuyen_Independence";
            //Pages.AddRange: Thêm các trang chính vào Ribbon
            this.ribbonControl_Tuyen_Independence.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageDB, //Trang quản lý cơ sở dữ liệu
            this.ribbonPageScheme, // Trang quản lý lược đồ.
            this.ribbonPageRelation, //Trang quản lý quan hệ.
            this.ribbonPageQuery}); //Trang quản lý truy vấn.
            // Đặt kích thước của Ribbon, ở đây là chiều rộng 1155 pixel và chiều cao 142 pixel.
            this.ribbonControl_Tuyen_Independence.Size = new System.Drawing.Size(1155, 142);
            //Sự kiện này được kích hoạt khi trang hiện tại của Ribbon đang thay đổi. Phương thức xử lý là ribbonControl1_SelectedPageChanging.
            this.ribbonControl_Tuyen_Independence.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.ribbonControl1_SelectedPageChanging);
            //Sự kiện này được kích hoạt sau khi trang của Ribbon đã thay đổi. Phương thức xử lý là ribbonControl1_SelectedPageChanged.
            this.ribbonControl_Tuyen_Independence.SelectedPageChanged += new System.EventHandler(this.ribbonControl1_SelectedPageChanged);
            // 
            // barButtonItemNewDB : Nút lệnh để tạo mới cơ sở dữ liệu.
            // 
            this.barButtonItemNewDB.Caption = "New Database";
            this.barButtonItemNewDB.Id = 1;
            this.barButtonItemNewDB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewDB.ImageOptions.LargeImage")));
            this.barButtonItemNewDB.Name = "barButtonItemNewDB";
            this.barButtonItemNewDB.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemNewDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewDB_ItemClick);
            // 
            // barButtonItemOpenDB: Nút lệnh để mở cơ sở dữ liệu hiện có.
            // 
            this.barButtonItemOpenDB.Caption = "Open Existing Database";
            this.barButtonItemOpenDB.Id = 2;
            this.barButtonItemOpenDB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenDB.ImageOptions.LargeImage")));
            this.barButtonItemOpenDB.Name = "barButtonItemOpenDB";
            this.barButtonItemOpenDB.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemOpenDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenDB_ItemClick);
            // 
            // barButtonItemSaveDB: Nút lệnh để lưu cơ sở dữ liệu.
            // 
            this.barButtonItemSaveDB.Caption = "Save Database";
            this.barButtonItemSaveDB.Id = 3;
            this.barButtonItemSaveDB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaveDB.ImageOptions.LargeImage")));
            this.barButtonItemSaveDB.Name = "barButtonItemSaveDB";
            this.barButtonItemSaveDB.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemSaveDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSaveDB_ItemClick);
            // 
            // barButtonItemCloseDb
            // 
            this.barButtonItemCloseDb.Caption = "Close Database\r\n";
            this.barButtonItemCloseDb.Id = 4;
            this.barButtonItemCloseDb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCloseDb.ImageOptions.LargeImage")));
            this.barButtonItemCloseDb.Name = "barButtonItemCloseDb";
            this.barButtonItemCloseDb.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemCloseDb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCloseDb_ItemClick);
            // 
            // barButtonItemExit: Nút lệnh để thoát ứng dụng.
            // 
            this.barButtonItemExit.Caption = "Exit";
            this.barButtonItemExit.Id = 5;
            this.barButtonItemExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemExit.ImageOptions.LargeImage")));
            this.barButtonItemExit.Name = "barButtonItemExit";
            this.barButtonItemExit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExit_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItemNewScheme: Thêm mới lược đồ
            // 
            this.barButtonItemNewScheme.Caption = "New Schema";
            this.barButtonItemNewScheme.Id = 7;
            this.barButtonItemNewScheme.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewScheme.ImageOptions.LargeImage")));
            this.barButtonItemNewScheme.Name = "barButtonItemNewScheme";
            this.barButtonItemNewScheme.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemNewScheme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewScheme_ItemClick);
            // 
            // barButtonItemEditScheme: Chỉnh sửa lược đồ
            // 
            this.barButtonItemEditScheme.Caption = "Edit Schema";
            this.barButtonItemEditScheme.Id = 8;
            this.barButtonItemEditScheme.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditScheme.ImageOptions.LargeImage")));
            this.barButtonItemEditScheme.Name = "barButtonItemEditScheme";
            this.barButtonItemEditScheme.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemEditScheme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSaveScheme_ItemClick);
            // 
            // barButtonItemOpenScheme: Mở 1 lược đồ
            // 
            this.barButtonItemOpenScheme.Caption = "Open Schema";
            this.barButtonItemOpenScheme.Id = 9;
            this.barButtonItemOpenScheme.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenScheme.ImageOptions.LargeImage")));
            this.barButtonItemOpenScheme.Name = "barButtonItemOpenScheme";
            this.barButtonItemOpenScheme.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemOpenScheme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenScheme_ItemClick);
            // 
            // barButtonItemDeleteScheme: Xóa 1 lược đồ
            // 
            this.barButtonItemDeleteScheme.Caption = "Delete Schema\r\n";
            this.barButtonItemDeleteScheme.Id = 10;
            this.barButtonItemDeleteScheme.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteScheme.ImageOptions.LargeImage")));
            this.barButtonItemDeleteScheme.Name = "barButtonItemDeleteScheme";
            this.barButtonItemDeleteScheme.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemDeleteScheme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteScheme_ItemClick);
            // 
            // barButtonItemCloseCurrentScheme: Đóng lược đồ
            // 
            this.barButtonItemCloseCurrentScheme.Caption = "Close Current Schema";
            this.barButtonItemCloseCurrentScheme.Id = 11;
            this.barButtonItemCloseCurrentScheme.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCloseCurrentScheme.ImageOptions.LargeImage")));
            this.barButtonItemCloseCurrentScheme.Name = "barButtonItemCloseCurrentScheme";
            this.barButtonItemCloseCurrentScheme.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemCloseCurrentScheme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCloseCurrentScheme_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItemNewRelation: Thêm mới quan hệ
            // 
            this.barButtonItemNewRelation.Caption = "New Relation";
            this.barButtonItemNewRelation.Id = 13;
            this.barButtonItemNewRelation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemNewRelation.ImageOptions.Image")));
            this.barButtonItemNewRelation.Name = "barButtonItemNewRelation";
            this.barButtonItemNewRelation.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemNewRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewRelation_ItemClick);
            // 
            // barButtonItemEditRelation: Chỉnh sửa quan hệ
            // 
            this.barButtonItemEditRelation.Caption = "Edit Relation";
            this.barButtonItemEditRelation.Id = 14;
            this.barButtonItemEditRelation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemEditRelation.ImageOptions.Image")));
            this.barButtonItemEditRelation.Name = "barButtonItemEditRelation";
            this.barButtonItemEditRelation.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemEditRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditRelation_ItemClick);
            // 
            // barButtonItemOpenRelation: Mở 1 quan hệ
            // 
            this.barButtonItemOpenRelation.Caption = "Open Relation";
            this.barButtonItemOpenRelation.Id = 15;
            this.barButtonItemOpenRelation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenRelation.ImageOptions.Image")));
            this.barButtonItemOpenRelation.Name = "barButtonItemOpenRelation";
            this.barButtonItemOpenRelation.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemOpenRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenRelation_ItemClick);
            // 
            // barButtonItemDeleteRelation: Xóa quan hệ
            // 
            this.barButtonItemDeleteRelation.Caption = "Delete Relation\r\n";
            this.barButtonItemDeleteRelation.Id = 16;
            this.barButtonItemDeleteRelation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteRelation.ImageOptions.Image")));
            this.barButtonItemDeleteRelation.Name = "barButtonItemDeleteRelation";
            this.barButtonItemDeleteRelation.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemDeleteRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteRelation_ItemClick);
            // 
            // barButtonItemCloseCurrentRelation: Đóng 1 quan hệ
            // 
            this.barButtonItemCloseCurrentRelation.Caption = "Close Current Relation";
            this.barButtonItemCloseCurrentRelation.Id = 17;
            this.barButtonItemCloseCurrentRelation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCloseCurrentRelation.ImageOptions.Image")));
            this.barButtonItemCloseCurrentRelation.Name = "barButtonItemCloseCurrentRelation";
            this.barButtonItemCloseCurrentRelation.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemCloseCurrentRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCloseCurrentRelation_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 18;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItemNewQuery: Tạo mới truy vấn
            // 
            this.barButtonItemNewQuery.Caption = "New Query";
            this.barButtonItemNewQuery.Id = 19;
            this.barButtonItemNewQuery.ImageOptions.LargeImage = global::PRDB_Sqlite.Properties.Resources.query_add1;
            this.barButtonItemNewQuery.Name = "barButtonItemNewQuery";
            this.barButtonItemNewQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemNewQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewQuery_ItemClick);
            // 
            // barButtonItemSaveQuery: Lưu truy vấn
            // 
            this.barButtonItemSaveQuery.Caption = "Save Query";
            this.barButtonItemSaveQuery.Enabled = false;
            this.barButtonItemSaveQuery.Id = 20;
            this.barButtonItemSaveQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaveQuery.ImageOptions.Image")));
            this.barButtonItemSaveQuery.Name = "barButtonItemSaveQuery";
            this.barButtonItemSaveQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemSaveQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSaveQuery_ItemClick);
            // 
            // barButtonItemOpenQuery: Mở truy vấn
            // 
            this.barButtonItemOpenQuery.Caption = "Open Query";
            this.barButtonItemOpenQuery.Id = 21;
            this.barButtonItemOpenQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenQuery.ImageOptions.Image")));
            this.barButtonItemOpenQuery.Name = "barButtonItemOpenQuery";
            this.barButtonItemOpenQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemOpenQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenQuery_ItemClick);
            // 
            // barButtonItemDeleteQuery: Xóa truy vấn
            // 
            this.barButtonItemDeleteQuery.Caption = "Delete Query\r\n";
            this.barButtonItemDeleteQuery.Id = 22;
            this.barButtonItemDeleteQuery.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteQuery.ImageOptions.LargeImage")));
            this.barButtonItemDeleteQuery.Name = "barButtonItemDeleteQuery";
            this.barButtonItemDeleteQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemDeleteQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteQuery_ItemClick);
            // 
            // barButtonItemExcuteQuery: Thực thi truy vấn
            // 
            this.barButtonItemExcuteQuery.Caption = "Excute Query";
            this.barButtonItemExcuteQuery.Enabled = false;
            this.barButtonItemExcuteQuery.Id = 23;
            this.barButtonItemExcuteQuery.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemExcuteQuery.ImageOptions.LargeImage")));
            this.barButtonItemExcuteQuery.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barButtonItemExcuteQuery.Name = "barButtonItemExcuteQuery";
            this.barButtonItemExcuteQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemExcuteQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExcuteQuery_ItemClick);
            // 
            // barButtonItemCloseCurrentQuery: Đóng truy vấn
            // 
            this.barButtonItemCloseCurrentQuery.Caption = "Close Current Query";
            this.barButtonItemCloseCurrentQuery.Enabled = false;
            this.barButtonItemCloseCurrentQuery.Id = 24;
            this.barButtonItemCloseCurrentQuery.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCloseCurrentQuery.ImageOptions.LargeImage")));
            this.barButtonItemCloseCurrentQuery.Name = "barButtonItemCloseCurrentQuery";
            this.barButtonItemCloseCurrentQuery.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemCloseCurrentQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCloseCurrentQuery_ItemClick);
            // 
            // barButtonGroup1
            // 
            //Nhóm và nút điều khiển liên quan đến "⊕_ig" (ignorance)
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 25;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem_Hoi_Ignor
            // 
            //Nút này có nhãn "⊕_ig (ignorance)" và font chữ đặc biệt. Khi người dùng bấm vào, sự kiện barButtonItem_Hoi_Ignor_ItemClick sẽ được xử lý. Nút này có định dạng kiểu chữ lớn và đậm khi ở trạng thái bình thường
            this.barButtonItem_Hoi_Ignor.Caption = "⊕_ig (ignorance)";
            this.barButtonItem_Hoi_Ignor.Id = 26;
            this.barButtonItem_Hoi_Ignor.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Hoi_Ignor.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem_Hoi_Ignor.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Hoi_Ignor.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem_Hoi_Ignor.Name = "barButtonItem_Hoi_Ignor";
            this.barButtonItem_Hoi_Ignor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Hoi_Ignor_ItemClick);
            // 
            // barButtonItem_Hoi_independence
            // 
            this.barButtonItem_Hoi_independence.Caption = "⊗_in (independence)";
            this.barButtonItem_Hoi_independence.Id = 27;
            this.barButtonItem_Hoi_independence.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Hoi_independence.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem_Hoi_independence.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.5F, System.Drawing.FontStyle.Bold);
            this.barButtonItem_Hoi_independence.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem_Hoi_independence.Name = "barButtonItem_Hoi_independence";
            this.barButtonItem_Hoi_independence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Hoi_independence_ItemClick);
            // 
            // barButtonItem_Hoi_mutualexclusion
            // 
            this.barButtonItem_Hoi_mutualexclusion.Caption = "⊗_me (mutual exclusion)";
            this.barButtonItem_Hoi_mutualexclusion.Id = 28;
            this.barButtonItem_Hoi_mutualexclusion.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Hoi_mutualexclusion.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem_Hoi_mutualexclusion.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Hoi_mutualexclusion.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem_Hoi_mutualexclusion.Name = "barButtonItem_Hoi_mutualexclusion";
            this.barButtonItem_Hoi_mutualexclusion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Hoi_mutualexclusion_ItemClick);
            // 
            // barButtonItem_Tuyen_ignorance
            // 
            //barButtonItem_Tuyen_ignorance, barButtonItem_Tuyen_mutualexclusion, barButtonItem_Tuyen_independence: Các nút này có chức năng tương tự như nhóm "⊕" và "⊗" nhưng dành cho các phép toán khác nhau. Mỗi nút có nhãn riêng và khi bấm vào sẽ kích hoạt sự kiện cụ thể.
            this.barButtonItem_Tuyen_ignorance.Caption = "⊕_ig (ignorance)";
            this.barButtonItem_Tuyen_ignorance.Id = 29;
            this.barButtonItem_Tuyen_ignorance.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Tuyen_ignorance.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem_Tuyen_ignorance.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Tuyen_ignorance.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem_Tuyen_ignorance.Name = "barButtonItem_Tuyen_ignorance";
            this.barButtonItem_Tuyen_ignorance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Tuyen_ignorance_ItemClick);
            // 
            // barButtonItem_Tuyen_mutualexclusion
            // 
            this.barButtonItem_Tuyen_mutualexclusion.Caption = "⊕_me (mutual exclusion)";
            this.barButtonItem_Tuyen_mutualexclusion.Id = 31;
            this.barButtonItem_Tuyen_mutualexclusion.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Tuyen_mutualexclusion.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem_Tuyen_mutualexclusion.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Tuyen_mutualexclusion.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem_Tuyen_mutualexclusion.Name = "barButtonItem_Tuyen_mutualexclusion";
            this.barButtonItem_Tuyen_mutualexclusion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Tuyen_mutualexclusion_ItemClick);
            // 
            // barButtonItem_Tru_ignorance
            // 
            this.barButtonItem_Tru_ignorance.Id = 39;
            this.barButtonItem_Tru_ignorance.Name = "barButtonItem_Tru_ignorance";
            // 
            // barButtonItem_Tru_independence
            // 
            this.barButtonItem_Tru_independence.Id = 40;
            this.barButtonItem_Tru_independence.Name = "barButtonItem_Tru_independence";
            // 
            // barButtonItem_Tru_mutualexclusion
            // 
            this.barButtonItem_Tru_mutualexclusion.Id = 41;
            this.barButtonItem_Tru_mutualexclusion.Name = "barButtonItem_Tru_mutualexclusion";
            // 
            // barButtonItem_Bang_ignorance
            // 
            this.barButtonItem_Bang_ignorance.Id = 42;
            this.barButtonItem_Bang_ignorance.Name = "barButtonItem_Bang_ignorance";
            // 
            // barButtonItem_Bang_independence
            // 
            this.barButtonItem_Bang_independence.Id = 43;
            this.barButtonItem_Bang_independence.Name = "barButtonItem_Bang_independence";
            // 
            // barButtonItem_Bang_mutualexclusion
            // 
            this.barButtonItem_Bang_mutualexclusion.Id = 44;
            this.barButtonItem_Bang_mutualexclusion.Name = "barButtonItem_Bang_mutualexclusion";
            // 
            // barButtonItem_Tuyen_independence
            // 
            this.barButtonItem_Tuyen_independence.Caption = "⊕_in (independence)";
            this.barButtonItem_Tuyen_independence.Id = 30;
            this.barButtonItem_Tuyen_independence.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Tuyen_independence.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem_Tuyen_independence.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem_Tuyen_independence.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem_Tuyen_independence.Name = "barButtonItem_Tuyen_independence";
            this.barButtonItem_Tuyen_independence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Tuyen_independence_ItemClick);
            // 
            // ribbonPageDB
            // 
            //ribbonPageDB: Một trang trong ribbon menu có tên là "Database". Trang này chứa các nhóm nút điều khiển
            this.ribbonPageDB.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,//  Chứa nút barButtonItemNewDB (tạo cơ sở dữ liệu mới
            this.ribbonPageGroup2, //Chứa nút barButtonItemOpenDB (mở cơ sở dữ liệu).
            this.ribbonPageGroup3, // Chứa nút barButtonItemSaveDB (lưu cơ sở dữ liệu).
            this.ribbonPageGroup4, // Chứa nút barButtonItemCloseDb (đóng cơ sở dữ liệu).
            this.ribbonPageGroup5}); //Chứa nút barButtonItemExit (thoát ứng dụng).
            this.ribbonPageDB.Name = "ribbonPageDB";
            this.ribbonPageDB.Text = "Database";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemNewDB);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemOpenDB);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemSaveDB);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemCloseDb);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemExit);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "                            ";
            // 
            // ribbonPageScheme
            // 
            //ribbonPageScheme: Một trang trong ribbon menu có tên "Schema".
            //Trang này chứa các nhóm nút điều khiển liên quan đến việc quản lý lược đồ:
            this.ribbonPageScheme.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7, //Chứa nút barButtonItemNewScheme (tạo lược đồ mới).
            this.ribbonPageGroup8, //Chứa nút barButtonItemEditScheme (chỉnh sửa lược đồ).
            this.ribbonPageGroup9, //Chứa nút barButtonItemOpenScheme (mở lược đồ).
            this.ribbonPageGroup10, //Chứa nút barButtonItemDeleteScheme (xóa lược đồ).
            this.ribbonPageGroup11}); //Chứa nút barButtonItemCloseCurrentScheme (đóng lược đồ hiện tại).
            this.ribbonPageScheme.Name = "ribbonPageScheme";
            this.ribbonPageScheme.Text = "Schema";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItemNewScheme);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItemEditScheme);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItemOpenScheme);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItemDeleteScheme);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.barButtonItemCloseCurrentScheme);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPageRelation
            // 
            //một trang trong ribbon, chứa các nhóm lệnh để quản lý quan hệ (Relation)
            this.ribbonPageRelation.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNewRelation,
            this.ribbonPageGroupSaveRelation,
            this.ribbonPageGroupOpenRelation,
            this.ribbonPageGroupDeleteRelation,
            this.ribbonPageGroupCloseCurrentRelation});
            this.ribbonPageRelation.Name = "ribbonPageRelation";
            this.ribbonPageRelation.Text = "Relation";
            // 
            // ribbonPageGroupNewRelation
            // 
            this.ribbonPageGroupNewRelation.ItemLinks.Add(this.barButtonItemNewRelation);
            this.ribbonPageGroupNewRelation.Name = "ribbonPageGroupNewRelation";
            // 
            // ribbonPageGroupSaveRelation
            // 
            this.ribbonPageGroupSaveRelation.ItemLinks.Add(this.barButtonItemEditRelation);
            this.ribbonPageGroupSaveRelation.Name = "ribbonPageGroupSaveRelation";
            this.ribbonPageGroupSaveRelation.Visible = false;
            // 
            // ribbonPageGroupOpenRelation
            // 
            this.ribbonPageGroupOpenRelation.ItemLinks.Add(this.barButtonItemOpenRelation);
            this.ribbonPageGroupOpenRelation.Name = "ribbonPageGroupOpenRelation";
            // 
            // ribbonPageGroupDeleteRelation
            // 
            this.ribbonPageGroupDeleteRelation.ItemLinks.Add(this.barButtonItemDeleteRelation);
            this.ribbonPageGroupDeleteRelation.Name = "ribbonPageGroupDeleteRelation";
            // 
            // ribbonPageGroupCloseCurrentRelation
            // 
            this.ribbonPageGroupCloseCurrentRelation.ItemLinks.Add(this.barButtonItemCloseCurrentRelation);
            this.ribbonPageGroupCloseCurrentRelation.Name = "ribbonPageGroupCloseCurrentRelation";
            // 
            // ribbonPageQuery
            // 
            // chứa các nhóm lệnh liên quan đến truy vấn (Query).
            this.ribbonPageQuery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup20,
            this.ribbonPageGroup21,
            this.ribbonPageGroup22,
            this.ribbonPageGroup23,
            this.ribbonPageGroupConjuntion,
            this.ribbonPageGroupDisjunction,
            this.ribbonPageGroup24,
            this.ribbonPageGroup25});
            this.ribbonPageQuery.Name = "ribbonPageQuery";
            this.ribbonPageQuery.Text = "Query";
            // 
            // ribbonPageGroup20
            // 
            this.ribbonPageGroup20.ItemLinks.Add(this.barButtonItemNewQuery);
            this.ribbonPageGroup20.Name = "ribbonPageGroup20";
            // 
            // ribbonPageGroup21
            // 
            this.ribbonPageGroup21.ItemLinks.Add(this.barButtonItemSaveQuery);
            this.ribbonPageGroup21.Name = "ribbonPageGroup21";
            // 
            // ribbonPageGroup22
            // 
            this.ribbonPageGroup22.ItemLinks.Add(this.barButtonItemOpenQuery);
            this.ribbonPageGroup22.Name = "ribbonPageGroup22";
            // 
            // ribbonPageGroup23
            // 
            this.ribbonPageGroup23.ItemLinks.Add(this.barButtonItemDeleteQuery);
            this.ribbonPageGroup23.Name = "ribbonPageGroup23";
            // 
            // ribbonPageGroupConjuntion
            // 
            //Đây là các nhóm chứa các lệnh để xử lý các phép toán hội và tuyển cho các điều kiện truy vấn.
            //Tuy nhiên, cả hai nhóm này đều đang bị ẩn (Visible = false).
            this.ribbonPageGroupConjuntion.ItemLinks.Add(this.barButtonItem_Hoi_Ignor);
            this.ribbonPageGroupConjuntion.ItemLinks.Add(this.barButtonItem_Hoi_independence);
            this.ribbonPageGroupConjuntion.ItemLinks.Add(this.barButtonItem_Hoi_mutualexclusion);
            this.ribbonPageGroupConjuntion.Name = "ribbonPageGroupConjuntion";
            this.ribbonPageGroupConjuntion.ShowCaptionButton = false;
            this.ribbonPageGroupConjuntion.Text = "  Conjunction";
            this.ribbonPageGroupConjuntion.Visible = false;
            // 
            // ribbonPageGroupDisjunction
            // 
            this.ribbonPageGroupDisjunction.ItemLinks.Add(this.barButtonItem_Tuyen_ignorance);
            this.ribbonPageGroupDisjunction.ItemLinks.Add(this.barButtonItem_Tuyen_independence);
            this.ribbonPageGroupDisjunction.ItemLinks.Add(this.barButtonItem_Tuyen_mutualexclusion);
            this.ribbonPageGroupDisjunction.Name = "ribbonPageGroupDisjunction";
            this.ribbonPageGroupDisjunction.Text = "Disjunction";
            this.ribbonPageGroupDisjunction.Visible = false;
            // 
            // ribbonPageGroup24
            // 
            this.ribbonPageGroup24.ItemLinks.Add(this.barButtonItemExcuteQuery);
            this.ribbonPageGroup24.Name = "ribbonPageGroup24";
            // 
            // ribbonPageGroup25
            // 
            this.ribbonPageGroup25.ItemLinks.Add(this.barButtonItemCloseCurrentQuery);
            this.ribbonPageGroup25.Name = "ribbonPageGroup25";
            // 
            // splitContainerControl1
            // 
            //Đây là một thành phần giao diện chia cửa sổ làm hai phần (Panel1 và Panel2).
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 142);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.TreeView);
            this.splitContainerControl1.Panel1.Controls.Add(this.ToolStripTitleOV);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabDatabase);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1155, 420);
            this.splitContainerControl1.SplitterPosition = 248;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // TreeView
            // 
            //Panel1 chứa TreeView để hiển thị cấu trúc đối tượng (Object Explorer) và thanh công cụ tiêu đề ToolStripTitleOV.
            //TreeView có thể hiển thị các mục như bảng, quan hệ, và lược đồ trong cơ sở dữ liệu.
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TreeView.ForeColor = System.Drawing.Color.Blue;
            this.TreeView.Location = new System.Drawing.Point(0, 25);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(248, 395);
            this.TreeView.TabIndex = 1;
            // 
            // ToolStripTitleOV
            // 
            this.ToolStripTitleOV.BackColor = System.Drawing.Color.Red;
            this.ToolStripTitleOV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripTitleOV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.ToolStripTitleOV.Location = new System.Drawing.Point(0, 0);
            this.ToolStripTitleOV.Name = "ToolStripTitleOV";
            this.ToolStripTitleOV.Size = new System.Drawing.Size(248, 25);
            this.ToolStripTitleOV.TabIndex = 0;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(30, 0, 80, 0);
            this.toolStripLabel3.Size = new System.Drawing.Size(207, 22);
            this.toolStripLabel3.Text = "Object  Explorer";
            // 
            // xtraTabDatabase
            // 
            //Panel2 chứa xtraTabDatabase là một tab chứa các trang khác nhau cho lược đồ (Scheme), quan hệ (Relation), và truy vấn (Query).
            this.xtraTabDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabDatabase.Location = new System.Drawing.Point(0, 0);
            this.xtraTabDatabase.Name = "xtraTabDatabase";
            this.xtraTabDatabase.SelectedTabPage = this.xtraTabPageScheme;
            this.xtraTabDatabase.Size = new System.Drawing.Size(903, 420);
            this.xtraTabDatabase.TabIndex = 0;
            this.xtraTabDatabase.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageScheme,
            this.xtraTabPageRelation,
            this.xtraTabPageQuery});
            // 
            // xtraTabPageScheme
            // 
            //xtraTabPageScheme: Hiển thị dữ liệu lược đồ thông qua gridControlScheme, một lưới dữ liệu cho phép xem các thuộc tính của lược đồ như khóa chính, kiểu dữ liệu, miền giá trị, và mô tả.
            this.xtraTabPageScheme.Controls.Add(this.gridControlScheme);
            this.xtraTabPageScheme.Name = "xtraTabPageScheme";
            this.xtraTabPageScheme.Size = new System.Drawing.Size(898, 395);
            this.xtraTabPageScheme.Text = "Scheme";
            // 
            // gridControlScheme
            // 
            //xtraTabPageRelation: Trang này có một trình điều khiển chia nhỏ khác (splitContainerControl2), trong đó phần trên có thể là các điều khiển nhập liệu và phần dưới có thể hiển thị dữ liệu trong GridViewValue hoặc nhập liệu trực tiếp qua txtValue.
            this.gridControlScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlScheme.Location = new System.Drawing.Point(0, 0);
            this.gridControlScheme.MainView = this.gridView;
            this.gridControlScheme.MenuManager = this.ribbonControl_Tuyen_Independence;
            this.gridControlScheme.Name = "gridControlScheme";
            this.gridControlScheme.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlScheme.Size = new System.Drawing.Size(898, 395);
            this.gridControlScheme.TabIndex = 1;
            this.gridControlScheme.UseEmbeddedNavigator = true;
            this.gridControlScheme.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            //Các cột: Bảng này chứa 5 cột (Primary Key, Attribute Name, Data Type, Domain, Description).
            //Mỗi cột được xác định qua GridColumn và có thuộc tính như Visible và VisibleIndex để kiểm soát việc hiển thị.
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPrimary,
            this.gridColumnAttribute,
            this.gridColumnDataType,
            this.gridColumnDomain,
            this.gridColumnDescription});
            this.gridView.GridControl = this.gridControlScheme;
            this.gridView.Name = "gridView";
            //AllowAddRows, AllowDeleteRows: Không cho phép thêm hoặc xóa dòng.
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            //Editable: Không cho phép chỉnh sửa trực tiếp dữ liệu.
            this.gridView.OptionsBehavior.Editable = false;
            //ReadOnly: Chế độ chỉ đọc.
            this.gridView.OptionsBehavior.ReadOnly = true;
            //AutoFocusNewRow: Tự động chuyển tiêu điểm sang dòng mới khi người dùng nhập dữ liệu
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            //EnterMoveNextColumn: Di chuyển tới cột tiếp theo khi nhấn Enter.
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            //ShowAutoFilterRow: Hiển thị hàng lọc tự động trên mỗi cột.
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            //ShowGroupPanel: Ẩn nhóm điều khiển (panel group).
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnPrimary
            // 
            //Cột này hiển thị trạng thái khóa chính (Primary Key) với kiểu dữ liệu checkbox (repositoryItemCheckEdit1).
            //Kiểu NullStyle của checkbox là Unchecked, tức là trạng thái null sẽ hiển thị như chưa được chọn.
            this.gridColumnPrimary.Caption = "Primary key";
            this.gridColumnPrimary.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumnPrimary.Name = "gridColumnPrimary";
            this.gridColumnPrimary.Visible = true;
            this.gridColumnPrimary.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridColumnAttribute
            // 
            //Các cột khác (gridColumnAttribute, gridColumnDataType, gridColumnDomain, gridColumnDescription):
            //Mỗi cột này hiển thị một thuộc tính tương ứng của dữ liệu: tên thuộc tính, kiểu dữ liệu, miền (domain), và mô tả.
            this.gridColumnAttribute.Caption = "Attribute name";
            this.gridColumnAttribute.Name = "gridColumnAttribute";
            this.gridColumnAttribute.Visible = true;
            this.gridColumnAttribute.VisibleIndex = 1;
            // 
            // gridColumnDataType
            // 
            this.gridColumnDataType.Caption = "Data Type";
            this.gridColumnDataType.Name = "gridColumnDataType";
            this.gridColumnDataType.Visible = true;
            this.gridColumnDataType.VisibleIndex = 2;
            // 
            // gridColumnDomain
            // 
            this.gridColumnDomain.Caption = "Domain";
            this.gridColumnDomain.Name = "gridColumnDomain";
            this.gridColumnDomain.Visible = true;
            this.gridColumnDomain.VisibleIndex = 3;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Description";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 4;
            // 
            // xtraTabPageRelation
            // 
            //Một tab trong giao diện chứa splitContainerControl2 và splitterControl1 để quản lý việc chia bố cục thành nhiều phần.
            this.xtraTabPageRelation.Controls.Add(this.splitContainerControl2);
            this.xtraTabPageRelation.Controls.Add(this.splitterControl1);
            this.xtraTabPageRelation.Name = "xtraTabPageRelation";
            this.xtraTabPageRelation.Size = new System.Drawing.Size(898, 395);
            this.xtraTabPageRelation.Text = "Relation";
            // 
            // splitContainerControl2
            // 
            //Bố cục này chia thành hai phần (Panel1 và Panel2). Panel1 chứa panelControl1 để hiển thị dữ liệu, trong khi Panel2 chứa các thành phần như GridViewValue và txtValue.
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(4, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.GridViewValue);
            this.splitContainerControl2.Panel2.Controls.Add(this.txtValue);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(894, 395);
            this.splitContainerControl2.SplitterPosition = 234;
            this.splitContainerControl2.TabIndex = 1;
            // 
            // panelControl1
            // 
            //Chứa BindingNavigatorData và GridViewData, nơi người dùng có thể điều hướng và thao tác với dữ liệu.
            this.panelControl1.Controls.Add(this.BindingNavigatorData);
            this.panelControl1.Controls.Add(this.GridViewData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(894, 234);
            this.panelControl1.TabIndex = 6;
            // 
            // BindingNavigatorData
            // 
            //Đây là thanh điều hướng cho dữ liệu, cho phép người dùng di chuyển giữa các hàng trong lưới (Grid).
            this.BindingNavigatorData.BackColor = System.Drawing.Color.Gainsboro;
            this.BindingNavigatorData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigatorData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                //Các nút như btn_Data_Home, btn_Data_Pre, btn_Data_Next, và btn_Data_End cho phép người dùng di chuyển về đầu, lùi, tiến, hoặc tới cuối danh sách hàng.
            this.btn_Data_Home,
            this.btn_Data_Pre,
            this.toolStripSeparator9,
            this.lblDataRowNumberIndicator,
            this.toolStripSeparator10,
            this.btn_Data_Next,
            this.btn_Data_End,
            this.toolStripSeparator11,
            this.Btn_Data_DeleteRow,
            this.Btn_Data_ClearData,
            this.Btn_Data_UpdateData});
            this.BindingNavigatorData.Location = new System.Drawing.Point(2, 206);
            this.BindingNavigatorData.Name = "BindingNavigatorData";
            this.BindingNavigatorData.Size = new System.Drawing.Size(890, 26);
            this.BindingNavigatorData.TabIndex = 5;
            this.BindingNavigatorData.Visible = false;
            // 
            // btn_Data_Home
            // 
            //Các chức năng sự kiện (Event) như btn_Data_Home_Click, btn_Data_Pre_Click, btn_Data_Next_Click, và btn_Data_End_Click sẽ được gọi khi người dùng nhấn vào các nút tương ứng để di chuyển qua các hàng dữ liệu.
            this.btn_Data_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Data_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Data_Home.Image")));
            this.btn_Data_Home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Data_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Data_Home.Name = "btn_Data_Home";
            this.btn_Data_Home.Size = new System.Drawing.Size(23, 23);
            this.btn_Data_Home.Text = "toolStripButton1";
            this.btn_Data_Home.ToolTipText = "Get Home";
            this.btn_Data_Home.Click += new System.EventHandler(this.btn_Data_Home_Click);
            // 
            // btn_Data_Pre
            // 
            this.btn_Data_Pre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Data_Pre.Image = ((System.Drawing.Image)(resources.GetObject("btn_Data_Pre.Image")));
            this.btn_Data_Pre.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Data_Pre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Data_Pre.Name = "btn_Data_Pre";
            this.btn_Data_Pre.Size = new System.Drawing.Size(23, 23);
            this.btn_Data_Pre.Text = "toolStripButton2";
            this.btn_Data_Pre.ToolTipText = "Previous Row";
            this.btn_Data_Pre.Click += new System.EventHandler(this.btn_Data_Pre_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 26);
            // 
            // lblDataRowNumberIndicator
            // 
            //lblDataRowNumberIndicator hiển thị số lượng hàng hiện tại dưới dạng "0/0", giúp người dùng biết vị trí hiện tại của họ trong danh sách.
            this.lblDataRowNumberIndicator.Name = "lblDataRowNumberIndicator";
            this.lblDataRowNumberIndicator.Size = new System.Drawing.Size(30, 23);
            this.lblDataRowNumberIndicator.Text = "0 / 0";
            this.lblDataRowNumberIndicator.ToolTipText = "Row Number";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 26);
            // 
            // btn_Data_Next
            // 
            this.btn_Data_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Data_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Data_Next.Image")));
            this.btn_Data_Next.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Data_Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Data_Next.Name = "btn_Data_Next";
            this.btn_Data_Next.Size = new System.Drawing.Size(23, 23);
            this.btn_Data_Next.Text = "toolStripButton3";
            this.btn_Data_Next.ToolTipText = "Next Row";
            this.btn_Data_Next.Click += new System.EventHandler(this.btn_Data_Next_Click);
            // 
            // btn_Data_End
            // 
            this.btn_Data_End.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Data_End.Image = ((System.Drawing.Image)(resources.GetObject("btn_Data_End.Image")));
            this.btn_Data_End.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Data_End.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Data_End.Name = "btn_Data_End";
            this.btn_Data_End.Size = new System.Drawing.Size(23, 23);
            this.btn_Data_End.Text = "toolStripButton4";
            this.btn_Data_End.ToolTipText = "Reach End";
            this.btn_Data_End.Click += new System.EventHandler(this.btn_Data_End_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 26);
            // 
            // Btn_Data_DeleteRow
            // 
            this.Btn_Data_DeleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Data_DeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Data_DeleteRow.Image")));
            this.Btn_Data_DeleteRow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Data_DeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Data_DeleteRow.Name = "Btn_Data_DeleteRow";
            this.Btn_Data_DeleteRow.Size = new System.Drawing.Size(23, 23);
            this.Btn_Data_DeleteRow.Text = "Delete this row";
            this.Btn_Data_DeleteRow.ToolTipText = "Delete this row";
            this.Btn_Data_DeleteRow.Click += new System.EventHandler(this.Btn_Data_DeleteRow_Click);
            // 
            // Btn_Data_ClearData
            // 
            this.Btn_Data_ClearData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Data_ClearData.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Data_ClearData.Image")));
            this.Btn_Data_ClearData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Data_ClearData.Name = "Btn_Data_ClearData";
            this.Btn_Data_ClearData.Size = new System.Drawing.Size(23, 23);
            this.Btn_Data_ClearData.Text = "Clear Grid View";
            this.Btn_Data_ClearData.Click += new System.EventHandler(this.Btn_Data_ClearData_Click);
            // 
            // Btn_Data_UpdateData
            // 
            this.Btn_Data_UpdateData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Data_UpdateData.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Data_UpdateData.Image")));
            this.Btn_Data_UpdateData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Data_UpdateData.Name = "Btn_Data_UpdateData";
            this.Btn_Data_UpdateData.Size = new System.Drawing.Size(23, 23);
            this.Btn_Data_UpdateData.Text = "Save Relation";
            this.Btn_Data_UpdateData.ToolTipText = "Update Relation";
            this.Btn_Data_UpdateData.Click += new System.EventHandler(this.Btn_Data_UpdateData_Click);
            // 
            // GridViewData
            // 
            this.GridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewData.Location = new System.Drawing.Point(2, 2);
            this.GridViewData.Name = "GridViewData";
            this.GridViewData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewData.Size = new System.Drawing.Size(887, 201);
            this.GridViewData.TabIndex = 4;
            this.GridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewData_CellClick);
            this.GridViewData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewData_CellEndEdit);
            this.GridViewData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridViewData_CellPainting);
            this.GridViewData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridViewData_RowsAdded);
            this.GridViewData.SelectionChanged += new System.EventHandler(this.GridViewData_SelectionChanged);
            this.GridViewData.Click += new System.EventHandler(this.GridViewData_Click);
            // 
            // GridViewValue
            // 
            this.GridViewValue.AllowUserToAddRows = false;
            this.GridViewValue.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewValue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewValue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnValue,
            this.ColumnMinProb,
            this.ColumnMaxProb});
            this.GridViewValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewValue.Location = new System.Drawing.Point(0, 0);
            this.GridViewValue.Name = "GridViewValue";
            this.GridViewValue.Size = new System.Drawing.Size(894, 157);
            this.GridViewValue.TabIndex = 16;
            this.GridViewValue.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewValue_CellEndEdit);
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnValue.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.Name = "ColumnValue";
            // 
            // ColumnMinProb
            // 
            this.ColumnMinProb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnMinProb.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnMinProb.HeaderText = "MinProb";
            this.ColumnMinProb.Name = "ColumnMinProb";
            // 
            // ColumnMaxProb
            // 
            this.ColumnMaxProb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnMaxProb.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnMaxProb.HeaderText = "MaxProb";
            this.ColumnMaxProb.Name = "ColumnMaxProb";
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(0, 0);
            this.txtValue.MenuManager = this.ribbonControl_Tuyen_Independence;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(894, 157);
            this.txtValue.TabIndex = 10;
            this.txtValue.Visible = false;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(4, 395);
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.TabStop = false;
            // 
            // xtraTabPageQuery
            // 
            this.xtraTabPageQuery.Controls.Add(this.splitContainerControl3);
            this.xtraTabPageQuery.Name = "xtraTabPageQuery";
            this.xtraTabPageQuery.Size = new System.Drawing.Size(898, 395);
            this.xtraTabPageQuery.Text = "Query";
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.txtQuery);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.xtraTabControlQueryResult);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(898, 395);
            this.splitContainerControl3.SplitterPosition = 211;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.ForeColor = System.Drawing.Color.Black;
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(898, 211);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.Text = "";
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged_1);
            // 
            // xtraTabControlQueryResult
            // 
            this.xtraTabControlQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlQueryResult.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlQueryResult.Name = "xtraTabControlQueryResult";
            this.xtraTabControlQueryResult.SelectedTabPage = this.xtraTabPageQueryResult;
            this.xtraTabControlQueryResult.Size = new System.Drawing.Size(898, 180);
            this.xtraTabControlQueryResult.TabIndex = 0;
            this.xtraTabControlQueryResult.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageQueryResult,
            this.MessageQuery});
            // 
            // xtraTabPageQueryResult
            // 
            this.xtraTabPageQueryResult.Controls.Add(this.GridViewResult);
            this.xtraTabPageQueryResult.Name = "xtraTabPageQueryResult";
            this.xtraTabPageQueryResult.Size = new System.Drawing.Size(893, 155);
            this.xtraTabPageQueryResult.Text = "Query Result";
            // 
            // GridViewResult
            // 
            this.GridViewResult.AllowUserToAddRows = false;
            this.GridViewResult.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewResult.Location = new System.Drawing.Point(0, 0);
            this.GridViewResult.Name = "GridViewResult";
            this.GridViewResult.ReadOnly = true;
            this.GridViewResult.Size = new System.Drawing.Size(893, 155);
            this.GridViewResult.TabIndex = 2;
            // 
            // MessageQuery
            // 
            this.MessageQuery.Controls.Add(this.txtMessage);
            this.MessageQuery.Name = "MessageQuery";
            this.MessageQuery.Size = new System.Drawing.Size(893, 155);
            this.MessageQuery.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.Red;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(893, 155);
            this.txtMessage.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false; //ngăn nhãn tự động thay đổi kích thước.
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel1.Text = "Object Explorer";
            // 
            // ContextMenu_Database
            // 
            //menu ngữ cảnh được hiển thị khi người dùng tương tác với cơ sở dữ liệu.
            this.ContextMenu_Database.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuDB_Rename, //đổi tên cơ sở dữ liệu
            this.CTMenuDB_CloseDB}); //đóng cơ sở dữ liệu.
            this.ContextMenu_Database.Name = "contextMenuStrip";
            this.ContextMenu_Database.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ContextMenu_Database.Size = new System.Drawing.Size(169, 48);
            this.ContextMenu_Database.Text = "Database Properties";
            // 
            // CTMenuDB_Rename
            // 
            // Khi người dùng chọn CTMenuDB_Rename, phương thức CTMenuDB_Rename_Click sẽ được gọi
            this.CTMenuDB_Rename.Name = "CTMenuDB_Rename";
            this.CTMenuDB_Rename.Size = new System.Drawing.Size(168, 22);
            this.CTMenuDB_Rename.Text = "Re&name Database";
            this.CTMenuDB_Rename.Click += new System.EventHandler(this.CTMenuDB_Rename_Click);
            // 
            // CTMenuDB_CloseDB
            // 
            this.CTMenuDB_CloseDB.Name = "CTMenuDB_CloseDB";
            this.CTMenuDB_CloseDB.Size = new System.Drawing.Size(168, 22);
            this.CTMenuDB_CloseDB.Text = "&Close Database";
            this.CTMenuDB_CloseDB.Click += new System.EventHandler(this.CTMenuDB_CloseDB_Click);
            // 
            // ContextMenu_Schema
            // 
            //Menu ngữ cảnh dành cho lược đồ (schema).
            this.ContextMenu_Schema.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_Schema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuSchema_NewSchema, //tạo lược đồ mới.
            this.CTMenuSchema_DelSchemas, //chỉnh sửa lược đồ.
            this.openSchemeToolStripMenuItem, //mở lược đồ.
            this.deleteSchemeToolStripMenuItem, //xóa lược đồ.
            this.closeCurrentSchemeToolStripMenuItem}); //đóng lược đồ hiện tại.
            this.ContextMenu_Schema.Name = "ContextMenu_Schema";
            this.ContextMenu_Schema.Size = new System.Drawing.Size(215, 114);
            // 
            // CTMenuSchema_NewSchema
            // 
            this.CTMenuSchema_NewSchema.Name = "CTMenuSchema_NewSchema";
            this.CTMenuSchema_NewSchema.Size = new System.Drawing.Size(214, 22);
            this.CTMenuSchema_NewSchema.Text = "&New Scheme";
            this.CTMenuSchema_NewSchema.Click += new System.EventHandler(this.CTMenuSchema_NewSchema_Click);
            // 
            // CTMenuSchema_DelSchemas
            // 
            this.CTMenuSchema_DelSchemas.Name = "CTMenuSchema_DelSchemas";
            this.CTMenuSchema_DelSchemas.Size = new System.Drawing.Size(214, 22);
            this.CTMenuSchema_DelSchemas.Text = "&Edit Scheme";
            this.CTMenuSchema_DelSchemas.Click += new System.EventHandler(this.CTMenuSchema_DelSchemas_Click);
            // 
            // openSchemeToolStripMenuItem
            // 
            this.openSchemeToolStripMenuItem.Name = "openSchemeToolStripMenuItem";
            this.openSchemeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openSchemeToolStripMenuItem.Text = "&Open Scheme";
            this.openSchemeToolStripMenuItem.Click += new System.EventHandler(this.openSchemeToolStripMenuItem_Click);
            // 
            // deleteSchemeToolStripMenuItem
            // 
            this.deleteSchemeToolStripMenuItem.Name = "deleteSchemeToolStripMenuItem";
            this.deleteSchemeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteSchemeToolStripMenuItem.Text = "&Delete Scheme";
            this.deleteSchemeToolStripMenuItem.Click += new System.EventHandler(this.deleteSchemeToolStripMenuItem_Click);
            // 
            // closeCurrentSchemeToolStripMenuItem
            // 
            this.closeCurrentSchemeToolStripMenuItem.Name = "closeCurrentSchemeToolStripMenuItem";
            this.closeCurrentSchemeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.closeCurrentSchemeToolStripMenuItem.Text = "&Close Current Scheme";
            this.closeCurrentSchemeToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentSchemeToolStripMenuItem_Click);
            // 
            // ContextMenu_SchemaNode
            // 
            //menu ngữ cảnh cho các node lược đồ, chứa các tùy chọn 
            this.ContextMenu_SchemaNode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_SchemaNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuSchNode_EditSchema, //chỉnh sửa lược đồ.
            this.CTMenuSchNode_OpenSchema, //mở lược đồ.
            this.CTMenuSchNode_DeleteSchema}); //xóa lược đồ
            this.ContextMenu_SchemaNode.Name = "ContextMenu_Table";
            this.ContextMenu_SchemaNode.Size = new System.Drawing.Size(169, 70);
            // 
            // CTMenuSchNode_EditSchema
            // 
            this.CTMenuSchNode_EditSchema.Name = "CTMenuSchNode_EditSchema";
            this.CTMenuSchNode_EditSchema.Size = new System.Drawing.Size(168, 22);
            this.CTMenuSchNode_EditSchema.Text = "&Edit Scheme";
            this.CTMenuSchNode_EditSchema.Click += new System.EventHandler(this.CTMenuSchNode_EditSchema_Click);
            // 
            // CTMenuSchNode_OpenSchema
            // 
            this.CTMenuSchNode_OpenSchema.Name = "CTMenuSchNode_OpenSchema";
            this.CTMenuSchNode_OpenSchema.Size = new System.Drawing.Size(168, 22);
            this.CTMenuSchNode_OpenSchema.Text = "&Open Scheme";
            this.CTMenuSchNode_OpenSchema.ToolTipText = "Tạo quan hệ mới";
            this.CTMenuSchNode_OpenSchema.Click += new System.EventHandler(this.CTMenuSchNode_OpenSchema_Click);
            // 
            // CTMenuSchNode_DeleteSchema
            // 
            this.CTMenuSchNode_DeleteSchema.Name = "CTMenuSchNode_DeleteSchema";
            this.CTMenuSchNode_DeleteSchema.Size = new System.Drawing.Size(168, 22);
            this.CTMenuSchNode_DeleteSchema.Text = "&Delete Scheme";
            this.CTMenuSchNode_DeleteSchema.Click += new System.EventHandler(this.CTMenuSchNode_DeleteSchema_Click);
            // 
            // ContextMenu_Relation
            // 
            // Menu ngữ cảnh cho quan hệ (relation)
            this.ContextMenu_Relation.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_Relation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuRelation_NewRelation, //tạo quan hệ mới.
            this.CTMenuRelation_DeleteRelations}); //xóa tất cả các quan hệ.
            this.ContextMenu_Relation.Name = "ContextMenu_Table";
            this.ContextMenu_Relation.Size = new System.Drawing.Size(200, 48);
            // 
            // CTMenuRelation_NewRelation
            // 
            this.CTMenuRelation_NewRelation.Name = "CTMenuRelation_NewRelation";
            this.CTMenuRelation_NewRelation.Size = new System.Drawing.Size(199, 22);
            this.CTMenuRelation_NewRelation.Text = "&New Relation";
            this.CTMenuRelation_NewRelation.ToolTipText = "Tạo quan hệ mới";
            this.CTMenuRelation_NewRelation.Click += new System.EventHandler(this.CTMenuRelation_NewRelation_Click);
            // 
            // CTMenuRelation_DeleteRelations
            // 
            this.CTMenuRelation_DeleteRelations.Name = "CTMenuRelation_DeleteRelations";
            this.CTMenuRelation_DeleteRelations.Size = new System.Drawing.Size(199, 22);
            this.CTMenuRelation_DeleteRelations.Text = "&Delete All Relations";
            this.CTMenuRelation_DeleteRelations.ToolTipText = "Xóa toàn bộ các quan hệ";
            this.CTMenuRelation_DeleteRelations.Click += new System.EventHandler(this.CTMenuRelation_DeleteRelations_Click);
            // 
            // ContextMenu_RelationNode
            // 
            // Menu ngữ cảnh dành cho node quan hệ
            this.ContextMenu_RelationNode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_RelationNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuRelNode_OpenRelation, //mở quan hệ.
            this.CTMenuRelNode_DeleteRelation, // xóa quan hệ.
            this.CTMenuRelNode_RenameRelation}); //đổi tên quan hệ.
            this.ContextMenu_RelationNode.Name = "ContextMenu_Table";
            this.ContextMenu_RelationNode.Size = new System.Drawing.Size(181, 70);
            // 
            // CTMenuRelNode_OpenRelation
            // 
            this.CTMenuRelNode_OpenRelation.Name = "CTMenuRelNode_OpenRelation";
            this.CTMenuRelNode_OpenRelation.Size = new System.Drawing.Size(180, 22);
            this.CTMenuRelNode_OpenRelation.Text = "&Open Relation";
            this.CTMenuRelNode_OpenRelation.ToolTipText = "Tạo quan hệ mới";
            this.CTMenuRelNode_OpenRelation.Click += new System.EventHandler(this.CTMenuRelNode_OpenRelation_Click);
            // 
            // CTMenuRelNode_DeleteRelation
            // 
            this.CTMenuRelNode_DeleteRelation.Name = "CTMenuRelNode_DeleteRelation";
            this.CTMenuRelNode_DeleteRelation.Size = new System.Drawing.Size(180, 22);
            this.CTMenuRelNode_DeleteRelation.Text = "&Delete Relation";
            this.CTMenuRelNode_DeleteRelation.Click += new System.EventHandler(this.CTMenuRelNode_DeleteRelation_Click);
            // 
            // CTMenuRelNode_RenameRelation
            // 
            this.CTMenuRelNode_RenameRelation.Name = "CTMenuRelNode_RenameRelation";
            this.CTMenuRelNode_RenameRelation.Size = new System.Drawing.Size(180, 22);
            this.CTMenuRelNode_RenameRelation.Text = "&Rename Relation";
            this.CTMenuRelNode_RenameRelation.Click += new System.EventHandler(this.CTMenuRelNode_RenameRelation_Click);
            // 
            // ContextMenu_Query
            // 
            // Menu ngữ cảnh dành cho truy vấn (query)
            this.ContextMenu_Query.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_Query.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuQuery_NewQuery, //tạo truy vấn mới.
            this.CTMenuQuery_DeleteQueries}); //xóa tất cả các truy vấn.
            this.ContextMenu_Query.Name = "ContextMenu_Query";
            this.ContextMenu_Query.Size = new System.Drawing.Size(190, 48);
            // 
            // CTMenuQuery_NewQuery
            // 
            this.CTMenuQuery_NewQuery.Name = "CTMenuQuery_NewQuery";
            this.CTMenuQuery_NewQuery.Size = new System.Drawing.Size(189, 22);
            this.CTMenuQuery_NewQuery.Text = "&New Query";
            this.CTMenuQuery_NewQuery.Click += new System.EventHandler(this.CTMenuQuery_NewQuery_Click);
            // 
            // CTMenuQuery_DeleteQueries
            // 
            this.CTMenuQuery_DeleteQueries.Name = "CTMenuQuery_DeleteQueries";
            this.CTMenuQuery_DeleteQueries.Size = new System.Drawing.Size(189, 22);
            this.CTMenuQuery_DeleteQueries.Text = "&Delete All Queries";
            this.CTMenuQuery_DeleteQueries.Click += new System.EventHandler(this.CTMenuQuery_DeleteQueries_Click);
            // 
            // contextMenu_QueryNode
            // 
            //Menu ngữ cảnh cho node truy vấn
            this.contextMenu_QueryNode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu_QueryNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuQueryNode_OpenQuery, //mở truy vấn.
            this.CTMenuQuery_DeleteQuery, //xóa truy vấn.
            this.CTMenuQuery_RenameQuery}); //đổi tên truy vấn.
            this.contextMenu_QueryNode.Name = "ContextMenu_Query";
            this.contextMenu_QueryNode.Size = new System.Drawing.Size(167, 70);
            // 
            // CTMenuQueryNode_OpenQuery
            // 
            this.CTMenuQueryNode_OpenQuery.Name = "CTMenuQueryNode_OpenQuery";
            this.CTMenuQueryNode_OpenQuery.Size = new System.Drawing.Size(166, 22);
            this.CTMenuQueryNode_OpenQuery.Text = "&Open Query";
            this.CTMenuQueryNode_OpenQuery.Click += new System.EventHandler(this.CTMenuQueryNode_OpenQuery_Click);
            // 
            // CTMenuQuery_DeleteQuery
            // 
            this.CTMenuQuery_DeleteQuery.Name = "CTMenuQuery_DeleteQuery";
            this.CTMenuQuery_DeleteQuery.Size = new System.Drawing.Size(166, 22);
            this.CTMenuQuery_DeleteQuery.Text = "&Delete Query";
            this.CTMenuQuery_DeleteQuery.Click += new System.EventHandler(this.CTMenuQuery_DeleteQuery_Click);
            // 
            // CTMenuQuery_RenameQuery
            // 
            this.CTMenuQuery_RenameQuery.Name = "CTMenuQuery_RenameQuery";
            this.CTMenuQuery_RenameQuery.Size = new System.Drawing.Size(166, 22);
            this.CTMenuQuery_RenameQuery.Text = "&Rename Query";
            this.CTMenuQuery_RenameQuery.Click += new System.EventHandler(this.CTMenuQuery_RenameQuery_Click);
            // 
            // ImageList_TreeView
            // 
            // quản lý danh sách hình ảnh sẽ được sử dụng trong TreeView
            // ImageStream được dùng để lấy các hình ảnh
            this.ImageList_TreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_TreeView.ImageStream")));
            this.ImageList_TreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_TreeView.Images.SetKeyName(0, "DB.png");
            this.ImageList_TreeView.Images.SetKeyName(1, "Folder.png");
            this.ImageList_TreeView.Images.SetKeyName(2, "OpenFolder.png");
            this.ImageList_TreeView.Images.SetKeyName(3, "Relation.png");
            this.ImageList_TreeView.Images.SetKeyName(4, "QueryIcon.png");
            this.ImageList_TreeView.Images.SetKeyName(5, "key.png");
            this.ImageList_TreeView.Images.SetKeyName(6, "attribute.png");
            // 
            // errorProvider
            // hiển thị các lỗi dưới dạng trực quan,
            // thường là biểu tượng dấu chấm than màu đỏ bên cạnh các điều khiển trên form
            this.errorProvider.ContainerControl = this;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "⊕_in (independence)";
            this.barButtonItem1.Id = 30;
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "⊕_in (independence)";
            this.barButtonItem2.Id = 30;
            this.barButtonItem2.ItemAppearance.Disabled.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPageGroup12
            // Nhóm lệnh này trong ribbon xử lý các phép toán rời rạc (phép OR logic),
            // nhưng hiện tại nó đang bị ẩn (Visible = false).
            this.ribbonPageGroup12.ItemLinks.Add(this.barButtonItem_Tuyen_ignorance);
            this.ribbonPageGroup12.ItemLinks.Add(this.barButtonItem_Tuyen_mutualexclusion);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "Disjunction";
            this.ribbonPageGroup12.Visible = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 562);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl_Tuyen_Independence);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRDB Visual Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl_Tuyen_Independence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ToolStripTitleOV.ResumeLayout(false);
            this.ToolStripTitleOV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabDatabase)).EndInit();
            this.xtraTabDatabase.ResumeLayout(false);
            this.xtraTabPageScheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xtraTabPageRelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.BindingNavigatorData.ResumeLayout(false);
            this.BindingNavigatorData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            this.xtraTabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlQueryResult)).EndInit();
            this.xtraTabControlQueryResult.ResumeLayout(false);
            this.xtraTabPageQueryResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResult)).EndInit();
            this.MessageQuery.ResumeLayout(false);
            this.MessageQuery.PerformLayout();
            this.ContextMenu_Database.ResumeLayout(false);
            this.ContextMenu_Schema.ResumeLayout(false);
            this.ContextMenu_SchemaNode.ResumeLayout(false);
            this.ContextMenu_Relation.ResumeLayout(false);
            this.ContextMenu_RelationNode.ResumeLayout(false);
            this.ContextMenu_Query.ResumeLayout(false);
            this.contextMenu_QueryNode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl_Tuyen_Independence;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageScheme;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuery;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup20;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup21;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup22;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup23;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup24;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup25;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewDB;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenDB;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaveDB;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloseDb;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewScheme;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditScheme;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenScheme;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteScheme;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloseCurrentScheme;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewRelation;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditRelation;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenRelation;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteRelation;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloseCurrentRelation;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewQuery;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaveQuery;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenQuery;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteQuery;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExcuteQuery;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloseCurrentQuery;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupConjuntion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDisjunction;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Hoi_Ignor;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Hoi_independence;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Hoi_mutualexclusion;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Tuyen_ignorance;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Tuyen_mutualexclusion;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Tru_ignorance;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Tru_independence;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Tru_mutualexclusion;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Bang_ignorance;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Bang_independence;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Bang_mutualexclusion;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ToolStrip ToolStripTitleOV;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TreeView TreeView;
        private DevExpress.XtraTab.XtraTabControl xtraTabDatabase;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageScheme;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageRelation;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageQuery;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.DataGridView GridViewData;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlQueryResult;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageQueryResult;
        private System.Windows.Forms.DataGridView GridViewResult;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Database;
        private System.Windows.Forms.ToolStripMenuItem CTMenuDB_Rename;
        private System.Windows.Forms.ToolStripMenuItem CTMenuDB_CloseDB;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Schema;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchema_NewSchema;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchema_DelSchemas;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_SchemaNode;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchNode_OpenSchema;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchNode_DeleteSchema;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Relation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelation_NewRelation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelation_DeleteRelations;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_RelationNode;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelNode_OpenRelation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelNode_DeleteRelation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelNode_RenameRelation;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Query;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_NewQuery;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_DeleteQueries;
        private System.Windows.Forms.ContextMenuStrip contextMenu_QueryNode;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQueryNode_OpenQuery;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_DeleteQuery;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_RenameQuery;
        private System.Windows.Forms.ImageList ImageList_TreeView;
        private System.Windows.Forms.ToolStrip BindingNavigatorData;
        private System.Windows.Forms.ToolStripButton btn_Data_Home;
        private System.Windows.Forms.ToolStripButton btn_Data_Pre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel lblDataRowNumberIndicator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btn_Data_Next;
        private System.Windows.Forms.ToolStripButton btn_Data_End;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton Btn_Data_DeleteRow;
        private System.Windows.Forms.ToolStripButton Btn_Data_ClearData;
        private System.Windows.Forms.ToolStripButton Btn_Data_UpdateData;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageRelation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNewRelation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSaveRelation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupOpenRelation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDeleteRelation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCloseCurrentRelation;
        private System.Windows.Forms.ToolStripMenuItem openSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchNode_EditSchema;
        private DevExpress.XtraGrid.GridControl gridControlScheme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrimary;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAttribute;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDomain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView GridViewValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMinProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxProb;
        private DevExpress.XtraEditors.MemoEdit txtValue;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RichTextBox txtQuery;
        private DevExpress.XtraTab.XtraTabPage MessageQuery;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Tuyen_independence;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
    }
}