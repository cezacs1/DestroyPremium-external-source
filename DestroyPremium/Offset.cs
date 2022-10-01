using System;

// Token: 0x0200001D RID: 29
public class Offset
{
	// Token: 0x0600008E RID: 142 RVA: 0x000022AB File Offset: 0x000004AB
	public Offset(string name, int value = 0)
	{
		this.name = name;
		this.value = value;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000022C1 File Offset: 0x000004C1
	public void SetValue(int value)
	{
		this.value = value;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00006C6C File Offset: 0x00004E6C
	public int GetValue()
	{
		return this.value;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00006C84 File Offset: 0x00004E84
	public string GetName()
	{
		return this.name;
	}

	// Token: 0x0400004B RID: 75
	private string name;

	// Token: 0x0400004C RID: 76
	private int value;
}
