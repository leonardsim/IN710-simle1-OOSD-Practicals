﻿namespace PubsAndClubs
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
            this.dgvGigs = new System.Windows.Forms.DataGridView();
            this.bandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGigs
            // 
            this.dgvGigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bandName,
            this.genre,
            this.venue,
            this.date,
            this.time});
            this.dgvGigs.Location = new System.Drawing.Point(13, 13);
            this.dgvGigs.Name = "dgvGigs";
            this.dgvGigs.Size = new System.Drawing.Size(504, 150);
            this.dgvGigs.TabIndex = 0;
            // 
            // bandName
            // 
            this.bandName.HeaderText = "Band Name";
            this.bandName.Name = "bandName";
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // venue
            // 
            this.venue.HeaderText = "Venue";
            this.venue.Name = "venue";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(13, 169);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(114, 44);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Display band info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(133, 169);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(114, 44);
            this.btnRock.TabIndex = 2;
            this.btnRock.Text = "\"Hard Rock\" genre";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(253, 169);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(114, 44);
            this.btnMonth.TabIndex = 3;
            this.btnMonth.Text = "Current month gig";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 225);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.dgvGigs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGigs;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnMonth;
    }
}

