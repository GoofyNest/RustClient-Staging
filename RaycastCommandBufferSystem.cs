public static class RaycastCommandBufferSystem // TypeDefIndex: 8880
{	// Fields
	private static CommandBuffer buffer; // 0x0
	private static Material depthmaterial; // 0x8
	private static ComputeBuffer computeBuffer; // 0x10
	private static float[] resultDataArray; // 0x18
	private static int dataLength; // 0x20

	// Methods

	// RVA: 0x6A9440 Offset: 0x6A7A40 VA: 0x1806A9440
	private static void SetupCommandBuffer() { }

	// RVA: 0x6A8B90 Offset: 0x6A7190 VA: 0x1806A8B90
	public static bool RunRaycast(Renderer renderer, Ray r, out Vector3 hitPos) { }

	// RVA: 0x6A95A0 Offset: 0x6A7BA0 VA: 0x1806A95A0
	private static Matrix4x4 ViewMatrix(Vector3 position, Quaternion rotation) { }

	// RVA: 0x6A8AB0 Offset: 0x6A70B0 VA: 0x1806A8AB0
	private static Matrix4x4 ProjMatrix(float orthographicSize, float nearClipPlane, float farClipPlane) { }

	// RVA: 0x6A89B0 Offset: 0x6A6FB0 VA: 0x1806A89B0
	public static void Cleanup() { }

	// RVA: 0x6A9980 Offset: 0x6A7F80 VA: 0x1806A9980
	private static void .cctor() { }

}

