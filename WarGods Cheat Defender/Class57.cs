using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000F2 RID: 242
internal class Class57
{
	// Token: 0x1700033B RID: 827
	// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00067944 File Offset: 0x00065B44
	// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00067958 File Offset: 0x00065B58
	public IntPtr IntPtr_0 { get; set; }

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0006796C File Offset: 0x00065B6C
	// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00067980 File Offset: 0x00065B80
	public string String_0 { get; set; }

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00067994 File Offset: 0x00065B94
	// (set) Token: 0x060007A5 RID: 1957 RVA: 0x000679A8 File Offset: 0x00065BA8
	public IntPtr IntPtr_1 { get; set; }

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000679BC File Offset: 0x00065BBC
	// (set) Token: 0x060007A7 RID: 1959 RVA: 0x000679D0 File Offset: 0x00065BD0
	public IntPtr IntPtr_2 { get; set; }

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x060007A8 RID: 1960 RVA: 0x000679E4 File Offset: 0x00065BE4
	// (set) Token: 0x060007A9 RID: 1961 RVA: 0x000679F8 File Offset: 0x00065BF8
	public uint UInt32_0 { get; set; }

	// Token: 0x060007AA RID: 1962 RVA: 0x00067A0C File Offset: 0x00065C0C
	public Class57()
	{
		this.IntPtr_0 = IntPtr.Zero;
		this.String_0 = string.Empty;
		this.IntPtr_1 = IntPtr.Zero;
		this.IntPtr_2 = IntPtr.Zero;
		this.UInt32_0 = 0U;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00067A54 File Offset: 0x00065C54
	public static Class57 smethod_0(byte[] byte_0)
	{
		if (byte_0 != null && (long)byte_0.Length >= 16L)
		{
			return new Class57
			{
				IntPtr_0 = (IntPtr)BitConverter.ToInt32(byte_0, 0),
				IntPtr_1 = (IntPtr)BitConverter.ToInt32(byte_0, 4),
				IntPtr_2 = (IntPtr)BitConverter.ToInt32(byte_0, 8),
				UInt32_0 = (uint)BitConverter.ToInt32(byte_0, 12)
			};
		}
		return null;
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00067AC0 File Offset: 0x00065CC0
	public static Class57 smethod_1(IntPtr intptr_3, byte[] byte_0)
	{
		Class57 @class = Class57.smethod_0(byte_0);
		if (@class == null)
		{
			return @class;
		}
		if (intptr_3 != IntPtr.Zero && @class.IntPtr_1 != IntPtr.Zero)
		{
			@class.String_0 = GClass49.smethod_26(intptr_3, @class.IntPtr_1, 256, true, "");
		}
		return @class;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00067B18 File Offset: 0x00065D18
	public static Class57[] smethod_2(IntPtr intptr_3, IntPtr intptr_4)
	{
		if (!(intptr_3 == IntPtr.Zero) && !(intptr_4 == IntPtr.Zero))
		{
			List<Class57> list = new List<Class57>();
			byte[] array = new byte[16];
			uint num = 0U;
			int num2 = 0;
			IntPtr intPtr = intptr_4;
			while ((long)num2 < (long)((ulong)Class57.uint_1) && GClass45.ReadProcessMemory(intptr_3, intPtr, array, (uint)array.Length, ref num))
			{
				if ((ulong)num != (ulong)((long)array.Length))
				{
					break;
				}
				Class57 @class = Class57.smethod_1(intptr_3, array);
				if (@class == null)
				{
					break;
				}
				list.Add(@class);
				if (@class.IntPtr_0 == IntPtr.Zero)
				{
					break;
				}
				intPtr = @class.IntPtr_0;
				num2++;
			}
			return list.ToArray();
		}
		return null;
	}

	// Token: 0x04000ADE RID: 2782
	public const uint uint_0 = 16U;

	// Token: 0x04000ADF RID: 2783
	public static readonly uint uint_1 = 1024U;

	// Token: 0x04000AE0 RID: 2784
	public static readonly uint uint_2 = 1024U;

	// Token: 0x04000AE1 RID: 2785
	public static readonly uint uint_3 = 128U;

	// Token: 0x04000AE2 RID: 2786
	[CompilerGenerated]
	private IntPtr intptr_0;

	// Token: 0x04000AE3 RID: 2787
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000AE4 RID: 2788
	[CompilerGenerated]
	private IntPtr intptr_1;

	// Token: 0x04000AE5 RID: 2789
	[CompilerGenerated]
	private IntPtr intptr_2;

	// Token: 0x04000AE6 RID: 2790
	[CompilerGenerated]
	private uint uint_4;
}
