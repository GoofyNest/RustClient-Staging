public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 548
{	// Fields
	private Type[] _classes; // 0x88
	private Exception[] _exceptions; // 0x90

	// Properties
	public Type[] Types { get; }

	// Methods

	// RVA: 0x18D5350 Offset: 0x18D3950 VA: 0x1818D5350
	private void .ctor() { }

	// RVA: 0x18D53B0 Offset: 0x18D39B0 VA: 0x1818D53B0
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x18D5420 Offset: 0x18D3A20 VA: 0x1818D5420
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public Type[] get_Types() { }

	// RVA: 0x18D5220 Offset: 0x18D3820 VA: 0x1818D5220 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

