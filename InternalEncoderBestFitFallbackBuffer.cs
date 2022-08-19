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

	// RVA: 0x191C480 Offset: 0x191AA80 VA: 0x18191C480
	private static object get_InternalSyncObject() { }

	// RVA: 0x191C2D0 Offset: 0x191A8D0 VA: 0x18191C2D0
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x191BDB0 Offset: 0x191A3B0 VA: 0x18191BDB0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x191BEF0 Offset: 0x191A4F0 VA: 0x18191BEF0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191C160 Offset: 0x191A760 VA: 0x18191C160 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x191C180 Offset: 0x191A780 VA: 0x18191C180 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x191C510 Offset: 0x191AB10 VA: 0x18191C510 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x191C1A0 Offset: 0x191A7A0 VA: 0x18191C1A0 Slot: 9
	public override void Reset() { }

	// RVA: 0x191C1C0 Offset: 0x191A7C0 VA: 0x18191C1C0
	private char TryBestFit(char cUnknown) { }

}

