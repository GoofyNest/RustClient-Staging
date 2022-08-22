public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 5788
{	// Fields
	private List<NameValueHeaderValue> parameters; // 0x20

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x10940F0 Offset: 0x10926F0 VA: 0x1810940F0
	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1094320 Offset: 0x1092920 VA: 0x181094320
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1093C20 Offset: 0x1092220 VA: 0x181093C20 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1093A10 Offset: 0x1092010 VA: 0x181093A10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1093B60 Offset: 0x1092160 VA: 0x181093B60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1093C80 Offset: 0x1092280 VA: 0x181093C80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1094060 Offset: 0x1092660 VA: 0x181094060
	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	// RVA: 0x1093D80 Offset: 0x1092380 VA: 0x181093D80
	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }

}

