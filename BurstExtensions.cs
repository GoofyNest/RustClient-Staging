internal static class BurstExtensions // TypeDefIndex: 7313
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159DA70 Offset: 0x159C070 VA: 0x18159DA70
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-RVA: 0x159DAA0 Offset: 0x159C0A0 VA: 0x18159DAA0
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-RVA: 0x159DAE0 Offset: 0x159C0E0 VA: 0x18159DAE0
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-RVA: 0x159DB10 Offset: 0x159C110 VA: 0x18159DB10
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159DAA0 Offset: 0x159C0A0 VA: 0x18159DAA0
	|-BurstExtensions.Get<BoneState>
	|
	|-RVA: 0x159DB10 Offset: 0x159C110 VA: 0x18159DB10
	|-BurstExtensions.Get<ColliderState>
	|
	|-RVA: 0x159DB50 Offset: 0x159C150 VA: 0x18159DB50
	|-BurstExtensions.Get<float3>
	*/

}

