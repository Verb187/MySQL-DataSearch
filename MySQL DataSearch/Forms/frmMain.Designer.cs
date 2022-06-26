
namespace MySQL_DataSearch.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnActive = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOnLeave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.init = new System.Windows.Forms.Timer(this.components);
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblFiltred = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.Transparent;
            this.pnlHeader.GradientBottomLeft = System.Drawing.Color.Teal;
            this.pnlHeader.GradientBottomRight = System.Drawing.Color.Teal;
            this.pnlHeader.GradientTopLeft = System.Drawing.Color.Teal;
            this.pnlHeader.GradientTopRight = System.Drawing.Color.Teal;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Quality = 10;
            this.pnlHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlHeader.Size = new System.Drawing.Size(1067, 48);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(1031, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(55, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestionnaire d\'immobilier";
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.Teal;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.Teal;
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderRadius = 35;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(29, 88);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.Teal;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Teal;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            stateProperties4.ForeColor = System.Drawing.Color.Silver;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.txtSearch.PlaceholderText = "Rechercher";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(260, 37);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Rechercher";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowMouseEffects = true;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.AutoRoundBorders = false;
            this.btnSearch.AutoSizeLeftIcon = true;
            this.btnSearch.AutoSizeRightIcon = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.Teal;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.ButtonText = "";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges1;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSearch.IconSize = 25;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnSearch.IdleBorderRadius = 40;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.Teal;
            this.btnSearch.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.IdleIconLeftImage")));
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(295, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.OnDisabledState.BorderRadius = 40;
            this.btnSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnDisabledState.BorderThickness = 1;
            this.btnSearch.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.OnDisabledState.IconLeftImage = null;
            this.btnSearch.OnDisabledState.IconRightImage = null;
            this.btnSearch.onHoverState.BorderColor = System.Drawing.Color.Teal;
            this.btnSearch.onHoverState.BorderRadius = 40;
            this.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.onHoverState.BorderThickness = 1;
            this.btnSearch.onHoverState.FillColor = System.Drawing.Color.Teal;
            this.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.onHoverState.IconLeftImage = null;
            this.btnSearch.onHoverState.IconRightImage = null;
            this.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnSearch.OnIdleState.BorderRadius = 40;
            this.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnIdleState.BorderThickness = 1;
            this.btnSearch.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.OnIdleState.IconLeftImage")));
            this.btnSearch.OnIdleState.IconRightImage = null;
            this.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.OnPressedState.BorderRadius = 40;
            this.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnPressedState.BorderThickness = 1;
            this.btnSearch.OnPressedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnPressedState.IconLeftImage = null;
            this.btnSearch.OnPressedState.IconRightImage = null;
            this.btnSearch.Size = new System.Drawing.Size(40, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAll
            // 
            this.btnAll.AllowAnimations = true;
            this.btnAll.AllowMouseEffects = true;
            this.btnAll.AllowToggling = true;
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.AnimationSpeed = 200;
            this.btnAll.AutoGenerateColors = false;
            this.btnAll.AutoRoundBorders = false;
            this.btnAll.AutoSizeLeftIcon = true;
            this.btnAll.AutoSizeRightIcon = true;
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAll.BackgroundImage")));
            this.btnAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAll.ButtonText = "Tout";
            this.btnAll.ButtonTextMarginLeft = 0;
            this.btnAll.ColorContrastOnClick = 45;
            this.btnAll.ColorContrastOnHover = 45;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.btnAll.CustomizableEdges = borderEdges2;
            this.btnAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAll.IconMarginLeft = 11;
            this.btnAll.IconPadding = 10;
            this.btnAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAll.IconSize = 25;
            this.btnAll.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnAll.IdleBorderRadius = 33;
            this.btnAll.IdleBorderThickness = 2;
            this.btnAll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnAll.IdleIconLeftImage = null;
            this.btnAll.IdleIconRightImage = null;
            this.btnAll.IndicateFocus = true;
            this.btnAll.Location = new System.Drawing.Point(42, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAll.OnDisabledState.BorderRadius = 33;
            this.btnAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAll.OnDisabledState.BorderThickness = 2;
            this.btnAll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAll.OnDisabledState.IconLeftImage = null;
            this.btnAll.OnDisabledState.IconRightImage = null;
            this.btnAll.onHoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAll.onHoverState.BorderRadius = 33;
            this.btnAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAll.onHoverState.BorderThickness = 2;
            this.btnAll.onHoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAll.onHoverState.IconLeftImage = null;
            this.btnAll.onHoverState.IconRightImage = null;
            this.btnAll.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnAll.OnIdleState.BorderRadius = 33;
            this.btnAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAll.OnIdleState.BorderThickness = 2;
            this.btnAll.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnAll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAll.OnIdleState.IconLeftImage = null;
            this.btnAll.OnIdleState.IconRightImage = null;
            this.btnAll.OnPressedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAll.OnPressedState.BorderRadius = 33;
            this.btnAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAll.OnPressedState.BorderThickness = 2;
            this.btnAll.OnPressedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAll.OnPressedState.IconLeftImage = null;
            this.btnAll.OnPressedState.IconRightImage = null;
            this.btnAll.Size = new System.Drawing.Size(55, 39);
            this.btnAll.TabIndex = 3;
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAll.TextMarginLeft = 0;
            this.btnAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAll.UseDefaultRadiusAndThickness = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnActive
            // 
            this.btnActive.AllowAnimations = true;
            this.btnActive.AllowMouseEffects = true;
            this.btnActive.AllowToggling = true;
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActive.AnimationSpeed = 200;
            this.btnActive.AutoGenerateColors = false;
            this.btnActive.AutoRoundBorders = false;
            this.btnActive.AutoSizeLeftIcon = true;
            this.btnActive.AutoSizeRightIcon = true;
            this.btnActive.BackColor = System.Drawing.Color.Transparent;
            this.btnActive.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActive.BackgroundImage")));
            this.btnActive.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActive.ButtonText = "Recent";
            this.btnActive.ButtonTextMarginLeft = 0;
            this.btnActive.ColorContrastOnClick = 45;
            this.btnActive.ColorContrastOnHover = 45;
            this.btnActive.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = false;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = false;
            borderEdges3.TopRight = false;
            this.btnActive.CustomizableEdges = borderEdges3;
            this.btnActive.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActive.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActive.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActive.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActive.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnActive.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnActive.IconMarginLeft = 11;
            this.btnActive.IconPadding = 10;
            this.btnActive.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActive.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnActive.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnActive.IconSize = 25;
            this.btnActive.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnActive.IdleBorderRadius = 33;
            this.btnActive.IdleBorderThickness = 2;
            this.btnActive.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnActive.IdleIconLeftImage = null;
            this.btnActive.IdleIconRightImage = null;
            this.btnActive.IndicateFocus = true;
            this.btnActive.Location = new System.Drawing.Point(93, 3);
            this.btnActive.Name = "btnActive";
            this.btnActive.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActive.OnDisabledState.BorderRadius = 33;
            this.btnActive.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActive.OnDisabledState.BorderThickness = 2;
            this.btnActive.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActive.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActive.OnDisabledState.IconLeftImage = null;
            this.btnActive.OnDisabledState.IconRightImage = null;
            this.btnActive.onHoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnActive.onHoverState.BorderRadius = 33;
            this.btnActive.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActive.onHoverState.BorderThickness = 2;
            this.btnActive.onHoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnActive.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnActive.onHoverState.IconLeftImage = null;
            this.btnActive.onHoverState.IconRightImage = null;
            this.btnActive.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnActive.OnIdleState.BorderRadius = 33;
            this.btnActive.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActive.OnIdleState.BorderThickness = 2;
            this.btnActive.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnActive.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnActive.OnIdleState.IconLeftImage = null;
            this.btnActive.OnIdleState.IconRightImage = null;
            this.btnActive.OnPressedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnActive.OnPressedState.BorderRadius = 33;
            this.btnActive.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActive.OnPressedState.BorderThickness = 2;
            this.btnActive.OnPressedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnActive.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnActive.OnPressedState.IconLeftImage = null;
            this.btnActive.OnPressedState.IconRightImage = null;
            this.btnActive.Size = new System.Drawing.Size(80, 39);
            this.btnActive.TabIndex = 4;
            this.btnActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActive.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActive.TextMarginLeft = 0;
            this.btnActive.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnActive.UseDefaultRadiusAndThickness = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnOnLeave
            // 
            this.btnOnLeave.AllowAnimations = true;
            this.btnOnLeave.AllowMouseEffects = true;
            this.btnOnLeave.AllowToggling = true;
            this.btnOnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnLeave.AnimationSpeed = 200;
            this.btnOnLeave.AutoGenerateColors = false;
            this.btnOnLeave.AutoRoundBorders = false;
            this.btnOnLeave.AutoSizeLeftIcon = true;
            this.btnOnLeave.AutoSizeRightIcon = true;
            this.btnOnLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnOnLeave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnOnLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnLeave.BackgroundImage")));
            this.btnOnLeave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOnLeave.ButtonText = "Vieux";
            this.btnOnLeave.ButtonTextMarginLeft = 0;
            this.btnOnLeave.ColorContrastOnClick = 45;
            this.btnOnLeave.ColorContrastOnHover = 45;
            this.btnOnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = false;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = false;
            borderEdges4.TopRight = true;
            this.btnOnLeave.CustomizableEdges = borderEdges4;
            this.btnOnLeave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOnLeave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOnLeave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOnLeave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOnLeave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOnLeave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOnLeave.ForeColor = System.Drawing.Color.White;
            this.btnOnLeave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnLeave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOnLeave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOnLeave.IconMarginLeft = 11;
            this.btnOnLeave.IconPadding = 10;
            this.btnOnLeave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnLeave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOnLeave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOnLeave.IconSize = 25;
            this.btnOnLeave.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnOnLeave.IdleBorderRadius = 33;
            this.btnOnLeave.IdleBorderThickness = 2;
            this.btnOnLeave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnOnLeave.IdleIconLeftImage = null;
            this.btnOnLeave.IdleIconRightImage = null;
            this.btnOnLeave.IndicateFocus = true;
            this.btnOnLeave.Location = new System.Drawing.Point(169, 3);
            this.btnOnLeave.Name = "btnOnLeave";
            this.btnOnLeave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOnLeave.OnDisabledState.BorderRadius = 33;
            this.btnOnLeave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOnLeave.OnDisabledState.BorderThickness = 2;
            this.btnOnLeave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOnLeave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOnLeave.OnDisabledState.IconLeftImage = null;
            this.btnOnLeave.OnDisabledState.IconRightImage = null;
            this.btnOnLeave.onHoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnOnLeave.onHoverState.BorderRadius = 33;
            this.btnOnLeave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOnLeave.onHoverState.BorderThickness = 2;
            this.btnOnLeave.onHoverState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnOnLeave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOnLeave.onHoverState.IconLeftImage = null;
            this.btnOnLeave.onHoverState.IconRightImage = null;
            this.btnOnLeave.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnOnLeave.OnIdleState.BorderRadius = 33;
            this.btnOnLeave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOnLeave.OnIdleState.BorderThickness = 2;
            this.btnOnLeave.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnOnLeave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOnLeave.OnIdleState.IconLeftImage = null;
            this.btnOnLeave.OnIdleState.IconRightImage = null;
            this.btnOnLeave.OnPressedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnOnLeave.OnPressedState.BorderRadius = 33;
            this.btnOnLeave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOnLeave.OnPressedState.BorderThickness = 2;
            this.btnOnLeave.OnPressedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnOnLeave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOnLeave.OnPressedState.IconLeftImage = null;
            this.btnOnLeave.OnPressedState.IconRightImage = null;
            this.btnOnLeave.Size = new System.Drawing.Size(87, 39);
            this.btnOnLeave.TabIndex = 5;
            this.btnOnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOnLeave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOnLeave.TextMarginLeft = 0;
            this.btnOnLeave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOnLeave.UseDefaultRadiusAndThickness = true;
            this.btnOnLeave.Click += new System.EventHandler(this.btnOnLeave_Click);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = false;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 30;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(29, 158);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 50;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(988, 466);
            this.grid.TabIndex = 6;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            this.grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grid_RowsAdded);
            this.grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grid_RowsRemoved);
            // 
            // Column8
            // 
            this.Column8.FillWeight = 25.40425F;
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.FillWeight = 125F;
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Message";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.FillWeight = 150F;
            this.Column7.HeaderText = "Signalement";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 130F;
            this.Column9.HeaderText = "Fichier";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = null;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1032, 189);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(17, 450);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 7;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 44;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            this.bunifuVScrollBar1.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.bunifuVScrollBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.btnOnLeave);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Location = new System.Drawing.Point(763, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 44);
            this.panel1.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search_ss48px.png");
            this.imageList1.Images.SetKeyName(1, "ok_96px.png");
            this.imageList1.Images.SetKeyName(2, "cancel_96px.png");
            // 
            // init
            // 
            this.init.Enabled = true;
            this.init.Interval = 300;
            this.init.Tick += new System.EventHandler(this.init_Tick);
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.lblSummary.Location = new System.Drawing.Point(26, 634);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(69, 17);
            this.lblSummary.TabIndex = 9;
            this.lblSummary.Text = "Trouvés: 0";
            // 
            // lblFiltred
            // 
            this.lblFiltred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltred.AutoSize = true;
            this.lblFiltred.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.lblFiltred.Location = new System.Drawing.Point(219, 634);
            this.lblFiltred.Name = "lblFiltred";
            this.lblFiltred.Size = new System.Drawing.Size(58, 17);
            this.lblFiltred.TabIndex = 10;
            this.lblFiltred.Text = "Filtrés: 0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1067, 661);
            this.Controls.Add(this.lblFiltred);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel pnlHeader;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActive;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOnLeave;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.DataGridView grid;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer init;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblFiltred;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}