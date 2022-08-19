public class TerrainBlendMap : TerrainMap<byte> // TypeDefIndex: 10395
{	// Fields
	public Texture2D BlendTexture; // 0x48

	// Methods

	// RVA: 0x113BAF0 Offset: 0x113A0F0 VA: 0x18113BAF0 Slot: 4
	public override void Setup() { }

	// RVA: 0x113B150 Offset: 0x1139750 VA: 0x18113B150
	public void GenerateTextures() { }

	// RVA: 0x1136650 Offset: 0x1134C50 VA: 0x181136650
	public void ApplyTextures() { }

	// RVA: 0x113B540 Offset: 0x1139B40 VA: 0x18113B540
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x113B2F0 Offset: 0x11398F0 VA: 0x18113B2F0
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x1136850 Offset: 0x1134E50 VA: 0x181136850
	public float GetAlpha(int x, int z) { }

	// RVA: 0x1136EE0 Offset: 0x11354E0 VA: 0x181136EE0
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x11372F0 Offset: 0x11358F0 VA: 0x1811372F0
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1136E60 Offset: 0x1135460 VA: 0x181136E60
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x113B9D0 Offset: 0x1139FD0 VA: 0x18113B9D0
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x113B680 Offset: 0x1139C80 VA: 0x18113B680
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113B8B0 Offset: 0x1139EB0 VA: 0x18113B8B0
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113BDD0 Offset: 0x113A3D0 VA: 0x18113BDD0
	public void .ctor() { }

}

private sealed class TerrainBlendMap.<>c__DisplayClass2_0 // TypeDefIndex: 10396
{	// Fields
	public TerrainBlendMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155060 Offset: 0x1153660 VA: 0x181155060
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

	// RVA: 0x1154F20 Offset: 0x1153520 VA: 0x181154F20
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

