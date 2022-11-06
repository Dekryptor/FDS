using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;

// Token: 0x02000070 RID: 112
public class GClass43
{
	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000379 RID: 889 RVA: 0x0004D864 File Offset: 0x0004BA64
	// (set) Token: 0x0600037A RID: 890 RVA: 0x0004D878 File Offset: 0x0004BA78
	private List<GClass44> List_0 { get; set; }

	// Token: 0x0600037B RID: 891 RVA: 0x0004D88C File Offset: 0x0004BA8C
	public GClass43(bool bool_2 = false)
	{
		this.List_0 = new List<GClass44>();
		this.bool_0 = bool_2;
		this.bool_1 = false;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x0004D8B8 File Offset: 0x0004BAB8
	public void method_0()
	{
		if (!this.bool_1)
		{
			this.method_2();
			this.method_5();
			this.bool_1 = true;
		}
	}

	// Token: 0x0600037D RID: 893 RVA: 0x0004D8E0 File Offset: 0x0004BAE0
	public void method_1()
	{
		if (this.bool_1)
		{
			this.managementEventWatcher_0.Stop();
			this.managementEventWatcher_1.Stop();
			object obj = GClass43.object_0;
			lock (obj)
			{
				this.List_0.Clear();
			}
			this.bool_1 = false;
		}
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0004D94C File Offset: 0x0004BB4C
	private void method_2()
	{
		this.managementEventWatcher_0 = new ManagementEventWatcher(Class14.String_228, Class14.String_170);
		this.managementEventWatcher_0.EventArrived += this.managementEventWatcher_0_EventArrived;
		this.managementEventWatcher_0.Start();
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0004D990 File Offset: 0x0004BB90
	public GClass44[] method_3(bool bool_2 = true)
	{
		List<GClass44> list = new List<GClass44>();
		object obj = GClass43.object_0;
		lock (obj)
		{
			foreach (GClass44 gclass in this.List_0)
			{
				list.Add(gclass);
			}
			if (bool_2)
			{
				this.List_0.Clear();
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000380 RID: 896 RVA: 0x0004DA28 File Offset: 0x0004BC28
	private long method_4(GEnum21 genum21_0, GEnum48 genum48_0, string string_0, DateTime? nullable_0 = null, GEnum51 genum51_0 = GEnum51.const_1)
	{
		long num = -1L;
		string_0 = GClass44.smethod_0(string_0, this.bool_0, ref genum51_0);
		string text = string_0.ToLowerInvariant();
		object obj = GClass43.object_0;
		lock (obj)
		{
			for (int i = 0; i < this.List_0.Count; i++)
			{
				if (this.List_0[i].String_1.ToLowerInvariant() == text)
				{
					this.List_0[i].GEnum48_0 |= genum48_0;
					this.List_0[i].GEnum21_0 |= genum21_0;
					if (nullable_0 != null)
					{
						try
						{
							if (this.List_0[i].Nullable_0 != null)
							{
								DateTime? nullable_ = this.List_0[i].Nullable_0;
								DateTime? dateTime = nullable_0;
								if (((nullable_ != null) & (dateTime != null)) && nullable_.GetValueOrDefault() > dateTime.GetValueOrDefault())
								{
									this.List_0[i].Nullable_0 = nullable_0;
								}
							}
							else
							{
								this.List_0[i].Nullable_0 = nullable_0;
							}
						}
						catch
						{
						}
					}
					num = (long)i;
					IL_13D:
					if (num == -1L)
					{
						GClass44 gclass = new GClass44(string_0, genum48_0, true);
						gclass.Nullable_0 = nullable_0;
						gclass.GEnum21_0 = genum21_0;
						gclass.Int64_0 = (long)this.List_0.Count;
						this.List_0.Add(gclass);
						num = gclass.Int64_0;
					}
					return num;
				}
			}
			//goto IL_13D;
		}
		return num;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x0004DC04 File Offset: 0x0004BE04
	private void managementEventWatcher_0_EventArrived(object sender, EventArrivedEventArgs e)
	{
		try
		{
			string text = ((ManagementBaseObject)e.NewEvent.Properties[Class14.String_92].Value).Properties[Class14.String_81].Value.ToString();
			try
			{
				text = Path.GetFullPath(text);
			}
			catch
			{
			}
			this.method_4(GEnum21.const_0, GEnum48.const_11, text, new DateTime?(DateTime.Now), GEnum51.const_1);
		}
		catch
		{
		}
	}

	// Token: 0x06000382 RID: 898 RVA: 0x0004DC90 File Offset: 0x0004BE90
	private void method_5()
	{
		this.managementEventWatcher_1 = new ManagementEventWatcher(Class14.String_228, Class14.String_101);
		this.managementEventWatcher_1.EventArrived += this.managementEventWatcher_1_EventArrived;
		this.managementEventWatcher_1.Start();
	}

	// Token: 0x06000383 RID: 899 RVA: 0x0004DC04 File Offset: 0x0004BE04
	private void managementEventWatcher_1_EventArrived(object sender, EventArrivedEventArgs e)
	{
		try
		{
			string text = ((ManagementBaseObject)e.NewEvent.Properties[Class14.String_92].Value).Properties[Class14.String_81].Value.ToString();
			try
			{
				text = Path.GetFullPath(text);
			}
			catch
			{
			}
			this.method_4(GEnum21.const_0, GEnum48.const_11, text, new DateTime?(DateTime.Now), GEnum51.const_1);
		}
		catch
		{
		}
	}

	// Token: 0x04000361 RID: 865
	private ManagementEventWatcher managementEventWatcher_0;

	// Token: 0x04000362 RID: 866
	private ManagementEventWatcher managementEventWatcher_1;

	// Token: 0x04000363 RID: 867
	[CompilerGenerated]
	private List<GClass44> list_0;

	// Token: 0x04000364 RID: 868
	private bool bool_0;

	// Token: 0x04000365 RID: 869
	private static object object_0 = new object();

	// Token: 0x04000366 RID: 870
	private bool bool_1;
}
