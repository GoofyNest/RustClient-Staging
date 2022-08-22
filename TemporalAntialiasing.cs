public sealed class TemporalAntialiasing // TypeDefIndex: 11811
{	[TooltipAttribute] // RVA: 0x765D0 Offset: 0x759D0 VA: 0x1800765D0
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

	public Vector2 jitter { get; set; }
	public Vector2 jitterRaw { get; set; }
	public int sampleIndex { get; set; }
	public int sampleCount { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector2 get_jitter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_jitter(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector2 get_jitterRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_jitterRaw(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_sampleIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_sampleIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_sampleCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_sampleCount(int value) { }

	public bool IsSupported() { }

	internal DepthTextureMode GetCameraFlags() { }

	internal void ResetHistory() { }

	private Vector2 GenerateRandomOffset() { }

	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	internal void Render(PostProcessRenderContext context) { }

	internal void Release() { }

	public void .ctor() { }

}

private enum TemporalAntialiasing.Pass // TypeDefIndex: 11812
{	public int value__; // 0x0
	public const TemporalAntialiasing.Pass SolverDilate = 0;
	public const TemporalAntialiasing.Pass SolverNoDilate = 1;

}

