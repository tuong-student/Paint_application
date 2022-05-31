namespace Paint_application
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashStylePicker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.NumericUpDown();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_arc = new System.Windows.Forms.Button();
            this.btn_fill_shape = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.dashStylePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numberBox);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 859);
            this.panel1.TabIndex = 0;
            // 
            // dashStylePicker
            // 
            this.dashStylePicker.FormattingEnabled = true;
            this.dashStylePicker.Items.AddRange(new object[] {
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot",
            "Solid"});
            this.dashStylePicker.Location = new System.Drawing.Point(117, 567);
            this.dashStylePicker.Name = "dashStylePicker";
            this.dashStylePicker.Size = new System.Drawing.Size(79, 28);
            this.dashStylePicker.TabIndex = 15;
            this.dashStylePicker.SelectedValueChanged += new System.EventHandler(this.dashStylePicker_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Line style";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 2;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(117, 603);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 33);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Maroon;
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.FlatAppearance.BorderSize = 2;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Location = new System.Drawing.Point(11, 819);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(181, 33);
            this.btn_about.TabIndex = 12;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Line size";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(117, 523);
            this.numberBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(76, 27);
            this.numberBox.TabIndex = 10;
            this.numberBox.ValueChanged += new System.EventHandler(this.numberBox_ValueChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 2;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(11, 740);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(181, 33);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 2;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(11, 780);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(181, 33);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // color_picker
            // 
            this.color_picker.BackgroundImage = global::Paint_application.Properties.Resources.color_palette;
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::Paint_application.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(3, 12);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(189, 125);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 2;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_color.Location = new System.Drawing.Point(3, 137);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(189, 27);
            this.pic_color.TabIndex = 1;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.btn_color);
            this.panel2.Controls.Add(this.btn_circle);
            this.panel2.Controls.Add(this.btn_arc);
            this.panel2.Controls.Add(this.btn_fill_shape);
            this.panel2.Controls.Add(this.btn_line);
            this.panel2.Controls.Add(this.btn_rectangle);
            this.panel2.Controls.Add(this.btn_ellipse);
            this.panel2.Location = new System.Drawing.Point(3, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 342);
            this.panel2.TabIndex = 2;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.BorderSize = 2;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::Paint_application.Properties.Resources.color;
            this.btn_color.Location = new System.Drawing.Point(6, 197);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(90, 80);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_circle.FlatAppearance.BorderSize = 2;
            this.btn_circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_circle.ForeColor = System.Drawing.Color.White;
            this.btn_circle.Image = global::Paint_application.Properties.Resources.circle;
            this.btn_circle.Location = new System.Drawing.Point(8, 113);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(90, 78);
            this.btn_circle.TabIndex = 10;
            this.btn_circle.Text = "Circle";
            this.btn_circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_arc
            // 
            this.btn_arc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_arc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arc.FlatAppearance.BorderSize = 2;
            this.btn_arc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_arc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_arc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arc.ForeColor = System.Drawing.Color.White;
            this.btn_arc.Image = global::Paint_application.Properties.Resources.line1;
            this.btn_arc.Location = new System.Drawing.Point(8, 29);
            this.btn_arc.Name = "btn_arc";
            this.btn_arc.Size = new System.Drawing.Size(90, 78);
            this.btn_arc.TabIndex = 9;
            this.btn_arc.Text = "Arc";
            this.btn_arc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_arc.UseVisualStyleBackColor = false;
            this.btn_arc.Click += new System.EventHandler(this.btn_arc_Click);
            // 
            // btn_fill_shape
            // 
            this.btn_fill_shape.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_fill_shape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill_shape.FlatAppearance.BorderSize = 2;
            this.btn_fill_shape.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_fill_shape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fill_shape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill_shape.ForeColor = System.Drawing.Color.White;
            this.btn_fill_shape.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fill_shape.Location = new System.Drawing.Point(99, 281);
            this.btn_fill_shape.Name = "btn_fill_shape";
            this.btn_fill_shape.Size = new System.Drawing.Size(90, 28);
            this.btn_fill_shape.TabIndex = 8;
            this.btn_fill_shape.Text = "Fill shape";
            this.btn_fill_shape.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill_shape.UseVisualStyleBackColor = false;
            this.btn_fill_shape.Click += new System.EventHandler(this.btn_fill_shape_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.BorderSize = 2;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::Paint_application.Properties.Resources.line1;
            this.btn_line.Location = new System.Drawing.Point(102, 197);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(90, 78);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rectangle.FlatAppearance.BorderSize = 2;
            this.btn_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rectangle.ForeColor = System.Drawing.Color.White;
            this.btn_rectangle.Image = global::Paint_application.Properties.Resources.rectangle1;
            this.btn_rectangle.Location = new System.Drawing.Point(102, 113);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(90, 78);
            this.btn_rectangle.TabIndex = 6;
            this.btn_rectangle.Text = "Rectangle";
            this.btn_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rectangle.UseVisualStyleBackColor = false;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.BorderSize = 2;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::Paint_application.Properties.Resources.circle;
            this.btn_ellipse.Location = new System.Drawing.Point(102, 29);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(90, 78);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1189, 859);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictrureBox1_MouseWheel);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(215, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1189, 859);
            this.panel3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 859);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Paint_application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberBox;
        private System.Windows.Forms.Button btn_fill_shape;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_arc;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dashStylePicker;
    }
}
