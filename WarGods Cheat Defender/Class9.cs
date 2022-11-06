using System;
using System.Runtime.InteropServices;

// Token: 0x02000046 RID: 70
internal sealed class Class9 : IDisposable
{
	// Token: 0x060001BA RID: 442 RVA: 0x00048B68 File Offset: 0x00046D68
	internal Class9(IntPtr intptr_1, Enum1 enum1_1)
	{
		this.enum1_0 = enum1_1;
		this.intptr_0 = intptr_1;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00048B8C File Offset: 0x00046D8C
	~Class9()
	{
		this.method_0(false);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00048BBC File Offset: 0x00046DBC
	private void method_0(bool bool_0)
	{
		if (this.intptr_0 != IntPtr.Zero)
		{
			if (this.enum1_0 != Enum1.const_0)
			{
				if (this.enum1_0 == Enum1.const_1)
				{
					Marshal.FreeCoTaskMem(this.intptr_0);
				}
			}
			else
			{
				Marshal.FreeHGlobal(this.intptr_0);
			}
			this.intptr_0 = IntPtr.Zero;
		}
		if (bool_0)
		{
			GC.SuppressFinalize(this);
		}
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00048C18 File Offset: 0x00046E18
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00048C2C File Offset: 0x00046E2C
	public static IntPtr smethod_0(Class9 class9_0)
	{
		return class9_0.intptr_0;
	}

	// Token: 0x04000203 RID: 515
	private IntPtr intptr_0;

	// Token: 0x04000204 RID: 516
	private Enum1 enum1_0;
}
