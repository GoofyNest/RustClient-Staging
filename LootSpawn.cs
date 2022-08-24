public class LootSpawn : ScriptableObject // TypeDefIndex: 10747
{	public ItemAmountRanged[] items; // 0x18
	public LootSpawn.Entry[] subSpawn; // 0x20


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 10748
{	[TooltipAttribute] // RVA: 0x77940 Offset: 0x76D40 VA: 0x180077940
	public int extraSpawns; // 0x0
	[TooltipAttribute] // RVA: 0x77A50 Offset: 0x76E50 VA: 0x180077A50
	public LootSpawn category; // 0x8
	[TooltipAttribute] // RVA: 0x77B10 Offset: 0x76F10 VA: 0x180077B10
	public int weight; // 0x10

}

