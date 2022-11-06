using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x02000071 RID: 113
public class GClass44
{
	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000385 RID: 901 RVA: 0x0004DCEC File Offset: 0x0004BEEC
	// (set) Token: 0x06000386 RID: 902 RVA: 0x0004DD00 File Offset: 0x0004BF00
	public long Int64_0 { get; set; }

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000387 RID: 903 RVA: 0x0004DD14 File Offset: 0x0004BF14
	// (set) Token: 0x06000388 RID: 904 RVA: 0x0004DD28 File Offset: 0x0004BF28
	public GEnum48 GEnum48_0 { get; set; }

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000389 RID: 905 RVA: 0x0004DD3C File Offset: 0x0004BF3C
	// (set) Token: 0x0600038A RID: 906 RVA: 0x0004DD50 File Offset: 0x0004BF50
	public GEnum21 GEnum21_0 { get; set; }

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x0600038B RID: 907 RVA: 0x0004DD64 File Offset: 0x0004BF64
	public bool Boolean_0
	{
		get
		{
			if (this.nullable_0 == null)
			{
				this.nullable_0 = new bool?(File.Exists(this.String_1));
			}
			return this.nullable_0.Value;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x0600038C RID: 908 RVA: 0x0004DDA0 File Offset: 0x0004BFA0
	// (set) Token: 0x0600038D RID: 909 RVA: 0x0004DDB4 File Offset: 0x0004BFB4
	public string String_0 { get; set; }

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x0600038E RID: 910 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
	// (set) Token: 0x0600038F RID: 911 RVA: 0x0004DDDC File Offset: 0x0004BFDC
	public string String_1 { get; set; }

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000390 RID: 912 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
	public string String_2
	{
		get
		{
			if (this.string_2 == null || this.string_2.Length != 64)
			{
				this.string_2 = Class15.smethod_8(this.String_1);
			}
			return this.string_2;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000391 RID: 913 RVA: 0x0004DE2C File Offset: 0x0004C02C
	public string String_3
	{
		get
		{
			if (this.string_3 == null || this.string_3.Length != 32)
			{
				this.string_3 = Class15.smethod_11(this.String_1);
			}
			return this.string_3;
		}
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0004DE6C File Offset: 0x0004C06C
	private string method_0(string string_6)
	{
		string text = "";
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(this.String_1);
			text = string.Format("{0}!{1}!{2}!{3}!{4}", new object[]
			{
				Class15.smethod_22(versionInfo.OriginalFilename),
				Class15.smethod_22(versionInfo.InternalName),
				Class15.smethod_22(versionInfo.LegalCopyright),
				Class15.smethod_22(versionInfo.CompanyName),
				Class15.smethod_22(versionInfo.Language)
			});
		}
		catch
		{
			text = "!!!!";
		}
		return text;
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000393 RID: 915 RVA: 0x0004DF00 File Offset: 0x0004C100
	public string String_4
	{
		get
		{
			if (this.string_4 == null)
			{
				this.string_4 = this.method_0(this.String_1);
			}
			return this.string_4;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000394 RID: 916 RVA: 0x0004DF30 File Offset: 0x0004C130
	// (set) Token: 0x06000395 RID: 917 RVA: 0x0004DF44 File Offset: 0x0004C144
	public long Int64_1 { get; set; }

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000396 RID: 918 RVA: 0x0004DF58 File Offset: 0x0004C158
	// (set) Token: 0x06000397 RID: 919 RVA: 0x0004DF6C File Offset: 0x0004C16C
	public uint UInt32_0 { get; set; }

	// Token: 0x06000398 RID: 920 RVA: 0x0004DF80 File Offset: 0x0004C180
	private string method_1(string string_6)
	{
		string text = "";
		try
		{
			X509Certificate2 x509Certificate = new X509Certificate2(this.String_1);
			string text2 = Class15.smethod_22(x509Certificate.SubjectName.Name);
			string text3 = Class15.smethod_22(x509Certificate.IssuerName.Name);
			string text4 = x509Certificate.NotBefore.ToString(Class15.string_0, CultureInfo.InvariantCulture);
			string text5 = x509Certificate.NotAfter.ToString(Class15.string_0, CultureInfo.InvariantCulture);
			string text6 = x509Certificate.Version.ToString();
			text = string.Format("{0}!{1}!{2}!{3}!{4}", new object[] { text6, text2, text3, text4, text5 });
		}
		catch
		{
			text = "!!!!";
		}
		return text;
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000399 RID: 921 RVA: 0x0004E048 File Offset: 0x0004C248
	public string String_5
	{
		get
		{
			if (this.string_5 == null)
			{
				this.string_5 = this.method_1(this.String_1);
			}
			return this.string_5;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x0600039A RID: 922 RVA: 0x0004E078 File Offset: 0x0004C278
	// (set) Token: 0x0600039B RID: 923 RVA: 0x0004E08C File Offset: 0x0004C28C
	public DateTime? Nullable_0 { get; set; }

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x0600039C RID: 924 RVA: 0x0004E0A0 File Offset: 0x0004C2A0
	public long Int64_2
	{
		get
		{
			if (this.nullable_1 == null)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(this.String_1);
					this.nullable_1 = new long?(fileInfo.Length);
				}
				catch
				{
					this.nullable_1 = new long?(0L);
				}
			}
			return this.nullable_1.Value;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x0600039D RID: 925 RVA: 0x0004E10C File Offset: 0x0004C30C
	public GClass17 GClass17_0
	{
		get
		{
			return this.gclass17_0;
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x0600039E RID: 926 RVA: 0x0004E120 File Offset: 0x0004C320
	// (set) Token: 0x0600039F RID: 927 RVA: 0x0004E134 File Offset: 0x0004C334
	public GEnum51 GEnum51_0 { get; private set; }

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x060003A0 RID: 928 RVA: 0x0004E148 File Offset: 0x0004C348
	// (set) Token: 0x060003A1 RID: 929 RVA: 0x0004E18C File Offset: 0x0004C38C
	private bool Boolean_1
	{
		get
		{
			object obj = this.object_0;
			bool flag2;
			lock (obj)
			{
				flag2 = this.bool_0;
			}
			return flag2;
		}
		set
		{
			object obj = this.object_0;
			lock (obj)
			{
				this.bool_0 = value;
			}
		}
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x0004E1D0 File Offset: 0x0004C3D0
	public void method_2(string string_6, string string_7, uint uint_1, uint uint_2)
	{
		object obj = this.object_1;
		lock (obj)
		{
			this.list_0.Add(new GClass57(string_6, string_7, uint_1, uint_2));
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x0004E220 File Offset: 0x0004C420
	public static string smethod_0(string string_6, bool bool_1, ref GEnum51 genum51_1)
	{
		if (string_6 == null)
		{
			throw new ArgumentException();
		}
		string text = string_6;
		try
		{
			if (text.StartsWith("\\??\\"))
			{
				text = text.Substring(4);
			}
			else if (!text.StartsWith("\\\\?\\"))
			{
				string text2 = text.ToLowerInvariant();
				if (text2.StartsWith("\\systemroot\\"))
				{
					text = Path.Combine(Environment.ExpandEnvironmentVariables("%SYSTEMROOT%"), text.Substring(12));
				}
				else if (text2.StartsWith("\\device\\"))
				{
					StringBuilder stringBuilder = new StringBuilder(256);
					foreach (string text3 in Environment.GetLogicalDrives())
					{
						if (GClass45.QueryDosDevice(text3.Substring(0, 2), stringBuilder, 256) > 0U)
						{
							string text4 = stringBuilder.ToString().ToLowerInvariant();
							if (text2.StartsWith(text4))
							{
								string text5 = text.Substring(text4.Length);
								if (text5.Length > 0 && text5.StartsWith("\\"))
								{
									text5 = text5.Substring(1);
								}
								text = Path.Combine(text3.Substring(0, 2), text5);
								break;
							}
						}
					}
				}
			}
			else
			{
				text = text.Substring(3);
			}
			text = new FileInfo(text).FullName;
		}
		catch
		{
		}
		if (bool_1)
		{
			if (genum51_1 == GEnum51.const_2)
			{
				try
				{
					string text6 = Class15.smethod_4();
					string text7 = text;
					if (text7.ToLowerInvariant().StartsWith(text6.ToLowerInvariant()))
					{
						text7 = Path.Combine(Class15.smethod_6(), text.Substring(text6.Length));
						if (!File.Exists(text7))
						{
							genum51_1 |= GEnum51.const_1;
						}
						else
						{
							text = text7;
						}
					}
				}
				catch
				{
				}
			}
			if (genum51_1 == GEnum51.const_1)
			{
				string text8 = Class15.smethod_4();
				if (text.ToLowerInvariant().StartsWith(text8.ToLowerInvariant()))
				{
					text = Path.Combine(Class15.smethod_5(), text.Substring(text8.Length));
				}
			}
		}
		return text;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x0004E428 File Offset: 0x0004C628
	private GClass44()
	{
		this.object_0 = new object();
		this.Boolean_1 = false;
		this.Int64_0 = -1L;
		this.GEnum21_0 = GEnum21.const_0;
		this.GEnum48_0 = GEnum48.const_0;
		this.String_0 = null;
		this.String_1 = null;
		this.string_3 = null;
		this.string_2 = null;
		this.string_4 = null;
		this.Int64_1 = 0L;
		this.string_5 = null;
		this.nullable_1 = new long?(0L);
		this.Nullable_0 = null;
		this.UInt32_0 = 0U;
		this.gclass17_0 = null;
		this.gclass0_0 = new GClass0();
		this.GEnum51_0 = GEnum51.const_0;
		this.object_1 = new object();
		this.list_0 = new List<GClass57>();
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0004E508 File Offset: 0x0004C708
	public GClass44(string string_6, GEnum48 genum48_1, bool bool_1 = false)
		: this()
	{
		this.GEnum48_0 = genum48_1;
		this.String_0 = string_6;
		this.String_1 = this.String_0;
		if (bool_1)
		{
			this.method_3();
		}
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x0004E540 File Offset: 0x0004C740
	public GClass44(string string_6, GEnum48 genum48_1, bool bool_1, GEnum51 genum51_1 = GEnum51.const_0, bool bool_2 = false)
		: this()
	{
		this.GEnum48_0 = genum48_1;
		this.String_0 = string_6;
		this.String_1 = GClass44.smethod_0(string_6, bool_1, ref genum51_1);
		this.GEnum51_0 = genum51_1;
		if (bool_2)
		{
			this.method_3();
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0004E584 File Offset: 0x0004C784
	public void method_3()
	{
		object obj = this.object_2;
		lock (obj)
		{
			if (this.Boolean_1)
			{
				return;
			}
			this.Boolean_1 = true;
		}
		FileStream fileStream = null;
		try
		{
			try
			{
				fileStream = new FileStream(this.String_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				this.nullable_0 = new bool?(true);
			}
			catch
			{
				fileStream = new FileStream(this.String_1, FileMode.Open, FileAccess.Read, FileShare.Read);
				this.nullable_0 = new bool?(true);
			}
		}
		catch
		{
			fileStream = null;
			this.Boolean_1 = false;
		}
		Class5.smethod_4(this.String_1, ref this.gclass0_0);
		try
		{
			this.nullable_0 = new bool?(File.Exists(this.String_1));
		}
		catch
		{
			this.nullable_0 = new bool?(false);
			this.Boolean_1 = false;
		}
		try
		{
			FileInfo fileInfo = new FileInfo(this.String_1);
			this.nullable_1 = new long?(fileInfo.Length);
		}
		catch
		{
			this.nullable_1 = new long?(0L);
			this.Boolean_1 = false;
		}
		if (this.string_5 == null)
		{
			this.string_5 = this.method_1(this.String_1);
		}
		if (this.string_4 == null)
		{
			this.string_4 = this.method_0(this.String_1);
		}
		if (fileStream != null)
		{
			if (this.string_3 == null || this.string_3 == Class14.String_215)
			{
				fileStream.Seek(0L, SeekOrigin.Begin);
				this.string_3 = Class15.smethod_12(fileStream);
				if (this.string_3 == Class14.String_215)
				{
					this.Boolean_1 = false;
				}
			}
			if (this.string_2 == null || this.string_2 == Class14.String_215)
			{
				fileStream.Seek(0L, SeekOrigin.Begin);
				this.string_2 = Class15.smethod_9(fileStream);
			}
			if (this.gclass17_0 == null)
			{
				try
				{
					fileStream.Seek(0L, SeekOrigin.Begin);
					this.gclass17_0 = new GClass17(fileStream, GEnum15.const_13);
				}
				catch (Exception)
				{
					this.gclass17_0 = null;
				}
			}
			try
			{
				fileStream.Close();
			}
			catch
			{
			}
		}
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0004E7E8 File Offset: 0x0004C9E8
	public virtual string ToString()
	{
		string text = string.Empty;
		string text3;
		try
		{
			if (this.GClass17_0 != null)
			{
				try
				{
					text = this.GClass17_0.ToString();
				}
				catch
				{
					text = string.Empty;
				}
			}
			List<string> list = new List<string>();
			for (int i = 0; i < this.list_0.Count; i++)
			{
				list.Add(this.list_0[i].ToString());
			}
			string text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(Class15.smethod_0(list, ';')));
			text3 = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}", new object[]
			{
				this.Int64_0,
				(int)this.GEnum48_0,
				(int)this.GEnum21_0,
				Class15.smethod_22(this.String_1),
				this.String_3,
				this.String_2,
				(this.Nullable_0 == null) ? "" : this.Nullable_0.Value.ToString(Class15.string_0, CultureInfo.InvariantCulture),
				this.Int64_1,
				this.Int64_2,
				this.Boolean_0 ? "1" : "0",
				this.UInt32_0,
				text,
				this.String_4,
				this.String_5,
				this.gclass0_0.method_0("!"),
				text2
			});
		}
		catch (Exception ex)
		{
			throw ex;
		}
		return text3;
	}

	// Token: 0x04000367 RID: 871
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04000368 RID: 872
	[CompilerGenerated]
	private GEnum48 genum48_0;

	// Token: 0x04000369 RID: 873
	[CompilerGenerated]
	private GEnum21 genum21_0;

	// Token: 0x0400036A RID: 874
	private bool? nullable_0;

	// Token: 0x0400036B RID: 875
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0400036C RID: 876
	[CompilerGenerated]
	private string string_1;

	// Token: 0x0400036D RID: 877
	private string string_2;

	// Token: 0x0400036E RID: 878
	private string string_3;

	// Token: 0x0400036F RID: 879
	private string string_4;

	// Token: 0x04000370 RID: 880
	[CompilerGenerated]
	private long long_1;

	// Token: 0x04000371 RID: 881
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000372 RID: 882
	private string string_5;

	// Token: 0x04000373 RID: 883
	private long? nullable_1;

	// Token: 0x04000374 RID: 884
	[CompilerGenerated]
	private DateTime? nullable_2;

	// Token: 0x04000375 RID: 885
	private GClass17 gclass17_0;

	// Token: 0x04000376 RID: 886
	[CompilerGenerated]
	private GEnum51 genum51_0;

	// Token: 0x04000377 RID: 887
	public GClass0 gclass0_0;

	// Token: 0x04000378 RID: 888
	private object object_0;

	// Token: 0x04000379 RID: 889
	private bool bool_0;

	// Token: 0x0400037A RID: 890
	private object object_1;

	// Token: 0x0400037B RID: 891
	private List<GClass57> list_0;

	// Token: 0x0400037C RID: 892
	private object object_2 = new object();
}
