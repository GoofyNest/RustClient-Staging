public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xA9C40 Offset: 0xA9040 VA: 0x1800A9C40
	// RVA: 0x182C710 Offset: 0x182AD10 VA: 0x18182C710
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9D30 Offset: 0xA9130 VA: 0x1800A9D30
	// RVA: 0x182C340 Offset: 0x182A940 VA: 0x18182C340
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9DA0 Offset: 0xA91A0 VA: 0x1800A9DA0
	// RVA: 0x182C740 Offset: 0x182AD40 VA: 0x18182C740
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182C7F0 Offset: 0x182ADF0 VA: 0x18182C7F0
	public void .ctor() { }

	// RVA: 0x182C660 Offset: 0x182AC60 VA: 0x18182C660 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9EA0 Offset: 0xA92A0 VA: 0x1800A9EA0
	// RVA: 0x182C600 Offset: 0x182AC00 VA: 0x18182C600
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9F10 Offset: 0xA9310 VA: 0x1800A9F10
	// RVA: 0x182C870 Offset: 0x182AE70 VA: 0x18182C870
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA000 Offset: 0xA9400 VA: 0x1800AA000
	// RVA: 0x182C830 Offset: 0x182AE30 VA: 0x18182C830
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA0E0 Offset: 0xA94E0 VA: 0x1800AA0E0
	// RVA: 0x182C790 Offset: 0x182AD90 VA: 0x18182C790
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	// RVA: 0x182C380 Offset: 0x182A980 VA: 0x18182C380 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x182C4E0 Offset: 0x182AAE0 VA: 0x18182C4E0 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x181C590 Offset: 0x181AB90 VA: 0x18181C590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x182C5A0 Offset: 0x182ABA0 VA: 0x18182C5A0
	private void Evaluate_Injected(float time, out Color ret) { }

}

