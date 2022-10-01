using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using DestroyPremium.Forms;

namespace DestroyPremium
{
	// Token: 0x0200001E RID: 30
	internal static class Program
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00006C9C File Offset: 0x00004E9C
		[STAThread]
		private static void Main()
		{
			//Program.KillSteam();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (!Program.IsAdministrator())
			{
				MessageBox.Show("Yönetici olarak başlatınız.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				Environment.Exit(0);
			}
			new Login().Show();
			Application.Run();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006CE8 File Offset: 0x00004EE8
		public static bool IsAdministrator()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006D0C File Offset: 0x00004F0C
		public static void DeleteSelf()
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T & Del \"" + Program.path + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe",
				Verb = "runas"
			};
			Process.Start(startInfo);
			Program.KillProcess(Path.GetFileNameWithoutExtension(Program.path));
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006D74 File Offset: 0x00004F74
		private static void KillSteam()
		{
			int num = Program.KillProcess("Steam");
			int num2 = Program.KillProcess("csgo");
			if (num > 0 || num2 > 0)
			{
				MessageBox.Show("Steam güvenlik sebebiyle kapatıldı.", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00006DB4 File Offset: 0x00004FB4
		private static int KillProcess(string processName)
		{
			int num = 0;
			foreach (Process process in Process.GetProcessesByName(processName))
			{
				process.Kill();
				num++;
			}
			return num;
		}

		// Token: 0x0400004D RID: 77
		public static string path = Assembly.GetExecutingAssembly().Location;

		// Token: 0x0400004E RID: 78
		public static string directory = Path.GetDirectoryName(Program.path);

		// Token: 0x0400004F RID: 79
		public const string currentVersion = "0.1";

		// Token: 0x04000050 RID: 80
		public static string newestVersion = string.Empty;

		// Token: 0x04000051 RID: 81
		public static string registeredMembers = string.Empty;

		// Token: 0x04000052 RID: 82
		public static string currentUser = string.Empty;

		// Token: 0x04000053 RID: 83
		public static bool currentUserAds = true;

		// Token: 0x04000054 RID: 84
		private static NumberFormatInfo format = new NumberFormatInfo
		{
			NumberGroupSeparator = "."
		};
	}
}
