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
	// RVA: 0x11E2B10 Offset: 0x11E1110 VA: 0x1811E2B10
	public Vector2 get_jitter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72CC0 Offset: 0xE712C0 VA: 0x180E72CC0
	private void set_jitter(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC14FF0 Offset: 0xC135F0 VA: 0x180C14FF0
	public Vector2 get_jitterRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC15030 Offset: 0xC13630 VA: 0x180C15030
	private void set_jitterRaw(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_sampleIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C0D00 Offset: 0x8BF300 VA: 0x1808C0D00
	private void set_sampleIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public int get_sampleCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	public void set_sampleCount(int value) { }

	// RVA: 0x11E2200 Offset: 0x11E0800 VA: 0x1811E2200
	public bool IsSupported() { }

	// RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x514CC0 Offset: 0x5132C0 VA: 0x180514CC0
	internal void ResetHistory() { }

	// RVA: 0x11E1D10 Offset: 0x11E0310 VA: 0x1811E1D10
	private Vector2 GenerateRandomOffset() { }

	// RVA: 0x11E1DA0 Offset: 0x11E03A0 VA: 0x1811E1DA0
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	// RVA: 0x11E1890 Offset: 0x11DFE90 VA: 0x1811E1890
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	// RVA: 0x11E1970 Offset: 0x11DFF70 VA: 0x1811E1970
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	// RVA: 0x11E1C30 Offset: 0x11E0230 VA: 0x1811E1C30
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	// RVA: 0x11E1020 Offset: 0x11DF620 VA: 0x1811E1020
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	// RVA: 0x11E2430 Offset: 0x11E0A30 VA: 0x1811E2430
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x11E2240 Offset: 0x11E0840 VA: 0x1811E2240
	internal void Release() { }

	// RVA: 0x11E2A50 Offset: 0x11E1050 VA: 0x1811E2A50
	public void .ctor() { }

}

private enum TemporalAntialiasing.Pass // TypeDefIndex: 11812
{	// Fields
	public int value__; // 0x0
	public const TemporalAntialiasing.Pass SolverDilate = 0;
	public const TemporalAntialiasing.Pass SolverNoDilate = 1;

}

