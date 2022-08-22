public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 325
{	// Fields
	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x213DCC0 Offset: 0x213C2C0 VA: 0x18213DCC0
	public void .ctor() { }

	// RVA: 0x213DC90 Offset: 0x213C290 VA: 0x18213DC90
	public void .ctor(string message) { }

	// RVA: 0x213DD20 Offset: 0x213C320 VA: 0x18213DD20 Slot: 5
	public override string get_Message() { }

	// RVA: 0x213D8D0 Offset: 0x213BED0 VA: 0x18213D8D0
	private void SetMessageField() { }

	// RVA: 0x213DA40 Offset: 0x213C040 VA: 0x18213DA40
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x213DAD0 Offset: 0x213C0D0 VA: 0x18213DAD0
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x213DB70 Offset: 0x213C170 VA: 0x18213DB70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213D750 Offset: 0x213BD50 VA: 0x18213D750 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

