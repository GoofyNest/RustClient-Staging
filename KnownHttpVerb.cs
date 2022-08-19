internal class KnownHttpVerb // TypeDefIndex: 2892
{	// Fields
	internal string Name; // 0x10
	internal bool RequireContentBody; // 0x18
	internal bool ContentBodyNotAllowed; // 0x19
	internal bool ConnectRequest; // 0x1A
	internal bool ExpectNoContentResponse; // 0x1B
	private static ListDictionary NamedHeaders; // 0x0
	internal static KnownHttpVerb Get; // 0x8
	internal static KnownHttpVerb Connect; // 0x10
	internal static KnownHttpVerb Head; // 0x18
	internal static KnownHttpVerb Put; // 0x20
	internal static KnownHttpVerb Post; // 0x28
	internal static KnownHttpVerb MkCol; // 0x30

	// Methods

	// RVA: 0x13454A0 Offset: 0x1343AA0 VA: 0x1813454A0
	internal void .ctor(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	// RVA: 0x13450E0 Offset: 0x13436E0 VA: 0x1813450E0
	private static void .cctor() { }

	// RVA: 0x1344FF0 Offset: 0x13435F0 VA: 0x181344FF0
	public static KnownHttpVerb Parse(string name) { }

}

