public sealed class Mesh : Object // TypeDefIndex: 3442
{	// Properties
	public int blendShapeCount { get; }
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

	// Methods

	[FreeFunctionAttribute] // RVA: 0x97710 Offset: 0x96B10 VA: 0x180097710
	// RVA: 0x18F3E00 Offset: 0x18F2400 VA: 0x1818F3E00
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F5D30 Offset: 0x18F4330 VA: 0x1818F5D30
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	// RVA: 0x18F5B20 Offset: 0x18F4120 VA: 0x1818F5B20
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x97CC0 Offset: 0x970C0 VA: 0x180097CC0
	// RVA: 0x18F3DA0 Offset: 0x18F23A0 VA: 0x1818F3DA0
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x97E00 Offset: 0x97200 VA: 0x180097E00
	// RVA: 0x18F37A0 Offset: 0x18F1DA0 VA: 0x1818F37A0
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97FC0 Offset: 0x973C0 VA: 0x180097FC0
	// RVA: 0x18F36A0 Offset: 0x18F1CA0 VA: 0x1818F36A0
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x980F0 Offset: 0x974F0 VA: 0x1800980F0
	// RVA: 0x18F3560 Offset: 0x18F1B60 VA: 0x1818F3560
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x981F0 Offset: 0x975F0 VA: 0x1800981F0
	// RVA: 0x18F3B60 Offset: 0x18F2160 VA: 0x1818F3B60
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98340 Offset: 0x97740 VA: 0x180098340
	// RVA: 0x18F38A0 Offset: 0x18F1EA0 VA: 0x1818F38A0
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98410 Offset: 0x97810 VA: 0x180098410
	// RVA: 0x18F4750 Offset: 0x18F2D50 VA: 0x1818F4750
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98490 Offset: 0x97890 VA: 0x180098490
	// RVA: 0x18F3EF0 Offset: 0x18F24F0 VA: 0x1818F3EF0
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x985C0 Offset: 0x979C0 VA: 0x1800985C0
	// RVA: 0x18F3D60 Offset: 0x18F2360 VA: 0x1818F3D60
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x98920 Offset: 0x97D20 VA: 0x180098920
	// RVA: 0x18F4330 Offset: 0x18F2930 VA: 0x1818F4330
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0x989A0 Offset: 0x97DA0 VA: 0x1800989A0
	// RVA: 0x18F3500 Offset: 0x18F1B00 VA: 0x1818F3500
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute] // RVA: 0x98B00 Offset: 0x97F00 VA: 0x180098B00
	// RVA: 0x18F5DF0 Offset: 0x18F43F0 VA: 0x1818F5DF0
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x98B70 Offset: 0x97F70 VA: 0x180098B70
	// RVA: 0x18F3660 Offset: 0x18F1C60 VA: 0x1818F3660
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x98C40 Offset: 0x98040 VA: 0x180098C40
	// RVA: 0x18F4390 Offset: 0x18F2990 VA: 0x1818F4390
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x18F5DB0 Offset: 0x18F43B0 VA: 0x1818F5DB0
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x18F62D0 Offset: 0x18F48D0 VA: 0x1818F62D0
	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute] // RVA: 0x98D90 Offset: 0x98190 VA: 0x180098D90
	// RVA: 0x18F5FB0 Offset: 0x18F45B0 VA: 0x1818F5FB0
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x98F30 Offset: 0x98330 VA: 0x180098F30
	// RVA: 0x18F5EE0 Offset: 0x18F44E0 VA: 0x1818F5EE0
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x990D0 Offset: 0x984D0 VA: 0x1800990D0
	// RVA: 0x18F6250 Offset: 0x18F4850 VA: 0x1818F6250
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x99220 Offset: 0x98620 VA: 0x180099220
	// RVA: 0x18F6030 Offset: 0x18F4630 VA: 0x1818F6030
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x99430 Offset: 0x98830 VA: 0x180099430
	// RVA: 0x18F64C0 Offset: 0x18F4AC0 VA: 0x1818F64C0
	public void set_subMeshCount(int value) { }

	// RVA: 0x18F5E80 Offset: 0x18F4480 VA: 0x1818F5E80
	public Bounds get_bounds() { }

	// RVA: 0x18F6370 Offset: 0x18F4970 VA: 0x1818F6370
	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x99690 Offset: 0x98A90 VA: 0x180099690
	// RVA: 0x18F33D0 Offset: 0x18F19D0 VA: 0x1818F33D0
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x99850 Offset: 0x98C50 VA: 0x180099850
	// RVA: 0x18F4000 Offset: 0x18F2600 VA: 0x1818F4000
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99BD0 Offset: 0x98FD0 VA: 0x180099BD0
	// RVA: 0x18F4110 Offset: 0x18F2710 VA: 0x1818F4110
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99D30 Offset: 0x99130 VA: 0x180099D30
	// RVA: 0x18F4220 Offset: 0x18F2820 VA: 0x1818F4220
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99F00 Offset: 0x99300 VA: 0x180099F00
	// RVA: 0x18F3E40 Offset: 0x18F2440 VA: 0x1818F3E40
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x99FD0 Offset: 0x993D0 VA: 0x180099FD0
	// RVA: 0x18F5C70 Offset: 0x18F4270 VA: 0x1818F5C70
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x9A1C0 Offset: 0x995C0 VA: 0x18009A1C0
	// RVA: 0x18F3A30 Offset: 0x18F2030 VA: 0x1818F3A30
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x18F3CF0 Offset: 0x18F22F0 VA: 0x1818F3CF0
	internal VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x18F3460 Offset: 0x18F1A60 VA: 0x1818F3460
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: 0x18F4F00 Offset: 0x18F3500 VA: 0x1818F4F00
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1AC0 Offset: 0x5D00C0 VA: 0x1805D1AC0
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color32>
	*/

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1BD0 Offset: 0x5D01D0 VA: 0x1805D1BD0
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector2>
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1C90 Offset: 0x5D0290 VA: 0x1805D1C90
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: 0x18F6290 Offset: 0x18F4890 VA: 0x1818F6290
	public Vector3[] get_vertices() { }

	// RVA: 0x18F6790 Offset: 0x18F4D90 VA: 0x1818F6790
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x18F5FF0 Offset: 0x18F45F0 VA: 0x1818F5FF0
	public Vector3[] get_normals() { }

	// RVA: 0x18F6470 Offset: 0x18F4A70 VA: 0x1818F6470
	public void set_normals(Vector3[] value) { }

	// RVA: 0x18F6070 Offset: 0x18F4670 VA: 0x1818F6070
	public Vector4[] get_tangents() { }

	// RVA: 0x18F6500 Offset: 0x18F4B00 VA: 0x1818F6500
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x18F6210 Offset: 0x18F4810 VA: 0x1818F6210
	public Vector2[] get_uv() { }

	// RVA: 0x18F6740 Offset: 0x18F4D40 VA: 0x1818F6740
	public void set_uv(Vector2[] value) { }

	// RVA: 0x18F6150 Offset: 0x18F4750 VA: 0x1818F6150
	public Vector2[] get_uv2() { }

	// RVA: 0x18F6650 Offset: 0x18F4C50 VA: 0x1818F6650
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x18F6190 Offset: 0x18F4790 VA: 0x1818F6190
	public Vector2[] get_uv3() { }

	// RVA: 0x18F66A0 Offset: 0x18F4CA0 VA: 0x1818F66A0
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x18F61D0 Offset: 0x18F47D0 VA: 0x1818F61D0
	public Vector2[] get_uv4() { }

	// RVA: 0x18F66F0 Offset: 0x18F4CF0 VA: 0x1818F66F0
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x18F5F70 Offset: 0x18F4570 VA: 0x1818F5F70
	public Color[] get_colors() { }

	// RVA: 0x18F6420 Offset: 0x18F4A20 VA: 0x1818F6420
	public void set_colors(Color[] value) { }

	// RVA: 0x18F5F20 Offset: 0x18F4520 VA: 0x1818F5F20
	public Color32[] get_colors32() { }

	// RVA: 0x18F63C0 Offset: 0x18F49C0 VA: 0x1818F63C0
	public void set_colors32(Color32[] value) { }

	// RVA: 0x18F5B70 Offset: 0x18F4170 VA: 0x1818F5B70
	public void SetVertices(List<Vector3> inVertices) { }

	// RVA: 0x18F5C00 Offset: 0x18F4200 VA: 0x1818F5C00
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x18F4E70 Offset: 0x18F3470 VA: 0x1818F4E70
	public void SetNormals(List<Vector3> inNormals) { }

	// RVA: 0x18F4DF0 Offset: 0x18F33F0 VA: 0x1818F4DF0
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x18F5240 Offset: 0x18F3840 VA: 0x1818F5240
	public void SetTangents(List<Vector4> inTangents) { }

	// RVA: 0x18F51C0 Offset: 0x18F37C0 VA: 0x1818F51C0
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x18F46C0 Offset: 0x18F2CC0 VA: 0x1818F46C0
	public void SetColors(List<Color> inColors) { }

	// RVA: 0x18F4480 Offset: 0x18F2A80 VA: 0x1818F4480
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x18F4500 Offset: 0x18F2B00 VA: 0x1818F4500
	public void SetColors(Color[] inColors) { }

	// RVA: 0x18F45A0 Offset: 0x18F2BA0 VA: 0x1818F45A0
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x18F43E0 Offset: 0x18F29E0 VA: 0x1818F43E0
	public void SetColors(List<Color32> inColors) { }

	// RVA: 0x18F4640 Offset: 0x18F2C40 VA: 0x1818F4640
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: -1 Offset: -1
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

	// RVA: 0x18F58C0 Offset: 0x18F3EC0 VA: 0x1818F58C0
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x18F5A70 Offset: 0x18F4070 VA: 0x1818F5A70
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x18F59F0 Offset: 0x18F3FF0 VA: 0x1818F59F0
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x18F5970 Offset: 0x18F3F70 VA: 0x1818F5970
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1FE0 Offset: 0x5D05E0 VA: 0x1805D1FE0
	|-Mesh.SetVertexBufferData<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x18F3F30 Offset: 0x18F2530 VA: 0x1818F3F30
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x18F30E0 Offset: 0x18F16E0 VA: 0x1818F30E0
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x18F30D0 Offset: 0x18F16D0 VA: 0x1818F30D0
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x18F30C0 Offset: 0x18F16C0 VA: 0x1818F30C0
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x18F60B0 Offset: 0x18F46B0 VA: 0x1818F60B0
	public int[] get_triangles() { }

	// RVA: 0x18F6550 Offset: 0x18F4B50 VA: 0x1818F6550
	public void set_triangles(int[] value) { }

	// RVA: 0x18F3BC0 Offset: 0x18F21C0 VA: 0x1818F3BC0
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x18F3C50 Offset: 0x18F2250 VA: 0x1818F3C50
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3900 Offset: 0x18F1F00 VA: 0x1818F3900
	public int[] GetIndices(int submesh) { }

	// RVA: 0x18F3990 Offset: 0x18F1F90 VA: 0x1818F3990
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x18F37E0 Offset: 0x18F1DE0 VA: 0x1818F37E0
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x18F36E0 Offset: 0x18F1CE0 VA: 0x1818F36E0
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x18F35A0 Offset: 0x18F1BA0 VA: 0x1818F35A0
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x18F3200 Offset: 0x18F1800 VA: 0x1818F3200
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x18F52D0 Offset: 0x18F38D0 VA: 0x1818F52D0
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F5810 Offset: 0x18F3E10 VA: 0x1818F5810
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x18F5390 Offset: 0x18F3990 VA: 0x1818F5390
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5560 Offset: 0x18F3B60 VA: 0x1818F5560
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F5610 Offset: 0x18F3C10 VA: 0x1818F5610
	public void SetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x18F5450 Offset: 0x18F3A50 VA: 0x1818F5450
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5710 Offset: 0x18F3D10 VA: 0x1818F5710
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F47C0 Offset: 0x18F2DC0 VA: 0x1818F47C0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F4C00 Offset: 0x18F3200 VA: 0x1818F4C00
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x18F4CF0 Offset: 0x18F32F0 VA: 0x1818F4CF0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F49F0 Offset: 0x18F2FF0 VA: 0x1818F49F0
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F48B0 Offset: 0x18F2EB0 VA: 0x1818F48B0
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F4AD0 Offset: 0x18F30D0 VA: 0x1818F4AD0
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F3660 Offset: 0x18F1C60 VA: 0x1818F3660
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x18F4390 Offset: 0x18F2990 VA: 0x1818F4390
	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3420 Offset: 0x18F1A20 VA: 0x1818F3420
	public void Clear() { }

	// RVA: 0x18F4040 Offset: 0x18F2640 VA: 0x1818F4040
	public void RecalculateBounds() { }

	// RVA: 0x18F4150 Offset: 0x18F2750 VA: 0x1818F4150
	public void RecalculateNormals() { }

	// RVA: 0x18F4260 Offset: 0x18F2860 VA: 0x1818F4260
	public void RecalculateTangents() { }

	// RVA: 0x18F3E80 Offset: 0x18F2480 VA: 0x1818F3E80
	public void MarkDynamic() { }

	// RVA: 0x18F5CC0 Offset: 0x18F42C0 VA: 0x1818F5CC0
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x18F3A70 Offset: 0x18F2070 VA: 0x1818F3A70
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x18F5E30 Offset: 0x18F4430 VA: 0x1818F5E30
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x18F6320 Offset: 0x18F4920 VA: 0x1818F6320
	private void set_bounds_Injected(ref Bounds value) { }

}

public static class Mesh // TypeDefIndex: 5606
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FD50 Offset: 0x198E350 VA: 0x18198FD50
	public static void Export(Mesh mesh, string filename) { }

}

public struct Mesh_Extents // TypeDefIndex: 6862
{	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x117670 Offset: 0x116A70 VA: 0x180117670 Slot: 3
	public override string ToString() { }

}

public class Mesh : ConsoleSystem // TypeDefIndex: 11945
{	// Fields
	private static float m_quality; // 0x1E590

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }

	// Methods

	// RVA: 0x3668C0 Offset: 0x364EC0 VA: 0x1803668C0
	public static float get_quality() { }

	// RVA: 0x366920 Offset: 0x364F20 VA: 0x180366920
	public static void set_quality(float value) { }

	// RVA: 0x366810 Offset: 0x364E10 VA: 0x180366810
	public static float get_lod() { }

	// RVA: 0x366730 Offset: 0x364D30 VA: 0x180366730
	public static float get_cull() { }

	// RVA: 0x3666D0 Offset: 0x364CD0 VA: 0x1803666D0
	public void .ctor() { }

	// RVA: 0x366690 Offset: 0x364C90 VA: 0x180366690
	private static void .cctor() { }

}

