using System;

// Token: 0x020000F5 RID: 245
public class GClass63
{
	// Token: 0x060007C2 RID: 1986 RVA: 0x00067F50 File Offset: 0x00066150
	public static int[] smethod_0(IntPtr intptr_0, IntPtr intptr_1)
	{
		if (!(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero))
		{
			byte[] array = new byte[184];
			uint num = 0U;
			if (GClass45.ReadProcessMemory(intptr_0, intptr_1, array, (uint)array.Length, ref num))
			{
				if ((ulong)num == (ulong)((long)array.Length))
				{
					int[] array2 = new int[46];
					int num2 = 0;
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i] = BitConverter.ToInt32(array, num2);
						num2 += 4;
						if (array2[i] > 1 && !GClass49.smethod_11(intptr_0, (IntPtr)array2[i]))
						{
							return null;
						}
					}
					return array2;
				}
			}
			return null;
		}
		return null;
	}
}
