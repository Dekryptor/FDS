using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x020000D6 RID: 214
public class GClass58
{
	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x060006BD RID: 1725 RVA: 0x00063EFC File Offset: 0x000620FC
	// (set) Token: 0x060006BE RID: 1726 RVA: 0x00063F10 File Offset: 0x00062110
	public string String_0 { get; private set; }

	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x060006BF RID: 1727 RVA: 0x00063F24 File Offset: 0x00062124
	// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00063F38 File Offset: 0x00062138
	public string String_1 { get; private set; }

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00063F4C File Offset: 0x0006214C
	// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00063F60 File Offset: 0x00062160
	public uint UInt32_0 { get; private set; }

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00063F74 File Offset: 0x00062174
	// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00063F88 File Offset: 0x00062188
	public long Int64_0 { get; private set; }

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00063F9C File Offset: 0x0006219C
	// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00063FB0 File Offset: 0x000621B0
	public DateTime? Nullable_0 { get; private set; }

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00063FC4 File Offset: 0x000621C4
	// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00063FD8 File Offset: 0x000621D8
	public GEnum52 GEnum52_0 { get; private set; }

	// Token: 0x060006C9 RID: 1737 RVA: 0x00063FEC File Offset: 0x000621EC
	public GClass58(string string_2, uint uint_1, long long_1, GEnum52 genum52_1)
	{
		this.String_1 = string_2;
		string text = string_2;
		if (text != null)
		{
			int num = text.IndexOf(":::");
			if (num <= -1)
			{
				num = text.IndexOf("::");
				if (num > -1)
				{
					text = text.Substring(num + 2);
				}
				else
				{
					num = text.IndexOf(":");
					if (num > -1)
					{
						text = text.Substring(num + 1);
					}
				}
			}
			else
			{
				text = text.Substring(num + 3);
			}
			if (text.Length >= 38 && text[0] == '{' && text[37] == '}')
			{
				string text2 = text.Substring(0, 38);
				if (Class15.smethod_21(text2))
				{
					string text3 = GClass45.smethod_9(new Guid(text2), GClass45.GEnum41.flag_6);
					if (text3 != null && text3.Length > 0)
					{
						if (text.Length > 38)
						{
							string text4 = text.Substring(38);
							if (text4.StartsWith("\\"))
							{
								text4 = text4.Substring(1);
							}
							text = Path.Combine(text3, text4);
						}
						else
						{
							text = text3;
						}
					}
				}
			}
		}
		this.String_0 = GClass45.smethod_6(text);
		this.UInt32_0 = uint_1;
		this.Int64_0 = long_1;
		try
		{
			this.Nullable_0 = new DateTime?(DateTime.FromFileTimeUtc(long_1));
		}
		catch (ArgumentOutOfRangeException)
		{
			this.Nullable_0 = null;
		}
		this.GEnum52_0 = genum52_1;
	}

	// Token: 0x040009A6 RID: 2470
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009A7 RID: 2471
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009A8 RID: 2472
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x040009A9 RID: 2473
	[CompilerGenerated]
	private long long_0;

	// Token: 0x040009AA RID: 2474
	[CompilerGenerated]
	private DateTime? nullable_0;

	// Token: 0x040009AB RID: 2475
	[CompilerGenerated]
	private GEnum52 genum52_0;
}
