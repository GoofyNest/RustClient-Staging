public class WaterPurifier : LiquidContainer // TypeDefIndex: 11261
{
	public GameObjectRef storagePrefab; 
	public Transform storagePrefabAnchor; 
	public ItemDefinition freshWater; 
	public int waterToProcessPerMinute; 
	public int freshWaterRatio; 
	public bool stopWhenOutputFull; 


	public bool IsBoiling() { }

	public void .ctor() { }

}

public static class WaterPurifier.WaterPurifierFlags // TypeDefIndex: 11262
{
	public const BaseEntity.Flags Boiling = 128;

}

