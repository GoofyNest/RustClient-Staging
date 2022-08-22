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

	// RVA: 0x9E8F00 Offset: 0x9E7500 VA: 0x1809E8F00
	private void BlurCreate() { }

	// RVA: 0x9E9020 Offset: 0x9E7620 VA: 0x1809E9020
	private void BlurDestroy() { }

	// RVA: 0x9E90C0 Offset: 0x9E76C0 VA: 0x1809E90C0
	public static void BlurRT(RenderTexture myRT, float radius, int passNum) { }

	// RVA: 0x9E8F00 Offset: 0x9E7500 VA: 0x1809E8F00
	public void OnEnable() { }

	// RVA: 0x9E94C0 Offset: 0x9E7AC0 VA: 0x1809E94C0
	public void OnDestroy() { }

	// RVA: 0x9EA350 Offset: 0x9E8950 VA: 0x1809EA350
	public void Update() { }

	// RVA: 0x9E9EB0 Offset: 0x9E84B0 VA: 0x1809E9EB0
	public void UpdateOutlines() { }

	// RVA: 0x9E9470 Offset: 0x9E7A70 VA: 0x1809E9470
	public void ClearOutlines() { }

	// RVA: 0x9E9340 Offset: 0x9E7940 VA: 0x1809E9340
	public void CleanupOutlines() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9E95C0 Offset: 0x9E7BC0 VA: 0x1809E95C0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x9EA3A0 Offset: 0x9E89A0 VA: 0x1809EA3A0
	public void .ctor() { }

	// RVA: 0x9EA360 Offset: 0x9E8960 VA: 0x1809EA360
	private static void .cctor() { }

}

