public class PaintedItemStorageEntity : BaseEntity, IServerFileReceiver, IUGCBrowserEntity // TypeDefIndex: 8612
{	// Fields
	private uint _currentImageCrc; // 0x168
	public List<PaintableItem> Targets; // 0x170
	private uint _loadingCrc; // 0x178
	private byte[] _loadedImage; // 0x180
	private uint _loadedImageCrc; // 0x188
	private Action _timeoutAction; // 0x190

	// Methods

	// RVA: 0x876CE0 Offset: 0x8752E0 VA: 0x180876CE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x876C50 Offset: 0x875250 VA: 0x180876C50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8772C0 Offset: 0x8758C0 VA: 0x1808772C0
	public void Setup(PaintableItem target) { }

	// RVA: 0x877450 Offset: 0x875A50 VA: 0x180877450
	public void UpdateImage(Texture2D texture) { }

	// RVA: 0x8773E0 Offset: 0x8759E0 VA: 0x1808773E0
	public bool TryGetImageData(out byte[] data) { }

	// RVA: 0x876690 Offset: 0x874C90 VA: 0x180876690 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x8768E0 Offset: 0x874EE0 VA: 0x1808768E0
	private void LoadImage() { }

	// RVA: 0x877160 Offset: 0x875760 VA: 0x180877160
	private void RequestImage() { }

	// RVA: 0x877240 Offset: 0x875840 VA: 0x180877240
	private void RequestTimedOut() { }

	// RVA: 0x876710 Offset: 0x874D10 VA: 0x180876710 Slot: 131
	private void IServerFileReceiver.OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

	// RVA: 0x877050 Offset: 0x875650 VA: 0x180877050
	private void RemoveInvalidTargets() { }

	// RVA: 0x876DD0 Offset: 0x8753D0 VA: 0x180876DD0
	public static void RebuildAll() { }

	[ConditionalAttribute] // RVA: 0xB2510 Offset: 0xB1910 VA: 0x1800B2510
	// RVA: 0x876620 Offset: 0x874C20 VA: 0x180876620
	private void DebugOnlyLog(string str) { }

	// RVA: 0x877710 Offset: 0x875D10 VA: 0x180877710
	public void .ctor() { }

}

private sealed class PaintedItemStorageEntity.<>c // TypeDefIndex: 8613
{	// Fields
	public static readonly PaintedItemStorageEntity.<>c <>9; // 0x0
	public static Predicate<PaintableItem> <>9__16_0; // 0x8

	// Methods

	// RVA: 0x8917A0 Offset: 0x88FDA0 VA: 0x1808917A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x890C30 Offset: 0x88F230 VA: 0x180890C30
	internal bool <RemoveInvalidTargets>b__16_0(PaintableItem t) { }

}

