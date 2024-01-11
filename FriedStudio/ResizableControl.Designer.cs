
namespace ScuffedScri
{
    partial class ResizableControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Size = new System.Drawing.Size(135, 133);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.ResizableControl_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizableControl_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizableControl_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizableControl_MouseUp);
            // 
            // ResizableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "ResizableControl";
            this.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Size = new System.Drawing.Size(155, 155);
            this.Load += new System.EventHandler(this.ResizableControl_Load);
            this.Click += new System.EventHandler(this.ResizableControl_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ResizableControl_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizableControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizableControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizableControl_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
    }
}
