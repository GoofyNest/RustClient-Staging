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

	// RVA: 0x22A21A0 Offset: 0x22A07A0 VA: 0x1822A21A0
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x22A2030 Offset: 0x22A0630 VA: 0x1822A2030
	public void .ctor() { }

	// RVA: 0x22A1F10 Offset: 0x22A0510 VA: 0x1822A1F10
	public void AddField(string fieldName, string value) { }

	// RVA: 0x22A1E00 Offset: 0x22A0400 VA: 0x1822A1E00
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x22A3210 Offset: 0x22A1810 VA: 0x1822A3210
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x22A21B0 Offset: 0x22A07B0 VA: 0x1822A21B0
	public byte[] get_data() { }

}

