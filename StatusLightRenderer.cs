public class StatusLightRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9240
{	// Fields
	public Material offMaterial; // 0x18
	public Material onMaterial; // 0x20
	private MaterialPropertyBlock propertyBlock; // 0x28
	private Renderer targetRenderer; // 0x30
	private Color lightColor; // 0x38
	private Light targetLight; // 0x48
	private int colorID; // 0x50
	private int emissionID; // 0x54

	// Methods

	// RVA: 0xA8D620 Offset: 0xA8BC20 VA: 0x180A8D620
	protected void Awake() { }

	// RVA: 0xA8D930 Offset: 0xA8BF30 VA: 0x180A8D930
	public void SetOff() { }

	// RVA: 0xA8DA30 Offset: 0xA8C030 VA: 0x180A8DA30
	public void SetOn() { }

	// RVA: 0xA8DB20 Offset: 0xA8C120 VA: 0x180A8DB20
	public void SetRed() { }

	// RVA: 0xA8D7D0 Offset: 0xA8BDD0 VA: 0x180A8D7D0
	public void SetGreen() { }

	// RVA: 0xA8D6E0 Offset: 0xA8BCE0 VA: 0x180A8D6E0
	private Color GetColor(byte r, byte g, byte b, byte a) { }

	// RVA: 0xA8D740 Offset: 0xA8BD40 VA: 0x180A8D740
	private Color GetColor(byte r, byte g, byte b, byte a, float intensity) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

