public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 5784
{	// Fields
	internal List<NameValueHeaderValue> parameters; // 0x10
	internal string media_type; // 0x18

	// Properties
	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x1092440 Offset: 0x1090A40 VA: 0x181092440
	public void .ctor(string mediaType) { }

	// RVA: 0x10921B0 Offset: 0x10907B0 VA: 0x1810921B0
	protected void .ctor(MediaTypeHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x1092580 Offset: 0x1090B80 VA: 0x181092580
	public string get_CharSet() { }

	// RVA: 0x1092700 Offset: 0x1090D00 VA: 0x181092700
	public void set_CharSet(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_MediaType() { }

	// RVA: 0x10928C0 Offset: 0x1090EC0 VA: 0x1810928C0
	public void set_MediaType(string value) { }

	// RVA: 0x1092690 Offset: 0x1090C90 VA: 0x181092690
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1091D10 Offset: 0x1090310 VA: 0x181091D10 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1091BD0 Offset: 0x10901D0 VA: 0x181091BD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1091C90 Offset: 0x1090290 VA: 0x181091C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1091D70 Offset: 0x1090370 VA: 0x181091D70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1092010 Offset: 0x1090610 VA: 0x181092010
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	// RVA: 0x1091DD0 Offset: 0x10903D0 VA: 0x181091DD0
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }

}

private sealed class MediaTypeHeaderValue.<>c // TypeDefIndex: 5785
{	// Fields
	public static readonly MediaTypeHeaderValue.<>c <>9; // 0x0
	public static Predicate<NameValueHeaderValue> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x109AE80 Offset: 0x1099480 VA: 0x18109AE80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109ACB0 Offset: 0x10992B0 VA: 0x18109ACB0
	internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }

}

