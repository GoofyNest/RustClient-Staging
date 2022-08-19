public static class MeshGenerator // TypeDefIndex: 11550
{	// Fields
	private const float kMinTruncatedRadius = 0,001;

	// Properties
	private static bool duplicateBackFaces { get; }

	// Methods

	// RVA: 0xAC8E10 Offset: 0xAC7410 VA: 0x180AC8E10
	private static bool get_duplicateBackFaces() { }

	// RVA: 0xAC7B10 Offset: 0xAC6110 VA: 0x180AC7B10
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC79D0 Offset: 0xAC5FD0 VA: 0x180AC79D0
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC7C60 Offset: 0xAC6260 VA: 0x180AC7C60
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap) { }

	// RVA: 0xAC8D20 Offset: 0xAC7320 VA: 0x180AC8D20
	public static int GetVertexCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC8B30 Offset: 0xAC7130 VA: 0x180AC8B30
	public static int GetIndicesCount(int numSides, int numSegments, bool geomCap) { }

	// RVA: 0xAC8CA0 Offset: 0xAC72A0 VA: 0x180AC8CA0
	public static int GetSharedMeshVertexCount() { }

	// RVA: 0xAC8C20 Offset: 0xAC7220 VA: 0x180AC8C20
	public static int GetSharedMeshIndicesCount() { }

}

