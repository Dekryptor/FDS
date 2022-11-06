using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000B6 RID: 182
public class GClass55
{
	// Token: 0x060005C4 RID: 1476
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(int int_0, bool bool_0, int int_1);

	// Token: 0x060005C5 RID: 1477
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int CloseHandle(IntPtr intptr_0);

	// Token: 0x060005C6 RID: 1478
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, ref uint uint_0);

	// Token: 0x060005C7 RID: 1479
	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	public static extern bool ReadProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, ref uint uint_1);

	// Token: 0x060005C8 RID: 1480
	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlGetUnloadEventTraceEx(out IntPtr intptr_0, out IntPtr intptr_1, out IntPtr intptr_2);

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00056058 File Offset: 0x00054258
	// (set) Token: 0x060005CA RID: 1482 RVA: 0x0005606C File Offset: 0x0005426C
	public List<GClass54> List_0 { get; private set; }

	// Token: 0x060005CB RID: 1483 RVA: 0x00056080 File Offset: 0x00054280
	public GClass55(Process process_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		if (process_0 == null)
		{
			throw new ArgumentNullException("Invalid argument");
		}
		this.List_0 = new List<GClass54>();
		IntPtr zero;
		IntPtr intPtr4;
		IntPtr intPtr3 = (intPtr4 = (zero = IntPtr.Zero));
		GClass55.RtlGetUnloadEventTraceEx(out intPtr3, out intPtr4, out zero);
		if (!(zero == IntPtr.Zero) && !(intPtr3 == IntPtr.Zero) && !(intPtr4 == IntPtr.Zero))
		{
			try
			{
				intPtr = GClass55.OpenProcess(1040, false, process_0.Id);
				byte[] array = new byte[8];
				uint num = 0U;
				if (GClass55.ReadProcessMemory_1(intPtr, intPtr3, array, 4U, ref num))
				{
					if (num == 4U)
					{
						ulong num2 = (ulong)BitConverter.ToUInt32(array, 0);
						if (num2 == 0UL)
						{
							throw new Exception("Invalid size");
						}
						if (GClass55.ReadProcessMemory_1(intPtr, intPtr4, array, 4U, ref num))
						{
							if (num == 4U)
							{
								ulong num3 = (ulong)BitConverter.ToUInt32(array, 0);
								if (num3 == 0UL)
								{
									throw new Exception("Invalid count");
								}
								bool flag = GClass49.smethod_17(process_0) == GClass49.GEnum45.const_1;
								IntPtr intPtr5 = IntPtr.Zero;
								if (flag)
								{
									if (GClass55.ReadProcessMemory_1(intPtr, zero, array, (uint)array.Length, ref num))
									{
										if ((ulong)num == (ulong)((long)array.Length))
										{
											intPtr5 = (IntPtr)BitConverter.ToInt32(array, 0);
											goto IL_16E;
										}
									}
									throw new Exception("Invalid address read");
								}
								if (GClass55.ReadProcessMemory_1(intPtr, zero, array, 4U, ref num))
								{
									if (num == 4U)
									{
										intPtr5 = (IntPtr)BitConverter.ToInt32(array, 0);
										goto IL_16E;
									}
								}
								throw new Exception("Invalid address read");
								IL_16E:
								if (intPtr5 == IntPtr.Zero)
								{
									throw new Exception("Invalid address");
								}
								int num4 = (int)(num3 * num2);
								intPtr2 = Marshal.AllocHGlobal(num4);
								if (GClass55.ReadProcessMemory(intPtr, intPtr5, intPtr2, num4, ref num))
								{
									if ((ulong)num == (ulong)((long)num4))
									{
										for (ulong num5 = 0UL; num5 < num3; num5 += 1UL)
										{
											GStruct26 gstruct = (GStruct26)Marshal.PtrToStructure((IntPtr)(intPtr2.ToInt64() + (long)(num5 * num2)), typeof(GStruct26));
											if (gstruct.intptr_0 != IntPtr.Zero || gstruct.uint_2 != 0U || (gstruct.char_0 != null && gstruct.char_0.Length != 0))
											{
												GClass54 gclass = new GClass54(gstruct);
												this.List_0.Add(gclass);
											}
										}
										return;
									}
								}
								throw new Exception("Invalid struct read");
							}
						}
						throw new Exception("Invalid count read");
					}
				}
				throw new Exception("Invalid size read");
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					GClass55.CloseHandle(intPtr);
				}
				if (intPtr2 != IntPtr.Zero)
				{
					try
					{
						Marshal.FreeHGlobal(intPtr2);
					}
					catch
					{
					}
				}
			}
		}
		throw new Exception("Invalid loader");
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00056374 File Offset: 0x00054574
	public static string smethod_0(List<GClass54> list_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<string> list = new List<string>();
		for (int i = 0; i < list_1.Count; i++)
		{
			if ((list_1[i].String_0 != null && !(list_1[i].String_0 == string.Empty)) || list_1[i].GStruct26_0.uint_2 != 0U)
			{
				string text = string.Concat(new string[]
				{
					Class15.smethod_22(list_1[i].String_0),
					Class15.char_2.ToString(),
					list_1[i].GStruct26_0.uint_2.ToString(),
					Class15.char_2.ToString(),
					Class15.smethod_1(list_1[i].List_0, Class15.char_1)
				});
				if (!Class15.smethod_30(list, text, false))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(Class15.char_0);
					}
					list.Add(text);
					stringBuilder.Append(text);
				}
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0400092B RID: 2347
	[CompilerGenerated]
	private List<GClass54> list_0;

	// Token: 0x020000B7 RID: 183
	[Flags]
	public enum GEnum50 : uint
	{
		// Token: 0x0400092D RID: 2349
		flag_0 = 2035711U,
		// Token: 0x0400092E RID: 2350
		flag_1 = 1U,
		// Token: 0x0400092F RID: 2351
		flag_2 = 2U,
		// Token: 0x04000930 RID: 2352
		flag_3 = 8U,
		// Token: 0x04000931 RID: 2353
		flag_4 = 16U,
		// Token: 0x04000932 RID: 2354
		flag_5 = 32U,
		// Token: 0x04000933 RID: 2355
		flag_6 = 64U,
		// Token: 0x04000934 RID: 2356
		flag_7 = 512U,
		// Token: 0x04000935 RID: 2357
		flag_8 = 1024U,
		// Token: 0x04000936 RID: 2358
		flag_9 = 1048576U
	}
}
