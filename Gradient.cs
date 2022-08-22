public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xA9C40 Offset: 0xA9040 VA: 0x1800A9C40
	// RVA: 0x182C9D0 Offset: 0x182AFD0 VA: 0x18182C9D0
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9D30 Offset: 0xA9130 VA: 0x1800A9D30
	// RVA: 0x182C600 Offset: 0x182AC00 VA: 0x18182C600
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9DA0 Offset: 0xA91A0 VA: 0x1800A9DA0
	// RVA: 0x182CA00 Offset: 0x182B000 VA: 0x18182CA00
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182CAB0 Offset: 0x182B0B0 VA: 0x18182CAB0
	public void .ctor() { }

	// RVA: 0x182C920 Offset: 0x182AF20 VA: 0x18182C920 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9EA0 Offset: 0xA92A0 VA: 0x1800A9EA0
	// RVA: 0x182C8C0 Offset: 0x182AEC0 VA: 0x18182C8C0
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9F10 Offset: 0xA9310 VA: 0x1800A9F10
	// RVA: 0x182CB30 Offset: 0x182B130 VA: 0x18182CB30
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA000 Offset: 0xA9400 VA: 0x1800AA000
	// RVA: 0x182CAF0 Offset: 0x182B0F0 VA: 0x18182CAF0
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA0E0 Offset: 0xA94E0 VA: 0x1800AA0E0
	// RVA: 0x182CA50 Offset: 0x182B050 VA: 0x18182CA50
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	// RVA: 0x182C640 Offset: 0x182AC40 VA: 0x18182C640 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x182C7A0 Offset: 0x182ADA0 VA: 0x18182C7A0 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x181C850 Offset: 0x181AE50 VA: 0x18181C850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x182C860 Offset: 0x182AE60 VA: 0x18182C860
	private void Evaluate_Injected(float time, out Color ret) { }

}

