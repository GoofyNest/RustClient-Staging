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

	// RVA: 0x15027B0 Offset: 0x1500DB0 VA: 0x1815027B0
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x15027E0 Offset: 0x1500DE0 VA: 0x1815027E0
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1502840 Offset: 0x1500E40 VA: 0x181502840
	public bool get_PreserveWhitespace() { }

	// RVA: 0x13A5690 Offset: 0x13A3C90 VA: 0x1813A5690 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x1502830 Offset: 0x1500E30 VA: 0x181502830
	public bool get_IsOpen() { }

	// RVA: 0xA110E0 Offset: 0xA0F6E0 VA: 0x180A110E0
	public void set_IsOpen(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x1502650 Offset: 0x1500C50 VA: 0x181502650 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x15025D0 Offset: 0x1500BD0 VA: 0x1815025D0
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x1502340 Offset: 0x1500940 VA: 0x181502340
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x1502680 Offset: 0x1500C80 VA: 0x181502680
	private static void .cctor() { }

}

