public struct GCHandle // TypeDefIndex: 1353
{	// Fields
	private int handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x14C5C0 Offset: 0x14B9C0 VA: 0x18014C5C0
	private void .ctor(IntPtr h) { }

	// RVA: 0x14C560 Offset: 0x14B960 VA: 0x18014C560
	private void .ctor(object obj) { }

	// RVA: 0x14C590 Offset: 0x14B990 VA: 0x18014C590
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x14C5E0 Offset: 0x14B9E0 VA: 0x18014C5E0
	public bool get_IsAllocated() { }

	// RVA: 0x14C5F0 Offset: 0x14B9F0 VA: 0x18014C5F0
	public object get_Target() { }

	// RVA: 0x14C670 Offset: 0x14BA70 VA: 0x18014C670
	public void set_Target(object value) { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0xFE7690 Offset: 0xFE5C90 VA: 0x180FE7690
	public static GCHandle Alloc(object value) { }

	// RVA: 0xFE7670 Offset: 0xFE5C70 VA: 0x180FE7670
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x14C4C0 Offset: 0x14B8C0 VA: 0x18014C4C0
	public void Free() { }

	// RVA: 0xFE78C0 Offset: 0xFE5EC0 VA: 0x180FE78C0
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0xFE77D0 Offset: 0xFE5DD0 VA: 0x180FE77D0
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0xFE76A0 Offset: 0xFE5CA0 VA: 0x180FE76A0
	private static bool CheckCurrentDomain(int handle) { }

	// RVA: 0xFE78B0 Offset: 0xFE5EB0 VA: 0x180FE78B0
	private static object GetTarget(int handle) { }

	// RVA: 0xFE78A0 Offset: 0xFE5EA0 VA: 0x180FE78A0
	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	// RVA: 0xFE7730 Offset: 0xFE5D30 VA: 0x180FE7730
	private static void FreeHandle(int handle) { }

	// RVA: 0xFE7890 Offset: 0xFE5E90 VA: 0x180FE7890
	private static IntPtr GetAddrOfPinnedObject(int handle) { }

	// RVA: 0xFE7990 Offset: 0xFE5F90 VA: 0x180FE7990
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x14C440 Offset: 0x14B840 VA: 0x18014C440 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x14C550 Offset: 0x14B950 VA: 0x18014C550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFE77D0 Offset: 0xFE5DD0 VA: 0x180FE77D0
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0xFE78C0 Offset: 0xFE5EC0 VA: 0x180FE78C0
	public static IntPtr ToIntPtr(GCHandle value) { }

}

