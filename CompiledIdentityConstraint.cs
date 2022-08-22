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

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Asttree[] get_Fields() { }

	// RVA: 0xF47DF0 Offset: 0xF463F0 VA: 0x180F47DF0
	private void .ctor() { }

	// RVA: 0xF47E80 Offset: 0xF46480 VA: 0x180F47E80
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF47D20 Offset: 0xF46320 VA: 0x180F47D20
	private static void .cctor() { }

}

public enum CompiledIdentityConstraint.ConstraintRole // TypeDefIndex: 2144
{	// Fields
	public int value__; // 0x0
	public const CompiledIdentityConstraint.ConstraintRole Unique = 0;
	public const CompiledIdentityConstraint.ConstraintRole Key = 1;
	public const CompiledIdentityConstraint.ConstraintRole Keyref = 2;

}

