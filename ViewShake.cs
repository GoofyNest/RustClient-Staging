public class ViewShake // TypeDefIndex: 9252
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <PositionOffset>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <AnglesOffset>k__BackingField; // 0x1C
	protected List<ViewShake.ShakeParameters> Entries; // 0x28

	// Properties
	public Vector3 PositionOffset { get; set; }
	public Vector3 AnglesOffset { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F6010 Offset: 0x7F4610 VA: 0x1807F6010
	public Vector3 get_PositionOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F6040 Offset: 0x7F4640 VA: 0x1807F6040
	protected void set_PositionOffset(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F5FF0 Offset: 0x7F45F0 VA: 0x1807F5FF0
	public Vector3 get_AnglesOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F6030 Offset: 0x7F4630 VA: 0x1807F6030
	protected void set_AnglesOffset(Vector3 value) { }

	// RVA: 0x7F5820 Offset: 0x7F3E20 VA: 0x1807F5820
	public void AddShake(float amplitude, float frequency, float duration) { }

	// RVA: 0x7F59D0 Offset: 0x7F3FD0 VA: 0x1807F59D0
	public void Update() { }

	// RVA: 0x7F5930 Offset: 0x7F3F30 VA: 0x1807F5930
	public void Stop() { }

	// RVA: 0x7F5F80 Offset: 0x7F4580 VA: 0x1807F5F80
	public void .ctor() { }

}

private sealed class ViewShake.<>c // TypeDefIndex: 9254
{	// Fields
	public static readonly ViewShake.<>c <>9; // 0x0
	public static Predicate<ViewShake.ShakeParameters> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x7EFFA0 Offset: 0x7EE5A0 VA: 0x1807EFFA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EFF20 Offset: 0x7EE520 VA: 0x1807EFF20
	internal bool <Update>b__11_0(ViewShake.ShakeParameters i) { }

}

