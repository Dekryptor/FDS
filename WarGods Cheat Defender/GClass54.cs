using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000B5 RID: 181
public class GClass54
{
	// Token: 0x170002CF RID: 719
	// (get) Token: 0x060005BE RID: 1470 RVA: 0x00055FA0 File Offset: 0x000541A0
	// (set) Token: 0x060005BF RID: 1471 RVA: 0x00055FB4 File Offset: 0x000541B4
	public GStruct26 GStruct26_0 { get; private set; }

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00055FC8 File Offset: 0x000541C8
	// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00055FDC File Offset: 0x000541DC
	public List<long> List_0 { get; private set; }

	// Token: 0x060005C2 RID: 1474 RVA: 0x00055FF0 File Offset: 0x000541F0
	public GClass54(GStruct26 gstruct26_1)
	{
		this.GStruct26_0 = gstruct26_1;
		this.List_0 = new List<long>();
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00056018 File Offset: 0x00054218
	public string String_0
	{
		get
		{
			string text = new string(this.GStruct26_0.char_0).Trim();
			int num = text.IndexOf('\0');
			if (num > -1)
			{
				text = text.Substring(0, num);
			}
			return text.Trim();
		}
	}

	// Token: 0x04000929 RID: 2345
	[CompilerGenerated]
	private GStruct26 gstruct26_0;

	// Token: 0x0400092A RID: 2346
	[CompilerGenerated]
	private List<long> list_0;
}
