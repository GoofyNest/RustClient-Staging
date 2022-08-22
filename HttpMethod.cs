public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 5752
{	// Fields
	private static readonly HttpMethod delete_method; // 0x0
	private static readonly HttpMethod get_method; // 0x8
	private static readonly HttpMethod head_method; // 0x10
	private static readonly HttpMethod options_method; // 0x18
	private static readonly HttpMethod post_method; // 0x20
	private static readonly HttpMethod put_method; // 0x28
	private static readonly HttpMethod trace_method; // 0x30
	private readonly string method; // 0x10

	// Properties
	public static HttpMethod Get { get; }
	public string Method { get; }
	public static HttpMethod Post { get; }

	// Methods

	// RVA: 0x108F150 Offset: 0x108D750 VA: 0x18108F150
	public void .ctor(string method) { }

	// RVA: 0x108F1F0 Offset: 0x108D7F0 VA: 0x18108F1F0
	public static HttpMethod get_Get() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Method() { }

	// RVA: 0x108F250 Offset: 0x108D850 VA: 0x18108F250
	public static HttpMethod get_Post() { }

	// RVA: 0x108F2B0 Offset: 0x108D8B0 VA: 0x18108F2B0
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	// RVA: 0x108EEA0 Offset: 0x108D4A0 VA: 0x18108EEA0 Slot: 4
	public bool Equals(HttpMethod other) { }

	// RVA: 0x108EED0 Offset: 0x108D4D0 VA: 0x18108EED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x108EF70 Offset: 0x108D570 VA: 0x18108EF70
	private static void .cctor() { }

}

