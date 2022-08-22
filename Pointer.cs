public sealed class Pointer : ISerializable // TypeDefIndex: 546
{	// Fields
	private void* _ptr; // 0x10
	private RuntimeType _ptrType; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x18D39F0 Offset: 0x18D1FF0 VA: 0x1818D39F0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D3770 Offset: 0x18D1D70 VA: 0x1818D3770
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x18D3960 Offset: 0x18D1F60 VA: 0x1818D3960 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class PointER // TypeDefIndex: 6874
{	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x2318760 Offset: 0x2316D60 VA: 0x182318760
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x23186C0 Offset: 0x2316CC0 VA: 0x1823186C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2318600 Offset: 0x2316C00 VA: 0x182318600 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23187B0 Offset: 0x2316DB0 VA: 0x1823187B0
	public static bool op_Equality(PointER left, PointER right) { }

}

