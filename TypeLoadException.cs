public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 325
{	// Fields
	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x213DE80 Offset: 0x213C480 VA: 0x18213DE80
	public void .ctor() { }

	// RVA: 0x213DE50 Offset: 0x213C450 VA: 0x18213DE50
	public void .ctor(string message) { }

	// RVA: 0x213DEE0 Offset: 0x213C4E0 VA: 0x18213DEE0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x213DA90 Offset: 0x213C090 VA: 0x18213DA90
	private void SetMessageField() { }

	// RVA: 0x213DC00 Offset: 0x213C200 VA: 0x18213DC00
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x213DC90 Offset: 0x213C290 VA: 0x18213DC90
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x213DD30 Offset: 0x213C330 VA: 0x18213DD30
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213D910 Offset: 0x213BF10 VA: 0x18213D910 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

