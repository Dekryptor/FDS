using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

// Token: 0x0200005D RID: 93
public static class GClass38
{
	// Token: 0x0600031C RID: 796 RVA: 0x0004C4A8 File Offset: 0x0004A6A8
	public static void smethod_0(string string_1)
	{
		string text = string_1.ToLower();
		string text2 = string.Concat(new string[]
		{
			GClass38.string_0,
			GClass38.string_0,
			"?",
			GClass38.string_0,
			"unc"
		});
		bool flag = text.StartsWith(text2);
		List<string> list = new List<string>();
		list.AddRange(string_1.Split(new char[] { GClass38.char_0 }, StringSplitOptions.RemoveEmptyEntries));
		string text3 = GClass38.string_0 + GClass38.string_0 + "?" + GClass38.string_0;
		int i;
		if (flag)
		{
			text3 = string.Concat(new string[]
			{
				text3,
				"UNC",
				GClass38.string_0,
				list[2],
				GClass38.string_0
			});
			i = 3;
		}
		else
		{
			text3 = text3 + list[1] + GClass38.string_0;
			i = 2;
		}
		while (i < list.Count)
		{
			text3 = text3 + list[i] + GClass38.string_0;
			if (!GClass38.smethod_2(text3))
			{
				bool flag2 = GClass38.CreateDirectory(text3, IntPtr.Zero);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!flag2)
				{
					throw new Win32Exception(lastWin32Error);
				}
			}
			i++;
		}
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0004C5D8 File Offset: 0x0004A7D8
	public static void smethod_1(string string_1)
	{
		GClass38.Struct9 @struct;
		IntPtr intPtr = GClass38.FindFirstFile(string_1 + "\\*", out @struct);
		if (intPtr != GClass38.intptr_0)
		{
			int lastWin32Error;
			for (;;)
			{
				string text = @struct.string_0;
				if ((@struct.fileAttributes_0 & FileAttributes.Directory) == (FileAttributes)0)
				{
					GClass39.smethod_1(Path.Combine(string_1, text));
				}
				else if (text != "." && text != "..")
				{
					string text2 = Path.Combine(string_1, text);
					GClass38.smethod_1(text2);
					bool flag = GClass38.RemoveDirectory(text2);
					lastWin32Error = Marshal.GetLastWin32Error();
					if (!flag)
					{
						break;
					}
				}
				if (!GClass38.FindNextFile(intPtr, out @struct))
				{
					goto IL_8D;
				}
			}
			throw new Win32Exception(lastWin32Error);
		}
		IL_8D:
		GClass38.FindClose(intPtr);
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0004C67C File Offset: 0x0004A87C
	public static bool smethod_2(string string_1)
	{
		GClass38.Enum8 fileAttributes = GClass38.GetFileAttributes(string_1);
		return fileAttributes != (GClass38.Enum8)(-1) && (fileAttributes & GClass38.Enum8.flag_3) == GClass38.Enum8.flag_3;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0004C6A0 File Offset: 0x0004A8A0
	public static string[] smethod_3(string string_1)
	{
		List<string> list = new List<string>();
		GClass38.Struct9 @struct;
		IntPtr intPtr = GClass38.FindFirstFile(string_1 + "\\*", out @struct);
		if (intPtr != GClass38.intptr_0)
		{
			do
			{
				string text = @struct.string_0;
				if ((@struct.fileAttributes_0 & FileAttributes.Directory) != (FileAttributes)0)
				{
					if (text != "." && text != "..")
					{
						list.Add(Path.Combine(string_1, text));
					}
				}
				else
				{
					list.Add(Path.Combine(string_1, text));
				}
			}
			while (GClass38.FindNextFile(intPtr, out @struct));
		}
		GClass38.FindClose(intPtr);
		return list.ToArray();
	}

	// Token: 0x06000320 RID: 800
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	internal static extern IntPtr FindFirstFile(string string_1, out GClass38.Struct9 struct9_0);

	// Token: 0x06000321 RID: 801
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextFile(IntPtr intptr_1, out GClass38.Struct9 struct9_0);

	// Token: 0x06000322 RID: 802
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindClose(IntPtr intptr_1);

	// Token: 0x06000323 RID: 803
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern GClass38.Enum8 GetFileAttributes(string string_1);

	// Token: 0x06000324 RID: 804
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreateDirectory(string string_1, IntPtr intptr_1);

	// Token: 0x06000325 RID: 805
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RemoveDirectory(string string_1);

	// Token: 0x040002A0 RID: 672
	internal const int int_0 = 260;

	// Token: 0x040002A1 RID: 673
	internal static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x040002A2 RID: 674
	internal const int int_1 = 16;

	// Token: 0x040002A3 RID: 675
	private static readonly string string_0 = Path.DirectorySeparatorChar.ToString();

	// Token: 0x040002A4 RID: 676
	private static readonly char char_0 = Path.DirectorySeparatorChar;

	// Token: 0x0200005E RID: 94
	[Flags]
	internal enum Enum8
	{
		// Token: 0x040002A6 RID: 678
		flag_0 = 1,
		// Token: 0x040002A7 RID: 679
		flag_1 = 2,
		// Token: 0x040002A8 RID: 680
		flag_2 = 4,
		// Token: 0x040002A9 RID: 681
		flag_3 = 16,
		// Token: 0x040002AA RID: 682
		flag_4 = 32,
		// Token: 0x040002AB RID: 683
		flag_5 = 64,
		// Token: 0x040002AC RID: 684
		flag_6 = 128,
		// Token: 0x040002AD RID: 685
		flag_7 = 256,
		// Token: 0x040002AE RID: 686
		flag_8 = 512,
		// Token: 0x040002AF RID: 687
		flag_9 = 1024,
		// Token: 0x040002B0 RID: 688
		flag_10 = 2048,
		// Token: 0x040002B1 RID: 689
		flag_11 = 4096,
		// Token: 0x040002B2 RID: 690
		flag_12 = 8192,
		// Token: 0x040002B3 RID: 691
		flag_13 = 16384,
		// Token: 0x040002B4 RID: 692
		flag_14 = 65536
	}

	// Token: 0x0200005F RID: 95
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct9
	{
		// Token: 0x040002B5 RID: 693
		internal FileAttributes fileAttributes_0;

		// Token: 0x040002B6 RID: 694
		internal System.Runtime.InteropServices.ComTypes.FILETIME filetime_0;

		// Token: 0x040002B7 RID: 695
		internal System.Runtime.InteropServices.ComTypes.FILETIME filetime_1;

		// Token: 0x040002B8 RID: 696
		internal System.Runtime.InteropServices.ComTypes.FILETIME filetime_2;

		// Token: 0x040002B9 RID: 697
		internal int int_0;

		// Token: 0x040002BA RID: 698
		internal int int_1;

		// Token: 0x040002BB RID: 699
		internal int int_2;

		// Token: 0x040002BC RID: 700
		internal int int_3;

		// Token: 0x040002BD RID: 701
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		internal string string_0;

		// Token: 0x040002BE RID: 702
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		internal string string_1;
	}
}
