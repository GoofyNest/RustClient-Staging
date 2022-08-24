public class WaterCatcher : LiquidContainer // TypeDefIndex: 9521
{	[HeaderAttribute] // RVA: 0x76140 Offset: 0x75540 VA: 0x180076140
	public ItemDefinition itemToCreate; // 0x3F8
	public float maxItemToCreate; // 0x400
	[HeaderAttribute] // RVA: 0x762B0 Offset: 0x756B0 VA: 0x1800762B0
	public Vector3 rainTestPosition; // 0x404
	public float rainTestSize; // 0x410
	private const float collectInterval = 60;


	public void .ctor() { }

}

