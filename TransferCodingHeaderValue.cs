public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 5808
{	// Fields
	internal string value; // 0x10
	internal List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1097B30 Offset: 0x1096130 VA: 0x181097B30
	protected void .ctor(TransferCodingHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x1097D90 Offset: 0x1096390 VA: 0x181097D90
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Value() { }

	// RVA: 0x1097810 Offset: 0x1095E10 VA: 0x181097810 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10976D0 Offset: 0x1095CD0 VA: 0x1810976D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1097790 Offset: 0x1095D90 VA: 0x181097790 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1097870 Offset: 0x1095E70 VA: 0x181097870 Slot: 3
	public override string ToString() { }

	// RVA: 0x1097AA0 Offset: 0x10960A0 VA: 0x181097AA0
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	// RVA: 0x10978D0 Offset: 0x1095ED0 VA: 0x1810978D0
	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }

}

