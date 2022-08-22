public class EmissionToggle : MonoBehaviour, IClientComponent // TypeDefIndex: 9344
{	// Fields
	private Color emissionColor; // 0x18
	public Renderer[] targetRenderers; // 0x28
	public int materialIndex; // 0x30
	private bool inited; // 0x34
	private Nullable<float> emissionPercent; // 0x38
	private static MaterialPropertyBlock block; // 0x0
	private static int emissionColorID; // 0x8

	// Methods

	// RVA: 0x8C1860 Offset: 0x8BFE60 VA: 0x1808C1860
	public void OnEnable() { }

	// RVA: 0x8C1600 Offset: 0x8BFC00 VA: 0x1808C1600
	private void Init() { }

	// RVA: 0x8C1870 Offset: 0x8BFE70 VA: 0x1808C1870
	public void SetEmissionEnabled(bool on) { }

	// RVA: 0x8C18A0 Offset: 0x8BFEA0 VA: 0x1808C18A0
	public void SetEmission(float percent) { }

	// RVA: 0x8C1B00 Offset: 0x8C0100 VA: 0x1808C1B00
	public void .ctor() { }

	// RVA: 0x8C1AB0 Offset: 0x8C00B0 VA: 0x1808C1AB0
	private static void .cctor() { }

}

