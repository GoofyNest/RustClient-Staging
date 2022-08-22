public class ConstructionGrade : PrefabAttribute // TypeDefIndex: 9057
{	// Fields
	public Construction construction; // 0x98
	public BuildingGrade gradeBase; // 0xA0
	public GameObjectRef skinObject; // 0xA8
	internal List<ItemAmount> _costToBuild; // 0xB0

	// Properties
	public float maxHealth { get; }
	public List<ItemAmount> costToBuild { get; }

	// Methods

	// RVA: 0x6B0930 Offset: 0x6AEF30 VA: 0x1806B0930
	public float get_maxHealth() { }

	// RVA: 0x6B06E0 Offset: 0x6AECE0 VA: 0x1806B06E0
	public List<ItemAmount> get_costToBuild() { }

	// RVA: 0x6B0620 Offset: 0x6AEC20 VA: 0x1806B0620 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6B0680 Offset: 0x6AEC80 VA: 0x1806B0680
	public void .ctor() { }

}

