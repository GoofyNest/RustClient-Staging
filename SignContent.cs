public class SignContent : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 9517
{	// Fields
	private uint[] textureIDs; // 0x170
	private List<ulong> editHistory; // 0x178

	// Properties
	protected override uint CrcToLoad { get; }
	protected override FileStorage.Type StorageType { get; }

	// Methods

	// RVA: 0x59A410 Offset: 0x598A10 VA: 0x18059A410 Slot: 132
	protected override uint get_CrcToLoad() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 131
	protected override FileStorage.Type get_StorageType() { }

	// RVA: 0x59A380 Offset: 0x598980 VA: 0x18059A380
	public void .ctor() { }

}

