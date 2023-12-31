﻿namespace BasicFacebookFeatures
{
    partial class AlbumsForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumsForm));
            this.buttonDownloadAlbum = new System.Windows.Forms.Button();
            this.buttonNextPhoto = new System.Windows.Forms.Button();
            this.buttonPreviousPhoto = new System.Windows.Forms.Button();
            this.SortByAlbumsLabel = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxPhotos = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxAlbumsSortOption = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.albumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.albumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingNavigator)).BeginInit();
            this.albumBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(22, 19);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(92, 16);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(22, 46);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.BackColor = System.Drawing.Color.Azure;
            this.buttonDownloadAlbum.Enabled = false;
            this.buttonDownloadAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(23, 166);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(150, 48);
            this.buttonDownloadAlbum.TabIndex = 84;
            this.buttonDownloadAlbum.Text = "Download Album";
            this.buttonDownloadAlbum.UseVisualStyleBackColor = false;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // buttonNextPhoto
            // 
            this.buttonNextPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextPhoto.BackColor = System.Drawing.Color.Azure;
            this.buttonNextPhoto.Enabled = false;
            this.buttonNextPhoto.Location = new System.Drawing.Point(868, 421);
            this.buttonNextPhoto.Name = "buttonNextPhoto";
            this.buttonNextPhoto.Size = new System.Drawing.Size(80, 71);
            this.buttonNextPhoto.TabIndex = 83;
            this.buttonNextPhoto.Text = "→";
            this.buttonNextPhoto.UseVisualStyleBackColor = false;
            this.buttonNextPhoto.Click += new System.EventHandler(this.buttonNextPhoto_Click);
            // 
            // buttonPreviousPhoto
            // 
            this.buttonPreviousPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPreviousPhoto.BackColor = System.Drawing.Color.Azure;
            this.buttonPreviousPhoto.Enabled = false;
            this.buttonPreviousPhoto.Location = new System.Drawing.Point(131, 421);
            this.buttonPreviousPhoto.Name = "buttonPreviousPhoto";
            this.buttonPreviousPhoto.Size = new System.Drawing.Size(80, 71);
            this.buttonPreviousPhoto.TabIndex = 82;
            this.buttonPreviousPhoto.Text = "←";
            this.buttonPreviousPhoto.UseVisualStyleBackColor = false;
            this.buttonPreviousPhoto.Click += new System.EventHandler(this.buttonPreviousPhoto_Click);
            // 
            // SortByAlbumsLabel
            // 
            this.SortByAlbumsLabel.AutoSize = true;
            this.SortByAlbumsLabel.Location = new System.Drawing.Point(19, 92);
            this.SortByAlbumsLabel.Name = "SortByAlbumsLabel";
            this.SortByAlbumsLabel.Size = new System.Drawing.Size(53, 16);
            this.SortByAlbumsLabel.TabIndex = 80;
            this.SortByAlbumsLabel.Text = "Sort By:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAlbums.BackColor = System.Drawing.Color.Azure;
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(430, 27);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(325, 132);
            this.listBoxAlbums.TabIndex = 77;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // linkAlbums
            // 
            this.linkAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAlbums.AutoSize = true;
            this.linkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkAlbums.Location = new System.Drawing.Point(22, 27);
            this.linkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(214, 35);
            this.linkAlbums.TabIndex = 78;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "Fetch Albums\r\n(Click an album to view its pictures)";
            this.linkAlbums.UseCompatibleTextRendering = true;
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage3.Controls.Add(this.pictureBoxPhotos);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.buttonDownloadAlbum);
            this.tabPage3.Controls.Add(this.buttonNextPhoto);
            this.tabPage3.Controls.Add(this.buttonPreviousPhoto);
            this.tabPage3.Controls.Add(this.SortByAlbumsLabel);
            this.tabPage3.Controls.Add(this.comboBoxAlbumsSortOption);
            this.tabPage3.Controls.Add(this.listBoxAlbums);
            this.tabPage3.Controls.Add(this.linkAlbums);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1174, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Albums";
            // 
            // pictureBoxPhotos
            // 
            this.pictureBoxPhotos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPhotos.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxPhotos.Location = new System.Drawing.Point(245, 181);
            this.pictureBoxPhotos.Name = "pictureBoxPhotos";
            this.pictureBoxPhotos.Size = new System.Drawing.Size(589, 311);
            this.pictureBoxPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhotos.TabIndex = 86;
            this.pictureBoxPhotos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Location = new System.Drawing.Point(774, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 148);
            this.panel1.TabIndex = 85;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "[No Description]"));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(177, 15);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.Azure;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "[No Description]"));
            this.descriptionTextBox.Location = new System.Drawing.Point(177, 46);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // comboBoxAlbumsSortOption
            // 
            this.comboBoxAlbumsSortOption.BackColor = System.Drawing.Color.Azure;
            this.comboBoxAlbumsSortOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbumsSortOption.Enabled = false;
            this.comboBoxAlbumsSortOption.FormattingEnabled = true;
            this.comboBoxAlbumsSortOption.Location = new System.Drawing.Point(23, 122);
            this.comboBoxAlbumsSortOption.Name = "comboBoxAlbumsSortOption";
            this.comboBoxAlbumsSortOption.Size = new System.Drawing.Size(273, 24);
            this.comboBoxAlbumsSortOption.TabIndex = 79;
            this.comboBoxAlbumsSortOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbumsSortOption_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 553);
            this.tabControl1.TabIndex = 55;
            // 
            // albumBindingNavigator
            // 
            this.albumBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.albumBindingNavigator.BindingSource = this.albumBindingSource;
            this.albumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.albumBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.albumBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.albumBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.albumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.albumBindingNavigatorSaveItem});
            this.albumBindingNavigator.Location = new System.Drawing.Point(0, 522);
            this.albumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.albumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.albumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.albumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.albumBindingNavigator.Name = "albumBindingNavigator";
            this.albumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.albumBindingNavigator.Size = new System.Drawing.Size(1182, 31);
            this.albumBindingNavigator.TabIndex = 56;
            this.albumBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // albumBindingNavigatorSaveItem
            // 
            this.albumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.albumBindingNavigatorSaveItem.Enabled = false;
            this.albumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("albumBindingNavigatorSaveItem.Image")));
            this.albumBindingNavigatorSaveItem.Name = "albumBindingNavigatorSaveItem";
            this.albumBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.albumBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.albumBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingNavigator)).EndInit();
            this.albumBindingNavigator.ResumeLayout(false);
            this.albumBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownloadAlbum;
        private System.Windows.Forms.Button buttonNextPhoto;
        private System.Windows.Forms.Button buttonPreviousPhoto;
        private System.Windows.Forms.Label SortByAlbumsLabel;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxAlbumsSortOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingNavigator albumBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton albumBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox pictureBoxPhotos;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        public System.Windows.Forms.TabControl tabControl1;
    }
}