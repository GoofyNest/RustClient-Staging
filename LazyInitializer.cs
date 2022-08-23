public static class LazyInitializer // TypeDefIndex: 757
{
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0820 Offset: 0xBDEE20 VA: 0x180BE0820
	|-LazyInitializer.EnsureInitialized<object>
	|-LazyInitializer.EnsureInitialized<ManualResetEvent>
	|-LazyInitializer.EnsureInitialized<SemaphoreSlim>
	|-LazyInitializer.EnsureInitialized<Task.ContingentProperties>
	*/

	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0760 Offset: 0xBDED60 VA: 0x180BE0760
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

}

