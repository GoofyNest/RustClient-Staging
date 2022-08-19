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

	// RVA: 0x7BBE40 Offset: 0x7BA440 VA: 0x1807BBE40 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x7BC260 Offset: 0x7BA860 VA: 0x1807BC260 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0x7BBFE0 Offset: 0x7BA5E0 VA: 0x1807BBFE0 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0x7BC1D0 Offset: 0x7BA7D0 VA: 0x1807BC1D0 Slot: 11
	internal override void OnObjectRemoved(GameObject obj) { }

	// RVA: 0x7BC0D0 Offset: 0x7BA6D0 VA: 0x1807BC0D0 Slot: 10
	internal override void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0x7BC2E0 Offset: 0x7BA8E0 VA: 0x1807BC2E0
	private void OnTick() { }

	// RVA: 0x7BC050 Offset: 0x7BA650 VA: 0x1807BC050
	protected void OnEnable() { }

	// RVA: 0x7BBF20 Offset: 0x7BA520 VA: 0x1807BBF20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x7BC7B0 Offset: 0x7BADB0 VA: 0x1807BC7B0 Slot: 17
	public void RefreshLOD() { }

	// RVA: 0x7BBDE0 Offset: 0x7BA3E0 VA: 0x1807BBDE0 Slot: 16
	public void ChangeLOD() { }

	// RVA: 0x7BC5B0 Offset: 0x7BABB0 VA: 0x1807BC5B0
	private void PlaySound(GameObject obj, float speed = 0) { }

	// RVA: 0x7BC6C0 Offset: 0x7BACC0 VA: 0x1807BC6C0 Slot: 18
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

