internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 446
{	// Fields
	private char cBestFit; // 0x30
	private InternalEncoderBestFitFallback oFallback; // 0x38
	private int iCount; // 0x40
	private int iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191BE20 Offset: 0x191A420 VA: 0x18191BE20
	private static object get_InternalSyncObject() { }

	// RVA: 0x191BC70 Offset: 0x191A270 VA: 0x18191BC70
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x191B750 Offset: 0x1919D50 VA: 0x18191B750 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x191B890 Offset: 0x1919E90 VA: 0x18191B890 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191BB00 Offset: 0x191A100 VA: 0x18191BB00 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x191BB20 Offset: 0x191A120 VA: 0x18191BB20 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x191BEB0 Offset: 0x191A4B0 VA: 0x18191BEB0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x191BB40 Offset: 0x191A140 VA: 0x18191BB40 Slot: 9
	public override void Reset() { }

	// RVA: 0x191BB60 Offset: 0x191A160 VA: 0x18191BB60
	private char TryBestFit(char cUnknown) { }

}

