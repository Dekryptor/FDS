using System;

// Token: 0x020000F0 RID: 240
public class GClass61
{
    // Token: 0x0600079E RID: 1950 RVA: 0x000678A8 File Offset: 0x00065AA8
    public static int[] smethod_0(IntPtr intptr_0, IntPtr intptr_1)
    {
        if (!(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero))
        {
            byte[] array = new byte[536];
            uint num = 0U;
            if (GClass45.ReadProcessMemory(intptr_0, intptr_1, array, (uint)array.Length, ref num))
            {
                if ((ulong)num == (ulong)((long)array.Length))
                {
                    int[] array2 = new int[134];
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
