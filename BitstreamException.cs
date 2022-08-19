public class BitstreamException : MP3SharpException // TypeDefIndex: 7385
{	// Fields
	private int _ErrorCode; // 0x88

	// Properties
	internal virtual int ErrorCode { get; }

	// Methods

	// RVA: 0x5DAC00 Offset: 0x5D9200 VA: 0x1805DAC00
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x5DACC0 Offset: 0x5D92C0 VA: 0x1805DACC0
	internal void .ctor(int errorcode, Exception inner) { }

	// RVA: 0x5DAC30 Offset: 0x5D9230 VA: 0x1805DAC30
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70 Slot: 12
	internal virtual int get_ErrorCode() { }

	// RVA: 0x5DAB40 Offset: 0x5D9140 VA: 0x1805DAB40 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5DABF0 Offset: 0x5D91F0 VA: 0x1805DABF0
	private void InitBlock() { }

	// RVA: 0x5DAAD0 Offset: 0x5D90D0 VA: 0x1805DAAD0
	internal static string GetErrorString(int errorcode) { }

}

