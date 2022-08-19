public class HableCurve // TypeDefIndex: 11858
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <whitePoint>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <inverseWhitePoint>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <x0>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <x1>k__BackingField; // 0x1C
	private readonly HableCurve.Segment[] m_Segments; // 0x20
	public readonly HableCurve.Uniforms uniforms; // 0x28

	// Properties
	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	internal float x0 { get; set; }
	internal float x1 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA10E10 Offset: 0xA0F410 VA: 0x180A10E10
	public float get_whitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA10E30 Offset: 0xA0F430 VA: 0x180A10E30
	private void set_whitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE72D10 Offset: 0xE71310 VA: 0x180E72D10
	public float get_inverseWhitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE72D20 Offset: 0xE71320 VA: 0x180E72D20
	private void set_inverseWhitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	internal float get_x0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	private void set_x0(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x774680 Offset: 0x772C80 VA: 0x180774680
	internal float get_x1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746C0 Offset: 0x772CC0 VA: 0x1807746C0
	private void set_x1(float value) { }

	// RVA: 0x10172E0 Offset: 0x10158E0 VA: 0x1810172E0
	public void .ctor() { }

	// RVA: 0x1016960 Offset: 0x1014F60 VA: 0x181016960
	public float Eval(float x) { }

	// RVA: 0x1016FF0 Offset: 0x10155F0 VA: 0x181016FF0
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x10169D0 Offset: 0x1014FD0 VA: 0x1810169D0
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x1017220 Offset: 0x1015820 VA: 0x181017220
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x1016860 Offset: 0x1014E60 VA: 0x181016860
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x10168C0 Offset: 0x1014EC0 VA: 0x1810168C0
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

	// RVA: 0x102CD70 Offset: 0x102B370 VA: 0x18102CD70
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(HableCurve parent) { }

	// RVA: 0x102D600 Offset: 0x102BC00 VA: 0x18102D600
	public Vector4 get_curve() { }

	// RVA: 0x102D850 Offset: 0x102BE50 VA: 0x18102D850
	public Vector4 get_toeSegmentA() { }

	// RVA: 0x102D8D0 Offset: 0x102BED0 VA: 0x18102D8D0
	public Vector4 get_toeSegmentB() { }

	// RVA: 0x102D650 Offset: 0x102BC50 VA: 0x18102D650
	public Vector4 get_midSegmentA() { }

	// RVA: 0x102D6D0 Offset: 0x102BCD0 VA: 0x18102D6D0
	public Vector4 get_midSegmentB() { }

	// RVA: 0x102D750 Offset: 0x102BD50 VA: 0x18102D750
	public Vector4 get_shoSegmentA() { }

	// RVA: 0x102D7D0 Offset: 0x102BDD0 VA: 0x18102D7D0
	public Vector4 get_shoSegmentB() { }

}

