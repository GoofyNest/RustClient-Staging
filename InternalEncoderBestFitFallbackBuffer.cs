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

	// RVA: 0x191C700 Offset: 0x191AD00 VA: 0x18191C700
	private static object get_InternalSyncObject() { }

	// RVA: 0x191C550 Offset: 0x191AB50 VA: 0x18191C550
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x191C030 Offset: 0x191A630 VA: 0x18191C030 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x191C170 Offset: 0x191A770 VA: 0x18191C170 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191C3E0 Offset: 0x191A9E0 VA: 0x18191C3E0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x191C400 Offset: 0x191AA00 VA: 0x18191C400 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x191C790 Offset: 0x191AD90 VA: 0x18191C790 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x191C420 Offset: 0x191AA20 VA: 0x18191C420 Slot: 9
	public override void Reset() { }

	// RVA: 0x191C440 Offset: 0x191AA40 VA: 0x18191C440
	private char TryBestFit(char cUnknown) { }

}

