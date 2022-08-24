public class LootSpawn : ScriptableObject // TypeDefIndex: 10747
{	public ItemAmountRanged[] items; // 0x18
	public LootSpawn.Entry[] subSpawn; // 0x20


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 10748
{	[TooltipAttribute] // RVA: 0x770E0 Offset: 0x764E0 VA: 0x1800770E0
	public int extraSpawns; // 0x0
	[TooltipAttribute] // RVA: 0x77270 Offset: 0x76670 VA: 0x180077270
	public LootSpawn category; // 0x8
	[TooltipAttribute] // RVA: 0x77350 Offset: 0x76750 VA: 0x180077350
	public int weight; // 0x10

}

