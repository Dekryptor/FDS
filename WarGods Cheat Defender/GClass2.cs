using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000014 RID: 20
public class GClass2
{
	// Token: 0x06000072 RID: 114 RVA: 0x0003F9E8 File Offset: 0x0003DBE8
	public GClass2(byte[] byte_0)
	{
		int num = 0;
		int num2 = BitConverter.ToInt32(byte_0, 0);
		if (num2 <= 23)
		{
			if (num2 != 17)
			{
				if (num2 == 23)
				{
					this.GEnum1_0 = (GEnum1)23;
				}
			}
			else
			{
				this.GEnum1_0 = (GEnum1)17;
			}
		}
		else if (num2 != 26)
		{
			if (num2 == 30)
			{
				this.GEnum1_0 = (GEnum1)30;
			}
		}
		else
		{
			this.GEnum1_0 = (GEnum1)26;
		}
		num += 4;
		this.String_0 = Encoding.ASCII.GetString(byte_0, num, 4);
		num += 4;
		num += 4;
		this.Int32_0 = BitConverter.ToInt32(byte_0, num);
		num += 4;
		string @string = Encoding.Unicode.GetString(byte_0, num, 60);
		this.String_1 = @string.Substring(0, @string.IndexOf('\0')).Trim();
		num += 60;
		this.String_2 = BitConverter.ToInt32(byte_0, num).ToString("X");
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000073 RID: 115 RVA: 0x0003FAC0 File Offset: 0x0003DCC0
	public GEnum1 GEnum1_0 { get; }

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000074 RID: 116 RVA: 0x0003FAD4 File Offset: 0x0003DCD4
	public string String_0 { get; }

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000075 RID: 117 RVA: 0x0003FAE8 File Offset: 0x0003DCE8
	public int Int32_0 { get; }

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000076 RID: 118 RVA: 0x0003FAFC File Offset: 0x0003DCFC
	public string String_1 { get; }

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000077 RID: 119 RVA: 0x0003FB10 File Offset: 0x0003DD10
	public string String_2 { get; }

	// Token: 0x06000078 RID: 120 RVA: 0x0003FB24 File Offset: 0x0003DD24
	public virtual string ToString()
	{
		return string.Format("Version: {0}, Sig: {1}, File size: {2}, Executable name: {3}, Hash: {4}", new object[] { this.GEnum1_0, this.String_0, this.Int32_0, this.String_1, this.String_2 });
	}

	// Token: 0x04000050 RID: 80
	[CompilerGenerated]
	private readonly GEnum1 genum1_0;

	// Token: 0x04000051 RID: 81
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x04000052 RID: 82
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x04000053 RID: 83
	[CompilerGenerated]
	private readonly string string_1;

	// Token: 0x04000054 RID: 84
	[CompilerGenerated]
	private readonly string string_2;
}
