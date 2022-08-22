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

	// RVA: 0xC23DB0 Offset: 0xC223B0 VA: 0x180C23DB0
	public Vector4 get_DisplacementMapTexelSize() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public RenderTexture get_NormalFoldMap() { }

	// RVA: 0x808600 Offset: 0x806C00 VA: 0x180808600
	public bool get_IsPlaying() { }

	// RVA: 0xC23DC0 Offset: 0xC223C0 VA: 0x180C23DC0
	public bool get_IsInitialized() { }

	// RVA: 0xC22BD0 Offset: 0xC211D0 VA: 0x180C22BD0
	public void Initialize(WaterSystem water, WaterRuntime runtime) { }

	// RVA: 0xC21D10 Offset: 0xC20310 VA: 0x180C21D10
	public void Destroy() { }

	// RVA: 0xC21200 Offset: 0xC1F800 VA: 0x180C21200
	private void CheckCommandBuffer() { }

	// RVA: 0xC21560 Offset: 0xC1FB60 VA: 0x180C21560
	private void CleanupCommandBuffer() { }

	// RVA: 0xC22010 Offset: 0xC20610 VA: 0x180C22010
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

	// RVA: 0xC22700 Offset: 0xC20D00 VA: 0x180C22700
	private void InitializeMaterials() { }

	// RVA: 0xC21C00 Offset: 0xC20200 VA: 0x180C21C00
	private void DestroyMaterials() { }

	// RVA: 0xC23020 Offset: 0xC21620 VA: 0x180C23020
	private int ReverseBits(int value, int bitCount) { }

	// RVA: 0xC21630 Offset: 0xC1FC30 VA: 0x180C21630
	private WaterSimulation.Butterfly[] CreateButterflyTable(int res, int numButterflies) { }

	// RVA: 0xC219D0 Offset: 0xC1FFD0 VA: 0x180C219D0
	private RenderTexture CreateRenderTexture(string name, int width, int height, RenderTextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC21B00 Offset: 0xC20100 VA: 0x180C21B00
	private Texture2D CreateTexture(string name, int width, int height, TextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC227F0 Offset: 0xC20DF0 VA: 0x180C227F0
	private void InitializeTextures() { }

	// RVA: 0xC21C50 Offset: 0xC20250 VA: 0x180C21C50
	private void DestroyTextures() { }

	// RVA: 0xC222A0 Offset: 0xC208A0 VA: 0x180C222A0
	private void InitializeFFT() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void DestroyFFT() { }

	// RVA: 0xC20D50 Offset: 0xC1F350 VA: 0x180C20D50
	private void BindMaterialProperties() { }

	// RVA: 0xC213E0 Offset: 0xC1F9E0 VA: 0x180C213E0
	public bool CheckLostData() { }

	// RVA: 0xC23A90 Offset: 0xC22090 VA: 0x180C23A90
	private void UpdateSimulationParams() { }

	// RVA: 0xC23D40 Offset: 0xC22340 VA: 0x180C23D40
	public void Update() { }

	// RVA: 0x962F70 Offset: 0x961570 VA: 0x180962F70
	public void Play() { }

	// RVA: 0xC23500 Offset: 0xC21B00 VA: 0x180C23500
	public void Stop() { }

	// RVA: 0xC21F20 Offset: 0xC20520 VA: 0x180C21F20
	private float Dispersion(int n_prime, int m_prime) { }

	// RVA: 0xC22E00 Offset: 0xC21400 VA: 0x180C22E00
	private float Phillips(int n_prime, int m_prime) { }

	// RVA: 0xC221F0 Offset: 0xC207F0 VA: 0x180C221F0
	private float Gauss() { }

	// RVA: 0xC23DD0 Offset: 0xC223D0 VA: 0x180C23DD0
	private Vector2 hTilde_0(int n_prime, int m_prime) { }

	// RVA: 0xC21E40 Offset: 0xC20440 VA: 0x180C21E40
	private void Disperse(CommandBuffer cb) { }

	// RVA: 0xC20F20 Offset: 0xC1F520 VA: 0x180C20F20
	private void BlitOverride(CommandBuffer cb, RenderTexture source, RenderTargetIdentifier destination, Material material, int pass) { }

	// RVA: 0xC23510 Offset: 0xC21B10 VA: 0x180C23510
	private void Transform(CommandBuffer cb, RenderTexture data) { }

	// RVA: 0xC23C50 Offset: 0xC22250 VA: 0x180C23C50
	private void UpdateTextures(CommandBuffer cb) { }

	// RVA: 0xC23050 Offset: 0xC21650 VA: 0x180C23050
	public void ShowDebug() { }

	// RVA: 0xC23D80 Offset: 0xC22380 VA: 0x180C23D80
	public void .ctor() { }

}

public struct WaterSimulation.Butterfly // TypeDefIndex: 10624
{	// Fields
	public int i; // 0x0
	public int j; // 0x4
	public float wr; // 0x8
	public float wi; // 0xC

}

