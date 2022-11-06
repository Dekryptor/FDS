// Token: 0x020000BA RID: 186
public partial class WCD : global::System.Windows.Forms.Form
{
	// Token: 0x06000651 RID: 1617 RVA: 0x00062594 File Offset: 0x00060794
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WCD));
		this.scan = new global::System.Windows.Forms.Button();
		this.report = new global::System.Windows.Forms.Button();
		this.label1 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.label4 = new global::System.Windows.Forms.Label();
		base.SuspendLayout();
		this.scan.BackColor = global::System.Drawing.Color.Transparent;
		this.scan.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
		this.scan.FlatAppearance.BorderSize = 0;
		this.scan.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Black;
		this.scan.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Black;
		this.scan.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.scan.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold);
		this.scan.ForeColor = global::System.Drawing.Color.Transparent;
		this.scan.Location = new global::System.Drawing.Point(253, 129);
		this.scan.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.scan.Name = "scan";
		this.scan.Size = new global::System.Drawing.Size(124, 36);
		this.scan.TabIndex = 2;
		this.scan.Text = "Scan";
		this.scan.UseVisualStyleBackColor = false;
		this.scan.Click += new global::System.EventHandler(this.scan_Click);
		this.report.BackColor = global::System.Drawing.Color.Transparent;
		this.report.Enabled = false;
		this.report.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
		this.report.FlatAppearance.BorderSize = 0;
		this.report.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Black;
		this.report.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Black;
		this.report.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.report.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
		this.report.ForeColor = global::System.Drawing.Color.Transparent;
		this.report.Location = new global::System.Drawing.Point(253, 172);
		this.report.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.report.Name = "report";
		this.report.Size = new global::System.Drawing.Size(124, 36);
		this.report.TabIndex = 3;
		this.report.Text = "Report";
		this.report.UseVisualStyleBackColor = false;
		this.report.Click += new global::System.EventHandler(this.report_Click);
		this.label1.AutoSize = true;
		this.label1.BackColor = global::System.Drawing.Color.Transparent;
		this.label1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.label1.Font = new global::System.Drawing.Font("Ethnocentric Rg", 8.999999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
		this.label1.ForeColor = global::System.Drawing.Color.White;
		this.label1.Location = new global::System.Drawing.Point(4, 284);
		this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(161, 18);
		this.label1.TabIndex = 6;
		this.label1.Text = "wargods.ro";
		this.label1.Click += new global::System.EventHandler(this.label1_Click);
		this.label2.AutoSize = true;
		this.label2.BackColor = global::System.Drawing.Color.Transparent;
		this.label2.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.label2.Font = new global::System.Drawing.Font("Ethnocentric Rg", 8.999999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
		this.label2.ForeColor = global::System.Drawing.Color.White;
		this.label2.Location = new global::System.Drawing.Point(289, 284);
		this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(88, 18);
		this.label2.TabIndex = 5;
		this.label2.Text = "About";
		this.label2.Click += new global::System.EventHandler(this.label2_Click);
		this.label3.AutoSize = true;
		this.label3.BackColor = global::System.Drawing.Color.Transparent;
		this.label3.Cursor = global::System.Windows.Forms.Cursors.Arrow;
		this.label3.Font = new global::System.Drawing.Font("Ethnocentric Rg", 8.999999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
		this.label3.ForeColor = global::System.Drawing.Color.White;
		this.label3.Location = new global::System.Drawing.Point(4, 219);
		this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(100, 18);
		this.label3.TabIndex = 7;
		this.label3.Text = "Status:";
		this.label4.AutoSize = true;
		this.label4.BackColor = global::System.Drawing.Color.Transparent;
		this.label4.Cursor = global::System.Windows.Forms.Cursors.Default;
		this.label4.Font = new global::System.Drawing.Font("Ethnocentric Rg", 8.999999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
		this.label4.ForeColor = global::System.Drawing.Color.White;
		this.label4.Location = new global::System.Drawing.Point(4, 241);
		this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(118, 18);
		this.label4.TabIndex = 8;
		this.label4.Text = "Waiting...";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		this.BackgroundImage = global::WarGodsCheatDefender.Properties.Properties.Resources.wcd;
		this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new global::System.Drawing.Size(393, 313);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.report);
		base.Controls.Add(this.scan);
		this.DoubleBuffered = true;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = global::WarGodsCheatDefender.Properties.Properties.Resources.Icon;
		base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.Name = "WCD";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "WarGods Cheat Defender";
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.WCD_FormClosing);
		base.Load += new global::System.EventHandler(this.WCD_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000962 RID: 2402
	private global::System.Windows.Forms.Button scan;

	// Token: 0x04000963 RID: 2403
	private global::System.Windows.Forms.Button report;

	// Token: 0x04000964 RID: 2404
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000965 RID: 2405
	private global::System.Windows.Forms.Label label2;

	// Token: 0x04000966 RID: 2406
	private global::System.Windows.Forms.Label label3;

	// Token: 0x04000967 RID: 2407
	private global::System.Windows.Forms.Label label4;
}
