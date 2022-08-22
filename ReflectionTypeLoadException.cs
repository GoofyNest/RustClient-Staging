public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 548
{	// Fields
	private Type[] _classes; // 0x88
	private Exception[] _exceptions; // 0x90

	// Properties
	public Type[] Types { get; }

	// Methods

	// RVA: 0x18D5090 Offset: 0x18D3690 VA: 0x1818D5090
	private void .ctor() { }

	// RVA: 0x18D50F0 Offset: 0x18D36F0 VA: 0x1818D50F0
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x18D5160 Offset: 0x18D3760 VA: 0x1818D5160
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public Type[] get_Types() { }

	// RVA: 0x18D4F60 Offset: 0x18D3560 VA: 0x1818D4F60 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

