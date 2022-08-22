public class SignContent : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 9517
{	// Fields
	private uint[] textureIDs; // 0x170
	private List<ulong> editHistory; // 0x178

	// Properties
	protected override uint CrcToLoad { get; }
	protected override FileStorage.Type StorageType { get; }

	// Methods

	// RVA: 0x59A3A0 Offset: 0x5989A0 VA: 0x18059A3A0 Slot: 132
	protected override uint get_CrcToLoad() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 131
	protected override FileStorage.Type get_StorageType() { }

	// RVA: 0x59A310 Offset: 0x598910 VA: 0x18059A310
	public void .ctor() { }

}

