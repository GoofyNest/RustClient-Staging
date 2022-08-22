public class ReflectionProbeEx : MonoBehaviour // TypeDefIndex: 10690
{	// Fields
	private static readonly uint[,] qualitySamples; // 0x0
	private static Vector4[] sampleData; // 0x8
	private Mesh blitMesh; // 0x18
	private Mesh skyboxMesh; // 0x20
	private static float[] octaVerts; // 0x10
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatrices; // 0x18
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatricesD3D11; // 0x20
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] shadowCubemapFaceMatrices; // 0x28
	private ReflectionProbeEx.CubemapFaceMatrices[] platformCubemapFaceMatrices; // 0x28
	private static readonly HashSet<string> supportedShaderNames; // 0x30
	private static Dictionary<Shader, Shader> supportedShaders; // 0x38
	private static Dictionary<Material, Material> matchingMaterials; // 0x40
	private RenderTexture probeTempTexture; // 0x30
	private RenderTexture probeShadowTexture; // 0x38
	private RenderTexture arrayTexture; // 0x40
	private RenderTexture arrayTempTexture; // 0x48
	private RenderTexture arrayDepthTexture; // 0x50
	private int mipmapCount; // 0x58
	private Material blitMaterial; // 0x60
	private Material filterMaterial; // 0x68
	private Material shadowMaterial; // 0x70
	private CommandBuffer forwardCB; // 0x78
	private CommandBuffer shadowCB; // 0x80
	private Matrix4x4[] viewProjMatrixArray; // 0x88
	private Matrix4x4[] objectToWorldArray; // 0x90
	private Matrix4x4[] cameraToWorldArray; // 0x98
	private bool useGeometryShader; // 0xA0
	private int PassCount; // 0xA4
	private static readonly int[] tab32; // 0x48
	public ReflectionProbeRefreshMode refreshMode; // 0xA8
	public bool timeSlicing; // 0xAC
	public int resolution; // 0xB0
	[InspectorNameAttribute] // RVA: 0x71950 Offset: 0x70D50 VA: 0x180071950
	public bool hdr; // 0xB4
	public float shadowDistance; // 0xB8
	public ReflectionProbeClearFlags clearFlags; // 0xBC
	public Color background; // 0xC0
	public float nearClip; // 0xD0
	public float farClip; // 0xD4
	public Transform attachToTarget; // 0xD8
	public Light directionalLight; // 0xE0
	public float textureMipBias; // 0xE8
	public bool highPrecision; // 0xEC
	public bool enableShadows; // 0xED
	public ReflectionProbeEx.ConvolutionQuality convolutionQuality; // 0xF0
	public List<ReflectionProbeEx.RenderListEntry> staticRenderList; // 0xF8
	public Cubemap reflectionCubemap; // 0x100
	public float reflectionIntensity; // 0x108
	private List<ReflectionProbeEx.RenderListEntry> dynamicRenderList; // 0x110
	private ReflectionProbe probe; // 0x118
	private RenderTexture probeTexture; // 0x120
	private int probeResolution; // 0x128
	private bool probeHdr; // 0x12C
	private float probeShadowDistance; // 0x130
	private float probeNearClip; // 0x134
	private float probeFarClip; // 0x138
	private const int probeDepth = 24;
	private bool probeHighPrecision; // 0x13C
	private ReflectionProbeEx.TimeSlicingState timeSlicedRenderState; // 0x140
	private bool scriptingRenderQueued; // 0x144
	private Matrix4x4 faceProjMatrix; // 0x148
	private Matrix4x4 faceProjInvMatrix; // 0x188
	private int prevFrame; // 0x1C8
	private ReflectionProbeRefreshMode savedProbeRefresh; // 0x1CC
	private ReflectionProbeMode savedProbeMode; // 0x1D0
	private Texture savedProbeCustomTexture; // 0x1D8

	// Properties
	public RenderTexture Texture { get; }

	// Methods

	// RVA: 0x943360 Offset: 0x941960 VA: 0x180943360
	private Vector2 Hammersley(uint index, uint numSamples) { }

	// RVA: 0x942C00 Offset: 0x941200 VA: 0x180942C00
	private float D_GGX(float roughness, float NdotH) { }

	// RVA: 0x943430 Offset: 0x941A30 VA: 0x180943430
	private Vector3 ImportanceSampleGGX(Vector2 Xi, float roughness) { }

	// RVA: 0x93FA30 Offset: 0x93E030 VA: 0x18093FA30
	private void ApplyConvolution(Texture target) { }

	// RVA: 0x941B80 Offset: 0x940180 VA: 0x180941B80
	private void CreateMeshes() { }

	// RVA: 0x942D10 Offset: 0x941310 VA: 0x180942D10
	private void DestroyMeshes() { }

	// RVA: 0x941480 Offset: 0x93FA80 VA: 0x180941480
	private static Mesh CreateBlitMesh() { }

	// RVA: 0x946830 Offset: 0x944E30 VA: 0x180946830
	private static ReflectionProbeEx.CubemapSkyboxVertex SubDivVert(ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2) { }

	// RVA: 0x946FE0 Offset: 0x9455E0 VA: 0x180946FE0
	private static void Subdivide(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x9469C0 Offset: 0x944FC0 VA: 0x1809469C0
	private static void SubdivideYOnly(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x941C90 Offset: 0x940290 VA: 0x180941C90
	private static Mesh CreateSkyboxMesh() { }

	// RVA: 0x943530 Offset: 0x941B30 VA: 0x180943530
	private bool InitializeCubemapFaceMatrices() { }

	// RVA: 0x942700 Offset: 0x940D00 VA: 0x180942700
	private void CreateTextures() { }

	// RVA: 0x942E40 Offset: 0x941440 VA: 0x180942E40
	private void DestroyTextures() { }

	// RVA: 0x945040 Offset: 0x943640 VA: 0x180945040
	private Material RegisterMaterialReplacement(Material material) { }

	// RVA: 0x943270 Offset: 0x941870 VA: 0x180943270
	private Material FindMaterialReplacement(Material material) { }

	// RVA: 0x941880 Offset: 0x93FE80 VA: 0x180941880
	private void CreateMaterials() { }

	// RVA: 0x942CA0 Offset: 0x9412A0 VA: 0x180942CA0
	private void DestroyMaterials() { }

	// RVA: 0x9417E0 Offset: 0x93FDE0 VA: 0x1809417E0
	private void CreateCommandBuffers() { }

	// RVA: 0x942C40 Offset: 0x941240 VA: 0x180942C40
	private void DestroyCommandBuffers() { }

	// RVA: 0x941390 Offset: 0x93F990 VA: 0x180941390
	private void ClearCommandBuffers() { }

	// RVA: 0x9401D0 Offset: 0x93E7D0 VA: 0x1809401D0
	private void AttachToLight() { }

	// RVA: 0x942EF0 Offset: 0x9414F0 VA: 0x180942EF0
	private void DetachFromLight() { }

	// RVA: 0x943100 Offset: 0x941700 VA: 0x180943100
	private void FindEnvironmentReflection() { }

	// RVA: 0x941040 Offset: 0x93F640 VA: 0x180941040
	private void BindGlobalProperties() { }

	// RVA: 0x940BB0 Offset: 0x93F1B0 VA: 0x180940BB0
	private void BindGlobalLight() { }

	// RVA: 0x9402F0 Offset: 0x93E8F0 VA: 0x1809402F0
	private void BindGlobalAmbient() { }

	// RVA: 0x941140 Offset: 0x93F740 VA: 0x180941140
	private void BindGlobalReflection() { }

	// RVA: 0x945420 Offset: 0x943A20 VA: 0x180945420
	private void RenderObjects() { }

	// RVA: 0x945D70 Offset: 0x944370 VA: 0x180945D70
	private void RenderSkybox() { }

	// RVA: 0x943AA0 Offset: 0x9420A0 VA: 0x180943AA0
	private void IssueRender() { }

	// RVA: 0x9439C0 Offset: 0x941FC0 VA: 0x1809439C0
	private void IssueGenerateMips() { }

	// RVA: 0x9436A0 Offset: 0x941CA0 VA: 0x1809436A0
	private void IssueConvolution() { }

	// RVA: 0x943CD0 Offset: 0x9422D0 VA: 0x180943CD0
	private void IssueShadow() { }

	// RVA: 0x944E30 Offset: 0x943430 VA: 0x180944E30
	private void PrepareFullRender() { }

	// RVA: 0x944F10 Offset: 0x943510 VA: 0x180944F10
	private void PrepareTimeSlicedRender(ReflectionProbeEx.TimeSlicingState state) { }

	// RVA: 0x942FC0 Offset: 0x9415C0 VA: 0x180942FC0
	private void ExecuteRender() { }

	// RVA: 0x943050 Offset: 0x941650 VA: 0x180943050
	private int FastLog2(int value) { }

	// RVA: 0x9463A0 Offset: 0x9449A0 VA: 0x1809463A0
	private uint ReverseBits(uint bits) { }

	// RVA: 0x946790 Offset: 0x944D90 VA: 0x180946790
	private void SafeCreateMaterial(ref Material mat, Shader shader) { }

	// RVA: 0x946690 Offset: 0x944C90 VA: 0x180946690
	private void SafeCreateMaterial(ref Material mat, string shaderName) { }

	// RVA: 0x9464A0 Offset: 0x944AA0 VA: 0x1809464A0
	private void SafeCreateCubeRT(ref RenderTexture rt, string name, int size, int depth, bool mips, TextureDimension dim, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite = 1) { }

	// RVA: 0x946410 Offset: 0x944A10 VA: 0x180946410
	private void SafeCreateCB(ref CommandBuffer cb, string name) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFECE0 Offset: 0xCFD2E0 VA: 0x180CFECE0
	|-ReflectionProbeEx.SafeDestroy<object>
	|-ReflectionProbeEx.SafeDestroy<Material>
	|-ReflectionProbeEx.SafeDestroy<RenderTexture>
	*/

	// RVA: -1 Offset: -1
	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFED80 Offset: 0xCFD380 VA: 0x180CFED80
	|-ReflectionProbeEx.SafeDispose<object>
	|-ReflectionProbeEx.SafeDispose<CommandBuffer>
	*/

	// RVA: 0x7DDD70 Offset: 0x7DC370 VA: 0x1807DDD70
	public RenderTexture get_Texture() { }

	// RVA: 0x941430 Offset: 0x93FA30 VA: 0x180941430
	public void ClearRenderList() { }

	// RVA: 0x93F970 Offset: 0x93DF70 VA: 0x18093F970
	public void AddToRenderList(Renderer renderer, bool alwaysEnabled = False) { }

	// RVA: 0x9402A0 Offset: 0x93E8A0 VA: 0x1809402A0
	private void Awake() { }

	// RVA: 0x944940 Offset: 0x942F40 VA: 0x180944940
	private void OnEnable() { }

	// RVA: 0x944620 Offset: 0x942C20 VA: 0x180944620
	private void OnDisable() { }

	// RVA: 0x944170 Offset: 0x942770 VA: 0x180944170
	private void OnCameraPreRender(Camera cam) { }

	// RVA: 0x945D50 Offset: 0x944350 VA: 0x180945D50
	public void RenderProbe() { }

	// RVA: 0x943680 Offset: 0x941C80 VA: 0x180943680
	public bool IsFinishedRendering() { }

	// RVA: 0x944050 Offset: 0x942650 VA: 0x180944050
	private void ModifyProbeProperties() { }

	// RVA: 0x9462E0 Offset: 0x9448E0 VA: 0x1809462E0
	private void RestoreProbeSettings() { }

	// RVA: 0x9473E0 Offset: 0x9459E0 VA: 0x1809473E0
	private bool UpdateProperties() { }

	// RVA: 0x949710 Offset: 0x947D10 VA: 0x180949710
	public void .ctor() { }

	// RVA: 0x9476C0 Offset: 0x945CC0 VA: 0x1809476C0
	private static void .cctor() { }

}

private struct ReflectionProbeEx.CubemapSkyboxVertex // TypeDefIndex: 10691
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public Color color; // 0xC
	public float tu; // 0x1C
	public float tv; // 0x20
	public float tw; // 0x24

}

private struct ReflectionProbeEx.CubemapFaceMatrices // TypeDefIndex: 10692
{	// Fields
	public Matrix4x4 worldToView; // 0x0
	public Matrix4x4 viewToWorld; // 0x40

	// Methods

	// RVA: 0xFA380 Offset: 0xF9780 VA: 0x1800FA380
	public void .ctor(Vector3 x, Vector3 y, Vector3 z) { }

}

public enum ReflectionProbeEx.ConvolutionQuality // TypeDefIndex: 10693
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbeEx.ConvolutionQuality Lowest = 0;
	public const ReflectionProbeEx.ConvolutionQuality Low = 1;
	public const ReflectionProbeEx.ConvolutionQuality Medium = 2;
	public const ReflectionProbeEx.ConvolutionQuality High = 3;
	public const ReflectionProbeEx.ConvolutionQuality VeryHigh = 4;

}

public struct ReflectionProbeEx.RenderListEntry // TypeDefIndex: 10694
{	// Fields
	public Renderer renderer; // 0x0
	public bool alwaysEnabled; // 0x8

	// Methods

	// RVA: 0xFA3F0 Offset: 0xF97F0 VA: 0x1800FA3F0
	public void .ctor(Renderer renderer, bool alwaysEnabled) { }

}

private enum ReflectionProbeEx.TimeSlicingState // TypeDefIndex: 10695
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbeEx.TimeSlicingState Shadow = 0;
	public const ReflectionProbeEx.TimeSlicingState Render = 1;
	public const ReflectionProbeEx.TimeSlicingState GenerateMips = 2;
	public const ReflectionProbeEx.TimeSlicingState Convolution = 3;
	public const ReflectionProbeEx.TimeSlicingState Finished = 4;

}

