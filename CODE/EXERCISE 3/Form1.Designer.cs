namespace Calculator
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.weight_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.weight_box = new System.Windows.Forms.TextBox();
            this.result_box = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Location = new System.Drawing.Point(50, 68);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(147, 15);
            this.weight_label.TabIndex = 0;
            this.weight_label.Text = "Enter your weight on Earth";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(68, 188);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(116, 15);
            this.result_label.TabIndex = 1;
            this.result_label.Text = "Your weight on Mars";
            // 
            // weight_box
            // 
            this.weight_box.Location = new System.Drawing.Point(287, 68);
            this.weight_box.Name = "weight_box";
            this.weight_box.Size = new System.Drawing.Size(100, 23);
            this.weight_box.TabIndex = 2;
            // 
            // result_box
            // 
            this.result_box.Enabled = false;
            this.result_box.Location = new System.Drawing.Point(287, 185);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(100, 23);
            this.result_box.TabIndex = 3;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(174, 282);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(81, 19);
            this.checkBox.TabIndex = 4;
            this.checkBox.Text = "Round Off";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(174, 316);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 5;
            this.calculate_button.Text = "Convert";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 366);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.weight_box);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.weight_label);
            this.Name = "Form";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox weight_box;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button calculate_button;
    }
}

