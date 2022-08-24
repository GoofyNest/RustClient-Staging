public struct IntPtr : ISerializable // TypeDefIndex: 369
{	private void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	public static int Size { get; }


	[ReliabilityContractAttribute] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[ReliabilityContractAttribute] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	public void .ctor(void* value) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static int get_Size() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public long ToInt64() { }

	[ReliabilityContractAttribute] // RVA: 0x7D940 Offset: 0x7CD40 VA: 0x18007D940
	[CLSCompliantAttribute] // RVA: 0x7D940 Offset: 0x7CD40 VA: 0x18007D940
	public void* ToPointer() { }

	public override string ToString() { }

	public string ToString(string format) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[ReliabilityContractAttribute] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	public static IntPtr op_Explicit(void* value) { }

	public static int op_Explicit(IntPtr value) { }

	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F4E0 Offset: 0x6E8E0 VA: 0x18006F4E0
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	internal bool IsNull() { }

}

