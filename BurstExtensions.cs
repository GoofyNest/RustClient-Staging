internal static class BurstExtensions // TypeDefIndex: 7313
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159D930 Offset: 0x159BF30 VA: 0x18159D930
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-RVA: 0x159D960 Offset: 0x159BF60 VA: 0x18159D960
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-RVA: 0x159D9A0 Offset: 0x159BFA0 VA: 0x18159D9A0
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-RVA: 0x159D9D0 Offset: 0x159BFD0 VA: 0x18159D9D0
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159D960 Offset: 0x159BF60 VA: 0x18159D960
	|-BurstExtensions.Get<BoneState>
	|
	|-RVA: 0x159D9D0 Offset: 0x159BFD0 VA: 0x18159D9D0
	|-BurstExtensions.Get<ColliderState>
	|
	|-RVA: 0x159DA10 Offset: 0x159C010 VA: 0x18159DA10
	|-BurstExtensions.Get<float3>
	*/

}

