public class ReverbZoneTrigger : TriggerBase, IClientComponentEx, ILOD, ISoundBudgetedUpdate // TypeDefIndex: 9018
{	// Fields
	public Collider trigger; // 0x30
	public AudioReverbZone reverbZone; // 0x38
	public float lodDistance; // 0x40
	public bool inRange; // 0x44
	public ReverbSettings reverbSettings; // 0x48
	private int initialReverbLevel; // 0x50
	private int targetReverbLevel; // 0x54
	private int currentReverbLevel; // 0x58
	private LODCell cell; // 0x60
	private AmbienceZone ambienceZone; // 0x68
	private float decayHFRatio; // 0x70
	private float decayTime; // 0x74
	private float density; // 0x78
	private float diffusion; // 0x7C
	private float HFReference; // 0x80
	private float LFReference; // 0x84
	private float maxDistance; // 0x88
	private float minDistance; // 0x8C
	private int reflections; // 0x90
	private float reflectionsDelay; // 0x94
	private int reverb; // 0x98
	private float reverbDelay; // 0x9C
	private int room; // 0xA0
	private int roomHF; // 0xA4
	private int roomLF; // 0xA8

	// Methods

	// RVA: 0x4C3F20 Offset: 0x4C2520 VA: 0x1804C3F20
	protected void Awake() { }

	// RVA: 0x4C48A0 Offset: 0x4C2EA0 VA: 0x1804C48A0
	protected void OnEnable() { }

	// RVA: 0x4C47E0 Offset: 0x4C2DE0 VA: 0x1804C47E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x4C43A0 Offset: 0x4C29A0 VA: 0x1804C43A0 Slot: 18
	public void DoUpdate() { }

	// RVA: 0x4C3AF0 Offset: 0x4C20F0 VA: 0x1804C3AF0
	private void ApplyReverbSettings() { }

	// RVA: 0x4C4140 Offset: 0x4C2740 VA: 0x1804C4140
	private void DisableReverbZone() { }

	// RVA: 0x4C45D0 Offset: 0x4C2BD0 VA: 0x1804C45D0
	private void EnableReverbZone() { }

	// RVA: 0x4C4680 Offset: 0x4C2C80 VA: 0x1804C4680 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x4C4920 Offset: 0x4C2F20 VA: 0x1804C4920 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x4C4930 Offset: 0x4C2F30 VA: 0x1804C4930 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x4C4A40 Offset: 0x4C3040 VA: 0x1804C4A40 Slot: 17
	public void RefreshLOD() { }

	// RVA: 0x4C4040 Offset: 0x4C2640 VA: 0x1804C4040 Slot: 16
	public void ChangeLOD() { }

	// RVA: 0x4C4940 Offset: 0x4C2F40 VA: 0x1804C4940 Slot: 20
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 19
	public bool IsSyncedToParent() { }

	// RVA: 0x4C4AC0 Offset: 0x4C30C0 VA: 0x1804C4AC0
	public void .ctor() { }

}

