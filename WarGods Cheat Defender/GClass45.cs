using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000073 RID: 115
public class GClass45
{
	// Token: 0x060003A9 RID: 937
	[DllImport("USER32.DLL")]
	public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_2);

	// Token: 0x060003AA RID: 938
	[DllImport("user32.dll")]
	public static extern int EnumChildWindows(IntPtr intptr_0, GClass45.GDelegate0 gdelegate0_0, int int_2);

	// Token: 0x060003AB RID: 939
	[DllImport("user32.dll")]
	public static extern int EnumWindows(GClass45.GDelegate1 gdelegate1_0, int int_2);

	// Token: 0x060003AC RID: 940
	[DllImport("USER32.DLL")]
	public static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_2);

	// Token: 0x060003AD RID: 941
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowInfo(IntPtr intptr_0, ref GClass45.GStruct3 gstruct3_0);

	// Token: 0x060003AE RID: 942
	[DllImport("user32.dll", SetLastError = true)]
	public static extern uint GetWindowThreadProcessId(IntPtr intptr_0, out uint uint_19);

	// Token: 0x060003AF RID: 943
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GlobalMemoryStatusEx([In] [Out] GClass45.GClass46 gclass46_0);

	// Token: 0x060003B0 RID: 944
	[DllImport("kernel32.dll")]
	public static extern long GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_19, ref uint uint_20, ref uint uint_21, ref uint uint_22, StringBuilder stringBuilder_1, uint uint_23);

	// Token: 0x060003B1 RID: 945
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process([In] IntPtr intptr_0, ref bool bool_1);

	// Token: 0x060003B2 RID: 946
	[DllImport("psapi.dll", SetLastError = true)]
	public static extern uint GetMappedFileName(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, uint uint_19);

	// Token: 0x060003B3 RID: 947
	[DllImport("kernel32.dll", EntryPoint = "GetMappedFileName", SetLastError = true)]
	public static extern uint GetMappedFileName_1(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, uint uint_19);

	// Token: 0x060003B4 RID: 948
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string string_0);

	// Token: 0x060003B5 RID: 949
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string string_0);

	// Token: 0x060003B6 RID: 950
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool FreeLibrary(IntPtr intptr_0);

	// Token: 0x060003B7 RID: 951
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	// Token: 0x060003B8 RID: 952
	[DllImport("kernel32", EntryPoint = "GetProcAddress", SetLastError = true)]
	public static extern IntPtr GetProcAddress_1(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x060003B9 RID: 953
	[DllImport("Kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_19, ref uint uint_20);

	// Token: 0x060003BA RID: 954
	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern uint NtReadVirtualMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_19, ref uint uint_20);

	// Token: 0x060003BB RID: 955
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool QueryFullProcessImageName([In] IntPtr intptr_0, [In] int int_2, [Out] StringBuilder stringBuilder_0, ref int int_3);

	// Token: 0x060003BC RID: 956
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(int int_2, bool bool_1, int int_3);

	// Token: 0x060003BD RID: 957
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int CloseHandle(IntPtr intptr_0);

	// Token: 0x060003BE RID: 958
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out GClass45.GStruct4 gstruct4_0, int int_2);

	// Token: 0x060003BF RID: 959
	[DllImport("kernel32", SetLastError = true)]
	public static extern void GetSystemInfo(ref GClass45.GStruct5 gstruct5_0);

	// Token: 0x060003C0 RID: 960
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetCurrentProcess();

	// Token: 0x060003C1 RID: 961
	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool OpenProcessToken(IntPtr intptr_0, uint uint_19, out IntPtr intptr_1);

	// Token: 0x060003C2 RID: 962
	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool LookupPrivilegeValue(string string_0, string string_1, out GClass45.GStruct6 gstruct6_0);

	// Token: 0x060003C3 RID: 963
	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AdjustTokenPrivileges(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, ref GClass45.GStruct7 gstruct7_0, uint uint_19, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x060003C4 RID: 964
	[DllImport("kernel32.dll")]
	private static extern GClass45.GEnum29 SetErrorMode(GClass45.GEnum29 genum29_0);

	// Token: 0x060003C5 RID: 965 RVA: 0x0004E9B0 File Offset: 0x0004CBB0
	public static bool smethod_0(string string_0, bool bool_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			intPtr = GClass45.OpenProcess(1040, false, currentProcess.Id);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			if (!GClass45.OpenProcessToken(GClass45.GetCurrentProcess(), 40U, out zero))
			{
				return false;
			}
			GClass45.GStruct6 gstruct;
			if (!GClass45.LookupPrivilegeValue(null, string_0, out gstruct))
			{
				return false;
			}
			GClass45.GStruct7 gstruct2;
			gstruct2.uint_0 = 1U;
			gstruct2.gstruct6_0 = gstruct;
			if (!bool_1)
			{
				gstruct2.uint_1 = 4U;
			}
			else
			{
				gstruct2.uint_1 = 2U;
			}
			if (GClass45.AdjustTokenPrivileges(zero, false, ref gstruct2, 0U, IntPtr.Zero, IntPtr.Zero))
			{
				return true;
			}
			return false;
		}
		catch
		{
		}
		finally
		{
			if (zero != IntPtr.Zero)
			{
				GClass45.CloseHandle(zero);
			}
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return false;
	}

	// Token: 0x060003C6 RID: 966
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenThread(uint uint_19, bool bool_1, uint uint_20);

	// Token: 0x060003C7 RID: 967
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool GetThreadContext(IntPtr intptr_0, ref GClass45.GStruct12 gstruct12_0);

	// Token: 0x060003C8 RID: 968
	[DllImport("kernel32.dll", EntryPoint = "GetThreadContext", SetLastError = true)]
	public static extern bool GetThreadContext_1(IntPtr intptr_0, ref GClass45.GStruct15 gstruct15_0);

	// Token: 0x060003C9 RID: 969
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool Wow64GetThreadContext(IntPtr intptr_0, ref GClass45.GStruct10 gstruct10_0);

	// Token: 0x060003CA RID: 970
	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern int ZwQueryInformationThread(IntPtr intptr_0, GClass45.GEnum33 genum33_0, IntPtr intptr_1, int int_2, IntPtr intptr_2);

	// Token: 0x060003CB RID: 971
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetTokenInformation(IntPtr intptr_0, GClass45.Enum10 enum10_0, IntPtr intptr_1, int int_2, out int int_3);

	// Token: 0x060003CC RID: 972 RVA: 0x0004EAB0 File Offset: 0x0004CCB0
	private static bool smethod_1()
	{
		return Marshal.SizeOf(typeof(IntPtr)) == 8;
	}

	// Token: 0x060003CD RID: 973
	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern uint NtQuerySystemInformation(int int_2, IntPtr intptr_0, int int_3, ref int int_4);

	// Token: 0x060003CE RID: 974
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DuplicateHandle(IntPtr intptr_0, ushort ushort_0, IntPtr intptr_1, out IntPtr intptr_2, uint uint_19, [MarshalAs(UnmanagedType.Bool)] bool bool_1, uint uint_20);

	// Token: 0x060003CF RID: 975
	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern int NtQueryObject(IntPtr intptr_0, int int_2, IntPtr intptr_1, int int_3, ref int int_4);

	// Token: 0x060003D0 RID: 976
	[DllImport("kernel32.dll")]
	private static extern GClass45.Enum12 GetFileType(IntPtr intptr_0);

	// Token: 0x060003D1 RID: 977 RVA: 0x0004EAD0 File Offset: 0x0004CCD0
	public static GClass45.GClass48 smethod_2(GClass45.GStruct16 gstruct16_0, IntPtr intptr_0, List<string> list_0)
	{
		GClass45.GStruct18 gstruct = default(GClass45.GStruct18);
		GClass45.GStruct20 gstruct2 = default(GClass45.GStruct20);
		GClass45.GStruct21 gstruct3 = default(GClass45.GStruct21);
		string text = null;
		int num = 0;
		int num2 = 100;
		IntPtr zero = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		GClass45.GClass48 gclass = null;
		try
		{
			if (gstruct16_0.uint_0 == 1180063U)
			{
				return gclass;
			}
			if (!GClass45.DuplicateHandle(intptr_0, gstruct16_0.ushort_0, GClass45.GetCurrentProcess(), out zero, 0U, false, 2U))
			{
				return gclass;
			}
			num = Marshal.SizeOf(gstruct);
			intPtr = Marshal.AllocHGlobal(num);
			int num3 = 0;
			int num4;
			while ((num4 = GClass45.NtQueryObject(zero, 0, intPtr, num, ref num)) == -1073741820 && ++num3 < num2)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
				if (num == 0)
				{
					break;
				}
				intPtr = Marshal.AllocHGlobal(num);
				if (intPtr == IntPtr.Zero)
				{
					break;
				}
			}
			if (num == 0 || intPtr == IntPtr.Zero || num3 >= num2 || (long)num4 != 0L)
			{
				return gclass;
			}
			gstruct = (GClass45.GStruct18)Marshal.PtrToStructure(intPtr, gstruct.GetType());
			Marshal.FreeHGlobal(intPtr);
			intPtr = IntPtr.Zero;
			num = gstruct.int_10;
			intPtr2 = Marshal.AllocHGlobal(num);
			num3 = 0;
			while ((num4 = GClass45.NtQueryObject(zero, 2, intPtr2, num, ref num)) == -1073741820 && ++num3 < num2)
			{
				Marshal.FreeHGlobal(intPtr2);
				intPtr2 = IntPtr.Zero;
				if (num == 0)
				{
					break;
				}
				intPtr2 = Marshal.AllocHGlobal(num);
				if (intPtr2 == IntPtr.Zero)
				{
					break;
				}
			}
			if (num == 0 || intPtr2 == IntPtr.Zero || num3 >= num2 || (long)num4 != 0L)
			{
				return gclass;
			}
			gstruct2 = (GClass45.GStruct20)Marshal.PtrToStructure(intPtr2, gstruct2.GetType());
			IntPtr intPtr4;
			if (GClass45.smethod_1())
			{
				intPtr4 = new IntPtr(Convert.ToInt64(gstruct2.gstruct22_0.intptr_0.ToString(), 10) >> 32);
			}
			else
			{
				intPtr4 = gstruct2.gstruct22_0.intptr_0;
			}
			string text2 = Marshal.PtrToStringUni(intPtr4, gstruct2.gstruct22_0.ushort_0 >> 1);
			if (text2 == null)
			{
				return gclass;
			}
			text2 = text2.ToLower();
			if (list_0 != null && list_0.Count > 0 && !list_0.Contains(text2))
			{
				return gclass;
			}
			GClass45.GEnum36 genum;
			if (!(text2 == "file"))
			{
				if (text2 == "key")
				{
					genum = GClass45.GEnum36.const_2;
				}
				else if (text2 == "section")
				{
					genum = GClass45.GEnum36.const_3;
				}
				else if (!(text2 == "mutant"))
				{
					if (text2 == "event")
					{
						genum = GClass45.GEnum36.const_5;
					}
					else if (text2 == "semaphore")
					{
						genum = GClass45.GEnum36.const_6;
					}
					else
					{
						if (!(text2 == "alpc port"))
						{
							return gclass;
						}
						genum = GClass45.GEnum36.const_7;
					}
				}
				else
				{
					genum = GClass45.GEnum36.const_4;
				}
			}
			else
			{
				if (GClass45.GetFileType(zero) != GClass45.Enum12.const_1)
				{
					return gclass;
				}
				genum = GClass45.GEnum36.const_1;
			}
			num = gstruct.int_9;
			intPtr3 = Marshal.AllocHGlobal(num);
			num3 = 0;
			while ((num4 = GClass45.NtQueryObject(zero, 1, intPtr3, num, ref num)) == -1073741820 && ++num3 < num2)
			{
				Marshal.FreeHGlobal(intPtr3);
				intPtr3 = IntPtr.Zero;
				if (num == 0)
				{
					break;
				}
				intPtr3 = Marshal.AllocHGlobal(num);
				if (intPtr3 == IntPtr.Zero)
				{
					break;
				}
			}
			if (num == 0 || intPtr3 == IntPtr.Zero || num3 >= num2 || (long)num4 != 0L)
			{
				return gclass;
			}
			gstruct3 = (GClass45.GStruct21)Marshal.PtrToStructure(intPtr3, gstruct3.GetType());
			if (GClass45.smethod_1())
			{
				intPtr4 = new IntPtr(Convert.ToInt64(gstruct3.gstruct22_0.intptr_0.ToString(), 10) >> 32);
			}
			else
			{
				intPtr4 = gstruct3.gstruct22_0.intptr_0;
			}
			if (intPtr4 != IntPtr.Zero)
			{
				byte[] array = new byte[num];
				try
				{
					Marshal.Copy(intPtr4, array, 0, num);
					text = Marshal.PtrToStringUni(GClass45.smethod_1() ? new IntPtr(intPtr4.ToInt64()) : new IntPtr(intPtr4.ToInt32()));
				}
				catch (AccessViolationException)
				{
					text = null;
				}
			}
			if (text != null && text != string.Empty)
			{
				gclass = new GClass45.GClass48
				{
					GEnum36_0 = genum
				};
				if (gclass.GEnum36_0 == GClass45.GEnum36.const_1)
				{
					gclass.String_0 = GClass45.smethod_6(text);
				}
				else
				{
					gclass.String_0 = text;
				}
			}
		}
		catch
		{
		}
		finally
		{
			try
			{
				if (zero != IntPtr.Zero)
				{
					GClass45.CloseHandle(zero);
				}
				if (intPtr3 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr3);
				}
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr2);
				}
			}
			catch
			{
			}
		}
		return gclass;
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x0004F030 File Offset: 0x0004D230
	public static List<GClass45.GStruct16> smethod_3(Process process_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		int num = 100;
		List<GClass45.GStruct16> list = new List<GClass45.GStruct16>();
		List<GClass45.GStruct16> list2;
		try
		{
			int num2 = 0;
			intPtr = Marshal.AllocHGlobal(num2);
			int num3 = 0;
			int num4;
			while ((num4 = (int)GClass45.NtQuerySystemInformation(16, intPtr, num2, ref num2)) == -1073741820 && ++num3 < num)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = IntPtr.Zero;
				if (num2 == 0)
				{
					break;
				}
				intPtr = Marshal.AllocHGlobal(num2);
				if (intPtr == IntPtr.Zero)
				{
					break;
				}
			}
			if (num2 != 0 && !(intPtr == IntPtr.Zero) && num3 < num && (long)num4 == 0L)
			{
				byte[] array = new byte[num2];
				Marshal.Copy(intPtr, array, 0, num2);
				long num5;
				if (GClass45.smethod_1())
				{
					num5 = Marshal.ReadInt64(intPtr);
					intPtr2 = new IntPtr(intPtr.ToInt64() + 8L);
				}
				else
				{
					num5 = (long)Marshal.ReadInt32(intPtr);
					intPtr2 = new IntPtr(intPtr.ToInt32() + 4);
				}
				for (long num6 = 0L; num6 < num5; num6 += 1L)
				{
					GClass45.GStruct16 gstruct = default(GClass45.GStruct16);
					if (!GClass45.smethod_1())
					{
						intPtr2 = new IntPtr(intPtr2.ToInt64() + (long)Marshal.SizeOf(gstruct));
						gstruct = (GClass45.GStruct16)Marshal.PtrToStructure(intPtr2, gstruct.GetType());
					}
					else
					{
						gstruct = (GClass45.GStruct16)Marshal.PtrToStructure(intPtr2, gstruct.GetType());
						intPtr2 = new IntPtr(intPtr2.ToInt64() + (long)Marshal.SizeOf(gstruct) + 8L);
					}
					if (gstruct.int_0 == process_0.Id)
					{
						list.Add(gstruct);
					}
				}
				return list;
			}
			list2 = list;
		}
		catch
		{
			return list;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		return list2;
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x0004F234 File Offset: 0x0004D434
	public static string smethod_4()
	{
		string text;
		try
		{
			text = WindowsIdentity.GetCurrent().User.Value;
		}
		catch
		{
			text = string.Empty;
		}
		return text;
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x0004F270 File Offset: 0x0004D470
	public static bool smethod_5()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			if (current == null)
			{
				throw new InvalidOperationException("Couldn't get the current user identity");
			}
			if (new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return true;
			}
			if (Environment.OSVersion.Platform != PlatformID.Win32NT || Environment.OSVersion.Version.Major < 6)
			{
				return true;
			}
		}
		catch
		{
		}
		int num = Marshal.SizeOf(typeof(int));
		IntPtr zero = IntPtr.Zero;
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		try
		{
			if (!GClass45.OpenProcessToken(GClass45.GetCurrentProcess(), 131080U, out zero))
			{
				return false;
			}
			if (!GClass45.GetTokenInformation(zero, GClass45.Enum10.const_17, intPtr, num, out num))
			{
				Exception exceptionForHR = Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error());
				throw new InvalidOperationException("Couldn't get token information", exceptionForHR);
			}
			switch (Marshal.ReadInt32(intPtr))
			{
			case 1:
				return false;
			case 2:
				return true;
			case 3:
				return true;
			default:
				return false;
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
			if (zero != IntPtr.Zero)
			{
				GClass45.CloseHandle(zero);
			}
		}
		return false;
	}

	// Token: 0x060003D5 RID: 981
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint QueryDosDevice(string string_0, StringBuilder stringBuilder_0, int int_2);

	// Token: 0x060003D6 RID: 982 RVA: 0x0004F3C4 File Offset: 0x0004D5C4
	public static string smethod_6(string string_0)
	{
		string text = string_0;
		try
		{
			string text2 = text.ToLower();
			if (text2.StartsWith("\\??\\"))
			{
				text = text.Substring(4);
			}
			else if (!text2.StartsWith("\\systemroot\\"))
			{
				foreach (string text3 in Environment.GetLogicalDrives())
				{
					StringBuilder stringBuilder = new StringBuilder(260);
					if (GClass45.QueryDosDevice(text3.Substring(0, 2), stringBuilder, 260) == 0U)
					{
						break;
					}
					string text4 = stringBuilder.ToString();
					if (text.StartsWith(text4))
					{
						text = text.Replace(text4, text3.Substring(0, 2));
						break;
					}
				}
			}
			else
			{
				text = Path.Combine(Environment.ExpandEnvironmentVariables("%SYSTEMROOT%"), text.Substring(12));
			}
			text = Path.GetFullPath(text);
		}
		catch
		{
		}
		return text;
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x0004F49C File Offset: 0x0004D69C
	public static string smethod_7(IntPtr intptr_0, IntPtr intptr_1)
	{
		if (!(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero))
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			string text = string.Empty;
			GClass45.GEnum29 genum = GClass45.SetErrorMode(GClass45.GEnum29.flag_1);
			try
			{
				if (GClass45.bool_0)
				{
					try
					{
						if (GClass45.GetMappedFileName(intptr_0, intptr_1, stringBuilder, (uint)stringBuilder.Capacity) > 0U)
						{
							text = GClass45.smethod_6(stringBuilder.ToString());
						}
						goto IL_CA;
					}
					catch
					{
						if (GClass45.GetMappedFileName_1(intptr_0, intptr_1, stringBuilder, (uint)stringBuilder.Capacity) > 0U)
						{
							GClass45.bool_0 = false;
							text = GClass45.smethod_6(stringBuilder.ToString());
						}
						goto IL_CA;
					}
				}
				try
				{
					if (GClass45.GetMappedFileName_1(intptr_0, intptr_1, stringBuilder, (uint)stringBuilder.Capacity) > 0U)
					{
						text = GClass45.smethod_6(stringBuilder.ToString());
					}
				}
				catch
				{
					if (GClass45.GetMappedFileName(intptr_0, intptr_1, stringBuilder, (uint)stringBuilder.Capacity) > 0U)
					{
						GClass45.bool_0 = true;
						text = GClass45.smethod_6(stringBuilder.ToString());
					}
				}
				IL_CA:;
			}
			catch
			{
			}
			GClass45.SetErrorMode(genum);
			return text;
		}
		return string.Empty;
	}

	// Token: 0x060003D8 RID: 984
	[DllImport("ntdll.dll")]
	public static extern int NtOpenDirectoryObject(out SafeFileHandle safeFileHandle_0, uint uint_19, ref GClass45.GStruct24 gstruct24_0);

	// Token: 0x060003D9 RID: 985
	[DllImport("ntdll.dll")]
	public static extern int NtQueryDirectoryObject(SafeFileHandle safeFileHandle_0, IntPtr intptr_0, int int_2, bool bool_1, bool bool_2, ref uint uint_19, out uint uint_20);

	// Token: 0x060003DA RID: 986 RVA: 0x0004F5B0 File Offset: 0x0004D7B0
	public static List<string> smethod_8(string string_0, int int_2 = 1024)
	{
		List<string> list = new List<string>();
		GClass45.GStruct24 gstruct = new GClass45.GStruct24(string_0, 0U);
		SafeFileHandle safeFileHandle;
		if (GClass45.NtOpenDirectoryObject(out safeFileHandle, 1U, ref gstruct) < 0)
		{
			return list;
		}
		int num = 1024;
		IntPtr intPtr = Marshal.AllocHGlobal(1024);
		uint num2 = 0U;
		uint num3 = 0U;
		int num4 = 0;
		while (num4 < int_2 && GClass45.NtQueryDirectoryObject(safeFileHandle, intPtr, num, true, num2 == 0U, ref num2, out num3) >= 0)
		{
			GClass45.GStruct23 gstruct2 = (GClass45.GStruct23)Marshal.PtrToStructure(intPtr, typeof(GClass45.GStruct23));
			try
			{
				string text = gstruct2.gstruct22_0.ToString();
				if (text != null && text.Length > 0)
				{
					list.Add(text);
				}
			}
			catch
			{
			}
			num4++;
		}
		Marshal.FreeHGlobal(intPtr);
		safeFileHandle.Dispose();
		return list;
	}

	// Token: 0x060003DB RID: 987
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetVolumeInformation", SetLastError = true)]
	public static extern int GetVolumeInformation_1(string string_0, StringBuilder stringBuilder_0, int int_2, out uint uint_19, out uint uint_20, out GClass45.GEnum40 genum40_0, StringBuilder stringBuilder_1, int int_3);

	// Token: 0x060003DC RID: 988
	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern int NtQueryInformationProcess(IntPtr intptr_0, int int_2, ref GClass45.GStruct25 gstruct25_0, int int_3, out int int_4);

	// Token: 0x060003DD RID: 989
	[DllImport("shell32.dll")]
	public static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, uint uint_19, IntPtr intptr_0, out IntPtr intptr_1);

	// Token: 0x060003DE RID: 990 RVA: 0x0004F684 File Offset: 0x0004D884
	public static string smethod_9(Guid guid_0, GClass45.GEnum41 genum41_0 = GClass45.GEnum41.flag_6)
	{
		IntPtr intPtr = IntPtr.Zero;
		string text = null;
		try
		{
			if (GClass45.SHGetKnownFolderPath(guid_0, (uint)genum41_0, IntPtr.Zero, out intPtr) == 0)
			{
				text = Marshal.PtrToStringUni(intPtr);
			}
		}
		catch (DllNotFoundException)
		{
		}
		catch (EntryPointNotFoundException)
		{
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intPtr);
				intPtr = IntPtr.Zero;
			}
		}
		return text;
	}

	// Token: 0x060003DF RID: 991
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetProcessDEPPolicy(IntPtr intptr_0, out GClass45.GEnum42 genum42_0, out bool bool_1);

	// Token: 0x060003E0 RID: 992
	[DllImport("USER32.DLL")]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	// Token: 0x04000398 RID: 920
	public const uint uint_0 = 1U;

	// Token: 0x04000399 RID: 921
	public const uint uint_1 = 2U;

	// Token: 0x0400039A RID: 922
	public const uint uint_2 = 4U;

	// Token: 0x0400039B RID: 923
	public const uint uint_3 = 2147483648U;

	// Token: 0x0400039C RID: 924
	public const uint uint_4 = 8U;

	// Token: 0x0400039D RID: 925
	public const uint uint_5 = 983040U;

	// Token: 0x0400039E RID: 926
	public const uint uint_6 = 131072U;

	// Token: 0x0400039F RID: 927
	public const uint uint_7 = 1U;

	// Token: 0x040003A0 RID: 928
	public const uint uint_8 = 2U;

	// Token: 0x040003A1 RID: 929
	public const uint uint_9 = 4U;

	// Token: 0x040003A2 RID: 930
	public const uint uint_10 = 8U;

	// Token: 0x040003A3 RID: 931
	public const uint uint_11 = 16U;

	// Token: 0x040003A4 RID: 932
	public const uint uint_12 = 32U;

	// Token: 0x040003A5 RID: 933
	public const uint uint_13 = 64U;

	// Token: 0x040003A6 RID: 934
	public const uint uint_14 = 128U;

	// Token: 0x040003A7 RID: 935
	public const uint uint_15 = 256U;

	// Token: 0x040003A8 RID: 936
	public const uint uint_16 = 131080U;

	// Token: 0x040003A9 RID: 937
	public const uint uint_17 = 983551U;

	// Token: 0x040003AA RID: 938
	public const int int_0 = 2;

	// Token: 0x040003AB RID: 939
	public const uint uint_18 = 4U;

	// Token: 0x040003AC RID: 940
	internal const int int_1 = 260;

	// Token: 0x040003AD RID: 941
	private static bool bool_0;

	// Token: 0x02000074 RID: 116
	// (Invoke) Token: 0x060003E4 RID: 996
	public delegate bool GDelegate0(IntPtr hwnd, int lParam);

	// Token: 0x02000075 RID: 117
	// (Invoke) Token: 0x060003E8 RID: 1000
	public delegate bool GDelegate1(IntPtr hwnd, int lParam);

	// Token: 0x02000076 RID: 118
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class GClass46
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x0004F6FC File Offset: 0x0004D8FC
		public GClass46()
		{
			this.uint_0 = (uint)Marshal.SizeOf(typeof(GClass45.GClass46));
		}

		// Token: 0x040003AE RID: 942
		public uint uint_0;

		// Token: 0x040003AF RID: 943
		public uint uint_1;

		// Token: 0x040003B0 RID: 944
		public ulong ulong_0;

		// Token: 0x040003B1 RID: 945
		public ulong ulong_1;

		// Token: 0x040003B2 RID: 946
		public ulong ulong_2;

		// Token: 0x040003B3 RID: 947
		public ulong ulong_3;

		// Token: 0x040003B4 RID: 948
		public ulong ulong_4;

		// Token: 0x040003B5 RID: 949
		public ulong ulong_5;

		// Token: 0x040003B6 RID: 950
		public ulong ulong_6;
	}

	// Token: 0x02000077 RID: 119
	public struct GStruct2
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x0004F724 File Offset: 0x0004D924
		public GStruct2(int int_4, int int_5, int int_6, int int_7)
		{
			this.int_0 = int_4;
			this.int_1 = int_5;
			this.int_2 = int_6;
			this.int_3 = int_7;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0004F750 File Offset: 0x0004D950
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0004F764 File Offset: 0x0004D964
		public int Int32_0
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_2 -= this.int_0 - value;
				this.int_0 = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0004F790 File Offset: 0x0004D990
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0004F7A4 File Offset: 0x0004D9A4
		public int Int32_1
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_3 -= this.int_1 - value;
				this.int_1 = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0004F7EC File Offset: 0x0004D9EC
		public int Int32_2
		{
			get
			{
				return this.int_3 - this.int_1;
			}
			set
			{
				this.int_3 = value + this.int_1;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0004F808 File Offset: 0x0004DA08
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0004F824 File Offset: 0x0004DA24
		public int Int32_3
		{
			get
			{
				return this.int_2 - this.int_0;
			}
			set
			{
				this.int_2 = value + this.int_0;
			}
		}

		// Token: 0x040003B7 RID: 951
		public int int_0;

		// Token: 0x040003B8 RID: 952
		public int int_1;

		// Token: 0x040003B9 RID: 953
		public int int_2;

		// Token: 0x040003BA RID: 954
		public int int_3;
	}

	// Token: 0x02000078 RID: 120
	public struct GStruct3
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x0004F840 File Offset: 0x0004DA40
		public GStruct3(bool? nullable_0)
		{
			this = default(GClass45.GStruct3);
			this.uint_0 = (uint)Marshal.SizeOf(typeof(GClass45.GStruct3));
		}

		// Token: 0x040003BB RID: 955
		public uint uint_0;

		// Token: 0x040003BC RID: 956
		public GClass45.GStruct2 gstruct2_0;

		// Token: 0x040003BD RID: 957
		public GClass45.GStruct2 gstruct2_1;

		// Token: 0x040003BE RID: 958
		public uint uint_1;

		// Token: 0x040003BF RID: 959
		public uint uint_2;

		// Token: 0x040003C0 RID: 960
		public uint uint_3;

		// Token: 0x040003C1 RID: 961
		public uint uint_4;

		// Token: 0x040003C2 RID: 962
		public uint uint_5;

		// Token: 0x040003C3 RID: 963
		public ushort ushort_0;

		// Token: 0x040003C4 RID: 964
		public ushort ushort_1;
	}

	// Token: 0x02000079 RID: 121
	[Flags]
	public enum GEnum24 : uint
	{
		// Token: 0x040003C6 RID: 966
		flag_0 = 2035711U,
		// Token: 0x040003C7 RID: 967
		flag_1 = 1U,
		// Token: 0x040003C8 RID: 968
		flag_2 = 2U,
		// Token: 0x040003C9 RID: 969
		flag_3 = 8U,
		// Token: 0x040003CA RID: 970
		flag_4 = 16U,
		// Token: 0x040003CB RID: 971
		flag_5 = 32U,
		// Token: 0x040003CC RID: 972
		flag_6 = 64U,
		// Token: 0x040003CD RID: 973
		flag_7 = 512U,
		// Token: 0x040003CE RID: 974
		flag_8 = 1024U,
		// Token: 0x040003CF RID: 975
		flag_9 = 1048576U
	}

	// Token: 0x0200007A RID: 122
	public struct GStruct4
	{
		// Token: 0x040003D0 RID: 976
		public IntPtr intptr_0;

		// Token: 0x040003D1 RID: 977
		public IntPtr intptr_1;

		// Token: 0x040003D2 RID: 978
		public uint uint_0;

		// Token: 0x040003D3 RID: 979
		public IntPtr intptr_2;

		// Token: 0x040003D4 RID: 980
		public uint uint_1;

		// Token: 0x040003D5 RID: 981
		public uint uint_2;

		// Token: 0x040003D6 RID: 982
		public uint uint_3;
	}

	// Token: 0x0200007B RID: 123
	public struct GStruct5
	{
		// Token: 0x040003D7 RID: 983
		public uint uint_0;

		// Token: 0x040003D8 RID: 984
		public uint uint_1;

		// Token: 0x040003D9 RID: 985
		public IntPtr intptr_0;

		// Token: 0x040003DA RID: 986
		public IntPtr intptr_1;

		// Token: 0x040003DB RID: 987
		public IntPtr intptr_2;

		// Token: 0x040003DC RID: 988
		public uint uint_2;

		// Token: 0x040003DD RID: 989
		public uint uint_3;

		// Token: 0x040003DE RID: 990
		public uint uint_4;

		// Token: 0x040003DF RID: 991
		public uint uint_5;

		// Token: 0x040003E0 RID: 992
		public uint uint_6;
	}

	// Token: 0x0200007C RID: 124
	public enum GEnum25 : uint
	{
		// Token: 0x040003E2 RID: 994
		const_0,
		// Token: 0x040003E3 RID: 995
		const_1,
		// Token: 0x040003E4 RID: 996
		const_2,
		// Token: 0x040003E5 RID: 997
		const_3 = 4U,
		// Token: 0x040003E6 RID: 998
		const_4 = 8U,
		// Token: 0x040003E7 RID: 999
		const_5 = 16U,
		// Token: 0x040003E8 RID: 1000
		const_6 = 32U,
		// Token: 0x040003E9 RID: 1001
		const_7 = 64U,
		// Token: 0x040003EA RID: 1002
		const_8 = 128U,
		// Token: 0x040003EB RID: 1003
		const_9 = 256U,
		// Token: 0x040003EC RID: 1004
		const_10 = 512U,
		// Token: 0x040003ED RID: 1005
		const_11 = 1024U
	}

	// Token: 0x0200007D RID: 125
	public enum GEnum26 : uint
	{
		// Token: 0x040003EF RID: 1007
		const_0 = 4096U,
		// Token: 0x040003F0 RID: 1008
		const_1 = 8192U,
		// Token: 0x040003F1 RID: 1009
		const_2 = 32768U,
		// Token: 0x040003F2 RID: 1010
		const_3 = 65536U,
		// Token: 0x040003F3 RID: 1011
		const_4 = 16777216U,
		// Token: 0x040003F4 RID: 1012
		const_5 = 536870912U,
		// Token: 0x040003F5 RID: 1013
		const_6 = 4194304U,
		// Token: 0x040003F6 RID: 1014
		const_7 = 1048576U
	}

	// Token: 0x0200007E RID: 126
	public enum GEnum27 : uint
	{
		// Token: 0x040003F8 RID: 1016
		const_0 = 16777216U,
		// Token: 0x040003F9 RID: 1017
		const_1 = 262144U,
		// Token: 0x040003FA RID: 1018
		const_2 = 131072U
	}

	// Token: 0x0200007F RID: 127
	public class GClass47
	{
		// Token: 0x040003FB RID: 1019
		public const string string_0 = "SeDebugPrivilege";

		// Token: 0x040003FC RID: 1020
		public const string string_1 = "SeTakeOwnershipPrivilege";
	}

	// Token: 0x02000080 RID: 128
	public enum GEnum28
	{
		// Token: 0x040003FE RID: 1022
		const_0 = 983040,
		// Token: 0x040003FF RID: 1023
		const_1 = 131072,
		// Token: 0x04000400 RID: 1024
		const_2 = 1,
		// Token: 0x04000401 RID: 1025
		const_3,
		// Token: 0x04000402 RID: 1026
		const_4 = 4,
		// Token: 0x04000403 RID: 1027
		const_5 = 8,
		// Token: 0x04000404 RID: 1028
		const_6 = 16,
		// Token: 0x04000405 RID: 1029
		const_7 = 32,
		// Token: 0x04000406 RID: 1030
		const_8 = 64,
		// Token: 0x04000407 RID: 1031
		const_9 = 128,
		// Token: 0x04000408 RID: 1032
		const_10 = 256,
		// Token: 0x04000409 RID: 1033
		const_11 = 131080,
		// Token: 0x0400040A RID: 1034
		const_12 = 983551
	}

	// Token: 0x02000081 RID: 129
	public struct GStruct6
	{
		// Token: 0x0400040B RID: 1035
		public uint uint_0;

		// Token: 0x0400040C RID: 1036
		public int int_0;
	}

	// Token: 0x02000082 RID: 130
	public struct GStruct7
	{
		// Token: 0x0400040D RID: 1037
		public uint uint_0;

		// Token: 0x0400040E RID: 1038
		public GClass45.GStruct6 gstruct6_0;

		// Token: 0x0400040F RID: 1039
		public uint uint_1;
	}

	// Token: 0x02000083 RID: 131
	public struct GStruct8
	{
		// Token: 0x04000410 RID: 1040
		public GClass45.GStruct6 gstruct6_0;

		// Token: 0x04000411 RID: 1041
		public uint uint_0;
	}

	// Token: 0x02000084 RID: 132
	[Flags]
	public enum GEnum29 : uint
	{
		// Token: 0x04000413 RID: 1043
		flag_0 = 0U,
		// Token: 0x04000414 RID: 1044
		flag_1 = 1U,
		// Token: 0x04000415 RID: 1045
		flag_2 = 4U,
		// Token: 0x04000416 RID: 1046
		flag_3 = 2U,
		// Token: 0x04000417 RID: 1047
		flag_4 = 32768U
	}

	// Token: 0x02000085 RID: 133
	public enum GEnum30 : uint
	{
		// Token: 0x04000419 RID: 1049
		const_0 = 65536U,
		// Token: 0x0400041A RID: 1050
		const_1 = 65536U,
		// Token: 0x0400041B RID: 1051
		const_2,
		// Token: 0x0400041C RID: 1052
		const_3,
		// Token: 0x0400041D RID: 1053
		const_4 = 65540U,
		// Token: 0x0400041E RID: 1054
		const_5 = 65544U,
		// Token: 0x0400041F RID: 1055
		const_6 = 65552U,
		// Token: 0x04000420 RID: 1056
		const_7 = 65568U,
		// Token: 0x04000421 RID: 1057
		const_8 = 65543U,
		// Token: 0x04000422 RID: 1058
		const_9 = 65599U
	}

	// Token: 0x02000086 RID: 134
	public struct GStruct9
	{
		// Token: 0x04000423 RID: 1059
		public uint uint_0;

		// Token: 0x04000424 RID: 1060
		public uint uint_1;

		// Token: 0x04000425 RID: 1061
		public uint uint_2;

		// Token: 0x04000426 RID: 1062
		public uint uint_3;

		// Token: 0x04000427 RID: 1063
		public uint uint_4;

		// Token: 0x04000428 RID: 1064
		public uint uint_5;

		// Token: 0x04000429 RID: 1065
		public uint uint_6;

		// Token: 0x0400042A RID: 1066
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		// Token: 0x0400042B RID: 1067
		public uint uint_7;
	}

	// Token: 0x02000087 RID: 135
	public struct GStruct10
	{
		// Token: 0x0400042C RID: 1068
		public uint uint_0;

		// Token: 0x0400042D RID: 1069
		public uint uint_1;

		// Token: 0x0400042E RID: 1070
		public uint uint_2;

		// Token: 0x0400042F RID: 1071
		public uint uint_3;

		// Token: 0x04000430 RID: 1072
		public uint uint_4;

		// Token: 0x04000431 RID: 1073
		public uint uint_5;

		// Token: 0x04000432 RID: 1074
		public uint uint_6;

		// Token: 0x04000433 RID: 1075
		public GClass45.GStruct11 gstruct11_0;

		// Token: 0x04000434 RID: 1076
		public uint uint_7;

		// Token: 0x04000435 RID: 1077
		public uint uint_8;

		// Token: 0x04000436 RID: 1078
		public uint uint_9;

		// Token: 0x04000437 RID: 1079
		public uint uint_10;

		// Token: 0x04000438 RID: 1080
		public uint uint_11;

		// Token: 0x04000439 RID: 1081
		public uint uint_12;

		// Token: 0x0400043A RID: 1082
		public uint uint_13;

		// Token: 0x0400043B RID: 1083
		public uint uint_14;

		// Token: 0x0400043C RID: 1084
		public uint uint_15;

		// Token: 0x0400043D RID: 1085
		public uint uint_16;

		// Token: 0x0400043E RID: 1086
		public uint uint_17;

		// Token: 0x0400043F RID: 1087
		public uint uint_18;

		// Token: 0x04000440 RID: 1088
		public uint uint_19;

		// Token: 0x04000441 RID: 1089
		public uint uint_20;

		// Token: 0x04000442 RID: 1090
		public uint uint_21;

		// Token: 0x04000443 RID: 1091
		public uint uint_22;

		// Token: 0x04000444 RID: 1092
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	// Token: 0x02000088 RID: 136
	public enum GEnum31 : uint
	{
		// Token: 0x04000446 RID: 1094
		const_0 = 65536U,
		// Token: 0x04000447 RID: 1095
		const_1 = 65536U,
		// Token: 0x04000448 RID: 1096
		const_2,
		// Token: 0x04000449 RID: 1097
		const_3,
		// Token: 0x0400044A RID: 1098
		const_4 = 65540U,
		// Token: 0x0400044B RID: 1099
		const_5 = 65544U,
		// Token: 0x0400044C RID: 1100
		const_6 = 65552U,
		// Token: 0x0400044D RID: 1101
		const_7 = 65568U,
		// Token: 0x0400044E RID: 1102
		const_8 = 65543U,
		// Token: 0x0400044F RID: 1103
		const_9 = 65599U
	}

	// Token: 0x02000089 RID: 137
	public struct GStruct11
	{
		// Token: 0x04000450 RID: 1104
		public uint uint_0;

		// Token: 0x04000451 RID: 1105
		public uint uint_1;

		// Token: 0x04000452 RID: 1106
		public uint uint_2;

		// Token: 0x04000453 RID: 1107
		public uint uint_3;

		// Token: 0x04000454 RID: 1108
		public uint uint_4;

		// Token: 0x04000455 RID: 1109
		public uint uint_5;

		// Token: 0x04000456 RID: 1110
		public uint uint_6;

		// Token: 0x04000457 RID: 1111
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		// Token: 0x04000458 RID: 1112
		public uint uint_7;
	}

	// Token: 0x0200008A RID: 138
	public struct GStruct12
	{
		// Token: 0x04000459 RID: 1113
		public uint uint_0;

		// Token: 0x0400045A RID: 1114
		public uint uint_1;

		// Token: 0x0400045B RID: 1115
		public uint uint_2;

		// Token: 0x0400045C RID: 1116
		public uint uint_3;

		// Token: 0x0400045D RID: 1117
		public uint uint_4;

		// Token: 0x0400045E RID: 1118
		public uint uint_5;

		// Token: 0x0400045F RID: 1119
		public uint uint_6;

		// Token: 0x04000460 RID: 1120
		public GClass45.GStruct11 gstruct11_0;

		// Token: 0x04000461 RID: 1121
		public uint uint_7;

		// Token: 0x04000462 RID: 1122
		public uint uint_8;

		// Token: 0x04000463 RID: 1123
		public uint uint_9;

		// Token: 0x04000464 RID: 1124
		public uint uint_10;

		// Token: 0x04000465 RID: 1125
		public uint uint_11;

		// Token: 0x04000466 RID: 1126
		public uint uint_12;

		// Token: 0x04000467 RID: 1127
		public uint uint_13;

		// Token: 0x04000468 RID: 1128
		public uint uint_14;

		// Token: 0x04000469 RID: 1129
		public uint uint_15;

		// Token: 0x0400046A RID: 1130
		public uint uint_16;

		// Token: 0x0400046B RID: 1131
		public uint uint_17;

		// Token: 0x0400046C RID: 1132
		public uint uint_18;

		// Token: 0x0400046D RID: 1133
		public uint uint_19;

		// Token: 0x0400046E RID: 1134
		public uint uint_20;

		// Token: 0x0400046F RID: 1135
		public uint uint_21;

		// Token: 0x04000470 RID: 1136
		public uint uint_22;

		// Token: 0x04000471 RID: 1137
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	// Token: 0x0200008B RID: 139
	public struct GStruct13
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x0004F86C File Offset: 0x0004DA6C
		public string ToString()
		{
			return string.Format("High:{0}, Low:{1}", this.ulong_0, this.long_0);
		}

		// Token: 0x04000472 RID: 1138
		public ulong ulong_0;

		// Token: 0x04000473 RID: 1139
		public long long_0;
	}

	// Token: 0x0200008C RID: 140
	[StructLayout(LayoutKind.Sequential, Pack = 16)]
	public struct GStruct14
	{
		// Token: 0x04000474 RID: 1140
		public ushort ushort_0;

		// Token: 0x04000475 RID: 1141
		public ushort ushort_1;

		// Token: 0x04000476 RID: 1142
		public byte byte_0;

		// Token: 0x04000477 RID: 1143
		public byte byte_1;

		// Token: 0x04000478 RID: 1144
		public ushort ushort_2;

		// Token: 0x04000479 RID: 1145
		public uint uint_0;

		// Token: 0x0400047A RID: 1146
		public ushort ushort_3;

		// Token: 0x0400047B RID: 1147
		public ushort ushort_4;

		// Token: 0x0400047C RID: 1148
		public uint uint_1;

		// Token: 0x0400047D RID: 1149
		public ushort ushort_5;

		// Token: 0x0400047E RID: 1150
		public ushort ushort_6;

		// Token: 0x0400047F RID: 1151
		public uint uint_2;

		// Token: 0x04000480 RID: 1152
		public uint uint_3;

		// Token: 0x04000481 RID: 1153
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public GClass45.GStruct13[] gstruct13_0;

		// Token: 0x04000482 RID: 1154
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public GClass45.GStruct13[] gstruct13_1;

		// Token: 0x04000483 RID: 1155
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
		public byte[] byte_2;
	}

	// Token: 0x0200008D RID: 141
	[StructLayout(LayoutKind.Sequential, Pack = 16)]
	public struct GStruct15
	{
		// Token: 0x04000484 RID: 1156
		public ulong ulong_0;

		// Token: 0x04000485 RID: 1157
		public ulong ulong_1;

		// Token: 0x04000486 RID: 1158
		public ulong ulong_2;

		// Token: 0x04000487 RID: 1159
		public ulong ulong_3;

		// Token: 0x04000488 RID: 1160
		public ulong ulong_4;

		// Token: 0x04000489 RID: 1161
		public ulong ulong_5;

		// Token: 0x0400048A RID: 1162
		public GClass45.GEnum31 genum31_0;

		// Token: 0x0400048B RID: 1163
		public uint uint_0;

		// Token: 0x0400048C RID: 1164
		public ushort ushort_0;

		// Token: 0x0400048D RID: 1165
		public ushort ushort_1;

		// Token: 0x0400048E RID: 1166
		public ushort ushort_2;

		// Token: 0x0400048F RID: 1167
		public ushort ushort_3;

		// Token: 0x04000490 RID: 1168
		public ushort ushort_4;

		// Token: 0x04000491 RID: 1169
		public ushort ushort_5;

		// Token: 0x04000492 RID: 1170
		public uint uint_1;

		// Token: 0x04000493 RID: 1171
		public ulong ulong_6;

		// Token: 0x04000494 RID: 1172
		public ulong ulong_7;

		// Token: 0x04000495 RID: 1173
		public ulong ulong_8;

		// Token: 0x04000496 RID: 1174
		public ulong ulong_9;

		// Token: 0x04000497 RID: 1175
		public ulong ulong_10;

		// Token: 0x04000498 RID: 1176
		public ulong ulong_11;

		// Token: 0x04000499 RID: 1177
		public ulong ulong_12;

		// Token: 0x0400049A RID: 1178
		public ulong ulong_13;

		// Token: 0x0400049B RID: 1179
		public ulong ulong_14;

		// Token: 0x0400049C RID: 1180
		public ulong ulong_15;

		// Token: 0x0400049D RID: 1181
		public ulong ulong_16;

		// Token: 0x0400049E RID: 1182
		public ulong ulong_17;

		// Token: 0x0400049F RID: 1183
		public ulong ulong_18;

		// Token: 0x040004A0 RID: 1184
		public ulong ulong_19;

		// Token: 0x040004A1 RID: 1185
		public ulong ulong_20;

		// Token: 0x040004A2 RID: 1186
		public ulong ulong_21;

		// Token: 0x040004A3 RID: 1187
		public ulong ulong_22;

		// Token: 0x040004A4 RID: 1188
		public ulong ulong_23;

		// Token: 0x040004A5 RID: 1189
		public ulong ulong_24;

		// Token: 0x040004A6 RID: 1190
		public ulong ulong_25;

		// Token: 0x040004A7 RID: 1191
		public ulong ulong_26;

		// Token: 0x040004A8 RID: 1192
		public ulong ulong_27;

		// Token: 0x040004A9 RID: 1193
		public ulong ulong_28;

		// Token: 0x040004AA RID: 1194
		public GClass45.GStruct14 gstruct14_0;

		// Token: 0x040004AB RID: 1195
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
		public GClass45.GStruct13[] gstruct13_0;

		// Token: 0x040004AC RID: 1196
		public ulong ulong_29;

		// Token: 0x040004AD RID: 1197
		public ulong ulong_30;

		// Token: 0x040004AE RID: 1198
		public ulong ulong_31;

		// Token: 0x040004AF RID: 1199
		public ulong ulong_32;

		// Token: 0x040004B0 RID: 1200
		public ulong ulong_33;

		// Token: 0x040004B1 RID: 1201
		public ulong ulong_34;
	}

	// Token: 0x0200008E RID: 142
	[Flags]
	public enum GEnum32
	{
		// Token: 0x040004B3 RID: 1203
		flag_0 = 1,
		// Token: 0x040004B4 RID: 1204
		flag_1 = 2,
		// Token: 0x040004B5 RID: 1205
		flag_2 = 8,
		// Token: 0x040004B6 RID: 1206
		flag_3 = 16,
		// Token: 0x040004B7 RID: 1207
		flag_4 = 32,
		// Token: 0x040004B8 RID: 1208
		flag_5 = 64,
		// Token: 0x040004B9 RID: 1209
		flag_6 = 128,
		// Token: 0x040004BA RID: 1210
		flag_7 = 256,
		// Token: 0x040004BB RID: 1211
		flag_8 = 512
	}

	// Token: 0x0200008F RID: 143
	public enum GEnum33
	{
		// Token: 0x040004BD RID: 1213
		const_0 = 9
	}

	// Token: 0x02000090 RID: 144
	private enum Enum10
	{
		// Token: 0x040004BF RID: 1215
		const_0 = 1,
		// Token: 0x040004C0 RID: 1216
		const_1,
		// Token: 0x040004C1 RID: 1217
		const_2,
		// Token: 0x040004C2 RID: 1218
		const_3,
		// Token: 0x040004C3 RID: 1219
		const_4,
		// Token: 0x040004C4 RID: 1220
		const_5,
		// Token: 0x040004C5 RID: 1221
		const_6,
		// Token: 0x040004C6 RID: 1222
		const_7,
		// Token: 0x040004C7 RID: 1223
		const_8,
		// Token: 0x040004C8 RID: 1224
		const_9,
		// Token: 0x040004C9 RID: 1225
		const_10,
		// Token: 0x040004CA RID: 1226
		const_11,
		// Token: 0x040004CB RID: 1227
		const_12,
		// Token: 0x040004CC RID: 1228
		const_13,
		// Token: 0x040004CD RID: 1229
		const_14,
		// Token: 0x040004CE RID: 1230
		const_15,
		// Token: 0x040004CF RID: 1231
		const_16,
		// Token: 0x040004D0 RID: 1232
		const_17,
		// Token: 0x040004D1 RID: 1233
		const_18,
		// Token: 0x040004D2 RID: 1234
		const_19,
		// Token: 0x040004D3 RID: 1235
		const_20,
		// Token: 0x040004D4 RID: 1236
		const_21,
		// Token: 0x040004D5 RID: 1237
		const_22,
		// Token: 0x040004D6 RID: 1238
		const_23,
		// Token: 0x040004D7 RID: 1239
		const_24,
		// Token: 0x040004D8 RID: 1240
		const_25,
		// Token: 0x040004D9 RID: 1241
		const_26,
		// Token: 0x040004DA RID: 1242
		const_27,
		// Token: 0x040004DB RID: 1243
		const_28
	}

	// Token: 0x02000091 RID: 145
	private enum Enum11
	{
		// Token: 0x040004DD RID: 1245
		const_0 = 1,
		// Token: 0x040004DE RID: 1246
		const_1,
		// Token: 0x040004DF RID: 1247
		const_2
	}

	// Token: 0x02000092 RID: 146
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct16
	{
		// Token: 0x040004E0 RID: 1248
		public int int_0;

		// Token: 0x040004E1 RID: 1249
		public byte byte_0;

		// Token: 0x040004E2 RID: 1250
		public byte byte_1;

		// Token: 0x040004E3 RID: 1251
		public ushort ushort_0;

		// Token: 0x040004E4 RID: 1252
		public int int_1;

		// Token: 0x040004E5 RID: 1253
		public uint uint_0;
	}

	// Token: 0x02000093 RID: 147
	public enum GEnum34 : uint
	{
		// Token: 0x040004E7 RID: 1255
		const_0,
		// Token: 0x040004E8 RID: 1256
		const_1,
		// Token: 0x040004E9 RID: 1257
		const_2,
		// Token: 0x040004EA RID: 1258
		const_3 = 4U,
		// Token: 0x040004EB RID: 1259
		const_4 = 8U,
		// Token: 0x040004EC RID: 1260
		const_5 = 16U,
		// Token: 0x040004ED RID: 1261
		const_6 = 32U,
		// Token: 0x040004EE RID: 1262
		const_7 = 64U,
		// Token: 0x040004EF RID: 1263
		const_8 = 128U,
		// Token: 0x040004F0 RID: 1264
		const_9 = 256U,
		// Token: 0x040004F1 RID: 1265
		const_10 = 512U,
		// Token: 0x040004F2 RID: 1266
		const_11 = 1024U,
		// Token: 0x040004F3 RID: 1267
		const_12 = 2048U,
		// Token: 0x040004F4 RID: 1268
		const_13 = 4096U,
		// Token: 0x040004F5 RID: 1269
		const_14 = 8192U,
		// Token: 0x040004F6 RID: 1270
		const_15 = 2147483648U
	}

	// Token: 0x02000094 RID: 148
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct17
	{
		// Token: 0x040004F7 RID: 1271
		public uint uint_0;

		// Token: 0x040004F8 RID: 1272
		public GClass45.GEnum34 genum34_0;
	}

	// Token: 0x02000095 RID: 149
	public enum GEnum35
	{
		// Token: 0x040004FA RID: 1274
		const_0,
		// Token: 0x040004FB RID: 1275
		const_1,
		// Token: 0x040004FC RID: 1276
		const_2,
		// Token: 0x040004FD RID: 1277
		const_3,
		// Token: 0x040004FE RID: 1278
		const_4
	}

	// Token: 0x02000096 RID: 150
	public struct GStruct18
	{
		// Token: 0x040004FF RID: 1279
		public int int_0;

		// Token: 0x04000500 RID: 1280
		public int int_1;

		// Token: 0x04000501 RID: 1281
		public int int_2;

		// Token: 0x04000502 RID: 1282
		public int int_3;

		// Token: 0x04000503 RID: 1283
		public int int_4;

		// Token: 0x04000504 RID: 1284
		public int int_5;

		// Token: 0x04000505 RID: 1285
		public int int_6;

		// Token: 0x04000506 RID: 1286
		public int int_7;

		// Token: 0x04000507 RID: 1287
		public int int_8;

		// Token: 0x04000508 RID: 1288
		public int int_9;

		// Token: 0x04000509 RID: 1289
		public int int_10;

		// Token: 0x0400050A RID: 1290
		public int int_11;

		// Token: 0x0400050B RID: 1291
		public System.Runtime.InteropServices.ComTypes.FILETIME filetime_0;
	}

	// Token: 0x02000097 RID: 151
	public struct GStruct19
	{
		// Token: 0x0400050C RID: 1292
		public int int_0;

		// Token: 0x0400050D RID: 1293
		public int int_1;

		// Token: 0x0400050E RID: 1294
		public int int_2;

		// Token: 0x0400050F RID: 1295
		public int int_3;
	}

	// Token: 0x02000098 RID: 152
	public struct GStruct20
	{
		// Token: 0x04000510 RID: 1296
		public GClass45.GStruct22 gstruct22_0;

		// Token: 0x04000511 RID: 1297
		public int int_0;

		// Token: 0x04000512 RID: 1298
		public int int_1;

		// Token: 0x04000513 RID: 1299
		public int int_2;

		// Token: 0x04000514 RID: 1300
		public int int_3;

		// Token: 0x04000515 RID: 1301
		public int int_4;

		// Token: 0x04000516 RID: 1302
		public int int_5;

		// Token: 0x04000517 RID: 1303
		public int int_6;

		// Token: 0x04000518 RID: 1304
		public int int_7;

		// Token: 0x04000519 RID: 1305
		public int int_8;

		// Token: 0x0400051A RID: 1306
		public int int_9;

		// Token: 0x0400051B RID: 1307
		public int int_10;

		// Token: 0x0400051C RID: 1308
		public int int_11;

		// Token: 0x0400051D RID: 1309
		public int int_12;

		// Token: 0x0400051E RID: 1310
		public GClass45.GStruct19 gstruct19_0;

		// Token: 0x0400051F RID: 1311
		public int int_13;

		// Token: 0x04000520 RID: 1312
		public byte byte_0;

		// Token: 0x04000521 RID: 1313
		public byte byte_1;

		// Token: 0x04000522 RID: 1314
		public int int_14;

		// Token: 0x04000523 RID: 1315
		public int int_15;

		// Token: 0x04000524 RID: 1316
		public int int_16;
	}

	// Token: 0x02000099 RID: 153
	public struct GStruct21
	{
		// Token: 0x04000525 RID: 1317
		public GClass45.GStruct22 gstruct22_0;
	}

	// Token: 0x0200009A RID: 154
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct22
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x0004F89C File Offset: 0x0004DA9C
		public GStruct22(string string_0)
		{
			this.ushort_0 = (ushort)(string_0.Length * 2);
			this.ushort_1 = (ushort)(this.ushort_0 + 2);
			this.intptr_0 = Marshal.StringToHGlobalUni(string_0);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0004F8D4 File Offset: 0x0004DAD4
		public void method_0()
		{
			Marshal.FreeHGlobal(this.intptr_0);
			this.intptr_0 = IntPtr.Zero;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0004F8F8 File Offset: 0x0004DAF8
		public string ToString()
		{
			return Marshal.PtrToStringUni(this.intptr_0);
		}

		// Token: 0x04000526 RID: 1318
		public ushort ushort_0;

		// Token: 0x04000527 RID: 1319
		public ushort ushort_1;

		// Token: 0x04000528 RID: 1320
		public IntPtr intptr_0;
	}

	// Token: 0x0200009B RID: 155
	public enum GEnum36
	{
		// Token: 0x0400052A RID: 1322
		const_0 = 1,
		// Token: 0x0400052B RID: 1323
		const_1,
		// Token: 0x0400052C RID: 1324
		const_2 = 4,
		// Token: 0x0400052D RID: 1325
		const_3 = 8,
		// Token: 0x0400052E RID: 1326
		const_4 = 16,
		// Token: 0x0400052F RID: 1327
		const_5 = 32,
		// Token: 0x04000530 RID: 1328
		const_6 = 64,
		// Token: 0x04000531 RID: 1329
		const_7 = 128
	}

	// Token: 0x0200009C RID: 156
	public class GClass48
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0004F910 File Offset: 0x0004DB10
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0004F924 File Offset: 0x0004DB24
		public GClass45.GEnum36 GEnum36_0 { get; set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0004F938 File Offset: 0x0004DB38
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0004F94C File Offset: 0x0004DB4C
		public string String_0 { get; set; }

		// Token: 0x04000532 RID: 1330
		[CompilerGenerated]
		private GClass45.GEnum36 genum36_0;

		// Token: 0x04000533 RID: 1331
		[CompilerGenerated]
		private string string_0;
	}

	// Token: 0x0200009D RID: 157
	public enum GEnum37 : uint
	{
		// Token: 0x04000535 RID: 1333
		const_0,
		// Token: 0x04000536 RID: 1334
		const_1 = 3221225476U
	}

	// Token: 0x0200009E RID: 158
	public enum GEnum38 : uint
	{
		// Token: 0x04000538 RID: 1336
		const_0,
		// Token: 0x04000539 RID: 1337
		const_1 = 290U
	}

	// Token: 0x0200009F RID: 159
	private enum Enum12 : uint
	{
		// Token: 0x0400053B RID: 1339
		const_0 = 2U,
		// Token: 0x0400053C RID: 1340
		const_1 = 1U,
		// Token: 0x0400053D RID: 1341
		const_2 = 3U,
		// Token: 0x0400053E RID: 1342
		const_3 = 32768U,
		// Token: 0x0400053F RID: 1343
		const_4 = 0U
	}

	// Token: 0x020000A0 RID: 160
	public enum GEnum39
	{
		// Token: 0x04000541 RID: 1345
		const_0,
		// Token: 0x04000542 RID: 1346
		const_1,
		// Token: 0x04000543 RID: 1347
		const_2,
		// Token: 0x04000544 RID: 1348
		const_3,
		// Token: 0x04000545 RID: 1349
		const_4,
		// Token: 0x04000546 RID: 1350
		const_5,
		// Token: 0x04000547 RID: 1351
		const_6,
		// Token: 0x04000548 RID: 1352
		const_7,
		// Token: 0x04000549 RID: 1353
		const_8,
		// Token: 0x0400054A RID: 1354
		const_9,
		// Token: 0x0400054B RID: 1355
		const_10,
		// Token: 0x0400054C RID: 1356
		const_11,
		// Token: 0x0400054D RID: 1357
		const_12,
		// Token: 0x0400054E RID: 1358
		const_13,
		// Token: 0x0400054F RID: 1359
		const_14,
		// Token: 0x04000550 RID: 1360
		const_15,
		// Token: 0x04000551 RID: 1361
		const_16,
		// Token: 0x04000552 RID: 1362
		const_17,
		// Token: 0x04000553 RID: 1363
		const_18,
		// Token: 0x04000554 RID: 1364
		const_19,
		// Token: 0x04000555 RID: 1365
		const_20 = 21,
		// Token: 0x04000556 RID: 1366
		const_21,
		// Token: 0x04000557 RID: 1367
		const_22,
		// Token: 0x04000558 RID: 1368
		const_23,
		// Token: 0x04000559 RID: 1369
		const_24,
		// Token: 0x0400055A RID: 1370
		const_25 = 28,
		// Token: 0x0400055B RID: 1371
		const_26,
		// Token: 0x0400055C RID: 1372
		const_27 = 31,
		// Token: 0x0400055D RID: 1373
		const_28 = 33,
		// Token: 0x0400055E RID: 1374
		const_29 = 35,
		// Token: 0x0400055F RID: 1375
		const_30,
		// Token: 0x04000560 RID: 1376
		const_31,
		// Token: 0x04000561 RID: 1377
		const_32 = 42,
		// Token: 0x04000562 RID: 1378
		const_33,
		// Token: 0x04000563 RID: 1379
		const_34,
		// Token: 0x04000564 RID: 1380
		const_35,
		// Token: 0x04000565 RID: 1381
		const_36 = 50,
		// Token: 0x04000566 RID: 1382
		const_37,
		// Token: 0x04000567 RID: 1383
		const_38 = 53,
		// Token: 0x04000568 RID: 1384
		const_39 = 55,
		// Token: 0x04000569 RID: 1385
		const_40,
		// Token: 0x0400056A RID: 1386
		const_41,
		// Token: 0x0400056B RID: 1387
		const_42,
		// Token: 0x0400056C RID: 1388
		const_43,
		// Token: 0x0400056D RID: 1389
		const_44,
		// Token: 0x0400056E RID: 1390
		const_45,
		// Token: 0x0400056F RID: 1391
		const_46,
		// Token: 0x04000570 RID: 1392
		const_47,
		// Token: 0x04000571 RID: 1393
		const_48,
		// Token: 0x04000572 RID: 1394
		const_49,
		// Token: 0x04000573 RID: 1395
		const_50,
		// Token: 0x04000574 RID: 1396
		const_51,
		// Token: 0x04000575 RID: 1397
		const_52,
		// Token: 0x04000576 RID: 1398
		const_53,
		// Token: 0x04000577 RID: 1399
		const_54,
		// Token: 0x04000578 RID: 1400
		const_55 = 72,
		// Token: 0x04000579 RID: 1401
		const_56,
		// Token: 0x0400057A RID: 1402
		const_57 = 76,
		// Token: 0x0400057B RID: 1403
		const_58,
		// Token: 0x0400057C RID: 1404
		const_59 = 79,
		// Token: 0x0400057D RID: 1405
		const_60,
		// Token: 0x0400057E RID: 1406
		const_61,
		// Token: 0x0400057F RID: 1407
		const_62 = 83,
		// Token: 0x04000580 RID: 1408
		const_63 = 86,
		// Token: 0x04000581 RID: 1409
		const_64,
		// Token: 0x04000582 RID: 1410
		const_65,
		// Token: 0x04000583 RID: 1411
		const_66 = 90,
		// Token: 0x04000584 RID: 1412
		const_67,
		// Token: 0x04000585 RID: 1413
		const_68,
		// Token: 0x04000586 RID: 1414
		const_69 = 95,
		// Token: 0x04000587 RID: 1415
		const_70,
		// Token: 0x04000588 RID: 1416
		const_71 = 98,
		// Token: 0x04000589 RID: 1417
		const_72,
		// Token: 0x0400058A RID: 1418
		const_73,
		// Token: 0x0400058B RID: 1419
		const_74,
		// Token: 0x0400058C RID: 1420
		const_75,
		// Token: 0x0400058D RID: 1421
		const_76,
		// Token: 0x0400058E RID: 1422
		const_77 = 105,
		// Token: 0x0400058F RID: 1423
		const_78,
		// Token: 0x04000590 RID: 1424
		const_79 = 108,
		// Token: 0x04000591 RID: 1425
		const_80,
		// Token: 0x04000592 RID: 1426
		const_81 = 112,
		// Token: 0x04000593 RID: 1427
		const_82,
		// Token: 0x04000594 RID: 1428
		const_83,
		// Token: 0x04000595 RID: 1429
		const_84,
		// Token: 0x04000596 RID: 1430
		const_85,
		// Token: 0x04000597 RID: 1431
		const_86,
		// Token: 0x04000598 RID: 1432
		const_87,
		// Token: 0x04000599 RID: 1433
		const_88,
		// Token: 0x0400059A RID: 1434
		const_89,
		// Token: 0x0400059B RID: 1435
		const_90 = 122,
		// Token: 0x0400059C RID: 1436
		const_91,
		// Token: 0x0400059D RID: 1437
		const_92,
		// Token: 0x0400059E RID: 1438
		const_93,
		// Token: 0x0400059F RID: 1439
		const_94,
		// Token: 0x040005A0 RID: 1440
		const_95 = 128,
		// Token: 0x040005A1 RID: 1441
		const_96 = 133,
		// Token: 0x040005A2 RID: 1442
		const_97,
		// Token: 0x040005A3 RID: 1443
		const_98,
		// Token: 0x040005A4 RID: 1444
		const_99,
		// Token: 0x040005A5 RID: 1445
		const_100,
		// Token: 0x040005A6 RID: 1446
		const_101,
		// Token: 0x040005A7 RID: 1447
		const_102,
		// Token: 0x040005A8 RID: 1448
		const_103,
		// Token: 0x040005A9 RID: 1449
		const_104,
		// Token: 0x040005AA RID: 1450
		const_105 = 143,
		// Token: 0x040005AB RID: 1451
		const_106,
		// Token: 0x040005AC RID: 1452
		const_107,
		// Token: 0x040005AD RID: 1453
		const_108 = 147,
		// Token: 0x040005AE RID: 1454
		const_109,
		// Token: 0x040005AF RID: 1455
		const_110,
		// Token: 0x040005B0 RID: 1456
		const_111,
		// Token: 0x040005B1 RID: 1457
		const_112,
		// Token: 0x040005B2 RID: 1458
		const_113 = 153,
		// Token: 0x040005B3 RID: 1459
		const_114,
		// Token: 0x040005B4 RID: 1460
		const_115 = 156,
		// Token: 0x040005B5 RID: 1461
		const_116,
		// Token: 0x040005B6 RID: 1462
		const_117,
		// Token: 0x040005B7 RID: 1463
		const_118,
		// Token: 0x040005B8 RID: 1464
		const_119,
		// Token: 0x040005B9 RID: 1465
		const_120 = 162,
		// Token: 0x040005BA RID: 1466
		const_121,
		// Token: 0x040005BB RID: 1467
		const_122,
		// Token: 0x040005BC RID: 1468
		const_123,
		// Token: 0x040005BD RID: 1469
		const_124,
		// Token: 0x040005BE RID: 1470
		const_125,
		// Token: 0x040005BF RID: 1471
		const_126 = 169,
		// Token: 0x040005C0 RID: 1472
		const_127 = 171,
		// Token: 0x040005C1 RID: 1473
		const_128,
		// Token: 0x040005C2 RID: 1474
		const_129,
		// Token: 0x040005C3 RID: 1475
		const_130,
		// Token: 0x040005C4 RID: 1476
		const_131
	}

	// Token: 0x020000A1 RID: 161
	public struct GStruct23
	{
		// Token: 0x040005C5 RID: 1477
		public GClass45.GStruct22 gstruct22_0;

		// Token: 0x040005C6 RID: 1478
		public GClass45.GStruct22 gstruct22_1;
	}

	// Token: 0x020000A2 RID: 162
	public struct GStruct24 : IDisposable
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x0004F960 File Offset: 0x0004DB60
		public GStruct24(string string_0, uint uint_1)
		{
			this.int_0 = 0;
			this.intptr_0 = IntPtr.Zero;
			this.intptr_1 = IntPtr.Zero;
			this.uint_0 = uint_1;
			this.intptr_2 = IntPtr.Zero;
			this.intptr_3 = IntPtr.Zero;
			this.int_0 = Marshal.SizeOf(this);
			this.GStruct22_0 = new GClass45.GStruct22(string_0);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0004F9CC File Offset: 0x0004DBCC
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0004F9F4 File Offset: 0x0004DBF4
		public GClass45.GStruct22 GStruct22_0
		{
			get
			{
				return (GClass45.GStruct22)Marshal.PtrToStructure(this.intptr_1, typeof(GClass45.GStruct22));
			}
			set
			{
				bool flag;
				if (!(flag = this.intptr_1 != IntPtr.Zero))
				{
					this.intptr_1 = Marshal.AllocHGlobal(Marshal.SizeOf(value));
				}
				Marshal.StructureToPtr(value, this.intptr_1, flag);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0004FA40 File Offset: 0x0004DC40
		public void Dispose()
		{
			if (this.intptr_1 != IntPtr.Zero)
			{
				Marshal.DestroyStructure(this.intptr_1, typeof(GClass45.GStruct22));
				Marshal.FreeHGlobal(this.intptr_1);
				this.intptr_1 = IntPtr.Zero;
			}
		}

		// Token: 0x040005C7 RID: 1479
		public int int_0;

		// Token: 0x040005C8 RID: 1480
		public IntPtr intptr_0;

		// Token: 0x040005C9 RID: 1481
		private IntPtr intptr_1;

		// Token: 0x040005CA RID: 1482
		public uint uint_0;

		// Token: 0x040005CB RID: 1483
		public IntPtr intptr_2;

		// Token: 0x040005CC RID: 1484
		public IntPtr intptr_3;
	}

	// Token: 0x020000A3 RID: 163
	[Flags]
	public enum GEnum40 : uint
	{
		// Token: 0x040005CE RID: 1486
		flag_0 = 2U,
		// Token: 0x040005CF RID: 1487
		flag_1 = 1U,
		// Token: 0x040005D0 RID: 1488
		flag_2 = 536870912U,
		// Token: 0x040005D1 RID: 1489
		flag_3 = 16U,
		// Token: 0x040005D2 RID: 1490
		flag_4 = 262144U,
		// Token: 0x040005D3 RID: 1491
		flag_5 = 8U,
		// Token: 0x040005D4 RID: 1492
		flag_6 = 524288U,
		// Token: 0x040005D5 RID: 1493
		flag_7 = 1048576U,
		// Token: 0x040005D6 RID: 1494
		flag_8 = 131072U,
		// Token: 0x040005D7 RID: 1495
		flag_9 = 8388608U,
		// Token: 0x040005D8 RID: 1496
		flag_10 = 4194304U,
		// Token: 0x040005D9 RID: 1497
		flag_11 = 65536U,
		// Token: 0x040005DA RID: 1498
		flag_12 = 16777216U,
		// Token: 0x040005DB RID: 1499
		flag_13 = 128U,
		// Token: 0x040005DC RID: 1500
		flag_14 = 64U,
		// Token: 0x040005DD RID: 1501
		flag_15 = 2097152U,
		// Token: 0x040005DE RID: 1502
		flag_16 = 33554432U,
		// Token: 0x040005DF RID: 1503
		flag_17 = 4U,
		// Token: 0x040005E0 RID: 1504
		flag_18 = 32768U,
		// Token: 0x040005E1 RID: 1505
		flag_19 = 32U
	}

	// Token: 0x020000A4 RID: 164
	public struct GStruct25
	{
		// Token: 0x040005E2 RID: 1506
		internal IntPtr intptr_0;

		// Token: 0x040005E3 RID: 1507
		internal IntPtr intptr_1;

		// Token: 0x040005E4 RID: 1508
		internal IntPtr intptr_2;

		// Token: 0x040005E5 RID: 1509
		internal IntPtr intptr_3;

		// Token: 0x040005E6 RID: 1510
		internal IntPtr intptr_4;

		// Token: 0x040005E7 RID: 1511
		internal IntPtr intptr_5;
	}

	// Token: 0x020000A5 RID: 165
	[Flags]
	public enum GEnum41 : uint
	{
		// Token: 0x040005E9 RID: 1513
		flag_0 = 0U,
		// Token: 0x040005EA RID: 1514
		flag_1 = 32768U,
		// Token: 0x040005EB RID: 1515
		flag_2 = 16384U,
		// Token: 0x040005EC RID: 1516
		flag_3 = 8192U,
		// Token: 0x040005ED RID: 1517
		flag_4 = 4096U,
		// Token: 0x040005EE RID: 1518
		flag_5 = 2048U,
		// Token: 0x040005EF RID: 1519
		flag_6 = 1024U,
		// Token: 0x040005F0 RID: 1520
		flag_7 = 512U,
		// Token: 0x040005F1 RID: 1521
		flag_8 = 256U,
		// Token: 0x040005F2 RID: 1522
		flag_9 = 2147483648U
	}

	// Token: 0x020000A6 RID: 166
	[Flags]
	public enum GEnum42 : uint
	{
		// Token: 0x040005F4 RID: 1524
		flag_0 = 0U,
		// Token: 0x040005F5 RID: 1525
		flag_1 = 1U,
		// Token: 0x040005F6 RID: 1526
		flag_2 = 2U
	}
}
