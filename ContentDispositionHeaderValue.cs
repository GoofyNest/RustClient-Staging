public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 5763
{	// Fields
	private string dispositionType; // 0x10
	private List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1087A80 Offset: 0x1086080 VA: 0x181087A80
	protected void .ctor(ContentDispositionHeaderValue source) { }

	// RVA: 0x1087D10 Offset: 0x1086310 VA: 0x181087D10
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1087810 Offset: 0x1085E10 VA: 0x181087810 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10876D0 Offset: 0x1085CD0 VA: 0x1810876D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1087790 Offset: 0x1085D90 VA: 0x181087790 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1087870 Offset: 0x1085E70 VA: 0x181087870 Slot: 3
	public override string ToString() { }

	// RVA: 0x10878D0 Offset: 0x1085ED0 VA: 0x1810878D0
	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }

}

