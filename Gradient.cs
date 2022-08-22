public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	internal IntPtr m_Ptr; // 0x10

	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }


	[FreeFunctionAttribute] // RVA: 0xA9C40 Offset: 0xA9040 VA: 0x1800A9C40
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9D30 Offset: 0xA9130 VA: 0x1800A9D30
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9DA0 Offset: 0xA91A0 VA: 0x1800A9DA0
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9EA0 Offset: 0xA92A0 VA: 0x1800A9EA0
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9F10 Offset: 0xA9310 VA: 0x1800A9F10
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA000 Offset: 0xA9400 VA: 0x1800AA000
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA0E0 Offset: 0xA94E0 VA: 0x1800AA0E0
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	public override bool Equals(object o) { }

	public bool Equals(Gradient other) { }

	public override int GetHashCode() { }

	private void Evaluate_Injected(float time, out Color ret) { }

}

