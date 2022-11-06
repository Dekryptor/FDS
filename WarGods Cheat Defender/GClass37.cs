using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x02000058 RID: 88
public class GClass37
{
	// Token: 0x060002FF RID: 767 RVA: 0x0003E820 File Offset: 0x0003CA20
	public GClass37()
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0004B900 File Offset: 0x00049B00
	public GClass37(X509Certificate2 x509Certificate2_0)
	{
		if (x509Certificate2_0 == null)
		{
			throw new ArgumentNullException();
		}
		this.Boolean_0 = x509Certificate2_0.HasPrivateKey;
		this.String_0 = x509Certificate2_0.IssuerName.Name;
		this.String_1 = x509Certificate2_0.SubjectName.Name;
		this.DateTime_0 = x509Certificate2_0.NotAfter;
		this.DateTime_1 = x509Certificate2_0.NotBefore;
		this.String_2 = x509Certificate2_0.SerialNumber;
		this.String_3 = x509Certificate2_0.Thumbprint;
		this.Int32_0 = x509Certificate2_0.Version;
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000301 RID: 769 RVA: 0x0004B988 File Offset: 0x00049B88
	// (set) Token: 0x06000302 RID: 770 RVA: 0x0004B99C File Offset: 0x00049B9C
	public bool Boolean_0 { get; set; }

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000303 RID: 771 RVA: 0x0004B9B0 File Offset: 0x00049BB0
	// (set) Token: 0x06000304 RID: 772 RVA: 0x0004B9C4 File Offset: 0x00049BC4
	public string String_0 { get; set; }

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000305 RID: 773 RVA: 0x0004B9D8 File Offset: 0x00049BD8
	// (set) Token: 0x06000306 RID: 774 RVA: 0x0004B9EC File Offset: 0x00049BEC
	public string String_1 { get; set; }

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000307 RID: 775 RVA: 0x0004BA00 File Offset: 0x00049C00
	// (set) Token: 0x06000308 RID: 776 RVA: 0x0004BA14 File Offset: 0x00049C14
	public DateTime DateTime_0 { get; set; }

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000309 RID: 777 RVA: 0x0004BA28 File Offset: 0x00049C28
	// (set) Token: 0x0600030A RID: 778 RVA: 0x0004BA3C File Offset: 0x00049C3C
	public DateTime DateTime_1 { get; set; }

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x0600030B RID: 779 RVA: 0x0004BA50 File Offset: 0x00049C50
	// (set) Token: 0x0600030C RID: 780 RVA: 0x0004BA64 File Offset: 0x00049C64
	public string String_2 { get; set; }

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x0600030D RID: 781 RVA: 0x0004BA78 File Offset: 0x00049C78
	// (set) Token: 0x0600030E RID: 782 RVA: 0x0004BA8C File Offset: 0x00049C8C
	public string String_3 { get; set; }

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x0600030F RID: 783 RVA: 0x0004BAA0 File Offset: 0x00049CA0
	// (set) Token: 0x06000310 RID: 784 RVA: 0x0004BAB4 File Offset: 0x00049CB4
	public int Int32_0 { get; set; }

	// Token: 0x06000311 RID: 785 RVA: 0x0004B8D0 File Offset: 0x00049AD0
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("WIN_CERTIFICATE\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-10}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x04000298 RID: 664
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04000299 RID: 665
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0400029A RID: 666
	[CompilerGenerated]
	private string string_1;

	// Token: 0x0400029B RID: 667
	[CompilerGenerated]
	private DateTime dateTime_0;

	// Token: 0x0400029C RID: 668
	[CompilerGenerated]
	private DateTime dateTime_1;

	// Token: 0x0400029D RID: 669
	[CompilerGenerated]
	private string string_2;

	// Token: 0x0400029E RID: 670
	[CompilerGenerated]
	private string string_3;

	// Token: 0x0400029F RID: 671
	[CompilerGenerated]
	private int int_0;
}
