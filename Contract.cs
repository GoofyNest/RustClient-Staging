public static class Contract // TypeDefIndex: 1505
{
	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF070 Offset: 0xBED670 VA: 0x180BEF070
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/

}

