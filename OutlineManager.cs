public class OutlineManager : MonoBehaviour, IClientComponent // TypeDefIndex: 10093
{	// Fields
	public static Material blurMat; // 0x0
	public List<OutlineObject> objectsToRender; // 0x18
	public float blurAmount; // 0x20
	public Material glowSolidMaterial; // 0x28
	public Material blendGlowMaterial; // 0x30
	public static float worldModelDistance; // 0x8
	private float nextUpdateTime; // 0x38

	// Methods

	// RVA: 0x9E8750 Offset: 0x9E6D50 VA: 0x1809E8750
	private void BlurCreate() { }

	// RVA: 0x9E8870 Offset: 0x9E6E70 VA: 0x1809E8870
	private void BlurDestroy() { }

	// RVA: 0x9E8910 Offset: 0x9E6F10 VA: 0x1809E8910
	public static void BlurRT(RenderTexture myRT, float radius, int passNum) { }

	// RVA: 0x9E8750 Offset: 0x9E6D50 VA: 0x1809E8750
	public void OnEnable() { }

	// RVA: 0x9E8D10 Offset: 0x9E7310 VA: 0x1809E8D10
	public void OnDestroy() { }

	// RVA: 0x9E9BA0 Offset: 0x9E81A0 VA: 0x1809E9BA0
	public void Update() { }

	// RVA: 0x9E9700 Offset: 0x9E7D00 VA: 0x1809E9700
	public void UpdateOutlines() { }

	// RVA: 0x9E8CC0 Offset: 0x9E72C0 VA: 0x1809E8CC0
	public void ClearOutlines() { }

	// RVA: 0x9E8B90 Offset: 0x9E7190 VA: 0x1809E8B90
	public void CleanupOutlines() { }

	[ImageEffectOpaque] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x9E8E10 Offset: 0x9E7410 VA: 0x1809E8E10
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x9E9BF0 Offset: 0x9E81F0 VA: 0x1809E9BF0
	public void .ctor() { }

	// RVA: 0x9E9BB0 Offset: 0x9E81B0 VA: 0x1809E9BB0
	private static void .cctor() { }

}

