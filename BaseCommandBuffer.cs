public class BaseCommandBuffer : MonoBehaviour // TypeDefIndex: 11289
{	// Fields
	private Dictionary<Camera, Dictionary<int, CommandBuffer>> cameras; // 0x18

	// Methods

	// RVA: 0x7A45B0 Offset: 0x7A2BB0 VA: 0x1807A45B0
	protected CommandBuffer GetCommandBuffer(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7A41E0 Offset: 0x7A27E0 VA: 0x1807A41E0
	protected void CleanupCamera(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7A42B0 Offset: 0x7A28B0 VA: 0x1807A42B0
	protected void CleanupCommandBuffer(Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7A4360 Offset: 0x7A2960 VA: 0x1807A4360
	protected void Cleanup() { }

	// RVA: 0x7A47B0 Offset: 0x7A2DB0 VA: 0x1807A47B0
	public void .ctor() { }

}

