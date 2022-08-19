public class CommandBufferDesc // TypeDefIndex: 10644
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CameraEvent <CameraEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <OrderId>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action<CommandBuffer> <FillDelegate>k__BackingField; // 0x18

	// Properties
	public CameraEvent CameraEvent { get; set; }
	public int OrderId { get; set; }
	public Action<CommandBuffer> FillDelegate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public CameraEvent get_CameraEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_CameraEvent(CameraEvent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_OrderId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	private void set_OrderId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Action<CommandBuffer> get_FillDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_FillDelegate(Action<CommandBuffer> value) { }

	// RVA: 0x57C930 Offset: 0x57AF30 VA: 0x18057C930
	public void .ctor(CameraEvent cameraEvent, int orderId, CommandBufferDesc.FillCommandBuffer fill) { }

}

public sealed class CommandBufferDesc.FillCommandBuffer : MulticastDelegate // TypeDefIndex: 10645
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x583E20 Offset: 0x582420 VA: 0x180583E20 Slot: 12
	public virtual void Invoke(CommandBuffer cb) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(CommandBuffer cb, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

