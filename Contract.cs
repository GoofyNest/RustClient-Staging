public static class Contract // TypeDefIndex: 1505
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEE8E0 Offset: 0xBECEE0 VA: 0x180BEE8E0
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/

}

