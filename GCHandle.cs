public struct GCHandle // TypeDefIndex: 1353
{	// Fields
	private int handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360
	private void .ctor(IntPtr h) { }

	// RVA: 0x14C300 Offset: 0x14B700 VA: 0x18014C300
	private void .ctor(object obj) { }

	// RVA: 0x14C330 Offset: 0x14B730 VA: 0x18014C330
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x14C380 Offset: 0x14B780 VA: 0x18014C380
	public bool get_IsAllocated() { }

	// RVA: 0x14C390 Offset: 0x14B790 VA: 0x18014C390
	public object get_Target() { }

	// RVA: 0x14C410 Offset: 0x14B810 VA: 0x18014C410
	public void set_Target(object value) { }

	// RVA: 0x14C100 Offset: 0x14B500 VA: 0x18014C100
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0xFE83F0 Offset: 0xFE69F0 VA: 0x180FE83F0
	public static GCHandle Alloc(object value) { }

	// RVA: 0xFE83D0 Offset: 0xFE69D0 VA: 0x180FE83D0
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x14C260 Offset: 0x14B660 VA: 0x18014C260
	public void Free() { }

	// RVA: 0xFE8620 Offset: 0xFE6C20 VA: 0x180FE8620
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0xFE8530 Offset: 0xFE6B30 VA: 0x180FE8530
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0xFE8400 Offset: 0xFE6A00 VA: 0x180FE8400
	private static bool CheckCurrentDomain(int handle) { }

	// RVA: 0xFE8610 Offset: 0xFE6C10 VA: 0x180FE8610
	private static object GetTarget(int handle) { }

	// RVA: 0xFE8600 Offset: 0xFE6C00 VA: 0x180FE8600
	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	// RVA: 0xFE8490 Offset: 0xFE6A90 VA: 0x180FE8490
	private static void FreeHandle(int handle) { }

	// RVA: 0xFE85F0 Offset: 0xFE6BF0 VA: 0x180FE85F0
	private static IntPtr GetAddrOfPinnedObject(int handle) { }

	// RVA: 0xFE86F0 Offset: 0xFE6CF0 VA: 0x180FE86F0
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x14C1E0 Offset: 0x14B5E0 VA: 0x18014C1E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x14C2F0 Offset: 0x14B6F0 VA: 0x18014C2F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFE8530 Offset: 0xFE6B30 VA: 0x180FE8530
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0xFE8620 Offset: 0xFE6C20 VA: 0x180FE8620
	public static IntPtr ToIntPtr(GCHandle value) { }

}

