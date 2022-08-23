internal static class BurstExtensions // TypeDefIndex: 7313
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159DA30 Offset: 0x159C030 VA: 0x18159DA30
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-RVA: 0x159DA60 Offset: 0x159C060 VA: 0x18159DA60
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-RVA: 0x159DAA0 Offset: 0x159C0A0 VA: 0x18159DAA0
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-RVA: 0x159DAD0 Offset: 0x159C0D0 VA: 0x18159DAD0
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159DA60 Offset: 0x159C060 VA: 0x18159DA60
	|-BurstExtensions.Get<BoneState>
	|
	|-RVA: 0x159DAD0 Offset: 0x159C0D0 VA: 0x18159DAD0
	|-BurstExtensions.Get<ColliderState>
	|
	|-RVA: 0x159DB10 Offset: 0x159C110 VA: 0x18159DB10
	|-BurstExtensions.Get<float3>
	*/

}

