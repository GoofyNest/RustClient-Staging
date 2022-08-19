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

	// RVA: 0x14A9A40 Offset: 0x14A8040 VA: 0x1814A9A40 Slot: 5
	public virtual string get_Bucket() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OnManifestFile(Manifest manifest) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	// RVA: 0x14A9B30 Offset: 0x14A8130 VA: 0x1814A9B30 Slot: 8
	public virtual string get_UserId() { }

	// RVA: 0x14A9B70 Offset: 0x14A8170 VA: 0x1814A9B70 Slot: 9
	public virtual string get_UserName() { }

	// RVA: 0x14A9AB0 Offset: 0x14A80B0 VA: 0x1814A9AB0 Slot: 10
	public virtual string get_ServerAddress() { }

	// RVA: 0x14A9AF0 Offset: 0x14A80F0 VA: 0x1814A9AF0 Slot: 11
	public virtual string get_ServerName() { }

	// RVA: 0x14A9A90 Offset: 0x14A8090 VA: 0x1814A9A90 Slot: 12
	public virtual string get_LevelName() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	public virtual int get_MinutesPlayed() { }

	// RVA: 0x14A9970 Offset: 0x14A7F70 VA: 0x1814A9970 Slot: 14
	public virtual Auth get_Auth() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public virtual bool get_RestrictEditorFunctionality() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool get_LocalApi() { }

	// RVA: 0x14A9910 Offset: 0x14A7F10 VA: 0x1814A9910 Slot: 17
	public virtual string get_ApiUrl() { }

	// RVA: 0x14A9A80 Offset: 0x14A8080 VA: 0x1814A9A80 Slot: 18
	public virtual bool get_DebugOutput() { }

	// RVA: 0x14A98E0 Offset: 0x14A7EE0 VA: 0x1814A98E0 Slot: 19
	public virtual bool ShouldReportException(string message, string stackTrace, LogType type) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}
