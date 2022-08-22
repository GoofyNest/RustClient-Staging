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

	[NativeMethodAttribute] // RVA: 0xD8DF0 Offset: 0xD81F0 VA: 0x1800D8DF0
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD8F30 Offset: 0xD8330 VA: 0x1800D8F30
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD8FD0 Offset: 0xD83D0 VA: 0x1800D8FD0
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD9230 Offset: 0xD8630 VA: 0x1800D9230
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

