public class TerrainAlphaMap : TerrainMap<byte> // TypeDefIndex: 10390
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCE140 Offset: 0xCD540 VA: 0x1800CE140
	public Texture2D AlphaTexture; // 0x48

	// Methods

	// RVA: 0x1137660 Offset: 0x1135C60 VA: 0x181137660 Slot: 4
	public override void Setup() { }

	// RVA: 0x1136970 Offset: 0x1134F70 VA: 0x181136970
	public void GenerateTextures() { }

	// RVA: 0x1136910 Offset: 0x1134F10 VA: 0x181136910
	public void ApplyTextures() { }

	// RVA: 0x1136B60 Offset: 0x1135160 VA: 0x181136B60
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x1136CA0 Offset: 0x11352A0 VA: 0x181136CA0
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x1136B10 Offset: 0x1135110 VA: 0x181136B10
	public float GetAlpha(int x, int z) { }

	// RVA: 0x11371A0 Offset: 0x11357A0 VA: 0x1811371A0
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x11375B0 Offset: 0x1135BB0 VA: 0x1811375B0
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1137120 Offset: 0x1135720 VA: 0x181137120
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x1137490 Offset: 0x1135A90 VA: 0x181137490
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x1136EF0 Offset: 0x11354F0 VA: 0x181136EF0
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1137370 Offset: 0x1135970 VA: 0x181137370
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1137940 Offset: 0x1135F40 VA: 0x181137940
	public void .ctor() { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass2_0 // TypeDefIndex: 10391
{	// Fields
	public TerrainAlphaMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155320 Offset: 0x1153920 VA: 0x181155320
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass12_0 // TypeDefIndex: 10392
{	// Fields
	public float opacity; // 0x10
	public TerrainAlphaMap <>4__this; // 0x18
	public float a; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11550A0 Offset: 0x11536A0 VA: 0x1811550A0
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

