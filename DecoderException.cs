public class DecoderException : MP3SharpException // TypeDefIndex: 7390
{	// Fields
	private int _ErrorCode; // 0x88

	// Methods

	// RVA: 0x5DCD40 Offset: 0x5DB340 VA: 0x1805DCD40
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x5DCCA0 Offset: 0x5DB2A0 VA: 0x1805DCCA0
	internal void .ctor(int errorcode, Exception inner) { }

	// RVA: 0x5DCD70 Offset: 0x5DB370 VA: 0x1805DCD70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DCBE0 Offset: 0x5DB1E0 VA: 0x1805DCBE0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DCC90 Offset: 0x5DB290 VA: 0x1805DCC90
	private void InitBlock() { }

	// RVA: 0x5DCB70 Offset: 0x5DB170 VA: 0x1805DCB70
	internal static string GetErrorString(int errorcode) { }

}

