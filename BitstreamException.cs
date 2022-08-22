public class BitstreamException : MP3SharpException // TypeDefIndex: 7385
{	// Fields
	private int _ErrorCode; // 0x88

	// Properties
	internal virtual int ErrorCode { get; }

	// Methods

	// RVA: 0x5DAB90 Offset: 0x5D9190 VA: 0x1805DAB90
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x5DAC50 Offset: 0x5D9250 VA: 0x1805DAC50
	internal void .ctor(int errorcode, Exception inner) { }

	// RVA: 0x5DABC0 Offset: 0x5D91C0 VA: 0x1805DABC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00 Slot: 12
	internal virtual int get_ErrorCode() { }

	// RVA: 0x5DAAD0 Offset: 0x5D90D0 VA: 0x1805DAAD0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DAB80 Offset: 0x5D9180 VA: 0x1805DAB80
	private void InitBlock() { }

	// RVA: 0x5DAA60 Offset: 0x5D9060 VA: 0x1805DAA60
	internal static string GetErrorString(int errorcode) { }

}

