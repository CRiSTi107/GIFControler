namespace PlayGif
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
            this.pic_Gif = new System.Windows.Forms.PictureBox();
            this.cmb_Index = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Gif
            // 
            this.pic_Gif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Gif.Location = new System.Drawing.Point(12, 12);
            this.pic_Gif.Name = "pic_Gif";
            this.pic_Gif.Size = new System.Drawing.Size(460, 411);
            this.pic_Gif.TabIndex = 0;
            this.pic_Gif.TabStop = false;
            // 
            // cmb_Index
            // 
            this.cmb_Index.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_Index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Index.FormattingEnabled = true;
            this.cmb_Index.Location = new System.Drawing.Point(185, 429);
            this.cmb_Index.Name = "cmb_Index";
            this.cmb_Index.Size = new System.Drawing.Size(121, 21);
            this.cmb_Index.TabIndex = 2;
            this.cmb_Index.SelectedIndexChanged += new System.EventHandler(this.cmb_Index_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.cmb_Index);
            this.Controls.Add(this.pic_Gif);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playing Gif";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Gif;
        private System.Windows.Forms.ComboBox cmb_Index;
    }
}

