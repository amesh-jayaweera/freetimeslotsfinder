namespace FreeTimeSlotFinder
{
    partial class Free_Time_Slots
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
            this.dgv_freeTimeSlots = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_freeTimeSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_freeTimeSlots
            // 
            this.dgv_freeTimeSlots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_freeTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_freeTimeSlots.Location = new System.Drawing.Point(12, 107);
            this.dgv_freeTimeSlots.Name = "dgv_freeTimeSlots";
            this.dgv_freeTimeSlots.Size = new System.Drawing.Size(355, 331);
            this.dgv_freeTimeSlots.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(113, 71);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Free Time Slots";
            // 
            // Free_Time_Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dgv_freeTimeSlots);
            this.MaximizeBox = false;
            this.Name = "Free_Time_Slots";
            this.Text = "Free Time Slots";
            this.Load += new System.EventHandler(this.Free_Time_Slots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_freeTimeSlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_freeTimeSlots;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}