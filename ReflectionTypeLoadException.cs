public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 548
{	// Fields
	private Type[] _classes; // 0x88
	private Exception[] _exceptions; // 0x90

	// Properties
	public Type[] Types { get; }

	// Methods

	// RVA: 0x18D50D0 Offset: 0x18D36D0 VA: 0x1818D50D0
	private void .ctor() { }

	// RVA: 0x18D5130 Offset: 0x18D3730 VA: 0x1818D5130
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x18D51A0 Offset: 0x18D37A0 VA: 0x1818D51A0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public Type[] get_Types() { }

	// RVA: 0x18D4FA0 Offset: 0x18D35A0 VA: 0x1818D4FA0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

