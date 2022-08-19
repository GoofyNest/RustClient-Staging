public static class LazyInitializer // TypeDefIndex: 757
{	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDFF50 Offset: 0xBDE550 VA: 0x180BDFF50
	|-LazyInitializer.EnsureInitialized<object>
	|-LazyInitializer.EnsureInitialized<ManualResetEvent>
	|-LazyInitializer.EnsureInitialized<SemaphoreSlim>
	|-LazyInitializer.EnsureInitialized<Task.ContingentProperties>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDFE90 Offset: 0xBDE490 VA: 0x180BDFE90
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

}

