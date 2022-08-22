public static class NativeArrayUnsafeUtility // TypeDefIndex: 3339
{
// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCodeAttribute] // RVA: 0xE0E80 Offset: 0xE0280 VA: 0x1800E0E80
[AttributeUsageAttribute] // RVA: 0xE0E80 Offset: 0xE0280 VA: 0x1800E0E80
public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute // TypeDefIndex: 3338

// Namespace: Unity.Collections.LowLevel.Unsafe
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public static class NativeArrayUnsafeUtility // TypeDefIndex: 3339
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3AF40 Offset: 0x1A39540 VA: 0x181A3AF40
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

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2880 Offset: 0x5D0E80 VA: 0x1805D2880
	|-NativeArrayUnsafeUtility.GetUnsafePtr<BoneState>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<ColliderState>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<float3>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2880 Offset: 0x5D0E80 VA: 0x1805D2880
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
	|-RVA: 0x5D2880 Offset: 0x5D0E80 VA: 0x1805D2880
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<RaycastCommand>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<RaycastHit>
	*/

}

