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

	// RVA: 0xA8D360 Offset: 0xA8B960 VA: 0x180A8D360
	protected void Awake() { }

	// RVA: 0xA8D670 Offset: 0xA8BC70 VA: 0x180A8D670
	public void SetOff() { }

	// RVA: 0xA8D770 Offset: 0xA8BD70 VA: 0x180A8D770
	public void SetOn() { }

	// RVA: 0xA8D860 Offset: 0xA8BE60 VA: 0x180A8D860
	public void SetRed() { }

	// RVA: 0xA8D510 Offset: 0xA8BB10 VA: 0x180A8D510
	public void SetGreen() { }

	// RVA: 0xA8D420 Offset: 0xA8BA20 VA: 0x180A8D420
	private Color GetColor(byte r, byte g, byte b, byte a) { }

	// RVA: 0xA8D480 Offset: 0xA8BA80 VA: 0x180A8D480
	private Color GetColor(byte r, byte g, byte b, byte a, float intensity) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

