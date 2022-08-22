public class TriggerBase : BaseMonoBehaviour // TypeDefIndex: 10020
{	// Fields
	public LayerMask interestLayers; // 0x18
	public HashSet<GameObject> contents; // 0x20
	public HashSet<BaseEntity> entityContents; // 0x28

	// Properties
	public bool HasAnyContents { get; }
	public bool HasAnyEntityContents { get; }

	// Methods

	// RVA: 0xA21560 Offset: 0xA1FB60 VA: 0x180A21560
	public bool get_HasAnyContents() { }

	// RVA: 0xA215A0 Offset: 0xA1FBA0 VA: 0x180A215A0
	public bool get_HasAnyEntityContents() { }

	// RVA: 0xA1FC20 Offset: 0xA1E220 VA: 0x180A1FC20 Slot: 6
	internal virtual GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA1FC80 Offset: 0xA1E280 VA: 0x180A1FC80 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0xA1FDB0 Offset: 0xA1E3B0 VA: 0x180A1FDB0 Slot: 8
	internal virtual void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA1FE80 Offset: 0xA1E480 VA: 0x180A1FE80 Slot: 9
	internal virtual void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA1FED0 Offset: 0xA1E4D0 VA: 0x180A1FED0 Slot: 10
	internal virtual void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0xA1FFB0 Offset: 0xA1E5B0 VA: 0x180A1FFB0 Slot: 11
	internal virtual void OnObjectRemoved(GameObject obj) { }

	// RVA: 0xA20F30 Offset: 0xA1F530 VA: 0x180A20F30
	internal void RemoveInvalidEntities() { }

	// RVA: 0xA1FA90 Offset: 0xA1E090 VA: 0x180A1FA90
	internal bool CheckEntity(BaseEntity ent) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	internal virtual void OnObjects() { }

	// RVA: 0xA1FD70 Offset: 0xA1E370 VA: 0x180A1FD70 Slot: 13
	internal virtual void OnEmpty() { }

	// RVA: 0xA214A0 Offset: 0xA1FAA0 VA: 0x180A214A0
	public void RemoveObject(GameObject obj) { }

	// RVA: 0xA20BB0 Offset: 0xA1F1B0 VA: 0x180A20BB0
	public void RemoveEntity(BaseEntity ent) { }

	// RVA: 0xA20280 Offset: 0xA1E880 VA: 0x180A20280
	public void OnTriggerEnter(Collider collider) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	internal virtual bool SkipOnTriggerExit(Collider collider) { }

	// RVA: 0xA20800 Offset: 0xA1EE00 VA: 0x180A20800
	public void OnTriggerExit(Collider collider) { }

	// RVA: 0xA20750 Offset: 0xA1ED50 VA: 0x180A20750
	private void OnTriggerExit(GameObject targetObj) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

