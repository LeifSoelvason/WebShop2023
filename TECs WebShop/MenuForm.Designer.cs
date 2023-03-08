namespace TECs_WebShop
{
    partial class MenuForm
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
            this.btn_kunde = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_indkøbskurv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kunde
            // 
            this.btn_kunde.Location = new System.Drawing.Point(64, 40);
            this.btn_kunde.Name = "btn_kunde";
            this.btn_kunde.Size = new System.Drawing.Size(75, 23);
            this.btn_kunde.TabIndex = 0;
            this.btn_kunde.Text = "Kunde";
            this.btn_kunde.UseVisualStyleBackColor = true;
            this.btn_kunde.Click += new System.EventHandler(this.btn_kunde_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(693, 398);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_indkøbskurv
            // 
            this.btn_indkøbskurv.Location = new System.Drawing.Point(64, 96);
            this.btn_indkøbskurv.Name = "btn_indkøbskurv";
            this.btn_indkøbskurv.Size = new System.Drawing.Size(75, 23);
            this.btn_indkøbskurv.TabIndex = 2;
            this.btn_indkøbskurv.Text = "Indkøbskurv";
            this.btn_indkøbskurv.UseVisualStyleBackColor = true;
            this.btn_indkøbskurv.Click += new System.EventHandler(this.btn_indkøbskurv_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_indkøbskurv);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_kunde);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kunde;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_indkøbskurv;
    }
}