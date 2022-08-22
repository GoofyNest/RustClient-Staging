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

	// RVA: 0x191C440 Offset: 0x191AA40 VA: 0x18191C440
	private static object get_InternalSyncObject() { }

	// RVA: 0x191C290 Offset: 0x191A890 VA: 0x18191C290
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x191BD70 Offset: 0x191A370 VA: 0x18191BD70 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x191BEB0 Offset: 0x191A4B0 VA: 0x18191BEB0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191C120 Offset: 0x191A720 VA: 0x18191C120 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x191C140 Offset: 0x191A740 VA: 0x18191C140 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x191C4D0 Offset: 0x191AAD0 VA: 0x18191C4D0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x191C160 Offset: 0x191A760 VA: 0x18191C160 Slot: 9
	public override void Reset() { }

	// RVA: 0x191C180 Offset: 0x191A780 VA: 0x18191C180
	private char TryBestFit(char cUnknown) { }

}

