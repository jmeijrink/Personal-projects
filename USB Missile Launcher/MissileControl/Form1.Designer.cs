namespace MissileControl
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
         this.btnLeft = new System.Windows.Forms.Button();
         this.btnRight = new System.Windows.Forms.Button();
         this.btnStop = new System.Windows.Forms.Button();
         this.btnUpLeft = new System.Windows.Forms.Button();
         this.btnDown = new System.Windows.Forms.Button();
         this.btnFire = new System.Windows.Forms.Button();
         this.btnTurnUp = new System.Windows.Forms.Button();
         this.btnUpRight = new System.Windows.Forms.Button();
         this.btnDownRight = new System.Windows.Forms.Button();
         this.btnDownLeft = new System.Windows.Forms.Button();
         this.btnPrime = new System.Windows.Forms.Button();
         this.chkAutomaticPriming = new System.Windows.Forms.CheckBox();
         this.lstDevices = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // btnLeft
         // 
         this.btnLeft.Location = new System.Drawing.Point(12, 113);
         this.btnLeft.Name = "btnLeft";
         this.btnLeft.Size = new System.Drawing.Size(99, 90);
         this.btnLeft.TabIndex = 0;
         this.btnLeft.Text = "<-";
         this.btnLeft.UseVisualStyleBackColor = true;
         this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
         // 
         // btnRight
         // 
         this.btnRight.Location = new System.Drawing.Point(222, 113);
         this.btnRight.Name = "btnRight";
         this.btnRight.Size = new System.Drawing.Size(99, 90);
         this.btnRight.TabIndex = 1;
         this.btnRight.Text = "->";
         this.btnRight.UseVisualStyleBackColor = true;
         this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
         // 
         // btnStop
         // 
         this.btnStop.Location = new System.Drawing.Point(117, 113);
         this.btnStop.Name = "btnStop";
         this.btnStop.Size = new System.Drawing.Size(99, 90);
         this.btnStop.TabIndex = 2;
         this.btnStop.Text = "O";
         this.btnStop.UseVisualStyleBackColor = true;
         this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
         // 
         // btnUpLeft
         // 
         this.btnUpLeft.Location = new System.Drawing.Point(12, 17);
         this.btnUpLeft.Name = "btnUpLeft";
         this.btnUpLeft.Size = new System.Drawing.Size(99, 90);
         this.btnUpLeft.TabIndex = 3;
         this.btnUpLeft.Text = "<^";
         this.btnUpLeft.UseMnemonic = false;
         this.btnUpLeft.UseVisualStyleBackColor = true;
         this.btnUpLeft.Click += new System.EventHandler(this.btnUpLeft_Click);
         // 
         // btnDown
         // 
         this.btnDown.Location = new System.Drawing.Point(117, 209);
         this.btnDown.Name = "btnDown";
         this.btnDown.Size = new System.Drawing.Size(99, 90);
         this.btnDown.TabIndex = 4;
         this.btnDown.Text = "V";
         this.btnDown.UseVisualStyleBackColor = true;
         this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
         // 
         // btnFire
         // 
         this.btnFire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.btnFire.Location = new System.Drawing.Point(327, 46);
         this.btnFire.Name = "btnFire";
         this.btnFire.Size = new System.Drawing.Size(249, 252);
         this.btnFire.TabIndex = 5;
         this.btnFire.Text = "FIRE";
         this.btnFire.UseVisualStyleBackColor = true;
         this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
         // 
         // btnTurnUp
         // 
         this.btnTurnUp.Location = new System.Drawing.Point(117, 17);
         this.btnTurnUp.Name = "btnTurnUp";
         this.btnTurnUp.Size = new System.Drawing.Size(99, 90);
         this.btnTurnUp.TabIndex = 6;
         this.btnTurnUp.Text = "^";
         this.btnTurnUp.UseMnemonic = false;
         this.btnTurnUp.UseVisualStyleBackColor = true;
         this.btnTurnUp.Click += new System.EventHandler(this.btnTurnUp_Click);
         // 
         // btnUpRight
         // 
         this.btnUpRight.Location = new System.Drawing.Point(222, 17);
         this.btnUpRight.Name = "btnUpRight";
         this.btnUpRight.Size = new System.Drawing.Size(99, 90);
         this.btnUpRight.TabIndex = 7;
         this.btnUpRight.Text = "^>";
         this.btnUpRight.UseMnemonic = false;
         this.btnUpRight.UseVisualStyleBackColor = true;
         this.btnUpRight.Click += new System.EventHandler(this.btnUpRight_Click);
         // 
         // btnDownRight
         // 
         this.btnDownRight.Location = new System.Drawing.Point(222, 209);
         this.btnDownRight.Name = "btnDownRight";
         this.btnDownRight.Size = new System.Drawing.Size(99, 90);
         this.btnDownRight.TabIndex = 8;
         this.btnDownRight.Text = "V>";
         this.btnDownRight.UseMnemonic = false;
         this.btnDownRight.UseVisualStyleBackColor = true;
         this.btnDownRight.Click += new System.EventHandler(this.btnDownRight_Click);
         // 
         // btnDownLeft
         // 
         this.btnDownLeft.Location = new System.Drawing.Point(12, 209);
         this.btnDownLeft.Name = "btnDownLeft";
         this.btnDownLeft.Size = new System.Drawing.Size(99, 90);
         this.btnDownLeft.TabIndex = 9;
         this.btnDownLeft.Text = "<V";
         this.btnDownLeft.UseMnemonic = false;
         this.btnDownLeft.UseVisualStyleBackColor = true;
         this.btnDownLeft.Click += new System.EventHandler(this.btnDownLeft_Click);
         // 
         // btnPrime
         // 
         this.btnPrime.Location = new System.Drawing.Point(327, 17);
         this.btnPrime.Name = "btnPrime";
         this.btnPrime.Size = new System.Drawing.Size(75, 23);
         this.btnPrime.TabIndex = 10;
         this.btnPrime.Text = "Prime";
         this.btnPrime.UseVisualStyleBackColor = true;
         this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
         // 
         // chkAutomaticPriming
         // 
         this.chkAutomaticPriming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.chkAutomaticPriming.Location = new System.Drawing.Point(463, 17);
         this.chkAutomaticPriming.Name = "chkAutomaticPriming";
         this.chkAutomaticPriming.Size = new System.Drawing.Size(110, 24);
         this.chkAutomaticPriming.TabIndex = 11;
         this.chkAutomaticPriming.Text = "Automatic priming";
         this.chkAutomaticPriming.UseVisualStyleBackColor = true;
         // 
         // lstDevices
         // 
         this.lstDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.lstDevices.FormattingEnabled = true;
         this.lstDevices.Location = new System.Drawing.Point(12, 306);
         this.lstDevices.Name = "lstDevices";
         this.lstDevices.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
         this.lstDevices.Size = new System.Drawing.Size(563, 69);
         this.lstDevices.TabIndex = 12;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(585, 383);
         this.Controls.Add(this.lstDevices);
         this.Controls.Add(this.chkAutomaticPriming);
         this.Controls.Add(this.btnPrime);
         this.Controls.Add(this.btnDownLeft);
         this.Controls.Add(this.btnDownRight);
         this.Controls.Add(this.btnUpRight);
         this.Controls.Add(this.btnTurnUp);
         this.Controls.Add(this.btnFire);
         this.Controls.Add(this.btnDown);
         this.Controls.Add(this.btnUpLeft);
         this.Controls.Add(this.btnStop);
         this.Controls.Add(this.btnRight);
         this.Controls.Add(this.btnLeft);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnLeft;
      private System.Windows.Forms.Button btnRight;
      private System.Windows.Forms.Button btnStop;
      private System.Windows.Forms.Button btnUpLeft;
      private System.Windows.Forms.Button btnDown;
      private System.Windows.Forms.Button btnFire;
      private System.Windows.Forms.Button btnTurnUp;
      private System.Windows.Forms.Button btnUpRight;
      private System.Windows.Forms.Button btnDownRight;
      private System.Windows.Forms.Button btnDownLeft;
      private System.Windows.Forms.Button btnPrime;
      private System.Windows.Forms.CheckBox chkAutomaticPriming;
      private System.Windows.Forms.ListBox lstDevices;
   }
}

