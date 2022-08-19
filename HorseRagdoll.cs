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

	// RVA: 0x7425E0 Offset: 0x740BE0 VA: 0x1807425E0
	public void SetBreedIndex(int newIndex) { }

	// RVA: 0x742600 Offset: 0x740C00 VA: 0x180742600
	public void SetShowHair(bool wants) { }

	// RVA: 0x7425F0 Offset: 0x740BF0 VA: 0x1807425F0
	public void SetShowArmor(bool showWood, bool showRoadsign) { }

	// RVA: 0x7423A0 Offset: 0x7409A0 VA: 0x1807423A0 Slot: 7
	public override void Init() { }

	// RVA: 0x742610 Offset: 0x740C10 VA: 0x180742610
	public void UpdateVisuals() { }

	// RVA: 0x742800 Offset: 0x740E00 VA: 0x180742800
	public void .ctor() { }

}

