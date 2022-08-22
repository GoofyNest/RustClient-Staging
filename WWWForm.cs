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

	// RVA: 0x22A2460 Offset: 0x22A0A60 VA: 0x1822A2460
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x22A22F0 Offset: 0x22A08F0 VA: 0x1822A22F0
	public void .ctor() { }

	// RVA: 0x22A21D0 Offset: 0x22A07D0 VA: 0x1822A21D0
	public void AddField(string fieldName, string value) { }

	// RVA: 0x22A20C0 Offset: 0x22A06C0 VA: 0x1822A20C0
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x22A34D0 Offset: 0x22A1AD0 VA: 0x1822A34D0
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x22A2470 Offset: 0x22A0A70 VA: 0x1822A2470
	public byte[] get_data() { }

}

