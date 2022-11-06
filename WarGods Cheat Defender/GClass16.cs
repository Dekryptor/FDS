using System;
using System.Runtime.InteropServices;

// Token: 0x02000031 RID: 49
public class GClass16
{
	// Token: 0x06000116 RID: 278
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out GClass16.GStruct0 gstruct0_0, int int_0);

	// Token: 0x06000117 RID: 279
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000118 RID: 280 RVA: 0x0004216C File Offset: 0x0004036C
	public static bool smethod_0(GClass16.GStruct0 gstruct0_0)
	{
		return gstruct0_0.uint_1 == 4096U && ((gstruct0_0.uint_2 & 1U) == 0U && (gstruct0_0.uint_2 & 256U) == 0U && (gstruct0_0.uint_2 & 1024U) == 0U && gstruct0_0.uint_2 != 0U);
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000421BC File Offset: 0x000403BC
	public static bool smethod_1(IntPtr intptr_0, IntPtr intptr_1)
	{
		GClass16.GStruct0 gstruct = default(GClass16.GStruct0);
		return !(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero) && GClass16.VirtualQueryEx(intptr_0, intptr_1, out gstruct, Marshal.SizeOf(gstruct)) > 0 && GClass16.smethod_0(gstruct);
	}

	// Token: 0x02000032 RID: 50
	public struct GStruct0
	{
		// Token: 0x0400016B RID: 363
		public IntPtr intptr_0;

		// Token: 0x0400016C RID: 364
		public IntPtr intptr_1;

		// Token: 0x0400016D RID: 365
		public uint uint_0;

		// Token: 0x0400016E RID: 366
		public IntPtr intptr_2;

		// Token: 0x0400016F RID: 367
		public uint uint_1;

		// Token: 0x04000170 RID: 368
		public uint uint_2;

		// Token: 0x04000171 RID: 369
		public uint uint_3;
	}

	// Token: 0x02000033 RID: 51
	public enum GEnum12 : uint
	{
		// Token: 0x04000173 RID: 371
		const_0,
		// Token: 0x04000174 RID: 372
		const_1,
		// Token: 0x04000175 RID: 373
		const_2,
		// Token: 0x04000176 RID: 374
		const_3 = 4U,
		// Token: 0x04000177 RID: 375
		const_4 = 8U,
		// Token: 0x04000178 RID: 376
		const_5 = 16U,
		// Token: 0x04000179 RID: 377
		const_6 = 32U,
		// Token: 0x0400017A RID: 378
		const_7 = 64U,
		// Token: 0x0400017B RID: 379
		const_8 = 128U,
		// Token: 0x0400017C RID: 380
		const_9 = 256U,
		// Token: 0x0400017D RID: 381
		const_10 = 512U,
		// Token: 0x0400017E RID: 382
		const_11 = 1024U
	}

	// Token: 0x02000034 RID: 52
	public enum GEnum13 : uint
	{
		// Token: 0x04000180 RID: 384
		const_0 = 4096U,
		// Token: 0x04000181 RID: 385
		const_1 = 8192U,
		// Token: 0x04000182 RID: 386
		const_2 = 32768U,
		// Token: 0x04000183 RID: 387
		const_3 = 65536U,
		// Token: 0x04000184 RID: 388
		const_4 = 16777216U,
		// Token: 0x04000185 RID: 389
		const_5 = 536870912U,
		// Token: 0x04000186 RID: 390
		const_6 = 4194304U,
		// Token: 0x04000187 RID: 391
		const_7 = 1048576U
	}

	// Token: 0x02000035 RID: 53
	public enum GEnum14 : uint
	{
		// Token: 0x04000189 RID: 393
		const_0 = 16777216U,
		// Token: 0x0400018A RID: 394
		const_1 = 262144U,
		// Token: 0x0400018B RID: 395
		const_2 = 131072U
	}
}
