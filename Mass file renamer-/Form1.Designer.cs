namespace Mass_file_renamer_
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
            this.SeasonNumer = new System.Windows.Forms.TextBox();
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.PathPreview = new System.Windows.Forms.TextBox();
            this.ChangeFiles = new System.Windows.Forms.Button();
            this.GetPath = new System.Windows.Forms.Button();
            this.EpisodeInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Episode = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeasonNumer
            // 
            this.SeasonNumer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonNumer.Location = new System.Drawing.Point(87, 12);
            this.SeasonNumer.Name = "SeasonNumer";
            this.SeasonNumer.Size = new System.Drawing.Size(879, 31);
            this.SeasonNumer.TabIndex = 0;
            this.SeasonNumer.Text = "1";
            // 
            // OutputWindow
            // 
            this.OutputWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputWindow.Location = new System.Drawing.Point(12, 522);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(1290, 277);
            this.OutputWindow.TabIndex = 1;
            this.OutputWindow.Text = "";
            // 
            // PathPreview
            // 
            this.PathPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathPreview.Enabled = false;
            this.PathPreview.Location = new System.Drawing.Point(87, 62);
            this.PathPreview.Name = "PathPreview";
            this.PathPreview.Size = new System.Drawing.Size(879, 31);
            this.PathPreview.TabIndex = 2;
            // 
            // ChangeFiles
            // 
            this.ChangeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeFiles.Enabled = false;
            this.ChangeFiles.Location = new System.Drawing.Point(1145, 12);
            this.ChangeFiles.Name = "ChangeFiles";
            this.ChangeFiles.Size = new System.Drawing.Size(157, 81);
            this.ChangeFiles.TabIndex = 3;
            this.ChangeFiles.Text = "Change filenames";
            this.ChangeFiles.UseVisualStyleBackColor = true;
            this.ChangeFiles.Click += new System.EventHandler(this.ChangeFiles_Click);
            // 
            // GetPath
            // 
            this.GetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetPath.Location = new System.Drawing.Point(982, 12);
            this.GetPath.Name = "GetPath";
            this.GetPath.Size = new System.Drawing.Size(157, 81);
            this.GetPath.TabIndex = 4;
            this.GetPath.Text = "GetPath";
            this.GetPath.UseVisualStyleBackColor = true;
            this.GetPath.Click += new System.EventHandler(this.GetPath_Click);
            // 
            // EpisodeInput
            // 
            this.EpisodeInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EpisodeInput.Location = new System.Drawing.Point(12, 132);
            this.EpisodeInput.Name = "EpisodeInput";
            this.EpisodeInput.Size = new System.Drawing.Size(1290, 349);
            this.EpisodeInput.TabIndex = 5;
            this.EpisodeInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Season";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path";
            // 
            // Episode
            // 
            this.Episode.AutoSize = true;
            this.Episode.Location = new System.Drawing.Point(12, 104);
            this.Episode.Name = "Episode";
            this.Episode.Size = new System.Drawing.Size(123, 25);
            this.Episode.TabIndex = 8;
            this.Episode.Text = "New Episodes";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 494);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(69, 25);
            this.OutputLabel.TabIndex = 9;
            this.OutputLabel.Text = "Output";
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoadingLabel.Location = new System.Drawing.Point(591, 104);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(95, 25);
            this.LoadingLabel.TabIndex = 10;
            this.LoadingLabel.Text = "Loading...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 811);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Episode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EpisodeInput);
            this.Controls.Add(this.GetPath);
            this.Controls.Add(this.ChangeFiles);
            this.Controls.Add(this.PathPreview);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.SeasonNumer);
            this.Name = "Form1";
            this.Text = "File renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SeasonNumer;
        private RichTextBox OutputWindow;
        private TextBox PathPreview;
        private Button ChangeFiles;
        private Button GetPath;
        private RichTextBox EpisodeInput;
        private Label label1;
        private Label label2;
        private Label Episode;
        private Label OutputLabel;
        private Label LoadingLabel;
    }
}