public static class Contract // TypeDefIndex: 1505
{
	[ReliabilityContractAttribute] // RVA: 0x83D60 Offset: 0x83160 VA: 0x180083D60
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/

}

