namespace TECs_WebShop
{
    partial class IndkøbskurvForm
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
            this.btn_tilføj = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_antalvarer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webshop_DBDataSet = new TECs_WebShop.Webshop_DBDataSet();
            this.productTableAdapter = new TECs_WebShop.Webshop_DBDataSetTableAdapters.ProductTableAdapter();
            this.btn_checkout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webshop_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tilføj
            // 
            this.btn_tilføj.Location = new System.Drawing.Point(250, 187);
            this.btn_tilføj.Name = "btn_tilføj";
            this.btn_tilføj.Size = new System.Drawing.Size(75, 23);
            this.btn_tilføj.TabIndex = 1;
            this.btn_tilføj.Text = "Tilføj";
            this.btn_tilføj.UseVisualStyleBackColor = true;
            this.btn_tilføj.Click += new System.EventHandler(this.btn_tilføj_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(713, 409);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 29);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_antalvarer
            // 
            this.lbl_antalvarer.AutoSize = true;
            this.lbl_antalvarer.Location = new System.Drawing.Point(111, 13);
            this.lbl_antalvarer.Name = "lbl_antalvarer";
            this.lbl_antalvarer.Size = new System.Drawing.Size(35, 13);
            this.lbl_antalvarer.TabIndex = 5;
            this.lbl_antalvarer.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.webshop_DBDataSet;
            // 
            // webshop_DBDataSet
            // 
            this.webshop_DBDataSet.DataSetName = "Webshop_DBDataSet";
            this.webshop_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(577, 187);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(75, 23);
            this.btn_checkout.TabIndex = 6;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // IndkøbskurvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.lbl_antalvarer);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_tilføj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IndkøbskurvForm";
            this.Text = "Indkøbskurv";
            this.Load += new System.EventHandler(this.IndkøbskurvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webshop_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_tilføj;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_antalvarer;
        private Webshop_DBDataSet webshop_DBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Webshop_DBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_checkout;
    }
}