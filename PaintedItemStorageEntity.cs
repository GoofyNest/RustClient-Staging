public class PaintedItemStorageEntity : BaseEntity, IServerFileReceiver, IUGCBrowserEntity // TypeDefIndex: 8612
{	// Fields
	private uint _currentImageCrc; // 0x168
	public List<PaintableItem> Targets; // 0x170
	private uint _loadingCrc; // 0x178
	private byte[] _loadedImage; // 0x180
	private uint _loadedImageCrc; // 0x188
	private Action _timeoutAction; // 0x190

	// Methods

	// RVA: 0x85B470 Offset: 0x859A70 VA: 0x18085B470 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x85B3E0 Offset: 0x8599E0 VA: 0x18085B3E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x85BA50 Offset: 0x85A050 VA: 0x18085BA50
	public void Setup(PaintableItem target) { }

	// RVA: 0x85BBE0 Offset: 0x85A1E0 VA: 0x18085BBE0
	public void UpdateImage(Texture2D texture) { }

	// RVA: 0x85BB70 Offset: 0x85A170 VA: 0x18085BB70
	public bool TryGetImageData(out byte[] data) { }

	// RVA: 0x85AE20 Offset: 0x859420 VA: 0x18085AE20 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x85B070 Offset: 0x859670 VA: 0x18085B070
	private void LoadImage() { }

	// RVA: 0x85B8F0 Offset: 0x859EF0 VA: 0x18085B8F0
	private void RequestImage() { }

	// RVA: 0x85B9D0 Offset: 0x859FD0 VA: 0x18085B9D0
	private void RequestTimedOut() { }

	// RVA: 0x85AEA0 Offset: 0x8594A0 VA: 0x18085AEA0 Slot: 131
	private void IServerFileReceiver.OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

	// RVA: 0x85B7E0 Offset: 0x859DE0 VA: 0x18085B7E0
	private void RemoveInvalidTargets() { }

	// RVA: 0x85B560 Offset: 0x859B60 VA: 0x18085B560
	public static void RebuildAll() { }

	[ConditionalAttribute] // RVA: 0xB2420 Offset: 0xB1820 VA: 0x1800B2420
	// RVA: 0x85ADB0 Offset: 0x8593B0 VA: 0x18085ADB0
	private void DebugOnlyLog(string str) { }

	// RVA: 0x85BEA0 Offset: 0x85A4A0 VA: 0x18085BEA0
	public void .ctor() { }

}

private sealed class PaintedItemStorageEntity.<>c // TypeDefIndex: 8613
{	// Fields
	public static readonly PaintedItemStorageEntity.<>c <>9; // 0x0
	public static Predicate<PaintableItem> <>9__16_0; // 0x8

	// Methods

	// RVA: 0x875F70 Offset: 0x874570 VA: 0x180875F70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x875400 Offset: 0x873A00 VA: 0x180875400
	internal bool <RemoveInvalidTargets>b__16_0(PaintableItem t) { }

}

