public class PaintedItemStorageEntity : BaseEntity, IServerFileReceiver, IUGCBrowserEntity // TypeDefIndex: 8612
{	// Fields
	private uint _currentImageCrc; // 0x168
	public List<PaintableItem> Targets; // 0x170
	private uint _loadingCrc; // 0x178
	private byte[] _loadedImage; // 0x180
	private uint _loadedImageCrc; // 0x188
	private Action _timeoutAction; // 0x190

	// Methods

	// RVA: 0x85B580 Offset: 0x859B80 VA: 0x18085B580 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x85B4F0 Offset: 0x859AF0 VA: 0x18085B4F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x85BB60 Offset: 0x85A160 VA: 0x18085BB60
	public void Setup(PaintableItem target) { }

	// RVA: 0x85BCF0 Offset: 0x85A2F0 VA: 0x18085BCF0
	public void UpdateImage(Texture2D texture) { }

	// RVA: 0x85BC80 Offset: 0x85A280 VA: 0x18085BC80
	public bool TryGetImageData(out byte[] data) { }

	// RVA: 0x85AF30 Offset: 0x859530 VA: 0x18085AF30 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x85B180 Offset: 0x859780 VA: 0x18085B180
	private void LoadImage() { }

	// RVA: 0x85BA00 Offset: 0x85A000 VA: 0x18085BA00
	private void RequestImage() { }

	// RVA: 0x85BAE0 Offset: 0x85A0E0 VA: 0x18085BAE0
	private void RequestTimedOut() { }

	// RVA: 0x85AFB0 Offset: 0x8595B0 VA: 0x18085AFB0 Slot: 131
	private void IServerFileReceiver.OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

	// RVA: 0x85B8F0 Offset: 0x859EF0 VA: 0x18085B8F0
	private void RemoveInvalidTargets() { }

	// RVA: 0x85B670 Offset: 0x859C70 VA: 0x18085B670
	public static void RebuildAll() { }

	[ConditionalAttribute] // RVA: 0xB2510 Offset: 0xB1910 VA: 0x1800B2510
	// RVA: 0x85AEC0 Offset: 0x8594C0 VA: 0x18085AEC0
	private void DebugOnlyLog(string str) { }

	// RVA: 0x85BFB0 Offset: 0x85A5B0 VA: 0x18085BFB0
	public void .ctor() { }

}

private sealed class PaintedItemStorageEntity.<>c // TypeDefIndex: 8613
{	// Fields
	public static readonly PaintedItemStorageEntity.<>c <>9; // 0x0
	public static Predicate<PaintableItem> <>9__16_0; // 0x8

	// Methods

	// RVA: 0x876080 Offset: 0x874680 VA: 0x180876080
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x875510 Offset: 0x873B10 VA: 0x180875510
	internal bool <RemoveInvalidTargets>b__16_0(PaintableItem t) { }

}

