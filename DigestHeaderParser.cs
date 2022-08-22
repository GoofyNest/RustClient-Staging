internal class DigestHeaderParser // TypeDefIndex: 2992
{
// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 2992
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x152CFB0 Offset: 0x152B5B0 VA: 0x18152CFB0
	public void .ctor(string header) { }

	// RVA: 0x152D170 Offset: 0x152B770 VA: 0x18152D170
	public string get_Realm() { }

	// RVA: 0x152D0F0 Offset: 0x152B6F0 VA: 0x18152D0F0
	public string get_Opaque() { }

	// RVA: 0x152D0B0 Offset: 0x152B6B0 VA: 0x18152D0B0
	public string get_Nonce() { }

	// RVA: 0x152D070 Offset: 0x152B670 VA: 0x18152D070
	public string get_Algorithm() { }

	// RVA: 0x152D130 Offset: 0x152B730 VA: 0x18152D130
	public string get_QOP() { }

	// RVA: 0x152CAA0 Offset: 0x152B0A0 VA: 0x18152CAA0
	public bool Parse() { }

	// RVA: 0x152CCE0 Offset: 0x152B2E0 VA: 0x18152CCE0
	private void SkipWhitespace() { }

	// RVA: 0x152C7B0 Offset: 0x152ADB0 VA: 0x18152C7B0
	private string GetKey() { }

	// RVA: 0x152C840 Offset: 0x152AE40 VA: 0x18152C840
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x152CD50 Offset: 0x152B350 VA: 0x18152CD50
	private static void .cctor() { }

}

