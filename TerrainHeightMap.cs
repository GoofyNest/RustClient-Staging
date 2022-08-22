public class TerrainHeightMap : TerrainMap<short> // TypeDefIndex: 10400
{	public Texture2D HeightTexture; // 0x48
	public Texture2D NormalTexture; // 0x50
	private float normY; // 0x58


	public override void Setup() { }

	public void ApplyToTerrain() { }

	public void GenerateTextures(bool heightTexture = True, bool normalTexture = True) { }

	public void ApplyTextures() { }

	public float GetHeight(Vector3 worldPos) { }

	public float GetHeight(float normX, float normZ) { }

	public float GetHeightFast(Vector2 uv) { }

	public float GetHeight(int x, int z) { }

	public float GetHeight01(Vector3 worldPos) { }

	public float GetHeight01(float normX, float normZ) { }

	public float GetTriangulatedHeight01(float normX, float normZ) { }

	public float GetHeight01(int x, int z) { }

	private float GetSrcHeight01(int x, int z) { }

	private float GetDstHeight01(int x, int z) { }

	public Vector3 GetNormal(Vector3 worldPos) { }

	public Vector3 GetNormal(float normX, float normZ) { }

	public Vector3 GetNormal(int x, int z) { }

	private Vector3 GetNormalSobel(int x, int z) { }

	public float GetSlope(Vector3 worldPos) { }

	public float GetSlope(float normX, float normZ) { }

	public float GetSlope(int x, int z) { }

	public float GetSlope01(Vector3 worldPos) { }

	public float GetSlope01(float normX, float normZ) { }

	public float GetSlope01(int x, int z) { }

	public void SetHeight(Vector3 worldPos, float height) { }

	public void SetHeight(float normX, float normZ, float height) { }

	public void SetHeight(int x, int z, float height) { }

	public void SetHeight(Vector3 worldPos, float height, float opacity) { }

	public void SetHeight(float normX, float normZ, float height, float opacity) { }

	public void SetHeight(int x, int z, float height, float opacity) { }

	public void AddHeight(Vector3 worldPos, float delta) { }

	public void AddHeight(float normX, float normZ, float delta) { }

	public void AddHeight(int x, int z, float delta) { }

	public void LowerHeight(Vector3 worldPos, float height, float opacity) { }

	public void LowerHeight(float normX, float normZ, float height, float opacity) { }

	public void LowerHeight(int x, int z, float height, float opacity) { }

	public void RaiseHeight(Vector3 worldPos, float height, float opacity) { }

	public void RaiseHeight(float normX, float normZ, float height, float opacity) { }

	public void RaiseHeight(int x, int z, float height, float opacity) { }

	public void SetHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	public void SetHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	public void LowerHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	public void LowerHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	public void RaiseHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	public void RaiseHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	public void AddHeight(Vector3 worldPos, float delta, float radius, float fade = 0) { }

	public void AddHeight(float normX, float normZ, float delta, float radius, float fade = 0) { }

	public void .ctor() { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass4_0 // TypeDefIndex: 10401
{	public float[,] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18


	public void .ctor() { }

	internal void <ApplyToTerrain>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_0 // TypeDefIndex: 10402
{	public Color32[] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18


	public void .ctor() { }

	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_1 // TypeDefIndex: 10403
{	public int normalres; // 0x10
	public Color32[] normals; // 0x18
	public TerrainHeightMap <>4__this; // 0x20


	public void .ctor() { }

	internal void <GenerateTextures>b__1(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass43_0 // TypeDefIndex: 10404
{	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C


	public void .ctor() { }

	internal void <SetHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass45_0 // TypeDefIndex: 10405
{	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C


	public void .ctor() { }

	internal void <LowerHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass47_0 // TypeDefIndex: 10406
{	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C


	public void .ctor() { }

	internal void <RaiseHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass49_0 // TypeDefIndex: 10407
{	public TerrainHeightMap <>4__this; // 0x10
	public float delta; // 0x18


	public void .ctor() { }

	internal void <AddHeight>b__0(int x, int z, float lerp) { }

}

