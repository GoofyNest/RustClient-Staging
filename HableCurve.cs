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
	// RVA: 0xA110D0 Offset: 0xA0F6D0 VA: 0x180A110D0
	public float get_whitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA110F0 Offset: 0xA0F6F0 VA: 0x180A110F0
	private void set_whitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72FD0 Offset: 0xE715D0 VA: 0x180E72FD0
	public float get_inverseWhitePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72FE0 Offset: 0xE715E0 VA: 0x180E72FE0
	private void set_inverseWhitePoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	internal float get_x0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774800 Offset: 0x772E00 VA: 0x180774800
	private void set_x0(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774790 Offset: 0x772D90 VA: 0x180774790
	internal float get_x1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747D0 Offset: 0x772DD0 VA: 0x1807747D0
	private void set_x1(float value) { }

	// RVA: 0x10175A0 Offset: 0x1015BA0 VA: 0x1810175A0
	public void .ctor() { }

	// RVA: 0x1016C20 Offset: 0x1015220 VA: 0x181016C20
	public float Eval(float x) { }

	// RVA: 0x10172B0 Offset: 0x10158B0 VA: 0x1810172B0
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x1016C90 Offset: 0x1015290 VA: 0x181016C90
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x10174E0 Offset: 0x1015AE0 VA: 0x1810174E0
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x1016B20 Offset: 0x1015120 VA: 0x181016B20
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x1016B80 Offset: 0x1015180 VA: 0x181016B80
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

	// RVA: 0x102D030 Offset: 0x102B630 VA: 0x18102D030
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

	// RVA: 0x102D8C0 Offset: 0x102BEC0 VA: 0x18102D8C0
	public Vector4 get_curve() { }

	// RVA: 0x102DB10 Offset: 0x102C110 VA: 0x18102DB10
	public Vector4 get_toeSegmentA() { }

	// RVA: 0x102DB90 Offset: 0x102C190 VA: 0x18102DB90
	public Vector4 get_toeSegmentB() { }

	// RVA: 0x102D910 Offset: 0x102BF10 VA: 0x18102D910
	public Vector4 get_midSegmentA() { }

	// RVA: 0x102D990 Offset: 0x102BF90 VA: 0x18102D990
	public Vector4 get_midSegmentB() { }

	// RVA: 0x102DA10 Offset: 0x102C010 VA: 0x18102DA10
	public Vector4 get_shoSegmentA() { }

	// RVA: 0x102DA90 Offset: 0x102C090 VA: 0x18102DA90
	public Vector4 get_shoSegmentB() { }

}

