public class TerrainAlphaMap : TerrainMap<byte> // TypeDefIndex: 10390
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCE140 Offset: 0xCD540 VA: 0x1800CE140
	public Texture2D AlphaTexture; // 0x48

	// Methods

	// RVA: 0x11380D0 Offset: 0x11366D0 VA: 0x1811380D0 Slot: 4
	public override void Setup() { }

	// RVA: 0x11373E0 Offset: 0x11359E0 VA: 0x1811373E0
	public void GenerateTextures() { }

	// RVA: 0x1137380 Offset: 0x1135980 VA: 0x181137380
	public void ApplyTextures() { }

	// RVA: 0x11375D0 Offset: 0x1135BD0 VA: 0x1811375D0
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x1137710 Offset: 0x1135D10 VA: 0x181137710
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x1137580 Offset: 0x1135B80 VA: 0x181137580
	public float GetAlpha(int x, int z) { }

	// RVA: 0x1137C10 Offset: 0x1136210 VA: 0x181137C10
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x1138020 Offset: 0x1136620 VA: 0x181138020
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1137B90 Offset: 0x1136190 VA: 0x181137B90
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x1137F00 Offset: 0x1136500 VA: 0x181137F00
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x1137960 Offset: 0x1135F60 VA: 0x181137960
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1137DE0 Offset: 0x11363E0 VA: 0x181137DE0
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x11383B0 Offset: 0x11369B0 VA: 0x1811383B0
	public void .ctor() { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass2_0 // TypeDefIndex: 10391
{	// Fields
	public TerrainAlphaMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155D90 Offset: 0x1154390 VA: 0x181155D90
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

	// RVA: 0x1155B10 Offset: 0x1154110 VA: 0x181155B10
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

