public class Mountain : TerrainPlacement // TypeDefIndex: 10590
{	// Fields
	public float Fade; // 0x110

	// Methods

	// RVA: 0x7D9A50 Offset: 0x7D8050 VA: 0x1807D9A50
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7D8A30 Offset: 0x7D7030 VA: 0x1807D8A30 Slot: 8
	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7D8F20 Offset: 0x7D7520 VA: 0x1807D8F20 Slot: 9
	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7D8470 Offset: 0x7D6A70 VA: 0x1807D8470 Slot: 11
	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7D95A0 Offset: 0x7D7BA0 VA: 0x1807D95A0 Slot: 12
	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7D9CE0 Offset: 0x7D82E0 VA: 0x1807D9CE0
	public void .ctor() { }

}

private sealed class Mountain.<>c__DisplayClass2_0 // TypeDefIndex: 10591
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7ED5C0 Offset: 0x7EBBC0 VA: 0x1807ED5C0
	internal void <ApplyHeight>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass3_0 // TypeDefIndex: 10592
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68
	public TextureData splat0data; // 0x78
	public TextureData splat1data; // 0x88
	public bool should0; // 0x98
	public bool should1; // 0x99
	public bool should2; // 0x9A
	public bool should3; // 0x9B
	public bool should4; // 0x9C
	public bool should5; // 0x9D
	public bool should6; // 0x9E
	public bool should7; // 0x9F

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7ED990 Offset: 0x7EBF90 VA: 0x1807ED990
	internal void <ApplySplat>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass5_0 // TypeDefIndex: 10593
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68
	public TextureData biomedata; // 0x78
	public bool should0; // 0x88
	public bool should1; // 0x89
	public bool should2; // 0x8A
	public bool should3; // 0x8B

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EDF00 Offset: 0x7EC500 VA: 0x1807EDF00
	internal void <ApplyBiome>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass6_0 // TypeDefIndex: 10594
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public TextureData topologydata; // 0x58

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal void <ApplyTopology>b__0(int x, int z) { }

}

