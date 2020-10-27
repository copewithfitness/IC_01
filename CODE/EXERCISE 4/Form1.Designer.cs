namespace Seconds_Convertor
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
            this.label1 = new System.Windows.Forms.Label();
            this.seconds_box = new System.Windows.Forms.TextBox();
            this.convert_button = new System.Windows.Forms.Button();
            this.answer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Seconds Elapsed";
            // 
            // seconds_box
            // 
            this.seconds_box.Location = new System.Drawing.Point(129, 44);
            this.seconds_box.Name = "seconds_box";
            this.seconds_box.Size = new System.Drawing.Size(101, 20);
            this.seconds_box.TabIndex = 1;
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(129, 232);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(101, 39);
            this.convert_button.TabIndex = 2;
            this.convert_button.Text = "Convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // answer_label
            // 
            this.answer_label.AutoSize = true;
            this.answer_label.Location = new System.Drawing.Point(163, 114);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(0, 13);
            this.answer_label.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 289);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.seconds_box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Seconds Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seconds_box;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Label answer_label;
    }
}

