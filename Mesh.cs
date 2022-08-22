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
	// RVA: 0x18F46E0 Offset: 0x18F2CE0 VA: 0x1818F46E0
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F6610 Offset: 0x18F4C10 VA: 0x1818F6610
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	// RVA: 0x18F6400 Offset: 0x18F4A00 VA: 0x1818F6400
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x97CC0 Offset: 0x970C0 VA: 0x180097CC0
	// RVA: 0x18F4680 Offset: 0x18F2C80 VA: 0x1818F4680
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x97E00 Offset: 0x97200 VA: 0x180097E00
	// RVA: 0x18F4080 Offset: 0x18F2680 VA: 0x1818F4080
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x97FC0 Offset: 0x973C0 VA: 0x180097FC0
	// RVA: 0x18F3F80 Offset: 0x18F2580 VA: 0x1818F3F80
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x980F0 Offset: 0x974F0 VA: 0x1800980F0
	// RVA: 0x18F3E40 Offset: 0x18F2440 VA: 0x1818F3E40
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x981F0 Offset: 0x975F0 VA: 0x1800981F0
	// RVA: 0x18F4440 Offset: 0x18F2A40 VA: 0x1818F4440
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98340 Offset: 0x97740 VA: 0x180098340
	// RVA: 0x18F4180 Offset: 0x18F2780 VA: 0x1818F4180
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98410 Offset: 0x97810 VA: 0x180098410
	// RVA: 0x18F5030 Offset: 0x18F3630 VA: 0x1818F5030
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x98490 Offset: 0x97890 VA: 0x180098490
	// RVA: 0x18F47D0 Offset: 0x18F2DD0 VA: 0x1818F47D0
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x985C0 Offset: 0x979C0 VA: 0x1800985C0
	// RVA: 0x18F4640 Offset: 0x18F2C40 VA: 0x1818F4640
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x98920 Offset: 0x97D20 VA: 0x180098920
	// RVA: 0x18F4C10 Offset: 0x18F3210 VA: 0x1818F4C10
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	[FreeFunctionAttribute] // RVA: 0x989A0 Offset: 0x97DA0 VA: 0x1800989A0
	// RVA: 0x18F3DE0 Offset: 0x18F23E0 VA: 0x1818F3DE0
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[NativeMethodAttribute] // RVA: 0x98B00 Offset: 0x97F00 VA: 0x180098B00
	// RVA: 0x18F66D0 Offset: 0x18F4CD0 VA: 0x1818F66D0
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x98B70 Offset: 0x97F70 VA: 0x180098B70
	// RVA: 0x18F3F40 Offset: 0x18F2540 VA: 0x1818F3F40
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x98C40 Offset: 0x98040 VA: 0x180098C40
	// RVA: 0x18F4C70 Offset: 0x18F3270 VA: 0x1818F4C70
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x18F6690 Offset: 0x18F4C90 VA: 0x1818F6690
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x18F6BB0 Offset: 0x18F51B0 VA: 0x1818F6BB0
	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethodAttribute] // RVA: 0x98D90 Offset: 0x98190 VA: 0x180098D90
	// RVA: 0x18F6890 Offset: 0x18F4E90 VA: 0x1818F6890
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x98F30 Offset: 0x98330 VA: 0x180098F30
	// RVA: 0x18F67C0 Offset: 0x18F4DC0 VA: 0x1818F67C0
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x990D0 Offset: 0x984D0 VA: 0x1800990D0
	// RVA: 0x18F6B30 Offset: 0x18F5130 VA: 0x1818F6B30
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x99220 Offset: 0x98620 VA: 0x180099220
	// RVA: 0x18F6910 Offset: 0x18F4F10 VA: 0x1818F6910
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x99430 Offset: 0x98830 VA: 0x180099430
	// RVA: 0x18F6DA0 Offset: 0x18F53A0 VA: 0x1818F6DA0
	public void set_subMeshCount(int value) { }

	// RVA: 0x18F6760 Offset: 0x18F4D60 VA: 0x1818F6760
	public Bounds get_bounds() { }

	// RVA: 0x18F6C50 Offset: 0x18F5250 VA: 0x1818F6C50
	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x99690 Offset: 0x98A90 VA: 0x180099690
	// RVA: 0x18F3CB0 Offset: 0x18F22B0 VA: 0x1818F3CB0
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x99850 Offset: 0x98C50 VA: 0x180099850
	// RVA: 0x18F48E0 Offset: 0x18F2EE0 VA: 0x1818F48E0
	private void RecalculateBoundsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99BD0 Offset: 0x98FD0 VA: 0x180099BD0
	// RVA: 0x18F49F0 Offset: 0x18F2FF0 VA: 0x1818F49F0
	private void RecalculateNormalsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99D30 Offset: 0x99130 VA: 0x180099D30
	// RVA: 0x18F4B00 Offset: 0x18F3100 VA: 0x1818F4B00
	private void RecalculateTangentsImpl() { }

	[NativeMethodAttribute] // RVA: 0x99F00 Offset: 0x99300 VA: 0x180099F00
	// RVA: 0x18F4720 Offset: 0x18F2D20 VA: 0x1818F4720
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x99FD0 Offset: 0x993D0 VA: 0x180099FD0
	// RVA: 0x18F6550 Offset: 0x18F4B50 VA: 0x1818F6550
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x9A1C0 Offset: 0x995C0 VA: 0x18009A1C0
	// RVA: 0x18F4310 Offset: 0x18F2910 VA: 0x1818F4310
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x18F45D0 Offset: 0x18F2BD0 VA: 0x1818F45D0
	internal VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x18F3D40 Offset: 0x18F2340 VA: 0x1818F3D40
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B6C0 Offset: 0x1A39CC0 VA: 0x181A3B6C0
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
	|-RVA: 0x1A3B7C0 Offset: 0x1A39DC0 VA: 0x181A3B7C0
	|-Mesh.GetAllocArrayFromChannel<object>
	|-Mesh.GetAllocArrayFromChannel<Color>
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: 0x18F57E0 Offset: 0x18F3DE0 VA: 0x1818F57E0
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

	// RVA: 0x18F6B70 Offset: 0x18F5170 VA: 0x1818F6B70
	public Vector3[] get_vertices() { }

	// RVA: 0x18F7070 Offset: 0x18F5670 VA: 0x1818F7070
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x18F68D0 Offset: 0x18F4ED0 VA: 0x1818F68D0
	public Vector3[] get_normals() { }

	// RVA: 0x18F6D50 Offset: 0x18F5350 VA: 0x1818F6D50
	public void set_normals(Vector3[] value) { }

	// RVA: 0x18F6950 Offset: 0x18F4F50 VA: 0x1818F6950
	public Vector4[] get_tangents() { }

	// RVA: 0x18F6DE0 Offset: 0x18F53E0 VA: 0x1818F6DE0
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x18F6AF0 Offset: 0x18F50F0 VA: 0x1818F6AF0
	public Vector2[] get_uv() { }

	// RVA: 0x18F7020 Offset: 0x18F5620 VA: 0x1818F7020
	public void set_uv(Vector2[] value) { }

	// RVA: 0x18F6A30 Offset: 0x18F5030 VA: 0x1818F6A30
	public Vector2[] get_uv2() { }

	// RVA: 0x18F6F30 Offset: 0x18F5530 VA: 0x1818F6F30
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x18F6A70 Offset: 0x18F5070 VA: 0x1818F6A70
	public Vector2[] get_uv3() { }

	// RVA: 0x18F6F80 Offset: 0x18F5580 VA: 0x1818F6F80
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x18F6AB0 Offset: 0x18F50B0 VA: 0x1818F6AB0
	public Vector2[] get_uv4() { }

	// RVA: 0x18F6FD0 Offset: 0x18F55D0 VA: 0x1818F6FD0
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x18F6850 Offset: 0x18F4E50 VA: 0x1818F6850
	public Color[] get_colors() { }

	// RVA: 0x18F6D00 Offset: 0x18F5300 VA: 0x1818F6D00
	public void set_colors(Color[] value) { }

	// RVA: 0x18F6800 Offset: 0x18F4E00 VA: 0x1818F6800
	public Color32[] get_colors32() { }

	// RVA: 0x18F6CA0 Offset: 0x18F52A0 VA: 0x1818F6CA0
	public void set_colors32(Color32[] value) { }

	// RVA: 0x18F6450 Offset: 0x18F4A50 VA: 0x1818F6450
	public void SetVertices(List<Vector3> inVertices) { }

	// RVA: 0x18F64E0 Offset: 0x18F4AE0 VA: 0x1818F64E0
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x18F5750 Offset: 0x18F3D50 VA: 0x1818F5750
	public void SetNormals(List<Vector3> inNormals) { }

	// RVA: 0x18F56D0 Offset: 0x18F3CD0 VA: 0x1818F56D0
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x18F5B20 Offset: 0x18F4120 VA: 0x1818F5B20
	public void SetTangents(List<Vector4> inTangents) { }

	// RVA: 0x18F5AA0 Offset: 0x18F40A0 VA: 0x1818F5AA0
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x18F4FA0 Offset: 0x18F35A0 VA: 0x1818F4FA0
	public void SetColors(List<Color> inColors) { }

	// RVA: 0x18F4D60 Offset: 0x18F3360 VA: 0x1818F4D60
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x18F4DE0 Offset: 0x18F33E0 VA: 0x1818F4DE0
	public void SetColors(Color[] inColors) { }

	// RVA: 0x18F4E80 Offset: 0x18F3480 VA: 0x1818F4E80
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x18F4CC0 Offset: 0x18F32C0 VA: 0x1818F4CC0
	public void SetColors(List<Color32> inColors) { }

	// RVA: 0x18F4F20 Offset: 0x18F3520 VA: 0x1818F4F20
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

	// RVA: 0x18F61A0 Offset: 0x18F47A0 VA: 0x1818F61A0
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x18F6350 Offset: 0x18F4950 VA: 0x1818F6350
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x18F62D0 Offset: 0x18F48D0 VA: 0x1818F62D0
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x18F6250 Offset: 0x18F4850 VA: 0x1818F6250
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2050 Offset: 0x5D0650 VA: 0x1805D2050
	|-Mesh.SetVertexBufferData<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x18F4810 Offset: 0x18F2E10 VA: 0x1818F4810
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x18F39C0 Offset: 0x18F1FC0 VA: 0x1818F39C0
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x18F39B0 Offset: 0x18F1FB0 VA: 0x1818F39B0
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x18F39A0 Offset: 0x18F1FA0 VA: 0x1818F39A0
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x18F6990 Offset: 0x18F4F90 VA: 0x1818F6990
	public int[] get_triangles() { }

	// RVA: 0x18F6E30 Offset: 0x18F5430 VA: 0x1818F6E30
	public void set_triangles(int[] value) { }

	// RVA: 0x18F44A0 Offset: 0x18F2AA0 VA: 0x1818F44A0
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x18F4530 Offset: 0x18F2B30 VA: 0x1818F4530
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F41E0 Offset: 0x18F27E0 VA: 0x1818F41E0
	public int[] GetIndices(int submesh) { }

	// RVA: 0x18F4270 Offset: 0x18F2870 VA: 0x1818F4270
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x18F40C0 Offset: 0x18F26C0 VA: 0x1818F40C0
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x18F3FC0 Offset: 0x18F25C0 VA: 0x1818F3FC0
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x18F3E80 Offset: 0x18F2480 VA: 0x1818F3E80
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x18F3AE0 Offset: 0x18F20E0 VA: 0x1818F3AE0
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x18F5BB0 Offset: 0x18F41B0 VA: 0x1818F5BB0
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F60F0 Offset: 0x18F46F0 VA: 0x1818F60F0
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x18F5C70 Offset: 0x18F4270 VA: 0x1818F5C70
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5E40 Offset: 0x18F4440 VA: 0x1818F5E40
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F5EF0 Offset: 0x18F44F0 VA: 0x1818F5EF0
	public void SetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x18F5D30 Offset: 0x18F4330 VA: 0x1818F5D30
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F5FF0 Offset: 0x18F45F0 VA: 0x1818F5FF0
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F50A0 Offset: 0x18F36A0 VA: 0x1818F50A0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F54E0 Offset: 0x18F3AE0 VA: 0x1818F54E0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x18F55D0 Offset: 0x18F3BD0 VA: 0x1818F55D0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x18F52D0 Offset: 0x18F38D0 VA: 0x1818F52D0
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F5190 Offset: 0x18F3790 VA: 0x1818F5190
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F53B0 Offset: 0x18F39B0 VA: 0x1818F53B0
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x18F3F40 Offset: 0x18F2540 VA: 0x1818F3F40
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x18F4C70 Offset: 0x18F3270 VA: 0x1818F4C70
	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3D00 Offset: 0x18F2300 VA: 0x1818F3D00
	public void Clear() { }

	// RVA: 0x18F4920 Offset: 0x18F2F20 VA: 0x1818F4920
	public void RecalculateBounds() { }

	// RVA: 0x18F4A30 Offset: 0x18F3030 VA: 0x1818F4A30
	public void RecalculateNormals() { }

	// RVA: 0x18F4B40 Offset: 0x18F3140 VA: 0x1818F4B40
	public void RecalculateTangents() { }

	// RVA: 0x18F4760 Offset: 0x18F2D60 VA: 0x1818F4760
	public void MarkDynamic() { }

	// RVA: 0x18F65A0 Offset: 0x18F4BA0 VA: 0x1818F65A0
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x18F4350 Offset: 0x18F2950 VA: 0x1818F4350
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x18F6710 Offset: 0x18F4D10 VA: 0x1818F6710
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x18F6C00 Offset: 0x18F5200 VA: 0x1818F6C00
	private void set_bounds_Injected(ref Bounds value) { }

}

public static class Mesh // TypeDefIndex: 5606
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A2950 Offset: 0x19A0F50 VA: 0x1819A2950
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

