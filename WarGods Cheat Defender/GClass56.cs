using System;
using System.Net;
using System.Runtime.CompilerServices;

// Token: 0x020000D3 RID: 211
public class GClass56 : WebClient
{
	// Token: 0x170002DF RID: 735
	// (get) Token: 0x060006AE RID: 1710 RVA: 0x00063D1C File Offset: 0x00061F1C
	// (set) Token: 0x060006AF RID: 1711 RVA: 0x00063D30 File Offset: 0x00061F30
	public int Int32_0 { get; set; }

	// Token: 0x060006B0 RID: 1712 RVA: 0x00063D44 File Offset: 0x00061F44
	protected virtual WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		webRequest.Timeout = this.Int32_0;
		return webRequest;
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00063D64 File Offset: 0x00061F64
	public static HttpWebResponse smethod_0(Exception exception_0)
	{
		if (exception_0 is WebException)
		{
			WebException ex = (WebException)exception_0;
			if (ex.Response is HttpWebResponse)
			{
				return (HttpWebResponse)ex.Response;
			}
		}
		return null;
	}

	// Token: 0x0400099D RID: 2461
	[CompilerGenerated]
	private int int_0;
}
