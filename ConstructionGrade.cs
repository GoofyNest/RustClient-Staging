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

	// RVA: 0x6B0890 Offset: 0x6AEE90 VA: 0x1806B0890
	public float get_maxHealth() { }

	// RVA: 0x6B0640 Offset: 0x6AEC40 VA: 0x1806B0640
	public List<ItemAmount> get_costToBuild() { }

	// RVA: 0x6B0580 Offset: 0x6AEB80 VA: 0x1806B0580 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6B05E0 Offset: 0x6AEBE0 VA: 0x1806B05E0
	public void .ctor() { }

}

