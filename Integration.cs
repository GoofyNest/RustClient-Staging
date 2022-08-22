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

	// RVA: 0x106EEE0 Offset: 0x106D4E0 VA: 0x18106EEE0 Slot: 4
	public override string get_PublicKey() { }

	// RVA: 0x106EEB0 Offset: 0x106D4B0 VA: 0x18106EEB0 Slot: 5
	public override string get_Bucket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106EBD0 Offset: 0x106D1D0 VA: 0x18106EBD0
	public void add_OnManifestUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106F380 Offset: 0x106D980 VA: 0x18106F380
	public void remove_OnManifestUpdated(Action value) { }

	// RVA: 0x106E9B0 Offset: 0x106CFB0 VA: 0x18106E9B0 Slot: 6
	public override void OnManifestFile(Manifest manifest) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106EC70 Offset: 0x106D270 VA: 0x18106EC70
	public void add_OnServerMetadataUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106F420 Offset: 0x106DA20 VA: 0x18106F420
	public void remove_OnServerMetadataUpdated(Action value) { }

	// RVA: 0xDD79F0 Offset: 0xDD5FF0 VA: 0x180DD79F0 Slot: 7
	public override void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	// RVA: 0x106F170 Offset: 0x106D770 VA: 0x18106F170 Slot: 8
	public override string get_UserId() { }

	// RVA: 0x106F280 Offset: 0x106D880 VA: 0x18106F280 Slot: 9
	public override string get_UserName() { }

	// RVA: 0x106ED10 Offset: 0x106D310 VA: 0x18106ED10 Slot: 14
	public override Auth get_Auth() { }

	// RVA: 0x106E9D0 Offset: 0x106CFD0 VA: 0x18106E9D0 Slot: 19
	public override bool ShouldReportException(string message, string stackTrace, LogType type) { }

	// RVA: 0x106EF10 Offset: 0x106D510 VA: 0x18106EF10 Slot: 10
	public override string get_ServerAddress() { }

	// RVA: 0x106F080 Offset: 0x106D680 VA: 0x18106F080 Slot: 11
	public override string get_ServerName() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

