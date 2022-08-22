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

	// RVA: 0x106E1B0 Offset: 0x106C7B0 VA: 0x18106E1B0 Slot: 4
	public override string get_PublicKey() { }

	// RVA: 0x106E180 Offset: 0x106C780 VA: 0x18106E180 Slot: 5
	public override string get_Bucket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106DEA0 Offset: 0x106C4A0 VA: 0x18106DEA0
	public void add_OnManifestUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106E650 Offset: 0x106CC50 VA: 0x18106E650
	public void remove_OnManifestUpdated(Action value) { }

	// RVA: 0x106DC80 Offset: 0x106C280 VA: 0x18106DC80 Slot: 6
	public override void OnManifestFile(Manifest manifest) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106DF40 Offset: 0x106C540 VA: 0x18106DF40
	public void add_OnServerMetadataUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106E6F0 Offset: 0x106CCF0 VA: 0x18106E6F0
	public void remove_OnServerMetadataUpdated(Action value) { }

	// RVA: 0xDD6C80 Offset: 0xDD5280 VA: 0x180DD6C80 Slot: 7
	public override void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	// RVA: 0x106E440 Offset: 0x106CA40 VA: 0x18106E440 Slot: 8
	public override string get_UserId() { }

	// RVA: 0x106E550 Offset: 0x106CB50 VA: 0x18106E550 Slot: 9
	public override string get_UserName() { }

	// RVA: 0x106DFE0 Offset: 0x106C5E0 VA: 0x18106DFE0 Slot: 14
	public override Auth get_Auth() { }

	// RVA: 0x106DCA0 Offset: 0x106C2A0 VA: 0x18106DCA0 Slot: 19
	public override bool ShouldReportException(string message, string stackTrace, LogType type) { }

	// RVA: 0x106E1E0 Offset: 0x106C7E0 VA: 0x18106E1E0 Slot: 10
	public override string get_ServerAddress() { }

	// RVA: 0x106E350 Offset: 0x106C950 VA: 0x18106E350 Slot: 11
	public override string get_ServerName() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

