public static class RaycastCommandBufferSystem // TypeDefIndex: 8880
{	// Fields
	private static CommandBuffer buffer; // 0x0
	private static Material depthmaterial; // 0x8
	private static ComputeBuffer computeBuffer; // 0x10
	private static float[] resultDataArray; // 0x18
	private static int dataLength; // 0x20

	// Methods

	// RVA: 0x6A94E0 Offset: 0x6A7AE0 VA: 0x1806A94E0
	private static void SetupCommandBuffer() { }

	// RVA: 0x6A8C30 Offset: 0x6A7230 VA: 0x1806A8C30
	public static bool RunRaycast(Renderer renderer, Ray r, out Vector3 hitPos) { }

	// RVA: 0x6A9640 Offset: 0x6A7C40 VA: 0x1806A9640
	private static Matrix4x4 ViewMatrix(Vector3 position, Quaternion rotation) { }

	// RVA: 0x6A8B50 Offset: 0x6A7150 VA: 0x1806A8B50
	private static Matrix4x4 ProjMatrix(float orthographicSize, float nearClipPlane, float farClipPlane) { }

	// RVA: 0x6A8A50 Offset: 0x6A7050 VA: 0x1806A8A50
	public static void Cleanup() { }

	// RVA: 0x6A9A20 Offset: 0x6A8020 VA: 0x1806A9A20
	private static void .cctor() { }

}

