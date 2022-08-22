public class TriggerBase : BaseMonoBehaviour // TypeDefIndex: 10020
{	// Fields
	public LayerMask interestLayers; // 0x18
	public HashSet<GameObject> contents; // 0x20
	public HashSet<BaseEntity> entityContents; // 0x28

	// Properties
	public bool HasAnyContents { get; }
	public bool HasAnyEntityContents { get; }

	// Methods

	// RVA: 0xA21A50 Offset: 0xA20050 VA: 0x180A21A50
	public bool get_HasAnyContents() { }

	// RVA: 0xA21A90 Offset: 0xA20090 VA: 0x180A21A90
	public bool get_HasAnyEntityContents() { }

	// RVA: 0xA20110 Offset: 0xA1E710 VA: 0x180A20110 Slot: 6
	internal virtual GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA20170 Offset: 0xA1E770 VA: 0x180A20170 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0xA202A0 Offset: 0xA1E8A0 VA: 0x180A202A0 Slot: 8
	internal virtual void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA20370 Offset: 0xA1E970 VA: 0x180A20370 Slot: 9
	internal virtual void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA203C0 Offset: 0xA1E9C0 VA: 0x180A203C0 Slot: 10
	internal virtual void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0xA204A0 Offset: 0xA1EAA0 VA: 0x180A204A0 Slot: 11
	internal virtual void OnObjectRemoved(GameObject obj) { }

	// RVA: 0xA21420 Offset: 0xA1FA20 VA: 0x180A21420
	internal void RemoveInvalidEntities() { }

	// RVA: 0xA1FF80 Offset: 0xA1E580 VA: 0x180A1FF80
	internal bool CheckEntity(BaseEntity ent) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void OnObjects() { }

	// RVA: 0xA20260 Offset: 0xA1E860 VA: 0x180A20260 Slot: 13
	internal virtual void OnEmpty() { }

	// RVA: 0xA21990 Offset: 0xA1FF90 VA: 0x180A21990
	public void RemoveObject(GameObject obj) { }

	// RVA: 0xA210A0 Offset: 0xA1F6A0 VA: 0x180A210A0
	public void RemoveEntity(BaseEntity ent) { }

	// RVA: 0xA20770 Offset: 0xA1ED70 VA: 0x180A20770
	public void OnTriggerEnter(Collider collider) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool SkipOnTriggerExit(Collider collider) { }

	// RVA: 0xA20CF0 Offset: 0xA1F2F0 VA: 0x180A20CF0
	public void OnTriggerExit(Collider collider) { }

	// RVA: 0xA20C40 Offset: 0xA1F240 VA: 0x180A20C40
	private void OnTriggerExit(GameObject targetObj) { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

