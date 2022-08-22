public class HableCurve // TypeDefIndex: 11858
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <whitePoint>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <inverseWhitePoint>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <x0>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <x1>k__BackingField; // 0x1C
	private readonly HableCurve.Segment[] m_Segments; // 0x20
	public readonly HableCurve.Uniforms uniforms; // 0x28

	// Properties
	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	internal float x0 { get; set; }
	internal float x1 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA115C0 Offset: 0xA0FBC0 VA: 0x180A115C0
	public float get_whitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA115E0 Offset: 0xA0FBE0 VA: 0x180A115E0
	private void set_whitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A80 Offset: 0xE72080 VA: 0x180E73A80
	public float get_inverseWhitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A90 Offset: 0xE72090 VA: 0x180E73A90
	private void set_inverseWhitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	internal float get_x0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774750 Offset: 0x772D50 VA: 0x180774750
	private void set_x0(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	internal float get_x1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774720 Offset: 0x772D20 VA: 0x180774720
	private void set_x1(float value) { }

	// RVA: 0x1018040 Offset: 0x1016640 VA: 0x181018040
	public void .ctor() { }

	// RVA: 0x10176C0 Offset: 0x1015CC0 VA: 0x1810176C0
	public float Eval(float x) { }

	// RVA: 0x1017D50 Offset: 0x1016350 VA: 0x181017D50
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x1017730 Offset: 0x1015D30 VA: 0x181017730
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x1017F80 Offset: 0x1016580 VA: 0x181017F80
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x10175C0 Offset: 0x1015BC0 VA: 0x1810175C0
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x1017620 Offset: 0x1015C20 VA: 0x181017620
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }

}

private class HableCurve.Segment // TypeDefIndex: 11859
{	// Fields
	public float offsetX; // 0x10
	public float offsetY; // 0x14
	public float scaleX; // 0x18
	public float scaleY; // 0x1C
	public float lnA; // 0x20
	public float B; // 0x24

	// Methods

	// RVA: 0x102DAD0 Offset: 0x102C0D0 VA: 0x18102DAD0
	public float Eval(float x) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct HableCurve.DirectParams // TypeDefIndex: 11860
{	// Fields
	internal float x0; // 0x0
	internal float y0; // 0x4
	internal float x1; // 0x8
	internal float y1; // 0xC
	internal float W; // 0x10
	internal float overshootX; // 0x14
	internal float overshootY; // 0x18
	internal float gamma; // 0x1C

}

public class HableCurve.Uniforms // TypeDefIndex: 11861
{	// Fields
	private HableCurve parent; // 0x10

	// Properties
	public Vector4 curve { get; }
	public Vector4 toeSegmentA { get; }
	public Vector4 toeSegmentB { get; }
	public Vector4 midSegmentA { get; }
	public Vector4 midSegmentB { get; }
	public Vector4 shoSegmentA { get; }
	public Vector4 shoSegmentB { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(HableCurve parent) { }

	// RVA: 0x102E360 Offset: 0x102C960 VA: 0x18102E360
	public Vector4 get_curve() { }

	// RVA: 0x102E5B0 Offset: 0x102CBB0 VA: 0x18102E5B0
	public Vector4 get_toeSegmentA() { }

	// RVA: 0x102E630 Offset: 0x102CC30 VA: 0x18102E630
	public Vector4 get_toeSegmentB() { }

	// RVA: 0x102E3B0 Offset: 0x102C9B0 VA: 0x18102E3B0
	public Vector4 get_midSegmentA() { }

	// RVA: 0x102E430 Offset: 0x102CA30 VA: 0x18102E430
	public Vector4 get_midSegmentB() { }

	// RVA: 0x102E4B0 Offset: 0x102CAB0 VA: 0x18102E4B0
	public Vector4 get_shoSegmentA() { }

	// RVA: 0x102E530 Offset: 0x102CB30 VA: 0x18102E530
	public Vector4 get_shoSegmentB() { }

}

