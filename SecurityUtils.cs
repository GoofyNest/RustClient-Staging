internal static class SecurityUtils // TypeDefIndex: 2565
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x14CDC20 Offset: 0x14CC220 VA: 0x1814CDC20
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x14CE060 Offset: 0x14CC660 VA: 0x1814CE060
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x14CE130 Offset: 0x14CC730 VA: 0x1814CE130
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x14CE120 Offset: 0x14CC720 VA: 0x1814CE120
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x14CDD90 Offset: 0x14CC390 VA: 0x1814CDD90
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x14CDEF0 Offset: 0x14CC4F0 VA: 0x1814CDEF0
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x14CDB80 Offset: 0x14CC180 VA: 0x1814CDB80
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x14CDC60 Offset: 0x14CC260 VA: 0x1814CDC60
	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

}

