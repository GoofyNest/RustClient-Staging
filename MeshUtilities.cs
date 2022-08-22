internal static class MeshUtilities // TypeDefIndex: 11864
{	// Fields
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; // 0x8

	// Methods

	// RVA: 0x1019610 Offset: 0x1017C10 VA: 0x181019610
	private static void .cctor() { }

	// RVA: 0x1019170 Offset: 0x1017770 VA: 0x181019170
	internal static Mesh GetColliderMesh(Collider collider) { }

	// RVA: 0x10194A0 Offset: 0x1017AA0 VA: 0x1810194A0
	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	// RVA: 0x10190D0 Offset: 0x10176D0 VA: 0x1810190D0
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

}

