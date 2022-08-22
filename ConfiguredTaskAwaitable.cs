public struct ConfiguredTaskAwaitable // TypeDefIndex: 1292
{	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: 0x14BE00 Offset: 0x14B200 VA: 0x18014BE00
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x14B590 Offset: 0x14A990 VA: 0x18014B590
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { }

}

public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1293
{	// Fields
	private readonly Task m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x8

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xFA3F0 Offset: 0xF97F0 VA: 0x1800FA3F0
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x14BEE0 Offset: 0x14B2E0 VA: 0x18014BEE0
	public bool get_IsCompleted() { }

	// RVA: 0x14BE80 Offset: 0x14B280 VA: 0x18014BE80 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x14BEB0 Offset: 0x14B2B0 VA: 0x18014BEB0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x14BE70 Offset: 0x14B270 VA: 0x18014BE70
	public void GetResult() { }

}

public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1295
{	// Fields
	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFA3F0 Offset: 0xF97F0 VA: 0x1800FA3F0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BEE0 Offset: 0x14B2E0 VA: 0x18014BEE0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BE80 Offset: 0x14B280 VA: 0x18014BE80
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.OnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BEB0 Offset: 0x14B2B0 VA: 0x18014BEB0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E32A0 Offset: 0x1E26A0 VA: 0x1801E32A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Int32Enum>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x1E3330 Offset: 0x1E2730 VA: 0x1801E3330
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.GetResult
	|
	|-RVA: 0x1E34B0 Offset: 0x1E28B0 VA: 0x1801E34B0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0x1E3560 Offset: 0x1E2960 VA: 0x1801E3560
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-RVA: 0x1E33F0 Offset: 0x1E27F0 VA: 0x1801E33F0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-RVA: 0x1E37A0 Offset: 0x1E2BA0 VA: 0x1801E37A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-RVA: 0x1E3660 Offset: 0x1E2A60 VA: 0x1801E3660
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.GetResult
	*/

}

