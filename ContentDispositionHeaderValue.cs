public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 5763
{	// Fields
	private string dispositionType; // 0x10
	private List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1087010 Offset: 0x1085610 VA: 0x181087010
	protected void .ctor(ContentDispositionHeaderValue source) { }

	// RVA: 0x10872A0 Offset: 0x10858A0 VA: 0x1810872A0
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1086DA0 Offset: 0x10853A0 VA: 0x181086DA0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1086C60 Offset: 0x1085260 VA: 0x181086C60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1086D20 Offset: 0x1085320 VA: 0x181086D20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1086E00 Offset: 0x1085400 VA: 0x181086E00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1086E60 Offset: 0x1085460 VA: 0x181086E60
	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }

}

