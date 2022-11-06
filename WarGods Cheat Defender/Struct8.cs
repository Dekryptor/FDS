using System;
using System.Runtime.InteropServices;

// Token: 0x02000045 RID: 69
internal struct Struct8 : IDisposable
{
	// Token: 0x060001B8 RID: 440 RVA: 0x00048A68 File Offset: 0x00046C68
	public Struct8(Struct7 struct7_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct8));
		this.intptr_2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Struct7)));
		Marshal.StructureToPtr(struct7_0, this.intptr_2, false);
		this.enum2_0 = Enum2.const_0;
		this.intptr_0 = IntPtr.Zero;
		this.intptr_1 = IntPtr.Zero;
		this.enum3_0 = Enum3.const_1;
		this.enum4_0 = Enum4.const_0;
		this.enum5_0 = Enum5.const_0;
		this.intptr_3 = IntPtr.Zero;
		this.intptr_4 = IntPtr.Zero;
		this.enum6_0 = Enum6.const_7;
		this.enum7_0 = Enum7.const_0;
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00048B10 File Offset: 0x00046D10
	public void Dispose()
	{
		if (this.enum2_0 == Enum2.const_0)
		{
			Struct7 @struct = default(Struct7);
			Marshal.PtrToStructure(this.intptr_2, @struct);
			@struct.Dispose();
			Marshal.DestroyStructure(this.intptr_2, typeof(Struct7));
		}
		Marshal.FreeHGlobal(this.intptr_2);
	}

	// Token: 0x040001F7 RID: 503
	public uint uint_0;

	// Token: 0x040001F8 RID: 504
	public IntPtr intptr_0;

	// Token: 0x040001F9 RID: 505
	public IntPtr intptr_1;

	// Token: 0x040001FA RID: 506
	public Enum3 enum3_0;

	// Token: 0x040001FB RID: 507
	public Enum4 enum4_0;

	// Token: 0x040001FC RID: 508
	public Enum2 enum2_0;

	// Token: 0x040001FD RID: 509
	public IntPtr intptr_2;

	// Token: 0x040001FE RID: 510
	public Enum5 enum5_0;

	// Token: 0x040001FF RID: 511
	public IntPtr intptr_3;

	// Token: 0x04000200 RID: 512
	private IntPtr intptr_4;

	// Token: 0x04000201 RID: 513
	public Enum6 enum6_0;

	// Token: 0x04000202 RID: 514
	public Enum7 enum7_0;
}
