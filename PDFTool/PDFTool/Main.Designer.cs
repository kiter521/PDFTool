namespace PDFTool
{
    partial class PDFTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFTool));
            this.gb_split = new System.Windows.Forms.GroupBox();
            this.btn_split = new System.Windows.Forms.Button();
            this.txt_spec_range_one_end = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_spec_range_one_start = new System.Windows.Forms.TextBox();
            this.chk_spec_range_pdf = new System.Windows.Forms.CheckBox();
            this.txt_spec_range_end = new System.Windows.Forms.TextBox();
            this.lab_end = new System.Windows.Forms.Label();
            this.lab_start = new System.Windows.Forms.Label();
            this.txt_spec_range_start = new System.Windows.Forms.TextBox();
            this.txt_spec_one = new System.Windows.Forms.TextBox();
            this.chk_spec_range = new System.Windows.Forms.CheckBox();
            this.chk_spec = new System.Windows.Forms.CheckBox();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.file_name = new System.Windows.Forms.TextBox();
            this.gb_merge = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_merge_page = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_file_merge_spec = new System.Windows.Forms.Button();
            this.btn_file_merge = new System.Windows.Forms.Button();
            this.list_files = new System.Windows.Forms.ListBox();
            this.btn_merge = new System.Windows.Forms.Button();
            this.chk_spec_merge = new System.Windows.Forms.CheckBox();
            this.txt_spec_merge = new System.Windows.Forms.TextBox();
            this.chk_merge_spec = new System.Windows.Forms.CheckBox();
            this.gb_split.SuspendLayout();
            this.gb_merge.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_split
            // 
            this.gb_split.Controls.Add(this.btn_split);
            this.gb_split.Controls.Add(this.txt_spec_range_one_end);
            this.gb_split.Controls.Add(this.label1);
            this.gb_split.Controls.Add(this.label2);
            this.gb_split.Controls.Add(this.txt_spec_range_one_start);
            this.gb_split.Controls.Add(this.chk_spec_range_pdf);
            this.gb_split.Controls.Add(this.txt_spec_range_end);
            this.gb_split.Controls.Add(this.lab_end);
            this.gb_split.Controls.Add(this.lab_start);
            this.gb_split.Controls.Add(this.txt_spec_range_start);
            this.gb_split.Controls.Add(this.txt_spec_one);
            this.gb_split.Controls.Add(this.chk_spec_range);
            this.gb_split.Controls.Add(this.chk_spec);
            this.gb_split.Controls.Add(this.chk_all);
            this.gb_split.Controls.Add(this.btn_file);
            this.gb_split.Controls.Add(this.file_name);
            resources.ApplyResources(this.gb_split, "gb_split");
            this.gb_split.Name = "gb_split";
            this.gb_split.TabStop = false;
            // 
            // btn_split
            // 
            resources.ApplyResources(this.btn_split, "btn_split");
            this.btn_split.Name = "btn_split";
            this.btn_split.UseVisualStyleBackColor = true;
            this.btn_split.Click += new System.EventHandler(this.btn_split_Click);
            // 
            // txt_spec_range_one_end
            // 
            resources.ApplyResources(this.txt_spec_range_one_end, "txt_spec_range_one_end");
            this.txt_spec_range_one_end.Name = "txt_spec_range_one_end";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txt_spec_range_one_start
            // 
            resources.ApplyResources(this.txt_spec_range_one_start, "txt_spec_range_one_start");
            this.txt_spec_range_one_start.Name = "txt_spec_range_one_start";
            // 
            // chk_spec_range_pdf
            // 
            resources.ApplyResources(this.chk_spec_range_pdf, "chk_spec_range_pdf");
            this.chk_spec_range_pdf.Name = "chk_spec_range_pdf";
            this.chk_spec_range_pdf.UseVisualStyleBackColor = true;
            this.chk_spec_range_pdf.CheckedChanged += new System.EventHandler(this.chk_spec_range_pdf_CheckedChanged);
            // 
            // txt_spec_range_end
            // 
            resources.ApplyResources(this.txt_spec_range_end, "txt_spec_range_end");
            this.txt_spec_range_end.Name = "txt_spec_range_end";
            // 
            // lab_end
            // 
            resources.ApplyResources(this.lab_end, "lab_end");
            this.lab_end.Name = "lab_end";
            // 
            // lab_start
            // 
            resources.ApplyResources(this.lab_start, "lab_start");
            this.lab_start.Name = "lab_start";
            // 
            // txt_spec_range_start
            // 
            resources.ApplyResources(this.txt_spec_range_start, "txt_spec_range_start");
            this.txt_spec_range_start.Name = "txt_spec_range_start";
            // 
            // txt_spec_one
            // 
            resources.ApplyResources(this.txt_spec_one, "txt_spec_one");
            this.txt_spec_one.Name = "txt_spec_one";
            // 
            // chk_spec_range
            // 
            resources.ApplyResources(this.chk_spec_range, "chk_spec_range");
            this.chk_spec_range.Name = "chk_spec_range";
            this.chk_spec_range.UseVisualStyleBackColor = true;
            this.chk_spec_range.CheckedChanged += new System.EventHandler(this.chk_spec_range_CheckedChanged);
            // 
            // chk_spec
            // 
            resources.ApplyResources(this.chk_spec, "chk_spec");
            this.chk_spec.Name = "chk_spec";
            this.chk_spec.UseVisualStyleBackColor = true;
            this.chk_spec.CheckedChanged += new System.EventHandler(this.chk_spec_CheckedChanged);
            // 
            // chk_all
            // 
            resources.ApplyResources(this.chk_all, "chk_all");
            this.chk_all.Name = "chk_all";
            this.chk_all.UseVisualStyleBackColor = true;
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // btn_file
            // 
            resources.ApplyResources(this.btn_file, "btn_file");
            this.btn_file.Name = "btn_file";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // file_name
            // 
            resources.ApplyResources(this.file_name, "file_name");
            this.file_name.Name = "file_name";
            // 
            // gb_merge
            // 
            this.gb_merge.Controls.Add(this.label3);
            this.gb_merge.Controls.Add(this.txt_merge_page);
            this.gb_merge.Controls.Add(this.btn_clear);
            this.gb_merge.Controls.Add(this.btn_delete);
            this.gb_merge.Controls.Add(this.btn_file_merge_spec);
            this.gb_merge.Controls.Add(this.btn_file_merge);
            this.gb_merge.Controls.Add(this.list_files);
            this.gb_merge.Controls.Add(this.btn_merge);
            this.gb_merge.Controls.Add(this.chk_spec_merge);
            this.gb_merge.Controls.Add(this.txt_spec_merge);
            this.gb_merge.Controls.Add(this.chk_merge_spec);
            resources.ApplyResources(this.gb_merge, "gb_merge");
            this.gb_merge.Name = "gb_merge";
            this.gb_merge.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_merge_page
            // 
            resources.ApplyResources(this.txt_merge_page, "txt_merge_page");
            this.txt_merge_page.Name = "txt_merge_page";
            // 
            // btn_clear
            // 
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_file_merge_spec
            // 
            resources.ApplyResources(this.btn_file_merge_spec, "btn_file_merge_spec");
            this.btn_file_merge_spec.Name = "btn_file_merge_spec";
            this.btn_file_merge_spec.UseVisualStyleBackColor = true;
            this.btn_file_merge_spec.Click += new System.EventHandler(this.btn_file_merge_spec_Click);
            // 
            // btn_file_merge
            // 
            resources.ApplyResources(this.btn_file_merge, "btn_file_merge");
            this.btn_file_merge.Name = "btn_file_merge";
            this.btn_file_merge.UseVisualStyleBackColor = true;
            this.btn_file_merge.Click += new System.EventHandler(this.btn_file_merge_Click);
            // 
            // list_files
            // 
            this.list_files.FormattingEnabled = true;
            resources.ApplyResources(this.list_files, "list_files");
            this.list_files.Name = "list_files";
            // 
            // btn_merge
            // 
            resources.ApplyResources(this.btn_merge, "btn_merge");
            this.btn_merge.Name = "btn_merge";
            this.btn_merge.UseVisualStyleBackColor = true;
            this.btn_merge.Click += new System.EventHandler(this.btn_merge_Click);
            // 
            // chk_spec_merge
            // 
            resources.ApplyResources(this.chk_spec_merge, "chk_spec_merge");
            this.chk_spec_merge.Name = "chk_spec_merge";
            this.chk_spec_merge.UseVisualStyleBackColor = true;
            this.chk_spec_merge.CheckedChanged += new System.EventHandler(this.chk_spec_merge_CheckedChanged);
            // 
            // txt_spec_merge
            // 
            resources.ApplyResources(this.txt_spec_merge, "txt_spec_merge");
            this.txt_spec_merge.Name = "txt_spec_merge";
            // 
            // chk_merge_spec
            // 
            resources.ApplyResources(this.chk_merge_spec, "chk_merge_spec");
            this.chk_merge_spec.Name = "chk_merge_spec";
            this.chk_merge_spec.UseVisualStyleBackColor = true;
            this.chk_merge_spec.CheckedChanged += new System.EventHandler(this.chk_merge_spec_CheckedChanged);
            // 
            // PDFTool
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_merge);
            this.Controls.Add(this.gb_split);
            this.MaximizeBox = false;
            this.Name = "PDFTool";
            this.gb_split.ResumeLayout(false);
            this.gb_split.PerformLayout();
            this.gb_merge.ResumeLayout(false);
            this.gb_merge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_split;
        private System.Windows.Forms.Button btn_split;
        private System.Windows.Forms.TextBox txt_spec_range_one_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_spec_range_one_start;
        private System.Windows.Forms.CheckBox chk_spec_range_pdf;
        private System.Windows.Forms.TextBox txt_spec_range_end;
        private System.Windows.Forms.Label lab_end;
        private System.Windows.Forms.Label lab_start;
        private System.Windows.Forms.TextBox txt_spec_range_start;
        private System.Windows.Forms.TextBox txt_spec_one;
        private System.Windows.Forms.CheckBox chk_spec_range;
        private System.Windows.Forms.CheckBox chk_spec;
        private System.Windows.Forms.CheckBox chk_all;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.GroupBox gb_merge;
        private System.Windows.Forms.Button btn_file_merge_spec;
        private System.Windows.Forms.Button btn_file_merge;
        private System.Windows.Forms.ListBox list_files;
        private System.Windows.Forms.Button btn_merge;
        private System.Windows.Forms.CheckBox chk_spec_merge;
        private System.Windows.Forms.TextBox txt_spec_merge;
        private System.Windows.Forms.CheckBox chk_merge_spec;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_merge_page;
    }
}

