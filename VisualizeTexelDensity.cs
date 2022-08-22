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

	// RVA: 0x800220 Offset: 0x7FE820 VA: 0x180800220
	public static VisualizeTexelDensity get_Instance() { }

	// RVA: 0x7FEB90 Offset: 0x7FD190 VA: 0x1807FEB90
	private void Awake() { }

	// RVA: 0x7FF150 Offset: 0x7FD750 VA: 0x1807FF150
	private void OnEnable() { }

	// RVA: 0x7FF0D0 Offset: 0x7FD6D0 VA: 0x1807FF0D0
	private void OnDisable() { }

	// RVA: 0x7FEF70 Offset: 0x7FD570 VA: 0x1807FEF70
	private void LoadResources() { }

	// RVA: 0x7FFA80 Offset: 0x7FE080 VA: 0x1807FFA80
	private void SafeDestroyViewTexelDensity() { }

	// RVA: 0x7FF990 Offset: 0x7FDF90 VA: 0x1807FF990
	private void SafeDestroyViewTexelDensityRT() { }

	// RVA: 0x7FFC10 Offset: 0x7FE210 VA: 0x1807FFC10
	private void UpdateViewTexelDensity(bool screenResized) { }

	// RVA: 0x7FEC10 Offset: 0x7FD210 VA: 0x1807FEC10
	private bool CheckScreenResized(int width, int height) { }

	// RVA: 0x7FF820 Offset: 0x7FDE20 VA: 0x1807FF820
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7FEC30 Offset: 0x7FD230 VA: 0x1807FEC30
	private void DrawGUIText(float x, float y, Vector2 size, string text, GUIStyle fontStyle) { }

	// RVA: 0x7FF310 Offset: 0x7FD910 VA: 0x1807FF310
	private void OnGUI() { }

	// RVA: 0x8001C0 Offset: 0x7FE7C0 VA: 0x1808001C0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

