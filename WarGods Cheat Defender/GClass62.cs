using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000F3 RID: 243
public class GClass62
{
	// Token: 0x17000340 RID: 832
	// (get) Token: 0x060007AF RID: 1967 RVA: 0x00067BEC File Offset: 0x00065DEC
	// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00067C00 File Offset: 0x00065E00
	public string String_0 { get; set; }

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00067C14 File Offset: 0x00065E14
	// (set) Token: 0x060007B2 RID: 1970 RVA: 0x00067C28 File Offset: 0x00065E28
	public IntPtr IntPtr_0 { get; set; }

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00067C3C File Offset: 0x00065E3C
	// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00067C50 File Offset: 0x00065E50
	public IntPtr IntPtr_1 { get; set; }

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00067C64 File Offset: 0x00065E64
	// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00067C78 File Offset: 0x00065E78
	public string String_1 { get; set; }

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00067C8C File Offset: 0x00065E8C
	// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00067CA0 File Offset: 0x00065EA0
	public GEnum55 GEnum55_0 { get; set; }

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00067CB4 File Offset: 0x00065EB4
	// (set) Token: 0x060007BA RID: 1978 RVA: 0x00067CC8 File Offset: 0x00065EC8
	public float Single_0 { get; set; }

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x060007BB RID: 1979 RVA: 0x00067CDC File Offset: 0x00065EDC
	// (set) Token: 0x060007BC RID: 1980 RVA: 0x00067CF0 File Offset: 0x00065EF0
	public IntPtr IntPtr_2 { get; set; }

	// Token: 0x060007BD RID: 1981 RVA: 0x00067D04 File Offset: 0x00065F04
	public GClass62()
	{
		this.String_0 = string.Empty;
		this.String_1 = null;
		this.IntPtr_0 = IntPtr.Zero;
		this.IntPtr_1 = IntPtr.Zero;
		this.GEnum55_0 = GEnum55.const_0;
		this.Single_0 = 0f;
		this.IntPtr_2 = IntPtr.Zero;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00067D5C File Offset: 0x00065F5C
	public static GClass62 smethod_0(byte[] byte_0)
	{
		if (byte_0 != null && (long)byte_0.Length >= (long)((ulong)GClass62.uint_0))
		{
			GClass62 gclass = new GClass62();
			gclass.IntPtr_0 = (IntPtr)BitConverter.ToInt32(byte_0, 0);
			gclass.IntPtr_1 = (IntPtr)BitConverter.ToInt32(byte_0, 4);
			gclass.GEnum55_0 = (GEnum55)BitConverter.ToInt32(byte_0, 8);
			try
			{
				gclass.Single_0 = (float)BitConverter.ToDouble(byte_0, 12);
			}
			catch (ArgumentException)
			{
			}
			gclass.IntPtr_2 = (IntPtr)BitConverter.ToInt32(byte_0, 16);
			return gclass;
		}
		return null;
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00067DEC File Offset: 0x00065FEC
	public static GClass62 smethod_1(IntPtr intptr_3, byte[] byte_0)
	{
		GClass62 gclass = GClass62.smethod_0(byte_0);
		if (gclass == null)
		{
			return gclass;
		}
		if (intptr_3 != IntPtr.Zero)
		{
			if (gclass.IntPtr_0 != IntPtr.Zero)
			{
				gclass.String_0 = GClass49.smethod_26(intptr_3, gclass.IntPtr_0, 256, true, "");
			}
			if (gclass.IntPtr_1 != IntPtr.Zero)
			{
				gclass.String_1 = GClass49.smethod_26(intptr_3, gclass.IntPtr_1, 256, true, "");
			}
		}
		return gclass;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00067E74 File Offset: 0x00066074
	public static GClass62[] smethod_2(IntPtr intptr_3, IntPtr intptr_4)
	{
		if (!(intptr_3 == IntPtr.Zero) && !(intptr_4 == IntPtr.Zero))
		{
			List<GClass62> list = new List<GClass62>();
			byte[] array = new byte[GClass62.uint_0];
			uint num = 0U;
			IntPtr intPtr = intptr_4;
			int num2 = 0;
			while ((long)num2 < (long)((ulong)GClass62.uint_1) && GClass45.ReadProcessMemory(intptr_3, intPtr, array, (uint)array.Length, ref num) && (ulong)num == (ulong)((long)array.Length))
			{
				GClass62 gclass = GClass62.smethod_1(intptr_3, array);
				if (gclass == null)
				{
					break;
				}
				list.Add(gclass);
				if (gclass.IntPtr_2 == IntPtr.Zero)
				{
					break;
				}
				intPtr = gclass.IntPtr_2;
				num2++;
			}
			return list.ToArray();
		}
		return null;
	}

	// Token: 0x04000AE7 RID: 2791
	public static readonly uint uint_0 = 20U;

	// Token: 0x04000AE8 RID: 2792
	public static readonly uint uint_1 = 1024U;

	// Token: 0x04000AE9 RID: 2793
	public static readonly uint uint_2 = 1024U;

	// Token: 0x04000AEA RID: 2794
	public static readonly uint uint_3 = 128U;

	// Token: 0x04000AEB RID: 2795
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000AEC RID: 2796
	[CompilerGenerated]
	private IntPtr intptr_0;

	// Token: 0x04000AED RID: 2797
	[CompilerGenerated]
	private IntPtr intptr_1;

	// Token: 0x04000AEE RID: 2798
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04000AEF RID: 2799
	[CompilerGenerated]
	private GEnum55 genum55_0;

	// Token: 0x04000AF0 RID: 2800
	[CompilerGenerated]
	private float float_0;

	// Token: 0x04000AF1 RID: 2801
	[CompilerGenerated]
	private IntPtr intptr_2;
}
