public class WaterPurifier : LiquidContainer // TypeDefIndex: 9523
{	// Fields
	public GameObjectRef storagePrefab; // 0x3F8
	public Transform storagePrefabAnchor; // 0x400
	public ItemDefinition freshWater; // 0x408
	public int waterToProcessPerMinute; // 0x410
	public int freshWaterRatio; // 0x414
	public bool stopWhenOutputFull; // 0x418

	// Methods

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsBoiling() { }

	// RVA: 0xC1A9F0 Offset: 0xC18FF0 VA: 0x180C1A9F0
	public void .ctor() { }

}

public static class WaterPurifier.WaterPurifierFlags // TypeDefIndex: 9524
{	// Fields
	public const BaseEntity.Flags Boiling = 128;

}

