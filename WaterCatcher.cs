public class WaterCatcher : LiquidContainer // TypeDefIndex: 9521
{	// Fields
	[HeaderAttribute] // RVA: 0x76070 Offset: 0x75470 VA: 0x180076070
	public ItemDefinition itemToCreate; // 0x3F8
	public float maxItemToCreate; // 0x400
	[HeaderAttribute] // RVA: 0x761E0 Offset: 0x755E0 VA: 0x1800761E0
	public Vector3 rainTestPosition; // 0x404
	public float rainTestSize; // 0x410
	private const float collectInterval = 60;

	// Methods

	// RVA: 0x803DF0 Offset: 0x8023F0 VA: 0x180803DF0
	public void .ctor() { }

}

