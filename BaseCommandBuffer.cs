public class BaseCommandBuffer : MonoBehaviour // TypeDefIndex: 11289
{	// Fields
	private Dictionary<Camera, Dictionary<int, CommandBuffer>> cameras; // 0x18

	// Methods

	// RVA: 0x7D8C90 Offset: 0x7D7290 VA: 0x1807D8C90
	protected CommandBuffer GetCommandBuffer(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7D88C0 Offset: 0x7D6EC0 VA: 0x1807D88C0
	protected void CleanupCamera(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7D8990 Offset: 0x7D6F90 VA: 0x1807D8990
	protected void CleanupCommandBuffer(Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7D8A40 Offset: 0x7D7040 VA: 0x1807D8A40
	protected void Cleanup() { }

	// RVA: 0x7D8E90 Offset: 0x7D7490 VA: 0x1807D8E90
	public void .ctor() { }

}

