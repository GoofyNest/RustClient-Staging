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

	// RVA: 0x76AE00 Offset: 0x769400 VA: 0x18076AE00 Slot: 6
	protected override void Awake() { }

	// RVA: 0x76B340 Offset: 0x769940 VA: 0x18076B340
	private void Update() { }

	// RVA: 0x76B330 Offset: 0x769930 VA: 0x18076B330
	public void SetCCTVMode(bool enabled) { }

	// RVA: 0x76AEC0 Offset: 0x7694C0 VA: 0x18076AEC0
	private void DoWoundedLoop() { }

	// RVA: 0x76B0D0 Offset: 0x7696D0 VA: 0x18076B0D0
	private AudioMixerSnapshot GetTargetState(bool isUnderwater) { }

	// RVA: 0x76BA00 Offset: 0x76A000 VA: 0x18076BA00
	public void .ctor() { }

}

