public class TerrainHeightMap : TerrainMap<short> // TypeDefIndex: 10400
{	// Fields
	public Texture2D HeightTexture; // 0x48
	public Texture2D NormalTexture; // 0x50
	private float normY; // 0x58

	// Methods

	// RVA: 0x1145F80 Offset: 0x1144580 VA: 0x181145F80 Slot: 4
	public override void Setup() { }

	// RVA: 0x11422D0 Offset: 0x11408D0 VA: 0x1811422D0
	public void ApplyToTerrain() { }

	// RVA: 0x11424A0 Offset: 0x1140AA0 VA: 0x1811424A0
	public void GenerateTextures(bool heightTexture = True, bool normalTexture = True) { }

	// RVA: 0x1142250 Offset: 0x1140850 VA: 0x181142250
	public void ApplyTextures() { }

	// RVA: 0x1142DC0 Offset: 0x11413C0 VA: 0x181142DC0
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x1143060 Offset: 0x1141660 VA: 0x181143060
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x1142BA0 Offset: 0x11411A0 VA: 0x181142BA0
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x1142F80 Offset: 0x1141580 VA: 0x181142F80
	public float GetHeight(int x, int z) { }

	// RVA: 0x11427E0 Offset: 0x1140DE0 VA: 0x1811427E0
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x1142920 Offset: 0x1140F20 VA: 0x181142920
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x11444B0 Offset: 0x1142AB0 VA: 0x1811444B0
	public float GetTriangulatedHeight01(float normX, float normZ) { }

	// RVA: 0x866DC0 Offset: 0x8653C0 VA: 0x180866DC0
	public float GetHeight01(int x, int z) { }

	// RVA: 0x866DC0 Offset: 0x8653C0 VA: 0x180866DC0
	private float GetSrcHeight01(int x, int z) { }

	// RVA: 0x1142790 Offset: 0x1140D90 VA: 0x181142790
	private float GetDstHeight01(int x, int z) { }

	// RVA: 0x1143C60 Offset: 0x1142260 VA: 0x181143C60
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x1143710 Offset: 0x1141D10 VA: 0x181143710
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x11439D0 Offset: 0x1141FD0 VA: 0x1811439D0
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x1143110 Offset: 0x1141710 VA: 0x181143110
	private Vector3 GetNormalSobel(int x, int z) { }

	// RVA: 0x11442B0 Offset: 0x11428B0 VA: 0x1811442B0
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x11441D0 Offset: 0x11427D0 VA: 0x1811441D0
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x11440F0 Offset: 0x11426F0 VA: 0x1811440F0
	public float GetSlope(int x, int z) { }

	// RVA: 0x1143EE0 Offset: 0x11424E0 VA: 0x181143EE0
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x1143EC0 Offset: 0x11424C0 VA: 0x181143EC0
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x1143DE0 Offset: 0x11423E0 VA: 0x181143DE0
	public float GetSlope01(int x, int z) { }

	// RVA: 0x11455F0 Offset: 0x1143BF0 VA: 0x1811455F0
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x1145C40 Offset: 0x1144240 VA: 0x181145C40
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x8682B0 Offset: 0x8668B0 VA: 0x1808682B0
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x1145A90 Offset: 0x1144090 VA: 0x181145A90
	public void SetHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x1145E10 Offset: 0x1144410 VA: 0x181145E10
	public void SetHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x1145E60 Offset: 0x1144460 VA: 0x181145E60
	public void SetHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x11420B0 Offset: 0x11406B0 VA: 0x1811420B0
	public void AddHeight(Vector3 worldPos, float delta) { }

	// RVA: 0x1141F30 Offset: 0x1140530 VA: 0x181141F30
	public void AddHeight(float normX, float normZ, float delta) { }

	// RVA: 0x1141E20 Offset: 0x1140420 VA: 0x181141E20
	public void AddHeight(int x, int z, float delta) { }

	// RVA: 0x1144B60 Offset: 0x1143160 VA: 0x181144B60
	public void LowerHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x1144D10 Offset: 0x1143310 VA: 0x181144D10
	public void LowerHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x11449E0 Offset: 0x1142FE0 VA: 0x1811449E0
	public void LowerHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x11452C0 Offset: 0x11438C0 VA: 0x1811452C0
	public void RaiseHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x1144FA0 Offset: 0x11435A0 VA: 0x181144FA0
	public void RaiseHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x1145470 Offset: 0x1143A70 VA: 0x181145470
	public void RaiseHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x11457C0 Offset: 0x1143DC0 VA: 0x1811457C0
	public void SetHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1145CF0 Offset: 0x11442F0 VA: 0x181145CF0
	public void SetHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144710 Offset: 0x1142D10 VA: 0x181144710
	public void LowerHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144D60 Offset: 0x1143360 VA: 0x181144D60
	public void LowerHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144FF0 Offset: 0x11435F0 VA: 0x181144FF0
	public void RaiseHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1144E80 Offset: 0x1143480 VA: 0x181144E80
	public void RaiseHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1141C00 Offset: 0x1140200 VA: 0x181141C00
	public void AddHeight(Vector3 worldPos, float delta, float radius, float fade = 0) { }

	// RVA: 0x1141F90 Offset: 0x1140590 VA: 0x181141F90
	public void AddHeight(float normX, float normZ, float delta, float radius, float fade = 0) { }

	// RVA: 0x1146290 Offset: 0x1144890 VA: 0x181146290
	public void .ctor() { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass4_0 // TypeDefIndex: 10401
{	// Fields
	public float[,] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1156220 Offset: 0x1154820 VA: 0x181156220
	internal void <ApplyToTerrain>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_0 // TypeDefIndex: 10402
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8733B0 Offset: 0x8719B0 VA: 0x1808733B0
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

	// RVA: 0x1156450 Offset: 0x1154A50 VA: 0x181156450
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

	// RVA: 0x11560F0 Offset: 0x11546F0 VA: 0x1811560F0
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

	// RVA: 0x1156140 Offset: 0x1154740 VA: 0x181156140
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

	// RVA: 0x1156190 Offset: 0x1154790 VA: 0x181156190
	internal void <RaiseHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass49_0 // TypeDefIndex: 10407
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float delta; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11561E0 Offset: 0x11547E0 VA: 0x1811561E0
	internal void <AddHeight>b__0(int x, int z, float lerp) { }

}

