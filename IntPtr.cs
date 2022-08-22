public struct IntPtr : ISerializable // TypeDefIndex: 369
{	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	public static int Size { get; }


	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[ReliabilityContractAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	public void .ctor(void* value) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int get_Size() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	public void* ToPointer() { }

	public override string ToString() { }

	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D680 Offset: 0x8CA80 VA: 0x18008D680
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[ReliabilityContractAttribute] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	public static IntPtr op_Explicit(void* value) { }

	public static int op_Explicit(IntPtr value) { }

	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	internal bool IsNull() { }

}

