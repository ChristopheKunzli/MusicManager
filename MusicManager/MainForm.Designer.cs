namespace MusicManager
{
    partial class MainForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.albumPicture = new System.Windows.Forms.PictureBox();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.webVideo = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(349, 12);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.Size = new System.Drawing.Size(549, 200);
            this.dgvAlbums.TabIndex = 0;
            this.dgvAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellClick);
            // 
            // albumPicture
            // 
            this.albumPicture.Location = new System.Drawing.Point(12, 12);
            this.albumPicture.Name = "albumPicture";
            this.albumPicture.Size = new System.Drawing.Size(200, 200);
            this.albumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumPicture.TabIndex = 1;
            this.albumPicture.TabStop = false;
            // 
            // dgvTracks
            // 
            this.dgvTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Location = new System.Drawing.Point(349, 252);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.Size = new System.Drawing.Size(549, 458);
            this.dgvTracks.TabIndex = 2;
            this.dgvTracks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTracks_CellClick);
            // 
            // webVideo
            // 
            this.webVideo.Location = new System.Drawing.Point(12, 252);
            this.webVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webVideo.Name = "webVideo";
            this.webVideo.Size = new System.Drawing.Size(331, 233);
            this.webVideo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 722);
            this.Controls.Add(this.webVideo);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.albumPicture);
            this.Controls.Add(this.dgvAlbums);
            this.Name = "MainForm";
            this.Text = "Music Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.PictureBox albumPicture;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.WebBrowser webVideo;
    }
}

