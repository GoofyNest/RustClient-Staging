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

	// RVA: 0x95A810 Offset: 0x958E10 VA: 0x18095A810
	public void OnEnable() { }

	// RVA: 0x95A810 Offset: 0x958E10 VA: 0x18095A810
	private void Init() { }

	// RVA: 0x95A8B0 Offset: 0x958EB0 VA: 0x18095A8B0
	public void SetColorScale(float scale) { }

	// RVA: 0x95AC10 Offset: 0x959210 VA: 0x18095AC10
	public void Update() { }

	// RVA: 0x95A850 Offset: 0x958E50 VA: 0x18095A850
	public void RefreshRenderers() { }

	// RVA: 0x95A960 Offset: 0x958F60 VA: 0x18095A960
	private void UpdateMaterials(Color final) { }

	// RVA: 0x95AD60 Offset: 0x959360 VA: 0x18095AD60
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

