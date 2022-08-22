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

	// RVA: 0x12928C0 Offset: 0x1290EC0 VA: 0x1812928C0
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x1292A70 Offset: 0x1291070 VA: 0x181292A70
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x1292CC0 Offset: 0x12912C0 VA: 0x181292CC0
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12927F0 Offset: 0x1290DF0 VA: 0x1812927F0
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x1292F90 Offset: 0x1291590 VA: 0x181292F90
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Type() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_Value() { }

	// RVA: 0x1292780 Offset: 0x1290D80 VA: 0x181292780 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x1292850 Offset: 0x1290E50 VA: 0x181292850 Slot: 3
	public override string ToString() { }

}

