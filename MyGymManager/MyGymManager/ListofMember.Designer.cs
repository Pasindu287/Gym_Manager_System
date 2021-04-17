namespace MyGymManager
{
    partial class ListofMember
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
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGymDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myGymDBDataSet = new MyGymManager.MyGymDBDataSet();
            this.myGymDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGymDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGymDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGymDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(566, 353);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 25);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(616, 314);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // myGymDBDataSetBindingSource
            // 
            this.myGymDBDataSetBindingSource.DataSource = this.myGymDBDataSet;
            this.myGymDBDataSetBindingSource.Position = 0;
            // 
            // myGymDBDataSet
            // 
            this.myGymDBDataSet.DataSetName = "MyGymDBDataSet";
            this.myGymDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myGymDBDataSetBindingSource1
            // 
            this.myGymDBDataSetBindingSource1.DataSource = this.myGymDBDataSet;
            this.myGymDBDataSetBindingSource1.Position = 0;
            // 
            // ListofMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyGymManager.Properties.Resources.search;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclose);
            this.Name = "ListofMember";
            this.Text = "ListofMember";
            this.Load += new System.EventHandler(this.ListofMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGymDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGymDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGymDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource myGymDBDataSetBindingSource;
        private MyGymDBDataSet myGymDBDataSet;
        private System.Windows.Forms.BindingSource myGymDBDataSetBindingSource1;
    }
}