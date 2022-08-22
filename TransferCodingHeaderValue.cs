public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 5808
{	// Fields
	internal string value; // 0x10
	internal List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1098860 Offset: 0x1096E60 VA: 0x181098860
	protected void .ctor(TransferCodingHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x1098AC0 Offset: 0x10970C0 VA: 0x181098AC0
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Value() { }

	// RVA: 0x1098540 Offset: 0x1096B40 VA: 0x181098540 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1098400 Offset: 0x1096A00 VA: 0x181098400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10984C0 Offset: 0x1096AC0 VA: 0x1810984C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10985A0 Offset: 0x1096BA0 VA: 0x1810985A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10987D0 Offset: 0x1096DD0 VA: 0x1810987D0
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	// RVA: 0x1098600 Offset: 0x1096C00 VA: 0x181098600
	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }

}

