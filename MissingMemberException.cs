public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 271
{	// Fields
	protected string ClassName; // 0x88
	protected string MemberName; // 0x90
	protected byte[] Signature; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1676090 Offset: 0x1674690 VA: 0x181676090
	public void .ctor() { }

	// RVA: 0x1676100 Offset: 0x1674700 VA: 0x181676100
	public void .ctor(string message) { }

	// RVA: 0x1676140 Offset: 0x1674740 VA: 0x181676140
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1676280 Offset: 0x1674880 VA: 0x181676280 Slot: 5
	public override string get_Message() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	internal static string FormatSignature(byte[] signature) { }

	// RVA: 0x1675F30 Offset: 0x1674530 VA: 0x181675F30 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

