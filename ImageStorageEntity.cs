public class ImageStorageEntity : BaseEntity // TypeDefIndex: 8580
{	// Fields
	private List<ImageStorageEntity.ImageRequest> _requests; // 0x168

	// Properties
	protected virtual FileStorage.Type StorageType { get; }
	protected virtual uint CrcToLoad { get; }

	// Methods

	// RVA: 0x80EEC0 Offset: 0x80D4C0 VA: 0x18080EEC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 131
	protected virtual FileStorage.Type get_StorageType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 132
	protected virtual uint get_CrcToLoad() { }

	// RVA: 0x80F370 Offset: 0x80D970 VA: 0x18080F370
	private void RequestImage(IImageReceiver receiver) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x80F320 Offset: 0x80D920 VA: 0x18080F320
	private void ReceiveImage(BaseEntity.RPCMessage msg) { }

	// RVA: 0x80EB10 Offset: 0x80D110 VA: 0x18080EB10
	private void LoadFromBytes(byte[] imageData) { }

	[IteratorStateMachineAttribute] // RVA: 0xAC080 Offset: 0xAB480 VA: 0x1800AC080
	// RVA: 0x80EE40 Offset: 0x80D440 VA: 0x18080EE40
	public static IEnumerator LoadImage(uint imageStorageEntityId, IImageReceiver receiver) { }

	// RVA: 0x80F760 Offset: 0x80DD60 VA: 0x18080F760
	public void .ctor() { }

}

private struct ImageStorageEntity.ImageRequest // TypeDefIndex: 8581
{	// Fields
	public IImageReceiver Receiver; // 0x0
	public float Time; // 0x8

}

private sealed class ImageStorageEntity.<>c // TypeDefIndex: 8582
{	// Fields
	public static readonly ImageStorageEntity.<>c <>9; // 0x0
	public static Predicate<ImageStorageEntity.ImageRequest> <>9__7_0; // 0x8
	public static Func<ImageStorageEntity.ImageRequest, IImageReceiver> <>9__7_1; // 0x10

	// Methods

	// RVA: 0x821D50 Offset: 0x820350 VA: 0x180821D50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8208F0 Offset: 0x81EEF0 VA: 0x1808208F0
	internal bool <RequestImage>b__7_0(ImageStorageEntity.ImageRequest r) { }

	// RVA: 0x820960 Offset: 0x81EF60 VA: 0x180820960
	internal IImageReceiver <RequestImage>b__7_1(ImageStorageEntity.ImageRequest r) { }

}

private sealed class ImageStorageEntity.<LoadImage>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8583
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public uint imageStorageEntityId; // 0x20
	public IImageReceiver receiver; // 0x28
	private RealTimeSince <sinceStart>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x820470 Offset: 0x81EA70 VA: 0x180820470 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x820620 Offset: 0x81EC20 VA: 0x180820620 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

