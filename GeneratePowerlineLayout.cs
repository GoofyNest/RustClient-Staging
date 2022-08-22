public class GeneratePowerlineLayout : ProceduralComponent // TypeDefIndex: 10476
{	// Fields
	private const int MaxDepth = 100000;

	// Methods

	// RVA: 0xC56CB0 Offset: 0xC552B0 VA: 0x180C56CB0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BBD0 Offset: 0x57A1D0 VA: 0x18057BBD0
	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathNode // TypeDefIndex: 10477
{	// Fields
	public MonumentInfo monument; // 0x10
	public PathFinder.Node node; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathSegment // TypeDefIndex: 10478
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_0 // TypeDefIndex: 10479
{	// Fields
	public GeneratePowerlineLayout.PathSegment segment; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64BF0 Offset: 0xC631F0 VA: 0x180C64BF0
	internal bool <Process>b__4(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_1 // TypeDefIndex: 10480
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC65240 Offset: 0xC63840 VA: 0x180C65240
	internal bool <Process>b__2(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC652C0 Offset: 0xC638C0 VA: 0x180C652C0
	internal bool <Process>b__3(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_2 // TypeDefIndex: 10481
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC65340 Offset: 0xC63940 VA: 0x180C65340
	internal bool <Process>b__5(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC653C0 Offset: 0xC639C0 VA: 0x180C653C0
	internal bool <Process>b__6(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c // TypeDefIndex: 10482
{	// Fields
	public static readonly GeneratePowerlineLayout.<>c <>9; // 0x0
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_0; // 0x8
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xC657B0 Offset: 0xC63DB0 VA: 0x180C657B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64370 Offset: 0xC62970 VA: 0x180C64370
	internal PathFinder.Point <Process>b__3_0(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC64370 Offset: 0xC62970 VA: 0x180C64370
	internal PathFinder.Point <Process>b__3_1(GeneratePowerlineLayout.PathNode x) { }

}

