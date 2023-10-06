
namespace ProjectMagicBilliard.Scene
{
    partial class TableItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.Label();
            this.txtTimePlay = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.timePlay = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Location = new System.Drawing.Point(35, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(107, 41);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Bàn 1";
            // 
            // txtTimePlay
            // 
            this.txtTimePlay.AutoSize = true;
            this.txtTimePlay.BackColor = System.Drawing.Color.Transparent;
            this.txtTimePlay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimePlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimePlay.Location = new System.Drawing.Point(25, 31);
            this.txtTimePlay.Name = "txtTimePlay";
            this.txtTimePlay.Size = new System.Drawing.Size(144, 41);
            this.txtTimePlay.TabIndex = 1;
            this.txtTimePlay.Text = "17:10:03";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.Location = new System.Drawing.Point(23, 92);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(153, 33);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "Giá : 40,000";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.BackColor = System.Drawing.Color.Transparent;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtId.Location = new System.Drawing.Point(2, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 45);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "1";
            // 
            // timePlay
            // 
            this.timePlay.Enabled = true;
            this.timePlay.Tick += new System.EventHandler(this.timePlay_Tick);
            // 
            // txtStatus
            // 
            this.txtStatus.AcceptsTab = true;
            this.txtStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtStatus.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(0, 62);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(139, 37);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Text = "Chờ thanh toán";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatus.Click += new System.EventHandler(this.TableItem_Click);
            this.txtStatus.EnabledChanged += new System.EventHandler(this.txtStatus_EnabledChanged);
            // 
            // TableItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTimePlay);
            this.Controls.Add(this.txtName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TableItem";
            this.Size = new System.Drawing.Size(140, 123);
            this.Load += new System.EventHandler(this.TableItem_Load);
            this.Click += new System.EventHandler(this.TableItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtTimePlay;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Timer timePlay;
        private System.Windows.Forms.TextBox txtStatus;
    }
}
