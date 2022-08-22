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

	// RVA: 0x7426F0 Offset: 0x740CF0 VA: 0x1807426F0
	public void SetBreedIndex(int newIndex) { }

	// RVA: 0x742710 Offset: 0x740D10 VA: 0x180742710
	public void SetShowHair(bool wants) { }

	// RVA: 0x742700 Offset: 0x740D00 VA: 0x180742700
	public void SetShowArmor(bool showWood, bool showRoadsign) { }

	// RVA: 0x7424B0 Offset: 0x740AB0 VA: 0x1807424B0 Slot: 7
	public override void Init() { }

	// RVA: 0x742720 Offset: 0x740D20 VA: 0x180742720
	public void UpdateVisuals() { }

	// RVA: 0x742910 Offset: 0x740F10 VA: 0x180742910
	public void .ctor() { }

}

