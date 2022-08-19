public class TerrainHeightMap : TerrainMap<short> // TypeDefIndex: 10400
{	// Fields
	public Texture2D HeightTexture; // 0x48
	public Texture2D NormalTexture; // 0x50
	private float normY; // 0x58

	// Methods

	// RVA: 0x1145250 Offset: 0x1143850 VA: 0x181145250 Slot: 4
	public override void Setup() { }

	// RVA: 0x11415A0 Offset: 0x113FBA0 VA: 0x1811415A0
	public void ApplyToTerrain() { }

	// RVA: 0x1141770 Offset: 0x113FD70 VA: 0x181141770
	public void GenerateTextures(bool heightTexture = True, bool normalTexture = True) { }

	// RVA: 0x1141520 Offset: 0x113FB20 VA: 0x181141520
	public void ApplyTextures() { }

	// RVA: 0x1142090 Offset: 0x1140690 VA: 0x181142090
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x1142330 Offset: 0x1140930 VA: 0x181142330
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x1141E70 Offset: 0x1140470 VA: 0x181141E70
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x1142250 Offset: 0x1140850 VA: 0x181142250
	public float GetHeight(int x, int z) { }

	// RVA: 0x1141AB0 Offset: 0x11400B0 VA: 0x181141AB0
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x1141BF0 Offset: 0x11401F0 VA: 0x181141BF0
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x1143780 Offset: 0x1141D80 VA: 0x181143780
	public float GetTriangulatedHeight01(float normX, float normZ) { }

	// RVA: 0x883970 Offset: 0x881F70 VA: 0x180883970
	public float GetHeight01(int x, int z) { }

	// RVA: 0x883970 Offset: 0x881F70 VA: 0x180883970
	private float GetSrcHeight01(int x, int z) { }

	// RVA: 0x1141A60 Offset: 0x1140060 VA: 0x181141A60
	private float GetDstHeight01(int x, int z) { }

	// RVA: 0x1142F30 Offset: 0x1141530 VA: 0x181142F30
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x11429E0 Offset: 0x1140FE0 VA: 0x1811429E0
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x1142CA0 Offset: 0x11412A0 VA: 0x181142CA0
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x11423E0 Offset: 0x11409E0 VA: 0x1811423E0
	private Vector3 GetNormalSobel(int x, int z) { }

	// RVA: 0x1143580 Offset: 0x1141B80 VA: 0x181143580
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x11434A0 Offset: 0x1141AA0 VA: 0x1811434A0
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x11433C0 Offset: 0x11419C0 VA: 0x1811433C0
	public float GetSlope(int x, int z) { }

	// RVA: 0x11431B0 Offset: 0x11417B0 VA: 0x1811431B0
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x1143190 Offset: 0x1141790 VA: 0x181143190
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x11430B0 Offset: 0x11416B0 VA: 0x1811430B0
	public float GetSlope01(int x, int z) { }

	// RVA: 0x11448C0 Offset: 0x1142EC0 VA: 0x1811448C0
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x1144F10 Offset: 0x1143510 VA: 0x181144F10
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x884E60 Offset: 0x883460 VA: 0x180884E60
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x1144D60 Offset: 0x1143360 VA: 0x181144D60
	public void SetHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x11450E0 Offset: 0x11436E0 VA: 0x1811450E0
	public void SetHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x1145130 Offset: 0x1143730 VA: 0x181145130
	public void SetHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x1141380 Offset: 0x113F980 VA: 0x181141380
	public void AddHeight(Vector3 worldPos, float delta) { }

	// RVA: 0x1141200 Offset: 0x113F800 VA: 0x181141200
	public void AddHeight(float normX, float normZ, float delta) { }

	// RVA: 0x11410F0 Offset: 0x113F6F0 VA: 0x1811410F0
	public void AddHeight(int x, int z, float delta) { }

	// RVA: 0x1143E30 Offset: 0x1142430 VA: 0x181143E30
	public void LowerHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x1143FE0 Offset: 0x11425E0 VA: 0x181143FE0
	public void LowerHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x1143CB0 Offset: 0x11422B0 VA: 0x181143CB0
	public void LowerHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x1144590 Offset: 0x1142B90 VA: 0x181144590
	public void RaiseHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x1144270 Offset: 0x1142870 VA: 0x181144270
	public void RaiseHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x1144740 Offset: 0x1142D40 VA: 0x181144740
	public void RaiseHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x1144A90 Offset: 0x1143090 VA: 0x181144A90
	public void SetHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144FC0 Offset: 0x11435C0 VA: 0x181144FC0
	public void SetHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x11439E0 Offset: 0x1141FE0 VA: 0x1811439E0
	public void LowerHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144030 Offset: 0x1142630 VA: 0x181144030
	public void LowerHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x11442C0 Offset: 0x11428C0 VA: 0x1811442C0
	public void RaiseHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144150 Offset: 0x1142750 VA: 0x181144150
	public void RaiseHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1140ED0 Offset: 0x113F4D0 VA: 0x181140ED0
	public void AddHeight(Vector3 worldPos, float delta, float radius, float fade = 0) { }

	// RVA: 0x1141260 Offset: 0x113F860 VA: 0x181141260
	public void AddHeight(float normX, float normZ, float delta, float radius, float fade = 0) { }

	// RVA: 0x1145560 Offset: 0x1143B60 VA: 0x181145560
	public void .ctor() { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass4_0 // TypeDefIndex: 10401
{	// Fields
	public float[,] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11554F0 Offset: 0x1153AF0 VA: 0x1811554F0
	internal void <ApplyToTerrain>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_0 // TypeDefIndex: 10402
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88FF60 Offset: 0x88E560 VA: 0x18088FF60
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

	// RVA: 0x1155720 Offset: 0x1153D20 VA: 0x181155720
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

	// RVA: 0x11553C0 Offset: 0x11539C0 VA: 0x1811553C0
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

	// RVA: 0x1155410 Offset: 0x1153A10 VA: 0x181155410
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

	// RVA: 0x1155460 Offset: 0x1153A60 VA: 0x181155460
	internal void <RaiseHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass49_0 // TypeDefIndex: 10407
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float delta; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11554B0 Offset: 0x1153AB0 VA: 0x1811554B0
	internal void <AddHeight>b__0(int x, int z, float lerp) { }

}

