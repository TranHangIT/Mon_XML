
namespace SampleXML
{
    partial class Form1
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
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.dgvFruits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColors
            // 
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Location = new System.Drawing.Point(33, 225);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.Size = new System.Drawing.Size(420, 267);
            this.dgvColors.TabIndex = 0;
            // 
            // dgvFruits
            // 
            this.dgvFruits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruits.Location = new System.Drawing.Point(648, 225);
            this.dgvFruits.Name = "dgvFruits";
            this.dgvFruits.Size = new System.Drawing.Size(420, 267);
            this.dgvFruits.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 572);
            this.Controls.Add(this.dgvFruits);
            this.Controls.Add(this.dgvColors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.DataGridView dgvFruits;
    }
}

