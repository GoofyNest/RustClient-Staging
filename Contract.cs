public static class Contract // TypeDefIndex: 1505
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEBA0 Offset: 0xBED1A0 VA: 0x180BEEBA0
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/

}

