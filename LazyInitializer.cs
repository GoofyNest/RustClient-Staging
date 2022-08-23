public static class LazyInitializer // TypeDefIndex: 757
{
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE07E0 Offset: 0xBDEDE0 VA: 0x180BE07E0
	|-LazyInitializer.EnsureInitialized<object>
	|-LazyInitializer.EnsureInitialized<ManualResetEvent>
	|-LazyInitializer.EnsureInitialized<SemaphoreSlim>
	|-LazyInitializer.EnsureInitialized<Task.ContingentProperties>
	*/

	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0720 Offset: 0xBDED20 VA: 0x180BE0720
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

}

