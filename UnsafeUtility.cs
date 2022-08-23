public static class UnsafeUtility // TypeDefIndex: 3340
{
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4CE0 Offset: 0xBF32E0 VA: 0x180BF4CE0
	|-UnsafeUtility.IsBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	public static void MemSet(void* destination, byte value, long size) { }

	public static void MemClear(void* destination, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	public static int SizeOf(Type type) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	public static bool IsBlittable(Type type) { }

	private static bool IsBlittableValueType(Type t) { }

	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	internal static bool IsArrayBlittable(Array arr) { }

	internal static bool IsGenericListBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4D50 Offset: 0xBF3350 VA: 0x180BF4D50
	|-UnsafeUtility.IsGenericListBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA4C0 Offset: 0xED8AC0 VA: 0x180EDA4C0
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA450 Offset: 0xED8A50 VA: 0x180EDA450
	|-UnsafeUtility.AlignOf<BoneData>
	|-UnsafeUtility.AlignOf<BoneState>
	|-UnsafeUtility.AlignOf<ColliderData>
	|-UnsafeUtility.AlignOf<ColliderState>
	|-UnsafeUtility.AlignOf<byte>
	|-UnsafeUtility.AlignOf<int>
	|-UnsafeUtility.AlignOf<float>
	|-UnsafeUtility.AlignOf<uint>
	|-UnsafeUtility.AlignOf<JobHandle>
	|-UnsafeUtility.AlignOf<float3>
	|-UnsafeUtility.AlignOf<half2>
	|-UnsafeUtility.AlignOf<Color32>
	|-UnsafeUtility.AlignOf<LightDataGI>
	|-UnsafeUtility.AlignOf<Plane>
	|-UnsafeUtility.AlignOf<RaycastCommand>
	|-UnsafeUtility.AlignOf<RaycastHit>
	|-UnsafeUtility.AlignOf<BatchVisibility>
	|-UnsafeUtility.AlignOf<Vector4>
	*/

	public static void CopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4660 Offset: 0x5D2C60 VA: 0x1805D4660
	|-UnsafeUtility.CopyPtrToStructure<IntPtr>
	*/

	private static void InternalCopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4670 Offset: 0x5D2C70 VA: 0x1805D4670
	|-UnsafeUtility.InternalCopyPtrToStructure<IntPtr>
	*/

	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAB10 Offset: 0x15B9110 VA: 0x1815BAB10
	|-UnsafeUtility.ReadArrayElement<BoneData>
	|
	|-RVA: 0x15BAB70 Offset: 0x15B9170 VA: 0x1815BAB70
	|-UnsafeUtility.ReadArrayElement<BoneState>
	|
	|-RVA: 0x15BABB0 Offset: 0x15B91B0 VA: 0x1815BABB0
	|-UnsafeUtility.ReadArrayElement<ColliderData>
	|
	|-RVA: 0x15BABE0 Offset: 0x15B91E0 VA: 0x1815BABE0
	|-UnsafeUtility.ReadArrayElement<ColliderState>
	|
	|-RVA: 0x15BABA0 Offset: 0x15B91A0 VA: 0x1815BABA0
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x15BAC00 Offset: 0x15B9200 VA: 0x1815BAC00
	|-UnsafeUtility.ReadArrayElement<int>
	|-UnsafeUtility.ReadArrayElement<uint>
	|-UnsafeUtility.ReadArrayElement<half2>
	|-UnsafeUtility.ReadArrayElement<Color32>
	|
	|-RVA: 0x15BACF0 Offset: 0x15B92F0 VA: 0x1815BACF0
	|-UnsafeUtility.ReadArrayElement<object>
	|
	|-RVA: 0x15BAD00 Offset: 0x15B9300 VA: 0x1815BAD00
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x15BAC10 Offset: 0x15B9210 VA: 0x1815BAC10
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|
	|-RVA: 0x15BAAF0 Offset: 0x15B90F0 VA: 0x1815BAAF0
	|-UnsafeUtility.ReadArrayElement<float3>
	|-UnsafeUtility.ReadArrayElement<BatchVisibility>
	|
	|-RVA: 0x15BAC30 Offset: 0x15B9230 VA: 0x1815BAC30
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x15BAC80 Offset: 0x15B9280 VA: 0x1815BAC80
	|-UnsafeUtility.ReadArrayElement<RaycastCommand>
	|
	|-RVA: 0x15BACB0 Offset: 0x15B92B0 VA: 0x1815BACB0
	|-UnsafeUtility.ReadArrayElement<RaycastHit>
	*/

	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D46B0 Offset: 0x5D2CB0 VA: 0x1805D46B0
	|-UnsafeUtility.WriteArrayElement<BoneData>
	|
	|-RVA: 0x5D4710 Offset: 0x5D2D10 VA: 0x1805D4710
	|-UnsafeUtility.WriteArrayElement<BoneState>
	|
	|-RVA: 0x5D4750 Offset: 0x5D2D50 VA: 0x1805D4750
	|-UnsafeUtility.WriteArrayElement<ColliderData>
	|
	|-RVA: 0x5D4780 Offset: 0x5D2D80 VA: 0x1805D4780
	|-UnsafeUtility.WriteArrayElement<ColliderState>
	|
	|-RVA: 0x5D4740 Offset: 0x5D2D40 VA: 0x1805D4740
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x5D47A0 Offset: 0x5D2DA0 VA: 0x1805D47A0
	|-UnsafeUtility.WriteArrayElement<int>
	|-UnsafeUtility.WriteArrayElement<uint>
	|-UnsafeUtility.WriteArrayElement<half2>
	|-UnsafeUtility.WriteArrayElement<Color32>
	|
	|-RVA: 0x5D4870 Offset: 0x5D2E70 VA: 0x1805D4870
	|-UnsafeUtility.WriteArrayElement<object>
	|
	|-RVA: 0x5D4890 Offset: 0x5D2E90 VA: 0x1805D4890
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0x5D47B0 Offset: 0x5D2DB0 VA: 0x1805D47B0
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|-UnsafeUtility.WriteArrayElement<Plane>
	|-UnsafeUtility.WriteArrayElement<Vector4>
	|
	|-RVA: 0x5D4690 Offset: 0x5D2C90 VA: 0x1805D4690
	|-UnsafeUtility.WriteArrayElement<float3>
	|-UnsafeUtility.WriteArrayElement<BatchVisibility>
	|
	|-RVA: 0x5D47C0 Offset: 0x5D2DC0 VA: 0x1805D47C0
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x5D4810 Offset: 0x5D2E10 VA: 0x1805D4810
	|-UnsafeUtility.WriteArrayElement<RaycastCommand>
	|
	|-RVA: 0x5D4840 Offset: 0x5D2E40 VA: 0x1805D4840
	|-UnsafeUtility.WriteArrayElement<RaycastHit>
	*/

	public static void* AddressOf<T>(ref T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-UnsafeUtility.AddressOf<InitializeBoneStateJob>
	|-UnsafeUtility.AddressOf<InitializeColliderStateJob>
	|-UnsafeUtility.AddressOf<SimulatePositionsJob>
	|-UnsafeUtility.AddressOf<UpdateTransformsJob>
	|-UnsafeUtility.AddressOf<MeshPaintable3D.DrawTextureJob>
	|-UnsafeUtility.AddressOf<ParticleSystemIK.ParticleSystemIKJob>
	|-UnsafeUtility.AddressOf<BatchQueryJob<RaycastCommand, RaycastHit>>
	*/

	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA5E0 Offset: 0xED8BE0 VA: 0x180EDA5E0
	|-UnsafeUtility.SizeOf<BoneData>
	|
	|-RVA: 0xEDA5D0 Offset: 0xED8BD0 VA: 0x180EDA5D0
	|-UnsafeUtility.SizeOf<BoneState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastCommand>>
	|
	|-RVA: 0xEDA570 Offset: 0xED8B70 VA: 0x180EDA570
	|-UnsafeUtility.SizeOf<ColliderData>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderState>>
	|
	|-RVA: 0xEDA590 Offset: 0xED8B90 VA: 0x180EDA590
	|-UnsafeUtility.SizeOf<ColliderState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|
	|-RVA: 0xEDA5F0 Offset: 0xED8BF0 VA: 0x180EDA5F0
	|-UnsafeUtility.SizeOf<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x5B1940 Offset: 0x5AFF40 VA: 0x1805B1940
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0xE38CC0 Offset: 0xE372C0 VA: 0x180E38CC0
	|-UnsafeUtility.SizeOf<int>
	|-UnsafeUtility.SizeOf<float>
	|-UnsafeUtility.SizeOf<uint>
	|-UnsafeUtility.SizeOf<half2>
	|-UnsafeUtility.SizeOf<Color32>
	|
	|-RVA: 0xEDA5C0 Offset: 0xED8BC0 VA: 0x180EDA5C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneData>>
	|
	|-RVA: 0xEDA560 Offset: 0xED8B60 VA: 0x180EDA560
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneState>>
	|-UnsafeUtility.SizeOf<RaycastHit>
	|
	|-RVA: 0xEDA580 Offset: 0xED8B80 VA: 0x180EDA580
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderData>>
	|
	|-RVA: 0x514710 Offset: 0x512D10 VA: 0x180514710
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x8C13F0 Offset: 0x8BF9F0 VA: 0x1808C13F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color32>>
	|
	|-RVA: 0xEDA5A0 Offset: 0xED8BA0 VA: 0x180EDA5A0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchVisibility>>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Vector4>
	|
	|-RVA: 0x9202F0 Offset: 0x91E8F0 VA: 0x1809202F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<half2>>
	|
	|-RVA: 0xEDA5B0 Offset: 0xED8BB0 VA: 0x180EDA5B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0xEDA550 Offset: 0xED8B50 VA: 0x180EDA550
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|
	|-RVA: 0x7A59F0 Offset: 0x7A3FF0 VA: 0x1807A59F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastHit>>
	|
	|-RVA: 0xB9FBF0 Offset: 0xB9E1F0 VA: 0x180B9FBF0
	|-UnsafeUtility.SizeOf<float3>
	|-UnsafeUtility.SizeOf<BatchVisibility>
	|
	|-RVA: 0xEDA600 Offset: 0xED8C00 VA: 0x180EDA600
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0xEDA610 Offset: 0xED8C10 VA: 0x180EDA610
	|-UnsafeUtility.SizeOf<RaycastCommand>
	*/

	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA490 Offset: 0xED8A90 VA: 0x180EDA490
	|-UnsafeUtility.EnumToInt<Int32Enum>
	*/

	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4680 Offset: 0x5D2C80 VA: 0x1805D4680
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|-UnsafeUtility.InternalEnumToInt<object>
	*/

}

private struct UnsafeUtility.AlignOfHelper<T> // TypeDefIndex: 3341
{	public byte dummy; // 0x0
	public T data; // 0x0

}

