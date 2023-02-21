
namespace Lottosorsolas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.szamokpanel = new System.Windows.Forms.Panel();
            this.sorsolasbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_nyeroszamok = new System.Windows.Forms.Label();
            this.label_megjatszott = new System.Windows.Forms.Label();
            this.label_talalat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szamokpanel
            // 
            this.szamokpanel.Location = new System.Drawing.Point(30, 23);
            this.szamokpanel.Name = "szamokpanel";
            this.szamokpanel.Size = new System.Drawing.Size(732, 278);
            this.szamokpanel.TabIndex = 0;
            // 
            // sorsolasbutton
            // 
            this.sorsolasbutton.Image = global::Lottosorsolas.Properties.Resources.shamrock_lucky_icon;
            this.sorsolasbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sorsolasbutton.Location = new System.Drawing.Point(189, 352);
            this.sorsolasbutton.Name = "sorsolasbutton";
            this.sorsolasbutton.Size = new System.Drawing.Size(83, 37);
            this.sorsolasbutton.TabIndex = 1;
            this.sorsolasbutton.Text = "Sorsolás";
            this.sorsolasbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sorsolasbutton.UseVisualStyleBackColor = true;
            this.sorsolasbutton.Click += new System.EventHandler(this.sorsolasbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(345, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nyerőszámok ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(345, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Megjátszott ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(345, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Találat ->";
            // 
            // label_nyeroszamok
            // 
            this.label_nyeroszamok.AutoSize = true;
            this.label_nyeroszamok.Location = new System.Drawing.Point(456, 324);
            this.label_nyeroszamok.Name = "label_nyeroszamok";
            this.label_nyeroszamok.Size = new System.Drawing.Size(0, 13);
            this.label_nyeroszamok.TabIndex = 5;
            this.label_nyeroszamok.Click += new System.EventHandler(this.label_nyeroszamok_Click);
            // 
            // label_megjatszott
            // 
            this.label_megjatszott.AutoSize = true;
            this.label_megjatszott.Location = new System.Drawing.Point(442, 364);
            this.label_megjatszott.Name = "label_megjatszott";
            this.label_megjatszott.Size = new System.Drawing.Size(0, 13);
            this.label_megjatszott.TabIndex = 6;
            this.label_megjatszott.Click += new System.EventHandler(this.label_megjatszott_Click);
            // 
            // label_talalat
            // 
            this.label_talalat.AutoSize = true;
            this.label_talalat.Location = new System.Drawing.Point(427, 403);
            this.label_talalat.Name = "label_talalat";
            this.label_talalat.Size = new System.Drawing.Size(0, 13);
            this.label_talalat.TabIndex = 7;
            this.label_talalat.Click += new System.EventHandler(this.label_talalat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_talalat);
            this.Controls.Add(this.label_megjatszott);
            this.Controls.Add(this.label_nyeroszamok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sorsolasbutton);
            this.Controls.Add(this.szamokpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lottósorsolás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel szamokpanel;
        private System.Windows.Forms.Button sorsolasbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_nyeroszamok;
        private System.Windows.Forms.Label label_megjatszott;
        private System.Windows.Forms.Label label_talalat;
    }
}

