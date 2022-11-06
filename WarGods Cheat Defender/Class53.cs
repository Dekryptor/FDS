using System;
using System.Collections.Generic;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000E6 RID: 230
internal class Class53
{
	// Token: 0x06000766 RID: 1894
	[DllImport("iphlpapi.dll", CharSet = CharSet.Ansi)]
	private static extern int GetAdaptersInfo(IntPtr intptr_0, ref long long_0);

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x06000767 RID: 1895 RVA: 0x000668B4 File Offset: 0x00064AB4
	// (set) Token: 0x06000768 RID: 1896 RVA: 0x000668C8 File Offset: 0x00064AC8
	public string String_0 { get; set; }

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x06000769 RID: 1897 RVA: 0x000668DC File Offset: 0x00064ADC
	// (set) Token: 0x0600076A RID: 1898 RVA: 0x000668F0 File Offset: 0x00064AF0
	public string String_1 { get; set; }

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x0600076B RID: 1899 RVA: 0x00066904 File Offset: 0x00064B04
	// (set) Token: 0x0600076C RID: 1900 RVA: 0x00066918 File Offset: 0x00064B18
	public string String_2 { get; set; }

	// Token: 0x0600076D RID: 1901 RVA: 0x0006692C File Offset: 0x00064B2C
	public Class53(string string_3 = "", string string_4 = "", string string_5 = "")
	{
		this.String_0 = string_3;
		this.String_1 = string_4;
		this.String_2 = string_5;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00066954 File Offset: 0x00064B54
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			this.String_2
		});
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x000669B0 File Offset: 0x00064BB0
	public static string smethod_0(string string_3)
	{
		if (string_3 != null && !(string_3 == string.Empty))
		{
			string text = string_3.Replace('-', ':');
			int num = Class15.smethod_20(text, ":");
			if (num != 0)
			{
				if (num != 5)
				{
					return null;
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < text.Length; i++)
				{
					if (i > 0 && i % 2 == 0)
					{
						stringBuilder.Append(':');
					}
					stringBuilder.Append(text[i]);
				}
				text = stringBuilder.ToString();
			}
			return text;
		}
		return null;
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00066A30 File Offset: 0x00064C30
	public static string smethod_1()
	{
		List<Class53> list = new List<Class53>();
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(Class14.String_14, Class14.String_134).Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				try
				{
					string text = managementObject.GetPropertyValue(Class14.String_216).ToString().Trim()
						.ToUpper();
					text = Class53.smethod_0(text);
					if (text != null)
					{
						string text2 = managementObject.GetPropertyValue(Class14.String_226).ToString().Trim();
						string text3 = managementObject.GetPropertyValue(Class14.String_18).ToString().Trim();
						Class53 @class = new Class53(text3, text2, text);
						list.Add(@class);
					}
				}
				catch
				{
				}
			}
			if (list.Count == 0)
			{
				throw new InvalidProgramException();
			}
		}
		catch
		{
			try
			{
				foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
				{
					if (networkInterface.GetPhysicalAddress() != null)
					{
						string text = networkInterface.GetPhysicalAddress().ToString();
						if (text != null)
						{
							text = text.Trim();
							if (text.Length >= 12)
							{
								text = text.Trim().ToUpper();
								text = Class53.smethod_0(text);
								if (text != null)
								{
									string text3 = networkInterface.Name;
									if (text3 == null)
									{
										text3 = "";
									}
									string text2 = networkInterface.Description;
									if (text2 == null)
									{
										text2 = "";
									}
									Class53 @class = new Class53(text3, text2, text);
									list.Add(@class);
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}
		if (list.Count == 0)
		{
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				long num = (long)Marshal.SizeOf(typeof(Class53.Struct13));
				intPtr = Marshal.AllocHGlobal(new IntPtr(num));
				int num2 = Class53.GetAdaptersInfo(intPtr, ref num);
				if (num2 == 111)
				{
					intPtr = Marshal.ReAllocHGlobal(intPtr, new IntPtr(num));
					num2 = Class53.GetAdaptersInfo(intPtr, ref num);
				}
				if (num2 == 0)
				{
					IntPtr intPtr2 = intPtr;
					do
					{
						Class53.Struct13 @struct = (Class53.Struct13)Marshal.PtrToStructure(intPtr2, typeof(Class53.Struct13));
						string text4 = string.Empty;
						for (int j = 0; j < @struct.byte_0.Length - 1; j++)
						{
							text4 += string.Format("{0:X2}", @struct.byte_0[j]);
							if ((long)j != (long)((ulong)(@struct.uint_0 - 1U)))
							{
								text4 += "-";
							}
						}
						if (text4.Length > 0)
						{
							string text = Class53.smethod_0(text4);
							if (text != null)
							{
								Class53 @class = new Class53(@struct.string_0, @struct.string_1, text);
								list.Add(@class);
							}
						}
						intPtr2 = @struct.intptr_0;
					}
					while (intPtr2 != IntPtr.Zero);
				}
			}
			catch
			{
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
		}
		if (list.Count == 0)
		{
			Class53 @class = new Class53("", "", "");
			list.Add(@class);
		}
		for (int k = 0; k < list.Count; k++)
		{
			stringBuilder.Append(list[k].ToString());
			if (k + 1 != list.Count)
			{
				stringBuilder.Append(Class15.char_1);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x040009EE RID: 2542
	private const int int_0 = 128;

	// Token: 0x040009EF RID: 2543
	private const int int_1 = 111;

	// Token: 0x040009F0 RID: 2544
	private const int int_2 = 256;

	// Token: 0x040009F1 RID: 2545
	private const int int_3 = 8;

	// Token: 0x040009F2 RID: 2546
	private const int int_4 = 1;

	// Token: 0x040009F3 RID: 2547
	private const int int_5 = 6;

	// Token: 0x040009F4 RID: 2548
	private const int int_6 = 9;

	// Token: 0x040009F5 RID: 2549
	private const int int_7 = 15;

	// Token: 0x040009F6 RID: 2550
	private const int int_8 = 23;

	// Token: 0x040009F7 RID: 2551
	private const int int_9 = 24;

	// Token: 0x040009F8 RID: 2552
	private const int int_10 = 28;

	// Token: 0x040009F9 RID: 2553
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009FA RID: 2554
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009FB RID: 2555
	[CompilerGenerated]
	private string string_2;

	// Token: 0x020000E7 RID: 231
	private struct Struct11
	{
		// Token: 0x040009FC RID: 2556
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string string_0;
	}

	// Token: 0x020000E8 RID: 232
	private struct Struct12
	{
		// Token: 0x040009FD RID: 2557
		public IntPtr intptr_0;

		// Token: 0x040009FE RID: 2558
		public Class53.Struct11 struct11_0;

		// Token: 0x040009FF RID: 2559
		public Class53.Struct11 struct11_1;

		// Token: 0x04000A00 RID: 2560
		public int int_0;
	}

	// Token: 0x020000E9 RID: 233
	private struct Struct13
	{
		// Token: 0x04000A01 RID: 2561
		public IntPtr intptr_0;

		// Token: 0x04000A02 RID: 2562
		public int int_0;

		// Token: 0x04000A03 RID: 2563
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		// Token: 0x04000A04 RID: 2564
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string string_1;

		// Token: 0x04000A05 RID: 2565
		public uint uint_0;

		// Token: 0x04000A06 RID: 2566
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_0;

		// Token: 0x04000A07 RID: 2567
		public int int_1;

		// Token: 0x04000A08 RID: 2568
		public uint uint_1;

		// Token: 0x04000A09 RID: 2569
		public uint uint_2;

		// Token: 0x04000A0A RID: 2570
		public IntPtr intptr_1;

		// Token: 0x04000A0B RID: 2571
		public Class53.Struct12 struct12_0;

		// Token: 0x04000A0C RID: 2572
		public Class53.Struct12 struct12_1;

		// Token: 0x04000A0D RID: 2573
		public Class53.Struct12 struct12_2;

		// Token: 0x04000A0E RID: 2574
		public bool bool_0;

		// Token: 0x04000A0F RID: 2575
		public Class53.Struct12 struct12_3;

		// Token: 0x04000A10 RID: 2576
		public Class53.Struct12 struct12_4;

		// Token: 0x04000A11 RID: 2577
		public int int_2;

		// Token: 0x04000A12 RID: 2578
		public int int_3;
	}
}
