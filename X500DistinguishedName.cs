public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 2812
{	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x1190490 Offset: 0x118EA90 VA: 0x181190490
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x1190230 Offset: 0x118E830 VA: 0x181190230
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x11903C0 Offset: 0x118E9C0 VA: 0x1811903C0 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x1190430 Offset: 0x118EA30 VA: 0x181190430
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1190160 Offset: 0x118E760 VA: 0x181190160
	private void DecodeRawData() { }

	// RVA: 0x118FEE0 Offset: 0x118E4E0 VA: 0x18118FEE0
	private static string Canonize(string s) { }

	// RVA: 0x118FC70 Offset: 0x118E270 VA: 0x18118FC70
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

