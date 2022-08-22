public enum PointerType // TypeDefIndex: 4028
{	// Fields
	public int value__; // 0x0
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;

}

public static class PointerType // TypeDefIndex: 4687
{	// Fields
	public static readonly string mouse; // 0x0
	public static readonly string touch; // 0x8
	public static readonly string pen; // 0x10
	public static readonly string unknown; // 0x18

	// Methods

	// RVA: 0xEB9B70 Offset: 0xEB8170 VA: 0x180EB9B70
	internal static string GetPointerType(int pointerId) { }

	// RVA: 0xEB9C40 Offset: 0xEB8240 VA: 0x180EB9C40
	internal static bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0xEB9CA0 Offset: 0xEB82A0 VA: 0x180EB9CA0
	private static void .cctor() { }

}

