using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020000E1 RID: 225
internal class Class48
{
	// Token: 0x17000316 RID: 790
	// (get) Token: 0x06000734 RID: 1844 RVA: 0x0006570C File Offset: 0x0006390C
	// (set) Token: 0x06000735 RID: 1845 RVA: 0x00065720 File Offset: 0x00063920
	public string String_0 { get; set; }

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x06000736 RID: 1846 RVA: 0x00065734 File Offset: 0x00063934
	// (set) Token: 0x06000737 RID: 1847 RVA: 0x00065748 File Offset: 0x00063948
	public string String_1 { get; set; }

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x06000738 RID: 1848 RVA: 0x0006575C File Offset: 0x0006395C
	// (set) Token: 0x06000739 RID: 1849 RVA: 0x00065770 File Offset: 0x00063970
	public long Int64_0 { get; set; }

	// Token: 0x0600073A RID: 1850 RVA: 0x00065784 File Offset: 0x00063984
	public Class48(string string_2 = "", string string_3 = "", long long_1 = 0L)
	{
		this.String_0 = string_2;
		this.String_1 = string_3;
		this.Int64_0 = long_1;
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x000657AC File Offset: 0x000639AC
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			this.Int64_0
		});
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00065810 File Offset: 0x00063A10
	public static string smethod_0()
	{
		List<Class48> list = new List<Class48>();
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(Class14.String_14, Class14.String_19).Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				Class48 @class = new Class48("", "", 0L);
				try
				{
					if (Convert.ToUInt32(managementObject.GetPropertyValue(Class14.String_117).ToString().Trim()) == 3U)
					{
						@class.String_0 = managementObject.GetPropertyValue(Class14.String_100).ToString().Trim()
							.ToUpper();
						if (@class.String_0.Length > 1)
						{
							@class.String_0 = @class.String_0[0].ToString();
						}
						@class.String_1 = managementObject.GetPropertyValue(Class14.String_41).ToString().Trim()
							.ToUpper();
						@class.Int64_0 = Convert.ToInt64(managementObject.GetPropertyValue(Class14.String_173).ToString().Trim());
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
				uint num = 0U;
				uint num2 = 0U;
				uint num3 = 0U;
				foreach (string text in Environment.GetLogicalDrives())
				{
					if (text.Length != 0)
					{
						string text2 = text[0].ToString().Trim().ToUpper();
						DriveInfo driveInfo = new DriveInfo(text2);
						if (driveInfo.DriveType == DriveType.Fixed && GClass45.GetVolumeInformation(text2 + ":\\", null, 0U, ref num, ref num2, ref num3, null, 0U) != 0L)
						{
							list.Add(new Class48("", "", 0L)
							{
								String_0 = text2,
								String_1 = num.ToString("X").Trim().ToUpper(),
								Int64_0 = driveInfo.TotalSize
							});
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
			Class48 @class = new Class48("", "", 0L);
			list.Add(@class);
		}
		for (int j = 0; j < list.Count; j++)
		{
			stringBuilder.Append(list[j].ToString());
			if (j + 1 != list.Count)
			{
				stringBuilder.Append(Class15.char_1);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x040009DC RID: 2524
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009DD RID: 2525
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009DE RID: 2526
	[CompilerGenerated]
	private long long_0;
}
