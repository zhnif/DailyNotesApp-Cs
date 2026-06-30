namespace DailyNotesApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Ui sederhana
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox contentTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView notesGrid;

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

            this.titleTxt = new System.Windows.Forms.TextBox();
            this.contentTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.notesGrid = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.notesGrid)).BeginInit();
            this.SuspendLayout();

            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(20, 20);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(250, 20);
            this.titleTxt.TabIndex = 0;
            // 
            // contentTxt
            // 
            this.contentTxt.Location = new System.Drawing.Point(20, 60);
            this.contentTxt.Multiline = true;
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.Size = new System.Drawing.Size(250, 100);
            this.contentTxt.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(20, 170);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(120, 30);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Simpan Catatan";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // notesGrid
            // 
            this.notesGrid.AllowUserToAddRows = false;
            this.notesGrid.AllowUserToDeleteRows = false;
            this.notesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesGrid.Location = new System.Drawing.Point(300, 20);
            this.notesGrid.Name = "notesGrid";
            this.notesGrid.ReadOnly = true;
            this.notesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesGrid.Size = new System.Drawing.Size(300, 200);
            this.notesGrid.TabIndex = 3;
            this.notesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesGrid_CellDoubleClick);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 260);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.contentTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.notesGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Notes App";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.notesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

