public class BaseCommandBuffer : MonoBehaviour // TypeDefIndex: 11289
{	// Fields
	private Dictionary<Camera, Dictionary<int, CommandBuffer>> cameras; // 0x18

	// Methods

	// RVA: 0x7D8B80 Offset: 0x7D7180 VA: 0x1807D8B80
	protected CommandBuffer GetCommandBuffer(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7D87B0 Offset: 0x7D6DB0 VA: 0x1807D87B0
	protected void CleanupCamera(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7D8880 Offset: 0x7D6E80 VA: 0x1807D8880
	protected void CleanupCommandBuffer(Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7D8930 Offset: 0x7D6F30 VA: 0x1807D8930
	protected void Cleanup() { }

	// RVA: 0x7D8D80 Offset: 0x7D7380 VA: 0x1807D8D80
	public void .ctor() { }

}

