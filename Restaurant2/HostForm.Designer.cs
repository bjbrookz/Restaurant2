﻿namespace Restaurant2
{
    partial class HostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.btnTable7 = new System.Windows.Forms.Button();
            this.btnHostRefresh = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddCustomerParty = new System.Windows.Forms.Button();
            this.btnRemoveCustomerParty = new System.Windows.Forms.Button();
            this.lblCustomerQueue = new System.Windows.Forms.Label();
            this.lstCustomerQueue = new System.Windows.Forms.ListBox();
            this.lblPartyNameLegend = new System.Windows.Forms.Label();
            this.lblPartySizeLegend = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.txtPartySize = new System.Windows.Forms.TextBox();
            this.lblCustomerPartyName = new System.Windows.Forms.Label();
            this.lblPartySize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTable1
            // 
            this.btnTable1.BackColor = System.Drawing.SystemColors.Info;
            this.btnTable1.Location = new System.Drawing.Point(6, 457);
            this.btnTable1.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(76, 29);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = false;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.BackColor = System.Drawing.SystemColors.Info;
            this.btnTable2.Location = new System.Drawing.Point(6, 501);
            this.btnTable2.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(76, 32);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "Table 2";
            this.btnTable2.UseVisualStyleBackColor = false;
            this.btnTable2.Click += new System.EventHandler(this.btnTable2_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.BackColor = System.Drawing.SystemColors.Info;
            this.btnTable3.Location = new System.Drawing.Point(112, 502);
            this.btnTable3.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(76, 31);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "Table 3";
            this.btnTable3.UseVisualStyleBackColor = false;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // btnTable4
            // 
            this.btnTable4.BackColor = System.Drawing.SystemColors.Info;
            this.btnTable4.Location = new System.Drawing.Point(510, 457);
            this.btnTable4.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(76, 29);
            this.btnTable4.TabIndex = 3;
            this.btnTable4.Text = "Table 4";
            this.btnTable4.UseVisualStyleBackColor = false;
            this.btnTable4.Click += new System.EventHandler(this.btnTable4_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.BackColor = System.Drawing.SystemColors.Info;
            this.btnTable5.Location = new System.Drawing.Point(417, 504);
            this.btnTable5.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(79, 29);
            this.btnTable5.TabIndex = 4;
            this.btnTable5.Text = "Table 5";
            this.btnTable5.UseVisualStyleBackColor = false;
            this.btnTable5.Click += new System.EventHandler(this.btnTable5_Click);
            // 
            // btnTable6
            // 
            this.btnTable6.BackColor = System.Drawing.SystemColors.Info;
            this.btnTable6.Location = new System.Drawing.Point(516, 504);
            this.btnTable6.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(70, 29);
            this.btnTable6.TabIndex = 5;
            this.btnTable6.Text = "Table 6";
            this.btnTable6.UseVisualStyleBackColor = false;
            this.btnTable6.Click += new System.EventHandler(this.btnTable6_Click);
            // 
            // btnTable7
            // 
            this.btnTable7.BackColor = System.Drawing.SystemColors.Info;
            this.btnTable7.Location = new System.Drawing.Point(241, 499);
            this.btnTable7.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable7.Name = "btnTable7";
            this.btnTable7.Size = new System.Drawing.Size(141, 34);
            this.btnTable7.TabIndex = 6;
            this.btnTable7.Text = "Table 7";
            this.btnTable7.UseVisualStyleBackColor = false;
            this.btnTable7.Click += new System.EventHandler(this.btnTable7_Click);
            // 
            // btnHostRefresh
            // 
            this.btnHostRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnHostRefresh.Location = new System.Drawing.Point(480, 344);
            this.btnHostRefresh.Name = "btnHostRefresh";
            this.btnHostRefresh.Size = new System.Drawing.Size(64, 22);
            this.btnHostRefresh.TabIndex = 7;
            this.btnHostRefresh.Text = "Refresh";
            this.btnHostRefresh.UseVisualStyleBackColor = false;
            this.btnHostRefresh.Click += new System.EventHandler(this.btnHostRefresh_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogOut.Location = new System.Drawing.Point(480, 292);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(64, 23);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddCustomerParty
            // 
            this.btnAddCustomerParty.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddCustomerParty.Location = new System.Drawing.Point(241, 410);
            this.btnAddCustomerParty.Name = "btnAddCustomerParty";
            this.btnAddCustomerParty.Size = new System.Drawing.Size(125, 40);
            this.btnAddCustomerParty.TabIndex = 13;
            this.btnAddCustomerParty.Text = "Add Customer Party";
            this.btnAddCustomerParty.UseVisualStyleBackColor = false;
            this.btnAddCustomerParty.Click += new System.EventHandler(this.btnAddCustomerParty_Click);
            // 
            // btnRemoveCustomerParty
            // 
            this.btnRemoveCustomerParty.BackColor = System.Drawing.SystemColors.Info;
            this.btnRemoveCustomerParty.Location = new System.Drawing.Point(418, 165);
            this.btnRemoveCustomerParty.Name = "btnRemoveCustomerParty";
            this.btnRemoveCustomerParty.Size = new System.Drawing.Size(126, 31);
            this.btnRemoveCustomerParty.TabIndex = 12;
            this.btnRemoveCustomerParty.Text = "Remove Customer Party";
            this.btnRemoveCustomerParty.UseVisualStyleBackColor = false;
            this.btnRemoveCustomerParty.Click += new System.EventHandler(this.btnRemoveCustomerParty_Click);
            // 
            // lblCustomerQueue
            // 
            this.lblCustomerQueue.AutoSize = true;
            this.lblCustomerQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerQueue.Location = new System.Drawing.Point(252, 10);
            this.lblCustomerQueue.Name = "lblCustomerQueue";
            this.lblCustomerQueue.Size = new System.Drawing.Size(130, 20);
            this.lblCustomerQueue.TabIndex = 14;
            this.lblCustomerQueue.Text = "Customer Queue";
            // 
            // lstCustomerQueue
            // 
            this.lstCustomerQueue.FormattingEnabled = true;
            this.lstCustomerQueue.ItemHeight = 14;
            this.lstCustomerQueue.Location = new System.Drawing.Point(53, 57);
            this.lstCustomerQueue.Name = "lstCustomerQueue";
            this.lstCustomerQueue.Size = new System.Drawing.Size(491, 102);
            this.lstCustomerQueue.TabIndex = 15;
            // 
            // lblPartyNameLegend
            // 
            this.lblPartyNameLegend.AutoSize = true;
            this.lblPartyNameLegend.Location = new System.Drawing.Point(176, 40);
            this.lblPartyNameLegend.Name = "lblPartyNameLegend";
            this.lblPartyNameLegend.Size = new System.Drawing.Size(59, 14);
            this.lblPartyNameLegend.TabIndex = 16;
            this.lblPartyNameLegend.Text = "Party Name";
            // 
            // lblPartySizeLegend
            // 
            this.lblPartySizeLegend.AutoSize = true;
            this.lblPartySizeLegend.Location = new System.Drawing.Point(378, 40);
            this.lblPartySizeLegend.Name = "lblPartySizeLegend";
            this.lblPartySizeLegend.Size = new System.Drawing.Size(53, 14);
            this.lblPartySizeLegend.TabIndex = 17;
            this.lblPartySizeLegend.Text = "Party Size";
            // 
            // txtPartyName
            // 
            this.txtPartyName.Location = new System.Drawing.Point(195, 293);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(236, 19);
            this.txtPartyName.TabIndex = 18;
            // 
            // txtPartySize
            // 
            this.txtPartySize.Location = new System.Drawing.Point(195, 343);
            this.txtPartySize.Name = "txtPartySize";
            this.txtPartySize.Size = new System.Drawing.Size(236, 19);
            this.txtPartySize.TabIndex = 19;
            // 
            // lblCustomerPartyName
            // 
            this.lblCustomerPartyName.AutoSize = true;
            this.lblCustomerPartyName.Location = new System.Drawing.Point(68, 302);
            this.lblCustomerPartyName.Name = "lblCustomerPartyName";
            this.lblCustomerPartyName.Size = new System.Drawing.Size(59, 14);
            this.lblCustomerPartyName.TabIndex = 20;
            this.lblCustomerPartyName.Text = "Party Name";
            // 
            // lblPartySize
            // 
            this.lblPartySize.AutoSize = true;
            this.lblPartySize.Location = new System.Drawing.Point(68, 348);
            this.lblPartySize.Name = "lblPartySize";
            this.lblPartySize.Size = new System.Drawing.Size(53, 14);
            this.lblPartySize.TabIndex = 21;
            this.lblPartySize.Text = "Party Size";
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 545);
            this.Controls.Add(this.lblPartySize);
            this.Controls.Add(this.lblCustomerPartyName);
            this.Controls.Add(this.txtPartySize);
            this.Controls.Add(this.txtPartyName);
            this.Controls.Add(this.lblPartySizeLegend);
            this.Controls.Add(this.lblPartyNameLegend);
            this.Controls.Add(this.lstCustomerQueue);
            this.Controls.Add(this.lblCustomerQueue);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnHostRefresh);
            this.Controls.Add(this.btnTable7);
            this.Controls.Add(this.btnAddCustomerParty);
            this.Controls.Add(this.btnTable6);
            this.Controls.Add(this.btnRemoveCustomerParty);
            this.Controls.Add(this.btnTable5);
            this.Controls.Add(this.btnTable4);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HostForm";
            this.Text = "HostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Button btnTable7;
        private System.Windows.Forms.Button btnHostRefresh;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddCustomerParty;
        private System.Windows.Forms.Button btnRemoveCustomerParty;
        private System.Windows.Forms.Label lblCustomerQueue;
        private System.Windows.Forms.ListBox lstCustomerQueue;
        private System.Windows.Forms.Label lblPartyNameLegend;
        private System.Windows.Forms.Label lblPartySizeLegend;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.TextBox txtPartySize;
        private System.Windows.Forms.Label lblCustomerPartyName;
        private System.Windows.Forms.Label lblPartySize;
    }
}