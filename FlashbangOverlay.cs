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

	// RVA: 0x791020 Offset: 0x78F620 VA: 0x180791020
	protected void Awake() { }

	// RVA: 0x7910B0 Offset: 0x78F6B0 VA: 0x1807910B0
	public void Flash(float time) { }

	// RVA: 0x7916B0 Offset: 0x78FCB0 VA: 0x1807916B0
	private void Update() { }

	// RVA: 0x791400 Offset: 0x78FA00 VA: 0x180791400
	public void UpdateAudio() { }

	// RVA: 0x7912B0 Offset: 0x78F8B0 VA: 0x1807912B0
	public void ShutdownAudio() { }

	// RVA: 0x791130 Offset: 0x78F730 VA: 0x180791130
	private void OnDestroy() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

