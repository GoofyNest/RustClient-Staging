public static class RaycastCommandBufferSystem // TypeDefIndex: 8880
{	// Fields
	private static CommandBuffer buffer; // 0x0
	private static Material depthmaterial; // 0x8
	private static ComputeBuffer computeBuffer; // 0x10
	private static float[] resultDataArray; // 0x18
	private static int dataLength; // 0x20

	// Methods

	// RVA: 0x6A9550 Offset: 0x6A7B50 VA: 0x1806A9550
	private static void SetupCommandBuffer() { }

	// RVA: 0x6A8CA0 Offset: 0x6A72A0 VA: 0x1806A8CA0
	public static bool RunRaycast(Renderer renderer, Ray r, out Vector3 hitPos) { }

	// RVA: 0x6A96B0 Offset: 0x6A7CB0 VA: 0x1806A96B0
	private static Matrix4x4 ViewMatrix(Vector3 position, Quaternion rotation) { }

	// RVA: 0x6A8BC0 Offset: 0x6A71C0 VA: 0x1806A8BC0
	private static Matrix4x4 ProjMatrix(float orthographicSize, float nearClipPlane, float farClipPlane) { }

	// RVA: 0x6A8AC0 Offset: 0x6A70C0 VA: 0x1806A8AC0
	public static void Cleanup() { }

	// RVA: 0x6A9A90 Offset: 0x6A8090 VA: 0x1806A9A90
	private static void .cctor() { }

}

