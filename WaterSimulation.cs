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

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Texture get_DisplacementMap() { }

	// RVA: 0xC24280 Offset: 0xC22880 VA: 0x180C24280
	public Vector4 get_DisplacementMapTexelSize() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public RenderTexture get_NormalFoldMap() { }

	// RVA: 0x808B90 Offset: 0x807190 VA: 0x180808B90
	public bool get_IsPlaying() { }

	// RVA: 0xC24290 Offset: 0xC22890 VA: 0x180C24290
	public bool get_IsInitialized() { }

	// RVA: 0xC230A0 Offset: 0xC216A0 VA: 0x180C230A0
	public void Initialize(WaterSystem water, WaterRuntime runtime) { }

	// RVA: 0xC221E0 Offset: 0xC207E0 VA: 0x180C221E0
	public void Destroy() { }

	// RVA: 0xC216D0 Offset: 0xC1FCD0 VA: 0x180C216D0
	private void CheckCommandBuffer() { }

	// RVA: 0xC21A30 Offset: 0xC20030 VA: 0x180C21A30
	private void CleanupCommandBuffer() { }

	// RVA: 0xC224E0 Offset: 0xC20AE0 VA: 0x180C224E0
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA360 Offset: 0x5D8960 VA: 0x1805DA360
	|-WaterSimulation.SafeDestroy<object>
	|-WaterSimulation.SafeDestroy<Material>
	|-WaterSimulation.SafeDestroy<RenderTexture>
	|-WaterSimulation.SafeDestroy<Texture2D>
	*/

	// RVA: 0xC22BD0 Offset: 0xC211D0 VA: 0x180C22BD0
	private void InitializeMaterials() { }

	// RVA: 0xC220D0 Offset: 0xC206D0 VA: 0x180C220D0
	private void DestroyMaterials() { }

	// RVA: 0xC234F0 Offset: 0xC21AF0 VA: 0x180C234F0
	private int ReverseBits(int value, int bitCount) { }

	// RVA: 0xC21B00 Offset: 0xC20100 VA: 0x180C21B00
	private WaterSimulation.Butterfly[] CreateButterflyTable(int res, int numButterflies) { }

	// RVA: 0xC21EA0 Offset: 0xC204A0 VA: 0x180C21EA0
	private RenderTexture CreateRenderTexture(string name, int width, int height, RenderTextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC21FD0 Offset: 0xC205D0 VA: 0x180C21FD0
	private Texture2D CreateTexture(string name, int width, int height, TextureFormat format, TextureWrapMode wrap, FilterMode filter) { }

	// RVA: 0xC22CC0 Offset: 0xC212C0 VA: 0x180C22CC0
	private void InitializeTextures() { }

	// RVA: 0xC22120 Offset: 0xC20720 VA: 0x180C22120
	private void DestroyTextures() { }

	// RVA: 0xC22770 Offset: 0xC20D70 VA: 0x180C22770
	private void InitializeFFT() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void DestroyFFT() { }

	// RVA: 0xC21220 Offset: 0xC1F820 VA: 0x180C21220
	private void BindMaterialProperties() { }

	// RVA: 0xC218B0 Offset: 0xC1FEB0 VA: 0x180C218B0
	public bool CheckLostData() { }

	// RVA: 0xC23F60 Offset: 0xC22560 VA: 0x180C23F60
	private void UpdateSimulationParams() { }

	// RVA: 0xC24210 Offset: 0xC22810 VA: 0x180C24210
	public void Update() { }

	// RVA: 0x963470 Offset: 0x961A70 VA: 0x180963470
	public void Play() { }

	// RVA: 0xC239D0 Offset: 0xC21FD0 VA: 0x180C239D0
	public void Stop() { }

	// RVA: 0xC223F0 Offset: 0xC209F0 VA: 0x180C223F0
	private float Dispersion(int n_prime, int m_prime) { }

	// RVA: 0xC232D0 Offset: 0xC218D0 VA: 0x180C232D0
	private float Phillips(int n_prime, int m_prime) { }

	// RVA: 0xC226C0 Offset: 0xC20CC0 VA: 0x180C226C0
	private float Gauss() { }

	// RVA: 0xC242A0 Offset: 0xC228A0 VA: 0x180C242A0
	private Vector2 hTilde_0(int n_prime, int m_prime) { }

	// RVA: 0xC22310 Offset: 0xC20910 VA: 0x180C22310
	private void Disperse(CommandBuffer cb) { }

	// RVA: 0xC213F0 Offset: 0xC1F9F0 VA: 0x180C213F0
	private void BlitOverride(CommandBuffer cb, RenderTexture source, RenderTargetIdentifier destination, Material material, int pass) { }

	// RVA: 0xC239E0 Offset: 0xC21FE0 VA: 0x180C239E0
	private void Transform(CommandBuffer cb, RenderTexture data) { }

	// RVA: 0xC24120 Offset: 0xC22720 VA: 0x180C24120
	private void UpdateTextures(CommandBuffer cb) { }

	// RVA: 0xC23520 Offset: 0xC21B20 VA: 0x180C23520
	public void ShowDebug() { }

	// RVA: 0xC24250 Offset: 0xC22850 VA: 0x180C24250
	public void .ctor() { }

}

public struct WaterSimulation.Butterfly // TypeDefIndex: 10624
{	// Fields
	public int i; // 0x0
	public int j; // 0x4
	public float wr; // 0x8
	public float wi; // 0xC

}

