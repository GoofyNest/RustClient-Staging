public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 5788
{	// Fields
	private List<NameValueHeaderValue> parameters; // 0x20

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x1094B60 Offset: 0x1093160 VA: 0x181094B60
	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1094D90 Offset: 0x1093390 VA: 0x181094D90
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1094690 Offset: 0x1092C90 VA: 0x181094690 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1094480 Offset: 0x1092A80 VA: 0x181094480 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10945D0 Offset: 0x1092BD0 VA: 0x1810945D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10946F0 Offset: 0x1092CF0 VA: 0x1810946F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1094AD0 Offset: 0x10930D0 VA: 0x181094AD0
	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	// RVA: 0x10947F0 Offset: 0x1092DF0 VA: 0x1810947F0
	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }

}

