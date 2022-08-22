public class Monument : TerrainPlacement // TypeDefIndex: 10584
{	// Fields
	public float Radius; // 0x110
	public float Fade; // 0x114

	// Methods

	// RVA: 0x77EA50 Offset: 0x77D050 VA: 0x18077EA50
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x77D990 Offset: 0x77BF90 VA: 0x18077D990 Slot: 8
	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77DF90 Offset: 0x77C590 VA: 0x18077DF90 Slot: 9
	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77CF70 Offset: 0x77B570 VA: 0x18077CF70 Slot: 10
	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77D450 Offset: 0x77BA50 VA: 0x18077D450 Slot: 11
	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77E570 Offset: 0x77CB70 VA: 0x18077E570 Slot: 12
	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77EB90 Offset: 0x77D190 VA: 0x18077EB90
	public void .ctor() { }

}

private sealed class Monument.<>c__DisplayClass3_0 // TypeDefIndex: 10585
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public bool useBlendMap; // 0x58
	public TextureData blenddata; // 0x60
	public Vector3 position; // 0x70
	public TextureData heightdata; // 0x80

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x77F700 Offset: 0x77DD00 VA: 0x18077F700
	internal void <ApplyHeight>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass4_0 // TypeDefIndex: 10586
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData splat0data; // 0x58
	public TextureData splat1data; // 0x68
	public bool should0; // 0x78
	public bool should1; // 0x79
	public bool should2; // 0x7A
	public bool should3; // 0x7B
	public bool should4; // 0x7C
	public bool should5; // 0x7D
	public bool should6; // 0x7E
	public bool should7; // 0x7F

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x77FB40 Offset: 0x77E140 VA: 0x18077FB40
	internal void <ApplySplat>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass5_0 // TypeDefIndex: 10587
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData alphadata; // 0x58

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x780050 Offset: 0x77E650 VA: 0x180780050
	internal void <ApplyAlpha>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass6_0 // TypeDefIndex: 10588
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData biomedata; // 0x58
	public bool should0; // 0x68
	public bool should1; // 0x69
	public bool should2; // 0x6A
	public bool should3; // 0x6B

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x780380 Offset: 0x77E980 VA: 0x180780380
	internal void <ApplyBiome>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass7_0 // TypeDefIndex: 10589
{	// Fields
	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData topologydata; // 0x58

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x780730 Offset: 0x77ED30 VA: 0x180780730
	internal void <ApplyTopology>b__0(int x, int z) { }

}

