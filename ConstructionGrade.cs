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

	// RVA: 0x6B09A0 Offset: 0x6AEFA0 VA: 0x1806B09A0
	public float get_maxHealth() { }

	// RVA: 0x6B0750 Offset: 0x6AED50 VA: 0x1806B0750
	public List<ItemAmount> get_costToBuild() { }

	// RVA: 0x6B0690 Offset: 0x6AEC90 VA: 0x1806B0690 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6B06F0 Offset: 0x6AECF0 VA: 0x1806B06F0
	public void .ctor() { }

}

