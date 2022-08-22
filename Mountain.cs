public class Mountain : TerrainPlacement // TypeDefIndex: 10590
{	// Fields
	public float Fade; // 0x110

	// Methods

	// RVA: 0x7BB660 Offset: 0x7B9C60 VA: 0x1807BB660
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7BA640 Offset: 0x7B8C40 VA: 0x1807BA640 Slot: 8
	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7BAB30 Offset: 0x7B9130 VA: 0x1807BAB30 Slot: 9
	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7BA080 Offset: 0x7B8680 VA: 0x1807BA080 Slot: 11
	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7BB1B0 Offset: 0x7B97B0 VA: 0x1807BB1B0 Slot: 12
	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7BB8F0 Offset: 0x7B9EF0 VA: 0x1807BB8F0
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

	// RVA: 0x7CF1D0 Offset: 0x7CD7D0 VA: 0x1807CF1D0
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

	// RVA: 0x7CF5A0 Offset: 0x7CDBA0 VA: 0x1807CF5A0
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

	// RVA: 0x7CFB10 Offset: 0x7CE110 VA: 0x1807CFB10
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

	// RVA: 0x7CFF40 Offset: 0x7CE540 VA: 0x1807CFF40
	internal void <ApplyTopology>b__0(int x, int z) { }

}

