public struct IntPtr : ISerializable // TypeDefIndex: 369
{	// Fields
	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x1E0800 Offset: 0x1DFC00 VA: 0x1801E0800
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[ReliabilityContractAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	public void .ctor(void* value) { }

	// RVA: 0x1FB760 Offset: 0x1FAB60 VA: 0x1801FB760
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310
	public static int get_Size() { }

	// RVA: 0x1FB650 Offset: 0x1FAA50 VA: 0x1801FB650 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1FB5C0 Offset: 0x1FA9C0 VA: 0x1801FB5C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1FB6E0 Offset: 0x1FAAE0 VA: 0x1801FB6E0
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public void* ToPointer() { }

	// RVA: 0x1FB6F0 Offset: 0x1FAAF0 VA: 0x1801FB6F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB720 Offset: 0x1FAB20 VA: 0x1801FB720
	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x12A4AF0 Offset: 0x12A30F0 VA: 0x1812A4AF0
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x145A880 Offset: 0x1458E80 VA: 0x18145A880
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[ReliabilityContractAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0xEC2110 Offset: 0xEC0710 VA: 0x180EC2110
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820
	internal bool IsNull() { }

}

