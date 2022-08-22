public sealed class DecoderReplacementFallback : DecoderFallback // TypeDefIndex: 442
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x18AD420 Offset: 0x18ABA20 VA: 0x1818AD420
	public void .ctor() { }

	// RVA: 0x18AD460 Offset: 0x18ABA60 VA: 0x1818AD460
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x18AD310 Offset: 0x18AB910 VA: 0x1818AD310 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18AD610 Offset: 0x18ABC10 VA: 0x1818AD610 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18AD390 Offset: 0x18AB990 VA: 0x1818AD390 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE5D30 Offset: 0xAE4330 VA: 0x180AE5D30 Slot: 2
	public override int GetHashCode() { }

}

