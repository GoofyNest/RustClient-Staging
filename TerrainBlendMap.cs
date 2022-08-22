public class TerrainBlendMap : TerrainMap<byte> // TypeDefIndex: 10395
{	// Fields
	public Texture2D BlendTexture; // 0x48

	// Methods

	// RVA: 0x113BDB0 Offset: 0x113A3B0 VA: 0x18113BDB0 Slot: 4
	public override void Setup() { }

	// RVA: 0x113B410 Offset: 0x1139A10 VA: 0x18113B410
	public void GenerateTextures() { }

	// RVA: 0x1136910 Offset: 0x1134F10 VA: 0x181136910
	public void ApplyTextures() { }

	// RVA: 0x113B800 Offset: 0x1139E00 VA: 0x18113B800
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x113B5B0 Offset: 0x1139BB0 VA: 0x18113B5B0
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x1136B10 Offset: 0x1135110 VA: 0x181136B10
	public float GetAlpha(int x, int z) { }

	// RVA: 0x11371A0 Offset: 0x11357A0 VA: 0x1811371A0
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x11375B0 Offset: 0x1135BB0 VA: 0x1811375B0
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1137120 Offset: 0x1135720 VA: 0x181137120
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x113BC90 Offset: 0x113A290 VA: 0x18113BC90
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x113B940 Offset: 0x1139F40 VA: 0x18113B940
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113BB70 Offset: 0x113A170 VA: 0x18113BB70
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113C090 Offset: 0x113A690 VA: 0x18113C090
	public void .ctor() { }

}

private sealed class TerrainBlendMap.<>c__DisplayClass2_0 // TypeDefIndex: 10396
{	// Fields
	public TerrainBlendMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155320 Offset: 0x1153920 VA: 0x181155320
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

	// RVA: 0x11551E0 Offset: 0x11537E0 VA: 0x1811551E0
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

