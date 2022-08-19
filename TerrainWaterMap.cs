public class TerrainWaterMap : TerrainMap<short> // TypeDefIndex: 10422
{	// Fields
	public Texture2D WaterTexture; // 0x48
	private float normY; // 0x50

	// Methods

	// RVA: 0x885080 Offset: 0x883680 VA: 0x180885080 Slot: 4
	public override void Setup() { }

	// RVA: 0x883120 Offset: 0x881720 VA: 0x180883120
	public void GenerateTextures() { }

	// RVA: 0x8830F0 Offset: 0x8816F0 VA: 0x1808830F0
	public void ApplyTextures() { }

	// RVA: 0x883FD0 Offset: 0x8825D0 VA: 0x180883FD0
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x883CA0 Offset: 0x8822A0 VA: 0x180883CA0
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x8839C0 Offset: 0x881FC0 VA: 0x1808839C0
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x883E10 Offset: 0x882410 VA: 0x180883E10
	public float GetHeight(int x, int z) { }

	// RVA: 0x8836C0 Offset: 0x881CC0 VA: 0x1808836C0
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x883720 Offset: 0x881D20 VA: 0x180883720
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x883970 Offset: 0x881F70 VA: 0x180883970
	public float GetHeight01(int x, int z) { }

	// RVA: 0x884300 Offset: 0x882900 VA: 0x180884300
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x884390 Offset: 0x882990 VA: 0x180884390
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x884190 Offset: 0x882790 VA: 0x180884190
	public Vector3 GetNormalFast(Vector2 uv) { }

	// RVA: 0x884610 Offset: 0x882C10 VA: 0x180884610
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x884C70 Offset: 0x883270 VA: 0x180884C70
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x884D80 Offset: 0x883380 VA: 0x180884D80
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x884B90 Offset: 0x883190 VA: 0x180884B90
	public float GetSlope(int x, int z) { }

	// RVA: 0x884990 Offset: 0x882F90 VA: 0x180884990
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x8848A0 Offset: 0x882EA0 VA: 0x1808848A0
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x884AB0 Offset: 0x8830B0 VA: 0x180884AB0
	public float GetSlope01(int x, int z) { }

	// RVA: 0x8832B0 Offset: 0x8818B0 VA: 0x1808832B0
	public float GetDepth(Vector3 worldPos) { }

	// RVA: 0x8834D0 Offset: 0x881AD0 VA: 0x1808834D0
	public float GetDepth(float normX, float normZ) { }

	// RVA: 0x884F90 Offset: 0x883590 VA: 0x180884F90
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x884EE0 Offset: 0x8834E0 VA: 0x180884EE0
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x884E60 Offset: 0x883460 VA: 0x180884E60
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x885390 Offset: 0x883990 VA: 0x180885390
	public void .ctor() { }

}

private sealed class TerrainWaterMap.<>c__DisplayClass3_0 // TypeDefIndex: 10423
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainWaterMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88FF60 Offset: 0x88E560 VA: 0x18088FF60
	internal void <GenerateTextures>b__0(int z) { }

}

