internal class CameraRaycastHelper // TypeDefIndex: 4074
{	// Methods

	[FreeFunctionAttribute] // RVA: 0xE9A20 Offset: 0xE8E20 VA: 0x1800E9A20
	// RVA: 0x2314090 Offset: 0x2312690 VA: 0x182314090
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunctionAttribute] // RVA: 0xE9B80 Offset: 0xE8F80 VA: 0x1800E9B80
	// RVA: 0x2313FB0 Offset: 0x23125B0 VA: 0x182313FB0
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x2314020 Offset: 0x2312620 VA: 0x182314020
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x2313F40 Offset: 0x2312540 VA: 0x182313F40
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

