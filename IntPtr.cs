public struct IntPtr : ISerializable // TypeDefIndex: 369
{	// Fields
	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x1E00C0 Offset: 0x1DF4C0 VA: 0x1801E00C0
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[ReliabilityContractAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	public void .ctor(void* value) { }

	// RVA: 0x1FBB30 Offset: 0x1FAF30 VA: 0x1801FBB30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x8C0E00 Offset: 0x8BF400 VA: 0x1808C0E00
	public static int get_Size() { }

	// RVA: 0x1FBA20 Offset: 0x1FAE20 VA: 0x1801FBA20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1FB990 Offset: 0x1FAD90 VA: 0x1801FB990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1FBAB0 Offset: 0x1FAEB0 VA: 0x1801FBAB0
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public void* ToPointer() { }

	// RVA: 0x1FBAC0 Offset: 0x1FAEC0 VA: 0x1801FBAC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FBAF0 Offset: 0x1FAEF0 VA: 0x1801FBAF0
	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x12A4450 Offset: 0x12A2A50 VA: 0x1812A4450
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x145B7B0 Offset: 0x1459DB0 VA: 0x18145B7B0
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[ReliabilityContractAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0xEC1660 Offset: 0xEBFC60 VA: 0x180EC1660
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820
	internal bool IsNull() { }

}

