public class HorseRagdoll : AnimalRagdoll // TypeDefIndex: 8928
{	// Fields
	public GameObject mane; // 0xA8
	public GameObject woodArmor; // 0xB0
	public GameObject roadsignArmor; // 0xB8
	public HorseBreed overrideBreed; // 0xC0
	public GameObjectRef breedSource; // 0xC8
	private int breedIndex; // 0xD0
	private bool showHair; // 0xD4
	private bool showWoodArmor; // 0xD5
	private bool showRoadsignArmor; // 0xD6

	// Methods

	// RVA: 0x742640 Offset: 0x740C40 VA: 0x180742640
	public void SetBreedIndex(int newIndex) { }

	// RVA: 0x742660 Offset: 0x740C60 VA: 0x180742660
	public void SetShowHair(bool wants) { }

	// RVA: 0x742650 Offset: 0x740C50 VA: 0x180742650
	public void SetShowArmor(bool showWood, bool showRoadsign) { }

	// RVA: 0x742400 Offset: 0x740A00 VA: 0x180742400 Slot: 7
	public override void Init() { }

	// RVA: 0x742670 Offset: 0x740C70 VA: 0x180742670
	public void UpdateVisuals() { }

	// RVA: 0x742860 Offset: 0x740E60 VA: 0x180742860
	public void .ctor() { }

}

