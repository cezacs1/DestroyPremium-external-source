using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

// Token: 0x02000009 RID: 9
internal static class Randomize
{
	// Token: 0x06000020 RID: 32 RVA: 0x000041A0 File Offset: 0x000023A0
	public static string String(int min = 8, int max = 16)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length - 10)].ToString() + new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", random.Next(min, max))
		select s[random.Next(s.Length)]).ToArray<char>());
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00004234 File Offset: 0x00002434
	public static bool Boolean()
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return random.Next(1) == 1;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00004264 File Offset: 0x00002464
	public static int Number(int min = 0, int max = 0)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return random.Next(min, max + 1);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00004298 File Offset: 0x00002498
	public static string Code(string element, string source)
	{
		Regex regex = new Regex(string.Concat(new string[]
		{
			"/\\*",
			element,
			"\\*/.*?/\\*",
			element,
			"\\*/"
		}));
		MatchCollection matchCollection = regex.Matches(source);
		foreach (object obj in matchCollection)
		{
			Match match = (Match)obj;
			string newValue = Randomize.String(8, 16);
			source = source.Replace(match.ToString(), newValue);
		}
		return source;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00004344 File Offset: 0x00002544
	public static string ReplaceNumbers(string source)
	{
		Regex regex = new Regex("/\\*number\\*/.*?/\\*number\\*/");
		MatchCollection matchCollection = regex.Matches(source);
		foreach (object obj in matchCollection)
		{
			Match match = (Match)obj;
			string text = match.ToString().Replace("/*number*/", "");
			int fromBase = (text.Length >= 2 && text.Substring(0, 2).ToLower() == "0x") ? 16 : 10;
			int num = Convert.ToInt32(text, fromBase);
			if (num != 0 && num != 1 && num >= 0)
			{
				Random random = new Random(Guid.NewGuid().GetHashCode());
				switch (random.Next(1, 4))
				{
				case 1:
				{
					int num2 = random.Next(1, num);
					int num3 = num + num2;
					source = source.ReplaceFirst(match.ToString(), num3.ToString() + " - " + num2.ToString());
					break;
				}
				case 2:
				{
					int num4 = random.Next(1, num);
					int num5 = num - num4;
					source = source.ReplaceFirst(match.ToString(), num5.ToString() + " + " + num4.ToString());
					break;
				}
				case 3:
				{
					int num6 = random.Next(2, 10);
					int num7 = num * num6;
					source = source.ReplaceFirst(match.ToString(), num7.ToString() + " / " + num6.ToString());
					break;
				}
				}
			}
		}
		return source;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00004524 File Offset: 0x00002724
	public static string RandomizeOrders(string source)
	{
		string result;
		if (source.NumberOf("/*order-start*/") == 0)
		{
			result = source;
		}
		else
		{
			string text = source;
			string text2 = string.Empty;
			List<string> list = new List<string>();
			Match match = null;
			Regex regex = new Regex("/\\*order-start\\*/.*?/\\*order-end\\*/", RegexOptions.Singleline);

			Regex regex2 = new Regex("/\\*order-\\*/.*?/\\*order-\\*/", RegexOptions.Singleline);
			MatchCollection matchCollection = regex2.Matches(match.ToString());
			foreach (object obj2 in matchCollection)
			{
				Match match3 = (Match)obj2;
				list.Add(match3.ToString().Replace("/*order-*/", ""));
			}
			if (list.Count > 1)
			{
				Randomize.Shuffle<string>(list);
			}
			foreach (string str in list)
			{
				text2 = text2 + str + Environment.NewLine;
			}
			result = Randomize.RandomizeOrders(source.Replace(match.ToString(), text2));
		}
		return result;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000046D0 File Offset: 0x000028D0
	public static void Shuffle<T>(IList<T> list)
	{
		RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
		int i = list.Count;
		while (i > 1)
		{
			byte[] array = new byte[1];
			do
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			while ((int)array[0] >= i * (255 / i));
			int index = (int)array[0] % i;
			i--;
			T value = list[index];
			list[index] = list[i];
			list[i] = value;
		}
	}
}
