public static class UnsafeUtility // TypeDefIndex: 3340
{
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4BE0 Offset: 0xBF31E0 VA: 0x180BF4BE0
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
	|-RVA: 0xBF4C50 Offset: 0xBF3250 VA: 0x180BF4C50
	|-UnsafeUtility.IsGenericListBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA3C0 Offset: 0xED89C0 VA: 0x180EDA3C0
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA350 Offset: 0xED8950 VA: 0x180EDA350
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
	|-RVA: 0x5D4590 Offset: 0x5D2B90 VA: 0x1805D4590
	|-UnsafeUtility.CopyPtrToStructure<IntPtr>
	*/

	private static void InternalCopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D45A0 Offset: 0x5D2BA0 VA: 0x1805D45A0
	|-UnsafeUtility.InternalCopyPtrToStructure<IntPtr>
	*/

	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAA10 Offset: 0x15B9010 VA: 0x1815BAA10
	|-UnsafeUtility.ReadArrayElement<BoneData>
	|
	|-RVA: 0x15BAA70 Offset: 0x15B9070 VA: 0x1815BAA70
	|-UnsafeUtility.ReadArrayElement<BoneState>
	|
	|-RVA: 0x15BAAB0 Offset: 0x15B90B0 VA: 0x1815BAAB0
	|-UnsafeUtility.ReadArrayElement<ColliderData>
	|
	|-RVA: 0x15BAAE0 Offset: 0x15B90E0 VA: 0x1815BAAE0
	|-UnsafeUtility.ReadArrayElement<ColliderState>
	|
	|-RVA: 0x15BAAA0 Offset: 0x15B90A0 VA: 0x1815BAAA0
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x15BAB00 Offset: 0x15B9100 VA: 0x1815BAB00
	|-UnsafeUtility.ReadArrayElement<int>
	|-UnsafeUtility.ReadArrayElement<uint>
	|-UnsafeUtility.ReadArrayElement<half2>
	|-UnsafeUtility.ReadArrayElement<Color32>
	|
	|-RVA: 0x15BABF0 Offset: 0x15B91F0 VA: 0x1815BABF0
	|-UnsafeUtility.ReadArrayElement<object>
	|
	|-RVA: 0x15BAC00 Offset: 0x15B9200 VA: 0x1815BAC00
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x15BAB10 Offset: 0x15B9110 VA: 0x1815BAB10
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|
	|-RVA: 0x15BA9F0 Offset: 0x15B8FF0 VA: 0x1815BA9F0
	|-UnsafeUtility.ReadArrayElement<float3>
	|-UnsafeUtility.ReadArrayElement<BatchVisibility>
	|
	|-RVA: 0x15BAB30 Offset: 0x15B9130 VA: 0x1815BAB30
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x15BAB80 Offset: 0x15B9180 VA: 0x1815BAB80
	|-UnsafeUtility.ReadArrayElement<RaycastCommand>
	|
	|-RVA: 0x15BABB0 Offset: 0x15B91B0 VA: 0x1815BABB0
	|-UnsafeUtility.ReadArrayElement<RaycastHit>
	*/

	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D45E0 Offset: 0x5D2BE0 VA: 0x1805D45E0
	|-UnsafeUtility.WriteArrayElement<BoneData>
	|
	|-RVA: 0x5D4640 Offset: 0x5D2C40 VA: 0x1805D4640
	|-UnsafeUtility.WriteArrayElement<BoneState>
	|
	|-RVA: 0x5D4680 Offset: 0x5D2C80 VA: 0x1805D4680
	|-UnsafeUtility.WriteArrayElement<ColliderData>
	|
	|-RVA: 0x5D46B0 Offset: 0x5D2CB0 VA: 0x1805D46B0
	|-UnsafeUtility.WriteArrayElement<ColliderState>
	|
	|-RVA: 0x5D4670 Offset: 0x5D2C70 VA: 0x1805D4670
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x5D46D0 Offset: 0x5D2CD0 VA: 0x1805D46D0
	|-UnsafeUtility.WriteArrayElement<int>
	|-UnsafeUtility.WriteArrayElement<uint>
	|-UnsafeUtility.WriteArrayElement<half2>
	|-UnsafeUtility.WriteArrayElement<Color32>
	|
	|-RVA: 0x5D47A0 Offset: 0x5D2DA0 VA: 0x1805D47A0
	|-UnsafeUtility.WriteArrayElement<object>
	|
	|-RVA: 0x5D47C0 Offset: 0x5D2DC0 VA: 0x1805D47C0
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0x5D46E0 Offset: 0x5D2CE0 VA: 0x1805D46E0
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|-UnsafeUtility.WriteArrayElement<Plane>
	|-UnsafeUtility.WriteArrayElement<Vector4>
	|
	|-RVA: 0x5D45C0 Offset: 0x5D2BC0 VA: 0x1805D45C0
	|-UnsafeUtility.WriteArrayElement<float3>
	|-UnsafeUtility.WriteArrayElement<BatchVisibility>
	|
	|-RVA: 0x5D46F0 Offset: 0x5D2CF0 VA: 0x1805D46F0
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x5D4740 Offset: 0x5D2D40 VA: 0x1805D4740
	|-UnsafeUtility.WriteArrayElement<RaycastCommand>
	|
	|-RVA: 0x5D4770 Offset: 0x5D2D70 VA: 0x1805D4770
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
	|-RVA: 0xEDA4E0 Offset: 0xED8AE0 VA: 0x180EDA4E0
	|-UnsafeUtility.SizeOf<BoneData>
	|
	|-RVA: 0xEDA4D0 Offset: 0xED8AD0 VA: 0x180EDA4D0
	|-UnsafeUtility.SizeOf<BoneState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastCommand>>
	|
	|-RVA: 0xEDA470 Offset: 0xED8A70 VA: 0x180EDA470
	|-UnsafeUtility.SizeOf<ColliderData>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderState>>
	|
	|-RVA: 0xEDA490 Offset: 0xED8A90 VA: 0x180EDA490
	|-UnsafeUtility.SizeOf<ColliderState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|
	|-RVA: 0xEDA4F0 Offset: 0xED8AF0 VA: 0x180EDA4F0
	|-UnsafeUtility.SizeOf<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0xE38BC0 Offset: 0xE371C0 VA: 0x180E38BC0
	|-UnsafeUtility.SizeOf<int>
	|-UnsafeUtility.SizeOf<float>
	|-UnsafeUtility.SizeOf<uint>
	|-UnsafeUtility.SizeOf<half2>
	|-UnsafeUtility.SizeOf<Color32>
	|
	|-RVA: 0xEDA4C0 Offset: 0xED8AC0 VA: 0x180EDA4C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneData>>
	|
	|-RVA: 0xEDA460 Offset: 0xED8A60 VA: 0x180EDA460
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneState>>
	|-UnsafeUtility.SizeOf<RaycastHit>
	|
	|-RVA: 0xEDA480 Offset: 0xED8A80 VA: 0x180EDA480
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderData>>
	|
	|-RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color32>>
	|
	|-RVA: 0xEDA4A0 Offset: 0xED8AA0 VA: 0x180EDA4A0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchVisibility>>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Vector4>
	|
	|-RVA: 0x920210 Offset: 0x91E810 VA: 0x180920210
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<half2>>
	|
	|-RVA: 0xEDA4B0 Offset: 0xED8AB0 VA: 0x180EDA4B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0xEDA450 Offset: 0xED8A50 VA: 0x180EDA450
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|
	|-RVA: 0x7A5910 Offset: 0x7A3F10 VA: 0x1807A5910
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastHit>>
	|
	|-RVA: 0xB9FAF0 Offset: 0xB9E0F0 VA: 0x180B9FAF0
	|-UnsafeUtility.SizeOf<float3>
	|-UnsafeUtility.SizeOf<BatchVisibility>
	|
	|-RVA: 0xEDA500 Offset: 0xED8B00 VA: 0x180EDA500
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0xEDA510 Offset: 0xED8B10 VA: 0x180EDA510
	|-UnsafeUtility.SizeOf<RaycastCommand>
	*/

	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA390 Offset: 0xED8990 VA: 0x180EDA390
	|-UnsafeUtility.EnumToInt<Int32Enum>
	*/

	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D45B0 Offset: 0x5D2BB0 VA: 0x1805D45B0
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|-UnsafeUtility.InternalEnumToInt<object>
	*/

}

private struct UnsafeUtility.AlignOfHelper<T> // TypeDefIndex: 3341
{	public byte dummy; // 0x0
	public T data; // 0x0

}

