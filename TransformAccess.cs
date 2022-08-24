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

	[NativeMethodAttribute] // RVA: 0xD8E20 Offset: 0xD8220 VA: 0x1800D8E20
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD8F60 Offset: 0xD8360 VA: 0x1800D8F60
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethodAttribute] // RVA: 0xD9030 Offset: 0xD8430 VA: 0x1800D9030
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethodAttribute] // RVA: 0xD92C0 Offset: 0xD86C0 VA: 0x1800D92C0
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

