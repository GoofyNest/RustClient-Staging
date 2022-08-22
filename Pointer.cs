public sealed class Pointer : ISerializable // TypeDefIndex: 546
{	// Fields
	private void* _ptr; // 0x10
	private RuntimeType _ptrType; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x18D4010 Offset: 0x18D2610 VA: 0x1818D4010
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D3D90 Offset: 0x18D2390 VA: 0x1818D3D90
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x18D3F80 Offset: 0x18D2580 VA: 0x1818D3F80 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class PointER // TypeDefIndex: 6874
{	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x2317C80 Offset: 0x2316280 VA: 0x182317C80
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2317BE0 Offset: 0x23161E0 VA: 0x182317BE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2317B20 Offset: 0x2316120 VA: 0x182317B20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2317CD0 Offset: 0x23162D0 VA: 0x182317CD0
	public static bool op_Equality(PointER left, PointER right) { }

}

