public class TerrainHeightMap : TerrainMap<short> // TypeDefIndex: 10400
{	// Fields
	public Texture2D HeightTexture; // 0x48
	public Texture2D NormalTexture; // 0x50
	private float normY; // 0x58

	// Methods

	// RVA: 0x1145510 Offset: 0x1143B10 VA: 0x181145510 Slot: 4
	public override void Setup() { }

	// RVA: 0x1141860 Offset: 0x113FE60 VA: 0x181141860
	public void ApplyToTerrain() { }

	// RVA: 0x1141A30 Offset: 0x1140030 VA: 0x181141A30
	public void GenerateTextures(bool heightTexture = True, bool normalTexture = True) { }

	// RVA: 0x11417E0 Offset: 0x113FDE0 VA: 0x1811417E0
	public void ApplyTextures() { }

	// RVA: 0x1142350 Offset: 0x1140950 VA: 0x181142350
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x11425F0 Offset: 0x1140BF0 VA: 0x1811425F0
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x1142130 Offset: 0x1140730 VA: 0x181142130
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x1142510 Offset: 0x1140B10 VA: 0x181142510
	public float GetHeight(int x, int z) { }

	// RVA: 0x1141D70 Offset: 0x1140370 VA: 0x181141D70
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x1141EB0 Offset: 0x11404B0 VA: 0x181141EB0
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x1143A40 Offset: 0x1142040 VA: 0x181143A40
	public float GetTriangulatedHeight01(float normX, float normZ) { }

	// RVA: 0x883A80 Offset: 0x882080 VA: 0x180883A80
	public float GetHeight01(int x, int z) { }

	// RVA: 0x883A80 Offset: 0x882080 VA: 0x180883A80
	private float GetSrcHeight01(int x, int z) { }

	// RVA: 0x1141D20 Offset: 0x1140320 VA: 0x181141D20
	private float GetDstHeight01(int x, int z) { }

	// RVA: 0x11431F0 Offset: 0x11417F0 VA: 0x1811431F0
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x1142CA0 Offset: 0x11412A0 VA: 0x181142CA0
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x1142F60 Offset: 0x1141560 VA: 0x181142F60
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x11426A0 Offset: 0x1140CA0 VA: 0x1811426A0
	private Vector3 GetNormalSobel(int x, int z) { }

	// RVA: 0x1143840 Offset: 0x1141E40 VA: 0x181143840
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x1143760 Offset: 0x1141D60 VA: 0x181143760
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x1143680 Offset: 0x1141C80 VA: 0x181143680
	public float GetSlope(int x, int z) { }

	// RVA: 0x1143470 Offset: 0x1141A70 VA: 0x181143470
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x1143450 Offset: 0x1141A50 VA: 0x181143450
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x1143370 Offset: 0x1141970 VA: 0x181143370
	public float GetSlope01(int x, int z) { }

	// RVA: 0x1144B80 Offset: 0x1143180 VA: 0x181144B80
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x11451D0 Offset: 0x11437D0 VA: 0x1811451D0
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x884F70 Offset: 0x883570 VA: 0x180884F70
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x1145020 Offset: 0x1143620 VA: 0x181145020
	public void SetHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x11453A0 Offset: 0x11439A0 VA: 0x1811453A0
	public void SetHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x11453F0 Offset: 0x11439F0 VA: 0x1811453F0
	public void SetHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x1141640 Offset: 0x113FC40 VA: 0x181141640
	public void AddHeight(Vector3 worldPos, float delta) { }

	// RVA: 0x11414C0 Offset: 0x113FAC0 VA: 0x1811414C0
	public void AddHeight(float normX, float normZ, float delta) { }

	// RVA: 0x11413B0 Offset: 0x113F9B0 VA: 0x1811413B0
	public void AddHeight(int x, int z, float delta) { }

	// RVA: 0x11440F0 Offset: 0x11426F0 VA: 0x1811440F0
	public void LowerHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x11442A0 Offset: 0x11428A0 VA: 0x1811442A0
	public void LowerHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x1143F70 Offset: 0x1142570 VA: 0x181143F70
	public void LowerHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x1144850 Offset: 0x1142E50 VA: 0x181144850
	public void RaiseHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x1144530 Offset: 0x1142B30 VA: 0x181144530
	public void RaiseHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x1144A00 Offset: 0x1143000 VA: 0x181144A00
	public void RaiseHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x1144D50 Offset: 0x1143350 VA: 0x181144D50
	public void SetHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1145280 Offset: 0x1143880 VA: 0x181145280
	public void SetHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1143CA0 Offset: 0x11422A0 VA: 0x181143CA0
	public void LowerHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x11442F0 Offset: 0x11428F0 VA: 0x1811442F0
	public void LowerHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144580 Offset: 0x1142B80 VA: 0x181144580
	public void RaiseHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144410 Offset: 0x1142A10 VA: 0x181144410
	public void RaiseHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1141190 Offset: 0x113F790 VA: 0x181141190
	public void AddHeight(Vector3 worldPos, float delta, float radius, float fade = 0) { }

	// RVA: 0x1141520 Offset: 0x113FB20 VA: 0x181141520
	public void AddHeight(float normX, float normZ, float delta, float radius, float fade = 0) { }

	// RVA: 0x1145820 Offset: 0x1143E20 VA: 0x181145820
	public void .ctor() { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass4_0 // TypeDefIndex: 10401
{	// Fields
	public float[,] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11557B0 Offset: 0x1153DB0 VA: 0x1811557B0
	internal void <ApplyToTerrain>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_0 // TypeDefIndex: 10402
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x890070 Offset: 0x88E670 VA: 0x180890070
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_1 // TypeDefIndex: 10403
{	// Fields
	public int normalres; // 0x10
	public Color32[] normals; // 0x18
	public TerrainHeightMap <>4__this; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11559E0 Offset: 0x1153FE0 VA: 0x1811559E0
	internal void <GenerateTextures>b__1(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass43_0 // TypeDefIndex: 10404
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155680 Offset: 0x1153C80 VA: 0x181155680
	internal void <SetHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass45_0 // TypeDefIndex: 10405
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11556D0 Offset: 0x1153CD0 VA: 0x1811556D0
	internal void <LowerHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass47_0 // TypeDefIndex: 10406
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155720 Offset: 0x1153D20 VA: 0x181155720
	internal void <RaiseHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass49_0 // TypeDefIndex: 10407
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float delta; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155770 Offset: 0x1153D70 VA: 0x181155770
	internal void <AddHeight>b__0(int x, int z, float lerp) { }

}

