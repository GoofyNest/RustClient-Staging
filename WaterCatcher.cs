public class WaterCatcher : LiquidContainer // TypeDefIndex: 9521
{	[HeaderAttribute] // RVA: 0x76130 Offset: 0x75530 VA: 0x180076130
	public ItemDefinition itemToCreate; // 0x3F8
	public float maxItemToCreate; // 0x400
	[HeaderAttribute] // RVA: 0x76250 Offset: 0x75650 VA: 0x180076250
	public Vector3 rainTestPosition; // 0x404
	public float rainTestSize; // 0x410
	private const float collectInterval = 60;


	public void .ctor() { }

}

