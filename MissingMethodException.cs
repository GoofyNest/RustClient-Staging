public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 272
{	// Fields
	private string signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1676480 Offset: 0x1674A80 VA: 0x181676480
	public void .ctor() { }

	// RVA: 0x1676500 Offset: 0x1674B00 VA: 0x181676500
	public void .ctor(string message) { }

	// RVA: 0x1675CD0 Offset: 0x16742D0 VA: 0x181675CD0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1676550 Offset: 0x1674B50 VA: 0x181676550 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1675D40 Offset: 0x1674340 VA: 0x181675D40
	public void .ctor(string className, string methodName) { }

	// RVA: 0x16763E0 Offset: 0x16749E0 VA: 0x1816763E0
	private void .ctor(string className, string methodName, string signature, string message) { }

}

