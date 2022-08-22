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

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Asttree get_Selector() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Asttree[] get_Fields() { }

	// RVA: 0xF48890 Offset: 0xF46E90 VA: 0x180F48890
	private void .ctor() { }

	// RVA: 0xF48920 Offset: 0xF46F20 VA: 0x180F48920
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF487C0 Offset: 0xF46DC0 VA: 0x180F487C0
	private static void .cctor() { }

}

public enum CompiledIdentityConstraint.ConstraintRole // TypeDefIndex: 2144
{	// Fields
	public int value__; // 0x0
	public const CompiledIdentityConstraint.ConstraintRole Unique = 0;
	public const CompiledIdentityConstraint.ConstraintRole Key = 1;
	public const CompiledIdentityConstraint.ConstraintRole Keyref = 2;

}

