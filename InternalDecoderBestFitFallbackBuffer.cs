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

	// RVA: 0x191B540 Offset: 0x1919B40 VA: 0x18191B540
	private static object get_InternalSyncObject() { }

	// RVA: 0x191B390 Offset: 0x1919990 VA: 0x18191B390
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x191B110 Offset: 0x1919710 VA: 0x18191B110 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x191B160 Offset: 0x1919760 VA: 0x18191B160 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1911F60 Offset: 0x1910560 VA: 0x181911F60 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1911F40 Offset: 0x1910540 VA: 0x181911F40 Slot: 7
	public override void Reset() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x191B180 Offset: 0x1919780 VA: 0x18191B180
	private char TryBestFit(byte[] bytesCheck) { }

}

