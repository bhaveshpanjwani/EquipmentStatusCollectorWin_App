namespace EquipmentStatusCollector
{
    partial class EquipmentStatusCollector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentStatusCollector));
            this.CollectStatusButton = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.IPAddressGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxIPAddress = new System.Windows.Forms.TextBox();
            this.LastStatusCollectLabel = new System.Windows.Forms.Label();
            this.IPAddressLable = new System.Windows.Forms.Label();
            this.LabelForLastStatusDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CollectStatusButton
            // 
            this.CollectStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectStatusButton.Location = new System.Drawing.Point(104, 136);
            this.CollectStatusButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.CollectStatusButton.Name = "CollectStatusButton";
            this.CollectStatusButton.Size = new System.Drawing.Size(221, 38);
            this.CollectStatusButton.TabIndex = 12;
            this.CollectStatusButton.Text = "Collect Status";
            this.CollectStatusButton.UseVisualStyleBackColor = true;
            this.CollectStatusButton.Click += new System.EventHandler(this.CollectStatusButton_Click);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPAddressGridView,
            this.StatusGridView});
            this.GridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridView.GridColor = System.Drawing.SystemColors.Window;
            this.GridView.Location = new System.Drawing.Point(62, 207);
            this.GridView.Name = "GridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridView.Size = new System.Drawing.Size(298, 55);
            this.GridView.TabIndex = 9;
            this.GridView.Visible = false;
            // 
            // IPAddressGridView
            // 
            this.IPAddressGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IPAddressGridView.HeaderText = "IP Address";
            this.IPAddressGridView.Name = "IPAddressGridView";
            this.IPAddressGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StatusGridView
            // 
            this.StatusGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusGridView.HeaderText = "Status";
            this.StatusGridView.Name = "StatusGridView";
            this.StatusGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TextBoxIPAddress
            // 
            this.TextBoxIPAddress.AcceptsTab = true;
            this.TextBoxIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxIPAddress.Location = new System.Drawing.Point(215, 64);
            this.TextBoxIPAddress.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.TextBoxIPAddress.MaxLength = 46;
            this.TextBoxIPAddress.Name = "TextBoxIPAddress";
            this.TextBoxIPAddress.Size = new System.Drawing.Size(183, 27);
            this.TextBoxIPAddress.TabIndex = 11;
            // 
            // LastStatusCollectLabel
            // 
            this.LastStatusCollectLabel.AutoSize = true;
            this.LastStatusCollectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastStatusCollectLabel.Location = new System.Drawing.Point(58, 289);
            this.LastStatusCollectLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 50);
            this.LastStatusCollectLabel.Name = "LastStatusCollectLabel";
            this.LastStatusCollectLabel.Size = new System.Drawing.Size(207, 22);
            this.LastStatusCollectLabel.TabIndex = 10;
            this.LastStatusCollectLabel.Text = "Last Status Collected At:";
            this.LastStatusCollectLabel.Visible = false;
            // 
            // IPAddressLable
            // 
            this.IPAddressLable.AutoSize = true;
            this.IPAddressLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressLable.Location = new System.Drawing.Point(58, 64);
            this.IPAddressLable.Name = "IPAddressLable";
            this.IPAddressLable.Size = new System.Drawing.Size(97, 22);
            this.IPAddressLable.TabIndex = 8;
            this.IPAddressLable.Text = "IP Address";
            // 
            // LabelForLastStatusDateTime
            // 
            this.LabelForLastStatusDateTime.AutoSize = true;
            this.LabelForLastStatusDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForLastStatusDateTime.Location = new System.Drawing.Point(262, 289);
            this.LabelForLastStatusDateTime.Name = "LabelForLastStatusDateTime";
            this.LabelForLastStatusDateTime.Size = new System.Drawing.Size(0, 22);
            this.LabelForLastStatusDateTime.TabIndex = 13;
            this.LabelForLastStatusDateTime.Visible = false;
            // 
            // EquipmentStatusCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(777, 437);
            this.Controls.Add(this.LabelForLastStatusDateTime);
            this.Controls.Add(this.CollectStatusButton);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.TextBoxIPAddress);
            this.Controls.Add(this.LastStatusCollectLabel);
            this.Controls.Add(this.IPAddressLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EquipmentStatusCollector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentStatusCollector";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CollectStatusButton;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox TextBoxIPAddress;
        private System.Windows.Forms.Label LastStatusCollectLabel;
        private System.Windows.Forms.Label IPAddressLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAddressGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGridView;
        private System.Windows.Forms.Label LabelForLastStatusDateTime;
    }
}

