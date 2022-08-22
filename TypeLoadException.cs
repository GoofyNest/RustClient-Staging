public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 325
{	// Fields
	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x213E7A0 Offset: 0x213CDA0 VA: 0x18213E7A0
	public void .ctor() { }

	// RVA: 0x213E770 Offset: 0x213CD70 VA: 0x18213E770
	public void .ctor(string message) { }

	// RVA: 0x213E800 Offset: 0x213CE00 VA: 0x18213E800 Slot: 5
	public override string get_Message() { }

	// RVA: 0x213E3B0 Offset: 0x213C9B0 VA: 0x18213E3B0
	private void SetMessageField() { }

	// RVA: 0x213E520 Offset: 0x213CB20 VA: 0x18213E520
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x213E5B0 Offset: 0x213CBB0 VA: 0x18213E5B0
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x213E650 Offset: 0x213CC50 VA: 0x18213E650
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213E230 Offset: 0x213C830 VA: 0x18213E230 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

