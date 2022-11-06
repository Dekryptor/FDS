using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

// Token: 0x020000AB RID: 171
public static class GClass50
{
	// Token: 0x06000424 RID: 1060
	[DllImport("advapi32.dll", CharSet = CharSet.Auto)]
	public static extern int RegOpenKeyEx(UIntPtr uintptr_0, string string_0, uint uint_0, uint uint_1, out IntPtr intptr_0);

	// Token: 0x06000425 RID: 1061 RVA: 0x00050D98 File Offset: 0x0004EF98
	public static RegistryKey smethod_0(RegistryHive registryHive_0, GClass50.GEnum46 genum46_0)
	{
		UIntPtr uintPtr = GClass50.dictionary_0[registryHive_0];
		if (Environment.OSVersion.Platform != PlatformID.Win32NT || Environment.OSVersion.Version.Major <= 5)
		{
			throw new PlatformNotSupportedException("The platform or operating system must be Windows XP or later.");
		}
		GClass50.GEnum47 genum = GClass50.GEnum47.flag_0 | GClass50.GEnum47.flag_1 | GClass50.GEnum47.flag_2 | GClass50.GEnum47.flag_3 | GClass50.dictionary_1[genum46_0];
		IntPtr zero = IntPtr.Zero;
		int num = GClass50.RegOpenKeyEx(uintPtr, string.Empty, 0U, (uint)genum, out zero);
		if (num == 0)
		{
			Type type = typeof(SafeHandleZeroOrMinusOneIsInvalid).Assembly.GetType("Microsoft.Win32.SafeHandles.SafeRegistryHandle");
			ConstructorInfo constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(IntPtr),
				typeof(bool)
			}, null);
			if (constructorInfo == null)
			{
				constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[]
				{
					typeof(IntPtr),
					typeof(bool)
				}, null);
			}
			object obj = constructorInfo.Invoke(new object[] { zero, true });
			ConstructorInfo constructor = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				type,
				typeof(bool)
			}, null);
			ConstructorInfo constructor2 = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(IntPtr),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, null);
			object obj2;
			if (constructor2 != null)
			{
				obj2 = constructor2.Invoke(new object[]
				{
					zero,
					true,
					false,
					false,
					uintPtr == GClass50.dictionary_0[RegistryHive.PerformanceData]
				});
			}
			else if (constructor != null)
			{
				obj2 = constructor.Invoke(new object[] { obj, true });
			}
			else
			{
				obj2 = typeof(RegistryKey).GetMethod("FromHandle", BindingFlags.Static | BindingFlags.Public, null, new Type[] { type }, null).Invoke(null, new object[] { obj });
			}
			FieldInfo field = typeof(RegistryKey).GetField("keyName", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null)
			{
				field.SetValue(obj2, string.Empty);
			}
			return (RegistryKey)obj2;
		}
		if (num == 2)
		{
			return null;
		}
		throw new Win32Exception(num);
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00051034 File Offset: 0x0004F234
	public static bool smethod_1(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		bool flag = false;
		RegistryKey registryKey = null;
		try
		{
			NTAccount ntaccount = new SecurityIdentifier(WellKnownSidType.WorldSid, null).Translate(typeof(NTAccount)) as NTAccount;
			using (RegistryKey registryKey2 = registryKey_0.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.ChangePermissions))
			{
				RegistrySecurity accessControl = registryKey2.GetAccessControl();
				RegistryAccessRule registryAccessRule = new RegistryAccessRule(Environment.UserDomainName + "\\" + Environment.UserName, RegistryRights.SetValue | RegistryRights.CreateSubKey | RegistryRights.Delete | RegistryRights.ReadPermissions | RegistryRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny);
				RegistryAccessRule registryAccessRule2 = new RegistryAccessRule(ntaccount, RegistryRights.SetValue | RegistryRights.CreateSubKey | RegistryRights.Delete | RegistryRights.ReadPermissions | RegistryRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny);
				if (!bool_0)
				{
					accessControl.AddAccessRule(registryAccessRule);
					accessControl.AddAccessRule(registryAccessRule2);
				}
				else
				{
					accessControl.RemoveAccessRuleSpecific(registryAccessRule);
					accessControl.RemoveAccessRuleSpecific(registryAccessRule2);
				}
				registryKey2.SetAccessControl(accessControl);
			}
			flag = true;
		}
		catch
		{
		}
		finally
		{
			if (registryKey != null)
			{
				registryKey.Close();
			}
		}
		return flag;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00051124 File Offset: 0x0004F324
	public static bool smethod_2(string string_0, string string_1, string string_2)
	{
		if (string_0 != null && string_1 != null)
		{
			RegistryKey registryKey;
			if (!(string_0 == Class14.String_54))
			{
				if (!(string_0 == Class14.String_231))
				{
					return false;
				}
				registryKey = Registry.CurrentUser;
			}
			else
			{
				registryKey = Registry.LocalMachine;
			}
			try
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(string_1, false))
				{
					if (registryKey2 != null)
					{
						if (string_2 == null)
						{
							return true;
						}
						if (registryKey2.GetValue(string_2) != null)
						{
							return true;
						}
					}
				}
			}
			catch
			{
			}
			return false;
		}
		return false;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x000511B8 File Offset: 0x0004F3B8
	public static bool smethod_3(RegistryKey registryKey_0, string string_0)
	{
		try
		{
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false))
			{
				if (registryKey != null)
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00051208 File Offset: 0x0004F408
	public static bool smethod_4(RegistryKey registryKey_0, string string_0, string string_1)
	{
		try
		{
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false))
			{
				if (registryKey != null)
				{
					try
					{
						registryKey.GetValue(string_1);
						registryKey.Close();
						return true;
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00051274 File Offset: 0x0004F474
	public static byte[] smethod_5(RegistryKey registryKey_0, string string_0, string string_1)
	{
		byte[] array = null;
		try
		{
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false))
			{
				if (registryKey != null)
				{
					try
					{
						array = (byte[])registryKey.GetValue(string_1);
						registryKey.Close();
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		return array;
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x000512E4 File Offset: 0x0004F4E4
	public static string smethod_6(RegistryKey registryKey_0, string string_0, string string_1)
	{
		string text = null;
		try
		{
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false))
			{
				if (registryKey != null)
				{
					if (registryKey.GetValueKind(string_1) == RegistryValueKind.String)
					{
						text = registryKey.GetValue(string_1).ToString();
					}
				}
			}
		}
		catch
		{
		}
		return text;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00051348 File Offset: 0x0004F548
	public static bool smethod_7(RegistryKey registryKey_0, string string_0, string string_1)
	{
		bool flag = false;
		try
		{
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false))
			{
				if (registryKey != null)
				{
					if (registryKey.GetValueKind(string_1) == RegistryValueKind.DWord)
					{
						if (registryKey.GetValue(string_1).ToString() == "1")
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
		return flag;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x000513B8 File Offset: 0x0004F5B8
	public static bool smethod_8(RegistryKey registryKey_0, string string_0, string string_1, out uint uint_0)
	{
		bool flag = false;
		uint_0 = 0U;
		try
		{
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false))
			{
				if (registryKey != null && registryKey.GetValueKind(string_1) == RegistryValueKind.DWord)
				{
					uint_0 = Convert.ToUInt32(registryKey.GetValue(string_1).ToString());
					flag = true;
				}
			}
		}
		catch
		{
		}
		return flag;
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00051424 File Offset: 0x0004F624
	public static bool smethod_9(RegistryKey registryKey_0, string string_0, string string_1, out ulong ulong_0)
	{
		bool flag = false;
		ulong_0 = 0UL;
		try
		{
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false))
			{
				if (registryKey != null)
				{
					if (registryKey.GetValueKind(string_1) == RegistryValueKind.QWord)
					{
						ulong_0 = Convert.ToUInt64(registryKey.GetValue(string_1).ToString());
						flag = true;
					}
				}
			}
		}
		catch
		{
		}
		return flag;
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x0005149C File Offset: 0x0004F69C
	public static bool smethod_10(RegistryKey registryKey_0, string string_0, string string_1, bool bool_0, bool bool_1 = false)
	{
		bool flag = false;
		RegistryKey registryKey = null;
		try
		{
			if (bool_1)
			{
				GClass50.smethod_1(registryKey_0, string_0, true);
			}
			registryKey = registryKey_0.OpenSubKey(string_0, true);
			if (registryKey == null)
			{
				registryKey = registryKey_0.CreateSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			if (registryKey != null)
			{
				registryKey.SetValue(string_1, bool_0 ? 1 : 0, RegistryValueKind.DWord);
				if (bool_1)
				{
					GClass50.smethod_1(registryKey_0, string_0, false);
				}
				flag = true;
			}
		}
		catch
		{
		}
		finally
		{
			if (registryKey != null)
			{
				registryKey.Close();
			}
		}
		return flag;
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00051524 File Offset: 0x0004F724
	public static bool smethod_11(RegistryKey registryKey_0, string string_0, string string_1, uint uint_0, bool bool_0 = false)
	{
		bool flag = false;
		RegistryKey registryKey = null;
		try
		{
			if (bool_0)
			{
				GClass50.smethod_1(registryKey_0, string_0, true);
			}
			registryKey = registryKey_0.OpenSubKey(string_0, true);
			if (registryKey == null)
			{
				registryKey = registryKey_0.CreateSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			if (registryKey != null)
			{
				registryKey.SetValue(string_1, uint_0, RegistryValueKind.DWord);
				if (bool_0)
				{
					GClass50.smethod_1(registryKey_0, string_0, false);
				}
				flag = true;
			}
		}
		catch
		{
		}
		finally
		{
			if (registryKey != null)
			{
				registryKey.Close();
			}
		}
		return flag;
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x000515A4 File Offset: 0x0004F7A4
	public static bool smethod_12(RegistryKey registryKey_0, string string_0, string string_1, string string_2, bool bool_0 = false)
	{
		bool flag = false;
		RegistryKey registryKey = null;
		try
		{
			if (string_2 != null)
			{
				if (bool_0)
				{
					GClass50.smethod_1(registryKey_0, string_0, true);
				}
				registryKey = registryKey_0.OpenSubKey(string_0, true);
				if (registryKey == null)
				{
					registryKey = registryKey_0.CreateSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				if (registryKey != null)
				{
					registryKey.SetValue(string_1, string_2, RegistryValueKind.String);
					if (bool_0)
					{
						GClass50.smethod_1(registryKey_0, string_0, false);
					}
					flag = true;
				}
			}
		}
		catch
		{
		}
		finally
		{
			if (registryKey != null)
			{
				registryKey.Close();
			}
		}
		return flag;
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00051624 File Offset: 0x0004F824
	public static bool smethod_13(RegistryKey registryKey_0, string string_0, string string_1, byte[] byte_0, bool bool_0 = false)
	{
		bool flag = false;
		RegistryKey registryKey = null;
		try
		{
			if (byte_0 != null)
			{
				if (bool_0)
				{
					GClass50.smethod_1(registryKey_0, string_0, true);
				}
				registryKey = registryKey_0.OpenSubKey(string_0, true);
				if (registryKey == null)
				{
					registryKey = registryKey_0.CreateSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
				}
				if (registryKey != null)
				{
					registryKey.SetValue(string_1, byte_0, RegistryValueKind.Binary);
					if (bool_0)
					{
						GClass50.smethod_1(registryKey_0, string_0, false);
					}
					flag = true;
				}
			}
		}
		catch
		{
		}
		finally
		{
			if (registryKey != null)
			{
				registryKey.Close();
			}
		}
		return flag;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x000516A4 File Offset: 0x0004F8A4
	public static bool smethod_14(RegistryKey registryKey_0, string string_0)
	{
		bool flag = false;
		try
		{
			GClass45.smethod_0("SeTakeOwnershipPrivilege", true);
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.ChangePermissions | RegistryRights.TakeOwnership))
			{
				RegistrySecurity registrySecurity = new RegistrySecurity();
				NTAccount ntaccount = new NTAccount("Administrators");
				registrySecurity.SetOwner(ntaccount);
				registryKey.SetAccessControl(registrySecurity);
			}
			flag = true;
		}
		catch (Exception)
		{
		}
		finally
		{
			GClass45.smethod_0("SeTakeOwnershipPrivilege", false);
		}
		return flag;
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00051738 File Offset: 0x0004F938
	public static bool smethod_15(RegistryKey registryKey_0, string string_0)
	{
		bool flag = false;
		try
		{
			NTAccount ntaccount = new SecurityIdentifier(WellKnownSidType.WorldSid, null).Translate(typeof(NTAccount)) as NTAccount;
			using (RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.ChangePermissions))
			{
				RegistrySecurity accessControl = registryKey.GetAccessControl(AccessControlSections.All);
				string text = Environment.UserDomainName + "\\" + Environment.UserName;
				RegistryAccessRule registryAccessRule = new RegistryAccessRule(text, RegistryRights.SetValue | RegistryRights.CreateSubKey | RegistryRights.Delete | RegistryRights.ReadPermissions | RegistryRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny);
				RegistryAccessRule registryAccessRule2 = new RegistryAccessRule(ntaccount, RegistryRights.SetValue | RegistryRights.CreateSubKey | RegistryRights.Delete | RegistryRights.ReadPermissions | RegistryRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny);
				RegistryAccessRule registryAccessRule3 = new RegistryAccessRule(text, RegistryRights.ExecuteKey, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
				accessControl.RemoveAccessRuleSpecific(registryAccessRule);
				accessControl.RemoveAccessRuleSpecific(registryAccessRule2);
				accessControl.RemoveAccessRuleSpecific(registryAccessRule3);
				accessControl.AddAccessRule(registryAccessRule);
				accessControl.AddAccessRule(registryAccessRule2);
				accessControl.AddAccessRule(registryAccessRule3);
				registryKey.SetAccessControl(accessControl);
			}
			flag = true;
		}
		catch
		{
		}
		return flag;
	}

	// Token: 0x04000609 RID: 1545
	private static Dictionary<RegistryHive, UIntPtr> dictionary_0 = new Dictionary<RegistryHive, UIntPtr>
	{
		{
			RegistryHive.ClassesRoot,
			new UIntPtr(2147483648U)
		},
		{
			RegistryHive.CurrentConfig,
			new UIntPtr(2147483653U)
		},
		{
			RegistryHive.CurrentUser,
			new UIntPtr(2147483649U)
		},
		{
			RegistryHive.DynData,
			new UIntPtr(2147483654U)
		},
		{
			RegistryHive.LocalMachine,
			new UIntPtr(2147483650U)
		},
		{
			RegistryHive.PerformanceData,
			new UIntPtr(2147483652U)
		},
		{
			RegistryHive.Users,
			new UIntPtr(2147483651U)
		}
	};

	// Token: 0x0400060A RID: 1546
	private static Dictionary<GClass50.GEnum46, GClass50.GEnum47> dictionary_1 = new Dictionary<GClass50.GEnum46, GClass50.GEnum47>
	{
		{
			GClass50.GEnum46.const_1,
			GClass50.GEnum47.flag_7
		},
		{
			GClass50.GEnum46.const_0,
			GClass50.GEnum47.flag_6
		}
	};

	// Token: 0x020000AC RID: 172
	public enum GEnum46
	{
		// Token: 0x0400060C RID: 1548
		const_0,
		// Token: 0x0400060D RID: 1549
		const_1
	}

	// Token: 0x020000AD RID: 173
	[Flags]
	public enum GEnum47
	{
		// Token: 0x0400060F RID: 1551
		flag_0 = 1,
		// Token: 0x04000610 RID: 1552
		flag_1 = 2,
		// Token: 0x04000611 RID: 1553
		flag_2 = 4,
		// Token: 0x04000612 RID: 1554
		flag_3 = 8,
		// Token: 0x04000613 RID: 1555
		flag_4 = 16,
		// Token: 0x04000614 RID: 1556
		flag_5 = 32,
		// Token: 0x04000615 RID: 1557
		flag_6 = 512,
		// Token: 0x04000616 RID: 1558
		flag_7 = 256,
		// Token: 0x04000617 RID: 1559
		flag_8 = 131078,
		// Token: 0x04000618 RID: 1560
		flag_9 = 131097,
		// Token: 0x04000619 RID: 1561
		flag_10 = 131097,
		// Token: 0x0400061A RID: 1562
		flag_11 = 983103
	}
}
