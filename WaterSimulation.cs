public class WaterSimulation // TypeDefIndex: 10623
{	// Fields
	private const int MaxSolverResolution = 512;
	private WaterSystem water; // 0x10
	private Camera camera; // 0x18
	private int solverResolution; // 0x20
	private float solverSizeInWorld; // 0x24
	private float gravity; // 0x28
	private float amplitude; // 0x2C
	private int solverButterflyCount; // 0x30
	private Vector2 windDirection; // 0x34
	private float windMagnitude; // 0x3C
	private RenderTexture displacementMap; // 0x40
	private Vector4 displacementMapTexelSize; // 0x48
	private RenderTexture normalFoldMap; // 0x58
	private Material computeNormalFoldMat; // 0x60
	private Material simulationMat; // 0x68
	private Texture2D hTilde0Map; // 0x70
	private Texture2D dispersionMap; // 0x78
	private Texture2D butterflyMap; // 0x80
	private RenderTexture hTilde_hMap; // 0x88
	private RenderTexture hTilde_dxdzMap; // 0x90
	private CommandBufferManager commandBufferManager; // 0x98
	private CommandBufferDesc commandBufferDesc; // 0xA0
	private bool playing; // 0xA8
	private bool initialized; // 0xA9

	// Properties
	public Texture DisplacementMap { get; }
	public Vector4 DisplacementMapTexelSize { get; }
	public RenderTexture NormalFoldMap { get; }
	public bool IsPlaying { get; }
	public bool IsInitialized { get; }

	// Methods

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Texture get_DisplacementMap() { }

	// RVA: 0xC23AF0 Offset: 0xC220F0 VA: 0x180C23AF0
	public Vector4 get_DisplacementMapTexelSize() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public RenderTexture get_NormalFoldMap() { }

	// RVA: 0x8084F0 Offset: 0x806AF0 VA: 0x1808084F0
	public bool get_IsPlaying() { }

	// RVA: 0xC23B00 Offset: 0xC22100 VA: 0x180C23B00
	public bool get_IsInitialized() { }

	// RVA: 0xC22910 Offset: 0xC20F10 VA: 0x180C22910
	public void Initialize(WaterSystem water, WaterRuntime runtime) { }

	// RVA: 0xC21A50 Offset: 0xC20050 VA: 0x180C21A50
	public void Destroy() { }

	// RVA: 0xC20F40 Offset: 0xC1F540 VA: 0x180C20F40
	private void CheckCommandBuffer() { }

	// RVA: 0xC212A0 Offset: 0xC1F8A0 VA: 0x180C212A0
	private void CleanupCommandBuffer() { }

	// RVA: 0xC21D50 Offset: 0xC20350 VA: 0x180C21D50
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA3D0 Offset: 0x5D89D0 VA: 0x1805DA3D0
	|-WaterSimulation.SafeDestroy<object>
	|-WaterSimulation.SafeDestroy<Material>
	|-WaterSimulation.SafeDestroy<RenderTexture>
	|-WaterSimulation.SafeDestroy<Texture2D>
	*/

	// RVA: 0xC22440 Offset: 0xC20A40 VA: 0x180C22440
	private void InitializeMaterials() { }

	// RVA: 0xC21940 Offset: 0xC1FF40 VA: 0x180C21940
	private void DestroyMaterials() { }

	// RVA: 0xC22D60 Offset: 0xC21360 VA: 0x180C22D60
	private int ReverseBits(int value, int bitCount) { }

	// RVA: 0xC21370 Offset: 0xC1F970 VA: 0x180C21370
	private WaterSimulation.Butterfly[] CreateButterflyTable(int res, int numButterflies) { }

	// RVA: 0xC21710 Offset: 0xC1FD10 VA: 0x180C21710
	private RenderTexture CreateRenderTexture(string name, int width, int height, RenderTextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC21840 Offset: 0xC1FE40 VA: 0x180C21840
	private Texture2D CreateTexture(string name, int width, int height, TextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC22530 Offset: 0xC20B30 VA: 0x180C22530
	private void InitializeTextures() { }

	// RVA: 0xC21990 Offset: 0xC1FF90 VA: 0x180C21990
	private void DestroyTextures() { }

	// RVA: 0xC21FE0 Offset: 0xC205E0 VA: 0x180C21FE0
	private void InitializeFFT() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void DestroyFFT() { }

	// RVA: 0xC20A90 Offset: 0xC1F090 VA: 0x180C20A90
	private void BindMaterialProperties() { }

	// RVA: 0xC21120 Offset: 0xC1F720 VA: 0x180C21120
	public bool CheckLostData() { }

	// RVA: 0xC237D0 Offset: 0xC21DD0 VA: 0x180C237D0
	private void UpdateSimulationParams() { }

	// RVA: 0xC23A80 Offset: 0xC22080 VA: 0x180C23A80
	public void Update() { }

	// RVA: 0x962E60 Offset: 0x961460 VA: 0x180962E60
	public void Play() { }

	// RVA: 0xC23240 Offset: 0xC21840 VA: 0x180C23240
	public void Stop() { }

	// RVA: 0xC21C60 Offset: 0xC20260 VA: 0x180C21C60
	private float Dispersion(int n_prime, int m_prime) { }

	// RVA: 0xC22B40 Offset: 0xC21140 VA: 0x180C22B40
	private float Phillips(int n_prime, int m_prime) { }

	// RVA: 0xC21F30 Offset: 0xC20530 VA: 0x180C21F30
	private float Gauss() { }

	// RVA: 0xC23B10 Offset: 0xC22110 VA: 0x180C23B10
	private Vector2 hTilde_0(int n_prime, int m_prime) { }

	// RVA: 0xC21B80 Offset: 0xC20180 VA: 0x180C21B80
	private void Disperse(CommandBuffer cb) { }

	// RVA: 0xC20C60 Offset: 0xC1F260 VA: 0x180C20C60
	private void BlitOverride(CommandBuffer cb, RenderTexture source, RenderTargetIdentifier destination, Material material, int pass) { }

	// RVA: 0xC23250 Offset: 0xC21850 VA: 0x180C23250
	private void Transform(CommandBuffer cb, RenderTexture data) { }

	// RVA: 0xC23990 Offset: 0xC21F90 VA: 0x180C23990
	private void UpdateTextures(CommandBuffer cb) { }

	// RVA: 0xC22D90 Offset: 0xC21390 VA: 0x180C22D90
	public void ShowDebug() { }

	// RVA: 0xC23AC0 Offset: 0xC220C0 VA: 0x180C23AC0
	public void .ctor() { }

}

public struct WaterSimulation.Butterfly // TypeDefIndex: 10624
{	// Fields
	public int i; // 0x0
	public int j; // 0x4
	public float wr; // 0x8
	public float wi; // 0xC

}

