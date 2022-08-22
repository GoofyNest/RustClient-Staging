public class ArmorInformationPanel : ItemInformationPanel // TypeDefIndex: 10981
{	// Fields
	public ItemTextValue projectileDisplay; // 0x18
	public ItemTextValue meleeDisplay; // 0x20
	public ItemTextValue coldDisplay; // 0x28
	public ItemTextValue explosionDisplay; // 0x30
	public ItemTextValue radiationDisplay; // 0x38
	public ItemTextValue biteDisplay; // 0x40
	public ItemTextValue spacer; // 0x48
	public Text areaProtectionText; // 0x50
	public Translate.Phrase LegText; // 0x58
	public Translate.Phrase ChestText; // 0x60
	public Translate.Phrase HeadText; // 0x68
	public Translate.Phrase ChestLegsText; // 0x70
	public Translate.Phrase WholeBodyText; // 0x78
	public ItemTextValue eggVision; // 0x80

	// Methods

	// RVA: 0x82E240 Offset: 0x82C840 VA: 0x18082E240 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x82E320 Offset: 0x82C920 VA: 0x18082E320
	public string ProtectionAreaText(ItemModWearable wearable) { }

	// RVA: 0x82E430 Offset: 0x82CA30 VA: 0x18082E430 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

