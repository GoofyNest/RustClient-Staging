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

	// RVA: 0x978F90 Offset: 0x977590 VA: 0x180978F90 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x979050 Offset: 0x977650 VA: 0x180979050 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x9790B0 Offset: 0x9776B0 VA: 0x1809790B0
	public void .ctor() { }

}

