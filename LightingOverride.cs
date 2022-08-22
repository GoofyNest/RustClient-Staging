public class LightingOverride : MonoBehaviour // TypeDefIndex: 6634
{	// Fields
	public bool overrideAmbientLight; // 0x18
	public AmbientMode ambientMode; // 0x1C
	public Color ambientGroundColor; // 0x20
	public Color ambientEquatorColor; // 0x30
	public Color ambientLight; // 0x40
	public float ambientIntensity; // 0x50
	internal Color old_ambientLight; // 0x54
	internal Color old_ambientGroundColor; // 0x64
	internal Color old_ambientEquatorColor; // 0x74
	internal float old_ambientIntensity; // 0x84
	internal AmbientMode old_ambientMode; // 0x88
	public float aspect; // 0x8C

	// Methods

	// RVA: 0x1BA3770 Offset: 0x1BA1D70 VA: 0x181BA3770
	private void OnPreRender() { }

	// RVA: 0x1BA36E0 Offset: 0x1BA1CE0 VA: 0x181BA36E0
	private void OnPostRender() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

