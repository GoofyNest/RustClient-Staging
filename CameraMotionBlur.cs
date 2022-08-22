public class CameraMotionBlur : PostEffectsBase // TypeDefIndex: 8168
{	// Fields
	private static float MAX_RADIUS; // 0x0
	public CameraMotionBlur.MotionBlurFilter filterType; // 0x28
	public bool preview; // 0x2C
	public Vector3 previewScale; // 0x30
	public float movementScale; // 0x3C
	public float rotationScale; // 0x40
	public float maxVelocity; // 0x44
	public float minVelocity; // 0x48
	public float velocityScale; // 0x4C
	public float softZDistance; // 0x50
	public int velocityDownsample; // 0x54
	public LayerMask excludeLayers; // 0x58
	private GameObject tmpCam; // 0x60
	public Shader shader; // 0x68
	public Shader dx11MotionBlurShader; // 0x70
	public Shader replacementClear; // 0x78
	private Material motionBlurMaterial; // 0x80
	private Material dx11MotionBlurMaterial; // 0x88
	public Texture2D noiseTexture; // 0x90
	public float jitter; // 0x98
	public bool showVelocity; // 0x9C
	public float showVelocityScale; // 0xA0
	private Matrix4x4 currentViewProjMat; // 0xA4
	private Matrix4x4 prevViewProjMat; // 0xE4
	private int prevFrameCount; // 0x124
	private bool wasActive; // 0x128
	private Vector3 prevFrameForward; // 0x12C
	private Vector3 prevFrameUp; // 0x138
	private Vector3 prevFramePos; // 0x144
	private Camera _camera; // 0x150

	// Methods

	// RVA: 0x12C8050 Offset: 0x12C6650 VA: 0x1812C8050
	private void CalculateViewProjection() { }

	// RVA: 0x12CA4E0 Offset: 0x12C8AE0 VA: 0x1812CA4E0
	private void Start() { }

	// RVA: 0x12C88A0 Offset: 0x12C6EA0 VA: 0x1812C88A0
	private void OnEnable() { }

	// RVA: 0x12C86F0 Offset: 0x12C6CF0 VA: 0x1812C86F0
	private void OnDisable() { }

	// RVA: 0x12C8230 Offset: 0x12C6830 VA: 0x1812C8230 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x12C8970 Offset: 0x12C6F70 VA: 0x1812C8970
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CA2E0 Offset: 0x12C88E0 VA: 0x1812CA2E0
	private void Remember() { }

	// RVA: 0x12C82E0 Offset: 0x12C68E0 VA: 0x1812C82E0
	private Camera GetTmpCam() { }

	// RVA: 0x12CA3D0 Offset: 0x12C89D0 VA: 0x1812CA3D0
	private void StartFrame() { }

	// RVA: 0x12CA730 Offset: 0x12C8D30 VA: 0x1812CA730
	private static int divRoundUp(int x, int d) { }

	// RVA: 0x12CA610 Offset: 0x12C8C10 VA: 0x1812CA610
	public void .ctor() { }

	// RVA: 0x12CA5D0 Offset: 0x12C8BD0 VA: 0x1812CA5D0
	private static void .cctor() { }

}

public enum CameraMotionBlur.MotionBlurFilter // TypeDefIndex: 8169
{	// Fields
	public int value__; // 0x0
	public const CameraMotionBlur.MotionBlurFilter CameraMotion = 0;
	public const CameraMotionBlur.MotionBlurFilter LocalBlur = 1;
	public const CameraMotionBlur.MotionBlurFilter Reconstruction = 2;
	public const CameraMotionBlur.MotionBlurFilter ReconstructionDX11 = 3;
	public const CameraMotionBlur.MotionBlurFilter ReconstructionDisc = 4;

}

