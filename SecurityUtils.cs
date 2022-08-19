internal static class SecurityUtils // TypeDefIndex: 2565
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x14CE890 Offset: 0x14CCE90 VA: 0x1814CE890
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x14CECD0 Offset: 0x14CD2D0 VA: 0x1814CECD0
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x14CEDA0 Offset: 0x14CD3A0 VA: 0x1814CEDA0
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x14CED90 Offset: 0x14CD390 VA: 0x1814CED90
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x14CEA00 Offset: 0x14CD000 VA: 0x1814CEA00
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x14CEB60 Offset: 0x14CD160 VA: 0x1814CEB60
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x14CE7F0 Offset: 0x14CCDF0 VA: 0x1814CE7F0
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x14CE8D0 Offset: 0x14CCED0 VA: 0x1814CE8D0
	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

}

