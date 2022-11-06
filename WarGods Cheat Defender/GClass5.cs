using System;
using System.IO;
using System.Text;

// Token: 0x02000017 RID: 23
public class GClass5
{
	// Token: 0x06000087 RID: 135 RVA: 0x0003FD98 File Offset: 0x0003DF98
	public static byte[] smethod_0(byte[] byte_0, int int_1, int int_2)
	{
		byte[] array = new byte[int_2];
		Array.Copy(byte_0, int_1, array, 0, int_2);
		return array;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0003FDB8 File Offset: 0x0003DFB8
	public static void smethod_1(string string_0, GInterface0 ginterface0_0)
	{
		File.WriteAllBytes(string_0, ginterface0_0.Byte_0);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0003FDD4 File Offset: 0x0003DFD4
	public static GInterface0 smethod_2(string string_0)
	{
		byte[] array = File.ReadAllBytes(string_0);
		if (array.Length < 8)
		{
			throw new GException0("Invalid file");
		}
		if (Encoding.ASCII.GetString(array, 0, 3).Equals("MAM"))
		{
			uint num = BitConverter.ToUInt32(array, 4);
			array = GClass10.smethod_0(GClass5.smethod_0(array, 8, array.Length - 8), (ulong)num);
		}
		GEnum1 genum = (GEnum1)BitConverter.ToInt32(array, 0);
		if (BitConverter.ToInt32(array, 4) != 1094927187)
		{
			throw new GException2("Invalid signature! Should be 'SCCA'");
		}
		if (genum <= GEnum1.const_1)
		{
			if (genum == GEnum1.const_0)
			{
				return new GClass6(array, string_0);
			}
			if (genum == GEnum1.const_1)
			{
				return new GClass7(array, string_0);
			}
		}
		else
		{
			if (genum == GEnum1.const_2)
			{
				return new GClass8(array, string_0);
			}
			if (genum == GEnum1.const_3)
			{
				return new GClass9(array, string_0);
			}
		}
		throw new GException1(string.Format("Unknown version '{0:X}'", genum));
	}

	// Token: 0x0400005C RID: 92
	private const int int_0 = 1094927187;
}
