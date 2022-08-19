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

	// RVA: 0x8C1750 Offset: 0x8BFD50 VA: 0x1808C1750
	public void OnEnable() { }

	// RVA: 0x8C14F0 Offset: 0x8BFAF0 VA: 0x1808C14F0
	private void Init() { }

	// RVA: 0x8C1760 Offset: 0x8BFD60 VA: 0x1808C1760
	public void SetEmissionEnabled(bool on) { }

	// RVA: 0x8C1790 Offset: 0x8BFD90 VA: 0x1808C1790
	public void SetEmission(float percent) { }

	// RVA: 0x8C19F0 Offset: 0x8BFFF0 VA: 0x1808C19F0
	public void .ctor() { }

	// RVA: 0x8C19A0 Offset: 0x8BFFA0 VA: 0x1808C19A0
	private static void .cctor() { }

}

