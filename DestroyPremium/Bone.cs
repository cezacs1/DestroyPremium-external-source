using System;

// Token: 0x02000004 RID: 4
public class Bone
{
	// Token: 0x0600000A RID: 10 RVA: 0x000020D4 File Offset: 0x000002D4
	public Bone(string name, int value = 0)
	{
		this.name = name;
		this.value = value;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000020EA File Offset: 0x000002EA
	public void SetValue(int value)
	{
		this.value = value;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002DD4 File Offset: 0x00000FD4
	public int GetValue()
	{
		return this.value;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002DEC File Offset: 0x00000FEC
	public string GetName()
	{
		return this.name;
	}

	// Token: 0x04000003 RID: 3
	private string name;

	// Token: 0x04000004 RID: 4
	private int value;
}
