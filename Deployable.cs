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

	// RVA: 0x979490 Offset: 0x977A90 VA: 0x180979490 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x979550 Offset: 0x977B50 VA: 0x180979550 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x9795B0 Offset: 0x977BB0 VA: 0x1809795B0
	public void .ctor() { }

}

