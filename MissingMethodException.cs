public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 272
{	// Fields
	private string signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1674330 Offset: 0x1672930 VA: 0x181674330
	public void .ctor() { }

	// RVA: 0x16743B0 Offset: 0x16729B0 VA: 0x1816743B0
	public void .ctor(string message) { }

	// RVA: 0x1673B80 Offset: 0x1672180 VA: 0x181673B80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1674400 Offset: 0x1672A00 VA: 0x181674400 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1673BF0 Offset: 0x16721F0 VA: 0x181673BF0
	public void .ctor(string className, string methodName) { }

	// RVA: 0x1674290 Offset: 0x1672890 VA: 0x181674290
	private void .ctor(string className, string methodName, string signature, string message) { }

}

