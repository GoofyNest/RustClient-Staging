internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 435
{	// Fields
	internal char cBestFit; // 0x20
	internal int iCount; // 0x24
	internal int iSize; // 0x28
	private InternalDecoderBestFitFallback oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191BBA0 Offset: 0x191A1A0 VA: 0x18191BBA0
	private static object get_InternalSyncObject() { }

	// RVA: 0x191B9F0 Offset: 0x1919FF0 VA: 0x18191B9F0
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x191B770 Offset: 0x1919D70 VA: 0x18191B770 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x191B7C0 Offset: 0x1919DC0 VA: 0x18191B7C0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x19125C0 Offset: 0x1910BC0 VA: 0x1819125C0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x19125A0 Offset: 0x1910BA0 VA: 0x1819125A0 Slot: 7
	public override void Reset() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x191B7E0 Offset: 0x1919DE0 VA: 0x18191B7E0
	private char TryBestFit(byte[] bytesCheck) { }

}

