public class VisualizeTexelDensity : MonoBehaviour // TypeDefIndex: 11533
{	// Fields
	public Shader shader; // 0x18
	public string shaderTag; // 0x20
	[RangeAttribute] // RVA: 0xBE350 Offset: 0xBD750 VA: 0x1800BE350
	public int texelsPerMeter; // 0x28
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
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

	// RVA: 0x7FFB80 Offset: 0x7FE180 VA: 0x1807FFB80
	public static VisualizeTexelDensity get_Instance() { }

	// RVA: 0x7FE4F0 Offset: 0x7FCAF0 VA: 0x1807FE4F0
	private void Awake() { }

	// RVA: 0x7FEAB0 Offset: 0x7FD0B0 VA: 0x1807FEAB0
	private void OnEnable() { }

	// RVA: 0x7FEA30 Offset: 0x7FD030 VA: 0x1807FEA30
	private void OnDisable() { }

	// RVA: 0x7FE8D0 Offset: 0x7FCED0 VA: 0x1807FE8D0
	private void LoadResources() { }

	// RVA: 0x7FF3E0 Offset: 0x7FD9E0 VA: 0x1807FF3E0
	private void SafeDestroyViewTexelDensity() { }

	// RVA: 0x7FF2F0 Offset: 0x7FD8F0 VA: 0x1807FF2F0
	private void SafeDestroyViewTexelDensityRT() { }

	// RVA: 0x7FF570 Offset: 0x7FDB70 VA: 0x1807FF570
	private void UpdateViewTexelDensity(bool screenResized) { }

	// RVA: 0x7FE570 Offset: 0x7FCB70 VA: 0x1807FE570
	private bool CheckScreenResized(int width, int height) { }

	// RVA: 0x7FF180 Offset: 0x7FD780 VA: 0x1807FF180
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7FE590 Offset: 0x7FCB90 VA: 0x1807FE590
	private void DrawGUIText(float x, float y, Vector2 size, string text, GUIStyle fontStyle) { }

	// RVA: 0x7FEC70 Offset: 0x7FD270 VA: 0x1807FEC70
	private void OnGUI() { }

	// RVA: 0x7FFB20 Offset: 0x7FE120 VA: 0x1807FFB20
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

