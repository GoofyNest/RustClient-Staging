public class TerrainWaterMap : TerrainMap<short> // TypeDefIndex: 10422
{	// Fields
	public Texture2D WaterTexture; // 0x48
	private float normY; // 0x50

	// Methods

	// RVA: 0x885190 Offset: 0x883790 VA: 0x180885190 Slot: 4
	public override void Setup() { }

	// RVA: 0x883230 Offset: 0x881830 VA: 0x180883230
	public void GenerateTextures() { }

	// RVA: 0x883200 Offset: 0x881800 VA: 0x180883200
	public void ApplyTextures() { }

	// RVA: 0x8840E0 Offset: 0x8826E0 VA: 0x1808840E0
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x883DB0 Offset: 0x8823B0 VA: 0x180883DB0
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x883AD0 Offset: 0x8820D0 VA: 0x180883AD0
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x883F20 Offset: 0x882520 VA: 0x180883F20
	public float GetHeight(int x, int z) { }

	// RVA: 0x8837D0 Offset: 0x881DD0 VA: 0x1808837D0
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x883830 Offset: 0x881E30 VA: 0x180883830
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x883A80 Offset: 0x882080 VA: 0x180883A80
	public float GetHeight01(int x, int z) { }

	// RVA: 0x884410 Offset: 0x882A10 VA: 0x180884410
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x8844A0 Offset: 0x882AA0 VA: 0x1808844A0
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x8842A0 Offset: 0x8828A0 VA: 0x1808842A0
	public Vector3 GetNormalFast(Vector2 uv) { }

	// RVA: 0x884720 Offset: 0x882D20 VA: 0x180884720
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x884D80 Offset: 0x883380 VA: 0x180884D80
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x884E90 Offset: 0x883490 VA: 0x180884E90
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x884CA0 Offset: 0x8832A0 VA: 0x180884CA0
	public float GetSlope(int x, int z) { }

	// RVA: 0x884AA0 Offset: 0x8830A0 VA: 0x180884AA0
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x8849B0 Offset: 0x882FB0 VA: 0x1808849B0
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x884BC0 Offset: 0x8831C0 VA: 0x180884BC0
	public float GetSlope01(int x, int z) { }

	// RVA: 0x8833C0 Offset: 0x8819C0 VA: 0x1808833C0
	public float GetDepth(Vector3 worldPos) { }

	// RVA: 0x8835E0 Offset: 0x881BE0 VA: 0x1808835E0
	public float GetDepth(float normX, float normZ) { }

	// RVA: 0x8850A0 Offset: 0x8836A0 VA: 0x1808850A0
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x884FF0 Offset: 0x8835F0 VA: 0x180884FF0
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x884F70 Offset: 0x883570 VA: 0x180884F70
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x8854A0 Offset: 0x883AA0 VA: 0x1808854A0
	public void .ctor() { }

}

private sealed class TerrainWaterMap.<>c__DisplayClass3_0 // TypeDefIndex: 10423
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainWaterMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x890070 Offset: 0x88E670 VA: 0x180890070
	internal void <GenerateTextures>b__0(int z) { }

}

