public class LootSpawn : ScriptableObject // TypeDefIndex: 10743
{	// Fields
	public ItemAmountRanged[] items; // 0x18
	public LootSpawn.Entry[] subSpawn; // 0x20

	// Methods

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 10744
{	// Fields
	[TooltipAttribute] // RVA: 0x77550 Offset: 0x76950 VA: 0x180077550
	public int extraSpawns; // 0x0
	[TooltipAttribute] // RVA: 0x776A0 Offset: 0x76AA0 VA: 0x1800776A0
	public LootSpawn category; // 0x8
	[TooltipAttribute] // RVA: 0x777B0 Offset: 0x76BB0 VA: 0x1800777B0
	public int weight; // 0x10

}

