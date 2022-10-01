using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace DestroyPremium.Properties
{
	// Token: 0x02000020 RID: 32
	internal class Resources
	{
		// Token: 0x0600009B RID: 155 RVA: 0x000020AF File Offset: 0x000002AF
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006F54 File Offset: 0x00005154
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("DestroyPremium.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00006F94 File Offset: 0x00005194
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000022CA File Offset: 0x000004CA
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00006FA8 File Offset: 0x000051A8
		internal static string AimbotMath
		{
			get
			{
				return Resources.ResourceManager.GetString("AimbotMath", Resources.resourceCulture);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00006FCC File Offset: 0x000051CC
		internal static Bitmap destlogopng
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("destlogopng", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00006FF8 File Offset: 0x000051F8
		internal static string Memory
		{
			get
			{
				return Resources.ResourceManager.GetString("Memory", Resources.resourceCulture);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000701C File Offset: 0x0000521C
		internal static string Offsets
		{
			get
			{
				return Resources.ResourceManager.GetString("Offsets", Resources.resourceCulture);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00007040 File Offset: 0x00005240
		internal static string Program
		{
			get
			{
				return Resources.ResourceManager.GetString("Program", Resources.resourceCulture);
			}
		}

		// Token: 0x04000055 RID: 85
		private static ResourceManager resourceMan;

		// Token: 0x04000056 RID: 86
		private static CultureInfo resourceCulture;
	}
}
