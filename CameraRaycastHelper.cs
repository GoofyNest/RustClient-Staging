internal class CameraRaycastHelper // TypeDefIndex: 4074
{
	[FreeFunctionAttribute] // RVA: 0xE9B60 Offset: 0xE8F60 VA: 0x1800E9B60
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunctionAttribute] // RVA: 0xE9CE0 Offset: 0xE90E0 VA: 0x1800E9CE0
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

