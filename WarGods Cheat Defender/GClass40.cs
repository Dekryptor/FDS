using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000068 RID: 104
public class GClass40
{
	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000336 RID: 822 RVA: 0x0004C9D0 File Offset: 0x0004ABD0
	// (set) Token: 0x06000337 RID: 823 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
	public GEnum20 GEnum20_0 { get; set; }

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000338 RID: 824 RVA: 0x0004C9F8 File Offset: 0x0004ABF8
	// (set) Token: 0x06000339 RID: 825 RVA: 0x0004CA0C File Offset: 0x0004AC0C
	public string String_0 { get; set; }

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x0600033A RID: 826 RVA: 0x0004CA20 File Offset: 0x0004AC20
	// (set) Token: 0x0600033B RID: 827 RVA: 0x0004CA34 File Offset: 0x0004AC34
	public byte[] Byte_0 { get; set; }

	// Token: 0x0600033C RID: 828 RVA: 0x0004CA48 File Offset: 0x0004AC48
	public GClass40()
	{
		this.GEnum20_0 = GEnum20.const_0;
		this.String_0 = null;
		this.Byte_0 = null;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0004CA70 File Offset: 0x0004AC70
	public static List<GClass40> smethod_0(string string_1)
	{
		string[] array = string_1.Split(new char[] { ';' });
		List<GClass40> list = new List<GClass40>();
		try
		{
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(new char[] { '!' });
				if (array3.Length != 4)
				{
					return null;
				}
				int num = Convert.ToInt32(array3[0]);
				int num2 = Convert.ToInt32(array3[1]);
				string text;
				byte[] array4;
				if ((num & 1) != 1)
				{
					if ((num & 2) != 2)
					{
						return null;
					}
					text = Class13.smethod_18(array3[2], num2);
					array4 = null;
					if (text == null)
					{
						return null;
					}
				}
				else
				{
					text = Class13.smethod_18(array3[2], num2);
					array4 = Class13.smethod_19(array3[3], num2);
					if (array4 == null || text == null)
					{
						return null;
					}
				}
				list.Add(new GClass40
				{
					GEnum20_0 = (GEnum20)num,
					Byte_0 = array4,
					String_0 = text
				});
			}
		}
		catch
		{
			return null;
		}
		if (list.Count == 0)
		{
			return null;
		}
		return list;
	}

	// Token: 0x04000300 RID: 768
	[CompilerGenerated]
	private GEnum20 genum20_0;

	// Token: 0x04000301 RID: 769
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000302 RID: 770
	[CompilerGenerated]
	private byte[] byte_0;
}
