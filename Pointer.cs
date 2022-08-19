public sealed class Pointer : ISerializable // TypeDefIndex: 546
{	// Fields
	private void* _ptr; // 0x10
	private RuntimeType _ptrType; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x18D4050 Offset: 0x18D2650 VA: 0x1818D4050
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D3DD0 Offset: 0x18D23D0 VA: 0x1818D3DD0
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x18D3FC0 Offset: 0x18D25C0 VA: 0x1818D3FC0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class PointER // TypeDefIndex: 6874
{	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x2317E40 Offset: 0x2316440 VA: 0x182317E40
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2317DA0 Offset: 0x23163A0 VA: 0x182317DA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2317CE0 Offset: 0x23162E0 VA: 0x182317CE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2317E90 Offset: 0x2316490 VA: 0x182317E90
	public static bool op_Equality(PointER left, PointER right) { }

}

