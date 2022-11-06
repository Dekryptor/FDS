using System;
using System.Runtime.InteropServices;

// Token: 0x0200003C RID: 60
internal static class Class8
{
	// Token: 0x060001B3 RID: 435
	[DllImport("Wintrust.dll")]
	private static extern uint WinVerifyTrust(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x060001B4 RID: 436 RVA: 0x000488A4 File Offset: 0x00046AA4
	private static uint smethod_0(string string_0)
	{
		Guid guid = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
		uint num;
		using (Struct7 @struct = new Struct7(string_0, Guid.Empty))
		{
			using (Class9 @class = new Class9(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid))), Enum1.const_0))
			{
				using (Class9 class2 = new Class9(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Struct8))), Enum1.const_0))
				{
					Struct8 struct2 = new Struct8(@struct);
					IntPtr intPtr = Class9.smethod_0(@class);
					IntPtr intPtr2 = Class9.smethod_0(class2);
					Marshal.StructureToPtr(guid, intPtr, true);
					Marshal.StructureToPtr(struct2, intPtr2, true);
					num = Class8.WinVerifyTrust(IntPtr.Zero, intPtr, intPtr2);
				}
			}
		}
		return num;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00048994 File Offset: 0x00046B94
	public static bool smethod_1(string string_0)
	{
		return Class8.smethod_0(string_0) == 0U;
	}
}
