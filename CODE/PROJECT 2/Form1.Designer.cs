namespace Shape_Maker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.shape_combobox = new System.Windows.Forms.ComboBox();
            this.is_fill = new System.Windows.Forms.RadioButton();
            this.is_outline = new System.Windows.Forms.RadioButton();
            this.fill_box = new System.Windows.Forms.GroupBox();
            this.details_box = new System.Windows.Forms.GroupBox();
            this.date_check = new System.Windows.Forms.CheckBox();
            this.name_check = new System.Windows.Forms.CheckBox();
            this.draw_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.show_label = new System.Windows.Forms.Label();
            this.shape_box = new System.Windows.Forms.GroupBox();
            this.fill_box.SuspendLayout();
            this.details_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a shape";
            // 
            // shape_combobox
            // 
            this.shape_combobox.FormattingEnabled = true;
            this.shape_combobox.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle",
            "Pentagon",
            "Hexagon"});
            this.shape_combobox.Location = new System.Drawing.Point(51, 94);
            this.shape_combobox.Name = "shape_combobox";
            this.shape_combobox.Size = new System.Drawing.Size(121, 23);
            this.shape_combobox.TabIndex = 1;
            this.shape_combobox.Text = "Circle";
            // 
            // is_fill
            // 
            this.is_fill.AutoSize = true;
            this.is_fill.Location = new System.Drawing.Point(6, 22);
            this.is_fill.Name = "is_fill";
            this.is_fill.Size = new System.Drawing.Size(40, 19);
            this.is_fill.TabIndex = 2;
            this.is_fill.Text = "Fill";
            this.is_fill.UseVisualStyleBackColor = true;
            // 
            // is_outline
            // 
            this.is_outline.AutoSize = true;
            this.is_outline.Checked = true;
            this.is_outline.Location = new System.Drawing.Point(6, 47);
            this.is_outline.Name = "is_outline";
            this.is_outline.Size = new System.Drawing.Size(64, 19);
            this.is_outline.TabIndex = 3;
            this.is_outline.TabStop = true;
            this.is_outline.Text = "Outline";
            this.is_outline.UseVisualStyleBackColor = true;
            // 
            // fill_box
            // 
            this.fill_box.Controls.Add(this.is_fill);
            this.fill_box.Controls.Add(this.is_outline);
            this.fill_box.Location = new System.Drawing.Point(51, 204);
            this.fill_box.Name = "fill_box";
            this.fill_box.Size = new System.Drawing.Size(141, 74);
            this.fill_box.TabIndex = 4;
            this.fill_box.TabStop = false;
            this.fill_box.Text = "Select fill mode";
            // 
            // details_box
            // 
            this.details_box.Controls.Add(this.date_check);
            this.details_box.Controls.Add(this.name_check);
            this.details_box.Location = new System.Drawing.Point(51, 297);
            this.details_box.Name = "details_box";
            this.details_box.Size = new System.Drawing.Size(141, 74);
            this.details_box.TabIndex = 4;
            this.details_box.TabStop = false;
            this.details_box.Text = "Select details";
            // 
            // date_check
            // 
            this.date_check.AutoSize = true;
            this.date_check.Checked = true;
            this.date_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.date_check.Location = new System.Drawing.Point(7, 49);
            this.date_check.Name = "date_check";
            this.date_check.Size = new System.Drawing.Size(50, 19);
            this.date_check.TabIndex = 1;
            this.date_check.Text = "Date";
            this.date_check.UseVisualStyleBackColor = true;
            // 
            // name_check
            // 
            this.name_check.AutoSize = true;
            this.name_check.Checked = true;
            this.name_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.name_check.Location = new System.Drawing.Point(7, 23);
            this.name_check.Name = "name_check";
            this.name_check.Size = new System.Drawing.Size(58, 19);
            this.name_check.TabIndex = 0;
            this.name_check.Text = "Name";
            this.name_check.UseVisualStyleBackColor = true;
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(263, 341);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(75, 23);
            this.draw_button.TabIndex = 5;
            this.draw_button.Text = "Draw";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(393, 341);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // show_label
            // 
            this.show_label.AutoSize = true;
            this.show_label.Location = new System.Drawing.Point(343, 272);
            this.show_label.Name = "show_label";
            this.show_label.Size = new System.Drawing.Size(0, 15);
            this.show_label.TabIndex = 7;
            // 
            // shape_box
            // 
            this.shape_box.Location = new System.Drawing.Point(263, 56);
            this.shape_box.Name = "shape_box";
            this.shape_box.Size = new System.Drawing.Size(200, 180);
            this.shape_box.TabIndex = 8;
            this.shape_box.TabStop = false;
            this.shape_box.Text = "Shape";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 408);
            this.Controls.Add(this.shape_box);
            this.Controls.Add(this.show_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.details_box);
            this.Controls.Add(this.fill_box);
            this.Controls.Add(this.shape_combobox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shape Maker";
            this.fill_box.ResumeLayout(false);
            this.fill_box.PerformLayout();
            this.details_box.ResumeLayout(false);
            this.details_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox shape_combobox;
        private System.Windows.Forms.RadioButton is_fill;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox fill_box;
        private System.Windows.Forms.GroupBox details_box;
        private System.Windows.Forms.CheckBox date_check;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label show_label;
        private System.Windows.Forms.GroupBox shape_box;
        private System.Windows.Forms.CheckBox name_check;
        private System.Windows.Forms.RadioButton is_outline;
    }
}

