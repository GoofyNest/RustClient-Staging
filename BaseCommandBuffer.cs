public class BaseCommandBuffer : MonoBehaviour // TypeDefIndex: 11293
{	private Dictionary<Camera, Dictionary<int, CommandBuffer>> cameras; // 0x18


	protected CommandBuffer GetCommandBuffer(string name, Camera camera, CameraEvent cameraEvent) { }

	protected void CleanupCamera(string name, Camera camera, CameraEvent cameraEvent) { }

	protected void CleanupCommandBuffer(Camera camera, CameraEvent cameraEvent) { }

	protected void Cleanup() { }

	public void .ctor() { }

}

