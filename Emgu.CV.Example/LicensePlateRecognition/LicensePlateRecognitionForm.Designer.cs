namespace LicensePlateRecognition
{
   partial class LicensePlateRecognitionForm
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
         this.components = new System.ComponentModel.Container();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.imageBox1 = new Emgu.CV.UI.ImageBox();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.panel1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.imageBox1);
         this.splitContainer1.Panel2.Controls.Add(this.panel2);
         this.splitContainer1.Size = new System.Drawing.Size(786, 380);
         this.splitContainer1.SplitterDistance = 215;
         this.splitContainer1.TabIndex = 0;
         // 
         // panel1
         // 
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(215, 380);
         this.panel1.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.textBox1);
         this.panel2.Controls.Add(this.button1);
         this.panel2.Controls.Add(this.label1);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(567, 53);
         this.panel2.TabIndex = 3;
         // 
         // imageBox1
         // 
         this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.imageBox1.Location = new System.Drawing.Point(0, 53);
         this.imageBox1.Name = "imageBox1";
         this.imageBox1.Size = new System.Drawing.Size(567, 327);
         this.imageBox1.TabIndex = 4;
         this.imageBox1.TabStop = false;
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(27, 24);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(26, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "File:";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(439, 19);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "Load Image";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(73, 21);
         this.textBox1.Name = "textBox1";
         this.textBox1.ReadOnly = true;
         this.textBox1.Size = new System.Drawing.Size(360, 20);
         this.textBox1.TabIndex = 2;
         // 
         // LicensePlateRecognitionForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(786, 380);
         this.Controls.Add(this.splitContainer1);
         this.Name = "LicensePlateRecognitionForm";
         this.Text = "License Plate Recognition";
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Panel panel1;
      private Emgu.CV.UI.ImageBox imageBox1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.TextBox textBox1;
   }
}