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

	// RVA: 0xEB90C0 Offset: 0xEB76C0 VA: 0x180EB90C0
	internal static string GetPointerType(int pointerId) { }

	// RVA: 0xEB9190 Offset: 0xEB7790 VA: 0x180EB9190
	internal static bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0xEB91F0 Offset: 0xEB77F0 VA: 0x180EB91F0
	private static void .cctor() { }

}

