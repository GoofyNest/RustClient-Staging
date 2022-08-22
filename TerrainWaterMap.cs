public class TerrainWaterMap : TerrainMap<short> // TypeDefIndex: 10422
{	// Fields
	public Texture2D WaterTexture; // 0x48
	private float normY; // 0x50

	// Methods

	// RVA: 0x8684D0 Offset: 0x866AD0 VA: 0x1808684D0 Slot: 4
	public override void Setup() { }

	// RVA: 0x866570 Offset: 0x864B70 VA: 0x180866570
	public void GenerateTextures() { }

	// RVA: 0x866540 Offset: 0x864B40 VA: 0x180866540
	public void ApplyTextures() { }

	// RVA: 0x867420 Offset: 0x865A20 VA: 0x180867420
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x8670F0 Offset: 0x8656F0 VA: 0x1808670F0
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x866E10 Offset: 0x865410 VA: 0x180866E10
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x867260 Offset: 0x865860 VA: 0x180867260
	public float GetHeight(int x, int z) { }

	// RVA: 0x866B10 Offset: 0x865110 VA: 0x180866B10
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x866B70 Offset: 0x865170 VA: 0x180866B70
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x866DC0 Offset: 0x8653C0 VA: 0x180866DC0
	public float GetHeight01(int x, int z) { }

	// RVA: 0x867750 Offset: 0x865D50 VA: 0x180867750
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x8677E0 Offset: 0x865DE0 VA: 0x1808677E0
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x8675E0 Offset: 0x865BE0 VA: 0x1808675E0
	public Vector3 GetNormalFast(Vector2 uv) { }

	// RVA: 0x867A60 Offset: 0x866060 VA: 0x180867A60
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x8680C0 Offset: 0x8666C0 VA: 0x1808680C0
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x8681D0 Offset: 0x8667D0 VA: 0x1808681D0
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x867FE0 Offset: 0x8665E0 VA: 0x180867FE0
	public float GetSlope(int x, int z) { }

	// RVA: 0x867DE0 Offset: 0x8663E0 VA: 0x180867DE0
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x867CF0 Offset: 0x8662F0 VA: 0x180867CF0
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x867F00 Offset: 0x866500 VA: 0x180867F00
	public float GetSlope01(int x, int z) { }

	// RVA: 0x866700 Offset: 0x864D00 VA: 0x180866700
	public float GetDepth(Vector3 worldPos) { }

	// RVA: 0x866920 Offset: 0x864F20 VA: 0x180866920
	public float GetDepth(float normX, float normZ) { }

	// RVA: 0x8683E0 Offset: 0x8669E0 VA: 0x1808683E0
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x868330 Offset: 0x866930 VA: 0x180868330
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x8682B0 Offset: 0x8668B0 VA: 0x1808682B0
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x8687E0 Offset: 0x866DE0 VA: 0x1808687E0
	public void .ctor() { }

}

private sealed class TerrainWaterMap.<>c__DisplayClass3_0 // TypeDefIndex: 10423
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainWaterMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8733B0 Offset: 0x8719B0 VA: 0x1808733B0
	internal void <GenerateTextures>b__0(int z) { }

}

