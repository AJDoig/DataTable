﻿namespace DataTable
{
    partial class FormDataTable
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(24, 20);
            this.ButtonAdd.Name = "ButtonFillDisplay";
            this.ButtonAdd.Size = new System.Drawing.Size(87, 34);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Fill and Display";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonFillDisplay_MouseClick);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(128, 34);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(100, 20);
            this.TextBoxInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Number ";
            // 
            // ListViewData
            // 
            this.ListViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewData.HideSelection = false;
            this.ListViewData.Location = new System.Drawing.Point(24, 72);
            this.ListViewData.Name = "ListViewData";
            this.ListViewData.Size = new System.Drawing.Size(326, 295);
            this.ListViewData.TabIndex = 5;
            this.ListViewData.UseCompatibleStateImageBehavior = false;
            this.ListViewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Col_1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Col_2";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Col_3";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Col_4";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Col_5";
            // 
            // FormDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 389);
            this.Controls.Add(this.ListViewData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ButtonAdd);
            this.Name = "FormDataTable";
            this.Text = "My Data Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

