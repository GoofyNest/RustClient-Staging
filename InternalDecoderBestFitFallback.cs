internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 434
{	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20
	internal char cReplacement; // 0x28

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191B710 Offset: 0x1919D10 VA: 0x18191B710
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191B5D0 Offset: 0x1919BD0 VA: 0x18191B5D0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191B630 Offset: 0x1919C30 VA: 0x18191B630 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191B6E0 Offset: 0x1919CE0 VA: 0x18191B6E0 Slot: 2
	public override int GetHashCode() { }

}

