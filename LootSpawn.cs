public class LootSpawn : ScriptableObject // TypeDefIndex: 12510
{
	public ItemAmountRanged[] items;
	public LootSpawn.Entry[] subSpawn;


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 12511
{
	[TooltipAttribute]
	public int extraSpawns;
	[TooltipAttribute]
	public LootSpawn category;
	[TooltipAttribute]
	public int weight;

}

