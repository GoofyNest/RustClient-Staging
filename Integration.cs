public class Integration : BaseIntegration // TypeDefIndex: 8229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnManifestUpdated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnServerMetadataUpdated; // 0x18
	private Auth _auth; // 0x20
	private IAuthTicket _steamTicket; // 0x28

	// Properties
	public override string PublicKey { get; }
	public override string Bucket { get; }
	public override string UserId { get; }
	public override string UserName { get; }
	public override Auth Auth { get; }
	public override string ServerAddress { get; }
	public override string ServerName { get; }

	// Methods

	// RVA: 0x106E470 Offset: 0x106CA70 VA: 0x18106E470 Slot: 4
	public override string get_PublicKey() { }

	// RVA: 0x106E440 Offset: 0x106CA40 VA: 0x18106E440 Slot: 5
	public override string get_Bucket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106E160 Offset: 0x106C760 VA: 0x18106E160
	public void add_OnManifestUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106E910 Offset: 0x106CF10 VA: 0x18106E910
	public void remove_OnManifestUpdated(Action value) { }

	// RVA: 0x106DF40 Offset: 0x106C540 VA: 0x18106DF40 Slot: 6
	public override void OnManifestFile(Manifest manifest) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106E200 Offset: 0x106C800 VA: 0x18106E200
	public void add_OnServerMetadataUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106E9B0 Offset: 0x106CFB0 VA: 0x18106E9B0
	public void remove_OnServerMetadataUpdated(Action value) { }

	// RVA: 0xDD6F40 Offset: 0xDD5540 VA: 0x180DD6F40 Slot: 7
	public override void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	// RVA: 0x106E700 Offset: 0x106CD00 VA: 0x18106E700 Slot: 8
	public override string get_UserId() { }

	// RVA: 0x106E810 Offset: 0x106CE10 VA: 0x18106E810 Slot: 9
	public override string get_UserName() { }

	// RVA: 0x106E2A0 Offset: 0x106C8A0 VA: 0x18106E2A0 Slot: 14
	public override Auth get_Auth() { }

	// RVA: 0x106DF60 Offset: 0x106C560 VA: 0x18106DF60 Slot: 19
	public override bool ShouldReportException(string message, string stackTrace, LogType type) { }

	// RVA: 0x106E4A0 Offset: 0x106CAA0 VA: 0x18106E4A0 Slot: 10
	public override string get_ServerAddress() { }

	// RVA: 0x106E610 Offset: 0x106CC10 VA: 0x18106E610 Slot: 11
	public override string get_ServerName() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

