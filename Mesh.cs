public sealed class Mesh : Object // TypeDefIndex: 3442
{	// Properties
	public int blendShapeCount { get; }
	[NativeNameAttribute] // RVA: 0x9B0C0 Offset: 0x9A4C0 VA: 0x18009B0C0
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

	[FreeFunctionAttribute] // RVA: 0x97680 Offset: 0x96A80 VA: 0x180097680
	// RVA: 0x18F4460 Offset: 0x18F2A60 VA: 0x1818F4460
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F6390 Offset: 0x18F4990 VA: 0x1818F6390
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x978E0 Offset: 0x96CE0 VA: 0x1800978E0
	// RVA: 0x18F6180 Offset: 0x18F4780 VA: 0x1818F6180
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x97BE0 Offset: 0x96FE0 VA: 0x180097BE0
	// RVA: 0x18F4400 Offset: 0x18F2A00 VA: 0x1818F4400
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x97D70 Offset: 0x97170 VA: 0x180097D70
	// RVA: 0x18F3E00 Offset: 0x18F2400 VA: 0x1818F3E00
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97E40 Offset: 0x97240 VA: 0x180097E40
	// RVA: 0x18F3D00 Offset: 0x18F2300 VA: 0x1818F3D00
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x98060 Offset: 0x97460 VA: 0x180098060
	// RVA: 0x18F3BC0 Offset: 0x18F21C0 VA: 0x1818F3BC0
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x981A0 Offset: 0x975A0 VA: 0x1800981A0
	// RVA: 0x18F41C0 Offset: 0x18F27C0 VA: 0x1818F41C0
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98200 Offset: 0x97600 VA: 0x180098200
	// RVA: 0x18F3F00 Offset: 0x18F2500 VA: 0x1818F3F00
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98380 Offset: 0x97780 VA: 0x180098380
	// RVA: 0x18F4DB0 Offset: 0x18F33B0 VA: 0x1818F4DB0
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98400 Offset: 0x97800 VA: 0x180098400
	// RVA: 0x18F4550 Offset: 0x18F2B50 VA: 0x1818F4550
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x984C0 Offset: 0x978C0 VA: 0x1800984C0
	// RVA: 0x18F43C0 Offset: 0x18F29C0 VA: 0x1818F43C0
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x985E0 Offset: 0x979E0 VA: 0x1800985E0
	// RVA: 0x18F4990 Offset: 0x18F2F90 VA: 0x1818F4990
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0x98910 Offset: 0x97D10 VA: 0x180098910
	// RVA: 0x18F3B60 Offset: 0x18F2160 VA: 0x1818F3B60
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute] // RVA: 0x98A70 Offset: 0x97E70 VA: 0x180098A70
	// RVA: 0x18F6450 Offset: 0x18F4A50 VA: 0x1818F6450
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x98AE0 Offset: 0x97EE0 VA: 0x180098AE0
	// RVA: 0x18F3CC0 Offset: 0x18F22C0 VA: 0x1818F3CC0
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x98BB0 Offset: 0x97FB0 VA: 0x180098BB0
	// RVA: 0x18F49F0 Offset: 0x18F2FF0 VA: 0x1818F49F0
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x18F6410 Offset: 0x18F4A10 VA: 0x1818F6410
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x18F6930 Offset: 0x18F4F30 VA: 0x1818F6930
	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute] // RVA: 0x98CD0 Offset: 0x980D0 VA: 0x180098CD0
	// RVA: 0x18F6610 Offset: 0x18F4C10 VA: 0x1818F6610
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x98E70 Offset: 0x98270 VA: 0x180098E70
	// RVA: 0x18F6540 Offset: 0x18F4B40 VA: 0x1818F6540
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x98F90 Offset: 0x98390 VA: 0x180098F90
	// RVA: 0x18F68B0 Offset: 0x18F4EB0 VA: 0x1818F68B0
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x99210 Offset: 0x98610 VA: 0x180099210
	// RVA: 0x18F6690 Offset: 0x18F4C90 VA: 0x1818F6690
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x993A0 Offset: 0x987A0 VA: 0x1800993A0
	// RVA: 0x18F6B20 Offset: 0x18F5120 VA: 0x1818F6B20
	public void set_subMeshCount(int value) { }

	// RVA: 0x18F64E0 Offset: 0x18F4AE0 VA: 0x1818F64E0
	public Bounds get_bounds() { }

	// RVA: 0x18F69D0 Offset: 0x18F4FD0 VA: 0x1818F69D0
	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x995A0 Offset: 0x989A0 VA: 0x1800995A0
	// RVA: 0x18F3A30 Offset: 0x18F2030 VA: 0x1818F3A30
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x99800 Offset: 0x98C00 VA: 0x180099800
	// RVA: 0x18F4660 Offset: 0x18F2C60 VA: 0x1818F4660
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99B40 Offset: 0x98F40 VA: 0x180099B40
	// RVA: 0x18F4770 Offset: 0x18F2D70 VA: 0x1818F4770
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99CA0 Offset: 0x990A0 VA: 0x180099CA0
	// RVA: 0x18F4880 Offset: 0x18F2E80 VA: 0x1818F4880
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99EC0 Offset: 0x992C0 VA: 0x180099EC0
	// RVA: 0x18F44A0 Offset: 0x18F2AA0 VA: 0x1818F44A0
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x99F40 Offset: 0x99340 VA: 0x180099F40
	// RVA: 0x18F62D0 Offset: 0x18F48D0 VA: 0x1818F62D0
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x9A110 Offset: 0x99510 VA: 0x18009A110
	// RVA: 0x18F4090 Offset: 0x18F2690 VA: 0x1818F4090
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x18F4350 Offset: 0x18F2950 VA: 0x1818F4350
	internal VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x18F3AC0 Offset: 0x18F20C0 VA: 0x1818F3AC0
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B440 Offset: 0x1A39A40 VA: 0x181A3B440
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
	|-RVA: 0x1A3B540 Offset: 0x1A39B40 VA: 0x181A3B540
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: 0x18F5560 Offset: 0x18F3B60 VA: 0x1818F5560
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1B30 Offset: 0x5D0130 VA: 0x1805D1B30
	|-Mesh.SetArrayForChannel<object>
	|-Mesh.SetArrayForChannel<Color32>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1BC0 Offset: 0x5D01C0 VA: 0x1805D1BC0
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
	|-RVA: 0x5D1C40 Offset: 0x5D0240 VA: 0x1805D1C40
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color32>
	|-Mesh.SetListForChannel<Vector2>
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1D00 Offset: 0x5D0300 VA: 0x1805D1D00
	|-Mesh.SetListForChannel<object>
	|-Mesh.SetListForChannel<Color>
	|-Mesh.SetListForChannel<Vector3>
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: 0x18F68F0 Offset: 0x18F4EF0 VA: 0x1818F68F0
	public Vector3[] get_vertices() { }

	// RVA: 0x18F6DF0 Offset: 0x18F53F0 VA: 0x1818F6DF0
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x18F6650 Offset: 0x18F4C50 VA: 0x1818F6650
	public Vector3[] get_normals() { }

	// RVA: 0x18F6AD0 Offset: 0x18F50D0 VA: 0x1818F6AD0
	public void set_normals(Vector3[] value) { }

	// RVA: 0x18F66D0 Offset: 0x18F4CD0 VA: 0x1818F66D0
	public Vector4[] get_tangents() { }

	// RVA: 0x18F6B60 Offset: 0x18F5160 VA: 0x1818F6B60
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x18F6870 Offset: 0x18F4E70 VA: 0x1818F6870
	public Vector2[] get_uv() { }

	// RVA: 0x18F6DA0 Offset: 0x18F53A0 VA: 0x1818F6DA0
	public void set_uv(Vector2[] value) { }

	// RVA: 0x18F67B0 Offset: 0x18F4DB0 VA: 0x1818F67B0
	public Vector2[] get_uv2() { }

	// RVA: 0x18F6CB0 Offset: 0x18F52B0 VA: 0x1818F6CB0
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x18F67F0 Offset: 0x18F4DF0 VA: 0x1818F67F0
	public Vector2[] get_uv3() { }

	// RVA: 0x18F6D00 Offset: 0x18F5300 VA: 0x1818F6D00
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x18F6830 Offset: 0x18F4E30 VA: 0x1818F6830
	public Vector2[] get_uv4() { }

	// RVA: 0x18F6D50 Offset: 0x18F5350 VA: 0x1818F6D50
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x18F65D0 Offset: 0x18F4BD0 VA: 0x1818F65D0
	public Color[] get_colors() { }

	// RVA: 0x18F6A80 Offset: 0x18F5080 VA: 0x1818F6A80
	public void set_colors(Color[] value) { }

	// RVA: 0x18F6580 Offset: 0x18F4B80 VA: 0x1818F6580
	public Color32[] get_colors32() { }

	// RVA: 0x18F6A20 Offset: 0x18F5020 VA: 0x1818F6A20
	public void set_colors32(Color32[] value) { }

	// RVA: 0x18F61D0 Offset: 0x18F47D0 VA: 0x1818F61D0
	public void SetVertices(List<Vector3> inVertices) { }

	// RVA: 0x18F6260 Offset: 0x18F4860 VA: 0x1818F6260
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x18F54D0 Offset: 0x18F3AD0 VA: 0x1818F54D0
	public void SetNormals(List<Vector3> inNormals) { }

	// RVA: 0x18F5450 Offset: 0x18F3A50 VA: 0x1818F5450
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x18F58A0 Offset: 0x18F3EA0 VA: 0x1818F58A0
	public void SetTangents(List<Vector4> inTangents) { }

	// RVA: 0x18F5820 Offset: 0x18F3E20 VA: 0x1818F5820
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x18F4D20 Offset: 0x18F3320 VA: 0x1818F4D20
	public void SetColors(List<Color> inColors) { }

	// RVA: 0x18F4AE0 Offset: 0x18F30E0 VA: 0x1818F4AE0
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x18F4B60 Offset: 0x18F3160 VA: 0x1818F4B60
	public void SetColors(Color[] inColors) { }

	// RVA: 0x18F4C00 Offset: 0x18F3200 VA: 0x1818F4C00
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x18F4A40 Offset: 0x18F3040 VA: 0x1818F4A40
	public void SetColors(List<Color32> inColors) { }

	// RVA: 0x18F4CA0 Offset: 0x18F32A0 VA: 0x1818F4CA0
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1DB0 Offset: 0x5D03B0 VA: 0x1805D1DB0
	|-Mesh.SetUvsImpl<object>
	|
	|-RVA: 0x5D1E90 Offset: 0x5D0490 VA: 0x1805D1E90
	|-Mesh.SetUvsImpl<Vector2>
	|
	|-RVA: 0x5D1F70 Offset: 0x5D0570 VA: 0x1805D1F70
	|-Mesh.SetUvsImpl<Vector4>
	*/

	// RVA: 0x18F5F20 Offset: 0x18F4520 VA: 0x1818F5F20
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x18F60D0 Offset: 0x18F46D0 VA: 0x1818F60D0
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x18F6050 Offset: 0x18F4650 VA: 0x1818F6050
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x18F5FD0 Offset: 0x18F45D0 VA: 0x1818F5FD0
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2050 Offset: 0x5D0650 VA: 0x1805D2050
	|-Mesh.SetVertexBufferData<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x18F4590 Offset: 0x18F2B90 VA: 0x1818F4590
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x18F3740 Offset: 0x18F1D40 VA: 0x1818F3740
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x18F3730 Offset: 0x18F1D30 VA: 0x1818F3730
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x18F3720 Offset: 0x18F1D20 VA: 0x1818F3720
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x18F6710 Offset: 0x18F4D10 VA: 0x1818F6710
	public int[] get_triangles() { }

	// RVA: 0x18F6BB0 Offset: 0x18F51B0 VA: 0x1818F6BB0
	public void set_triangles(int[] value) { }

	// RVA: 0x18F4220 Offset: 0x18F2820 VA: 0x1818F4220
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x18F42B0 Offset: 0x18F28B0 VA: 0x1818F42B0
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F3F60 Offset: 0x18F2560 VA: 0x1818F3F60
	public int[] GetIndices(int submesh) { }

	// RVA: 0x18F3FF0 Offset: 0x18F25F0 VA: 0x1818F3FF0
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x18F3E40 Offset: 0x18F2440 VA: 0x1818F3E40
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x18F3D40 Offset: 0x18F2340 VA: 0x1818F3D40
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x18F3C00 Offset: 0x18F2200 VA: 0x1818F3C00
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x18F3860 Offset: 0x18F1E60 VA: 0x1818F3860
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x18F5930 Offset: 0x18F3F30 VA: 0x1818F5930
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F5E70 Offset: 0x18F4470 VA: 0x1818F5E70
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x18F59F0 Offset: 0x18F3FF0 VA: 0x1818F59F0
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5BC0 Offset: 0x18F41C0 VA: 0x1818F5BC0
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F5C70 Offset: 0x18F4270 VA: 0x1818F5C70
	public void SetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x18F5AB0 Offset: 0x18F40B0 VA: 0x1818F5AB0
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5D70 Offset: 0x18F4370 VA: 0x1818F5D70
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F4E20 Offset: 0x18F3420 VA: 0x1818F4E20
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F5260 Offset: 0x18F3860 VA: 0x1818F5260
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x18F5350 Offset: 0x18F3950 VA: 0x1818F5350
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5050 Offset: 0x18F3650 VA: 0x1818F5050
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F4F10 Offset: 0x18F3510 VA: 0x1818F4F10
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F5130 Offset: 0x18F3730 VA: 0x1818F5130
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F3CC0 Offset: 0x18F22C0 VA: 0x1818F3CC0
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x18F49F0 Offset: 0x18F2FF0 VA: 0x1818F49F0
	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F3A80 Offset: 0x18F2080 VA: 0x1818F3A80
	public void Clear() { }

	// RVA: 0x18F46A0 Offset: 0x18F2CA0 VA: 0x1818F46A0
	public void RecalculateBounds() { }

	// RVA: 0x18F47B0 Offset: 0x18F2DB0 VA: 0x1818F47B0
	public void RecalculateNormals() { }

	// RVA: 0x18F48C0 Offset: 0x18F2EC0 VA: 0x1818F48C0
	public void RecalculateTangents() { }

	// RVA: 0x18F44E0 Offset: 0x18F2AE0 VA: 0x1818F44E0
	public void MarkDynamic() { }

	// RVA: 0x18F6320 Offset: 0x18F4920 VA: 0x1818F6320
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x18F40D0 Offset: 0x18F26D0 VA: 0x1818F40D0
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x18F6490 Offset: 0x18F4A90 VA: 0x1818F6490
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x18F6980 Offset: 0x18F4F80 VA: 0x1818F6980
	private void set_bounds_Injected(ref Bounds value) { }

}

public static class Mesh // TypeDefIndex: 5606
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19A26D0 Offset: 0x19A0CD0 VA: 0x1819A26D0
	public static void Export(Mesh mesh, string filename) { }

}

public struct Mesh_Extents // TypeDefIndex: 6862
{	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x117000 Offset: 0x116400 VA: 0x180117000
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x1176F0 Offset: 0x116AF0 VA: 0x1801176F0 Slot: 3
	public override string ToString() { }

}

public class Mesh : ConsoleSystem // TypeDefIndex: 11945
{	// Fields
	private static float m_quality; // 0x204A6

	// Properties
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
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

