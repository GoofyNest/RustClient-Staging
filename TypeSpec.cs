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

	// RVA: 0x213E220 Offset: 0x213C820 VA: 0x18213E220
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x213E660 Offset: 0x213CC60 VA: 0x18213E660
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x2140050 Offset: 0x213E650 VA: 0x182140050
	internal string get_DisplayFullName() { }

	// RVA: 0x213E840 Offset: 0x213CE40 VA: 0x18213E840
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x213FF70 Offset: 0x213E570 VA: 0x18213FF70
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x213F670 Offset: 0x213DC70 VA: 0x18213F670
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x213E0C0 Offset: 0x213C6C0 VA: 0x18213E0C0
	private void AddName(string type_name) { }

	// RVA: 0x213E020 Offset: 0x213C620 VA: 0x18213E020
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x213FEC0 Offset: 0x213E4C0 VA: 0x18213FEC0
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x213E1A0 Offset: 0x213C7A0 VA: 0x18213E1A0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x213D510 Offset: 0x213BB10 VA: 0x18213D510
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x213E900 Offset: 0x213CF00 VA: 0x18213E900
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

