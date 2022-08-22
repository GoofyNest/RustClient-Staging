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
	// RVA: 0x900120 Offset: 0x8FE720 VA: 0x180900120
	public ulong get_PhotographerSteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907160 Offset: 0x905760 VA: 0x180907160
	private void set_PhotographerSteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907140 Offset: 0x905740 VA: 0x180907140
	public uint get_ImageCrc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x907150 Offset: 0x905750 VA: 0x180907150
	private void set_ImageCrc(uint value) { }

	// RVA: 0x907140 Offset: 0x905740 VA: 0x180907140 Slot: 132
	protected override uint get_CrcToLoad() { }

	// RVA: 0x9070C0 Offset: 0x9056C0 VA: 0x1809070C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x907130 Offset: 0x905730 VA: 0x180907130
	public void .ctor() { }

}

