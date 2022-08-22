internal static class BurstExtensions // TypeDefIndex: 7313
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E5A0 Offset: 0x159CBA0 VA: 0x18159E5A0
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-RVA: 0x159E5D0 Offset: 0x159CBD0 VA: 0x18159E5D0
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-RVA: 0x159E610 Offset: 0x159CC10 VA: 0x18159E610
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-RVA: 0x159E640 Offset: 0x159CC40 VA: 0x18159E640
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E5D0 Offset: 0x159CBD0 VA: 0x18159E5D0
	|-BurstExtensions.Get<BoneState>
	|
	|-RVA: 0x159E640 Offset: 0x159CC40 VA: 0x18159E640
	|-BurstExtensions.Get<ColliderState>
	|
	|-RVA: 0x159E680 Offset: 0x159CC80 VA: 0x18159E680
	|-BurstExtensions.Get<float3>
	*/

}

