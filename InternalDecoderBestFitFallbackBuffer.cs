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

	// RVA: 0x191BB60 Offset: 0x191A160 VA: 0x18191BB60
	private static object get_InternalSyncObject() { }

	// RVA: 0x191B9B0 Offset: 0x1919FB0 VA: 0x18191B9B0
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x191B730 Offset: 0x1919D30 VA: 0x18191B730 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x191B780 Offset: 0x1919D80 VA: 0x18191B780 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1912580 Offset: 0x1910B80 VA: 0x181912580 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1912560 Offset: 0x1910B60 VA: 0x181912560 Slot: 7
	public override void Reset() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x191B7A0 Offset: 0x1919DA0 VA: 0x18191B7A0
	private char TryBestFit(byte[] bytesCheck) { }

}

