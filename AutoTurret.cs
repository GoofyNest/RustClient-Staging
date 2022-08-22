public class AutoTurret : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6331
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimPos; // 0x14
	public Vector3 aimDir; // 0x20
	public uint targetID; // 0x2C
	public List<PlayerNameID> users; // 0x30

	// Methods

	// RVA: 0x1FFA840 Offset: 0x1FF8E40 VA: 0x181FFA840
	public static void ResetToPool(AutoTurret instance) { }

	// RVA: 0x1FFA650 Offset: 0x1FF8C50 VA: 0x181FFA650
	public void ResetToPool() { }

	// RVA: 0x1FFA360 Offset: 0x1FF8960 VA: 0x181FFA360 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF8E90 Offset: 0x1FF7490 VA: 0x181FF8E90
	public void CopyTo(AutoTurret instance) { }

	// RVA: 0x1FF8FE0 Offset: 0x1FF75E0 VA: 0x181FF8FE0
	public AutoTurret Copy() { }

	// RVA: 0x1FF9E00 Offset: 0x1FF8400 VA: 0x181FF9E00
	public static AutoTurret Deserialize(Stream stream) { }

	// RVA: 0x1FF94A0 Offset: 0x1FF7AA0 VA: 0x181FF94A0
	public static AutoTurret DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF9810 Offset: 0x1FF7E10 VA: 0x181FF9810
	public static AutoTurret DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFA070 Offset: 0x1FF8670 VA: 0x181FFA070
	public static AutoTurret Deserialize(byte[] buffer) { }

	// RVA: 0x1FFA3E0 Offset: 0x1FF89E0 VA: 0x181FFA3E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFB4D0 Offset: 0x1FF9AD0 VA: 0x181FFB4D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFB4F0 Offset: 0x1FF9AF0 VA: 0x181FFB4F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AutoTurret previous) { }

	// RVA: 0x1FFA630 Offset: 0x1FF8C30 VA: 0x181FFA630 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF9AF0 Offset: 0x1FF80F0 VA: 0x181FF9AF0
	public static AutoTurret Deserialize(byte[] buffer, AutoTurret instance, bool isDelta = False) { }

	// RVA: 0x1FF98A0 Offset: 0x1FF7EA0 VA: 0x181FF98A0
	public static AutoTurret Deserialize(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF9180 Offset: 0x1FF7780 VA: 0x181FF9180
	public static AutoTurret DeserializeLengthDelimited(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF9520 Offset: 0x1FF7B20 VA: 0x181FF9520
	public static AutoTurret DeserializeLength(Stream stream, int length, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FFAA30 Offset: 0x1FF9030 VA: 0x181FFAA30
	public static void SerializeDelta(Stream stream, AutoTurret instance, AutoTurret previous) { }

	// RVA: 0x1FFB110 Offset: 0x1FF9710 VA: 0x181FFB110
	public static void Serialize(Stream stream, AutoTurret instance) { }

	// RVA: 0x1FFB4C0 Offset: 0x1FF9AC0 VA: 0x181FFB4C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFB4D0 Offset: 0x1FF9AD0 VA: 0x181FFB4D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFB000 Offset: 0x1FF9600 VA: 0x181FFB000
	public static byte[] SerializeToBytes(AutoTurret instance) { }

	// RVA: 0x1FFAF50 Offset: 0x1FF9550 VA: 0x181FFAF50
	public static void SerializeLengthDelimited(Stream stream, AutoTurret instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x8391F0 Offset: 0x8377F0 VA: 0x1808391F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x83C4B0 Offset: 0x83AAB0 VA: 0x18083C4B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x83B030 Offset: 0x839630 VA: 0x18083B030 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x83B840 Offset: 0x839E40 VA: 0x18083B840 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x838FA0 Offset: 0x8375A0 VA: 0x180838FA0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void InitializeClientsideEffects() { }

	// RVA: 0x8390D0 Offset: 0x8376D0 VA: 0x1808390D0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x838FB0 Offset: 0x8375B0 VA: 0x180838FB0
	public void ClientTick() { }

	// RVA: 0x83BE40 Offset: 0x83A440 VA: 0x18083BE40
	private void UpdateSounds(bool didTurn) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x83A410 Offset: 0x838A10 VA: 0x18083A410 Slot: 166
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838E90 Offset: 0x837490 VA: 0x180838E90
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8389D0 Offset: 0x836FD0 VA: 0x1808389D0
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.Description] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.Icon] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x83AD30 Offset: 0x839330 VA: 0x18083AD30
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.Description] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.Icon] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	// RVA: 0x83AC50 Offset: 0x839250 VA: 0x18083AC50
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x83ABE0 Offset: 0x8391E0 VA: 0x18083ABE0
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.Description] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.Icon] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	// RVA: 0x83ACF0 Offset: 0x8392F0 VA: 0x18083ACF0
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x83AC90 Offset: 0x839290 VA: 0x18083AC90
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.Description] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.Icon] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	// RVA: 0x83ACB0 Offset: 0x8392B0 VA: 0x18083ACB0
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x83AC90 Offset: 0x839290 VA: 0x18083AC90
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.Description] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.Icon] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	// RVA: 0x83AE80 Offset: 0x839480 VA: 0x18083AE80
	public void MenuTurretRotate(BasePlayer player) { }

	// RVA: 0x83AC90 Offset: 0x839290 VA: 0x18083AC90
	public bool MenuTurretRotate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.Description] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.Icon] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	// RVA: 0x83AE40 Offset: 0x839440 VA: 0x18083AE40
	public void MenuTurretPeacekeeper(BasePlayer player) { }

	// RVA: 0x83AE00 Offset: 0x839400 VA: 0x18083AE00
	public bool MenuTurretPeacekeeper_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.Description] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.Icon] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	// RVA: 0x83ADC0 Offset: 0x8393C0 VA: 0x18083ADC0
	public void MenuTurretAttackAll(BasePlayer player) { }

	// RVA: 0x83AD80 Offset: 0x839380 VA: 0x18083AD80
	public bool MenuTurretAttackAll_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.Icon] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.Description] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	// RVA: 0x83AF00 Offset: 0x839500 VA: 0x18083AF00
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0x83AEC0 Offset: 0x8394C0 VA: 0x18083AEC0 Slot: 176
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool PeacekeeperMode() { }

	// RVA: 0x83A8C0 Offset: 0x838EC0 VA: 0x18083A8C0
	public bool IsBeingRemoteControlled() { }

	// RVA: 0x8391D0 Offset: 0x8377D0 VA: 0x1808391D0 Slot: 167
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

	// RVA: 0x83BE30 Offset: 0x83A430 VA: 0x18083BE30 Slot: 170
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x8391E0 Offset: 0x8377E0 VA: 0x1808391E0 Slot: 171
	public string GetIdentifier() { }

	// RVA: 0x4A6090 Offset: 0x4A4690 VA: 0x1804A6090 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430
	public bool IsOnline() { }

	// RVA: 0x6FDC20 Offset: 0x6FC220 VA: 0x1806FDC20
	public bool IsOffline() { }

	// RVA: 0x83B7B0 Offset: 0x839DB0 VA: 0x18083B7B0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x8391C0 Offset: 0x8377C0 VA: 0x1808391C0 Slot: 179
	public virtual Transform GetCenterMuzzle() { }

	// RVA: 0x8387C0 Offset: 0x836DC0 VA: 0x1808387C0
	public float AngleToTarget(BaseCombatEntity potentialtarget, bool use2D = False) { }

	// RVA: 0x83A540 Offset: 0x838B40 VA: 0x18083A540 Slot: 180
	public virtual bool InFiringArc(BaseCombatEntity potentialtarget) { }

	// RVA: 0x838F50 Offset: 0x837550 VA: 0x180838F50 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x83AB40 Offset: 0x839140 VA: 0x18083AB40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x83C280 Offset: 0x83A880 VA: 0x18083C280
	public void Update() { }

	// RVA: 0x838530 Offset: 0x836B30 VA: 0x180838530
	public Vector3 AimOffset(BaseCombatEntity aimat) { }

	// RVA: 0x839190 Offset: 0x837790 VA: 0x180839190
	public float GetAimSpeed() { }

	// RVA: 0x83B990 Offset: 0x839F90 VA: 0x18083B990
	public void UpdateAiming() { }

	// RVA: 0x83A920 Offset: 0x838F20 VA: 0x18083A920
	private static Quaternion Lerp(Quaternion from, Quaternion to, float speed) { }

	// RVA: 0x83AA20 Offset: 0x839020 VA: 0x18083AA20
	private static Vector3 Lerp(Vector3 from, Vector3 to, float speed) { }

	// RVA: 0x83A750 Offset: 0x838D50 VA: 0x18083A750
	public bool IsAuthed(ulong id) { }

	// RVA: 0x83A800 Offset: 0x838E00 VA: 0x18083A800
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x838980 Offset: 0x836F80 VA: 0x180838980
	public bool AnyAuthed() { }

	// RVA: 0x838EF0 Offset: 0x8374F0 VA: 0x180838EF0 Slot: 181
	public virtual bool CanChangeSettings(BasePlayer player) { }

	// RVA: 0x83C3C0 Offset: 0x83A9C0 VA: 0x18083C3C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83B870 Offset: 0x839E70 VA: 0x18083B870
	private bool <Menu_AssignToFriend>b__46_0(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83B920 Offset: 0x839F20 VA: 0x18083B920
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

	// RVA: 0x705950 Offset: 0x703F50 VA: 0x180705950
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class AutoTurret.<>c__DisplayClass107_0 // TypeDefIndex: 8314
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705920 Offset: 0x703F20 VA: 0x180705920
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

