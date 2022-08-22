public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 5808
{	// Fields
	internal string value; // 0x10
	internal List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1097DF0 Offset: 0x10963F0 VA: 0x181097DF0
	protected void .ctor(TransferCodingHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x1098050 Offset: 0x1096650 VA: 0x181098050
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Value() { }

	// RVA: 0x1097AD0 Offset: 0x10960D0 VA: 0x181097AD0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1097990 Offset: 0x1095F90 VA: 0x181097990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1097A50 Offset: 0x1096050 VA: 0x181097A50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1097B30 Offset: 0x1096130 VA: 0x181097B30 Slot: 3
	public override string ToString() { }

	// RVA: 0x1097D60 Offset: 0x1096360 VA: 0x181097D60
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	// RVA: 0x1097B90 Offset: 0x1096190 VA: 0x181097B90
	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }

}

