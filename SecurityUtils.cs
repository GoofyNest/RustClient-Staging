internal static class SecurityUtils // TypeDefIndex: 2565
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x14CEB50 Offset: 0x14CD150 VA: 0x1814CEB50
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x14CEF90 Offset: 0x14CD590 VA: 0x1814CEF90
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x14CF060 Offset: 0x14CD660 VA: 0x1814CF060
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x14CF050 Offset: 0x14CD650 VA: 0x1814CF050
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x14CECC0 Offset: 0x14CD2C0 VA: 0x1814CECC0
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x14CEE20 Offset: 0x14CD420 VA: 0x1814CEE20
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x14CEAB0 Offset: 0x14CD0B0 VA: 0x1814CEAB0
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x14CEB90 Offset: 0x14CD190 VA: 0x1814CEB90
	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

}

