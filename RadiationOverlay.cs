public class RadiationOverlay : MonoBehaviour // TypeDefIndex: 9134
{	// Fields
	public SoundDefinition[] geigerSounds; // 0x18
	public PostProcessVolume postProcessVolume; // 0x20
	private Sound sound; // 0x28
	private float smoothRadiationCurrent; // 0x30
	private float smoothRadiationVelocity; // 0x34
	private float smoothRadiationExposureCurrent; // 0x38
	private float smoothRadiationExposureVelocity; // 0x3C

	// Methods

	// RVA: 0x6A1EE0 Offset: 0x6A04E0 VA: 0x1806A1EE0
	public void Awake() { }

	// RVA: 0x6A2480 Offset: 0x6A0A80 VA: 0x1806A2480
	protected void Update() { }

	// RVA: 0x6A2280 Offset: 0x6A0880 VA: 0x1806A2280
	private void UpdateSound(float exposure) { }

	// RVA: 0x6A20D0 Offset: 0x6A06D0 VA: 0x1806A20D0
	private float GetRadationFraction() { }

	// RVA: 0x6A1F10 Offset: 0x6A0510 VA: 0x1806A1F10
	private float GetRadationExposureFraction() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

