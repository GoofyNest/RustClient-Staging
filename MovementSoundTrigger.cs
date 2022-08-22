public class MovementSoundTrigger : TriggerBase, IClientComponentEx, ILOD // TypeDefIndex: 8998
{	// Fields
	public SoundDefinition softSound; // 0x30
	public SoundDefinition medSound; // 0x38
	public SoundDefinition hardSound; // 0x40
	public Collider collider; // 0x48
	private const float maxDistance = 100;
	private const float tickRate = 2;
	private LODCell cell; // 0x50
	private Dictionary<GameObject, Vector3> lastPositionByObject; // 0x58

	// Methods

	// RVA: 0x7BBF50 Offset: 0x7BA550 VA: 0x1807BBF50 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x7BC370 Offset: 0x7BA970 VA: 0x1807BC370 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0x7BC0F0 Offset: 0x7BA6F0 VA: 0x1807BC0F0 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0x7BC2E0 Offset: 0x7BA8E0 VA: 0x1807BC2E0 Slot: 11
	internal override void OnObjectRemoved(GameObject obj) { }

	// RVA: 0x7BC1E0 Offset: 0x7BA7E0 VA: 0x1807BC1E0 Slot: 10
	internal override void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0x7BC3F0 Offset: 0x7BA9F0 VA: 0x1807BC3F0
	private void OnTick() { }

	// RVA: 0x7BC160 Offset: 0x7BA760 VA: 0x1807BC160
	protected void OnEnable() { }

	// RVA: 0x7BC030 Offset: 0x7BA630 VA: 0x1807BC030 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x7BC8C0 Offset: 0x7BAEC0 VA: 0x1807BC8C0 Slot: 17
	public void RefreshLOD() { }

	// RVA: 0x7BBEF0 Offset: 0x7BA4F0 VA: 0x1807BBEF0 Slot: 16
	public void ChangeLOD() { }

	// RVA: 0x7BC6C0 Offset: 0x7BACC0 VA: 0x1807BC6C0
	private void PlaySound(GameObject obj, float speed = 0) { }

	// RVA: 0x7BC7D0 Offset: 0x7BADD0 VA: 0x1807BC7D0 Slot: 18
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

