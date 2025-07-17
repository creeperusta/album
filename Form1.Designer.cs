namespace album
{
    partial class Form1
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
            this.Albumviem = new System.Windows.Forms.Button();
            this.likesong = new System.Windows.Forms.DataGridView();
            this.albumname = new System.Windows.Forms.Label();
            this.Albumhistory = new System.Windows.Forms.Label();
            this.albumowner = new System.Windows.Forms.Label();
            this.albumsong = new System.Windows.Forms.Label();
            this.albumtime = new System.Windows.Forms.Label();
            this.totaltime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.likesong_text = new System.Windows.Forms.TextBox();
            this.totaltime_text = new System.Windows.Forms.TextBox();
            this.Albumtime_text = new System.Windows.Forms.TextBox();
            this.Albumsong_text = new System.Windows.Forms.TextBox();
            this.Albumowner_text = new System.Windows.Forms.TextBox();
            this.albumhistory_text = new System.Windows.Forms.TextBox();
            this.Albumname_text = new System.Windows.Forms.TextBox();
            this.albumadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.likesong)).BeginInit();
            this.SuspendLayout();
            // 
            // Albumviem
            // 
            this.Albumviem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Albumviem.Font = new System.Drawing.Font("Noto Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albumviem.Location = new System.Drawing.Point(12, 12);
            this.Albumviem.Name = "Albumviem";
            this.Albumviem.Size = new System.Drawing.Size(202, 84);
            this.Albumviem.TabIndex = 0;
            this.Albumviem.Text = "Album viem";
            this.Albumviem.UseVisualStyleBackColor = false;
            this.Albumviem.Click += new System.EventHandler(this.Albumviem_Click);
            // 
            // likesong
            // 
            this.likesong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.likesong.Location = new System.Drawing.Point(12, 267);
            this.likesong.Name = "likesong";
            this.likesong.Size = new System.Drawing.Size(776, 183);
            this.likesong.TabIndex = 1;
            // 
            // albumname
            // 
            this.albumname.AutoSize = true;
            this.albumname.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.albumname.Location = new System.Drawing.Point(240, 7);
            this.albumname.Name = "albumname";
            this.albumname.Size = new System.Drawing.Size(129, 29);
            this.albumname.TabIndex = 2;
            this.albumname.Text = "Album name";
            // 
            // Albumhistory
            // 
            this.Albumhistory.AutoSize = true;
            this.Albumhistory.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Albumhistory.ForeColor = System.Drawing.Color.Black;
            this.Albumhistory.Location = new System.Drawing.Point(240, 37);
            this.Albumhistory.Name = "Albumhistory";
            this.Albumhistory.Size = new System.Drawing.Size(140, 29);
            this.Albumhistory.TabIndex = 4;
            this.Albumhistory.Text = "Album history";
            // 
            // albumowner
            // 
            this.albumowner.AutoSize = true;
            this.albumowner.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.albumowner.Location = new System.Drawing.Point(240, 66);
            this.albumowner.Name = "albumowner";
            this.albumowner.Size = new System.Drawing.Size(135, 29);
            this.albumowner.TabIndex = 6;
            this.albumowner.Text = "Album owner";
            // 
            // albumsong
            // 
            this.albumsong.AutoSize = true;
            this.albumsong.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.albumsong.Location = new System.Drawing.Point(240, 95);
            this.albumsong.Name = "albumsong";
            this.albumsong.Size = new System.Drawing.Size(122, 29);
            this.albumsong.TabIndex = 8;
            this.albumsong.Text = "Album song";
            // 
            // albumtime
            // 
            this.albumtime.AutoSize = true;
            this.albumtime.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.albumtime.Location = new System.Drawing.Point(240, 124);
            this.albumtime.Name = "albumtime";
            this.albumtime.Size = new System.Drawing.Size(118, 29);
            this.albumtime.TabIndex = 10;
            this.albumtime.Text = "Album time";
            // 
            // totaltime
            // 
            this.totaltime.AutoSize = true;
            this.totaltime.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totaltime.Location = new System.Drawing.Point(250, 153);
            this.totaltime.Name = "totaltime";
            this.totaltime.Size = new System.Drawing.Size(99, 29);
            this.totaltime.TabIndex = 12;
            this.totaltime.Text = "Totaltime";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(250, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 29);
            this.label14.TabIndex = 15;
            this.label14.Text = "Like song";
            // 
            // likesong_text
            // 
            this.likesong_text.Location = new System.Drawing.Point(355, 190);
            this.likesong_text.Name = "likesong_text";
            this.likesong_text.Size = new System.Drawing.Size(100, 20);
            this.likesong_text.TabIndex = 16;
            // 
            // totaltime_text
            // 
            this.totaltime_text.Location = new System.Drawing.Point(355, 156);
            this.totaltime_text.Name = "totaltime_text";
            this.totaltime_text.Size = new System.Drawing.Size(100, 20);
            this.totaltime_text.TabIndex = 17;
            // 
            // Albumtime_text
            // 
            this.Albumtime_text.Location = new System.Drawing.Point(355, 127);
            this.Albumtime_text.Name = "Albumtime_text";
            this.Albumtime_text.Size = new System.Drawing.Size(100, 20);
            this.Albumtime_text.TabIndex = 18;
            // 
            // Albumsong_text
            // 
            this.Albumsong_text.Location = new System.Drawing.Point(355, 98);
            this.Albumsong_text.Name = "Albumsong_text";
            this.Albumsong_text.Size = new System.Drawing.Size(100, 20);
            this.Albumsong_text.TabIndex = 19;
            // 
            // Albumowner_text
            // 
            this.Albumowner_text.Location = new System.Drawing.Point(381, 72);
            this.Albumowner_text.Name = "Albumowner_text";
            this.Albumowner_text.Size = new System.Drawing.Size(100, 20);
            this.Albumowner_text.TabIndex = 20;
            // 
            // albumhistory_text
            // 
            this.albumhistory_text.Location = new System.Drawing.Point(386, 44);
            this.albumhistory_text.Name = "albumhistory_text";
            this.albumhistory_text.Size = new System.Drawing.Size(100, 20);
            this.albumhistory_text.TabIndex = 21;
            // 
            // Albumname_text
            // 
            this.Albumname_text.Location = new System.Drawing.Point(375, 12);
            this.Albumname_text.Name = "Albumname_text";
            this.Albumname_text.Size = new System.Drawing.Size(100, 20);
            this.Albumname_text.TabIndex = 22;
            // 
            // albumadd
            // 
            this.albumadd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.albumadd.Font = new System.Drawing.Font("Noto Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumadd.Location = new System.Drawing.Point(12, 123);
            this.albumadd.Name = "albumadd";
            this.albumadd.Size = new System.Drawing.Size(202, 84);
            this.albumadd.TabIndex = 23;
            this.albumadd.Text = "Album Add";
            this.albumadd.UseVisualStyleBackColor = false;
            this.albumadd.Click += new System.EventHandler(this.albumadd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.albumadd);
            this.Controls.Add(this.Albumname_text);
            this.Controls.Add(this.albumhistory_text);
            this.Controls.Add(this.Albumowner_text);
            this.Controls.Add(this.Albumsong_text);
            this.Controls.Add(this.Albumtime_text);
            this.Controls.Add(this.totaltime_text);
            this.Controls.Add(this.likesong_text);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.totaltime);
            this.Controls.Add(this.albumtime);
            this.Controls.Add(this.albumsong);
            this.Controls.Add(this.albumowner);
            this.Controls.Add(this.Albumhistory);
            this.Controls.Add(this.albumname);
            this.Controls.Add(this.likesong);
            this.Controls.Add(this.Albumviem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.likesong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Albumviem;
        private System.Windows.Forms.DataGridView likesong;
        private System.Windows.Forms.Label albumname;
        private System.Windows.Forms.Label Albumhistory;
        private System.Windows.Forms.Label albumowner;
        private System.Windows.Forms.Label albumsong;
        private System.Windows.Forms.Label albumtime;
        private System.Windows.Forms.Label totaltime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox likesong_text;
        private System.Windows.Forms.TextBox totaltime_text;
        private System.Windows.Forms.TextBox Albumtime_text;
        private System.Windows.Forms.TextBox Albumsong_text;
        private System.Windows.Forms.TextBox Albumowner_text;
        private System.Windows.Forms.TextBox albumhistory_text;
        private System.Windows.Forms.TextBox Albumname_text;
        private System.Windows.Forms.Button albumadd;
    }
}

