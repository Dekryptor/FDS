using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x020000DB RID: 219
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Class43
{
	// Token: 0x060006F9 RID: 1785 RVA: 0x0003E820 File Offset: 0x0003CA20
	internal Class43()
	{
	}

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x060006FA RID: 1786 RVA: 0x000647C0 File Offset: 0x000629C0
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class43.resourceManager_0 == null)
			{
				Class43.resourceManager_0 = new ResourceManager("/)/Ls6!)d8FaJn#do3=\\\\DLB6#", typeof(Class43).Assembly);
			}
			return Class43.resourceManager_0;
		}
	}

	// Token: 0x170002FF RID: 767
	// (get) Token: 0x060006FB RID: 1787 RVA: 0x000647F8 File Offset: 0x000629F8
	// (set) Token: 0x060006FC RID: 1788 RVA: 0x0006480C File Offset: 0x00062A0C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class43.cultureInfo_0;
		}
		set
		{
			Class43.cultureInfo_0 = value;
		}
	}

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x060006FD RID: 1789 RVA: 0x00064820 File Offset: 0x00062A20
	internal static byte[] Byte_0
	{
		get
		{
			return (byte[])Class43.ResourceManager_0.GetObject("ethnocentric", Class43.cultureInfo_0);
		}
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x060006FE RID: 1790 RVA: 0x00064848 File Offset: 0x00062A48
	internal static Bitmap Bitmap_0
	{
		get
		{
			return (Bitmap)Class43.ResourceManager_0.GetObject("wcd", Class43.cultureInfo_0);
		}
	}

	// Token: 0x040009C6 RID: 2502
	private static ResourceManager resourceManager_0;

	// Token: 0x040009C7 RID: 2503
	private static CultureInfo cultureInfo_0;
}
