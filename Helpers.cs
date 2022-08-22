internal static class Helpers // TypeDefIndex: 5254
{	// Fields
	private static byte[][] BufferPool; // 0x0
	private static int BufferPoolIndex; // 0x8

	// Methods

	// RVA: 0x12856D0 Offset: 0x1283CD0 VA: 0x1812856D0
	public static Helpers.Memory TakeMemory() { }

	// RVA: 0x1285290 Offset: 0x1283890 VA: 0x181285290
	public static byte[] TakeBuffer(int minSize) { }

	// RVA: 0x12851D0 Offset: 0x12837D0 VA: 0x1812851D0
	internal static string MemoryToString(IntPtr ptr) { }

	// RVA: 0x1285720 Offset: 0x1283D20 VA: 0x181285720
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
	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	private void set_Ptr(IntPtr value) { }

	// RVA: 0x128D7C0 Offset: 0x128BDC0 VA: 0x18128D7C0
	public static IntPtr op_Implicit(in Helpers.Memory m) { }

	// RVA: 0x128D590 Offset: 0x128BB90 VA: 0x18128D590
	internal static Helpers.Memory Take() { }

	// RVA: 0x1D30C0 Offset: 0x1D24C0 VA: 0x1801D30C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x128D760 Offset: 0x128BD60 VA: 0x18128D760
	private static void .cctor() { }

}

