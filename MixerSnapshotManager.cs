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

	// RVA: 0x76AEB0 Offset: 0x7694B0 VA: 0x18076AEB0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x76B3F0 Offset: 0x7699F0 VA: 0x18076B3F0
	private void Update() { }

	// RVA: 0x76B3E0 Offset: 0x7699E0 VA: 0x18076B3E0
	public void SetCCTVMode(bool enabled) { }

	// RVA: 0x76AF70 Offset: 0x769570 VA: 0x18076AF70
	private void DoWoundedLoop() { }

	// RVA: 0x76B180 Offset: 0x769780 VA: 0x18076B180
	private AudioMixerSnapshot GetTargetState(bool isUnderwater) { }

	// RVA: 0x76BAB0 Offset: 0x76A0B0 VA: 0x18076BAB0
	public void .ctor() { }

}

