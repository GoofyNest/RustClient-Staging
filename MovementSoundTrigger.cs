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

	// RVA: 0x7DA340 Offset: 0x7D8940 VA: 0x1807DA340 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x7DA760 Offset: 0x7D8D60 VA: 0x1807DA760 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0x7DA4E0 Offset: 0x7D8AE0 VA: 0x1807DA4E0 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0x7DA6D0 Offset: 0x7D8CD0 VA: 0x1807DA6D0 Slot: 11
	internal override void OnObjectRemoved(GameObject obj) { }

	// RVA: 0x7DA5D0 Offset: 0x7D8BD0 VA: 0x1807DA5D0 Slot: 10
	internal override void OnObjectAdded(GameObject obj, Collider col) { }

	// RVA: 0x7DA7E0 Offset: 0x7D8DE0 VA: 0x1807DA7E0
	private void OnTick() { }

	// RVA: 0x7DA550 Offset: 0x7D8B50 VA: 0x1807DA550
	protected void OnEnable() { }

	// RVA: 0x7DA420 Offset: 0x7D8A20 VA: 0x1807DA420 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x7DACB0 Offset: 0x7D92B0 VA: 0x1807DACB0 Slot: 17
	public void RefreshLOD() { }

	// RVA: 0x7DA2E0 Offset: 0x7D88E0 VA: 0x1807DA2E0 Slot: 16
	public void ChangeLOD() { }

	// RVA: 0x7DAAB0 Offset: 0x7D90B0 VA: 0x1807DAAB0
	private void PlaySound(GameObject obj, float speed = 0) { }

	// RVA: 0x7DABC0 Offset: 0x7D91C0 VA: 0x1807DABC0 Slot: 18
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x4D3840 Offset: 0x4D1E40 VA: 0x1804D3840
	public void .ctor() { }

}

