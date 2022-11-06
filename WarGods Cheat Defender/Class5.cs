using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000010 RID: 16
internal class Class5
{
	// Token: 0x06000049 RID: 73
	[DllImport("kernel32")]
	public static extern int GetPrivateProfileString(string string_1, string string_2, string string_3, StringBuilder stringBuilder_0, int int_0, string string_4);

	// Token: 0x0600004A RID: 74
	[DllImport("kernel32")]
	public static extern int GetPrivateProfileInt(string string_1, string string_2, int int_0, string string_3);

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600004B RID: 75 RVA: 0x0003F6F8 File Offset: 0x0003D8F8
	// (set) Token: 0x0600004C RID: 76 RVA: 0x0003F70C File Offset: 0x0003D90C
	public string String_0 { get; private set; }

	// Token: 0x0600004D RID: 77 RVA: 0x0003F720 File Offset: 0x0003D920
	public static string smethod_0(string string_1, string string_2, string string_3 = null, string string_4 = null)
	{
		StringBuilder stringBuilder = new StringBuilder(16777215);
		Class5.GetPrivateProfileString(string_2, string_3, string_4, stringBuilder, stringBuilder.Capacity, string_1);
		return stringBuilder.ToString().Trim();
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0003F754 File Offset: 0x0003D954
	public static int smethod_1(string string_1, string string_2, string string_3 = null, int int_0 = 0)
	{
		return Class5.GetPrivateProfileInt(string_2, string_3, int_0, string_1);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0003F76C File Offset: 0x0003D96C
	public static string smethod_2(string string_1)
	{
		if (string_1 == null || string_1 == string.Empty)
		{
			return string_1;
		}
		string[] array = string_1.Split(new char[] { ':' });
		if (array.Length < 2)
		{
			return string_1;
		}
		return array[0] + ":" + array[1];
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0003F7B8 File Offset: 0x0003D9B8
	public static string smethod_3(string string_1)
	{
		if (string_1 == null || string_1.Length == 0)
		{
			throw new Exception();
		}
		return Class5.smethod_2(string_1) + ":Zone.Identifier";
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0003F7E8 File Offset: 0x0003D9E8
	public static bool smethod_4(string string_1, ref GClass0 gclass0_0)
	{
		try
		{
			string text = Class5.smethod_3(string_1);
			if (GClass39.smethod_3(text))
			{
				gclass0_0.GEnum0_0 = (GEnum0)Class5.smethod_1(text, "ZoneTransfer", "ZoneId", 0);
				gclass0_0.String_1 = Class5.smethod_0(text, "ZoneTransfer", "ReferrerUrl", null);
				gclass0_0.String_0 = Class5.smethod_0(text, "ZoneTransfer", "HostUrl", null);
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x04000043 RID: 67
	[CompilerGenerated]
	private string string_0;
}
