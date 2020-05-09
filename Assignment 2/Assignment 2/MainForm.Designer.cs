namespace Assingment2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.dealerBox = new System.Windows.Forms.GroupBox();
            this.dealerHandLabel = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.playerBox = new System.Windows.Forms.GroupBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerHandLabel = new System.Windows.Forms.Label();
            this.scoreTable = new System.Windows.Forms.DataGridView();
            this.columnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.cardsLeftLabel = new System.Windows.Forms.Label();
            this.dealerBox.SuspendLayout();
            this.playerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(11, 123);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(2);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(104, 32);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(11, 87);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(104, 32);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(11, 159);
            this.btnStand.Margin = new System.Windows.Forms.Padding(2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(104, 32);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // dealerBox
            // 
            this.dealerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dealerBox.Controls.Add(this.dealerHandLabel);
            this.dealerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBox.Location = new System.Drawing.Point(615, 41);
            this.dealerBox.Margin = new System.Windows.Forms.Padding(2);
            this.dealerBox.Name = "dealerBox";
            this.dealerBox.Padding = new System.Windows.Forms.Padding(2);
            this.dealerBox.Size = new System.Drawing.Size(420, 339);
            this.dealerBox.TabIndex = 6;
            this.dealerBox.TabStop = false;
            this.dealerBox.Text = "Dealer";
            this.dealerBox.Paint += new System.Windows.Forms.PaintEventHandler(this.dealerBox_Paint);
            // 
            // dealerHandLabel
            // 
            this.dealerHandLabel.AutoSize = true;
            this.dealerHandLabel.Location = new System.Drawing.Point(4, 19);
            this.dealerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerHandLabel.Name = "dealerHandLabel";
            this.dealerHandLabel.Size = new System.Drawing.Size(86, 17);
            this.dealerHandLabel.TabIndex = 1;
            this.dealerHandLabel.Text = "Hand Value:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 348);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 32);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerBox.Controls.Add(this.playerLabel);
            this.playerBox.Controls.Add(this.playerHandLabel);
            this.playerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBox.Location = new System.Drawing.Point(215, 41);
            this.playerBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerBox.Name = "playerBox";
            this.playerBox.Padding = new System.Windows.Forms.Padding(2);
            this.playerBox.Size = new System.Drawing.Size(373, 339);
            this.playerBox.TabIndex = 7;
            this.playerBox.TabStop = false;
            this.playerBox.Paint += new System.Windows.Forms.PaintEventHandler(this.playerBox_Paint);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(4, 0);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(0, 17);
            this.playerLabel.TabIndex = 1;
            // 
            // playerHandLabel
            // 
            this.playerHandLabel.AutoSize = true;
            this.playerHandLabel.Location = new System.Drawing.Point(4, 19);
            this.playerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerHandLabel.Name = "playerHandLabel";
            this.playerHandLabel.Size = new System.Drawing.Size(86, 17);
            this.playerHandLabel.TabIndex = 0;
            this.playerHandLabel.Text = "Hand Value:";
            // 
            // scoreTable
            // 
            this.scoreTable.AllowUserToAddRows = false;
            this.scoreTable.AllowUserToDeleteRows = false;
            this.scoreTable.AllowUserToResizeColumns = false;
            this.scoreTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.scoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCountry,
            this.ColumnID,
            this.ColumnCity});
            this.scoreTable.Location = new System.Drawing.Point(1059, 41);
            this.scoreTable.Margin = new System.Windows.Forms.Padding(2);
            this.scoreTable.MultiSelect = false;
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.ReadOnly = true;
            this.scoreTable.RowHeadersVisible = false;
            this.scoreTable.RowHeadersWidth = 20;
            this.scoreTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.scoreTable.RowTemplate.Height = 64;
            this.scoreTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scoreTable.Size = new System.Drawing.Size(245, 335);
            this.scoreTable.TabIndex = 18;
            // 
            // columnCountry
            // 
            this.columnCountry.FillWeight = 75F;
            this.columnCountry.Frozen = true;
            this.columnCountry.HeaderText = "Name";
            this.columnCountry.MaxInputLength = 200;
            this.columnCountry.Name = "columnCountry";
            this.columnCountry.ReadOnly = true;
            this.columnCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnCountry.Width = 75;
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 45F;
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "Value";
            this.ColumnID.MaxInputLength = 10;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnID.Width = 45;
            // 
            // ColumnCity
            // 
            this.ColumnCity.FillWeight = 125F;
            this.ColumnCity.Frozen = true;
            this.ColumnCity.HeaderText = "State";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            this.ColumnCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCity.Width = 125;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 750;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // displayTimer
            // 
            this.displayTimer.Interval = 1000;
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // cardsLeftLabel
            // 
            this.cardsLeftLabel.AutoSize = true;
            this.cardsLeftLabel.Location = new System.Drawing.Point(5, 9);
            this.cardsLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardsLeftLabel.Name = "cardsLeftLabel";
            this.cardsLeftLabel.Size = new System.Drawing.Size(82, 13);
            this.cardsLeftLabel.TabIndex = 2;
            this.cardsLeftLabel.Text = "Cards available:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1327, 391);
            this.Controls.Add(this.cardsLeftLabel);
            this.Controls.Add(this.scoreTable);
            this.Controls.Add(this.dealerBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnShuffle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.dealerBox.ResumeLayout(false);
            this.dealerBox.PerformLayout();
            this.playerBox.ResumeLayout(false);
            this.playerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.GroupBox dealerBox;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox playerBox;
        private System.Windows.Forms.DataGridView scoreTable;
        private System.Windows.Forms.Label playerHandLabel;
        private System.Windows.Forms.Label dealerHandLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.Label cardsLeftLabel;
    }
}

