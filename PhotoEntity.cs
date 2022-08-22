public class PhotoEntity : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 8815
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <PhotographerSteamId>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <ImageCrc>k__BackingField; // 0x178

	// Properties
	public ulong PhotographerSteamId { get; set; }
	public uint ImageCrc { get; set; }
	protected override uint CrcToLoad { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x900630 Offset: 0x8FEC30 VA: 0x180900630
	public ulong get_PhotographerSteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907670 Offset: 0x905C70 VA: 0x180907670
	private void set_PhotographerSteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907650 Offset: 0x905C50 VA: 0x180907650
	public uint get_ImageCrc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907660 Offset: 0x905C60 VA: 0x180907660
	private void set_ImageCrc(uint value) { }

	// RVA: 0x907650 Offset: 0x905C50 VA: 0x180907650 Slot: 132
	protected override uint get_CrcToLoad() { }

	// RVA: 0x9075D0 Offset: 0x905BD0 VA: 0x1809075D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x907640 Offset: 0x905C40 VA: 0x180907640
	public void .ctor() { }

}

