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

	// RVA: 0x9E8A10 Offset: 0x9E7010 VA: 0x1809E8A10
	private void BlurCreate() { }

	// RVA: 0x9E8B30 Offset: 0x9E7130 VA: 0x1809E8B30
	private void BlurDestroy() { }

	// RVA: 0x9E8BD0 Offset: 0x9E71D0 VA: 0x1809E8BD0
	public static void BlurRT(RenderTexture myRT, float radius, int passNum) { }

	// RVA: 0x9E8A10 Offset: 0x9E7010 VA: 0x1809E8A10
	public void OnEnable() { }

	// RVA: 0x9E8FD0 Offset: 0x9E75D0 VA: 0x1809E8FD0
	public void OnDestroy() { }

	// RVA: 0x9E9E60 Offset: 0x9E8460 VA: 0x1809E9E60
	public void Update() { }

	// RVA: 0x9E99C0 Offset: 0x9E7FC0 VA: 0x1809E99C0
	public void UpdateOutlines() { }

	// RVA: 0x9E8F80 Offset: 0x9E7580 VA: 0x1809E8F80
	public void ClearOutlines() { }

	// RVA: 0x9E8E50 Offset: 0x9E7450 VA: 0x1809E8E50
	public void CleanupOutlines() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9E90D0 Offset: 0x9E76D0 VA: 0x1809E90D0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x9E9EB0 Offset: 0x9E84B0 VA: 0x1809E9EB0
	public void .ctor() { }

	// RVA: 0x9E9E70 Offset: 0x9E8470 VA: 0x1809E9E70
	private static void .cctor() { }

}

