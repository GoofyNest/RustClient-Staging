public static class UnsafeUtility // TypeDefIndex: 3340
{	// Methods

	// RVA: -1 Offset: -1
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4710 Offset: 0xBF2D10 VA: 0x180BF4710
	|-UnsafeUtility.IsBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x1834E70 Offset: 0x1833470 VA: 0x181834E70
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x1834AC0 Offset: 0x18330C0 VA: 0x181834AC0
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x1834F10 Offset: 0x1833510 VA: 0x181834F10
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x1834F70 Offset: 0x1833570 VA: 0x181834F70
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x1834EC0 Offset: 0x18334C0 VA: 0x181834EC0
	public static void MemClear(void* destination, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x1834FD0 Offset: 0x18335D0 VA: 0x181834FD0
	public static int SizeOf(Type type) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x1834E30 Offset: 0x1833430 VA: 0x181834E30
	public static bool IsBlittable(Type type) { }

	// RVA: 0x1834DD0 Offset: 0x18333D0 VA: 0x181834DD0
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x1834B60 Offset: 0x1833160 VA: 0x181834B60
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x1834D40 Offset: 0x1833340 VA: 0x181834D40
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static bool IsGenericListBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4780 Offset: 0xBF2D80 VA: 0x180BF4780
	|-UnsafeUtility.IsGenericListBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x1834B00 Offset: 0x1833100 VA: 0x181834B00
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9910 Offset: 0xED7F10 VA: 0x180ED9910
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED98A0 Offset: 0xED7EA0 VA: 0x180ED98A0
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
	|-RVA: 0x15BB940 Offset: 0x15B9F40 VA: 0x1815BB940
	|-UnsafeUtility.ReadArrayElement<BoneData>
	|
	|-RVA: 0x15BB9A0 Offset: 0x15B9FA0 VA: 0x1815BB9A0
	|-UnsafeUtility.ReadArrayElement<BoneState>
	|
	|-RVA: 0x15BB9E0 Offset: 0x15B9FE0 VA: 0x1815BB9E0
	|-UnsafeUtility.ReadArrayElement<ColliderData>
	|
	|-RVA: 0x15BBA10 Offset: 0x15BA010 VA: 0x1815BBA10
	|-UnsafeUtility.ReadArrayElement<ColliderState>
	|
	|-RVA: 0x15BB9D0 Offset: 0x15B9FD0 VA: 0x1815BB9D0
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x15BBA30 Offset: 0x15BA030 VA: 0x1815BBA30
	|-UnsafeUtility.ReadArrayElement<int>
	|-UnsafeUtility.ReadArrayElement<uint>
	|-UnsafeUtility.ReadArrayElement<half2>
	|-UnsafeUtility.ReadArrayElement<Color32>
	|
	|-RVA: 0x15BBB20 Offset: 0x15BA120 VA: 0x1815BBB20
	|-UnsafeUtility.ReadArrayElement<object>
	|
	|-RVA: 0x15BBB30 Offset: 0x15BA130 VA: 0x1815BBB30
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x15BBA40 Offset: 0x15BA040 VA: 0x1815BBA40
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|
	|-RVA: 0x15BB920 Offset: 0x15B9F20 VA: 0x1815BB920
	|-UnsafeUtility.ReadArrayElement<float3>
	|-UnsafeUtility.ReadArrayElement<BatchVisibility>
	|
	|-RVA: 0x15BBA60 Offset: 0x15BA060 VA: 0x1815BBA60
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x15BBAB0 Offset: 0x15BA0B0 VA: 0x1815BBAB0
	|-UnsafeUtility.ReadArrayElement<RaycastCommand>
	|
	|-RVA: 0x15BBAE0 Offset: 0x15BA0E0 VA: 0x1815BBAE0
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
	|-RVA: 0xED9A30 Offset: 0xED8030 VA: 0x180ED9A30
	|-UnsafeUtility.SizeOf<BoneData>
	|
	|-RVA: 0xED9A20 Offset: 0xED8020 VA: 0x180ED9A20
	|-UnsafeUtility.SizeOf<BoneState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastCommand>>
	|
	|-RVA: 0xED99C0 Offset: 0xED7FC0 VA: 0x180ED99C0
	|-UnsafeUtility.SizeOf<ColliderData>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderState>>
	|
	|-RVA: 0xED99E0 Offset: 0xED7FE0 VA: 0x180ED99E0
	|-UnsafeUtility.SizeOf<ColliderState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|
	|-RVA: 0xED9A40 Offset: 0xED8040 VA: 0x180ED9A40
	|-UnsafeUtility.SizeOf<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0xE38110 Offset: 0xE36710 VA: 0x180E38110
	|-UnsafeUtility.SizeOf<int>
	|-UnsafeUtility.SizeOf<float>
	|-UnsafeUtility.SizeOf<uint>
	|-UnsafeUtility.SizeOf<half2>
	|-UnsafeUtility.SizeOf<Color32>
	|
	|-RVA: 0xED9A10 Offset: 0xED8010 VA: 0x180ED9A10
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneData>>
	|
	|-RVA: 0xED99B0 Offset: 0xED7FB0 VA: 0x180ED99B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneState>>
	|-UnsafeUtility.SizeOf<RaycastHit>
	|
	|-RVA: 0xED99D0 Offset: 0xED7FD0 VA: 0x180ED99D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderData>>
	|
	|-RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x8C0E00 Offset: 0x8BF400 VA: 0x1808C0E00
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color32>>
	|
	|-RVA: 0xED99F0 Offset: 0xED7FF0 VA: 0x180ED99F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchVisibility>>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Vector4>
	|
	|-RVA: 0x91FD00 Offset: 0x91E300 VA: 0x18091FD00
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<half2>>
	|
	|-RVA: 0xED9A00 Offset: 0xED8000 VA: 0x180ED9A00
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0xED99A0 Offset: 0xED7FA0 VA: 0x180ED99A0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|
	|-RVA: 0x7D9FF0 Offset: 0x7D85F0 VA: 0x1807D9FF0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastHit>>
	|
	|-RVA: 0xB9F620 Offset: 0xB9DC20 VA: 0x180B9F620
	|-UnsafeUtility.SizeOf<float3>
	|-UnsafeUtility.SizeOf<BatchVisibility>
	|
	|-RVA: 0xED9A50 Offset: 0xED8050 VA: 0x180ED9A50
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0xED9A60 Offset: 0xED8060 VA: 0x180ED9A60
	|-UnsafeUtility.SizeOf<RaycastCommand>
	*/

	// RVA: -1 Offset: -1
	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED98E0 Offset: 0xED7EE0 VA: 0x180ED98E0
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

