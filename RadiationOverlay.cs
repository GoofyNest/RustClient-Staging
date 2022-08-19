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

	// RVA: 0x6A1E40 Offset: 0x6A0440 VA: 0x1806A1E40
	public void Awake() { }

	// RVA: 0x6A23E0 Offset: 0x6A09E0 VA: 0x1806A23E0
	protected void Update() { }

	// RVA: 0x6A21E0 Offset: 0x6A07E0 VA: 0x1806A21E0
	private void UpdateSound(float exposure) { }

	// RVA: 0x6A2030 Offset: 0x6A0630 VA: 0x1806A2030
	private float GetRadationFraction() { }

	// RVA: 0x6A1E70 Offset: 0x6A0470 VA: 0x1806A1E70
	private float GetRadationExposureFraction() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

