public class PhotoEntity : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 8815
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <PhotographerSteamId>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <ImageCrc>k__BackingField; // 0x178

	public ulong PhotographerSteamId { get; set; }
	public uint ImageCrc { get; set; }
	protected override uint CrcToLoad { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ulong get_PhotographerSteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_PhotographerSteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public uint get_ImageCrc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ImageCrc(uint value) { }

	protected override uint get_CrcToLoad() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

