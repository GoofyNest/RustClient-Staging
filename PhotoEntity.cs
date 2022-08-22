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
	// RVA: 0x900010 Offset: 0x8FE610 VA: 0x180900010
	public ulong get_PhotographerSteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907050 Offset: 0x905650 VA: 0x180907050
	private void set_PhotographerSteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907030 Offset: 0x905630 VA: 0x180907030
	public uint get_ImageCrc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907040 Offset: 0x905640 VA: 0x180907040
	private void set_ImageCrc(uint value) { }

	// RVA: 0x907030 Offset: 0x905630 VA: 0x180907030 Slot: 132
	protected override uint get_CrcToLoad() { }

	// RVA: 0x906FB0 Offset: 0x9055B0 VA: 0x180906FB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x907020 Offset: 0x905620 VA: 0x180907020
	public void .ctor() { }

}

