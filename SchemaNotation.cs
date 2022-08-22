internal sealed class SchemaNotation // TypeDefIndex: 2284
{	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_SystemLiteral() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_Pubid() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Pubid(string value) { }

}

