public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 325
{	// Fields
	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x213DF80 Offset: 0x213C580 VA: 0x18213DF80
	public void .ctor() { }

	// RVA: 0x213DF50 Offset: 0x213C550 VA: 0x18213DF50
	public void .ctor(string message) { }

	// RVA: 0x213DFE0 Offset: 0x213C5E0 VA: 0x18213DFE0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x213DB90 Offset: 0x213C190 VA: 0x18213DB90
	private void SetMessageField() { }

	// RVA: 0x213DD00 Offset: 0x213C300 VA: 0x18213DD00
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x213DD90 Offset: 0x213C390 VA: 0x18213DD90
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x213DE30 Offset: 0x213C430 VA: 0x18213DE30
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213DA10 Offset: 0x213C010 VA: 0x18213DA10 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

