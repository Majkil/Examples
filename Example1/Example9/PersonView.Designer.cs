﻿namespace Example9
{
    partial class PersonView
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
            this.personsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personsGridView
            // 
            this.personsGridView.AllowDrop = true;
            this.personsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personsGridView.Location = new System.Drawing.Point(0, 0);
            this.personsGridView.Name = "personsGridView";
            this.personsGridView.Size = new System.Drawing.Size(284, 262);
            this.personsGridView.TabIndex = 0;
            this.personsGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsGridView_RowLeave);
            this.personsGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.personsGridView_RowsAdded);
            // 
            // PersonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.personsGridView);
            this.Name = "PersonView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personsGridView;
    }
}

