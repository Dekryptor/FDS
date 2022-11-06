using System;
using System.Runtime.InteropServices;

// Token: 0x0200003D RID: 61
internal struct Struct7 : IDisposable
{
	// Token: 0x060001B6 RID: 438 RVA: 0x000489AC File Offset: 0x00046BAC
	public Struct7(string string_1, Guid guid_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct7));
		this.string_0 = string_1;
		if (guid_0 != Guid.Empty)
		{
			this.intptr_1 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid)));
			Marshal.StructureToPtr(guid_0, this.intptr_1, true);
		}
		else
		{
			this.intptr_1 = IntPtr.Zero;
		}
		this.intptr_0 = IntPtr.Zero;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00048A28 File Offset: 0x00046C28
	public void Dispose()
	{
		if (this.intptr_1 == IntPtr.Zero)
		{
			return;
		}
		Marshal.DestroyStructure(this.intptr_1, typeof(Guid));
		Marshal.FreeHGlobal(this.intptr_1);
	}

	// Token: 0x040001CD RID: 461
	public uint uint_0;

	// Token: 0x040001CE RID: 462
	[MarshalAs(UnmanagedType.LPTStr)]
	public string string_0;

	// Token: 0x040001CF RID: 463
	public IntPtr intptr_0;

	// Token: 0x040001D0 RID: 464
	public IntPtr intptr_1;
}
