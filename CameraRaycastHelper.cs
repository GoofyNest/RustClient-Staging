internal class CameraRaycastHelper // TypeDefIndex: 4074
{
	[FreeFunctionAttribute] // RVA: 0xE9B50 Offset: 0xE8F50 VA: 0x1800E9B50
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunctionAttribute] // RVA: 0xE9C80 Offset: 0xE9080 VA: 0x1800E9C80
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

