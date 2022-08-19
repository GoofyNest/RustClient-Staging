public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 5763
{	// Fields
	private string dispositionType; // 0x10
	private List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x1086D50 Offset: 0x1085350 VA: 0x181086D50
	protected void .ctor(ContentDispositionHeaderValue source) { }

	// RVA: 0x1086FE0 Offset: 0x10855E0 VA: 0x181086FE0
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1086AE0 Offset: 0x10850E0 VA: 0x181086AE0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10869A0 Offset: 0x1084FA0 VA: 0x1810869A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1086A60 Offset: 0x1085060 VA: 0x181086A60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1086B40 Offset: 0x1085140 VA: 0x181086B40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1086BA0 Offset: 0x10851A0 VA: 0x181086BA0
	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }

}

