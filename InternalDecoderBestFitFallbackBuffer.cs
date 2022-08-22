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

	// RVA: 0x191BE20 Offset: 0x191A420 VA: 0x18191BE20
	private static object get_InternalSyncObject() { }

	// RVA: 0x191BC70 Offset: 0x191A270 VA: 0x18191BC70
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x191B9F0 Offset: 0x1919FF0 VA: 0x18191B9F0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x191BA40 Offset: 0x191A040 VA: 0x18191BA40 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1912840 Offset: 0x1910E40 VA: 0x181912840 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1912820 Offset: 0x1910E20 VA: 0x181912820 Slot: 7
	public override void Reset() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x191BA60 Offset: 0x191A060 VA: 0x18191BA60
	private char TryBestFit(byte[] bytesCheck) { }

}

