public class AutoTurret : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6331
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimPos; // 0x14
	public Vector3 aimDir; // 0x20
	public uint targetID; // 0x2C
	public List<PlayerNameID> users; // 0x30

	// Methods

	// RVA: 0x1FFB320 Offset: 0x1FF9920 VA: 0x181FFB320
	public static void ResetToPool(AutoTurret instance) { }

	// RVA: 0x1FFB130 Offset: 0x1FF9730 VA: 0x181FFB130
	public void ResetToPool() { }

	// RVA: 0x1FFAE40 Offset: 0x1FF9440 VA: 0x181FFAE40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF9970 Offset: 0x1FF7F70 VA: 0x181FF9970
	public void CopyTo(AutoTurret instance) { }

	// RVA: 0x1FF9AC0 Offset: 0x1FF80C0 VA: 0x181FF9AC0
	public AutoTurret Copy() { }

	// RVA: 0x1FFA8E0 Offset: 0x1FF8EE0 VA: 0x181FFA8E0
	public static AutoTurret Deserialize(Stream stream) { }

	// RVA: 0x1FF9F80 Offset: 0x1FF8580 VA: 0x181FF9F80
	public static AutoTurret DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFA2F0 Offset: 0x1FF88F0 VA: 0x181FFA2F0
	public static AutoTurret DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFAB50 Offset: 0x1FF9150 VA: 0x181FFAB50
	public static AutoTurret Deserialize(byte[] buffer) { }

	// RVA: 0x1FFAEC0 Offset: 0x1FF94C0 VA: 0x181FFAEC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFBFB0 Offset: 0x1FFA5B0 VA: 0x181FFBFB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFBFD0 Offset: 0x1FFA5D0 VA: 0x181FFBFD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AutoTurret previous) { }

	// RVA: 0x1FFB110 Offset: 0x1FF9710 VA: 0x181FFB110 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFA5D0 Offset: 0x1FF8BD0 VA: 0x181FFA5D0
	public static AutoTurret Deserialize(byte[] buffer, AutoTurret instance, bool isDelta = False) { }

	// RVA: 0x1FFA380 Offset: 0x1FF8980 VA: 0x181FFA380
	public static AutoTurret Deserialize(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF9C60 Offset: 0x1FF8260 VA: 0x181FF9C60
	public static AutoTurret DeserializeLengthDelimited(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FFA000 Offset: 0x1FF8600 VA: 0x181FFA000
	public static AutoTurret DeserializeLength(Stream stream, int length, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FFB510 Offset: 0x1FF9B10 VA: 0x181FFB510
	public static void SerializeDelta(Stream stream, AutoTurret instance, AutoTurret previous) { }

	// RVA: 0x1FFBBF0 Offset: 0x1FFA1F0 VA: 0x181FFBBF0
	public static void Serialize(Stream stream, AutoTurret instance) { }

	// RVA: 0x1FFBFA0 Offset: 0x1FFA5A0 VA: 0x181FFBFA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFBFB0 Offset: 0x1FFA5B0 VA: 0x181FFBFB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFBAE0 Offset: 0x1FFA0E0 VA: 0x181FFBAE0
	public static byte[] SerializeToBytes(AutoTurret instance) { }

	// RVA: 0x1FFBA30 Offset: 0x1FFA030 VA: 0x181FFBA30
	public static void SerializeLengthDelimited(Stream stream, AutoTurret instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x839850 Offset: 0x837E50 VA: 0x180839850 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x83CB10 Offset: 0x83B110 VA: 0x18083CB10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x83B690 Offset: 0x839C90 VA: 0x18083B690 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x83BEA0 Offset: 0x83A4A0 VA: 0x18083BEA0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x839600 Offset: 0x837C00 VA: 0x180839600 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void InitializeClientsideEffects() { }

	// RVA: 0x839730 Offset: 0x837D30 VA: 0x180839730 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x839610 Offset: 0x837C10 VA: 0x180839610
	public void ClientTick() { }

	// RVA: 0x83C4A0 Offset: 0x83AAA0 VA: 0x18083C4A0
	private void UpdateSounds(bool didTurn) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x83AA70 Offset: 0x839070 VA: 0x18083AA70 Slot: 166
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8394F0 Offset: 0x837AF0 VA: 0x1808394F0
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x839030 Offset: 0x837630 VA: 0x180839030
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.Description] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.Icon] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2660 Offset: 0xB1A60 VA: 0x1800B2660
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x83B390 Offset: 0x839990 VA: 0x18083B390
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.Description] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.Icon] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2B20 Offset: 0xB1F20 VA: 0x1800B2B20
	// RVA: 0x83B2B0 Offset: 0x8398B0 VA: 0x18083B2B0
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x83B240 Offset: 0x839840 VA: 0x18083B240
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.Description] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.Icon] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2E00 Offset: 0xB2200 VA: 0x1800B2E00
	// RVA: 0x83B350 Offset: 0x839950 VA: 0x18083B350
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x83B2F0 Offset: 0x8398F0 VA: 0x18083B2F0
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.Description] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.Icon] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3000 Offset: 0xB2400 VA: 0x1800B3000
	// RVA: 0x83B310 Offset: 0x839910 VA: 0x18083B310
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x83B2F0 Offset: 0x8398F0 VA: 0x18083B2F0
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.Description] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.Icon] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3330 Offset: 0xB2730 VA: 0x1800B3330
	// RVA: 0x83B4E0 Offset: 0x839AE0 VA: 0x18083B4E0
	public void MenuTurretRotate(BasePlayer player) { }

	// RVA: 0x83B2F0 Offset: 0x8398F0 VA: 0x18083B2F0
	public bool MenuTurretRotate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.Description] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.Icon] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	// RVA: 0x83B4A0 Offset: 0x839AA0 VA: 0x18083B4A0
	public void MenuTurretPeacekeeper(BasePlayer player) { }

	// RVA: 0x83B460 Offset: 0x839A60 VA: 0x18083B460
	public bool MenuTurretPeacekeeper_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.Description] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.Icon] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB38A0 Offset: 0xB2CA0 VA: 0x1800B38A0
	// RVA: 0x83B420 Offset: 0x839A20 VA: 0x18083B420
	public void MenuTurretAttackAll(BasePlayer player) { }

	// RVA: 0x83B3E0 Offset: 0x8399E0 VA: 0x18083B3E0
	public bool MenuTurretAttackAll_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.Icon] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.Description] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3CC0 Offset: 0xB30C0 VA: 0x1800B3CC0
	// RVA: 0x83B560 Offset: 0x839B60 VA: 0x18083B560
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0x83B520 Offset: 0x839B20 VA: 0x18083B520 Slot: 176
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool PeacekeeperMode() { }

	// RVA: 0x83AF20 Offset: 0x839520 VA: 0x18083AF20
	public bool IsBeingRemoteControlled() { }

	// RVA: 0x839830 Offset: 0x837E30 VA: 0x180839830 Slot: 167
	public Transform GetEyes() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 169
	public bool Occupied() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 168
	public BaseEntity GetEnt() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 177
	public virtual bool CanControl() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 178
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 172
	public void RCSetup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 173
	public void RCShutdown() { }

	// RVA: 0x83C490 Offset: 0x83AA90 VA: 0x18083C490 Slot: 170
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x839840 Offset: 0x837E40 VA: 0x180839840 Slot: 171
	public string GetIdentifier() { }

	// RVA: 0x4A6020 Offset: 0x4A4620 VA: 0x1804A6020 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5B03C0 Offset: 0x5AE9C0 VA: 0x1805B03C0
	public bool IsOnline() { }

	// RVA: 0x6FDC80 Offset: 0x6FC280 VA: 0x1806FDC80
	public bool IsOffline() { }

	// RVA: 0x83BE10 Offset: 0x83A410 VA: 0x18083BE10 Slot: 27
	public override void ResetState() { }

	// RVA: 0x839820 Offset: 0x837E20 VA: 0x180839820 Slot: 179
	public virtual Transform GetCenterMuzzle() { }

	// RVA: 0x838E20 Offset: 0x837420 VA: 0x180838E20
	public float AngleToTarget(BaseCombatEntity potentialtarget, bool use2D = False) { }

	// RVA: 0x83ABA0 Offset: 0x8391A0 VA: 0x18083ABA0 Slot: 180
	public virtual bool InFiringArc(BaseCombatEntity potentialtarget) { }

	// RVA: 0x8395B0 Offset: 0x837BB0 VA: 0x1808395B0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x83B1A0 Offset: 0x8397A0 VA: 0x18083B1A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x83C8E0 Offset: 0x83AEE0 VA: 0x18083C8E0
	public void Update() { }

	// RVA: 0x838B90 Offset: 0x837190 VA: 0x180838B90
	public Vector3 AimOffset(BaseCombatEntity aimat) { }

	// RVA: 0x8397F0 Offset: 0x837DF0 VA: 0x1808397F0
	public float GetAimSpeed() { }

	// RVA: 0x83BFF0 Offset: 0x83A5F0 VA: 0x18083BFF0
	public void UpdateAiming() { }

	// RVA: 0x83AF80 Offset: 0x839580 VA: 0x18083AF80
	private static Quaternion Lerp(Quaternion from, Quaternion to, float speed) { }

	// RVA: 0x83B080 Offset: 0x839680 VA: 0x18083B080
	private static Vector3 Lerp(Vector3 from, Vector3 to, float speed) { }

	// RVA: 0x83ADB0 Offset: 0x8393B0 VA: 0x18083ADB0
	public bool IsAuthed(ulong id) { }

	// RVA: 0x83AE60 Offset: 0x839460 VA: 0x18083AE60
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x838FE0 Offset: 0x8375E0 VA: 0x180838FE0
	public bool AnyAuthed() { }

	// RVA: 0x839550 Offset: 0x837B50 VA: 0x180839550 Slot: 181
	public virtual bool CanChangeSettings(BasePlayer player) { }

	// RVA: 0x83CA20 Offset: 0x83B020 VA: 0x18083CA20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83BED0 Offset: 0x83A4D0 VA: 0x18083BED0
	private bool <Menu_AssignToFriend>b__46_0(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x83BF80 Offset: 0x83A580 VA: 0x18083BF80
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

	// RVA: 0x7059B0 Offset: 0x703FB0 VA: 0x1807059B0
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class AutoTurret.<>c__DisplayClass107_0 // TypeDefIndex: 8314
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x705980 Offset: 0x703F80 VA: 0x180705980
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

