public class AutoTurret : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6331
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimPos; // 0x14
	public Vector3 aimDir; // 0x20
	public uint targetID; // 0x2C
	public List<PlayerNameID> users; // 0x30

	// Methods

	// RVA: 0x1FFAB00 Offset: 0x1FF9100 VA: 0x181FFAB00
	public static void ResetToPool(AutoTurret instance) { }

	// RVA: 0x1FFA910 Offset: 0x1FF8F10 VA: 0x181FFA910
	public void ResetToPool() { }

	// RVA: 0x1FFA620 Offset: 0x1FF8C20 VA: 0x181FFA620 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF9150 Offset: 0x1FF7750 VA: 0x181FF9150
	public void CopyTo(AutoTurret instance) { }

	// RVA: 0x1FF92A0 Offset: 0x1FF78A0 VA: 0x181FF92A0
	public AutoTurret Copy() { }

	// RVA: 0x1FFA0C0 Offset: 0x1FF86C0 VA: 0x181FFA0C0
	public static AutoTurret Deserialize(Stream stream) { }

	// RVA: 0x1FF9760 Offset: 0x1FF7D60 VA: 0x181FF9760
	public static AutoTurret DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF9AD0 Offset: 0x1FF80D0 VA: 0x181FF9AD0
	public static AutoTurret DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFA330 Offset: 0x1FF8930 VA: 0x181FFA330
	public static AutoTurret Deserialize(byte[] buffer) { }

	// RVA: 0x1FFA6A0 Offset: 0x1FF8CA0 VA: 0x181FFA6A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFB790 Offset: 0x1FF9D90 VA: 0x181FFB790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFB7B0 Offset: 0x1FF9DB0 VA: 0x181FFB7B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AutoTurret previous) { }

	// RVA: 0x1FFA8F0 Offset: 0x1FF8EF0 VA: 0x181FFA8F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF9DB0 Offset: 0x1FF83B0 VA: 0x181FF9DB0
	public static AutoTurret Deserialize(byte[] buffer, AutoTurret instance, bool isDelta = False) { }

	// RVA: 0x1FF9B60 Offset: 0x1FF8160 VA: 0x181FF9B60
	public static AutoTurret Deserialize(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF9440 Offset: 0x1FF7A40 VA: 0x181FF9440
	public static AutoTurret DeserializeLengthDelimited(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF97E0 Offset: 0x1FF7DE0 VA: 0x181FF97E0
	public static AutoTurret DeserializeLength(Stream stream, int length, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FFACF0 Offset: 0x1FF92F0 VA: 0x181FFACF0
	public static void SerializeDelta(Stream stream, AutoTurret instance, AutoTurret previous) { }

	// RVA: 0x1FFB3D0 Offset: 0x1FF99D0 VA: 0x181FFB3D0
	public static void Serialize(Stream stream, AutoTurret instance) { }

	// RVA: 0x1FFB780 Offset: 0x1FF9D80 VA: 0x181FFB780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFB790 Offset: 0x1FF9D90 VA: 0x181FFB790
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFB2C0 Offset: 0x1FF98C0 VA: 0x181FFB2C0
	public static byte[] SerializeToBytes(AutoTurret instance) { }

	// RVA: 0x1FFB210 Offset: 0x1FF9810 VA: 0x181FFB210
	public static void SerializeLengthDelimited(Stream stream, AutoTurret instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AutoTurret : ContainerIOEntity, IRemoteControllable // TypeDefIndex: 8311
{	// Fields
	private Option __menuOption_Menu_AssignToFriend; // 0x378
	private Option __menuOption_Menu_MaxAuth; // 0x3D0
	private Option __menuOption_MenuAuthorize; // 0x428
	private Option __menuOption_MenuClearList; // 0x480
	private Option __menuOption_MenuDeauthorize; // 0x4D8
	private Option __menuOption_MenuTurretAttackAll; // 0x530
	private Option __menuOption_MenuTurretPeacekeeper; // 0x588
	private Option __menuOption_MenuTurretRotate; // 0x5E0
	public GameObjectRef gun_fire_effect; // 0x638
	public GameObjectRef bulletEffect; // 0x640
	public float bulletSpeed; // 0x648
	public AmbienceEmitter ambienceEmitter; // 0x650
	public GameObject assignDialog; // 0x658
	private SoundModulation.Modulator turnSoundModulator; // 0x660
	private Sound turnLoop; // 0x668
	private float nextFocusSound; // 0x670
	private bool wasTurning; // 0x674
	private Quaternion lastYaw; // 0x678
	private BasePlayer playerController; // 0x688
	private string rcIdentifier; // 0x690
	private Vector3 initialAimDir; // 0x698
	public float rcTurnSensitivity; // 0x6A4
	public Transform RCEyes; // 0x6A8
	public TargetTrigger targetTrigger; // 0x6B0
	public Transform socketTransform; // 0x6B8
	public BaseCombatEntity target; // 0x6C0
	public Transform eyePos; // 0x6C8
	public Transform muzzlePos; // 0x6D0
	public Vector3 aimDir; // 0x6D8
	public Transform gun_yaw; // 0x6E8
	public Transform gun_pitch; // 0x6F0
	public float sightRange; // 0x6F8
	public SoundDefinition turnLoopDef; // 0x700
	public SoundDefinition movementChangeDef; // 0x708
	public SoundDefinition ambientLoopDef; // 0x710
	public SoundDefinition focusCameraDef; // 0x718
	public float focusSoundFreqMin; // 0x720
	public float focusSoundFreqMax; // 0x724
	public GameObjectRef peacekeeperToggleSound; // 0x728
	public GameObjectRef onlineSound; // 0x730
	public GameObjectRef offlineSound; // 0x738
	public GameObjectRef targetAcquiredEffect; // 0x740
	public GameObjectRef targetLostEffect; // 0x748
	public GameObjectRef reloadEffect; // 0x750
	public float aimCone; // 0x758
	public const BaseEntity.Flags Flag_Equipped = 512;
	public const BaseEntity.Flags Flag_MaxAuths = 1024;
	public List<PlayerNameID> authorizedPlayers; // 0x760

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }

	// Methods

	// RVA: 0x839300 Offset: 0x837900 VA: 0x180839300 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x83C5C0 Offset: 0x83ABC0 VA: 0x18083C5C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x83B140 Offset: 0x839740 VA: 0x18083B140 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x83B950 Offset: 0x839F50 VA: 0x18083B950 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x8390B0 Offset: 0x8376B0 VA: 0x1808390B0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void InitializeClientsideEffects() { }

	// RVA: 0x8391E0 Offset: 0x8377E0 VA: 0x1808391E0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x8390C0 Offset: 0x8376C0 VA: 0x1808390C0
	public void ClientTick() { }

	// RVA: 0x83BF50 Offset: 0x83A550 VA: 0x18083BF50
	private void UpdateSounds(bool didTurn) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x83A520 Offset: 0x838B20 VA: 0x18083A520 Slot: 166
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838FA0 Offset: 0x8375A0 VA: 0x180838FA0
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838AE0 Offset: 0x8370E0 VA: 0x180838AE0
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.Description] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.Icon] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x83AE40 Offset: 0x839440 VA: 0x18083AE40
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.Description] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.Icon] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	// RVA: 0x83AD60 Offset: 0x839360 VA: 0x18083AD60
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x83ACF0 Offset: 0x8392F0 VA: 0x18083ACF0
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.Description] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.Icon] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	// RVA: 0x83AE00 Offset: 0x839400 VA: 0x18083AE00
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x83ADA0 Offset: 0x8393A0 VA: 0x18083ADA0
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.Description] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.Icon] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	// RVA: 0x83ADC0 Offset: 0x8393C0 VA: 0x18083ADC0
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x83ADA0 Offset: 0x8393A0 VA: 0x18083ADA0
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.Description] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.Icon] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	// RVA: 0x83AF90 Offset: 0x839590 VA: 0x18083AF90
	public void MenuTurretRotate(BasePlayer player) { }

	// RVA: 0x83ADA0 Offset: 0x8393A0 VA: 0x18083ADA0
	public bool MenuTurretRotate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.Description] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.Icon] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	// RVA: 0x83AF50 Offset: 0x839550 VA: 0x18083AF50
	public void MenuTurretPeacekeeper(BasePlayer player) { }

	// RVA: 0x83AF10 Offset: 0x839510 VA: 0x18083AF10
	public bool MenuTurretPeacekeeper_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.Description] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.Icon] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	// RVA: 0x83AED0 Offset: 0x8394D0 VA: 0x18083AED0
	public void MenuTurretAttackAll(BasePlayer player) { }

	// RVA: 0x83AE90 Offset: 0x839490 VA: 0x18083AE90
	public bool MenuTurretAttackAll_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.Icon] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.Description] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	// RVA: 0x83B010 Offset: 0x839610 VA: 0x18083B010
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0x83AFD0 Offset: 0x8395D0 VA: 0x18083AFD0 Slot: 176
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool PeacekeeperMode() { }

	// RVA: 0x83A9D0 Offset: 0x838FD0 VA: 0x18083A9D0
	public bool IsBeingRemoteControlled() { }

	// RVA: 0x8392E0 Offset: 0x8378E0 VA: 0x1808392E0 Slot: 167
	public Transform GetEyes() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 169
	public bool Occupied() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 168
	public BaseEntity GetEnt() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 177
	public virtual bool CanControl() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 178
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 172
	public void RCSetup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 173
	public void RCShutdown() { }

	// RVA: 0x83BF40 Offset: 0x83A540 VA: 0x18083BF40 Slot: 170
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x8392F0 Offset: 0x8378F0 VA: 0x1808392F0 Slot: 171
	public string GetIdentifier() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430
	public bool IsOnline() { }

	// RVA: 0x6FDD30 Offset: 0x6FC330 VA: 0x1806FDD30
	public bool IsOffline() { }

	// RVA: 0x83B8C0 Offset: 0x839EC0 VA: 0x18083B8C0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x8392D0 Offset: 0x8378D0 VA: 0x1808392D0 Slot: 179
	public virtual Transform GetCenterMuzzle() { }

	// RVA: 0x8388D0 Offset: 0x836ED0 VA: 0x1808388D0
	public float AngleToTarget(BaseCombatEntity potentialtarget, bool use2D = False) { }

	// RVA: 0x83A650 Offset: 0x838C50 VA: 0x18083A650 Slot: 180
	public virtual bool InFiringArc(BaseCombatEntity potentialtarget) { }

	// RVA: 0x839060 Offset: 0x837660 VA: 0x180839060 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x83AC50 Offset: 0x839250 VA: 0x18083AC50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x83C390 Offset: 0x83A990 VA: 0x18083C390
	public void Update() { }

	// RVA: 0x838640 Offset: 0x836C40 VA: 0x180838640
	public Vector3 AimOffset(BaseCombatEntity aimat) { }

	// RVA: 0x8392A0 Offset: 0x8378A0 VA: 0x1808392A0
	public float GetAimSpeed() { }

	// RVA: 0x83BAA0 Offset: 0x83A0A0 VA: 0x18083BAA0
	public void UpdateAiming() { }

	// RVA: 0x83AA30 Offset: 0x839030 VA: 0x18083AA30
	private static Quaternion Lerp(Quaternion from, Quaternion to, float speed) { }

	// RVA: 0x83AB30 Offset: 0x839130 VA: 0x18083AB30
	private static Vector3 Lerp(Vector3 from, Vector3 to, float speed) { }

	// RVA: 0x83A860 Offset: 0x838E60 VA: 0x18083A860
	public bool IsAuthed(ulong id) { }

	// RVA: 0x83A910 Offset: 0x838F10 VA: 0x18083A910
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x838A90 Offset: 0x837090 VA: 0x180838A90
	public bool AnyAuthed() { }

	// RVA: 0x839000 Offset: 0x837600 VA: 0x180839000 Slot: 181
	public virtual bool CanChangeSettings(BasePlayer player) { }

	// RVA: 0x83C4D0 Offset: 0x83AAD0 VA: 0x18083C4D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83B980 Offset: 0x839F80 VA: 0x18083B980
	private bool <Menu_AssignToFriend>b__46_0(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83BA30 Offset: 0x83A030 VA: 0x18083BA30
	private void <Menu_AssignToFriend>b__46_1(ulong id, string steamName) { }

}

public static class AutoTurret.TurretFlags // TypeDefIndex: 8312
{	// Fields
	public const BaseEntity.Flags Peacekeeper = 128;

}

private sealed class AutoTurret.<>c__DisplayClass106_0 // TypeDefIndex: 8313
{	// Fields
	public ulong id; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705A60 Offset: 0x704060 VA: 0x180705A60
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class AutoTurret.<>c__DisplayClass107_0 // TypeDefIndex: 8314
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705A30 Offset: 0x704030 VA: 0x180705A30
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

