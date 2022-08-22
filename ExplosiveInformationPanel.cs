public class ExplosiveInformationPanel : ItemInformationPanel // TypeDefIndex: 11003
{	// Fields
	public ItemTextValue explosiveDmgDisplay; // 0x18
	public ItemTextValue lethalDmgDisplay; // 0x20
	public ItemTextValue throwDistanceDisplay; // 0x28
	public ItemTextValue projectileDistanceDisplay; // 0x30
	public ItemTextValue fuseLengthDisplay; // 0x38
	public ItemTextValue blastRadiusDisplay; // 0x40
	public Text unreliableText; // 0x48

	// Methods

	// RVA: 0x8D37D0 Offset: 0x8D1DD0 VA: 0x1808D37D0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8D3A50 Offset: 0x8D2050 VA: 0x1808D3A50 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

