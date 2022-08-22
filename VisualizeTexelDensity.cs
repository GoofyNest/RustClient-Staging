public class VisualizeTexelDensity : MonoBehaviour // TypeDefIndex: 11533
{	// Fields
	public Shader shader; // 0x18
	public string shaderTag; // 0x20
	[RangeAttribute] // RVA: 0xBE3F0 Offset: 0xBD7F0 VA: 0x1800BE3F0
	public int texelsPerMeter; // 0x28
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
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

	// Properties
	public static VisualizeTexelDensity Instance { get; }

	// Methods

	// RVA: 0x7FFC90 Offset: 0x7FE290 VA: 0x1807FFC90
	public static VisualizeTexelDensity get_Instance() { }

	// RVA: 0x7FE600 Offset: 0x7FCC00 VA: 0x1807FE600
	private void Awake() { }

	// RVA: 0x7FEBC0 Offset: 0x7FD1C0 VA: 0x1807FEBC0
	private void OnEnable() { }

	// RVA: 0x7FEB40 Offset: 0x7FD140 VA: 0x1807FEB40
	private void OnDisable() { }

	// RVA: 0x7FE9E0 Offset: 0x7FCFE0 VA: 0x1807FE9E0
	private void LoadResources() { }

	// RVA: 0x7FF4F0 Offset: 0x7FDAF0 VA: 0x1807FF4F0
	private void SafeDestroyViewTexelDensity() { }

	// RVA: 0x7FF400 Offset: 0x7FDA00 VA: 0x1807FF400
	private void SafeDestroyViewTexelDensityRT() { }

	// RVA: 0x7FF680 Offset: 0x7FDC80 VA: 0x1807FF680
	private void UpdateViewTexelDensity(bool screenResized) { }

	// RVA: 0x7FE680 Offset: 0x7FCC80 VA: 0x1807FE680
	private bool CheckScreenResized(int width, int height) { }

	// RVA: 0x7FF290 Offset: 0x7FD890 VA: 0x1807FF290
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7FE6A0 Offset: 0x7FCCA0 VA: 0x1807FE6A0
	private void DrawGUIText(float x, float y, Vector2 size, string text, GUIStyle fontStyle) { }

	// RVA: 0x7FED80 Offset: 0x7FD380 VA: 0x1807FED80
	private void OnGUI() { }

	// RVA: 0x7FFC30 Offset: 0x7FE230 VA: 0x1807FFC30
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

