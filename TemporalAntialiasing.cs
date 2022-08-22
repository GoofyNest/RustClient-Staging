public sealed class TemporalAntialiasing // TypeDefIndex: 11811
{	// Fields
	[TooltipAttribute] // RVA: 0x765D0 Offset: 0x759D0 VA: 0x1800765D0
	[RangeAttribute] // RVA: 0x765D0 Offset: 0x759D0 VA: 0x1800765D0
	public float jitterSpread; // 0x10
	[TooltipAttribute] // RVA: 0x767B0 Offset: 0x75BB0 VA: 0x1800767B0
	[RangeAttribute] // RVA: 0x767B0 Offset: 0x75BB0 VA: 0x1800767B0
	public float sharpness; // 0x14
	[TooltipAttribute] // RVA: 0x76900 Offset: 0x75D00 VA: 0x180076900
	[RangeAttribute] // RVA: 0x76900 Offset: 0x75D00 VA: 0x180076900
	public float stationaryBlending; // 0x18
	[TooltipAttribute] // RVA: 0x76AF0 Offset: 0x75EF0 VA: 0x180076AF0
	[RangeAttribute] // RVA: 0x76AF0 Offset: 0x75EF0 VA: 0x180076AF0
	public float motionBlending; // 0x1C
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <jitter>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <jitterRaw>k__BackingField; // 0x30
	private readonly RenderTargetIdentifier[] m_Mrt; // 0x38
	private bool m_ResetHistory; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <sampleIndex>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <sampleCount>k__BackingField; // 0x48
	private const int k_NumEyes = 2;
	private const int k_NumHistoryTextures = 2;
	private readonly RenderTexture[][] m_HistoryTextures; // 0x50
	private readonly int[] m_HistoryPingPong; // 0x58

	// Properties
	public Vector2 jitter { get; set; }
	public Vector2 jitterRaw { get; set; }
	public int sampleIndex { get; set; }
	public int sampleCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E3470 Offset: 0x11E1A70 VA: 0x1811E3470
	public Vector2 get_jitter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A30 Offset: 0xE72030 VA: 0x180E73A30
	private void set_jitter(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC15780 Offset: 0xC13D80 VA: 0x180C15780
	public Vector2 get_jitterRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC157C0 Offset: 0xC13DC0 VA: 0x180C157C0
	private void set_jitterRaw(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public int get_sampleIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1320 Offset: 0x8BF920 VA: 0x1808C1320
	private void set_sampleIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public int get_sampleCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	public void set_sampleCount(int value) { }

	// RVA: 0x11E2B60 Offset: 0x11E1160 VA: 0x1811E2B60
	public bool IsSupported() { }

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x514C50 Offset: 0x513250 VA: 0x180514C50
	internal void ResetHistory() { }

	// RVA: 0x11E2670 Offset: 0x11E0C70 VA: 0x1811E2670
	private Vector2 GenerateRandomOffset() { }

	// RVA: 0x11E2700 Offset: 0x11E0D00 VA: 0x1811E2700
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	// RVA: 0x11E21F0 Offset: 0x11E07F0 VA: 0x1811E21F0
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	// RVA: 0x11E22D0 Offset: 0x11E08D0 VA: 0x1811E22D0
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	// RVA: 0x11E2590 Offset: 0x11E0B90 VA: 0x1811E2590
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	// RVA: 0x11E1980 Offset: 0x11DFF80 VA: 0x1811E1980
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	// RVA: 0x11E2D90 Offset: 0x11E1390 VA: 0x1811E2D90
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x11E2BA0 Offset: 0x11E11A0 VA: 0x1811E2BA0
	internal void Release() { }

	// RVA: 0x11E33B0 Offset: 0x11E19B0 VA: 0x1811E33B0
	public void .ctor() { }

}

private enum TemporalAntialiasing.Pass // TypeDefIndex: 11812
{	// Fields
	public int value__; // 0x0
	public const TemporalAntialiasing.Pass SolverDilate = 0;
	public const TemporalAntialiasing.Pass SolverNoDilate = 1;

}

