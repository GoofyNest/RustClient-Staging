internal static class BurstExtensions // TypeDefIndex: 7313
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-BurstExtensions.Get<BoneState>
	|
	|-BurstExtensions.Get<ColliderState>
	|
	|-BurstExtensions.Get<float3>
	*/

}

