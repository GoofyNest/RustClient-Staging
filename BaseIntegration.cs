public abstract class BaseIntegration // TypeDefIndex: 6177
{	// Properties
	public abstract string PublicKey { get; }
	public virtual string Bucket { get; }
	public virtual string UserId { get; }
	public virtual string UserName { get; }
	public virtual string ServerAddress { get; }
	public virtual string ServerName { get; }
	public virtual string LevelName { get; }
	public virtual int MinutesPlayed { get; }
	public virtual Auth Auth { get; }
	public virtual bool RestrictEditorFunctionality { get; }
	public virtual bool LocalApi { get; }
	public virtual string ApiUrl { get; }
	public virtual bool DebugOutput { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_PublicKey();

	// RVA: 0x14A8DD0 Offset: 0x14A73D0 VA: 0x1814A8DD0 Slot: 5
	public virtual string get_Bucket() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OnManifestFile(Manifest manifest) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	// RVA: 0x14A8EC0 Offset: 0x14A74C0 VA: 0x1814A8EC0 Slot: 8
	public virtual string get_UserId() { }

	// RVA: 0x14A8F00 Offset: 0x14A7500 VA: 0x1814A8F00 Slot: 9
	public virtual string get_UserName() { }

	// RVA: 0x14A8E40 Offset: 0x14A7440 VA: 0x1814A8E40 Slot: 10
	public virtual string get_ServerAddress() { }

	// RVA: 0x14A8E80 Offset: 0x14A7480 VA: 0x1814A8E80 Slot: 11
	public virtual string get_ServerName() { }

	// RVA: 0x14A8E20 Offset: 0x14A7420 VA: 0x1814A8E20 Slot: 12
	public virtual string get_LevelName() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 13
	public virtual int get_MinutesPlayed() { }

	// RVA: 0x14A8D00 Offset: 0x14A7300 VA: 0x1814A8D00 Slot: 14
	public virtual Auth get_Auth() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 15
	public virtual bool get_RestrictEditorFunctionality() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool get_LocalApi() { }

	// RVA: 0x14A8CA0 Offset: 0x14A72A0 VA: 0x1814A8CA0 Slot: 17
	public virtual string get_ApiUrl() { }

	// RVA: 0x14A8E10 Offset: 0x14A7410 VA: 0x1814A8E10 Slot: 18
	public virtual bool get_DebugOutput() { }

	// RVA: 0x14A8C70 Offset: 0x14A7270 VA: 0x1814A8C70 Slot: 19
	public virtual bool ShouldReportException(string message, string stackTrace, LogType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

