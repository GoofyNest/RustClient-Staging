public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 271
{	// Fields
	protected string ClassName; // 0x88
	protected string MemberName; // 0x90
	protected byte[] Signature; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1676350 Offset: 0x1674950 VA: 0x181676350
	public void .ctor() { }

	// RVA: 0x16763C0 Offset: 0x16749C0 VA: 0x1816763C0
	public void .ctor(string message) { }

	// RVA: 0x1676400 Offset: 0x1674A00 VA: 0x181676400
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1676540 Offset: 0x1674B40 VA: 0x181676540 Slot: 5
	public override string get_Message() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	internal static string FormatSignature(byte[] signature) { }

	// RVA: 0x16761F0 Offset: 0x16747F0 VA: 0x1816761F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

