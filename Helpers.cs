internal static class Helpers // TypeDefIndex: 5254
{	// Fields
	private static byte[][] BufferPool; // 0x0
	private static int BufferPoolIndex; // 0x8

	// Methods

	// RVA: 0x1286030 Offset: 0x1284630 VA: 0x181286030
	public static Helpers.Memory TakeMemory() { }

	// RVA: 0x1285BF0 Offset: 0x12841F0 VA: 0x181285BF0
	public static byte[] TakeBuffer(int minSize) { }

	// RVA: 0x1285B30 Offset: 0x1284130 VA: 0x181285B30
	internal static string MemoryToString(IntPtr ptr) { }

	// RVA: 0x1286080 Offset: 0x1284680 VA: 0x181286080
	private static void .cctor() { }

}

internal struct Helpers.Memory : IDisposable // TypeDefIndex: 5255
{	// Fields
	private static readonly Queue<IntPtr> BufferBag; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IntPtr <Ptr>k__BackingField; // 0x0

	// Properties
	public IntPtr Ptr { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IntPtr get_Ptr() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	private void set_Ptr(IntPtr value) { }

	// RVA: 0x128E120 Offset: 0x128C720 VA: 0x18128E120
	public static IntPtr op_Implicit(in Helpers.Memory m) { }

	// RVA: 0x128DEF0 Offset: 0x128C4F0 VA: 0x18128DEF0
	internal static Helpers.Memory Take() { }

	// RVA: 0x1D3730 Offset: 0x1D2B30 VA: 0x1801D3730 Slot: 4
	public void Dispose() { }

	// RVA: 0x128E0C0 Offset: 0x128C6C0 VA: 0x18128E0C0
	private static void .cctor() { }

}

