using System;
using System.Text.RegularExpressions;

// Token: 0x0200000B RID: 11
public static class StringExtension
{
	// Token: 0x06000029 RID: 41 RVA: 0x00004740 File Offset: 0x00002940
	public static string ReplaceFirst(this string text, string search, string replace)
	{
		int num = text.IndexOf(search);
		string result;
		if (num < 0)
		{
			result = text;
		}
		else
		{
			result = text.Substring(0, num) + replace + text.Substring(num + search.Length);
		}
		return result;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00004780 File Offset: 0x00002980
	public static string EraseFirst(this string text, string search)
	{
		return text.ReplaceFirst(search, "");
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000479C File Offset: 0x0000299C
	public static int NumberOf(this string haystack, string needle)
	{
		return new Regex(Regex.Escape(needle)).Matches(haystack).Count;
	}
}
