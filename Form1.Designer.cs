namespace WindowsFormsApp14
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.title1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.title2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title1,
            this.title2,
            this.title3,
            this.title4,
            this.title5,
            this.title6});
            this.dataGridView1.Location = new System.Drawing.Point(1, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(962, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title1
            // 
            this.title1.HeaderText = "表示";
            this.title1.Name = "title1";
            this.title1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.title1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.title1.Width = 70;
            // 
            // title2
            // 
            this.title2.FillWeight = 141.6765F;
            this.title2.HeaderText = "タイトル";
            this.title2.Name = "title2";
            this.title2.Width = 300;
            // 
            // title3
            // 
            this.title3.FillWeight = 45.35721F;
            this.title3.HeaderText = "開始";
            this.title3.Name = "title3";
            this.title3.Width = 96;
            // 
            // title4
            // 
            this.title4.FillWeight = 54.86073F;
            this.title4.HeaderText = "終了";
            this.title4.Name = "title4";
            this.title4.Width = 116;
            // 
            // title5
            // 
            this.title5.FillWeight = 158.1056F;
            this.title5.HeaderText = "備考";
            this.title5.Name = "title5";
            this.title5.Width = 335;
            // 
            // title6
            // 
            this.title6.HeaderText = "Column1";
            this.title6.Name = "title6";
            this.title6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "インターンシップ";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title2;
        private System.Windows.Forms.DataGridViewTextBoxColumn title3;
        private System.Windows.Forms.DataGridViewTextBoxColumn title4;
        private System.Windows.Forms.DataGridViewTextBoxColumn title5;
        private System.Windows.Forms.DataGridViewTextBoxColumn title6;
    }
}

