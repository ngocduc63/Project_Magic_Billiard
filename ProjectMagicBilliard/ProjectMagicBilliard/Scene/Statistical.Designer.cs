
namespace ProjectMagicBilliard.Scene
{
    partial class Statistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDetail = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRevenue
            // 
            chartArea6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea6.BorderColor = System.Drawing.Color.BlanchedAlmond;
            chartArea6.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend6);
            this.chartRevenue.Location = new System.Drawing.Point(11, 100);
            this.chartRevenue.Name = "chartRevenue";
            series6.BackSecondaryColor = System.Drawing.Color.White;
            series6.BorderColor = System.Drawing.Color.OrangeRed;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.DeepSkyBlue;
            series6.Legend = "Legend1";
            series6.MarkerBorderColor = System.Drawing.Color.White;
            series6.MarkerColor = System.Drawing.Color.White;
            series6.Name = "Doanh Thu";
            this.chartRevenue.Series.Add(series6);
            this.chartRevenue.Size = new System.Drawing.Size(763, 472);
            this.chartRevenue.TabIndex = 0;
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(799, 37);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(158, 46);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Xem chi tiết ";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(11, 100);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 62;
            this.dgvDetail.RowTemplate.Height = 28;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(959, 472);
            this.dgvDetail.TabIndex = 2;
            // 
            // Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.chartRevenue);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Statistical";
            this.Padding = new System.Windows.Forms.Padding(20, 57, 20, 19);
            this.Text = "Thống kê doanh thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Statistical_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DataGridView dgvDetail;
    }
}