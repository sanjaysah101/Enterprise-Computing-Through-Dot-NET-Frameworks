
namespace EventApp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonShort = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(108, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 0;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(476, 82);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(114, 40);
            this.buttonFill.TabIndex = 1;
            this.buttonFill.Text = "Fill";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonShort
            // 
            this.buttonShort.Location = new System.Drawing.Point(481, 158);
            this.buttonShort.Name = "buttonShort";
            this.buttonShort.Size = new System.Drawing.Size(109, 40);
            this.buttonShort.TabIndex = 2;
            this.buttonShort.Text = "Short";
            this.buttonShort.UseVisualStyleBackColor = true;
            this.buttonShort.Click += new System.EventHandler(this.buttonShort_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(481, 228);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(109, 37);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(108, 273);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(116, 33);
            this.buttonCount.TabIndex = 4;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(466, 297);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(153, 40);
            this.buttonRemoveItem.TabIndex = 5;
            this.buttonRemoveItem.Text = "Remove Item";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Location = new System.Drawing.Point(108, 357);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(10, 16);
            this.labelTotalItem.TabIndex = 6;
            this.labelTotalItem.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalItem);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonShort);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonShort;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Label labelTotalItem;
    }
}

