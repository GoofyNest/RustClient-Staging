public static class LazyInitializer // TypeDefIndex: 757
{	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0210 Offset: 0xBDE810 VA: 0x180BE0210
	|-LazyInitializer.EnsureInitialized<object>
	|-LazyInitializer.EnsureInitialized<ManualResetEvent>
	|-LazyInitializer.EnsureInitialized<SemaphoreSlim>
	|-LazyInitializer.EnsureInitialized<Task.ContingentProperties>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0150 Offset: 0xBDE750 VA: 0x180BE0150
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

}

