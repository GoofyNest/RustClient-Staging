public class Mountain : TerrainPlacement // TypeDefIndex: 10590
{	// Fields
	public float Fade; // 0x110

	// Methods

	// RVA: 0x7BB550 Offset: 0x7B9B50 VA: 0x1807BB550
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7BA530 Offset: 0x7B8B30 VA: 0x1807BA530 Slot: 8
	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7BAA20 Offset: 0x7B9020 VA: 0x1807BAA20 Slot: 9
	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7B9F70 Offset: 0x7B8570 VA: 0x1807B9F70 Slot: 11
	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7BB0A0 Offset: 0x7B96A0 VA: 0x1807BB0A0 Slot: 12
	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x7BB7E0 Offset: 0x7B9DE0 VA: 0x1807BB7E0
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

	// RVA: 0x7CF0C0 Offset: 0x7CD6C0 VA: 0x1807CF0C0
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

	// RVA: 0x7CF490 Offset: 0x7CDA90 VA: 0x1807CF490
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

	// RVA: 0x7CFA00 Offset: 0x7CE000 VA: 0x1807CFA00
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

	// RVA: 0x7CFE30 Offset: 0x7CE430 VA: 0x1807CFE30
	internal void <ApplyTopology>b__0(int x, int z) { }

}

