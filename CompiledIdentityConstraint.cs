internal class CompiledIdentityConstraint // TypeDefIndex: 2143
{	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Asttree get_Selector() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Asttree[] get_Fields() { }

	// RVA: 0xF47B30 Offset: 0xF46130 VA: 0x180F47B30
	private void .ctor() { }

	// RVA: 0xF47BC0 Offset: 0xF461C0 VA: 0x180F47BC0
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF47A60 Offset: 0xF46060 VA: 0x180F47A60
	private static void .cctor() { }

}

public enum CompiledIdentityConstraint.ConstraintRole // TypeDefIndex: 2144
{	// Fields
	public int value__; // 0x0
	public const CompiledIdentityConstraint.ConstraintRole Unique = 0;
	public const CompiledIdentityConstraint.ConstraintRole Key = 1;
	public const CompiledIdentityConstraint.ConstraintRole Keyref = 2;

}

