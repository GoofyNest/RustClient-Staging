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

	// RVA: 0x12A5E30 Offset: 0x12A4430 VA: 0x1812A5E30
	internal bool get_HasModifiers() { }

	// RVA: 0x213EB40 Offset: 0x213D140 VA: 0x18213EB40
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x213EF80 Offset: 0x213D580 VA: 0x18213EF80
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x2140970 Offset: 0x213EF70 VA: 0x182140970
	internal string get_DisplayFullName() { }

	// RVA: 0x213F160 Offset: 0x213D760 VA: 0x18213F160
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x2140890 Offset: 0x213EE90 VA: 0x182140890
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x213FF90 Offset: 0x213E590 VA: 0x18213FF90
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x213E9E0 Offset: 0x213CFE0 VA: 0x18213E9E0
	private void AddName(string type_name) { }

	// RVA: 0x213E940 Offset: 0x213CF40 VA: 0x18213E940
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x21407E0 Offset: 0x213EDE0 VA: 0x1821407E0
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x213EAC0 Offset: 0x213D0C0 VA: 0x18213EAC0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x213DE30 Offset: 0x213C430 VA: 0x18213DE30
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x213F220 Offset: 0x213D820 VA: 0x18213F220
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

