public sealed class Mesh : Object // TypeDefIndex: 3442
{	public int blendShapeCount { get; }
	[NativeNameAttribute] // RVA: 0x9B1E0 Offset: 0x9A5E0 VA: 0x18009B1E0
	public Matrix4x4[] bindposes { get; set; }
	public bool isReadable { get; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Vector2[] uv3 { get; set; }
	public Vector2[] uv4 { get; set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { get; set; }
	public int[] triangles { get; set; }
	public BoneWeight[] boneWeights { get; set; }


	[FreeFunctionAttribute] // RVA: 0x97710 Offset: 0x96B10 VA: 0x180097710
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x97CC0 Offset: 0x970C0 VA: 0x180097CC0
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x97E00 Offset: 0x97200 VA: 0x180097E00
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97FC0 Offset: 0x973C0 VA: 0x180097FC0
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x980F0 Offset: 0x974F0 VA: 0x1800980F0
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x981F0 Offset: 0x975F0 VA: 0x1800981F0
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98340 Offset: 0x97740 VA: 0x180098340
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98410 Offset: 0x97810 VA: 0x180098410
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98490 Offset: 0x97890 VA: 0x180098490
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x985C0 Offset: 0x979C0 VA: 0x1800985C0
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x98920 Offset: 0x97D20 VA: 0x180098920
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0x989A0 Offset: 0x97DA0 VA: 0x1800989A0
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute] // RVA: 0x98B00 Offset: 0x97F00 VA: 0x180098B00
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x98B70 Offset: 0x97F70 VA: 0x180098B70
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x98C40 Offset: 0x98040 VA: 0x180098C40
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	public Matrix4x4[] get_bindposes() { }

	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute] // RVA: 0x98D90 Offset: 0x98190 VA: 0x180098D90
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x98F30 Offset: 0x98330 VA: 0x180098F30
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x990D0 Offset: 0x984D0 VA: 0x1800990D0
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x99220 Offset: 0x98620 VA: 0x180099220
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x99430 Offset: 0x98830 VA: 0x180099430
	public void set_subMeshCount(int value) { }

	public Bounds get_bounds() { }

	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x99690 Offset: 0x98A90 VA: 0x180099690
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x99850 Offset: 0x98C50 VA: 0x180099850
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99BD0 Offset: 0x98FD0 VA: 0x180099BD0
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99D30 Offset: 0x99130 VA: 0x180099D30
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99F00 Offset: 0x99300 VA: 0x180099F00
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x99FD0 Offset: 0x993D0 VA: 0x180099FD0
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x9A1C0 Offset: 0x995C0 VA: 0x18009A1C0
	private MeshTopology GetTopologyImpl(int submesh) { }

	internal VertexAttribute GetUVChannel(int uvIndex) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3ADE0 Offset: 0x1A393E0 VA: 0x181A3ADE0
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3AEE0 Offset: 0x1A394E0 VA: 0x181A3AEE0
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1AC0 Offset: 0x5D00C0 VA: 0x1805D1AC0
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color32>
	*/

	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1B50 Offset: 0x5D0150 VA: 0x1805D1B50
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color>
	|-Mesh.SetArrayForChannel<Vector2>
	|-Mesh.SetArrayForChannel<Vector3>
	|-Mesh.SetArrayForChannel<Vector4>
	*/

	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1BD0 Offset: 0x5D01D0 VA: 0x1805D1BD0
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector2>
	|-Mesh.SetListForChannel<Vector4>
	*/

	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1C90 Offset: 0x5D0290 VA: 0x1805D1C90
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	*/

	public Vector3[] get_vertices() { }

	public void set_vertices(Vector3[] value) { }

	public Vector3[] get_normals() { }

	public void set_normals(Vector3[] value) { }

	public Vector4[] get_tangents() { }

	public void set_tangents(Vector4[] value) { }

	public Vector2[] get_uv() { }

	public void set_uv(Vector2[] value) { }

	public Vector2[] get_uv2() { }

	public void set_uv2(Vector2[] value) { }

	public Vector2[] get_uv3() { }

	public void set_uv3(Vector2[] value) { }

	public Vector2[] get_uv4() { }

	public void set_uv4(Vector2[] value) { }

	public Color[] get_colors() { }

	public void set_colors(Color[] value) { }

	public Color32[] get_colors32() { }

	public void set_colors32(Color32[] value) { }

	public void SetVertices(List<Vector3> inVertices) { }

	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	public void SetNormals(List<Vector3> inNormals) { }

	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	public void SetTangents(List<Vector4> inTangents) { }

	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	public void SetColors(List<Color> inColors) { }

	public void SetColors(List<Color> inColors, int start, int length) { }

	public void SetColors(Color[] inColors) { }

	public void SetColors(Color[] inColors, int start, int length) { }

	public void SetColors(List<Color32> inColors) { }

	public void SetColors(List<Color32> inColors, int start, int length) { }

	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1D40 Offset: 0x5D0340 VA: 0x1805D1D40
	|-Mesh.SetUvsImpl<object>
	|
	|-RVA: 0x5D1E20 Offset: 0x5D0420 VA: 0x1805D1E20
	|-Mesh.SetUvsImpl<Vector2>
	|
	|-RVA: 0x5D1F00 Offset: 0x5D0500 VA: 0x1805D1F00
	|-Mesh.SetUvsImpl<Vector4>
	*/

	public void SetUVs(int channel, List<Vector2> uvs) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1FE0 Offset: 0x5D05E0 VA: 0x1805D1FE0
	|-Mesh.SetVertexBufferData<FoliageGridMeshData.FoliageVertex>
	*/

	private void PrintErrorCantAccessIndices() { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	public int[] get_triangles() { }

	public void set_triangles(int[] value) { }

	public int[] GetTriangles(int submesh) { }

	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int[] GetIndices(int submesh) { }

	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	public uint GetIndexStart(int submesh) { }

	public uint GetIndexCount(int submesh) { }

	public uint GetBaseVertex(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void SetTriangles(int[] triangles, int submesh) { }

	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void SetTriangles(List<int> triangles, int submesh) { }

	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	public BoneWeight[] get_boneWeights() { }

	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void Clear() { }

	public void RecalculateBounds() { }

	public void RecalculateNormals() { }

	public void RecalculateTangents() { }

	public void MarkDynamic() { }

	public void UploadMeshData(bool markNoLongerReadable) { }

	public MeshTopology GetTopology(int submesh) { }

	private void get_bounds_Injected(out Bounds ret) { }

	private void set_bounds_Injected(ref Bounds value) { }

}

public static class Mesh // TypeDefIndex: 5606
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Export(Mesh mesh, string filename) { }

}

public struct Mesh_Extents // TypeDefIndex: 6862
{	public Vector2 min; // 0x0
	public Vector2 max; // 0x8


	public void .ctor(Vector2 min, Vector2 max) { }

	public override string ToString() { }

}

public class Mesh : ConsoleSystem // TypeDefIndex: 11945
{	private static float m_quality; // 0x1E590

	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }


	public static float get_quality() { }

	public static void set_quality(float value) { }

	public static float get_lod() { }

	public static float get_cull() { }

	public void .ctor() { }

	private static void .cctor() { }

}

