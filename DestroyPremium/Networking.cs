using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace DestroyPremium
{
	// Token: 0x0200001F RID: 31
	internal class Networking
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00006E50 File Offset: 0x00005050
		public static void DownloadFile(string url, string path)
		{
			string directoryName = Path.GetDirectoryName(path);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			using (WebClient webClient = new WebClient())
			{
				webClient.NullifyProxy();
				webClient.DownloadFile(url, path);
			}
		}

		public static dynamic Login(string username, string password)
		{
			object result;
			try
			{
				string text = string.Empty;
				using (WebClient webClient = new WebClient())
				{
					webClient.NullifyProxy();
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["username"] = username;
					nameValueCollection["password"] = password;
					nameValueCollection["cheat"] = "external";
					nameValueCollection["hwid"] = General.GetMachineGuid();
					byte[] bytes = webClient.UploadValues("https://destroypremium.com/auth.php", nameValueCollection);
					text = Encoding.Default.GetString(bytes);
				}
				result = text;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
