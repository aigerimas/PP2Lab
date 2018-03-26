namespace Calc1
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
			this.Devision = new System.Windows.Forms.Button();
			this.Multiply = new System.Windows.Forms.Button();
			this.Minus = new System.Windows.Forms.Button();
			this.Plus = new System.Windows.Forms.Button();
			this.Equal = new System.Windows.Forms.Button();
			this.Percent = new System.Windows.Forms.Button();
			this.Zero = new System.Windows.Forms.Button();
			this.PlusORMinus = new System.Windows.Forms.Button();
			this.Cos = new System.Windows.Forms.Button();
			this.Tan = new System.Windows.Forms.Button();
			this.TenPow = new System.Windows.Forms.Button();
			this.Sin = new System.Windows.Forms.Button();
			this.Mod = new System.Windows.Forms.Button();
			this.MS = new System.Windows.Forms.Button();
			this.Clear = new System.Windows.Forms.Button();
			this.Sqr = new System.Windows.Forms.Button();
			this.MR = new System.Windows.Forms.Button();
			this.MC = new System.Windows.Forms.Button();
			this.Log = new System.Windows.Forms.Button();
			this.MPlass = new System.Windows.Forms.Button();
			this.Sqrt = new System.Windows.Forms.Button();
			this.Backspace = new System.Windows.Forms.Button();
			this.Dot = new System.Windows.Forms.Button();
			this.MMinus = new System.Windows.Forms.Button();
			this.EPow = new System.Windows.Forms.Button();
			this.Qcube = new System.Windows.Forms.Button();
			this.XPowOneoverY = new System.Windows.Forms.Button();
			this.Factorial = new System.Windows.Forms.Button();
			this.Pow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Devision
			// 
			this.Devision.BackColor = System.Drawing.Color.Fuchsia;
			this.Devision.Location = new System.Drawing.Point(273, 240);
			this.Devision.Name = "Devision";
			this.Devision.Size = new System.Drawing.Size(50, 50);
			this.Devision.TabIndex = 0;
			this.Devision.Text = "÷";
			this.Devision.UseVisualStyleBackColor = false;
			this.Devision.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Multiply
			// 
			this.Multiply.BackColor = System.Drawing.Color.Fuchsia;
			this.Multiply.Location = new System.Drawing.Point(273, 300);
			this.Multiply.Name = "Multiply";
			this.Multiply.Size = new System.Drawing.Size(50, 50);
			this.Multiply.TabIndex = 1;
			this.Multiply.Text = "*";
			this.Multiply.UseVisualStyleBackColor = false;
			this.Multiply.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Minus
			// 
			this.Minus.BackColor = System.Drawing.Color.Fuchsia;
			this.Minus.Location = new System.Drawing.Point(273, 360);
			this.Minus.Name = "Minus";
			this.Minus.Size = new System.Drawing.Size(50, 50);
			this.Minus.TabIndex = 2;
			this.Minus.Text = "-";
			this.Minus.UseVisualStyleBackColor = false;
			this.Minus.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Plus
			// 
			this.Plus.BackColor = System.Drawing.Color.Fuchsia;
			this.Plus.Location = new System.Drawing.Point(273, 420);
			this.Plus.Name = "Plus";
			this.Plus.Size = new System.Drawing.Size(50, 110);
			this.Plus.TabIndex = 3;
			this.Plus.Text = "+";
			this.Plus.UseVisualStyleBackColor = false;
			this.Plus.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Equal
			// 
			this.Equal.BackColor = System.Drawing.Color.Pink;
			this.Equal.Location = new System.Drawing.Point(213, 480);
			this.Equal.Name = "Equal";
			this.Equal.Size = new System.Drawing.Size(50, 50);
			this.Equal.TabIndex = 4;
			this.Equal.Text = "=";
			this.Equal.UseVisualStyleBackColor = false;
			this.Equal.Click += new System.EventHandler(this.result_Operation);
			// 
			// Percent
			// 
			this.Percent.BackColor = System.Drawing.Color.Fuchsia;
			this.Percent.Location = new System.Drawing.Point(33, 300);
			this.Percent.Name = "Percent";
			this.Percent.Size = new System.Drawing.Size(50, 50);
			this.Percent.TabIndex = 5;
			this.Percent.Text = "%";
			this.Percent.UseVisualStyleBackColor = false;
			this.Percent.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Zero
			// 
			this.Zero.BackColor = System.Drawing.Color.Pink;
			this.Zero.Location = new System.Drawing.Point(93, 480);
			this.Zero.Name = "Zero";
			this.Zero.Size = new System.Drawing.Size(110, 50);
			this.Zero.TabIndex = 6;
			this.Zero.Text = "0";
			this.Zero.UseVisualStyleBackColor = false;
			this.Zero.Click += new System.EventHandler(this.Numbers_Click);
			// 
			// PlusORMinus
			// 
			this.PlusORMinus.BackColor = System.Drawing.Color.Fuchsia;
			this.PlusORMinus.Location = new System.Drawing.Point(33, 420);
			this.PlusORMinus.Name = "PlusORMinus";
			this.PlusORMinus.Size = new System.Drawing.Size(50, 50);
			this.PlusORMinus.TabIndex = 7;
			this.PlusORMinus.Text = "+/-";
			this.PlusORMinus.UseVisualStyleBackColor = false;
			this.PlusORMinus.Click += new System.EventHandler(this.znak_change);
			// 
			// Cos
			// 
			this.Cos.BackColor = System.Drawing.Color.Fuchsia;
			this.Cos.Location = new System.Drawing.Point(213, 120);
			this.Cos.Name = "Cos";
			this.Cos.Size = new System.Drawing.Size(50, 50);
			this.Cos.TabIndex = 8;
			this.Cos.Text = "cos";
			this.Cos.UseVisualStyleBackColor = false;
			this.Cos.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Tan
			// 
			this.Tan.BackColor = System.Drawing.Color.Fuchsia;
			this.Tan.Location = new System.Drawing.Point(273, 120);
			this.Tan.Name = "Tan";
			this.Tan.Size = new System.Drawing.Size(50, 50);
			this.Tan.TabIndex = 9;
			this.Tan.Text = "tan";
			this.Tan.UseVisualStyleBackColor = false;
			this.Tan.Click += new System.EventHandler(this.Operation_Click);
			// 
			// TenPow
			// 
			this.TenPow.BackColor = System.Drawing.Color.Fuchsia;
			this.TenPow.Location = new System.Drawing.Point(93, 180);
			this.TenPow.Name = "TenPow";
			this.TenPow.Size = new System.Drawing.Size(50, 50);
			this.TenPow.TabIndex = 10;
			this.TenPow.Text = "10 ˣ ";
			this.TenPow.UseVisualStyleBackColor = false;
			this.TenPow.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Sin
			// 
			this.Sin.BackColor = System.Drawing.Color.Fuchsia;
			this.Sin.Location = new System.Drawing.Point(153, 120);
			this.Sin.Name = "Sin";
			this.Sin.Size = new System.Drawing.Size(50, 50);
			this.Sin.TabIndex = 11;
			this.Sin.Text = "sin";
			this.Sin.UseVisualStyleBackColor = false;
			this.Sin.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Mod
			// 
			this.Mod.BackColor = System.Drawing.Color.Fuchsia;
			this.Mod.Location = new System.Drawing.Point(273, 180);
			this.Mod.Name = "Mod";
			this.Mod.Size = new System.Drawing.Size(50, 50);
			this.Mod.TabIndex = 12;
			this.Mod.Text = "Mod";
			this.Mod.UseVisualStyleBackColor = false;
			this.Mod.Click += new System.EventHandler(this.Operation_Click);
			// 
			// MS
			// 
			this.MS.BackColor = System.Drawing.Color.Fuchsia;
			this.MS.Location = new System.Drawing.Point(273, 60);
			this.MS.Name = "MS";
			this.MS.Size = new System.Drawing.Size(50, 50);
			this.MS.TabIndex = 13;
			this.MS.Text = "MS";
			this.MS.UseVisualStyleBackColor = false;
			this.MS.Click += new System.EventHandler(this.Memory_click);
			// 
			// Clear
			// 
			this.Clear.BackColor = System.Drawing.Color.Pink;
			this.Clear.Location = new System.Drawing.Point(153, 240);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(50, 50);
			this.Clear.TabIndex = 14;
			this.Clear.Text = "C";
			this.Clear.UseVisualStyleBackColor = false;
			this.Clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// Sqr
			// 
			this.Sqr.BackColor = System.Drawing.Color.Fuchsia;
			this.Sqr.Location = new System.Drawing.Point(33, 120);
			this.Sqr.Name = "Sqr";
			this.Sqr.Size = new System.Drawing.Size(50, 50);
			this.Sqr.TabIndex = 15;
			this.Sqr.Text = "x ²";
			this.Sqr.UseVisualStyleBackColor = false;
			this.Sqr.Click += new System.EventHandler(this.Operation_Click);
			// 
			// MR
			// 
			this.MR.BackColor = System.Drawing.Color.Fuchsia;
			this.MR.Location = new System.Drawing.Point(153, 60);
			this.MR.Name = "MR";
			this.MR.Size = new System.Drawing.Size(50, 50);
			this.MR.TabIndex = 16;
			this.MR.Text = "MR";
			this.MR.UseVisualStyleBackColor = false;
			this.MR.Click += new System.EventHandler(this.Memory_click);
			// 
			// MC
			// 
			this.MC.BackColor = System.Drawing.Color.Fuchsia;
			this.MC.Location = new System.Drawing.Point(33, 60);
			this.MC.Margin = new System.Windows.Forms.Padding(5);
			this.MC.Name = "MC";
			this.MC.Size = new System.Drawing.Size(50, 50);
			this.MC.TabIndex = 17;
			this.MC.Text = "MC";
			this.MC.UseVisualStyleBackColor = false;
			this.MC.Click += new System.EventHandler(this.Memory_click);
			// 
			// Log
			// 
			this.Log.BackColor = System.Drawing.Color.Fuchsia;
			this.Log.Location = new System.Drawing.Point(153, 180);
			this.Log.Name = "Log";
			this.Log.Size = new System.Drawing.Size(50, 50);
			this.Log.TabIndex = 18;
			this.Log.Text = "log";
			this.Log.UseVisualStyleBackColor = false;
			this.Log.Click += new System.EventHandler(this.Operation_Click);
			// 
			// MPlass
			// 
			this.MPlass.BackColor = System.Drawing.Color.Fuchsia;
			this.MPlass.Location = new System.Drawing.Point(93, 60);
			this.MPlass.Margin = new System.Windows.Forms.Padding(5);
			this.MPlass.Name = "MPlass";
			this.MPlass.Size = new System.Drawing.Size(50, 50);
			this.MPlass.TabIndex = 19;
			this.MPlass.Text = "M+";
			this.MPlass.UseVisualStyleBackColor = false;
			this.MPlass.Click += new System.EventHandler(this.Memory_click);
			// 
			// Sqrt
			// 
			this.Sqrt.BackColor = System.Drawing.Color.Fuchsia;
			this.Sqrt.Location = new System.Drawing.Point(33, 180);
			this.Sqrt.Name = "Sqrt";
			this.Sqrt.Size = new System.Drawing.Size(50, 50);
			this.Sqrt.TabIndex = 20;
			this.Sqrt.Text = "√";
			this.Sqrt.UseVisualStyleBackColor = false;
			this.Sqrt.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Backspace
			// 
			this.Backspace.BackColor = System.Drawing.Color.Fuchsia;
			this.Backspace.Location = new System.Drawing.Point(213, 240);
			this.Backspace.Name = "Backspace";
			this.Backspace.Size = new System.Drawing.Size(50, 50);
			this.Backspace.TabIndex = 21;
			this.Backspace.Text = "←";
			this.Backspace.UseVisualStyleBackColor = false;
			this.Backspace.Click += new System.EventHandler(this.Clear_Click);
			// 
			// Dot
			// 
			this.Dot.BackColor = System.Drawing.Color.Fuchsia;
			this.Dot.Location = new System.Drawing.Point(33, 480);
			this.Dot.Name = "Dot";
			this.Dot.Size = new System.Drawing.Size(50, 50);
			this.Dot.TabIndex = 22;
			this.Dot.Text = ".";
			this.Dot.UseVisualStyleBackColor = false;
			this.Dot.Click += new System.EventHandler(this.dot_Click);
			// 
			// MMinus
			// 
			this.MMinus.BackColor = System.Drawing.Color.Fuchsia;
			this.MMinus.Location = new System.Drawing.Point(213, 60);
			this.MMinus.Name = "MMinus";
			this.MMinus.Size = new System.Drawing.Size(50, 50);
			this.MMinus.TabIndex = 23;
			this.MMinus.Text = "M-";
			this.MMinus.UseVisualStyleBackColor = false;
			this.MMinus.Click += new System.EventHandler(this.Memory_click);
			// 
			// EPow
			// 
			this.EPow.BackColor = System.Drawing.Color.Fuchsia;
			this.EPow.Location = new System.Drawing.Point(213, 180);
			this.EPow.Name = "EPow";
			this.EPow.Size = new System.Drawing.Size(50, 50);
			this.EPow.TabIndex = 24;
			this.EPow.Text = "e ˣ ";
			this.EPow.UseVisualStyleBackColor = false;
			this.EPow.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Qcube
			// 
			this.Qcube.BackColor = System.Drawing.Color.Fuchsia;
			this.Qcube.Location = new System.Drawing.Point(93, 240);
			this.Qcube.Name = "Qcube";
			this.Qcube.Size = new System.Drawing.Size(50, 50);
			this.Qcube.TabIndex = 25;
			this.Qcube.Text = "x³";
			this.Qcube.UseVisualStyleBackColor = false;
			this.Qcube.Click += new System.EventHandler(this.Operation_Click);
			// 
			// XPowOneoverY
			// 
			this.XPowOneoverY.BackColor = System.Drawing.Color.Fuchsia;
			this.XPowOneoverY.Location = new System.Drawing.Point(33, 240);
			this.XPowOneoverY.Name = "XPowOneoverY";
			this.XPowOneoverY.Size = new System.Drawing.Size(50, 50);
			this.XPowOneoverY.TabIndex = 26;
			this.XPowOneoverY.Text = "x⅟ ʸ  ";
			this.XPowOneoverY.UseVisualStyleBackColor = false;
			this.XPowOneoverY.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Factorial
			// 
			this.Factorial.BackColor = System.Drawing.Color.Fuchsia;
			this.Factorial.Location = new System.Drawing.Point(33, 360);
			this.Factorial.Name = "Factorial";
			this.Factorial.Size = new System.Drawing.Size(50, 50);
			this.Factorial.TabIndex = 27;
			this.Factorial.Text = "!";
			this.Factorial.UseVisualStyleBackColor = false;
			this.Factorial.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Pow
			// 
			this.Pow.BackColor = System.Drawing.Color.Fuchsia;
			this.Pow.Location = new System.Drawing.Point(93, 120);
			this.Pow.Name = "Pow";
			this.Pow.Size = new System.Drawing.Size(50, 50);
			this.Pow.TabIndex = 28;
			this.Pow.Text = "xʸ";
			this.Pow.UseVisualStyleBackColor = false;
			this.Pow.Click += new System.EventHandler(this.Operation_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 553);
			this.Controls.Add(this.Pow);
			this.Controls.Add(this.Factorial);
			this.Controls.Add(this.XPowOneoverY);
			this.Controls.Add(this.Qcube);
			this.Controls.Add(this.EPow);
			this.Controls.Add(this.MMinus);
			this.Controls.Add(this.Dot);
			this.Controls.Add(this.Backspace);
			this.Controls.Add(this.Sqrt);
			this.Controls.Add(this.MPlass);
			this.Controls.Add(this.Log);
			this.Controls.Add(this.MC);
			this.Controls.Add(this.MR);
			this.Controls.Add(this.Sqr);
			this.Controls.Add(this.Clear);
			this.Controls.Add(this.MS);
			this.Controls.Add(this.Mod);
			this.Controls.Add(this.Sin);
			this.Controls.Add(this.TenPow);
			this.Controls.Add(this.Tan);
			this.Controls.Add(this.Cos);
			this.Controls.Add(this.PlusORMinus);
			this.Controls.Add(this.Zero);
			this.Controls.Add(this.Percent);
			this.Controls.Add(this.Equal);
			this.Controls.Add(this.Plus);
			this.Controls.Add(this.Minus);
			this.Controls.Add(this.Multiply);
			this.Controls.Add(this.Devision);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Devision;
		private System.Windows.Forms.Button Multiply;
		private System.Windows.Forms.Button Minus;
		private System.Windows.Forms.Button Plus;
		private System.Windows.Forms.Button Equal;
		private System.Windows.Forms.Button Percent;
		private System.Windows.Forms.Button Zero;
		private System.Windows.Forms.Button PlusORMinus;
		private System.Windows.Forms.Button Cos;
		private System.Windows.Forms.Button Tan;
		private System.Windows.Forms.Button TenPow;
		private System.Windows.Forms.Button Sin;
		private System.Windows.Forms.Button Mod;
		private System.Windows.Forms.Button MS;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.Button Sqr;
		private System.Windows.Forms.Button MR;
		private System.Windows.Forms.Button MC;
		private System.Windows.Forms.Button Log;
		private System.Windows.Forms.Button MPlass;
		private System.Windows.Forms.Button Sqrt;
		private System.Windows.Forms.Button Backspace;
		private System.Windows.Forms.Button Dot;
		private System.Windows.Forms.Button MMinus;
		private System.Windows.Forms.Button EPow;
		private System.Windows.Forms.Button Qcube;
		private System.Windows.Forms.Button XPowOneoverY;
		private System.Windows.Forms.Button Factorial;
		private System.Windows.Forms.Button Pow;
	}
}

