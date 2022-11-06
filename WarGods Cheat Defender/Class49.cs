using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

// Token: 0x020000E2 RID: 226
internal class Class49
{
	// Token: 0x17000319 RID: 793
	// (get) Token: 0x0600073D RID: 1853 RVA: 0x00065B0C File Offset: 0x00063D0C
	// (set) Token: 0x0600073E RID: 1854 RVA: 0x00065B20 File Offset: 0x00063D20
	public bool Boolean_0 { get; set; }

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x0600073F RID: 1855 RVA: 0x00065B34 File Offset: 0x00063D34
	// (set) Token: 0x06000740 RID: 1856 RVA: 0x00065B48 File Offset: 0x00063D48
	public int Int32_0 { get; set; }

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x06000741 RID: 1857 RVA: 0x00065B5C File Offset: 0x00063D5C
	// (set) Token: 0x06000742 RID: 1858 RVA: 0x00065B70 File Offset: 0x00063D70
	public int Int32_1 { get; set; }

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06000743 RID: 1859 RVA: 0x00065B84 File Offset: 0x00063D84
	// (set) Token: 0x06000744 RID: 1860 RVA: 0x00065B98 File Offset: 0x00063D98
	public int Int32_2 { get; set; }

	// Token: 0x06000745 RID: 1861 RVA: 0x00065BAC File Offset: 0x00063DAC
	public Class49(bool bool_1 = false, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		this.Boolean_0 = bool_1;
		this.Int32_0 = int_3;
		this.Int32_1 = int_4;
		this.Int32_2 = int_5;
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00065BDC File Offset: 0x00063DDC
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
		{
			this.Boolean_0 ? "1" : "0",
			Class15.char_2,
			this.Int32_0,
			Class15.char_2,
			this.Int32_1,
			Class15.char_2,
			this.Int32_2
		});
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00065C64 File Offset: 0x00063E64
	public static string smethod_0()
	{
		List<Class49> list = new List<Class49>();
		try
		{
			foreach (Screen screen in Screen.AllScreens)
			{
				Rectangle bounds = screen.Bounds;
				Class49 @class = new Class49(screen.Primary, bounds.Width, bounds.Height, screen.BitsPerPixel);
				list.Add(@class);
			}
		}
		catch
		{
		}
		if (list.Count == 0)
		{
			Class49 @class = new Class49(false, 0, 0, 0);
			list.Add(@class);
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int j = 0; j < list.Count; j++)
		{
			stringBuilder.Append(list[j]);
			if (j + 1 != list.Count)
			{
				stringBuilder.Append(Class15.char_1);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x040009DF RID: 2527
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040009E0 RID: 2528
	[CompilerGenerated]
	private int int_0;

	// Token: 0x040009E1 RID: 2529
	[CompilerGenerated]
	private int int_1;

	// Token: 0x040009E2 RID: 2530
	[CompilerGenerated]
	private int int_2;
}
