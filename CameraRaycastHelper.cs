internal class CameraRaycastHelper // TypeDefIndex: 4074
{
	[FreeFunctionAttribute] // RVA: 0xE9A20 Offset: 0xE8E20 VA: 0x1800E9A20
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunctionAttribute] // RVA: 0xE9B80 Offset: 0xE8F80 VA: 0x1800E9B80
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

