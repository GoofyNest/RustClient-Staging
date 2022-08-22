public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 5784
{	// Fields
	internal List<NameValueHeaderValue> parameters; // 0x10
	internal string media_type; // 0x18

	// Properties
	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x1093170 Offset: 0x1091770 VA: 0x181093170
	public void .ctor(string mediaType) { }

	// RVA: 0x1092EE0 Offset: 0x10914E0 VA: 0x181092EE0
	protected void .ctor(MediaTypeHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x10932B0 Offset: 0x10918B0 VA: 0x1810932B0
	public string get_CharSet() { }

	// RVA: 0x1093430 Offset: 0x1091A30 VA: 0x181093430
	public void set_CharSet(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_MediaType() { }

	// RVA: 0x10935F0 Offset: 0x1091BF0 VA: 0x1810935F0
	public void set_MediaType(string value) { }

	// RVA: 0x10933C0 Offset: 0x10919C0 VA: 0x1810933C0
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1092A40 Offset: 0x1091040 VA: 0x181092A40 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1092900 Offset: 0x1090F00 VA: 0x181092900 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10929C0 Offset: 0x1090FC0 VA: 0x1810929C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1092AA0 Offset: 0x10910A0 VA: 0x181092AA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1092D40 Offset: 0x1091340 VA: 0x181092D40
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	// RVA: 0x1092B00 Offset: 0x1091100 VA: 0x181092B00
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }

}

private sealed class MediaTypeHeaderValue.<>c // TypeDefIndex: 5785
{	// Fields
	public static readonly MediaTypeHeaderValue.<>c <>9; // 0x0
	public static Predicate<NameValueHeaderValue> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x109BBB0 Offset: 0x109A1B0 VA: 0x18109BBB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109B9E0 Offset: 0x1099FE0 VA: 0x18109B9E0
	internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }

}

