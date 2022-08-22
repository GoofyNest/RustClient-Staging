public class LootSpawn : ScriptableObject // TypeDefIndex: 10743
{	public ItemAmountRanged[] items; // 0x18
	public LootSpawn.Entry[] subSpawn; // 0x20


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 10744
{	[TooltipAttribute] // RVA: 0x77620 Offset: 0x76A20 VA: 0x180077620
	public int extraSpawns; // 0x0
	[TooltipAttribute] // RVA: 0x777D0 Offset: 0x76BD0 VA: 0x1800777D0
	public LootSpawn category; // 0x8
	[TooltipAttribute] // RVA: 0x778E0 Offset: 0x76CE0 VA: 0x1800778E0
	public int weight; // 0x10

}

