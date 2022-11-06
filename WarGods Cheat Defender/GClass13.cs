using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x0200002D RID: 45
public class GClass13
{
	// Token: 0x060000FB RID: 251 RVA: 0x00041B50 File Offset: 0x0003FD50
	public GClass13(byte[] byte_0)
	{
		this.List_0 = new List<string>();
		this.method_0(byte_0);
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00041B78 File Offset: 0x0003FD78
	public GClass13(X509Certificate2 x509Certificate2_0)
	{
		this.List_0 = new List<string>();
		foreach (X509Extension x509Extension in x509Certificate2_0.Extensions)
		{
			if (x509Extension.Oid.Value == "2.5.29.31")
			{
				this.method_0(x509Extension.RawData);
			}
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060000FD RID: 253 RVA: 0x00041BD8 File Offset: 0x0003FDD8
	// (set) Token: 0x060000FE RID: 254 RVA: 0x00041BEC File Offset: 0x0003FDEC
	public List<string> List_0 { get; set; }

	// Token: 0x060000FF RID: 255 RVA: 0x00041C00 File Offset: 0x0003FE00
	private void method_0(byte[] byte_0)
	{
		int num = byte_0.Length;
		int i = 0;
		while (i < num - 5)
		{
			if (byte_0[i] != 104)
			{
				goto IL_3C;
			}
			if (byte_0[i + 1] != 116)
			{
				goto IL_3C;
			}
			if (byte_0[i + 2] != 116)
			{
				goto IL_3C;
			}
			if (byte_0[i + 3] != 112 || byte_0[i + 4] != 58)
			{
				goto IL_3C;
			}
			goto IL_7A;
			IL_182:
			i++;
			continue;
			IL_3C:
			if (byte_0[i] != 108)
			{
				goto IL_182;
			}
			if (byte_0[i + 1] != 100)
			{
				goto IL_182;
			}
			if (byte_0[i + 2] != 97)
			{
				goto IL_182;
			}
			if (byte_0[i + 3] != 112 || byte_0[i + 4] != 58)
			{
				goto IL_182;
			}
			IL_7A:
			List<byte> list = new List<byte>();
			int j = i;
			while (j < num)
			{
				if (byte_0[j - 4] == 46 && byte_0[j - 3] == 99)
				{
					if (byte_0[j - 2] == 114)
					{
						if (byte_0[j - 1] == 108)
						{
							goto IL_102;
						}
					}
				}
				if (byte_0[j] == 98)
				{
					if (byte_0[j + 1] == 97)
					{
						if (byte_0[j + 2] == 115)
						{
							if (byte_0[j + 3] == 101)
							{
								goto IL_102;
							}
						}
					}
				}
				if (byte_0[j] >= 32 && byte_0[j] <= 126)
				{
					list.Add(byte_0[j]);
					j++;
					continue;
				}
				i = j;
				break;
				IL_102:
				i = j;
				break;
			}
			string text = Encoding.ASCII.GetString(list.ToArray());
			if (this.method_1(text) && text.StartsWith("http://") && text.EndsWith(".crl"))
			{
				this.List_0.Add(text);
			}
			if (text.StartsWith("ldap:", StringComparison.InvariantCulture))
			{
				text = "ldap://" + text.Split(new char[] { '/' })[2];
				this.List_0.Add(text);
				goto IL_182;
			}
			goto IL_182;
		}
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00041D9C File Offset: 0x0003FF9C
	private bool method_1(string string_0)
	{
		Uri uri;
		return Uri.TryCreate(string_0, UriKind.Absolute, out uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
	}

	// Token: 0x04000163 RID: 355
	[CompilerGenerated]
	private List<string> list_0;
}
