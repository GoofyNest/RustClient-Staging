internal static class MeshUtilities // TypeDefIndex: 11864
{	// Fields
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; // 0x8

	// Methods

	// RVA: 0x101A0B0 Offset: 0x10186B0 VA: 0x18101A0B0
	private static void .cctor() { }

	// RVA: 0x1019C10 Offset: 0x1018210 VA: 0x181019C10
	internal static Mesh GetColliderMesh(Collider collider) { }

	// RVA: 0x1019F40 Offset: 0x1018540 VA: 0x181019F40
	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	// RVA: 0x1019B70 Offset: 0x1018170 VA: 0x181019B70
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

}

