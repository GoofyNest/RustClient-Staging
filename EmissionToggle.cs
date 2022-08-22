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

	// RVA: 0x8C1D70 Offset: 0x8C0370 VA: 0x1808C1D70
	public void OnEnable() { }

	// RVA: 0x8C1B10 Offset: 0x8C0110 VA: 0x1808C1B10
	private void Init() { }

	// RVA: 0x8C1D80 Offset: 0x8C0380 VA: 0x1808C1D80
	public void SetEmissionEnabled(bool on) { }

	// RVA: 0x8C1DB0 Offset: 0x8C03B0 VA: 0x1808C1DB0
	public void SetEmission(float percent) { }

	// RVA: 0x8C2010 Offset: 0x8C0610 VA: 0x1808C2010
	public void .ctor() { }

	// RVA: 0x8C1FC0 Offset: 0x8C05C0 VA: 0x1808C1FC0
	private static void .cctor() { }

}

