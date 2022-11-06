using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000060 RID: 96
public class GClass39
{
	// Token: 0x06000327 RID: 807 RVA: 0x0004C774 File Offset: 0x0004A974
	public static string smethod_0(string string_0)
	{
		if (string_0 != null)
		{
			//goto IL_4A;
		}
		IL_0C:
		int num = 1226832325;
		IL_11:
		int num2 = num;
		switch (((~(1357352391 - num2) * 1365712535) ^ -681671405) % 5)
		{
		case 0:
			IL_4A:
			num = (string_0.StartsWith("\\\\?\\") ? 844836459 : (-1177954969));
			goto IL_11;
		case 1:
			return string_0;
		case 2:
			goto IL_0C;
		case 3:
			return string_0;
		}
		return "\\\\?\\" + string_0;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0004C7EC File Offset: 0x0004A9EC
	public static void smethod_1(string string_0)
	{
		if (string_0 != null)
		{
			GClass39.DeleteFile(GClass39.smethod_0(string_0));
		}
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0004C808 File Offset: 0x0004AA08
	public static FileStream smethod_2(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0)
	{
		FileStream fileStream = null;
		if (string_0 == null)
		{
			return fileStream;
		}
		SafeFileHandle safeFileHandle = GClass39.CreateFile(GClass39.smethod_0(string_0), GClass39.smethod_7(fileAccess_0), GClass39.smethod_6(fileShare_0), IntPtr.Zero, GClass39.smethod_8(fileMode_0), (GClass39.GEnum19)0U, IntPtr.Zero);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!safeFileHandle.IsInvalid)
		{
			fileStream = new FileStream(safeFileHandle, fileAccess_0);
			if (fileMode_0 == FileMode.Append)
			{
				fileStream.Seek(0L, SeekOrigin.End);
			}
			return fileStream;
		}
		throw new Win32Exception(lastWin32Error);
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0004C878 File Offset: 0x0004AA78
	public static bool smethod_3(string string_0)
	{
		GClass39.Enum9 fileAttributes = GClass39.GetFileAttributes(GClass39.smethod_0(string_0));
		return fileAttributes != (GClass39.Enum9)(-1) && (fileAttributes & GClass39.Enum9.flag_3) != GClass39.Enum9.flag_3;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0004C8A4 File Offset: 0x0004AAA4
	public static void smethod_4(string string_0, string string_1, bool bool_0)
	{
		bool flag = GClass39.CopyFile(GClass39.smethod_0(string_0), GClass39.smethod_0(string_1), bool_0);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!flag)
		{
			throw new Win32Exception(lastWin32Error);
		}
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0004C8D4 File Offset: 0x0004AAD4
	public static void smethod_5(string string_0, string string_1, bool bool_0)
	{
		GClass39.smethod_4(string_0, string_1, bool_0);
		GClass39.smethod_1(string_0);
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
	private static GClass39.GEnum17 smethod_6(FileShare fileShare_0)
	{
		switch (fileShare_0)
		{
		case FileShare.None:
			return GClass39.GEnum17.flag_0;
		case FileShare.Read:
			return GClass39.GEnum17.flag_1;
		case FileShare.Write:
			return GClass39.GEnum17.flag_2;
		case FileShare.ReadWrite:
			return GClass39.GEnum17.flag_1 | GClass39.GEnum17.flag_2;
		case FileShare.Delete:
			return GClass39.GEnum17.flag_3;
		default:
			if (fileShare_0 == FileShare.Inheritable)
			{
				throw new NotSupportedException("Inheritible is not supported.");
			}
			throw new NotSupportedException();
		}
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0004C938 File Offset: 0x0004AB38
	private static GClass39.GEnum16 smethod_7(FileAccess fileAccess_0)
	{
		switch (fileAccess_0)
		{
		case FileAccess.Read:
			return (GClass39.GEnum16)2147483648U;
		case FileAccess.Write:
			return GClass39.GEnum16.flag_1;
		case FileAccess.ReadWrite:
			return (GClass39.GEnum16)3221225472U;
		default:
			throw new NotSupportedException();
		}
	}

	// Token: 0x0600032F RID: 815 RVA: 0x0004C970 File Offset: 0x0004AB70
	private static GClass39.GEnum18 smethod_8(FileMode fileMode_0)
	{
		switch (fileMode_0)
		{
		case FileMode.CreateNew:
			return GClass39.GEnum18.const_0;
		case FileMode.Create:
			return GClass39.GEnum18.const_1;
		case FileMode.Open:
			return GClass39.GEnum18.const_2;
		case FileMode.OpenOrCreate:
			return GClass39.GEnum18.const_3;
		case FileMode.Truncate:
			return GClass39.GEnum18.const_4;
		case FileMode.Append:
			return GClass39.GEnum18.const_3;
		default:
			throw new NotSupportedException();
		}
	}

	// Token: 0x06000330 RID: 816
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	// Token: 0x06000331 RID: 817
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern GClass39.Enum9 GetFileAttributes(string string_0);

	// Token: 0x06000332 RID: 818
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeFileHandle CreateFile(string string_0, GClass39.GEnum16 genum16_0, GClass39.GEnum17 genum17_0, IntPtr intptr_1, GClass39.GEnum18 genum18_0, GClass39.GEnum19 genum19_0, IntPtr intptr_2);

	// Token: 0x06000333 RID: 819
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CopyFile(string string_0, string string_1, bool bool_0);

	// Token: 0x040002BF RID: 703
	internal static IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x040002C0 RID: 704
	internal static int int_0 = 16;

	// Token: 0x02000061 RID: 97
	[Flags]
	internal enum Enum9
	{
		// Token: 0x040002C2 RID: 706
		flag_0 = 1,
		// Token: 0x040002C3 RID: 707
		flag_1 = 2,
		// Token: 0x040002C4 RID: 708
		flag_2 = 4,
		// Token: 0x040002C5 RID: 709
		flag_3 = 16,
		// Token: 0x040002C6 RID: 710
		flag_4 = 32,
		// Token: 0x040002C7 RID: 711
		flag_5 = 64,
		// Token: 0x040002C8 RID: 712
		flag_6 = 128,
		// Token: 0x040002C9 RID: 713
		flag_7 = 256,
		// Token: 0x040002CA RID: 714
		flag_8 = 512,
		// Token: 0x040002CB RID: 715
		flag_9 = 1024,
		// Token: 0x040002CC RID: 716
		flag_10 = 2048,
		// Token: 0x040002CD RID: 717
		flag_11 = 4096,
		// Token: 0x040002CE RID: 718
		flag_12 = 8192,
		// Token: 0x040002CF RID: 719
		flag_13 = 16384,
		// Token: 0x040002D0 RID: 720
		flag_14 = 65536
	}

	// Token: 0x02000062 RID: 98
	[Flags]
	public enum GEnum16 : uint
	{
		// Token: 0x040002D2 RID: 722
		flag_0 = 2147483648U,
		// Token: 0x040002D3 RID: 723
		flag_1 = 1073741824U,
		// Token: 0x040002D4 RID: 724
		flag_2 = 536870912U,
		// Token: 0x040002D5 RID: 725
		flag_3 = 268435456U
	}

	// Token: 0x02000063 RID: 99
	[Flags]
	public enum GEnum17 : uint
	{
		// Token: 0x040002D7 RID: 727
		flag_0 = 0U,
		// Token: 0x040002D8 RID: 728
		flag_1 = 1U,
		// Token: 0x040002D9 RID: 729
		flag_2 = 2U,
		// Token: 0x040002DA RID: 730
		flag_3 = 4U
	}

	// Token: 0x02000064 RID: 100
	public enum GEnum18 : uint
	{
		// Token: 0x040002DC RID: 732
		const_0 = 1U,
		// Token: 0x040002DD RID: 733
		const_1,
		// Token: 0x040002DE RID: 734
		const_2,
		// Token: 0x040002DF RID: 735
		const_3,
		// Token: 0x040002E0 RID: 736
		const_4
	}

	// Token: 0x02000065 RID: 101
	[Flags]
	public enum GEnum19 : uint
	{
		// Token: 0x040002E2 RID: 738
		flag_0 = 1U,
		// Token: 0x040002E3 RID: 739
		flag_1 = 2U,
		// Token: 0x040002E4 RID: 740
		flag_2 = 4U,
		// Token: 0x040002E5 RID: 741
		flag_3 = 16U,
		// Token: 0x040002E6 RID: 742
		flag_4 = 32U,
		// Token: 0x040002E7 RID: 743
		flag_5 = 64U,
		// Token: 0x040002E8 RID: 744
		flag_6 = 128U,
		// Token: 0x040002E9 RID: 745
		flag_7 = 256U,
		// Token: 0x040002EA RID: 746
		flag_8 = 512U,
		// Token: 0x040002EB RID: 747
		flag_9 = 1024U,
		// Token: 0x040002EC RID: 748
		flag_10 = 2048U,
		// Token: 0x040002ED RID: 749
		flag_11 = 4096U,
		// Token: 0x040002EE RID: 750
		flag_12 = 8192U,
		// Token: 0x040002EF RID: 751
		flag_13 = 16384U,
		// Token: 0x040002F0 RID: 752
		flag_14 = 2147483648U,
		// Token: 0x040002F1 RID: 753
		flag_15 = 1073741824U,
		// Token: 0x040002F2 RID: 754
		flag_16 = 536870912U,
		// Token: 0x040002F3 RID: 755
		flag_17 = 268435456U,
		// Token: 0x040002F4 RID: 756
		flag_18 = 134217728U,
		// Token: 0x040002F5 RID: 757
		flag_19 = 67108864U,
		// Token: 0x040002F6 RID: 758
		flag_20 = 33554432U,
		// Token: 0x040002F7 RID: 759
		flag_21 = 16777216U,
		// Token: 0x040002F8 RID: 760
		flag_22 = 2097152U,
		// Token: 0x040002F9 RID: 761
		flag_23 = 1048576U,
		// Token: 0x040002FA RID: 762
		flag_24 = 524288U
	}

	// Token: 0x02000066 RID: 102
	internal struct Struct10
	{
		// Token: 0x040002FB RID: 763
		internal uint uint_0;

		// Token: 0x040002FC RID: 764
		internal uint uint_1;
	}

	// Token: 0x02000067 RID: 103
	public struct GStruct1
	{
		// Token: 0x040002FD RID: 765
		public int int_0;

		// Token: 0x040002FE RID: 766
		public IntPtr intptr_0;

		// Token: 0x040002FF RID: 767
		public int int_1;
	}
}
