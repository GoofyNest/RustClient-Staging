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

	// RVA: 0x218DC0 Offset: 0x2181C0 VA: 0x180218DC0
	public Vector3 get_position() { }

	// RVA: 0x218E30 Offset: 0x218230 VA: 0x180218E30
	public Quaternion get_rotation() { }

	// RVA: 0x218E90 Offset: 0x218290 VA: 0x180218E90
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x218EE0 Offset: 0x2182E0 VA: 0x180218EE0
	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0xD8DF0 Offset: 0xD81F0 VA: 0x1800D8DF0
	// RVA: 0x1900AE0 Offset: 0x18FF0E0 VA: 0x181900AE0
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD8F30 Offset: 0xD8330 VA: 0x1800D8F30
	// RVA: 0x1900B30 Offset: 0x18FF130 VA: 0x181900B30
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD8FD0 Offset: 0xD83D0 VA: 0x1800D8FD0
	// RVA: 0x1900B80 Offset: 0x18FF180 VA: 0x181900B80
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD9230 Offset: 0xD8630 VA: 0x1800D9230
	// RVA: 0x1900BD0 Offset: 0x18FF1D0 VA: 0x181900BD0
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

