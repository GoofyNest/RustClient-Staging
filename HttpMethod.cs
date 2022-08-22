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

	// RVA: 0x108FBC0 Offset: 0x108E1C0 VA: 0x18108FBC0
	public void .ctor(string method) { }

	// RVA: 0x108FC60 Offset: 0x108E260 VA: 0x18108FC60
	public static HttpMethod get_Get() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Method() { }

	// RVA: 0x108FCC0 Offset: 0x108E2C0 VA: 0x18108FCC0
	public static HttpMethod get_Post() { }

	// RVA: 0x108FD20 Offset: 0x108E320 VA: 0x18108FD20
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	// RVA: 0x108F910 Offset: 0x108DF10 VA: 0x18108F910 Slot: 4
	public bool Equals(HttpMethod other) { }

	// RVA: 0x108F940 Offset: 0x108DF40 VA: 0x18108F940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2D10 Offset: 0xDE1310 VA: 0x180DE2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 3
	public override string ToString() { }

	// RVA: 0x108F9E0 Offset: 0x108DFE0 VA: 0x18108F9E0
	private static void .cctor() { }

}

