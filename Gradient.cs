public class Gradient : IEquatable<Gradient> // TypeDefIndex: 3464
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; }
	public GradientAlphaKey[] alphaKeys { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xA9C40 Offset: 0xA9040 VA: 0x1800A9C40
	// RVA: 0x1819E10 Offset: 0x1818410 VA: 0x181819E10
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xA9D30 Offset: 0xA9130 VA: 0x1800A9D30
	// RVA: 0x1819A40 Offset: 0x1818040 VA: 0x181819A40
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xA9DA0 Offset: 0xA91A0 VA: 0x1800A9DA0
	// RVA: 0x1819E40 Offset: 0x1818440 VA: 0x181819E40
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1819EF0 Offset: 0x18184F0 VA: 0x181819EF0
	public void .ctor() { }

	// RVA: 0x1819D60 Offset: 0x1818360 VA: 0x181819D60 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xA9EA0 Offset: 0xA92A0 VA: 0x1800A9EA0
	// RVA: 0x1819D00 Offset: 0x1818300 VA: 0x181819D00
	public Color Evaluate(float time) { }

	[FreeFunctionAttribute] // RVA: 0xA9F10 Offset: 0xA9310 VA: 0x1800A9F10
	// RVA: 0x1819F70 Offset: 0x1818570 VA: 0x181819F70
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA000 Offset: 0xA9400 VA: 0x1800AA000
	// RVA: 0x1819F30 Offset: 0x1818530 VA: 0x181819F30
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xAA0E0 Offset: 0xA94E0 VA: 0x1800AA0E0
	// RVA: 0x1819E90 Offset: 0x1818490 VA: 0x181819E90
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	// RVA: 0x1819A80 Offset: 0x1818080 VA: 0x181819A80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1819BE0 Offset: 0x18181E0 VA: 0x181819BE0 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x1809C90 Offset: 0x1808290 VA: 0x181809C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1819CA0 Offset: 0x18182A0 VA: 0x181819CA0
	private void Evaluate_Injected(float time, out Color ret) { }

}

