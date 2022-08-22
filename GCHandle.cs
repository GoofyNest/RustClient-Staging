public struct GCHandle // TypeDefIndex: 1353
{	// Fields
	private int handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x14C540 Offset: 0x14B940 VA: 0x18014C540
	private void .ctor(IntPtr h) { }

	// RVA: 0x14C4E0 Offset: 0x14B8E0 VA: 0x18014C4E0
	private void .ctor(object obj) { }

	// RVA: 0x14C510 Offset: 0x14B910 VA: 0x18014C510
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x14C560 Offset: 0x14B960 VA: 0x18014C560
	public bool get_IsAllocated() { }

	// RVA: 0x14C570 Offset: 0x14B970 VA: 0x18014C570
	public object get_Target() { }

	// RVA: 0x14C5F0 Offset: 0x14B9F0 VA: 0x18014C5F0
	public void set_Target(object value) { }

	// RVA: 0x14C2E0 Offset: 0x14B6E0 VA: 0x18014C2E0
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0xFE7950 Offset: 0xFE5F50 VA: 0x180FE7950
	public static GCHandle Alloc(object value) { }

	// RVA: 0xFE7930 Offset: 0xFE5F30 VA: 0x180FE7930
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x14C440 Offset: 0x14B840 VA: 0x18014C440
	public void Free() { }

	// RVA: 0xFE7B80 Offset: 0xFE6180 VA: 0x180FE7B80
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0xFE7A90 Offset: 0xFE6090 VA: 0x180FE7A90
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0xFE7960 Offset: 0xFE5F60 VA: 0x180FE7960
	private static bool CheckCurrentDomain(int handle) { }

	// RVA: 0xFE7B70 Offset: 0xFE6170 VA: 0x180FE7B70
	private static object GetTarget(int handle) { }

	// RVA: 0xFE7B60 Offset: 0xFE6160 VA: 0x180FE7B60
	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	// RVA: 0xFE79F0 Offset: 0xFE5FF0 VA: 0x180FE79F0
	private static void FreeHandle(int handle) { }

	// RVA: 0xFE7B50 Offset: 0xFE6150 VA: 0x180FE7B50
	private static IntPtr GetAddrOfPinnedObject(int handle) { }

	// RVA: 0xFE7C50 Offset: 0xFE6250 VA: 0x180FE7C50
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x14C3C0 Offset: 0x14B7C0 VA: 0x18014C3C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFE7A90 Offset: 0xFE6090 VA: 0x180FE7A90
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0xFE7B80 Offset: 0xFE6180 VA: 0x180FE7B80
	public static IntPtr ToIntPtr(GCHandle value) { }

}

