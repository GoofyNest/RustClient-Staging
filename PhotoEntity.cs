public class PhotoEntity : ImageStorageEntity, IUGCBrowserEntity // TypeDefIndex: 8815
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ulong <PhotographerSteamId>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private uint <ImageCrc>k__BackingField; // 0x178

	public ulong PhotographerSteamId { get; set; }
	public uint ImageCrc { get; set; }
	protected override uint CrcToLoad { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ulong get_PhotographerSteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_PhotographerSteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public uint get_ImageCrc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_ImageCrc(uint value) { }

	protected override uint get_CrcToLoad() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

