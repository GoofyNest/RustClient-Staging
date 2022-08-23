public static class Contract // TypeDefIndex: 1505
{
	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF1B0 Offset: 0xBED7B0 VA: 0x180BEF1B0
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/

}

