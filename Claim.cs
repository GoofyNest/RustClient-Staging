public class Claim // TypeDefIndex: 934
{	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1292600 Offset: 0x1290C00 VA: 0x181292600
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x12927B0 Offset: 0x1290DB0 VA: 0x1812927B0
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x1292A00 Offset: 0x1291000 VA: 0x181292A00
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1292530 Offset: 0x1290B30 VA: 0x181292530
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x1292CD0 Offset: 0x12912D0 VA: 0x181292CD0
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Type() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_Value() { }

	// RVA: 0x12924C0 Offset: 0x1290AC0 VA: 0x1812924C0 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x1292590 Offset: 0x1290B90 VA: 0x181292590 Slot: 3
	public override string ToString() { }

}

