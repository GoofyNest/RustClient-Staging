public class TriggerBase : BaseMonoBehaviour // TypeDefIndex: 10020
{	// Fields
	public LayerMask interestLayers; // 0x18
	public HashSet<GameObject> contents; // 0x20
	public HashSet<BaseEntity> entityContents; // 0x28

	// Properties
	public bool HasAnyContents { get; }
	public bool HasAnyEntityContents { get; }

	// Methods

	// RVA: 0xA212A0 Offset: 0xA1F8A0 VA: 0x180A212A0
	public bool get_HasAnyContents() { }

	// RVA: 0xA212E0 Offset: 0xA1F8E0 VA: 0x180A212E0
	public bool get_HasAnyEntityContents() { }

	// RVA: 0xA1F960 Offset: 0xA1DF60 VA: 0x180A1F960 Slot: 6
	internal virtual GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA1F9C0 Offset: 0xA1DFC0 VA: 0x180A1F9C0 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0xA1FAF0 Offset: 0xA1E0F0 VA: 0x180A1FAF0 Slot: 8
	internal virtual void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA1FBC0 Offset: 0xA1E1C0 VA: 0x180A1FBC0 Slot: 9
	internal virtual void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA1FC10 Offset: 0xA1E210 VA: 0x180A1FC10 Slot: 10
	internal virtual void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0xA1FCF0 Offset: 0xA1E2F0 VA: 0x180A1FCF0 Slot: 11
	internal virtual void OnObjectRemoved(GameObject obj) { }

	// RVA: 0xA20C70 Offset: 0xA1F270 VA: 0x180A20C70
	internal void RemoveInvalidEntities() { }

	// RVA: 0xA1F7D0 Offset: 0xA1DDD0 VA: 0x180A1F7D0
	internal bool CheckEntity(BaseEntity ent) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void OnObjects() { }

	// RVA: 0xA1FAB0 Offset: 0xA1E0B0 VA: 0x180A1FAB0 Slot: 13
	internal virtual void OnEmpty() { }

	// RVA: 0xA211E0 Offset: 0xA1F7E0 VA: 0x180A211E0
	public void RemoveObject(GameObject obj) { }

	// RVA: 0xA208F0 Offset: 0xA1EEF0 VA: 0x180A208F0
	public void RemoveEntity(BaseEntity ent) { }

	// RVA: 0xA1FFC0 Offset: 0xA1E5C0 VA: 0x180A1FFC0
	public void OnTriggerEnter(Collider collider) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool SkipOnTriggerExit(Collider collider) { }

	// RVA: 0xA20540 Offset: 0xA1EB40 VA: 0x180A20540
	public void OnTriggerExit(Collider collider) { }

	// RVA: 0xA20490 Offset: 0xA1EA90 VA: 0x180A20490
	private void OnTriggerExit(GameObject targetObj) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

