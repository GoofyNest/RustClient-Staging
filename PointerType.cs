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

	// RVA: 0xEB8E00 Offset: 0xEB7400 VA: 0x180EB8E00
	internal static string GetPointerType(int pointerId) { }

	// RVA: 0xEB8ED0 Offset: 0xEB74D0 VA: 0x180EB8ED0
	internal static bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0xEB8F30 Offset: 0xEB7530 VA: 0x180EB8F30
	private static void .cctor() { }

}

