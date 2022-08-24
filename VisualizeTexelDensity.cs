public class VisualizeTexelDensity : MonoBehaviour // TypeDefIndex: 11537
{	public Shader shader; // 0x18
	public string shaderTag; // 0x20
	[RangeAttribute] // RVA: 0xBE110 Offset: 0xBD510 VA: 0x1800BE110
	public int texelsPerMeter; // 0x28
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float overlayOpacity; // 0x2C
	public bool showHUD; // 0x30
	private Camera mainCamera; // 0x38
	private bool initialized; // 0x40
	private int screenWidth; // 0x44
	private int screenHeight; // 0x48
	private Camera texelDensityCamera; // 0x50
	private RenderTexture texelDensityRT; // 0x58
	private Texture texelDensityGradTex; // 0x60
	private Material texelDensityOverlayMat; // 0x68
	private static VisualizeTexelDensity instance; // 0x0

	public static VisualizeTexelDensity Instance { get; }


	public static VisualizeTexelDensity get_Instance() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void LoadResources() { }

	private void SafeDestroyViewTexelDensity() { }

	private void SafeDestroyViewTexelDensityRT() { }

	private void UpdateViewTexelDensity(bool screenResized) { }

	private bool CheckScreenResized(int width, int height) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void DrawGUIText(float x, float y, Vector2 size, string text, GUIStyle fontStyle) { }

	private void OnGUI() { }

	public void .ctor() { }

	private static void .cctor() { }

}

