public static class MeshGenerator // TypeDefIndex: 11550
{	// Fields
	private const float kMinTruncatedRadius = 0,001;

	// Properties
	private static bool duplicateBackFaces { get; }

	// Methods

	// RVA: 0xAC95A0 Offset: 0xAC7BA0 VA: 0x180AC95A0
	private static bool get_duplicateBackFaces() { }

	// RVA: 0xAC82A0 Offset: 0xAC68A0 VA: 0x180AC82A0
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC8160 Offset: 0xAC6760 VA: 0x180AC8160
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC83F0 Offset: 0xAC69F0 VA: 0x180AC83F0
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC94B0 Offset: 0xAC7AB0 VA: 0x180AC94B0
	public static int GetVertexCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC92C0 Offset: 0xAC78C0 VA: 0x180AC92C0
	public static int GetIndicesCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC9430 Offset: 0xAC7A30 VA: 0x180AC9430
	public static int GetSharedMeshVertexCount() { }

	// RVA: 0xAC93B0 Offset: 0xAC79B0 VA: 0x180AC93B0
	public static int GetSharedMeshIndicesCount() { }

}

