internal static class MeshUtilities // TypeDefIndex: 11864
{	// Fields
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; // 0x8

	// Methods

	// RVA: 0x1019350 Offset: 0x1017950 VA: 0x181019350
	private static void .cctor() { }

	// RVA: 0x1018EB0 Offset: 0x10174B0 VA: 0x181018EB0
	internal static Mesh GetColliderMesh(Collider collider) { }

	// RVA: 0x10191E0 Offset: 0x10177E0 VA: 0x1810191E0
	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	// RVA: 0x1018E10 Offset: 0x1017410 VA: 0x181018E10
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

}

