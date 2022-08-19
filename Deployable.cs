public class Deployable : PrefabAttribute // TypeDefIndex: 9851
{	// Fields
	public Mesh guideMesh; // 0x98
	public Vector3 guideMeshScale; // 0xA0
	public bool guideLights; // 0xAC
	public bool wantsInstanceData; // 0xAD
	public bool copyInventoryFromItem; // 0xAE
	public bool setSocketParent; // 0xAF
	public bool toSlot; // 0xB0
	public BaseEntity.Slot slot; // 0xB4
	public GameObjectRef placeEffect; // 0xB8
	public Bounds bounds; // 0xC0

	// Methods

	// RVA: 0x978E80 Offset: 0x977480 VA: 0x180978E80 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x978F40 Offset: 0x977540 VA: 0x180978F40 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x978FA0 Offset: 0x9775A0 VA: 0x180978FA0
	public void .ctor() { }

}

