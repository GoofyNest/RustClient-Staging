public sealed class CanvasRenderer : Component // TypeDefIndex: 4735
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <isMask>k__BackingField; 

	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	[NativePropertyAttribute] 
	public bool cull { get; set; }


	public void set_hasPopInstruction(bool value) { }

	public int get_materialCount() { }

	public void set_materialCount(int value) { }

	public void set_popMaterialCount(int value) { }

	public int get_absoluteDepth() { }

	public bool get_hasMoved() { }

	public bool get_cull() { }

	public void set_cull(bool value) { }

	public void SetColor(Color color) { }

	public Color GetColor() { }

	public void EnableRectClipping(Rect rect) { }

	public void DisableRectClipping() { }

	public void SetMaterial(Material material, int index) { }

	public Material GetMaterial(int index) { }

	public void SetPopMaterial(Material material, int index) { }

	public void SetTexture(Texture texture) { }

	public void SetAlphaTexture(Texture texture) { }

	public void SetMesh(Mesh mesh) { }

	public void Clear() { }

	public void SetAlpha(float alpha) { }

	public void SetMaterial(Material material, Texture texture) { }

	public Material GetMaterial() { }

	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessorAttribute] 
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] 
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] 
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	private void SetColor_Injected(ref Color color) { }

	private void GetColor_Injected(out Color ret) { }

	private void EnableRectClipping_Injected(ref Rect rect) { }

}

