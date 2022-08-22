internal class ContentValidator // TypeDefIndex: 2167
{	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x1501880 Offset: 0x14FFE80 VA: 0x181501880
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x15018B0 Offset: 0x14FFEB0 VA: 0x1815018B0
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1501910 Offset: 0x14FFF10 VA: 0x181501910
	public bool get_PreserveWhitespace() { }

	// RVA: 0x13A4790 Offset: 0x13A2D90 VA: 0x1813A4790 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x1501900 Offset: 0x14FFF00 VA: 0x181501900
	public bool get_IsOpen() { }

	// RVA: 0xA115D0 Offset: 0xA0FBD0 VA: 0x180A115D0
	public void set_IsOpen(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x1501720 Offset: 0x14FFD20 VA: 0x181501720 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x15016A0 Offset: 0x14FFCA0 VA: 0x1815016A0
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x1501410 Offset: 0x14FFA10 VA: 0x181501410
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x1501750 Offset: 0x14FFD50 VA: 0x181501750
	private static void .cctor() { }

}

