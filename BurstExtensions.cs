internal static class BurstExtensions // TypeDefIndex: 7313
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159D970 Offset: 0x159BF70 VA: 0x18159D970
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-RVA: 0x159D9A0 Offset: 0x159BFA0 VA: 0x18159D9A0
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-RVA: 0x159D9E0 Offset: 0x159BFE0 VA: 0x18159D9E0
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-RVA: 0x159DA10 Offset: 0x159C010 VA: 0x18159DA10
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159D9A0 Offset: 0x159BFA0 VA: 0x18159D9A0
	|-BurstExtensions.Get<BoneState>
	|
	|-RVA: 0x159DA10 Offset: 0x159C010 VA: 0x18159DA10
	|-BurstExtensions.Get<ColliderState>
	|
	|-RVA: 0x159DA50 Offset: 0x159C050 VA: 0x18159DA50
	|-BurstExtensions.Get<float3>
	*/

}

