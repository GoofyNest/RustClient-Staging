public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 271
{	// Fields
	protected string ClassName; // 0x88
	protected string MemberName; // 0x90
	protected byte[] Signature; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1673F40 Offset: 0x1672540 VA: 0x181673F40
	public void .ctor() { }

	// RVA: 0x1673FB0 Offset: 0x16725B0 VA: 0x181673FB0
	public void .ctor(string message) { }

	// RVA: 0x1673FF0 Offset: 0x16725F0 VA: 0x181673FF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1674130 Offset: 0x1672730 VA: 0x181674130 Slot: 5
	public override string get_Message() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	internal static string FormatSignature(byte[] signature) { }

	// RVA: 0x1673DE0 Offset: 0x16723E0 VA: 0x181673DE0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

