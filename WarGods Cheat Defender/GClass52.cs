using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000B1 RID: 177
public class GClass52
{
	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x060005AB RID: 1451 RVA: 0x00055D30 File Offset: 0x00053F30
	// (set) Token: 0x060005AC RID: 1452 RVA: 0x00055D44 File Offset: 0x00053F44
	public string String_0 { get; private set; }

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x060005AD RID: 1453 RVA: 0x00055D58 File Offset: 0x00053F58
	// (set) Token: 0x060005AE RID: 1454 RVA: 0x00055D6C File Offset: 0x00053F6C
	public string String_1 { get; private set; }

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x060005AF RID: 1455 RVA: 0x00055D80 File Offset: 0x00053F80
	// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00055D94 File Offset: 0x00053F94
	public bool Boolean_0 { get; private set; }

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00055DA8 File Offset: 0x00053FA8
	// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00055DBC File Offset: 0x00053FBC
	public List<GClass53> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00055DD0 File Offset: 0x00053FD0
	public GClass52(string string_2, string string_3, bool bool_1 = false)
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException("Invalid first argument");
		}
		this.String_0 = string_2;
		this.String_1 = string_3;
		this.Boolean_0 = bool_1;
		this.list_0 = new List<GClass53>();
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00055E14 File Offset: 0x00054014
	public GClass52(string string_2, string string_3, List<GClass53> list_1, bool bool_1 = false)
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException("Invalid first argument");
		}
		this.String_0 = string_2;
		this.String_1 = string_3;
		this.list_0 = list_1;
		this.Boolean_0 = bool_1;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00055E54 File Offset: 0x00054054
	public int method_0()
	{
		int num = 0;
		for (int i = 0; i < this.list_0.Count; i++)
		{
			if (this.list_0[i].Byte_0.Length > num)
			{
				num = this.list_0[i].Byte_0.Length;
			}
		}
		return num;
	}

	// Token: 0x040008F4 RID: 2292
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040008F5 RID: 2293
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040008F6 RID: 2294
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040008F7 RID: 2295
	private List<GClass53> list_0;
}
