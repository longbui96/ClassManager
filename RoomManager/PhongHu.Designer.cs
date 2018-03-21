namespace RoomManager
{
    partial class PhongHu
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
            this.dgvPH = new System.Windows.Forms.DataGridView();
            this.btnS = new System.Windows.Forms.Button();
            this.btnQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPH
            // 
            this.dgvPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPH.Location = new System.Drawing.Point(0, 0);
            this.dgvPH.Name = "dgvPH";
            this.dgvPH.Size = new System.Drawing.Size(747, 267);
            this.dgvPH.TabIndex = 1;
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnS.Location = new System.Drawing.Point(12, 287);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(161, 43);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "Sửa trạng thái";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnQL
            // 
            this.btnQL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQL.Location = new System.Drawing.Point(640, 287);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(95, 43);
            this.btnQL.TabIndex = 18;
            this.btnQL.Text = "Quay lại";
            this.btnQL.UseVisualStyleBackColor = true;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // PhongHu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 342);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.dgvPH);
            this.Name = "PhongHu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng hư";
            this.Load += new System.EventHandler(this.PhongHu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPH;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnQL;
    }
}