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

	// RVA: 0x12A54D0 Offset: 0x12A3AD0 VA: 0x1812A54D0
	internal bool get_HasModifiers() { }

	// RVA: 0x213E060 Offset: 0x213C660 VA: 0x18213E060
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x213E4A0 Offset: 0x213CAA0 VA: 0x18213E4A0
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x213FE90 Offset: 0x213E490 VA: 0x18213FE90
	internal string get_DisplayFullName() { }

	// RVA: 0x213E680 Offset: 0x213CC80 VA: 0x18213E680
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x213FDB0 Offset: 0x213E3B0 VA: 0x18213FDB0
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x213F4B0 Offset: 0x213DAB0 VA: 0x18213F4B0
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x213DF00 Offset: 0x213C500 VA: 0x18213DF00
	private void AddName(string type_name) { }

	// RVA: 0x213DE60 Offset: 0x213C460 VA: 0x18213DE60
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x213FD00 Offset: 0x213E300 VA: 0x18213FD00
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x213DFE0 Offset: 0x213C5E0 VA: 0x18213DFE0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x213D350 Offset: 0x213B950 VA: 0x18213D350
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x213E740 Offset: 0x213CD40 VA: 0x18213E740
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

