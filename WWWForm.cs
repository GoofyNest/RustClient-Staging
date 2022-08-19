public class WWWForm // TypeDefIndex: 4125
{	// Fields
	private List<byte[]> formData; // 0x10
	private List<string> fieldNames; // 0x18
	private List<string> fileNames; // 0x20
	private List<string> types; // 0x28
	private byte[] boundary; // 0x30
	private bool containsFiles; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }
	public Dictionary<string, string> headers { get; }
	public byte[] data { get; }

	// Methods

	// RVA: 0x22A2360 Offset: 0x22A0960 VA: 0x1822A2360
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x22A21F0 Offset: 0x22A07F0 VA: 0x1822A21F0
	public void .ctor() { }

	// RVA: 0x22A20D0 Offset: 0x22A06D0 VA: 0x1822A20D0
	public void AddField(string fieldName, string value) { }

	// RVA: 0x22A1FC0 Offset: 0x22A05C0 VA: 0x1822A1FC0
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x22A33D0 Offset: 0x22A19D0 VA: 0x1822A33D0
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x22A2370 Offset: 0x22A0970 VA: 0x1822A2370
	public byte[] get_data() { }

}

