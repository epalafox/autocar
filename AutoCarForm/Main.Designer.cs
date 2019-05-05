namespace AutoCarForm
{
    partial class Main
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
            this.lstAutos = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAutos
            // 
            this.lstAutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstAutos.LabelEdit = true;
            this.lstAutos.Location = new System.Drawing.Point(12, 12);
            this.lstAutos.Name = "lstAutos";
            this.lstAutos.Size = new System.Drawing.Size(429, 329);
            this.lstAutos.TabIndex = 0;
            this.lstAutos.UseCompatibleStateImageBehavior = false;
            this.lstAutos.View = System.Windows.Forms.View.List;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(44, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 422);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAutos);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstAutos;
        private System.Windows.Forms.Button btnAdd;
    }
}

