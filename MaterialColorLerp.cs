public class MaterialColorLerp : MonoBehaviour, IClientComponent // TypeDefIndex: 9639
{	// Fields
	public Color startColor; // 0x18
	public Color endColor; // 0x28
	public Color currentColor; // 0x38
	public float delta; // 0x48
	private static MaterialPropertyBlock materialPropertyBlock; // 0x0
	private bool initialized; // 0x4C
	private float lerpStartTime; // 0x50
	private List<Renderer> cachedRenderers; // 0x58

	// Methods

	// RVA: 0x95A200 Offset: 0x958800 VA: 0x18095A200
	public void OnEnable() { }

	// RVA: 0x95A200 Offset: 0x958800 VA: 0x18095A200
	private void Init() { }

	// RVA: 0x95A2A0 Offset: 0x9588A0 VA: 0x18095A2A0
	public void SetColorScale(float scale) { }

	// RVA: 0x95A600 Offset: 0x958C00 VA: 0x18095A600
	public void Update() { }

	// RVA: 0x95A240 Offset: 0x958840 VA: 0x18095A240
	public void RefreshRenderers() { }

	// RVA: 0x95A350 Offset: 0x958950 VA: 0x18095A350
	private void UpdateMaterials(Color final) { }

	// RVA: 0x95A750 Offset: 0x958D50 VA: 0x18095A750
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

