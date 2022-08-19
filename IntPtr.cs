public struct IntPtr : ISerializable // TypeDefIndex: 369
{	// Fields
	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x8D660 Offset: 0x8CA60 VA: 0x18008D660
	// RVA: 0x1E0140 Offset: 0x1DF540 VA: 0x1801E0140
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D660 Offset: 0x8CA60 VA: 0x18008D660
	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8B0 Offset: 0x8CCB0 VA: 0x18008D8B0
	[ReliabilityContractAttribute] // RVA: 0x8D8B0 Offset: 0x8CCB0 VA: 0x18008D8B0
	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	public void .ctor(void* value) { }

	// RVA: 0x1FBBB0 Offset: 0x1FAFB0 VA: 0x1801FBBB0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0
	public static int get_Size() { }

	// RVA: 0x1FBAA0 Offset: 0x1FAEA0 VA: 0x1801FBAA0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1FBA10 Offset: 0x1FAE10 VA: 0x1801FBA10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1FBB30 Offset: 0x1FAF30 VA: 0x1801FBB30
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D810 Offset: 0x7CC10 VA: 0x18007D810
	[CLSCompliantAttribute] // RVA: 0x7D810 Offset: 0x7CC10 VA: 0x18007D810
	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public void* ToPointer() { }

	// RVA: 0x1FBB40 Offset: 0x1FAF40 VA: 0x1801FBB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FBB70 Offset: 0x1FAF70 VA: 0x1801FBB70
	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x12A4190 Offset: 0x12A2790 VA: 0x1812A4190
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D660 Offset: 0x8CA60 VA: 0x18008D660
	// RVA: 0x145B4F0 Offset: 0x1459AF0 VA: 0x18145B4F0
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D660 Offset: 0x8CA60 VA: 0x18008D660
	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8B0 Offset: 0x8CCB0 VA: 0x18008D8B0
	[ReliabilityContractAttribute] // RVA: 0x8D8B0 Offset: 0x8CCB0 VA: 0x18008D8B0
	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0xEC13A0 Offset: 0xEBF9A0 VA: 0x180EC13A0
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1188A0 Offset: 0x117CA0 VA: 0x1801188A0
	internal bool IsNull() { }

}

