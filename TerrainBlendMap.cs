public class TerrainBlendMap : TerrainMap<byte> // TypeDefIndex: 10395
{	// Fields
	public Texture2D BlendTexture; // 0x48

	// Methods

	// RVA: 0x113C820 Offset: 0x113AE20 VA: 0x18113C820 Slot: 4
	public override void Setup() { }

	// RVA: 0x113BE80 Offset: 0x113A480 VA: 0x18113BE80
	public void GenerateTextures() { }

	// RVA: 0x1137380 Offset: 0x1135980 VA: 0x181137380
	public void ApplyTextures() { }

	// RVA: 0x113C270 Offset: 0x113A870 VA: 0x18113C270
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x113C020 Offset: 0x113A620 VA: 0x18113C020
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x1137580 Offset: 0x1135B80 VA: 0x181137580
	public float GetAlpha(int x, int z) { }

	// RVA: 0x1137C10 Offset: 0x1136210 VA: 0x181137C10
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x1138020 Offset: 0x1136620 VA: 0x181138020
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1137B90 Offset: 0x1136190 VA: 0x181137B90
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x113C700 Offset: 0x113AD00 VA: 0x18113C700
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x113C3B0 Offset: 0x113A9B0 VA: 0x18113C3B0
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113C5E0 Offset: 0x113ABE0 VA: 0x18113C5E0
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113CB00 Offset: 0x113B100 VA: 0x18113CB00
	public void .ctor() { }

}

private sealed class TerrainBlendMap.<>c__DisplayClass2_0 // TypeDefIndex: 10396
{	// Fields
	public TerrainBlendMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155D90 Offset: 0x1154390 VA: 0x181155D90
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainBlendMap.<>c__DisplayClass12_0 // TypeDefIndex: 10397
{	// Fields
	public float opacity; // 0x10
	public TerrainBlendMap <>4__this; // 0x18
	public float a; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155C50 Offset: 0x1154250 VA: 0x181155C50
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

