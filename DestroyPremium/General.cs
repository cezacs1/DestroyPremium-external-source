using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x02000007 RID: 7
internal static class General
{
	// Token: 0x06000016 RID: 22 RVA: 0x00003F70 File Offset: 0x00002170
	public static string GetMachineGuid()
	{
		string text = "SOFTWARE\\Microsoft\\Cryptography";
		string text2 = "MachineGuid";
		string result;
		using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
		{
			using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
			{
				if (registryKey2 == null)
				{
					throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
				}
				object value = registryKey2.GetValue(text2);
				if (value == null)
				{
					throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
				}
				result = value.ToString();
			}
		}
		return result;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00004018 File Offset: 0x00002218
	public static string ReplaceComment(this string source, string setting, string value)
	{
		Regex regex = new Regex(string.Concat(new string[]
		{
			"/\\*",
			setting,
			"\\*/.*?/\\*",
			setting,
			"\\*/"
		}), RegexOptions.Singleline);
		MatchCollection matchCollection = regex.Matches(source);
		foreach (object obj in matchCollection)
		{
			Match match = (Match)obj;
			source = source.Replace(match.ToString(), value);
		}
		return source;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000040B8 File Offset: 0x000022B8
	public static string EraseComment(string source, string setting)
	{
		return source.ReplaceComment(setting, string.Empty);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000210A File Offset: 0x0000030A
	public static void NullifyProxy(this WebClient web)
	{
		web.Proxy = null;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000040D4 File Offset: 0x000022D4
	public static string Reverse(this string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000040F8 File Offset: 0x000022F8
	public static string DecodeB64(this string s)
	{
		byte[] bytes = Convert.FromBase64String(s);
		return Encoding.UTF8.GetString(bytes);
	}


	public static bool IsNull(this object T)
	{
		return T == null;
	}


}
