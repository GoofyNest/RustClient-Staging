public static class LazyInitializer // TypeDefIndex: 757
{
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE06E0 Offset: 0xBDECE0 VA: 0x180BE06E0
	|-LazyInitializer.EnsureInitialized<object>
	|-LazyInitializer.EnsureInitialized<ManualResetEvent>
	|-LazyInitializer.EnsureInitialized<SemaphoreSlim>
	|-LazyInitializer.EnsureInitialized<Task.ContingentProperties>
	*/

	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0620 Offset: 0xBDEC20 VA: 0x180BE0620
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

}

