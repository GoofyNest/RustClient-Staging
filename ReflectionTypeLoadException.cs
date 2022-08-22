public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 548
{	// Fields
	private Type[] _classes; // 0x88
	private Exception[] _exceptions; // 0x90

	// Properties
	public Type[] Types { get; }

	// Methods

	// RVA: 0x18D4A70 Offset: 0x18D3070 VA: 0x1818D4A70
	private void .ctor() { }

	// RVA: 0x18D4AD0 Offset: 0x18D30D0 VA: 0x1818D4AD0
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x18D4B40 Offset: 0x18D3140 VA: 0x1818D4B40
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public Type[] get_Types() { }

	// RVA: 0x18D4940 Offset: 0x18D2F40 VA: 0x1818D4940 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

