public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 5784
{	// Fields
	internal List<NameValueHeaderValue> parameters; // 0x10
	internal string media_type; // 0x18

	// Properties
	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x1092700 Offset: 0x1090D00 VA: 0x181092700
	public void .ctor(string mediaType) { }

	// RVA: 0x1092470 Offset: 0x1090A70 VA: 0x181092470
	protected void .ctor(MediaTypeHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x1092840 Offset: 0x1090E40 VA: 0x181092840
	public string get_CharSet() { }

	// RVA: 0x10929C0 Offset: 0x1090FC0 VA: 0x1810929C0
	public void set_CharSet(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_MediaType() { }

	// RVA: 0x1092B80 Offset: 0x1091180 VA: 0x181092B80
	public void set_MediaType(string value) { }

	// RVA: 0x1092950 Offset: 0x1090F50 VA: 0x181092950
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1091FD0 Offset: 0x10905D0 VA: 0x181091FD0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1091E90 Offset: 0x1090490 VA: 0x181091E90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1091F50 Offset: 0x1090550 VA: 0x181091F50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1092030 Offset: 0x1090630 VA: 0x181092030 Slot: 3
	public override string ToString() { }

	// RVA: 0x10922D0 Offset: 0x10908D0 VA: 0x1810922D0
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	// RVA: 0x1092090 Offset: 0x1090690 VA: 0x181092090
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }

}

private sealed class MediaTypeHeaderValue.<>c // TypeDefIndex: 5785
{	// Fields
	public static readonly MediaTypeHeaderValue.<>c <>9; // 0x0
	public static Predicate<NameValueHeaderValue> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x109B140 Offset: 0x1099740 VA: 0x18109B140
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AF70 Offset: 0x1099570 VA: 0x18109AF70
	internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }

}

