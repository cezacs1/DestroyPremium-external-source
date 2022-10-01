using System;

// Token: 0x0200000D RID: 13
public static class JunkGenerator
{
	// Token: 0x06000033 RID: 51 RVA: 0x00004CA8 File Offset: 0x00002EA8
	public static string Junkify(this string source)
	{
		string text = string.Empty;
		string[] array = source.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		foreach (string text2 in array)
		{
			if (text2.Contains("junk_method"))
			{
				text = text + JunkGenerator.GenerateMethod() + "\n";
			}
			else if (text2.Contains("junk_line"))
			{
				text = text + JunkGenerator.GenerateLine() + "\n";
			}
			else
			{
				text = text + text2 + "\n";
			}
		}
		return text;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00004D38 File Offset: 0x00002F38
	private static string GenerateMethod()
	{
		string text = string.Empty;
		string str = string.Empty;
		string text2 = "void";
		string text3 = Randomize.String(8, 16);
		int num = Randomize.Number(0, 3);
		switch (num)
		{
		case 1:
			text2 = "string";
			str = "\"" + Randomize.String(8, 16) + "\"";
			break;
		case 2:
			text2 = "int";
			str = Randomize.Number(11111, 99999).ToString();
			break;
		case 3:
			text2 = "float";
			str = string.Format("{0}.{1}f", Randomize.Number(11111, 99999), Randomize.Number(0, 99));
			break;
		}
		text = string.Concat(new string[]
		{
			text,
			"public static ",
			text2,
			" ",
			text3,
			"() {\n"
		});
		for (int i = 0; i < Randomize.Number(5, 30); i++)
		{
			text += JunkGenerator.GenerateLine();
		}
		if (num > 0)
		{
			text = text + "return " + str + ";\n";
		}
		return text + "}";
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00004E78 File Offset: 0x00003078
	private static string GenerateLine()
	{
		string text = string.Empty;
		string text2 = string.Empty;
		string text3 = Randomize.String(8, 16);
		switch (Randomize.Number(0, 2))
		{
		case 0:
			text = string.Concat(new string[]
			{
				text,
				"string ",
				text3,
				" = \"",
				Randomize.String(8, 16),
				"\";\n"
			});
			return string.Concat(new string[]
			{
				text,
				text3,
				" += \"",
				Randomize.String(4, 8),
				"\";\n"
			});
		case 1:
			text += string.Format("int {0} = {1};\n", text3, Randomize.Number(1111, 9999));
			text2 = Randomize.Number(500, 1000).ToString();
			break;
		case 2:
			text += string.Format("float {0} = {1}.{2}f;\n", text3, Randomize.Number(1111, 9999), Randomize.Number(0, 99));
			text2 = Randomize.Number(500, 1000).ToString() + "." + Randomize.Number(0, 99).ToString() + "f";
			break;
		}
		switch (Randomize.Number(0, 2))
		{
		case 0:
			text = string.Concat(new string[]
			{
				text,
				text3,
				" += ",
				text2,
				";\n"
			});
			break;
		case 1:
			text = string.Concat(new string[]
			{
				text,
				text3,
				" -= ",
				text2,
				";\n"
			});
			break;
		case 2:
			text = string.Concat(new string[]
			{
				text,
				text3,
				" *= ",
				text2,
				";\n"
			});
			break;
		}
		return text;
	}
}
