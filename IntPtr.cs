public struct IntPtr : ISerializable // TypeDefIndex: 369
{	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	public static int Size { get; }


	[ReliabilityContractAttribute] // RVA: 0x8D6C0 Offset: 0x8CAC0 VA: 0x18008D6C0
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D6C0 Offset: 0x8CAC0 VA: 0x18008D6C0
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D910 Offset: 0x8CD10 VA: 0x18008D910
	[ReliabilityContractAttribute] // RVA: 0x8D910 Offset: 0x8CD10 VA: 0x18008D910
	public void .ctor(void* value) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public static int get_Size() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D840 Offset: 0x7CC40 VA: 0x18007D840
	[CLSCompliantAttribute] // RVA: 0x7D840 Offset: 0x7CC40 VA: 0x18007D840
	public void* ToPointer() { }

	public override string ToString() { }

	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D6C0 Offset: 0x8CAC0 VA: 0x18008D6C0
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D6C0 Offset: 0x8CAC0 VA: 0x18008D6C0
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8D910 Offset: 0x8CD10 VA: 0x18008D910
	[ReliabilityContractAttribute] // RVA: 0x8D910 Offset: 0x8CD10 VA: 0x18008D910
	public static IntPtr op_Explicit(void* value) { }

	public static int op_Explicit(IntPtr value) { }

	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F4E0 Offset: 0x6E8E0 VA: 0x18006F4E0
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
	internal bool IsNull() { }

}

