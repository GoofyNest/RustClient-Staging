public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 2812
{	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x1195070 Offset: 0x1193670 VA: 0x181195070
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x1194E10 Offset: 0x1193410 VA: 0x181194E10
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1194FA0 Offset: 0x11935A0 VA: 0x181194FA0 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x1195010 Offset: 0x1193610 VA: 0x181195010
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1194D40 Offset: 0x1193340 VA: 0x181194D40
	private void DecodeRawData() { }

	// RVA: 0x1194AC0 Offset: 0x11930C0 VA: 0x181194AC0
	private static string Canonize(string s) { }

	// RVA: 0x1194850 Offset: 0x1192E50 VA: 0x181194850
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

