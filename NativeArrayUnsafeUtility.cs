public static class NativeArrayUnsafeUtility // TypeDefIndex: 3339
{
// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCodeAttribute] // RVA: 0xE0EA0 Offset: 0xE02A0 VA: 0x1800E0EA0
[AttributeUsageAttribute] // RVA: 0xE0EA0 Offset: 0xE02A0 VA: 0x1800E0EA0
public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute // TypeDefIndex: 3338

// Namespace: Unity.Collections.LowLevel.Unsafe
[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
public static class NativeArrayUnsafeUtility // TypeDefIndex: 3339
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B5A0 Offset: 0x1A39BA0 VA: 0x181A3B5A0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoneData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoneState>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ColliderData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ColliderState>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<JobHandle>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float3>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<half2>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Color32>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<RaycastCommand>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<RaycastHit>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchVisibility>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28F0 Offset: 0x5D0EF0 VA: 0x1805D28F0
	|-NativeArrayUnsafeUtility.GetUnsafePtr<BoneState>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<ColliderState>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<float3>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28F0 Offset: 0x5D0EF0 VA: 0x1805D28F0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BoneData>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BoneState>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ColliderData>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ColliderState>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<uint>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<Vector4>
	*/

	// RVA: -1 Offset: -1
	public static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D28F0 Offset: 0x5D0EF0 VA: 0x1805D28F0
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<RaycastCommand>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<RaycastHit>
	*/

}

