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

	// RVA: 0x6A1F50 Offset: 0x6A0550 VA: 0x1806A1F50
	public void Awake() { }

	// RVA: 0x6A24F0 Offset: 0x6A0AF0 VA: 0x1806A24F0
	protected void Update() { }

	// RVA: 0x6A22F0 Offset: 0x6A08F0 VA: 0x1806A22F0
	private void UpdateSound(float exposure) { }

	// RVA: 0x6A2140 Offset: 0x6A0740 VA: 0x1806A2140
	private float GetRadationFraction() { }

	// RVA: 0x6A1F80 Offset: 0x6A0580 VA: 0x1806A1F80
	private float GetRadationExposureFraction() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

