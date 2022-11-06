using System;
using System.Runtime.InteropServices;

// Token: 0x0200001C RID: 28
public class GClass10
{
	// Token: 0x060000E7 RID: 231
	[DllImport("ntdll.dll")]
	private static extern uint RtlGetCompressionWorkSpaceSize(ushort ushort_1, ref ulong ulong_0, ref ulong ulong_1);

	// Token: 0x060000E8 RID: 232
	[DllImport("ntdll.dll")]
	private static extern uint RtlDecompressBufferEx(ushort ushort_1, byte[] byte_0, int int_0, byte[] byte_1, int int_1, ref int int_2, byte[] byte_2);

	// Token: 0x060000E9 RID: 233 RVA: 0x000419F8 File Offset: 0x0003FBF8
	public static byte[] smethod_0(byte[] byte_0, ulong ulong_0)
	{
		byte[] array = new byte[ulong_0];
		ulong num = 0UL;
		ulong num2 = 0UL;
		if (GClass10.RtlGetCompressionWorkSpaceSize(4, ref num, ref num2) != 0U)
		{
			return null;
		}
		byte[] array2 = new byte[num2];
		int num3 = 0;
		if (GClass10.RtlDecompressBufferEx(4, array, array.Length, byte_0, byte_0.Length, ref num3, array2) != 0U)
		{
			return null;
		}
		return array;
	}

	// Token: 0x040000B5 RID: 181
	private const ushort ushort_0 = 4;
}
