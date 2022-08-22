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

	// RVA: 0x1292F60 Offset: 0x1291560 VA: 0x181292F60
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x1293110 Offset: 0x1291710 VA: 0x181293110
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x1293360 Offset: 0x1291960 VA: 0x181293360
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1292E90 Offset: 0x1291490 VA: 0x181292E90
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x1293630 Offset: 0x1291C30 VA: 0x181293630
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Type() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_Value() { }

	// RVA: 0x1292E20 Offset: 0x1291420 VA: 0x181292E20 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x1292EF0 Offset: 0x12914F0 VA: 0x181292EF0 Slot: 3
	public override string ToString() { }

}

