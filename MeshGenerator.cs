public static class MeshGenerator // TypeDefIndex: 11550
{	// Fields
	private const float kMinTruncatedRadius = 0,001;

	// Properties
	private static bool duplicateBackFaces { get; }

	// Methods

	// RVA: 0xAC90D0 Offset: 0xAC76D0 VA: 0x180AC90D0
	private static bool get_duplicateBackFaces() { }

	// RVA: 0xAC7DD0 Offset: 0xAC63D0 VA: 0x180AC7DD0
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC7C90 Offset: 0xAC6290 VA: 0x180AC7C90
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC7F20 Offset: 0xAC6520 VA: 0x180AC7F20
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC8FE0 Offset: 0xAC75E0 VA: 0x180AC8FE0
	public static int GetVertexCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC8DF0 Offset: 0xAC73F0 VA: 0x180AC8DF0
	public static int GetIndicesCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC8F60 Offset: 0xAC7560 VA: 0x180AC8F60
	public static int GetSharedMeshVertexCount() { }

	// RVA: 0xAC8EE0 Offset: 0xAC74E0 VA: 0x180AC8EE0
	public static int GetSharedMeshIndicesCount() { }

}

