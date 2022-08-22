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

	// RVA: 0xA8DAF0 Offset: 0xA8C0F0 VA: 0x180A8DAF0
	protected void Awake() { }

	// RVA: 0xA8DE00 Offset: 0xA8C400 VA: 0x180A8DE00
	public void SetOff() { }

	// RVA: 0xA8DF00 Offset: 0xA8C500 VA: 0x180A8DF00
	public void SetOn() { }

	// RVA: 0xA8DFF0 Offset: 0xA8C5F0 VA: 0x180A8DFF0
	public void SetRed() { }

	// RVA: 0xA8DCA0 Offset: 0xA8C2A0 VA: 0x180A8DCA0
	public void SetGreen() { }

	// RVA: 0xA8DBB0 Offset: 0xA8C1B0 VA: 0x180A8DBB0
	private Color GetColor(byte r, byte g, byte b, byte a) { }

	// RVA: 0xA8DC10 Offset: 0xA8C210 VA: 0x180A8DC10
	private Color GetColor(byte r, byte g, byte b, byte a, float intensity) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

