public struct ConfiguredTaskAwaitable // TypeDefIndex: 1292
{	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: 0x14BFE0 Offset: 0x14B3E0 VA: 0x18014BFE0
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x14B770 Offset: 0x14AB70 VA: 0x18014B770
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

	// RVA: 0x14C0C0 Offset: 0x14B4C0 VA: 0x18014C0C0
	public bool get_IsCompleted() { }

	// RVA: 0x14C060 Offset: 0x14B460 VA: 0x18014C060 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x14C090 Offset: 0x14B490 VA: 0x18014C090 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x14C050 Offset: 0x14B450 VA: 0x18014C050
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
	|-RVA: 0x14C0C0 Offset: 0x14B4C0 VA: 0x18014C0C0
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
	|-RVA: 0x14C060 Offset: 0x14B460 VA: 0x18014C060
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
	|-RVA: 0x14C090 Offset: 0x14B490 VA: 0x18014C090
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
	|-RVA: 0x1E2E80 Offset: 0x1E2280 VA: 0x1801E2E80
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
	|-RVA: 0x1E2F10 Offset: 0x1E2310 VA: 0x1801E2F10
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<PublishResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Image>>.GetResult
	|
	|-RVA: 0x1E3090 Offset: 0x1E2490 VA: 0x1801E3090
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0x1E3140 Offset: 0x1E2540 VA: 0x1801E3140
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-RVA: 0x1E2FD0 Offset: 0x1E23D0 VA: 0x1801E2FD0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-RVA: 0x1E3380 Offset: 0x1E2780 VA: 0x1801E3380
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-RVA: 0x1E3240 Offset: 0x1E2640 VA: 0x1801E3240
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<Item>>.GetResult
	*/

}

