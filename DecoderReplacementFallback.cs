public sealed class DecoderReplacementFallback : DecoderFallback // TypeDefIndex: 442
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x18AD1A0 Offset: 0x18AB7A0 VA: 0x1818AD1A0
	public void .ctor() { }

	// RVA: 0x18AD1E0 Offset: 0x18AB7E0 VA: 0x1818AD1E0
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x18AD090 Offset: 0x18AB690 VA: 0x1818AD090 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18AD390 Offset: 0x18AB990 VA: 0x1818AD390 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18AD110 Offset: 0x18AB710 VA: 0x1818AD110 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE5A70 Offset: 0xAE4070 VA: 0x180AE5A70 Slot: 2
	public override int GetHashCode() { }

}

