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

	// RVA: 0x218770 Offset: 0x217B70 VA: 0x180218770
	public Vector3 get_position() { }

	// RVA: 0x2187E0 Offset: 0x217BE0 VA: 0x1802187E0
	public Quaternion get_rotation() { }

	// RVA: 0x218840 Offset: 0x217C40 VA: 0x180218840
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x218890 Offset: 0x217C90 VA: 0x180218890
	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0xD8D80 Offset: 0xD8180 VA: 0x1800D8D80
	// RVA: 0x1901140 Offset: 0x18FF740 VA: 0x181901140
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD8EC0 Offset: 0xD82C0 VA: 0x1800D8EC0
	// RVA: 0x1901190 Offset: 0x18FF790 VA: 0x181901190
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD8F30 Offset: 0xD8330 VA: 0x1800D8F30
	// RVA: 0x19011E0 Offset: 0x18FF7E0 VA: 0x1819011E0
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD91F0 Offset: 0xD85F0 VA: 0x1800D91F0
	// RVA: 0x1901230 Offset: 0x18FF830 VA: 0x181901230
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

