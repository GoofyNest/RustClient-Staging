public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 443
{	// Fields
	private string strDefault; // 0x20
	private int fallbackCount; // 0x28
	private int fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x18AC9D0 Offset: 0x18AAFD0 VA: 0x1818AC9D0
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x18AC910 Offset: 0x18AAF10 VA: 0x1818AC910 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x18AC960 Offset: 0x18AAF60 VA: 0x1818AC960 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x18ACA20 Offset: 0x18AB020 VA: 0x1818ACA20 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x18AC9B0 Offset: 0x18AAFB0 VA: 0x1818AC9B0 Slot: 7
	public override void Reset() { }

	// RVA: 0xD4D5D0 Offset: 0xD4BBD0 VA: 0x180D4D5D0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

