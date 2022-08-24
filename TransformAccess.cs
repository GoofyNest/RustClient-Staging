public struct TransformAccess // TypeDefIndex: 3589
{	private IntPtr hierarchy; // 0x0
	private int index; // 0x8

	public Vector3 position { get; }
	public Quaternion rotation { get; }
	public Vector3 localPosition { set; }
	public Quaternion localRotation { set; }


	public Vector3 get_position() { }

	public Quaternion get_rotation() { }

	public void set_localPosition(Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	[NativeMethodAttribute] // RVA: 0xD8F20 Offset: 0xD8320 VA: 0x1800D8F20
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD9100 Offset: 0xD8500 VA: 0x1800D9100
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD9360 Offset: 0xD8760 VA: 0x1800D9360
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

