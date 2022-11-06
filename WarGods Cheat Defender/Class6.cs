using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200002E RID: 46
internal class Class6
{
	// Token: 0x06000101 RID: 257 RVA: 0x00041DDC File Offset: 0x0003FFDC
	public static string smethod_0(string string_0)
	{
		try
		{
			return Class6.smethod_1(MD5.Create().ComputeHash(Encoding.Default.GetBytes(string_0)));
		}
		catch
		{
		}
		return "???";
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00041E20 File Offset: 0x00040020
	public static string smethod_1(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		for (;;)
		{
			IL_69:
			int num2 = ((num < byte_0.Length) ? 1215678727 : (-186543138));
			for (;;)
			{
				int num3 = num2;
				switch (~(-num3 * -394295051 - 1182261372) % 4)
				{
				case 0:
					num2 = 1215678727;
					continue;
				case 2:
					stringBuilder.Append(byte_0[num].ToString("X2"));
					num++;
					num2 = -349477508;
					continue;
				case 3:
					goto IL_69;
				}
				goto Block_1;
			}
		}
		Block_1:
		return stringBuilder.ToString();
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00041EA4 File Offset: 0x000400A4
	public static bool smethod_2(BinaryReader binaryReader_0, out string string_0, long long_0 = 0L, long long_1 = 0L, int int_0 = 4096)
	{
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		if (long_1 == 0L)
		{
			long_1 = binaryReader_0.BaseStream.Length;
		}
		if (long_0 >= long_1)
		{
			string_0 = null;
			return false;
		}
		long num = long_0;
		byte[] array = new byte[int_0];
		long position = binaryReader_0.BaseStream.Position;
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		for (;;)
		{
			if (num + (long)int_0 > long_1)
			{
				int_0 = (int)(long_1 - num);
			}
			if (int_0 == 0)
			{
				goto IL_8B;
			}
			if (binaryReader_0.BaseStream.Read(array, 0, int_0) <= 0)
			{
				break;
			}
			md5CryptoServiceProvider.TransformBlock(array, 0, int_0, null, 0);
			num += (long)int_0;
			if (num >= long_1)
			{
				goto IL_8B;
			}
		}
		string_0 = null;
		return false;
		IL_8B:
		binaryReader_0.BaseStream.Seek(position, SeekOrigin.Begin);
		md5CryptoServiceProvider.TransformFinalBlock(array, 0, 0);
		string_0 = BitConverter.ToString(md5CryptoServiceProvider.Hash).Replace("-", "");
		return true;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00041F74 File Offset: 0x00040174
	public static bool smethod_3(byte[] byte_0, out string string_0, long long_0 = 0L, long long_1 = 0L, int int_0 = 4096)
	{
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		if (long_1 == 0L)
		{
			long_1 = (long)byte_0.Length;
		}
		if (long_0 < long_1)
		{
			long num = long_0;
			do
			{
				if (num + (long)int_0 > long_1)
				{
					int_0 = (int)(long_1 - num);
				}
				if (int_0 == 0)
				{
					break;
				}
				md5CryptoServiceProvider.TransformBlock(byte_0, (int)num, int_0, null, 0);
				num += (long)int_0;
			}
			while (num < long_1);
			md5CryptoServiceProvider.TransformFinalBlock(byte_0, 0, 0);
			string_0 = BitConverter.ToString(md5CryptoServiceProvider.Hash).Replace("-", "");
			return true;
		}
		string_0 = null;
		return false;
	}
}
