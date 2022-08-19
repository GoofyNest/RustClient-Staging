public class GeneratePowerlineLayout : ProceduralComponent // TypeDefIndex: 10476
{	// Fields
	private const int MaxDepth = 100000;

	// Methods

	// RVA: 0xC56520 Offset: 0xC54B20 VA: 0x180C56520 Slot: 5
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

	// RVA: 0xC64460 Offset: 0xC62A60 VA: 0x180C64460
	internal bool <Process>b__4(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_1 // TypeDefIndex: 10480
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64AB0 Offset: 0xC630B0 VA: 0x180C64AB0
	internal bool <Process>b__2(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC64B30 Offset: 0xC63130 VA: 0x180C64B30
	internal bool <Process>b__3(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_2 // TypeDefIndex: 10481
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC64BB0 Offset: 0xC631B0 VA: 0x180C64BB0
	internal bool <Process>b__5(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC64C30 Offset: 0xC63230 VA: 0x180C64C30
	internal bool <Process>b__6(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c // TypeDefIndex: 10482
{	// Fields
	public static readonly GeneratePowerlineLayout.<>c <>9; // 0x0
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_0; // 0x8
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xC65020 Offset: 0xC63620 VA: 0x180C65020
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC63BE0 Offset: 0xC621E0 VA: 0x180C63BE0
	internal PathFinder.Point <Process>b__3_0(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xC63BE0 Offset: 0xC621E0 VA: 0x180C63BE0
	internal PathFinder.Point <Process>b__3_1(GeneratePowerlineLayout.PathNode x) { }

}

