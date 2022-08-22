public class CommandBufferDesc // TypeDefIndex: 10644
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CameraEvent <CameraEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <OrderId>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<CommandBuffer> <FillDelegate>k__BackingField; // 0x18

	public CameraEvent CameraEvent { get; set; }
	public int OrderId { get; set; }
	public Action<CommandBuffer> FillDelegate { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public CameraEvent get_CameraEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_CameraEvent(CameraEvent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_OrderId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_OrderId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Action<CommandBuffer> get_FillDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_FillDelegate(Action<CommandBuffer> value) { }

	public void .ctor(CameraEvent cameraEvent, int orderId, CommandBufferDesc.FillCommandBuffer fill) { }

}

public sealed class CommandBufferDesc.FillCommandBuffer : MulticastDelegate // TypeDefIndex: 10645
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(CommandBuffer cb) { }

	public virtual IAsyncResult BeginInvoke(CommandBuffer cb, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

