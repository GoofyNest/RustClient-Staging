public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	internal IntPtr m_Ptr; // 0x10

	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }


	[FreeFunctionAttribute] // RVA: 0xA9CD0 Offset: 0xA90D0 VA: 0x1800A9CD0
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9DD0 Offset: 0xA91D0 VA: 0x1800A9DD0
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9E80 Offset: 0xA9280 VA: 0x1800A9E80
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9FB0 Offset: 0xA93B0 VA: 0x1800A9FB0
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xAA020 Offset: 0xA9420 VA: 0x1800AA020
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA110 Offset: 0xA9510 VA: 0x1800AA110
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA1F0 Offset: 0xA95F0 VA: 0x1800AA1F0
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	public override bool Equals(object o) { }

	public bool Equals(Gradient other) { }

	public override int GetHashCode() { }

	private void Evaluate_Injected(float time, out Color ret) { }

}

