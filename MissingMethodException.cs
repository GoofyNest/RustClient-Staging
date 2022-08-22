public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 272
{	// Fields
	private string signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1676740 Offset: 0x1674D40 VA: 0x181676740
	public void .ctor() { }

	// RVA: 0x16767C0 Offset: 0x1674DC0 VA: 0x1816767C0
	public void .ctor(string message) { }

	// RVA: 0x1675F90 Offset: 0x1674590 VA: 0x181675F90
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1676810 Offset: 0x1674E10 VA: 0x181676810 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1676000 Offset: 0x1674600 VA: 0x181676000
	public void .ctor(string className, string methodName) { }

	// RVA: 0x16766A0 Offset: 0x1674CA0 VA: 0x1816766A0
	private void .ctor(string className, string methodName, string signature, string message) { }

}

