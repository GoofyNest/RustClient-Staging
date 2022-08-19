public static class UnsafeUtility // TypeDefIndex: 3340
{	// Methods

	// RVA: -1 Offset: -1
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4450 Offset: 0xBF2A50 VA: 0x180BF4450
	|-UnsafeUtility.IsBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x1834BF0 Offset: 0x18331F0 VA: 0x181834BF0
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x1834840 Offset: 0x1832E40 VA: 0x181834840
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x1834C90 Offset: 0x1833290 VA: 0x181834C90
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x1834CF0 Offset: 0x18332F0 VA: 0x181834CF0
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x1834C40 Offset: 0x1833240 VA: 0x181834C40
	public static void MemClear(void* destination, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x1834D50 Offset: 0x1833350 VA: 0x181834D50
	public static int SizeOf(Type type) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x1834BB0 Offset: 0x18331B0 VA: 0x181834BB0
	public static bool IsBlittable(Type type) { }

	// RVA: 0x1834B50 Offset: 0x1833150 VA: 0x181834B50
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x18348E0 Offset: 0x1832EE0 VA: 0x1818348E0
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x1834AC0 Offset: 0x18330C0 VA: 0x181834AC0
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static bool IsGenericListBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF44C0 Offset: 0xBF2AC0 VA: 0x180BF44C0
	|-UnsafeUtility.IsGenericListBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x1834880 Offset: 0x1832E80 VA: 0x181834880
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9650 Offset: 0xED7C50 VA: 0x180ED9650
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED95E0 Offset: 0xED7BE0 VA: 0x180ED95E0
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

	// RVA: -1 Offset: -1
	public static void CopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4600 Offset: 0x5D2C00 VA: 0x1805D4600
	|-UnsafeUtility.CopyPtrToStructure<IntPtr>
	*/

	// RVA: -1 Offset: -1
	private static void InternalCopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4610 Offset: 0x5D2C10 VA: 0x1805D4610
	|-UnsafeUtility.InternalCopyPtrToStructure<IntPtr>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB680 Offset: 0x15B9C80 VA: 0x1815BB680
	|-UnsafeUtility.ReadArrayElement<BoneData>
	|
	|-RVA: 0x15BB6E0 Offset: 0x15B9CE0 VA: 0x1815BB6E0
	|-UnsafeUtility.ReadArrayElement<BoneState>
	|
	|-RVA: 0x15BB720 Offset: 0x15B9D20 VA: 0x1815BB720
	|-UnsafeUtility.ReadArrayElement<ColliderData>
	|
	|-RVA: 0x15BB750 Offset: 0x15B9D50 VA: 0x1815BB750
	|-UnsafeUtility.ReadArrayElement<ColliderState>
	|
	|-RVA: 0x15BB710 Offset: 0x15B9D10 VA: 0x1815BB710
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x15BB770 Offset: 0x15B9D70 VA: 0x1815BB770
	|-UnsafeUtility.ReadArrayElement<int>
	|-UnsafeUtility.ReadArrayElement<uint>
	|-UnsafeUtility.ReadArrayElement<half2>
	|-UnsafeUtility.ReadArrayElement<Color32>
	|
	|-RVA: 0x15BB860 Offset: 0x15B9E60 VA: 0x1815BB860
	|-UnsafeUtility.ReadArrayElement<object>
	|
	|-RVA: 0x15BB870 Offset: 0x15B9E70 VA: 0x1815BB870
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x15BB780 Offset: 0x15B9D80 VA: 0x1815BB780
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|
	|-RVA: 0x15BB660 Offset: 0x15B9C60 VA: 0x1815BB660
	|-UnsafeUtility.ReadArrayElement<float3>
	|-UnsafeUtility.ReadArrayElement<BatchVisibility>
	|
	|-RVA: 0x15BB7A0 Offset: 0x15B9DA0 VA: 0x1815BB7A0
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x15BB7F0 Offset: 0x15B9DF0 VA: 0x1815BB7F0
	|-UnsafeUtility.ReadArrayElement<RaycastCommand>
	|
	|-RVA: 0x15BB820 Offset: 0x15B9E20 VA: 0x1815BB820
	|-UnsafeUtility.ReadArrayElement<RaycastHit>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4650 Offset: 0x5D2C50 VA: 0x1805D4650
	|-UnsafeUtility.WriteArrayElement<BoneData>
	|
	|-RVA: 0x5D46B0 Offset: 0x5D2CB0 VA: 0x1805D46B0
	|-UnsafeUtility.WriteArrayElement<BoneState>
	|
	|-RVA: 0x5D46F0 Offset: 0x5D2CF0 VA: 0x1805D46F0
	|-UnsafeUtility.WriteArrayElement<ColliderData>
	|
	|-RVA: 0x5D4720 Offset: 0x5D2D20 VA: 0x1805D4720
	|-UnsafeUtility.WriteArrayElement<ColliderState>
	|
	|-RVA: 0x5D46E0 Offset: 0x5D2CE0 VA: 0x1805D46E0
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x5D4740 Offset: 0x5D2D40 VA: 0x1805D4740
	|-UnsafeUtility.WriteArrayElement<int>
	|-UnsafeUtility.WriteArrayElement<uint>
	|-UnsafeUtility.WriteArrayElement<half2>
	|-UnsafeUtility.WriteArrayElement<Color32>
	|
	|-RVA: 0x5D4810 Offset: 0x5D2E10 VA: 0x1805D4810
	|-UnsafeUtility.WriteArrayElement<object>
	|
	|-RVA: 0x5D4830 Offset: 0x5D2E30 VA: 0x1805D4830
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0x5D4750 Offset: 0x5D2D50 VA: 0x1805D4750
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|-UnsafeUtility.WriteArrayElement<Plane>
	|-UnsafeUtility.WriteArrayElement<Vector4>
	|
	|-RVA: 0x5D4630 Offset: 0x5D2C30 VA: 0x1805D4630
	|-UnsafeUtility.WriteArrayElement<float3>
	|-UnsafeUtility.WriteArrayElement<BatchVisibility>
	|
	|-RVA: 0x5D4760 Offset: 0x5D2D60 VA: 0x1805D4760
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x5D47B0 Offset: 0x5D2DB0 VA: 0x1805D47B0
	|-UnsafeUtility.WriteArrayElement<RaycastCommand>
	|
	|-RVA: 0x5D47E0 Offset: 0x5D2DE0 VA: 0x1805D47E0
	|-UnsafeUtility.WriteArrayElement<RaycastHit>
	*/

	// RVA: -1 Offset: -1
	public static void* AddressOf<T>(ref T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	|-UnsafeUtility.AddressOf<InitializeBoneStateJob>
	|-UnsafeUtility.AddressOf<InitializeColliderStateJob>
	|-UnsafeUtility.AddressOf<SimulatePositionsJob>
	|-UnsafeUtility.AddressOf<UpdateTransformsJob>
	|-UnsafeUtility.AddressOf<MeshPaintable3D.DrawTextureJob>
	|-UnsafeUtility.AddressOf<ParticleSystemIK.ParticleSystemIKJob>
	|-UnsafeUtility.AddressOf<BatchQueryJob<RaycastCommand, RaycastHit>>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9770 Offset: 0xED7D70 VA: 0x180ED9770
	|-UnsafeUtility.SizeOf<BoneData>
	|
	|-RVA: 0xED9760 Offset: 0xED7D60 VA: 0x180ED9760
	|-UnsafeUtility.SizeOf<BoneState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastCommand>>
	|
	|-RVA: 0xED9700 Offset: 0xED7D00 VA: 0x180ED9700
	|-UnsafeUtility.SizeOf<ColliderData>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderState>>
	|
	|-RVA: 0xED9720 Offset: 0xED7D20 VA: 0x180ED9720
	|-UnsafeUtility.SizeOf<ColliderState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|
	|-RVA: 0xED9780 Offset: 0xED7D80 VA: 0x180ED9780
	|-UnsafeUtility.SizeOf<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0xE37E50 Offset: 0xE36450 VA: 0x180E37E50
	|-UnsafeUtility.SizeOf<int>
	|-UnsafeUtility.SizeOf<float>
	|-UnsafeUtility.SizeOf<uint>
	|-UnsafeUtility.SizeOf<half2>
	|-UnsafeUtility.SizeOf<Color32>
	|
	|-RVA: 0xED9750 Offset: 0xED7D50 VA: 0x180ED9750
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneData>>
	|
	|-RVA: 0xED96F0 Offset: 0xED7CF0 VA: 0x180ED96F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneState>>
	|-UnsafeUtility.SizeOf<RaycastHit>
	|
	|-RVA: 0xED9710 Offset: 0xED7D10 VA: 0x180ED9710
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderData>>
	|
	|-RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color32>>
	|
	|-RVA: 0xED9730 Offset: 0xED7D30 VA: 0x180ED9730
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchVisibility>>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Vector4>
	|
	|-RVA: 0x91FBF0 Offset: 0x91E1F0 VA: 0x18091FBF0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<half2>>
	|
	|-RVA: 0xED9740 Offset: 0xED7D40 VA: 0x180ED9740
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0xED96E0 Offset: 0xED7CE0 VA: 0x180ED96E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|
	|-RVA: 0x7D9EE0 Offset: 0x7D84E0 VA: 0x1807D9EE0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastHit>>
	|
	|-RVA: 0xB9F360 Offset: 0xB9D960 VA: 0x180B9F360
	|-UnsafeUtility.SizeOf<float3>
	|-UnsafeUtility.SizeOf<BatchVisibility>
	|
	|-RVA: 0xED9790 Offset: 0xED7D90 VA: 0x180ED9790
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0xED97A0 Offset: 0xED7DA0 VA: 0x180ED97A0
	|-UnsafeUtility.SizeOf<RaycastCommand>
	*/

	// RVA: -1 Offset: -1
	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9620 Offset: 0xED7C20 VA: 0x180ED9620
	|-UnsafeUtility.EnumToInt<Int32Enum>
	*/

	// RVA: -1 Offset: -1
	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4620 Offset: 0x5D2C20 VA: 0x1805D4620
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|-UnsafeUtility.InternalEnumToInt<object>
	*/

}

private struct UnsafeUtility.AlignOfHelper<T> // TypeDefIndex: 3341
{	// Fields
	public byte dummy; // 0x0
	public T data; // 0x0

}

