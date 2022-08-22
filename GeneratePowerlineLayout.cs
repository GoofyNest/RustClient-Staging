public class GeneratePowerlineLayout : ProceduralComponent // TypeDefIndex: 10476
{	// Fields
	private const int MaxDepth = 100000;

	// Methods

	// RVA: 0xC567E0 Offset: 0xC54DE0 VA: 0x180C567E0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BC40 Offset: 0x57A240 VA: 0x18057BC40
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

	// RVA: 0xC64720 Offset: 0xC62D20 VA: 0x180C64720
	internal bool <Process>b__4(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_1 // TypeDefIndex: 10480
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64D70 Offset: 0xC63370 VA: 0x180C64D70
	internal bool <Process>b__2(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC64DF0 Offset: 0xC633F0 VA: 0x180C64DF0
	internal bool <Process>b__3(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_2 // TypeDefIndex: 10481
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64E70 Offset: 0xC63470 VA: 0x180C64E70
	internal bool <Process>b__5(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC64EF0 Offset: 0xC634F0 VA: 0x180C64EF0
	internal bool <Process>b__6(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c // TypeDefIndex: 10482
{	// Fields
	public static readonly GeneratePowerlineLayout.<>c <>9; // 0x0
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_0; // 0x8
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xC652E0 Offset: 0xC638E0 VA: 0x180C652E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC63EA0 Offset: 0xC624A0 VA: 0x180C63EA0
	internal PathFinder.Point <Process>b__3_0(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC63EA0 Offset: 0xC624A0 VA: 0x180C63EA0
	internal PathFinder.Point <Process>b__3_1(GeneratePowerlineLayout.PathNode x) { }

}

