public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 2812
{	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x1190750 Offset: 0x118ED50 VA: 0x181190750
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x11904F0 Offset: 0x118EAF0 VA: 0x1811904F0
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1190680 Offset: 0x118EC80 VA: 0x181190680 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x11906F0 Offset: 0x118ECF0 VA: 0x1811906F0
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1190420 Offset: 0x118EA20 VA: 0x181190420
	private void DecodeRawData() { }

	// RVA: 0x11901A0 Offset: 0x118E7A0 VA: 0x1811901A0
	private static string Canonize(string s) { }

	// RVA: 0x118FF30 Offset: 0x118E530 VA: 0x18118FF30
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

