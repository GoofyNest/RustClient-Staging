public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xA9BA0 Offset: 0xA8FA0 VA: 0x1800A9BA0
	// RVA: 0x182C750 Offset: 0x182AD50 VA: 0x18182C750
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9C90 Offset: 0xA9090 VA: 0x1800A9C90
	// RVA: 0x182C380 Offset: 0x182A980 VA: 0x18182C380
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9D00 Offset: 0xA9100 VA: 0x1800A9D00
	// RVA: 0x182C780 Offset: 0x182AD80 VA: 0x18182C780
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182C830 Offset: 0x182AE30 VA: 0x18182C830
	public void .ctor() { }

	// RVA: 0x182C6A0 Offset: 0x182ACA0 VA: 0x18182C6A0 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9E00 Offset: 0xA9200 VA: 0x1800A9E00
	// RVA: 0x182C640 Offset: 0x182AC40 VA: 0x18182C640
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9E40 Offset: 0xA9240 VA: 0x1800A9E40
	// RVA: 0x182C8B0 Offset: 0x182AEB0 VA: 0x18182C8B0
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xA9F60 Offset: 0xA9360 VA: 0x1800A9F60
	// RVA: 0x182C870 Offset: 0x182AE70 VA: 0x18182C870
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA020 Offset: 0xA9420 VA: 0x1800AA020
	// RVA: 0x182C7D0 Offset: 0x182ADD0 VA: 0x18182C7D0
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	// RVA: 0x182C3C0 Offset: 0x182A9C0 VA: 0x18182C3C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x182C520 Offset: 0x182AB20 VA: 0x18182C520 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x181C590 Offset: 0x181AB90 VA: 0x18181C590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x182C5E0 Offset: 0x182ABE0 VA: 0x18182C5E0
	private void Evaluate_Injected(float time, out Color ret) { }

}

