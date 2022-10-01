using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.CSharp;

// Token: 0x02000005 RID: 5
internal class Compiler
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002E04 File Offset: 0x00001004
	public static List<string> Compile(string source, string output)
	{
		List<string> list = new List<string>();
		CompilerResults compilerResults = Compiler.CompileCsharpSource(new string[]
		{
			source
		}, output, new string[]
		{
			"System.dll",
			"System.Core.dll"
		});
		List<string> result;
		if (compilerResults.Errors.Count == 0)
		{
			result = list;
		}
		else
		{
			foreach (object obj in compilerResults.Errors)
			{
				CompilerError compilerError = (CompilerError)obj;
				list.Add(compilerError.Line.ToString() + ": " + compilerError.ErrorText);
			}
			result = list;
		}
		return result;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002ECC File Offset: 0x000010CC
	private static CompilerResults CompileCsharpSource(string[] sources, string output, params string[] references)
	{
		CompilerParameters compilerParameters = new CompilerParameters(references, output);
		compilerParameters.GenerateExecutable = true;
		compilerParameters.CompilerOptions = "/platform:x86 /optimize- /unsafe";
		CompilerResults result;
		using (CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider(new Dictionary<string, string>
		{
			{
				"CompilerVersion",
				"v4.0"
			}
		}))
		{
			result = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, sources);
		}
		return result;
	}
}
