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
	// RVA: 0x18F4420 Offset: 0x18F2A20 VA: 0x1818F4420
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F6350 Offset: 0x18F4950 VA: 0x1818F6350
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	// RVA: 0x18F6140 Offset: 0x18F4740 VA: 0x1818F6140
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x97CC0 Offset: 0x970C0 VA: 0x180097CC0
	// RVA: 0x18F43C0 Offset: 0x18F29C0 VA: 0x1818F43C0
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x97E00 Offset: 0x97200 VA: 0x180097E00
	// RVA: 0x18F3DC0 Offset: 0x18F23C0 VA: 0x1818F3DC0
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97FC0 Offset: 0x973C0 VA: 0x180097FC0
	// RVA: 0x18F3CC0 Offset: 0x18F22C0 VA: 0x1818F3CC0
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x980F0 Offset: 0x974F0 VA: 0x1800980F0
	// RVA: 0x18F3B80 Offset: 0x18F2180 VA: 0x1818F3B80
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x981F0 Offset: 0x975F0 VA: 0x1800981F0
	// RVA: 0x18F4180 Offset: 0x18F2780 VA: 0x1818F4180
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98340 Offset: 0x97740 VA: 0x180098340
	// RVA: 0x18F3EC0 Offset: 0x18F24C0 VA: 0x1818F3EC0
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98410 Offset: 0x97810 VA: 0x180098410
	// RVA: 0x18F4D70 Offset: 0x18F3370 VA: 0x1818F4D70
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98490 Offset: 0x97890 VA: 0x180098490
	// RVA: 0x18F4510 Offset: 0x18F2B10 VA: 0x1818F4510
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x985C0 Offset: 0x979C0 VA: 0x1800985C0
	// RVA: 0x18F4380 Offset: 0x18F2980 VA: 0x1818F4380
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x98920 Offset: 0x97D20 VA: 0x180098920
	// RVA: 0x18F4950 Offset: 0x18F2F50 VA: 0x1818F4950
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0x989A0 Offset: 0x97DA0 VA: 0x1800989A0
	// RVA: 0x18F3B20 Offset: 0x18F2120 VA: 0x1818F3B20
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute] // RVA: 0x98B00 Offset: 0x97F00 VA: 0x180098B00
	// RVA: 0x18F6410 Offset: 0x18F4A10 VA: 0x1818F6410
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x98B70 Offset: 0x97F70 VA: 0x180098B70
	// RVA: 0x18F3C80 Offset: 0x18F2280 VA: 0x1818F3C80
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x98C40 Offset: 0x98040 VA: 0x180098C40
	// RVA: 0x18F49B0 Offset: 0x18F2FB0 VA: 0x1818F49B0
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x18F63D0 Offset: 0x18F49D0 VA: 0x1818F63D0
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x18F68F0 Offset: 0x18F4EF0 VA: 0x1818F68F0
	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute] // RVA: 0x98D90 Offset: 0x98190 VA: 0x180098D90
	// RVA: 0x18F65D0 Offset: 0x18F4BD0 VA: 0x1818F65D0
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x98F30 Offset: 0x98330 VA: 0x180098F30
	// RVA: 0x18F6500 Offset: 0x18F4B00 VA: 0x1818F6500
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x990D0 Offset: 0x984D0 VA: 0x1800990D0
	// RVA: 0x18F6870 Offset: 0x18F4E70 VA: 0x1818F6870
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x99220 Offset: 0x98620 VA: 0x180099220
	// RVA: 0x18F6650 Offset: 0x18F4C50 VA: 0x1818F6650
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x99430 Offset: 0x98830 VA: 0x180099430
	// RVA: 0x18F6AE0 Offset: 0x18F50E0 VA: 0x1818F6AE0
	public void set_subMeshCount(int value) { }

	// RVA: 0x18F64A0 Offset: 0x18F4AA0 VA: 0x1818F64A0
	public Bounds get_bounds() { }

	// RVA: 0x18F6990 Offset: 0x18F4F90 VA: 0x1818F6990
	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x99690 Offset: 0x98A90 VA: 0x180099690
	// RVA: 0x18F39F0 Offset: 0x18F1FF0 VA: 0x1818F39F0
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x99850 Offset: 0x98C50 VA: 0x180099850
	// RVA: 0x18F4620 Offset: 0x18F2C20 VA: 0x1818F4620
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99BD0 Offset: 0x98FD0 VA: 0x180099BD0
	// RVA: 0x18F4730 Offset: 0x18F2D30 VA: 0x1818F4730
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99D30 Offset: 0x99130 VA: 0x180099D30
	// RVA: 0x18F4840 Offset: 0x18F2E40 VA: 0x1818F4840
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99F00 Offset: 0x99300 VA: 0x180099F00
	// RVA: 0x18F4460 Offset: 0x18F2A60 VA: 0x1818F4460
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x99FD0 Offset: 0x993D0 VA: 0x180099FD0
	// RVA: 0x18F6290 Offset: 0x18F4890 VA: 0x1818F6290
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x9A1C0 Offset: 0x995C0 VA: 0x18009A1C0
	// RVA: 0x18F4050 Offset: 0x18F2650 VA: 0x1818F4050
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x18F4310 Offset: 0x18F2910 VA: 0x1818F4310
	internal VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x18F3A80 Offset: 0x18F2080 VA: 0x1818F3A80
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B400 Offset: 0x1A39A00 VA: 0x181A3B400
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
	|-RVA: 0x1A3B500 Offset: 0x1A39B00 VA: 0x181A3B500
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: 0x18F5520 Offset: 0x18F3B20 VA: 0x1818F5520
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

	// RVA: 0x18F68B0 Offset: 0x18F4EB0 VA: 0x1818F68B0
	public Vector3[] get_vertices() { }

	// RVA: 0x18F6DB0 Offset: 0x18F53B0 VA: 0x1818F6DB0
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x18F6610 Offset: 0x18F4C10 VA: 0x1818F6610
	public Vector3[] get_normals() { }

	// RVA: 0x18F6A90 Offset: 0x18F5090 VA: 0x1818F6A90
	public void set_normals(Vector3[] value) { }

	// RVA: 0x18F6690 Offset: 0x18F4C90 VA: 0x1818F6690
	public Vector4[] get_tangents() { }

	// RVA: 0x18F6B20 Offset: 0x18F5120 VA: 0x1818F6B20
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x18F6830 Offset: 0x18F4E30 VA: 0x1818F6830
	public Vector2[] get_uv() { }

	// RVA: 0x18F6D60 Offset: 0x18F5360 VA: 0x1818F6D60
	public void set_uv(Vector2[] value) { }

	// RVA: 0x18F6770 Offset: 0x18F4D70 VA: 0x1818F6770
	public Vector2[] get_uv2() { }

	// RVA: 0x18F6C70 Offset: 0x18F5270 VA: 0x1818F6C70
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x18F67B0 Offset: 0x18F4DB0 VA: 0x1818F67B0
	public Vector2[] get_uv3() { }

	// RVA: 0x18F6CC0 Offset: 0x18F52C0 VA: 0x1818F6CC0
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x18F67F0 Offset: 0x18F4DF0 VA: 0x1818F67F0
	public Vector2[] get_uv4() { }

	// RVA: 0x18F6D10 Offset: 0x18F5310 VA: 0x1818F6D10
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x18F6590 Offset: 0x18F4B90 VA: 0x1818F6590
	public Color[] get_colors() { }

	// RVA: 0x18F6A40 Offset: 0x18F5040 VA: 0x1818F6A40
	public void set_colors(Color[] value) { }

	// RVA: 0x18F6540 Offset: 0x18F4B40 VA: 0x1818F6540
	public Color32[] get_colors32() { }

	// RVA: 0x18F69E0 Offset: 0x18F4FE0 VA: 0x1818F69E0
	public void set_colors32(Color32[] value) { }

	// RVA: 0x18F6190 Offset: 0x18F4790 VA: 0x1818F6190
	public void SetVertices(List<Vector3> inVertices) { }

	// RVA: 0x18F6220 Offset: 0x18F4820 VA: 0x1818F6220
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x18F5490 Offset: 0x18F3A90 VA: 0x1818F5490
	public void SetNormals(List<Vector3> inNormals) { }

	// RVA: 0x18F5410 Offset: 0x18F3A10 VA: 0x1818F5410
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x18F5860 Offset: 0x18F3E60 VA: 0x1818F5860
	public void SetTangents(List<Vector4> inTangents) { }

	// RVA: 0x18F57E0 Offset: 0x18F3DE0 VA: 0x1818F57E0
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x18F4CE0 Offset: 0x18F32E0 VA: 0x1818F4CE0
	public void SetColors(List<Color> inColors) { }

	// RVA: 0x18F4AA0 Offset: 0x18F30A0 VA: 0x1818F4AA0
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x18F4B20 Offset: 0x18F3120 VA: 0x1818F4B20
	public void SetColors(Color[] inColors) { }

	// RVA: 0x18F4BC0 Offset: 0x18F31C0 VA: 0x1818F4BC0
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x18F4A00 Offset: 0x18F3000 VA: 0x1818F4A00
	public void SetColors(List<Color32> inColors) { }

	// RVA: 0x18F4C60 Offset: 0x18F3260 VA: 0x1818F4C60
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

	// RVA: 0x18F5EE0 Offset: 0x18F44E0 VA: 0x1818F5EE0
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x18F6090 Offset: 0x18F4690 VA: 0x1818F6090
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x18F6010 Offset: 0x18F4610 VA: 0x1818F6010
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x18F5F90 Offset: 0x18F4590 VA: 0x1818F5F90
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2050 Offset: 0x5D0650 VA: 0x1805D2050
	|-Mesh.SetVertexBufferData<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x18F4550 Offset: 0x18F2B50 VA: 0x1818F4550
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x18F3700 Offset: 0x18F1D00 VA: 0x1818F3700
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x18F36F0 Offset: 0x18F1CF0 VA: 0x1818F36F0
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x18F36E0 Offset: 0x18F1CE0 VA: 0x1818F36E0
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x18F66D0 Offset: 0x18F4CD0 VA: 0x1818F66D0
	public int[] get_triangles() { }

	// RVA: 0x18F6B70 Offset: 0x18F5170 VA: 0x1818F6B70
	public void set_triangles(int[] value) { }

	// RVA: 0x18F41E0 Offset: 0x18F27E0 VA: 0x1818F41E0
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x18F4270 Offset: 0x18F2870 VA: 0x1818F4270
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3F20 Offset: 0x18F2520 VA: 0x1818F3F20
	public int[] GetIndices(int submesh) { }

	// RVA: 0x18F3FB0 Offset: 0x18F25B0 VA: 0x1818F3FB0
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x18F3E00 Offset: 0x18F2400 VA: 0x1818F3E00
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x18F3D00 Offset: 0x18F2300 VA: 0x1818F3D00
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x18F3BC0 Offset: 0x18F21C0 VA: 0x1818F3BC0
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x18F3820 Offset: 0x18F1E20 VA: 0x1818F3820
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x18F58F0 Offset: 0x18F3EF0 VA: 0x1818F58F0
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F5E30 Offset: 0x18F4430 VA: 0x1818F5E30
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x18F59B0 Offset: 0x18F3FB0 VA: 0x1818F59B0
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5B80 Offset: 0x18F4180 VA: 0x1818F5B80
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F5C30 Offset: 0x18F4230 VA: 0x1818F5C30
	public void SetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x18F5A70 Offset: 0x18F4070 VA: 0x1818F5A70
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5D30 Offset: 0x18F4330 VA: 0x1818F5D30
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F4DE0 Offset: 0x18F33E0 VA: 0x1818F4DE0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F5220 Offset: 0x18F3820 VA: 0x1818F5220
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x18F5310 Offset: 0x18F3910 VA: 0x1818F5310
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5010 Offset: 0x18F3610 VA: 0x1818F5010
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F4ED0 Offset: 0x18F34D0 VA: 0x1818F4ED0
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F50F0 Offset: 0x18F36F0 VA: 0x1818F50F0
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F3C80 Offset: 0x18F2280 VA: 0x1818F3C80
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x18F49B0 Offset: 0x18F2FB0 VA: 0x1818F49B0
	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3A40 Offset: 0x18F2040 VA: 0x1818F3A40
	public void Clear() { }

	// RVA: 0x18F4660 Offset: 0x18F2C60 VA: 0x1818F4660
	public void RecalculateBounds() { }

	// RVA: 0x18F4770 Offset: 0x18F2D70 VA: 0x1818F4770
	public void RecalculateNormals() { }

	// RVA: 0x18F4880 Offset: 0x18F2E80 VA: 0x1818F4880
	public void RecalculateTangents() { }

	// RVA: 0x18F44A0 Offset: 0x18F2AA0 VA: 0x1818F44A0
	public void MarkDynamic() { }

	// RVA: 0x18F62E0 Offset: 0x18F48E0 VA: 0x1818F62E0
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x18F4090 Offset: 0x18F2690 VA: 0x1818F4090
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x18F6450 Offset: 0x18F4A50 VA: 0x1818F6450
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x18F6940 Offset: 0x18F4F40 VA: 0x1818F6940
	private void set_bounds_Injected(ref Bounds value) { }

}

public static class Mesh // TypeDefIndex: 5606
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A2690 Offset: 0x19A0C90 VA: 0x1819A2690
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
	private static float m_quality; // 0x204A6

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

