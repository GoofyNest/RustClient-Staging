public class WaterCatcher : LiquidContainer // TypeDefIndex: 9521
{	// Fields
	[HeaderAttribute] // RVA: 0x75FA0 Offset: 0x753A0 VA: 0x180075FA0
	public ItemDefinition itemToCreate; // 0x3F8
	public float maxItemToCreate; // 0x400
	[HeaderAttribute] // RVA: 0x76110 Offset: 0x75510 VA: 0x180076110
	public Vector3 rainTestPosition; // 0x404
	public float rainTestSize; // 0x410
	private const float collectInterval = 60;

	// Methods

	// RVA: 0x803CE0 Offset: 0x8022E0 VA: 0x180803CE0
	public void .ctor() { }

}

