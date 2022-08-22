public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 443
{	// Fields
	private string strDefault; // 0x20
	private int fallbackCount; // 0x28
	private int fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x18ACFF0 Offset: 0x18AB5F0 VA: 0x1818ACFF0
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x18ACF30 Offset: 0x18AB530 VA: 0x1818ACF30 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x18ACF80 Offset: 0x18AB580 VA: 0x1818ACF80 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x18AD040 Offset: 0x18AB640 VA: 0x1818AD040 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x18ACFD0 Offset: 0x18AB5D0 VA: 0x1818ACFD0 Slot: 7
	public override void Reset() { }

	// RVA: 0xD4CE70 Offset: 0xD4B470 VA: 0x180D4CE70 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

