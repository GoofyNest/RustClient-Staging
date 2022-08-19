public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 5788
{	// Fields
	private List<NameValueHeaderValue> parameters; // 0x20

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x1093E30 Offset: 0x1092430 VA: 0x181093E30
	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1094060 Offset: 0x1092660 VA: 0x181094060
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1093960 Offset: 0x1091F60 VA: 0x181093960 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1093750 Offset: 0x1091D50 VA: 0x181093750 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10938A0 Offset: 0x1091EA0 VA: 0x1810938A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10939C0 Offset: 0x1091FC0 VA: 0x1810939C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1093DA0 Offset: 0x10923A0 VA: 0x181093DA0
	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	// RVA: 0x1093AC0 Offset: 0x10920C0 VA: 0x181093AC0
	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }

}

