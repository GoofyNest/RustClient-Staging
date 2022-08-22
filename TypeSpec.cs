internal class TypeSpec // TypeDefIndex: 414
{	// Fields
	private TypeIdentifier name; // 0x10
	private string assembly_name; // 0x18
	private List<TypeIdentifier> nested; // 0x20
	private List<TypeSpec> generic_params; // 0x28
	private List<ModifierSpec> modifier_spec; // 0x30
	private bool is_byref; // 0x38
	private string display_fullname; // 0x40

	// Properties
	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }

	// Methods

	// RVA: 0x12A5790 Offset: 0x12A3D90 VA: 0x1812A5790
	internal bool get_HasModifiers() { }

	// RVA: 0x213E320 Offset: 0x213C920 VA: 0x18213E320
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x213E760 Offset: 0x213CD60 VA: 0x18213E760
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x2140150 Offset: 0x213E750 VA: 0x182140150
	internal string get_DisplayFullName() { }

	// RVA: 0x213E940 Offset: 0x213CF40 VA: 0x18213E940
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x2140070 Offset: 0x213E670 VA: 0x182140070
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x213F770 Offset: 0x213DD70 VA: 0x18213F770
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x213E1C0 Offset: 0x213C7C0 VA: 0x18213E1C0
	private void AddName(string type_name) { }

	// RVA: 0x213E120 Offset: 0x213C720 VA: 0x18213E120
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x213FFC0 Offset: 0x213E5C0 VA: 0x18213FFC0
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x213E2A0 Offset: 0x213C8A0 VA: 0x18213E2A0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x213D610 Offset: 0x213BC10 VA: 0x18213D610
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x213EA00 Offset: 0x213D000 VA: 0x18213EA00
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal enum TypeSpec.DisplayNameFormat // TypeDefIndex: 415
{	// Fields
	public int value__; // 0x0
	public const TypeSpec.DisplayNameFormat Default = 0;
	public const TypeSpec.DisplayNameFormat WANT_ASSEMBLY = 1;
	public const TypeSpec.DisplayNameFormat NO_MODIFIERS = 2;

}

