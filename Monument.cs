public class Monument : TerrainPlacement // TypeDefIndex: 10584
{	// Fields
	public float Radius; // 0x110
	public float Fade; // 0x114

	// Methods

	// RVA: 0x77E940 Offset: 0x77CF40 VA: 0x18077E940
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x77D880 Offset: 0x77BE80 VA: 0x18077D880 Slot: 8
	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77DE80 Offset: 0x77C480 VA: 0x18077DE80 Slot: 9
	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77CE60 Offset: 0x77B460 VA: 0x18077CE60 Slot: 10
	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77D340 Offset: 0x77B940 VA: 0x18077D340 Slot: 11
	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77E460 Offset: 0x77CA60 VA: 0x18077E460 Slot: 12
	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x77EA80 Offset: 0x77D080 VA: 0x18077EA80
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

	// RVA: 0x77F5F0 Offset: 0x77DBF0 VA: 0x18077F5F0
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

	// RVA: 0x77FA30 Offset: 0x77E030 VA: 0x18077FA30
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

	// RVA: 0x77FF40 Offset: 0x77E540 VA: 0x18077FF40
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

	// RVA: 0x780270 Offset: 0x77E870 VA: 0x180780270
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

	// RVA: 0x780620 Offset: 0x77EC20 VA: 0x180780620
	internal void <ApplyTopology>b__0(int x, int z) { }

}

