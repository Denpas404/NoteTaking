namespace NoteTaking
{
    partial class Notes
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.Message_lbl = new System.Windows.Forms.Label();
            this.message_txtbox = new System.Windows.Forms.TextBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.read_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(48, 70);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(27, 13);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Title";
            // 
            // title_txtbox
            // 
            this.title_txtbox.Location = new System.Drawing.Point(81, 67);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(260, 20);
            this.title_txtbox.TabIndex = 1;
            // 
            // Message_lbl
            // 
            this.Message_lbl.AutoSize = true;
            this.Message_lbl.Location = new System.Drawing.Point(25, 103);
            this.Message_lbl.Name = "Message_lbl";
            this.Message_lbl.Size = new System.Drawing.Size(50, 13);
            this.Message_lbl.TabIndex = 2;
            this.Message_lbl.Text = "Message";
            // 
            // message_txtbox
            // 
            this.message_txtbox.Location = new System.Drawing.Point(81, 100);
            this.message_txtbox.Multiline = true;
            this.message_txtbox.Name = "message_txtbox";
            this.message_txtbox.Size = new System.Drawing.Size(260, 198);
            this.message_txtbox.TabIndex = 3;
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(81, 369);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(75, 23);
            this.new_btn.TabIndex = 5;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(265, 369);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // read_btn
            // 
            this.read_btn.Location = new System.Drawing.Point(425, 369);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(75, 23);
            this.read_btn.TabIndex = 7;
            this.read_btn.Text = "Read";
            this.read_btn.UseVisualStyleBackColor = true;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(688, 369);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(338, 228);
            this.dataGridView1.TabIndex = 9;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.message_txtbox);
            this.Controls.Add(this.Message_lbl);
            this.Controls.Add(this.title_txtbox);
            this.Controls.Add(this.title_lbl);
            this.Name = "Notes";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.Label Message_lbl;
        private System.Windows.Forms.TextBox message_txtbox;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

