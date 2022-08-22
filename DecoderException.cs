public class DecoderException : MP3SharpException // TypeDefIndex: 7390
{	// Fields
	private int _ErrorCode; // 0x88

	// Methods

	// RVA: 0x5DCCD0 Offset: 0x5DB2D0 VA: 0x1805DCCD0
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x5DCC30 Offset: 0x5DB230 VA: 0x1805DCC30
	internal void .ctor(int errorcode, Exception inner) { }

	// RVA: 0x5DCD00 Offset: 0x5DB300 VA: 0x1805DCD00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DCB70 Offset: 0x5DB170 VA: 0x1805DCB70 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DCC20 Offset: 0x5DB220 VA: 0x1805DCC20
	private void InitBlock() { }

	// RVA: 0x5DCB00 Offset: 0x5DB100 VA: 0x1805DCB00
	internal static string GetErrorString(int errorcode) { }

}

