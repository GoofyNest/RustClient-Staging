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

	// RVA: 0x22A2C80 Offset: 0x22A1280 VA: 0x1822A2C80
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x22A2B10 Offset: 0x22A1110 VA: 0x1822A2B10
	public void .ctor() { }

	// RVA: 0x22A29F0 Offset: 0x22A0FF0 VA: 0x1822A29F0
	public void AddField(string fieldName, string value) { }

	// RVA: 0x22A28E0 Offset: 0x22A0EE0 VA: 0x1822A28E0
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x22A3CF0 Offset: 0x22A22F0 VA: 0x1822A3CF0
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x22A2C90 Offset: 0x22A1290 VA: 0x1822A2C90
	public byte[] get_data() { }

}

