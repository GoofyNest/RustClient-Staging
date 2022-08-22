public class FlashbangOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 9129
{	// Fields
	public static FlashbangOverlay Instance; // 0x0
	public PostProcessVolume postProcessVolume; // 0x18
	public AnimationCurve burnIntensityCurve; // 0x20
	public AnimationCurve whiteoutIntensityCurve; // 0x28
	public SoundDefinition deafLoopDef; // 0x30
	private FlashbangEffect flashbangEffect; // 0x38
	private float flashLength; // 0x40
	private TimeSince flashTime; // 0x44
	private Sound deafLoop; // 0x48
	private SoundModulation.Modulator deafGain; // 0x50

	// Methods

	// RVA: 0x790F30 Offset: 0x78F530 VA: 0x180790F30
	protected void Awake() { }

	// RVA: 0x790FC0 Offset: 0x78F5C0 VA: 0x180790FC0
	public void Flash(float time) { }

	// RVA: 0x7915C0 Offset: 0x78FBC0 VA: 0x1807915C0
	private void Update() { }

	// RVA: 0x791310 Offset: 0x78F910 VA: 0x180791310
	public void UpdateAudio() { }

	// RVA: 0x7911C0 Offset: 0x78F7C0 VA: 0x1807911C0
	public void ShutdownAudio() { }

	// RVA: 0x791040 Offset: 0x78F640 VA: 0x180791040
	private void OnDestroy() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

