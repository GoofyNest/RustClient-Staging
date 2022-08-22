public struct TransformAccess // TypeDefIndex: 3589
{	// Fields
	private IntPtr hierarchy; // 0x0
	private int index; // 0x8

	// Properties
	public Vector3 position { get; }
	public Quaternion rotation { get; }
	public Vector3 localPosition { set; }
	public Quaternion localRotation { set; }

	// Methods

	// RVA: 0x2186F0 Offset: 0x217AF0 VA: 0x1802186F0
	public Vector3 get_position() { }

	// RVA: 0x218760 Offset: 0x217B60 VA: 0x180218760
	public Quaternion get_rotation() { }

	// RVA: 0x2187C0 Offset: 0x217BC0 VA: 0x1802187C0
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x218810 Offset: 0x217C10 VA: 0x180218810
	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0xD8DF0 Offset: 0xD81F0 VA: 0x1800D8DF0
	// RVA: 0x19013C0 Offset: 0x18FF9C0 VA: 0x1819013C0
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD8F30 Offset: 0xD8330 VA: 0x1800D8F30
	// RVA: 0x1901410 Offset: 0x18FFA10 VA: 0x181901410
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD8FD0 Offset: 0xD83D0 VA: 0x1800D8FD0
	// RVA: 0x1901460 Offset: 0x18FFA60 VA: 0x181901460
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD9230 Offset: 0xD8630 VA: 0x1800D9230
	// RVA: 0x19014B0 Offset: 0x18FFAB0 VA: 0x1819014B0
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

