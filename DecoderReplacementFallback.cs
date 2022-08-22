public sealed class DecoderReplacementFallback : DecoderFallback // TypeDefIndex: 442
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x18AD160 Offset: 0x18AB760 VA: 0x1818AD160
	public void .ctor() { }

	// RVA: 0x18AD1A0 Offset: 0x18AB7A0 VA: 0x1818AD1A0
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x18AD050 Offset: 0x18AB650 VA: 0x1818AD050 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18AD350 Offset: 0x18AB950 VA: 0x1818AD350 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18AD0D0 Offset: 0x18AB6D0 VA: 0x1818AD0D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE5A70 Offset: 0xAE4070 VA: 0x180AE5A70 Slot: 2
	public override int GetHashCode() { }

}

