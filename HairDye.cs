public class HairDye // TypeDefIndex: 10729
{	// Fields
	[ColorUsageAttribute] // RVA: 0x768B0 Offset: 0x75CB0 VA: 0x1800768B0
	public Color capBaseColor; // 0x10
	public Material sourceMaterial; // 0x20
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public HairDye.CopyPropertyMask copyProperties; // 0x28
	private static MaterialPropertyDesc[] transferableProps; // 0x0
	private static int _HairBaseColorUV1; // 0x8
	private static int _HairBaseColorUV2; // 0xC
	private static int _HairPackedMapUV1; // 0x10
	private static int _HairPackedMapUV2; // 0x14

	// Methods

	// RVA: 0x734450 Offset: 0x732A50 VA: 0x180734450
	public void Apply(HairDyeCollection collection, MaterialPropertyBlock block) { }

	// RVA: 0x734280 Offset: 0x732880 VA: 0x180734280
	public void ApplyCap(HairDyeCollection collection, HairType type, MaterialPropertyBlock block) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x734670 Offset: 0x732C70 VA: 0x180734670
	private static void .cctor() { }

}

public enum HairDye.CopyProperty // TypeDefIndex: 10730
{	// Fields
	public int value__; // 0x0
	public const HairDye.CopyProperty DyeColor = 0;
	public const HairDye.CopyProperty RootColor = 1;
	public const HairDye.CopyProperty TipColor = 2;
	public const HairDye.CopyProperty Brightness = 3;
	public const HairDye.CopyProperty DyeRoughness = 4;
	public const HairDye.CopyProperty DyeScatter = 5;
	public const HairDye.CopyProperty Specular = 6;
	public const HairDye.CopyProperty Roughness = 7;
	public const HairDye.CopyProperty Count = 8;

}

public enum HairDye.CopyPropertyMask // TypeDefIndex: 10731
{	// Fields
	public int value__; // 0x0
	public const HairDye.CopyPropertyMask DyeColor = 1;
	public const HairDye.CopyPropertyMask RootColor = 2;
	public const HairDye.CopyPropertyMask TipColor = 4;
	public const HairDye.CopyPropertyMask Brightness = 8;
	public const HairDye.CopyPropertyMask DyeRoughness = 16;
	public const HairDye.CopyPropertyMask DyeScatter = 32;
	public const HairDye.CopyPropertyMask Specular = 64;
	public const HairDye.CopyPropertyMask Roughness = 128;

}

