public class TerrainAlphaMap : TerrainMap<byte> // TypeDefIndex: 10390
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCE060 Offset: 0xCD460 VA: 0x1800CE060
	public Texture2D AlphaTexture; // 0x48

	// Methods

	// RVA: 0x11373A0 Offset: 0x11359A0 VA: 0x1811373A0 Slot: 4
	public override void Setup() { }

	// RVA: 0x11366B0 Offset: 0x1134CB0 VA: 0x1811366B0
	public void GenerateTextures() { }

	// RVA: 0x1136650 Offset: 0x1134C50 VA: 0x181136650
	public void ApplyTextures() { }

	// RVA: 0x11368A0 Offset: 0x1134EA0 VA: 0x1811368A0
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x11369E0 Offset: 0x1134FE0 VA: 0x1811369E0
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x1136850 Offset: 0x1134E50 VA: 0x181136850
	public float GetAlpha(int x, int z) { }

	// RVA: 0x1136EE0 Offset: 0x11354E0 VA: 0x181136EE0
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x11372F0 Offset: 0x11358F0 VA: 0x1811372F0
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1136E60 Offset: 0x1135460 VA: 0x181136E60
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x11371D0 Offset: 0x11357D0 VA: 0x1811371D0
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x1136C30 Offset: 0x1135230 VA: 0x181136C30
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x11370B0 Offset: 0x11356B0 VA: 0x1811370B0
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1137680 Offset: 0x1135C80 VA: 0x181137680
	public void .ctor() { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass2_0 // TypeDefIndex: 10391
{	// Fields
	public TerrainAlphaMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1155060 Offset: 0x1153660 VA: 0x181155060
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

	// RVA: 0x1154DE0 Offset: 0x11533E0 VA: 0x181154DE0
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

