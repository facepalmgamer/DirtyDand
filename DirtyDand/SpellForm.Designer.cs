﻿
namespace DirtyDand
{
    partial class SpellForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSpellMain = new System.Windows.Forms.Panel();
            this.dataGridViewSpells = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panelSpellMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpells)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelSpellMain);
            this.panelMain.Controls.Add(this.panelSearch);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1632, 918);
            this.panelMain.TabIndex = 3;
            // 
            // panelSpellMain
            // 
            this.panelSpellMain.AutoScroll = true;
            this.panelSpellMain.BackColor = System.Drawing.Color.Black;
            this.panelSpellMain.Controls.Add(this.dataGridViewSpells);
            this.panelSpellMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSpellMain.Location = new System.Drawing.Point(0, 123);
            this.panelSpellMain.Name = "panelSpellMain";
            this.panelSpellMain.Size = new System.Drawing.Size(1632, 795);
            this.panelSpellMain.TabIndex = 7;
            // 
            // dataGridViewSpells
            // 
            this.dataGridViewSpells.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewSpells.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSpells.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSpells.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewSpells.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSpells.Name = "dataGridViewSpells";
            this.dataGridViewSpells.Size = new System.Drawing.Size(1632, 795);
            this.dataGridViewSpells.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSearchBar);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1632, 123);
            this.panelSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSearch.Location = new System.Drawing.Point(1005, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 103);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "button1";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBar.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxSearchBar.Location = new System.Drawing.Point(10, 10);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(977, 103);
            this.textBoxSearchBar.TabIndex = 0;
            // 
            // SpellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 918);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpellForm";
            this.Text = "SpellForm";
            this.panelMain.ResumeLayout(false);
            this.panelSpellMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpells)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Panel panelSpellMain;
        private System.Windows.Forms.DataGridView dataGridViewSpells;
    }
}