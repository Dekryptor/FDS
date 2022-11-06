using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020000B8 RID: 184
internal class Class15
{
	// Token: 0x060005CD RID: 1485 RVA: 0x00056494 File Offset: 0x00054694
	public static string smethod_0(List<string> list_0, char char_3 = ';')
	{
		if (list_0 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < list_0.Count; i++)
		{
			stringBuilder.Append(list_0[i].ToString());
			if (i + 1 < list_0.Count)
			{
				stringBuilder.Append(char_3);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x000564EC File Offset: 0x000546EC
	public static string smethod_1(List<long> list_0, char char_3 = ';')
	{
		if (list_0 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < list_0.Count; i++)
		{
			stringBuilder.Append(list_0[i].ToString());
			if (i + 1 < list_0.Count)
			{
				stringBuilder.Append(char_3);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00056544 File Offset: 0x00054744
	public static string smethod_2(string[] string_4, char char_3 = ';')
	{
		if (string_4 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < string_4.Length; i++)
		{
			stringBuilder.Append(string_4[i].ToString());
			if (i + 1 < string_4.Length)
			{
				stringBuilder.Append(char_3);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00056590 File Offset: 0x00054790
	public static string smethod_3()
	{
		return Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.System));
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x000565AC File Offset: 0x000547AC
	public static string smethod_4()
	{
		return Path.Combine(Class15.smethod_3(), Class14.String_182 + "\\");
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x000565D4 File Offset: 0x000547D4
	public static string smethod_5()
	{
		return Path.Combine(Class15.smethod_3(), Class14.String_122 + "\\");
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x000565FC File Offset: 0x000547FC
	public static string smethod_6()
	{
		return Path.Combine(Class15.smethod_3(), Class14.String_200 + "\\");
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00056624 File Offset: 0x00054824
	public static string smethod_7(string string_4)
	{
		if (string.IsNullOrEmpty(string_4))
		{
			return null;
		}
		string text = null;
		try
		{
			string fullPath = Path.GetFullPath(string_4);
			text = fullPath.Substring(Path.GetPathRoot(fullPath).Length);
		}
		catch
		{
		}
		return text;
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0005666C File Offset: 0x0005486C
	public static string smethod_8(string string_4)
	{
		FileStream fileStream = null;
		try
		{
			try
			{
				fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			byte[] array;
			using (BinaryReader binaryReader = new BinaryReader(fileStream))
			{
				array = new SHA256Managed().ComputeHash(binaryReader.BaseStream);
			}
			return Class15.smethod_14(array);
		}
		catch
		{
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return Class14.String_215;
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x0005670C File Offset: 0x0005490C
	public static string smethod_9(FileStream fileStream_0)
	{
		try
		{
			BinaryReader binaryReader = new BinaryReader(fileStream_0);
			return Class15.smethod_14(new SHA256Managed().ComputeHash(binaryReader.BaseStream));
		}
		catch
		{
		}
		return Class14.String_215;
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00056754 File Offset: 0x00054954
	public static string smethod_10(string string_4)
	{
		return Class15.smethod_14(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(string_4)));
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0005677C File Offset: 0x0005497C
	public static string smethod_11(string string_4)
	{
		FileStream fileStream = null;
		try
		{
			if (File.Exists(string_4))
			{
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				try
				{
					fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.Read);
				}
				catch
				{
					fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				}
				md5CryptoServiceProvider.ComputeHash(fileStream);
				return Class15.smethod_14(md5CryptoServiceProvider.Hash);
			}
		}
		catch
		{
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return Class14.String_215;
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00056808 File Offset: 0x00054A08
	public static string smethod_12(FileStream fileStream_0)
	{
		try
		{
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			md5CryptoServiceProvider.ComputeHash(fileStream_0);
			return Class15.smethod_14(md5CryptoServiceProvider.Hash);
		}
		catch
		{
		}
		return Class14.String_215;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0005684C File Offset: 0x00054A4C
	public static string smethod_13(string string_4)
	{
		try
		{
			return Class15.smethod_14(MD5.Create().ComputeHash(Encoding.Default.GetBytes(string_4)));
		}
		catch
		{
		}
		return "???";
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00056890 File Offset: 0x00054A90
	public static string smethod_14(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < byte_0.Length; i++)
		{
			stringBuilder.Append(byte_0[i].ToString("x2"));
		}
		return stringBuilder.ToString().ToUpper();
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x000568D4 File Offset: 0x00054AD4
	public static string[] smethod_15(string string_4, string string_5, bool bool_0)
	{
		string[] array;
		try
		{
			array = Directory.GetFiles(string_4, string_5, (!bool_0) ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);
		}
		catch
		{
			array = null;
		}
		return array;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00056908 File Offset: 0x00054B08
	public static bool smethod_16(string string_4)
	{
		if (string_4 == null)
		{
			return false;
		}
		foreach (char c in string_4)
		{
			if (c == Class15.Class16.char_0 || (c >= Class15.Class16.char_1 && c < Class15.Class16.char_2) || (c > Class15.Class16.char_3 && c < Class15.Class16.char_4))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00056960 File Offset: 0x00054B60
	public static long smethod_17(string string_4)
	{
		FileStream fileStream = null;
		long num = 0L;
		try
		{
			try
			{
				fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			using (StreamReader streamReader = new StreamReader(fileStream))
			{
				while (streamReader.ReadLine() != null)
				{
					num += 1L;
				}
			}
		}
		catch
		{
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return num;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00056A00 File Offset: 0x00054C00
	public static string smethod_18(string string_4)
	{
		FileStream fileStream = null;
		string text = string.Empty;
		try
		{
			try
			{
				fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			using (StreamReader streamReader = new StreamReader(fileStream))
			{
				text = streamReader.ReadToEnd();
			}
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return text;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00056A7C File Offset: 0x00054C7C
	public static bool smethod_19(string string_4)
	{
		if (string_4 == null)
		{
			return false;
		}
		foreach (char c in string_4)
		{
			if (c < '\t' || ((c < '\t' || c > '\v') && (c < ' ' || c > '~')))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00056AC8 File Offset: 0x00054CC8
	public static int smethod_20(string string_4, string string_5)
	{
		int num = 0;
		try
		{
			int num2 = 0;
			while ((num2 = string_4.IndexOf(string_5, num2)) != -1)
			{
				num2 += string_5.Length;
				num++;
			}
		}
		catch
		{
		}
		return num;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00056B10 File Offset: 0x00054D10
	public static bool smethod_21(string string_4)
	{
		if (string_4 == null)
		{
			return false;
		}
		try
		{
			new Guid(string_4);
			return true;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00056B44 File Offset: 0x00054D44
	public static string smethod_22(string string_4)
	{
		if (string_4 == null)
		{
			return string.Empty;
		}
		string_4 = string_4.Replace(Class15.char_0.ToString(), Class15.string_1);
		string_4 = string_4.Replace(Class15.char_1.ToString(), Class15.string_2);
		string_4 = string_4.Replace(Class15.char_2.ToString(), Class15.string_3);
		string_4 = string_4.Trim();
		return string_4;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00056BB4 File Offset: 0x00054DB4
	public static int smethod_23(byte[] byte_0, byte[] byte_1, string string_4, int int_2 = 0, int int_3 = 0)
	{
		if (byte_0 != null && byte_1 != null && byte_1.Length == string_4.Length && string_4.Length != 0)
		{
			int num = -1;
			if (int_3 != 0)
			{
				int_3 -= byte_1.Length;
			}
			else
			{
				int_3 = byte_0.Length - byte_1.Length;
			}
			if (byte_0.Length != 0 && byte_1.Length != 0 && int_2 <= int_3 && byte_0.Length >= byte_1.Length)
			{
				if (string_4[0] == '\0')
				{
					throw new ArgumentException();
				}
				for (int i = int_2; i < int_3; i++)
				{
					if (byte_0[i] == byte_1[0])
					{
						if (byte_0.Length <= 1)
						{
							num = i;
							break;
						}
						bool flag = true;
						for (int j = 1; j < byte_1.Length; j++)
						{
							if (string_4[j] != '?')
							{
								if (byte_0[i + j] != byte_1[j])
								{
									flag = false;
									break;
								}
							}
						}
						if (flag)
						{
							num = i;
							break;
						}
					}
				}
			}
			return num;
		}
		throw new ArgumentNullException();
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00056C80 File Offset: 0x00054E80
	public static bool smethod_24(string string_4)
	{
		IPAddress ipaddress = null;
		return !string.IsNullOrEmpty(string_4) && IPAddress.TryParse(string_4, out ipaddress);
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00056CA4 File Offset: 0x00054EA4
	public static bool smethod_25(long long_2)
	{
		return long_2 - Class15.long_1 > 0L;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00056CC8 File Offset: 0x00054EC8
	public static int smethod_26(byte[] byte_0, byte[] byte_1, int int_2, ref int int_3)
	{
		if (byte_0 != null && byte_1 != null && int_2 >= -1)
		{
			if (int_2 == 0)
			{
				if (byte_0.Length <= byte_1.Length)
				{
					int_2 = byte_0.Length;
				}
				else
				{
					int_2 = byte_1.Length;
				}
			}
			else if (int_2 > byte_0.Length || int_2 > byte_1.Length)
			{
				throw new Exception("Invalid length");
			}
			int_3 = int_2;
			for (int i = 0; i < int_2; i++)
			{
				if (byte_0[i] > byte_1[i])
				{
					int_3 = i;
					return 1;
				}
				if (byte_0[i] < byte_1[i])
				{
					int_3 = i;
					return -1;
				}
			}
			return 0;
		}
		throw new Exception("Invalid parameter");
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00056D44 File Offset: 0x00054F44
	public static List<DirectoryInfo> smethod_27(DirectoryInfo directoryInfo_0)
	{
		if (directoryInfo_0 == null)
		{
			return null;
		}
		List<DirectoryInfo> list = new List<DirectoryInfo>();
		DirectoryInfo directoryInfo = directoryInfo_0;
		while (directoryInfo.Name != directoryInfo.Root.Name)
		{
			list.Add(directoryInfo);
			directoryInfo = directoryInfo.Parent;
		}
		list.Add(directoryInfo.Root);
		list.Reverse();
		return list;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00056D9C File Offset: 0x00054F9C
	public static List<DirectoryInfo> smethod_28(string string_4)
	{
		if (string_4 == null)
		{
			return null;
		}
		return Class15.smethod_27(new DirectoryInfo(string_4));
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00056DBC File Offset: 0x00054FBC
	public static string[] smethod_29(string string_4, string string_5, int int_2 = 1)
	{
		List<string> list = new List<string>();
		if (int_2 <= 0)
		{
			return list.ToArray();
		}
		try
		{
			Directory.GetFiles(string_4, string_5, SearchOption.TopDirectoryOnly);
		}
		catch (UnauthorizedAccessException)
		{
		}
		return list.ToArray();
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00056E00 File Offset: 0x00055000
	public static bool smethod_30(List<string> list_0, string string_4, bool bool_0 = false)
	{
		if (list_0 != null && string_4 != null)
		{
			if (bool_0)
			{
				foreach (string text in list_0)
				{
					if (string_4 == text)
					{
						return true;
					}
				}
				return false;
			}
			string text2 = string_4.ToLowerInvariant();
			foreach (string text3 in list_0)
			{
				if (text2 == text3.ToLowerInvariant())
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x04000937 RID: 2359
	public static readonly int int_0 = 60000;

	// Token: 0x04000938 RID: 2360
	public static readonly int int_1 = 256;

	// Token: 0x04000939 RID: 2361
	public static readonly string string_0 = "dd.MM.yyyy HH:mm:ss";

	// Token: 0x0400093A RID: 2362
	public static readonly char char_0 = ';';

	// Token: 0x0400093B RID: 2363
	public static readonly string string_1 = "%3B";

	// Token: 0x0400093C RID: 2364
	public static readonly char char_1 = '|';

	// Token: 0x0400093D RID: 2365
	public static readonly string string_2 = "%7C";

	// Token: 0x0400093E RID: 2366
	public static readonly char char_2 = '!';

	// Token: 0x0400093F RID: 2367
	public static readonly string string_3 = "%21";

	// Token: 0x04000940 RID: 2368
	public static readonly long long_0 = 76561197960265728L;

	// Token: 0x04000941 RID: 2369
	public static readonly long long_1 = 76561190000000000L;

	// Token: 0x020000B9 RID: 185
	public static class Class16
	{
		// Token: 0x04000942 RID: 2370
		public static char char_0 = '\0';

		// Token: 0x04000943 RID: 2371
		public static char char_1 = '\u0005';

		// Token: 0x04000944 RID: 2372
		public static char char_2 = '\b';

		// Token: 0x04000945 RID: 2373
		public static char char_3 = '\r';

		// Token: 0x04000946 RID: 2374
		public static char char_4 = '\u001a';
	}
}
