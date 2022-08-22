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

	// RVA: 0x4C3EB0 Offset: 0x4C24B0 VA: 0x1804C3EB0
	protected void Awake() { }

	// RVA: 0x4C4830 Offset: 0x4C2E30 VA: 0x1804C4830
	protected void OnEnable() { }

	// RVA: 0x4C4770 Offset: 0x4C2D70 VA: 0x1804C4770 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x4C4330 Offset: 0x4C2930 VA: 0x1804C4330 Slot: 18
	public void DoUpdate() { }

	// RVA: 0x4C3A80 Offset: 0x4C2080 VA: 0x1804C3A80
	private void ApplyReverbSettings() { }

	// RVA: 0x4C40D0 Offset: 0x4C26D0 VA: 0x1804C40D0
	private void DisableReverbZone() { }

	// RVA: 0x4C4560 Offset: 0x4C2B60 VA: 0x1804C4560
	private void EnableReverbZone() { }

	// RVA: 0x4C4610 Offset: 0x4C2C10 VA: 0x1804C4610 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x4C48B0 Offset: 0x4C2EB0 VA: 0x1804C48B0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x4C48C0 Offset: 0x4C2EC0 VA: 0x1804C48C0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x4C49D0 Offset: 0x4C2FD0 VA: 0x1804C49D0 Slot: 17
	public void RefreshLOD() { }

	// RVA: 0x4C3FD0 Offset: 0x4C25D0 VA: 0x1804C3FD0 Slot: 16
	public void ChangeLOD() { }

	// RVA: 0x4C48D0 Offset: 0x4C2ED0 VA: 0x1804C48D0 Slot: 20
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 19
	public bool IsSyncedToParent() { }

	// RVA: 0x4C4A50 Offset: 0x4C3050 VA: 0x1804C4A50
	public void .ctor() { }

}

