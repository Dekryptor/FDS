using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200006B RID: 107
internal class Class13
{
	// Token: 0x17000155 RID: 341
	// (get) Token: 0x0600034B RID: 843 RVA: 0x0004CD00 File Offset: 0x0004AF00
	public static string String_0
	{
		get
		{
			return Class13.smethod_18(Class13.string_0, Class13.int_0);
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x0600034C RID: 844 RVA: 0x0004CD1C File Offset: 0x0004AF1C
	public static string String_1
	{
		get
		{
			return Class13.smethod_18(Class13.string_1, Class13.int_1);
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x0600034D RID: 845 RVA: 0x0004CD38 File Offset: 0x0004AF38
	public static string String_2
	{
		get
		{
			return Class13.smethod_18(Class13.string_2, Class13.int_2);
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x0600034E RID: 846 RVA: 0x0004CD54 File Offset: 0x0004AF54
	public static string String_3
	{
		get
		{
			return Class13.smethod_18(Class13.string_3, Class13.int_3);
		}
	}

	// Token: 0x0600034F RID: 847 RVA: 0x0004CD70 File Offset: 0x0004AF70
	public static string smethod_0(int int_4 = 32)
	{
		RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		byte[] array = new byte[int_4];
		randomNumberGenerator.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0004CD98 File Offset: 0x0004AF98
	public static byte[] smethod_1(int int_4 = 32)
	{
		RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		byte[] array = new byte[int_4];
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0004CDB8 File Offset: 0x0004AFB8
	public static string smethod_2(string string_6, byte[] byte_2, byte[] byte_3)
	{
		byte[] array = null;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Key = byte_2;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.IV = byte_3;
			rijndaelManaged.Mode = CipherMode.CBC;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(string_6);
						streamWriter.Flush();
					}
					cryptoStream.Flush();
				}
				array = memoryStream.ToArray();
			}
		}
		return Convert.ToBase64String(array);
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0004CEA0 File Offset: 0x0004B0A0
	public static string smethod_3(string string_6, byte[] byte_2, byte[] byte_3)
	{
		string text = null;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Key = byte_2;
			rijndaelManaged.IV = byte_3;
			byte[] array = Convert.FromBase64String(string_6);
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using (MemoryStream memoryStream = new MemoryStream(array))
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
				{
					cryptoStream.Flush();
					using (StreamReader streamReader = new StreamReader(cryptoStream))
					{
						text = streamReader.ReadToEnd();
					}
				}
			}
		}
		return text;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x0004CF78 File Offset: 0x0004B178
	public static byte[] smethod_4(string string_6, byte[] byte_2, byte[] byte_3)
	{
		byte[] array = null;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Key = byte_2;
			rijndaelManaged.IV = byte_3;
			byte[] array2 = Convert.FromBase64String(string_6);
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using (MemoryStream memoryStream = new MemoryStream(array2))
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
				{
					cryptoStream.Flush();
				}
				array = memoryStream.ToArray();
			}
		}
		return array;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x0004D030 File Offset: 0x0004B230
	public static string smethod_5(string string_6, byte[] byte_2)
	{
		return Class13.smethod_2(string_6, byte_2, Class13.byte_0);
	}

	// Token: 0x06000355 RID: 853 RVA: 0x0004D04C File Offset: 0x0004B24C
	public static string smethod_6(string string_6, byte[] byte_2)
	{
		return Class13.smethod_3(string_6, byte_2, Class13.byte_1);
	}

	// Token: 0x06000356 RID: 854 RVA: 0x0004D068 File Offset: 0x0004B268
	public static byte[] smethod_7(byte[] byte_2, string string_6)
	{
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		rsacryptoServiceProvider.FromXmlString(string_6);
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		byte[] array = rsacryptoServiceProvider.Encrypt(byte_2, true);
		rsacryptoServiceProvider.Clear();
		return array;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x0004D0A0 File Offset: 0x0004B2A0
	public static byte[] smethod_8(byte[] byte_2, string string_6)
	{
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		rsacryptoServiceProvider.FromXmlString(string_6);
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		byte[] array = rsacryptoServiceProvider.SignData(byte_2, new SHA1CryptoServiceProvider());
		rsacryptoServiceProvider.Clear();
		return array;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0004D0DC File Offset: 0x0004B2DC
	public static bool smethod_9(byte[] byte_2, byte[] byte_3, string string_6)
	{
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		rsacryptoServiceProvider.FromXmlString(string_6);
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		bool flag = rsacryptoServiceProvider.VerifyData(byte_2, new SHA1CryptoServiceProvider(), byte_3);
		rsacryptoServiceProvider.Clear();
		return flag;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0004D118 File Offset: 0x0004B318
	public static byte[] smethod_10(byte[] byte_2, string string_6)
	{
		RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		rsacryptoServiceProvider.FromXmlString(string_6);
		rsacryptoServiceProvider.PersistKeyInCsp = false;
		byte[] array = rsacryptoServiceProvider.Decrypt(byte_2, true);
		rsacryptoServiceProvider.Clear();
		return array;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0004D150 File Offset: 0x0004B350
	public static string smethod_11(string string_6)
	{
		byte[] array = Class13.smethod_10(Convert.FromBase64String(string_6), Class13.String_3);
		return Encoding.UTF8.GetString(array);
	}

	// Token: 0x0600035B RID: 859 RVA: 0x0004D17C File Offset: 0x0004B37C
	public static byte[] smethod_12(string string_6)
	{
		return Class13.smethod_10(Convert.FromBase64String(string_6), Class13.String_3);
	}

	// Token: 0x0600035C RID: 860 RVA: 0x0004D19C File Offset: 0x0004B39C
	public static string smethod_13(string string_6)
	{
		return Convert.ToBase64String(Class13.smethod_7(Encoding.ASCII.GetBytes(string_6), Class13.String_1));
	}

	// Token: 0x0600035D RID: 861 RVA: 0x0004D1C4 File Offset: 0x0004B3C4
	public static string smethod_14(string string_6)
	{
		return Convert.ToBase64String(Class13.smethod_8(Encoding.ASCII.GetBytes(string_6), Class13.String_0));
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0004D1EC File Offset: 0x0004B3EC
	public static bool smethod_15(string string_6, string string_7)
	{
		byte[] array = Convert.FromBase64String(string_6);
		byte[] array2 = Convert.FromBase64String(string_7);
		return Class13.smethod_9(array, array2, Class13.String_2);
	}

	// Token: 0x0600035F RID: 863 RVA: 0x0004D214 File Offset: 0x0004B414
	public static string smethod_16(int int_4)
	{
		StringBuilder stringBuilder = new StringBuilder();
		return stringBuilder.ToString();
	}

	// Token: 0x06000360 RID: 864 RVA: 0x0004D230 File Offset: 0x0004B430
	public static string smethod_17(string string_6, string string_7)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < string_6.Length; i++)
			{
				stringBuilder.Append(string_6[i] ^ string_7[i % string_7.Length]);
			}
			return stringBuilder.ToString();
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x06000361 RID: 865 RVA: 0x0004D294 File Offset: 0x0004B494
	public static string smethod_18(string string_6, int int_4)
	{
		if (int_4 >= 0 && int_4 < Class13.string_5.Length)
		{
			string text = Class13.string_5[int_4];
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in string_6)
			{
				int num = text.IndexOf(c);
				if (num == -1)
				{
					return null;
				}
				stringBuilder.Append(Class13.string_4[num]);
			}
			text = stringBuilder.ToString();
			byte[] array = Convert.FromBase64String(text);
			return Encoding.UTF8.GetString(array);
		}
		return null;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x0004D324 File Offset: 0x0004B524
	public static byte[] smethod_19(string string_6, int int_4)
	{
		if (int_4 >= 0 && int_4 < Class13.string_5.Length)
		{
			string text = Class13.string_5[int_4];
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in string_6)
			{
				int num = text.IndexOf(c);
				if (num == -1)
				{
					return null;
				}
				stringBuilder.Append(Class13.string_4[num]);
			}
			text = stringBuilder.ToString();
			return Convert.FromBase64String(text);
		}
		return null;
	}

	// Token: 0x06000363 RID: 867 RVA: 0x0004D3A0 File Offset: 0x0004B5A0
	public static bool smethod_20(BinaryReader binaryReader_0, out string string_6, long long_0 = 0L, long long_1 = 0L, int int_4 = 4096)
	{
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		if (long_1 == 0L)
		{
			long_1 = binaryReader_0.BaseStream.Length;
		}
		if (long_0 < long_1)
		{
			long num = long_0;
			byte[] array = new byte[int_4];
			long position = binaryReader_0.BaseStream.Position;
			binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
			for (;;)
			{
				if (num + (long)int_4 > long_1)
				{
					int_4 = (int)(long_1 - num);
				}
				if (int_4 == 0)
				{
					goto IL_85;
				}
				if (binaryReader_0.BaseStream.Read(array, 0, int_4) <= 0)
				{
					break;
				}
				md5CryptoServiceProvider.TransformBlock(array, 0, int_4, null, 0);
				num += (long)int_4;
				if (num >= long_1)
				{
					goto IL_85;
				}
			}
			string_6 = null;
			return false;
			IL_85:
			binaryReader_0.BaseStream.Seek(position, SeekOrigin.Begin);
			md5CryptoServiceProvider.TransformFinalBlock(array, 0, 0);
			string_6 = BitConverter.ToString(md5CryptoServiceProvider.Hash).Replace("-", "");
			return true;
		}
		string_6 = null;
		return false;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x0004D46C File Offset: 0x0004B66C
	public static bool smethod_21(byte[] byte_2, out string string_6, long long_0 = 0L, long long_1 = 0L, int int_4 = 4096)
	{
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		if (long_1 == 0L)
		{
			long_1 = (long)byte_2.Length;
		}
		if (long_0 < long_1)
		{
			long num = long_0;
			do
			{
				if (num + (long)int_4 > long_1)
				{
					int_4 = (int)(long_1 - num);
				}
				if (int_4 == 0)
				{
					break;
				}
				md5CryptoServiceProvider.TransformBlock(byte_2, (int)num, int_4, null, 0);
				num += (long)int_4;
			}
			while (num < long_1);
			md5CryptoServiceProvider.TransformFinalBlock(byte_2, 0, 0);
			string_6 = BitConverter.ToString(md5CryptoServiceProvider.Hash).Replace("-", "");
			return true;
		}
		string_6 = null;
		return false;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0004D4E8 File Offset: 0x0004B6E8
	public static string smethod_22(string string_6, int int_4 = 13)
	{
		char[] array = string_6.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			int num = (int)array[i];
			if (num >= 97 && num <= 122)
			{
				if (num > 109)
				{
					num -= int_4;
				}
				else
				{
					num += int_4;
				}
			}
			else if (num >= 65 && num <= 90)
			{
				if (num <= 77)
				{
					num += int_4;
				}
				else
				{
					num -= int_4;
				}
			}
			array[i] = (char)num;
		}
		return new string(array);
	}

	// Token: 0x0400030C RID: 780
	private static readonly int int_0 = 4;

	// Token: 0x0400030D RID: 781
	private static readonly string string_0 = "WuvJSRQXM7szoF7XW=BUoDZmoF7YWku8RN7vR7ZCUi4rokUfs9dDw2dU7qdkw=z2ZkjnRIjORL7S9IUjwmkrS2eilkUJhRmQRImWUi54NNwYCmZcsN5aZu/H7mvcCRXhJ8Rg9FjlNqQY5754ofUaUmIelJzNsXXqsiUWZizaM8p1Nx4DbIlEMIOaoiX3hEdU7RmiJFu/scQ25iUglXlElfk1JDm09iz0wm5coRmnN8/lokdlluXhNJzj5iu3lXp1UmzNRkZc3asb9Y/nbiB09RIaN=vIJFU4785XMuhBJkUUlDjJw2G1RR41Nk5zoY70SNaDoLXUsDZ/w7zYh2IBUNuCoNhrlmX8Nuveluzz7DhaM77UURucokrglRsilx/k98ZFMNvBw7s9Cu5kwaBnRidzRJZ0Nxs0Zx7DlaGrRFSe5fZsRNzURJadWqdUoDZmoF7YW=BuMF/1o27n5Le/RRuqWqduMF/1o27n5LrGRLe/hkmSoF+BlNelh8v45IXll7zKUL/4J2jxCxsswXuj7JXb7auQoajuUJXYRXIfR2z=Rxs/sI5bCX7mh=/SZIvfwXpDCm74SJ7aRmzJSY+EwkzY5X41985BC2zEJmkrCu7x9I5SN2e0JFzLRfvebidUhD4fZ=uY7m0ECNZYNiuDZX5YRRzcU=sQSNlB9xRr5RSDRXXSRXzjCkQZWJaG3mpVWuIVSReFJ70e5=7Ul2dnU9dxJ8v8S8wO3Dd0JusnRfsjRkra7a+fZL/f9Fs1UIe/CJX2Cke2S2jUJcGOlNj97FhEZfXE5ISeMNzRwkZUsFzulXjSoDQBCNZi927772ubU7Uc98s/ZXX0NxXKhm0YCXs07az/lIeYPDUYMF+DomIYNIez3m0roDeBZNkDNJ0O7Fv3hEdZ9JzW9m5eRJadWqdZW=BIRLe/9iu7UDQ9UXsJPY7L5ke2CIhO9FsZJI4ah8prR7j8R7/IsNzzRFsWl24ewfUKUkeS9YZB5Y+m3adZUJZRNx73h8ueMijeCNv/Cup1UYU8wDXz7XXgC8XFRRea52ag7FjQl8vsCDjebIjvhYvJZRQh9cQLRm/4w=ue7iZEofzqU8pEhJ+1SmZnNIQqsJpmSRUU7xvfUkQXha5ZWJaG3aZSW=BIRJe/SRXCMF7BCDrgCuZjS2vlsD0BMR+elDQ6oDu73Y/RUY7mJasghfXf78kglm+DwYwDRFXU58kEZDjshXjzoIjW7k41l9Qhsusql2snMLlOZFu7Nu7fZ2vrMFpmluz4Rk5RsL7=9LUq5DkalRjBNN5is2e43a0D58UnC=7nh=0EML71SNrrUm7v57UFwDUZ9awY5fkERijDlmUZWJaG3aZZW=BvoxsXwxUXRJe/Z2emUazZoRZECJsK72QeNksPRRH1Ci7e5N+eRLv/UXsSUR0f7IUnCN5YCY5nCu/rsaB7CazEZuv0Z2RDh7U47DeHsf7g9Fsz57IBUXjE7i4ewNvUNX5iwFpOZY71SfhDwNagJu4DRkQ3NiUCsivZ9k7lM25Nh8RY9RRmCDvPRRQzU7/7wxReRDvDlIeFoaRENuprURdvhDQ/WJaG3aXn527EwD7ZW=BIWku7o8ucofXYZfjBlRBZ527s9uUx5Y/PhxzHMkReh8uXUD5uCN+199d1w=uO9iOrUY+m5XjJbJzvhasOZ=v/S9QnUaeSSkzYs2mRZDHrJ2mabJ5eCNu6Mk0EwDec7DX6NFjDPfzFCm4D5Ie0o=+rPDXeSmREMIrEZR73siBW9DUe9L5sNujS97sFo7ZZJihDoDQzhX7ES2e7JRQlwJXuliXhbRuhRmjiw=5bhJXxMcQ2oNzxJ7ucM8sOU8v=R2aasD7ISfzOoiIeU2HgsRagZizX5LXFU8u79=z1Ncd7sX5OCFXkUFuWMRshPmz17aX75N0eUcdYN=X2bIGfwIRgsEQ8CNZQUx/=bJZ=lLZjoxsXlXvPJFXk9IIaSYXNZ=7k5NjZ7L54sNQrCRjk7JuHwRQZRJadWqdIW=O1RXU/9D7e72uH5NRV";

	// Token: 0x0400030E RID: 782
	private static readonly int int_1 = 9;

	// Token: 0x0400030F RID: 783
	private static readonly string string_1 = "jCakm/5NGrRL29rNjUAl20Zv29r3jVC8lVyck0aQrfl4RIZJ2/lLmIampHmMmIr/mIBH/kaKGNE9HHLL7flZivZD2SOCo3NJF0atovZtpS=AlfRr2uCVFuXkkCE7G9rBkvLIRUavlNLfF/r62TBbm/llE9N08NZD/UaBrfFAZtaX2vBVkveurWRorWO023FvGrr6i3BQoVC623Z6/WC0FSZ4pHCn2tmI/WlsE3KXZTCedUrM/SxJ8rNhHNLa29O1d0Nrp/AddHaRR4NKi0M1HCOQdf532TClptrNluCZrTRodUrvkUCD2TrIr4d3o/Zj205bENdAokLk8UE8p0Pxd0vbZTF1RTZarHNbFTB4ovE7FWRS/NOddINjlNE/l9Nl/ULkh0NSHTEVGrlepUEcFSvxk/NcGW8vkSPA8WBcrsP4ptKvEual/kuPjsPl20Zv29r3jUACG9B12tr6ETXB//CsjsPCG9B12tr6ETDyhvakm/5NGrRL29rNj=YY";

	// Token: 0x04000310 RID: 784
	public static byte[] byte_0 = new byte[]
	{
		125, 96, 242, 101, 0, 23, 63, 155, 214, 13,
		133, 133, 142, 216, 4, 247
	};

	// Token: 0x04000311 RID: 785
	private static readonly int int_2 = 0;

	// Token: 0x04000312 RID: 786
	private static readonly string string_2 = "BZ9G6ky47mDb0Pm4BVq10FUz0Pm8B/Zbvz4eUm4+ki1+DIyCvP9TGKy2lNZGURZClz1TvZ4d7kTLvWmRgm91gVgJEJyyDnnR7/sTtJaPU/a4vFyLlV4vgFyjvnzkLVZDERZqDWbj6zkK7P9ZLp4L2n4vlm9Djn6JmpD+EOqJOjyBGIkT1jaD1MaxgITFvRDyUz4ImpyMlZ/FGzgTmk9ILkDKkKKFEFDe1KlmjRwFEzbClImXmIe8E/UXEZmUvWmDEI=QUpUFk/eTEGb1vIzb18hsgFDUtFDB0PhLlFmBvZhbUkyElmbGjRUZEOZN0kUbgFZ40plN08m37IzsLR94EZbhLmL8jnmBDIUB6WmBmz4FkzUHUkAR7paI1pyG0KD/mR/FjO=qlP9Z1WU3xRLQ7I1RUZhvgV1mjPUU7N3M7Nh3Dn/QmzZtl8KaBMa10FUz0Pm8BVqZ7PhC0pmuliThkkZMBMaZ7PhC0pmulieStz9G6ky47mDb0Pm4BAYY";

	// Token: 0x04000313 RID: 787
	private static readonly int int_3 = 4;

	// Token: 0x04000314 RID: 788
	private static readonly string string_3 = "WuvJSRQXM7szoF7XW=BUoDZmoF7YWkuhJJ0fSaQWJ2dnMuXB5mvLJkeUo2ROUxsZ5JzbsDBXsfv0RNzn720roRQqJavvPYIBSkjulXzzUX/K9uwr98u6ZXuswkvzoIX7UkXEhfZ8UIejPmuKhJZzRLUlsx/hwRj0CFj7CaQhUFXXwu/3hNGElmXmCX5YUa7C9xvW7R5gJ85jbNjqsDQxRx0mbiQZ98+BZ2uQJRdvJxul7F4fsL7QJimxoqdDoidNSmIg5L/gUf4g99H1CY7hSX52JkdOlDSBw=ZYCkU/bizswNuZZIeUJRSYwusxNIBxoI5elYZh5IvB5YSO5aX2hRjhlIjYlFsaluImwFzfMIQUCRU/ULlmRN+YUXjssFXxsf/gsXwOMxRmwXsZSxU4bNmghN5zSJzU9cdgZFUn92vzsDXC5XshRJadWqdUoDZmoF7YW=BuMF/1o27n5Le/RRuqWqduMF/1o27n5LrGRLe/hNuZhDBDl75LJNQfUm/7sR7ERfu15Xvz3mlY5RUzCDvgNNdNlxjJ79Q37F/Hof5uwX+eCJ/6o9QQbL/XJmzEC=UYhmU6NkzcNFuRhfZFo7z3Z85H5NsuZxkDSXwg97RmZL5Z5i5gZmZxJ2jEN=XO7imYNR+1Za+abiviRX0fZ87FlkemwJ0YUkme587SJxs9M8jUCIj3UL/fWJaG3mpVWuIVSRdICazlw2U1JfX9oXIg9XsaZ=uboae8ZkucJLRaM8Z6JiUmR=ufbL7B9NXkhxvkRXZH3f7kUku73ae0bN715uzY3m7RU2Bj5muD5RrBsxzqR7//ZmzmhJ/P52jDPfzXCIs9UFXQbN7koDehRkjHbRBI5EHel77hNNXmJY79ZiBSlL0BwmXnlkdgJiQeUfh1JLuHCDaYS2vI5YadWqdZW=BIRLe/9xj/98/DUIeqMJXJUN7WUf/ehJwOh=/4h=RglR5v9Xvrw2zCC7ZOZkeUJku0l27lhRQ6ZizJ7=5KwRXNNFkrlkZnJLz4UkeXwIu1lk7Swk5C5LufsuZrMNUWo2mm77pDJDZx7xZzhaBrU77f92zUUuvghksmNxvL7XlYUFhrN=5F5Ed7sf7NZasX5uZbSakD3DU67flm5NefWJaG3aZSW=BIRJe/9aBiJcHas2z29FjBw7pEZmzOhfzXo2BZNusrl=XWbi0YZNSrb7v7l9dIbJu/5YkYw=srJuXrNi58570m3as1C7ZgRu0gZNe=57+mwf7INxSYZxzkoaIDZY/cNXzBlf0r5DZsw2ZrR2m3NkzfomSe7iXgZ85XwYsglDB0N7j/9EdSCLUelNGmsFwElDrDNN5F5FUmwaZO5aZZWJaG3aZZW=BvoxsXwxUXRJe/SJUjlR4r5idKo24eRmzBJIOr7NODJI7BwNz1wDRgJYSfSJsnsa53NNsFha59hX7qCf79oImh7Yu9ULu1sX7xwFuIoNd9smXll2uIhN5K3ajZNXjiRmslU7u=lIjPJiXCC=RmhkUuh8UShx/mJ=wEwRUvSYZWsm7eZDehbNjDoa4EoIvcUkdaJau0ZkrDM=Ig9N5Dhau0oxvxWJaG3aXn527EwD7ZW=BIWku0si4BJIQZsFIa9EQBsIXQluu3RNQK9RdsZRQmNL7aUmlf5X5Lb8uYRxzPNFzNRIBU7isQPadvhfuFS8jb5YZuU87/C9QjZNOm3aujsuSD7ijBo2znsEHgl75NZYub5aUWhkmxZ8pE5JuP9Re2PamulDmq9J0DlD5YZkQrMIhfoIuCsidLbFvnokjgwXUeSNsgwR5I5isgsRkYJkjmNR7fl=XUw8z0bNvSsx5/5RQKs2XWwDvzUYIB7NQZ9LvgZIaYlDSO9Xsnw8lDSx/J9Edl3Y/2J=5ewuXewcQsNNXeMIdFRavOsfjbJRekNXjHRFpEw7SaCiwDRNOgPmZQlL5jS2jzlRefsaHgZaUu9L+fJcQFJRd2JR5x9qQgMijebFw1sNBDlNjj5=/8s80DZYUBRJadWqdIW=O1RXU/9D7e72uH5NRV";

	// Token: 0x04000315 RID: 789
	public static byte[] byte_1 = new byte[]
	{
		23, 246, 65, 50, 110, 172, 29, 131, 25, 81,
		247, 18, 145, 12, 126, 92
	};

	// Token: 0x04000316 RID: 790
	private static readonly string string_4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";

	// Token: 0x04000317 RID: 791
	private static readonly string[] string_5 = new string[] { "whMinZIP=9xtE12B6UjGkmOWLDv0gl7cAb+V/4pN53XQsyuCdqJ8KzFReTHrSaofY", "VA/0KirSu=zRUNJXmDdG4f9Y82xIyp6oa1wgEWM5POqZ+7bhTL3jHnBkcvQCtFles", "ZrNTWYCMle7bJOLGBIPduQSUK1qgDiwAfjR54ao/p=+czm6vE0khy938nsXHFxVt2", "5MXIsbZJ+9S8uAkv3OB=j/y7dGEwrPcKiqm6FgnepQTHCoDh0xaNfRWtz2LlUV1Y4", "p/qLIuiF0vP3lUbWSZ9JR7N8hsCow5Mt+zc=kX2x4jKgHQn1OBEYamDfre6AGdVyT", "8Thbsz51JfArHq+jV6DnCcGUKdOtgQENFRaL=opYwySxWvlZm7MB0e4X2kP3i9/uI", "De3pAYFt1hmQl4I6HCP2T/8=KxNiRzGv9ME0WyBndwcbqUVSLoXfkagZ7Jru+js5O", "+6pW9NidFDRh=o5kMCfwO0sSgIBcGjQxa1tLrzYeKUlPZ/2ETXmH8ynV4A73vbJqu", "PYn74CE1SvIuoj5=zclkHed/pZbGsNtJX39A6Wa2yKRm08DV+UxOrBhTQgqfLMwFi", "wBsTSCf9Kaihdl7jmZok/rHW8Rp2FEGg=LbUVNt4eOQcx561MAJ3uv0IDXnzyPq+Y" };
}
