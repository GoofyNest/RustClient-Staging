public class MixerSnapshotManager : SingletonComponent<MixerSnapshotManager>, IClientComponent // TypeDefIndex: 8997
{	// Fields
	public AudioMixerSnapshot defaultSnapshot; // 0x18
	public AudioMixerSnapshot underwaterSnapshot; // 0x20
	public AudioMixerSnapshot loadingSnapshot; // 0x28
	public AudioMixerSnapshot woundedSnapshot; // 0x30
	public AudioMixerSnapshot cctvSnapshot; // 0x38
	public SoundDefinition underwaterInSound; // 0x40
	public SoundDefinition underwaterOutSound; // 0x48
	public AudioMixerSnapshot recordingSnapshot; // 0x50
	public SoundDefinition woundedLoop; // 0x58
	private Sound woundedLoopSound; // 0x60
	public SoundDefinition cctvModeLoopDef; // 0x68
	private Sound cctvModeLoop; // 0x70
	public SoundDefinition cctvModeStartDef; // 0x78
	public SoundDefinition cctvModeStopDef; // 0x80
	public float deafness; // 0x88
	private bool cctvMode; // 0x8C
	internal AudioMixerSnapshot currentState; // 0x90

	// Methods

	// RVA: 0x76ADA0 Offset: 0x7693A0 VA: 0x18076ADA0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x76B2E0 Offset: 0x7698E0 VA: 0x18076B2E0
	private void Update() { }

	// RVA: 0x76B2D0 Offset: 0x7698D0 VA: 0x18076B2D0
	public void SetCCTVMode(bool enabled) { }

	// RVA: 0x76AE60 Offset: 0x769460 VA: 0x18076AE60
	private void DoWoundedLoop() { }

	// RVA: 0x76B070 Offset: 0x769670 VA: 0x18076B070
	private AudioMixerSnapshot GetTargetState(bool isUnderwater) { }

	// RVA: 0x76B9A0 Offset: 0x769FA0 VA: 0x18076B9A0
	public void .ctor() { }

}

