using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000A7 RID: 167
public class GClass49
{
	// Token: 0x06000404 RID: 1028 RVA: 0x0004FA8C File Offset: 0x0004DC8C
	public static IntPtr smethod_0(uint uint_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = GClass45.OpenThread(64U, false, uint_0);
		if (!(intPtr3 == IntPtr.Zero))
		{
			try
			{
				intPtr2 = Marshal.AllocHGlobal(IntPtr.Size);
				if (GClass45.ZwQueryInformationThread(intPtr3, GClass45.GEnum33.const_0, intPtr2, IntPtr.Size, IntPtr.Zero) == 0)
				{
					intPtr = Marshal.ReadIntPtr(intPtr2);
				}
			}
			catch
			{
			}
			finally
			{
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr2);
				}
			}
			GClass45.CloseHandle(intPtr3);
			return intPtr;
		}
		return intPtr;
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x0004FB24 File Offset: 0x0004DD24
	public static string smethod_1(Process process_0, IntPtr intptr_0)
	{
		if (process_0 != null && !(intptr_0 == IntPtr.Zero))
		{
			ProcessModuleCollection modules = process_0.Modules;
			for (int i = 0; i < modules.Count; i++)
			{
				if (modules[i].BaseAddress.ToInt64() <= intptr_0.ToInt64() && modules[i].BaseAddress.ToInt64() + (long)modules[i].ModuleMemorySize > intptr_0.ToInt64())
				{
					return modules[i].ModuleName;
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x0004FBB4 File Offset: 0x0004DDB4
	public static string smethod_2(Process process_0, IntPtr intptr_0)
	{
		if (process_0 != null && !(intptr_0 == IntPtr.Zero))
		{
			ProcessModuleCollection modules = process_0.Modules;
			for (int i = 0; i < modules.Count; i++)
			{
				if (modules[i].BaseAddress.ToInt64() <= intptr_0.ToInt64() && modules[i].BaseAddress.ToInt64() + (long)modules[i].ModuleMemorySize > intptr_0.ToInt64())
				{
					try
					{
						return Path.GetFullPath(modules[i].FileName);
					}
					catch
					{
					}
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0004FC60 File Offset: 0x0004DE60
	public static ProcessModule smethod_3(Process process_0, string string_0)
	{
		if (process_0 != null && string_0 != null)
		{
			ProcessModuleCollection modules = process_0.Modules;
			for (int i = 0; i < modules.Count; i++)
			{
				if (modules[i].ModuleName.ToLower() == string_0)
				{
					return modules[i];
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0004FCB4 File Offset: 0x0004DEB4
	public static IntPtr smethod_4(Process process_0, string string_0)
	{
		ProcessModule processModule = GClass49.smethod_3(process_0, string_0);
		if (processModule != null)
		{
			return processModule.BaseAddress;
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x0004FCD8 File Offset: 0x0004DED8
	public static ProcessModule smethod_5(Process process_0, string string_0, string string_1, GClass49.GEnum43 genum43_0 = GClass49.GEnum43.const_0)
	{
		if (process_0 != null && string_0 != null)
		{
			ProcessModuleCollection modules = process_0.Modules;
			string text = string_0.ToLower();
			string text2 = null;
			if (string_1 != null)
			{
				text2 = string_1.ToLower();
			}
			for (int i = 0; i < modules.Count; i++)
			{
				if (modules[i].ModuleName.ToLower() == text)
				{
					if (text2 == null)
					{
						return modules[i];
					}
					switch (genum43_0)
					{
					case GClass49.GEnum43.const_0:
						if (modules[i].FileName.ToLower() == text2)
						{
							return modules[i];
						}
						break;
					case GClass49.GEnum43.const_1:
						if (modules[i].FileName.ToLower().Contains(text2))
						{
							return modules[i];
						}
						break;
					case GClass49.GEnum43.const_2:
						if (modules[i].FileName.ToLower().StartsWith(text2))
						{
							return modules[i];
						}
						break;
					case GClass49.GEnum43.const_3:
						if (modules[i].FileName.ToLower().EndsWith(text2))
						{
							return modules[i];
						}
						break;
					}
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x0004FDF4 File Offset: 0x0004DFF4
	public static IntPtr smethod_6(Process process_0, string string_0)
	{
		if (process_0 != null && string_0 != null)
		{
			ProcessModuleCollection modules = process_0.Modules;
			for (int i = 0; i < modules.Count; i++)
			{
				if (modules[i].ModuleName == string_0)
				{
					return modules[i].BaseAddress;
				}
			}
			return IntPtr.Zero;
		}
		return IntPtr.Zero;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x0004FE50 File Offset: 0x0004E050
	public static bool smethod_7(Process process_0, IntPtr intptr_0)
	{
		return GClass49.smethod_8(process_0, intptr_0) != IntPtr.Zero;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0004FE70 File Offset: 0x0004E070
	public static IntPtr smethod_8(Process process_0, IntPtr intptr_0)
	{
		if (process_0 != null && !(intptr_0 == IntPtr.Zero))
		{
			ProcessModuleCollection modules = process_0.Modules;
			for (int i = 0; i < modules.Count; i++)
			{
				if (modules[i].BaseAddress.ToInt64() <= intptr_0.ToInt64() && modules[i].BaseAddress.ToInt64() + (long)modules[i].ModuleMemorySize > intptr_0.ToInt64())
				{
					return modules[i].BaseAddress;
				}
			}
			return IntPtr.Zero;
		}
		return IntPtr.Zero;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0004FF08 File Offset: 0x0004E108
	public static bool smethod_9(GClass45.GStruct4 gstruct4_0)
	{
		return gstruct4_0.uint_1 == 4096U && ((gstruct4_0.uint_2 & 1U) == 0U && (gstruct4_0.uint_2 & 256U) == 0U && (gstruct4_0.uint_2 & 1024U) == 0U && gstruct4_0.uint_2 != 0U);
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00050024 File Offset: 0x0004E224
	public static bool smethod_11(IntPtr intptr_0, IntPtr intptr_1)
	{
		GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
		return !(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero) && GClass45.VirtualQueryEx(intptr_0, intptr_1, out gstruct, Marshal.SizeOf(gstruct)) > 0 && GClass49.smethod_9(gstruct);
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00050074 File Offset: 0x0004E274
	public static uint smethod_12(uint uint_0)
	{
		uint num = 0U;
		if ((uint_0 & 16U) != 0U)
		{
			num = 10U;
		}
		if ((uint_0 & 32U) != 0U)
		{
			num |= 10U;
		}
		if ((uint_0 & 64U) != 0U)
		{
			num |= 14U;
		}
		if ((uint_0 & 128U) != 0U)
		{
			num |= 12U;
		}
		if ((uint_0 & 256U) != 0U)
		{
			num |= 16U;
		}
		if ((uint_0 & 1U) != 0U)
		{
			num |= 1U;
		}
		if ((uint_0 & 512U) != 0U)
		{
			num |= 32U;
		}
		if ((uint_0 & 2U) != 0U)
		{
			num |= 2U;
		}
		if ((uint_0 & 4U) != 0U)
		{
			num |= 6U;
		}
		if ((uint_0 & 1024U) != 0U)
		{
			num |= 4U;
		}
		if ((uint_0 & 8U) != 0U)
		{
			num |= 4U;
		}
		return num;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00050100 File Offset: 0x0004E300
	public static bool smethod_13(IntPtr intptr_0, IntPtr intptr_1)
	{
		GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
		return !(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero) && GClass45.VirtualQueryEx(intptr_0, intptr_1, out gstruct, Marshal.SizeOf(gstruct)) > 0 && GClass49.smethod_14(gstruct.uint_2);
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00050158 File Offset: 0x0004E358
	public static bool smethod_14(uint uint_0)
	{
		return (GClass49.smethod_12(uint_0) & 8U) == 8U;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00050170 File Offset: 0x0004E370
	public static bool smethod_15(Process process_0)
	{
		IntPtr intPtr = GClass45.OpenProcess(1040, false, process_0.Id);
		bool flag = false;
		if (intPtr != IntPtr.Zero)
		{
			try
			{
				if (!GClass45.IsWow64Process(intPtr, ref flag))
				{
					flag = false;
				}
			}
			catch
			{
			}
			GClass45.CloseHandle(intPtr);
		}
		return flag;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x000501C8 File Offset: 0x0004E3C8
	public static bool smethod_16()
	{
		return GClass49.smethod_17(Process.GetCurrentProcess()) != GClass49.GEnum45.const_0;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x000501E8 File Offset: 0x0004E3E8
	public static GClass49.GEnum45 smethod_17(Process process_0)
	{
		bool flag = IntPtr.Size == 8 || GClass49.smethod_15(Process.GetCurrentProcess());
		bool flag2 = GClass49.smethod_15(process_0);
		if (flag && flag2)
		{
			return GClass49.GEnum45.const_2;
		}
		if (flag && !flag2)
		{
			return GClass49.GEnum45.const_1;
		}
		return GClass49.GEnum45.const_0;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00050224 File Offset: 0x0004E424
	public static bool smethod_18(Process process_0)
	{
		GClass49.GEnum45 genum = GClass49.smethod_17(process_0);
		return genum == GClass49.GEnum45.const_0 || genum == GClass49.GEnum45.const_2;
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00050244 File Offset: 0x0004E444
	public static string smethod_19(Process process_0, IntPtr intptr_0)
	{
		if (process_0 == null)
		{
			return string.Empty;
		}
		string text = Class14.String_47;
		GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
		IntPtr intPtr = GClass45.OpenProcess(1040, false, process_0.Id);
		if (intPtr == IntPtr.Zero)
		{
			return text;
		}
		try
		{
			if (GClass45.VirtualQueryEx(intPtr, intptr_0, out gstruct, Marshal.SizeOf(gstruct)) <= 0)
			{
				GClass45.CloseHandle(intPtr);
				return text;
			}
			uint num;
			IntPtr intPtr2 = GClass49.smethod_20(process_0, intPtr, gstruct.intptr_0, out num, true);
			uint num2;
			if (!(intPtr2 != IntPtr.Zero))
			{
				num2 = GClass49.smethod_12(gstruct.uint_2);
				intPtr2 = (IntPtr)(gstruct.intptr_0.ToInt64() + gstruct.intptr_2.ToInt64());
			}
			else
			{
				num2 = GClass49.smethod_12(num);
			}
			string text2 = null;
			if (gstruct.uint_3 == 16777216U)
			{
				text2 = GClass49.smethod_1(process_0, intptr_0);
			}
			if (text2 != null)
			{
				text2 = Class14.String_221 + text2;
			}
			else if (gstruct.uint_3 == 131072U)
			{
				text2 = Class14.String_205;
			}
			else
			{
				string text3 = GClass45.smethod_7(intPtr, gstruct.intptr_0);
				if (text3 == null)
				{
					text3 = string.Empty;
				}
				if (text3.Length <= 0)
				{
					if (gstruct.uint_3 == 16777216U)
					{
						text2 = Class14.String_53;
					}
					else
					{
						text2 = Class14.String_76;
					}
				}
				else
				{
					text3 = Path.GetFileName(text3);
					if (gstruct.uint_3 == 16777216U)
					{
						text2 = Class14.String_88 + text3.ToString();
					}
					else
					{
						text2 = Class14.String_152 + text3.ToString();
					}
				}
			}
			char[] array = new char[] { '-', '-', '-' };
			if ((num2 & 2U) == 2U)
			{
				array[0] = 'r';
			}
			if ((num2 & 4U) == 4U)
			{
				array[1] = 'w';
			}
			if ((num2 & 8U) == 8U)
			{
				array[2] = 'x';
			}
			string text4 = new string(array);
			if (!GClass17.smethod_1(intPtr, gstruct.intptr_0))
			{
				text += Class14.String_74;
			}
			else
			{
				text += Class14.String_217;
			}
			text = string.Concat(new string[]
			{
				text,
				"_",
				gstruct.intptr_0.ToString("X2"),
				"_",
				intPtr2.ToString("X2"),
				"_",
				text4.ToString(),
				"_",
				text2
			});
			IntPtr intPtr3 = IntPtr.Zero;
			uint num3 = 0U;
			for (int i = 0; i < process_0.Threads.Count; i++)
			{
				intPtr3 = GClass49.smethod_0((uint)process_0.Threads[i].Id);
				if (!(intPtr3 == IntPtr.Zero) && intPtr3.ToInt64() >= gstruct.intptr_0.ToInt64() && intPtr3.ToInt64() < intPtr2.ToInt64())
				{
					num3 += 1U;
				}
			}
			text = text + Class14.String_121 + num3.ToString();
		}
		catch
		{
		}
		GClass45.CloseHandle(intPtr);
		return text;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00050560 File Offset: 0x0004E760
	public static IntPtr smethod_20(Process process_0, IntPtr intptr_0, IntPtr intptr_1, out uint uint_0, bool bool_1 = true)
	{
		GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
		GClass45.GStruct4 gstruct2 = default(GClass45.GStruct4);
		IntPtr intPtr = IntPtr.Zero;
		GClass45.GStruct5 gstruct3 = default(GClass45.GStruct5);
		GClass45.GetSystemInfo(ref gstruct3);
		uint_0 = 0U;
		int num = GClass45.VirtualQueryEx(intptr_0, intptr_1, out gstruct2, Marshal.SizeOf(gstruct2));
		uint_0 = gstruct2.uint_2;
		if (num <= 0)
		{
			return IntPtr.Zero;
		}
		if (gstruct2.intptr_0.ToInt64() == 0L || gstruct2.intptr_2.ToInt64() == 0L)
		{
			return IntPtr.Zero;
		}
		if (!GClass49.smethod_9(gstruct2))
		{
			return (IntPtr)(gstruct2.intptr_0.ToInt64() + gstruct2.intptr_2.ToInt64());
		}
		if (gstruct2.uint_3 == 16777216U)
		{
			intPtr = GClass49.smethod_8(process_0, gstruct2.intptr_0);
			if (intPtr == IntPtr.Zero && gstruct2.uint_3 == 16777216U && GClass49.smethod_16())
			{
				bool_1 = true;
			}
			string text = string.Empty;
			string text2 = string.Empty;
			if (bool_1)
			{
				text = GClass45.smethod_7(intptr_0, gstruct2.intptr_0);
			}
			IntPtr intPtr2 = (IntPtr)(gstruct2.intptr_0.ToInt64() + gstruct2.intptr_2.ToInt64());
			IntPtr intptr_2 = gstruct3.intptr_1;
			while (GClass45.VirtualQueryEx(intptr_0, intPtr2, out gstruct, Marshal.SizeOf(gstruct)) > 0)
			{
				if (gstruct.intptr_0.ToInt64() != 0L && gstruct.intptr_2.ToInt64() != 0L)
				{
					if (gstruct.uint_3 != gstruct2.uint_3)
					{
						intPtr2 = gstruct.intptr_0;
					}
					else
					{
						if (!GClass49.smethod_9(gstruct))
						{
							if (intPtr != IntPtr.Zero)
							{
								if (GClass49.smethod_8(process_0, gstruct.intptr_0) != intPtr)
								{
									bool flag = true;
									if (bool_1)
									{
										text2 = GClass45.smethod_7(intptr_0, gstruct2.intptr_0);
										if (text == text2)
										{
											flag = false;
										}
									}
									if (flag)
									{
										return gstruct.intptr_0;
									}
								}
							}
							else
							{
								bool flag = true;
								if (bool_1)
								{
									text2 = GClass45.smethod_7(intptr_0, gstruct2.intptr_0);
									if (text == text2)
									{
										flag = false;
									}
								}
								if (flag)
								{
									return (IntPtr)(gstruct.intptr_0.ToInt64() + gstruct.intptr_2.ToInt64());
								}
							}
						}
						else if (intPtr != IntPtr.Zero)
						{
							if (GClass49.smethod_8(process_0, gstruct.intptr_0) != intPtr)
							{
								bool flag = true;
								if (bool_1)
								{
									text2 = GClass45.smethod_7(intptr_0, gstruct2.intptr_0);
									if (text == text2)
									{
										flag = false;
									}
								}
								if (flag)
								{
									return gstruct.intptr_0;
								}
							}
						}
						else
						{
							bool flag = true;
							if (bool_1)
							{
								text2 = GClass45.smethod_7(intptr_0, gstruct2.intptr_0);
								if (text == text2)
								{
									flag = false;
								}
							}
							if (flag)
							{
								return (IntPtr)(gstruct.intptr_0.ToInt64() + gstruct.intptr_2.ToInt64());
							}
						}
						uint_0 |= gstruct.uint_2;
						intPtr2 = (IntPtr)(gstruct.intptr_0.ToInt64() + gstruct.intptr_2.ToInt64());
						if (intPtr2.ToInt64() < intptr_2.ToInt64())
						{
							continue;
						}
					}
				}
				else
				{
					intPtr2 = gstruct.intptr_0;
				}
				return intPtr2;
			}
			return gstruct.intptr_0;
		}
		return (IntPtr)(gstruct2.intptr_0.ToInt64() + gstruct2.intptr_2.ToInt64());
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x000508C8 File Offset: 0x0004EAC8
	public static bool smethod_21(string string_0)
	{
		if (!GClass49.smethod_16())
		{
			return false;
		}
		string[] array = new string[] { "wow64win.dll", "wow64.dll", "wow64cpu.dll", "ntdll.dll" };
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string_0 = string_0.ToLowerInvariant();
		for (int i = 0; i < array.Length; i++)
		{
			string text = Path.Combine(folderPath, array[i]);
			string text2 = text.ToLowerInvariant();
			if (string_0 == text2)
			{
				return i >= array.Length - 1 || !File.Exists(text);
			}
		}
		return false;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x0005095C File Offset: 0x0004EB5C
	public static bool smethod_22(Process process_0, out string string_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		string_0 = null;
		if (GClass49.bool_0)
		{
			int num = 32768;
			StringBuilder stringBuilder = new StringBuilder(32768);
			try
			{
				intPtr = GClass45.OpenProcess(1024, false, process_0.Id);
				if (intPtr == IntPtr.Zero)
				{
					return flag;
				}
				if (GClass45.QueryFullProcessImageName(intPtr, 0, stringBuilder, ref num))
				{
					string_0 = stringBuilder.ToString();
					flag = true;
				}
				flag = true;
			}
			catch (EntryPointNotFoundException)
			{
				GClass49.bool_0 = false;
			}
			catch (Exception)
			{
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					GClass45.CloseHandle(intPtr);
				}
			}
			return flag;
		}
		return flag;
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00050A1C File Offset: 0x0004EC1C
	public static string smethod_23(int int_0)
	{
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + int_0.ToString());
			StringBuilder stringBuilder = new StringBuilder();
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					stringBuilder.Append(managementObject["CommandLine"].ToString());
				}
			}
			return stringBuilder.ToString().Trim();
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00050ABC File Offset: 0x0004ECBC
	public static string smethod_24(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		bool flag = true;
		string text = string.Empty;
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, int_0);
		}
		catch (Exception)
		{
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
			if (flag)
			{
				text = GClass49.smethod_23(int_0);
			}
		}
		return text;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00050B28 File Offset: 0x0004ED28
	public static bool smethod_25(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, int_0);
			if (intPtr != IntPtr.Zero)
			{
				GClass45.GEnum42 genum = GClass45.GEnum42.flag_0;
				bool flag2 = false;
				if (GClass45.GetProcessDEPPolicy(intPtr, out genum, out flag2))
				{
					if (genum == GClass45.GEnum42.flag_1)
					{
						if (flag2)
						{
							flag = true;
						}
					}
				}
			}
		}
		catch
		{
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return flag;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00050BAC File Offset: 0x0004EDAC
	public static string smethod_26(IntPtr intptr_0, IntPtr intptr_1, int int_0, bool bool_1 = true, string string_0 = "")
	{
		string text = string_0;
		if (!(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero) && int_0 != 0)
		{
			try
			{
				byte[] array = new byte[int_0];
				uint num = 0U;
				if (GClass45.ReadProcessMemory(intptr_0, intptr_1, array, (uint)array.Length, ref num) && num > 0U)
				{
					string text2;
					int num2;
					if (!bool_1)
					{
						text2 = Encoding.UTF8.GetString(array);
						num2 = text2.IndexOf("\0\0");
					}
					else
					{
						text2 = Encoding.ASCII.GetString(array);
						num2 = text2.IndexOf('\0');
					}
					if (num2 > 0)
					{
						text2 = text2.Substring(0, num2);
					}
					else if (num2 == 0)
					{
						text2 = string_0;
					}
					text = text2;
				}
			}
			catch
			{
			}
			return text;
		}
		return text;
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00050C64 File Offset: 0x0004EE64
	public static Process smethod_27(Process process_0)
	{
		if (process_0 == null)
		{
			process_0 = Process.GetCurrentProcess();
		}
		Process process = GClass49.smethod_28(process_0.Handle);
		if (process == null)
		{
			process = GClass49.smethod_29(process_0);
		}
		return process;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00050C94 File Offset: 0x0004EE94
	public static Process smethod_28(IntPtr intptr_0)
	{
		try
		{
			GClass45.GStruct25 gstruct = default(GClass45.GStruct25);
			int num;
			if (GClass45.NtQueryInformationProcess(intptr_0, 0, ref gstruct, Marshal.SizeOf(gstruct), out num) != 0)
			{
				return null;
			}
			return Process.GetProcessById(gstruct.intptr_5.ToInt32());
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00050CF0 File Offset: 0x0004EEF0
	public static Process smethod_29(Process process_0)
	{
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = " + process_0.Id).Get().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					if (managementObject != null)
					{
						Process.GetProcessById(Convert.ToInt32(managementObject["ParentProcessId"]));
						break;
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x040005F7 RID: 1527
	private static bool bool_0 = true;

	// Token: 0x020000A8 RID: 168
	public enum GEnum43
	{
		// Token: 0x040005F9 RID: 1529
		const_0,
		// Token: 0x040005FA RID: 1530
		const_1,
		// Token: 0x040005FB RID: 1531
		const_2,
		// Token: 0x040005FC RID: 1532
		const_3
	}

	// Token: 0x020000A9 RID: 169
	public enum GEnum44 : uint
	{
		// Token: 0x040005FE RID: 1534
		const_0,
		// Token: 0x040005FF RID: 1535
		const_1,
		// Token: 0x04000600 RID: 1536
		const_2,
		// Token: 0x04000601 RID: 1537
		const_3 = 4U,
		// Token: 0x04000602 RID: 1538
		const_4 = 8U,
		// Token: 0x04000603 RID: 1539
		const_5 = 16U,
		// Token: 0x04000604 RID: 1540
		const_6 = 32U
	}

	// Token: 0x020000AA RID: 170
	public enum GEnum45
	{
		// Token: 0x04000606 RID: 1542
		const_0 = 1,
		// Token: 0x04000607 RID: 1543
		const_1,
		// Token: 0x04000608 RID: 1544
		const_2 = 4
	}
}
