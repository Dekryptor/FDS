using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x0200006A RID: 106
internal class Class12
{
	// Token: 0x1700014E RID: 334
	// (get) Token: 0x0600033E RID: 830 RVA: 0x0004CB90 File Offset: 0x0004AD90
	public static string String_0
	{
		get
		{
			return "wcd";
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x0600033F RID: 831 RVA: 0x0004CBA4 File Offset: 0x0004ADA4
	// (set) Token: 0x06000340 RID: 832 RVA: 0x0004CBB8 File Offset: 0x0004ADB8
	public static bool Boolean_0 { get; set; }

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000341 RID: 833 RVA: 0x0004CBCC File Offset: 0x0004ADCC
	public static string String_1
	{
		get
		{
			return "https";
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000342 RID: 834 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
	public static string String_2
	{
		get
		{
			return "http";
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000343 RID: 835 RVA: 0x0004CBF4 File Offset: 0x0004ADF4
	public static string String_3
	{
		get
		{
			return "www.wargods.ro";
		}
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0004CC08 File Offset: 0x0004AE08
	public static string smethod_0(bool bool_1)
	{
		return (bool_1 ? Class12.String_1 : Class12.String_2) + "://" + Class12.String_3;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0004CC34 File Offset: 0x0004AE34
	public static string smethod_1(bool bool_1)
	{
		return Class12.smethod_0(bool_1) + "/" + Class12.String_0;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x0004CC58 File Offset: 0x0004AE58
	public static string smethod_2(bool bool_1, string string_0)
	{
		return Class12.smethod_1(bool_1) + "/api.php?query=" + string_0;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0004CC78 File Offset: 0x0004AE78
	public static string smethod_3(bool bool_1, long long_0)
	{
		return Class12.smethod_1(bool_1) + "/report.php?id=" + long_0.ToString();
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000348 RID: 840 RVA: 0x0004CC9C File Offset: 0x0004AE9C
	public static string String_4
	{
		get
		{
			return Application.ProductVersion;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000349 RID: 841 RVA: 0x0004CCB0 File Offset: 0x0004AEB0
	public static string String_5
	{
		get
		{
			string text = "";
			try
			{
				text = string.Format("wCD/{0} ({1})", Application.ProductVersion, Environment.OSVersion);
			}
			catch
			{
				text = string.Format("wCD/{0}", Application.ProductVersion);
			}
			return text;
		}
	}

	// Token: 0x0400030B RID: 779
	[CompilerGenerated]
	private static bool bool_0;
}
