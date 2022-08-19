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

	// RVA: 0x108EE90 Offset: 0x108D490 VA: 0x18108EE90
	public void .ctor(string method) { }

	// RVA: 0x108EF30 Offset: 0x108D530 VA: 0x18108EF30
	public static HttpMethod get_Get() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Method() { }

	// RVA: 0x108EF90 Offset: 0x108D590 VA: 0x18108EF90
	public static HttpMethod get_Post() { }

	// RVA: 0x108EFF0 Offset: 0x108D5F0 VA: 0x18108EFF0
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	// RVA: 0x108EBE0 Offset: 0x108D1E0 VA: 0x18108EBE0 Slot: 4
	public bool Equals(HttpMethod other) { }

	// RVA: 0x108EC10 Offset: 0x108D210 VA: 0x18108EC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x108ECB0 Offset: 0x108D2B0 VA: 0x18108ECB0
	private static void .cctor() { }

}

