public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	internal IntPtr m_Ptr; // 0x10

	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }


	[FreeFunctionAttribute] // RVA: 0xA9D90 Offset: 0xA9190 VA: 0x1800A9D90
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9E20 Offset: 0xA9220 VA: 0x1800A9E20
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9E60 Offset: 0xA9260 VA: 0x1800A9E60
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9F00 Offset: 0xA9300 VA: 0x1800A9F00
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9FA0 Offset: 0xA93A0 VA: 0x1800A9FA0
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA080 Offset: 0xA9480 VA: 0x1800AA080
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA110 Offset: 0xA9510 VA: 0x1800AA110
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	public override bool Equals(object o) { }

	public bool Equals(Gradient other) { }

	public override int GetHashCode() { }

	private void Evaluate_Injected(float time, out Color ret) { }

}

