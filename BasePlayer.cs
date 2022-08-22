internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 3475
{	// Methods

	// RVA: 0x18FAD20 Offset: 0x18F9320 VA: 0x1818FAD20 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FAE40 Offset: 0x18F9440 VA: 0x1818FAE40 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FAB80 Offset: 0x18F9180 VA: 0x1818FAB80 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x18FACB0 Offset: 0x18F92B0 VA: 0x1818FACB0 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x18FAF60 Offset: 0x18F9560 VA: 0x1818FAF60 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x18FAB20 Offset: 0x18F9120 VA: 0x1818FAB20 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x18FAB50 Offset: 0x18F9150 VA: 0x1818FAB50 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x18FAAF0 Offset: 0x18F90F0 VA: 0x1818FAAF0 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunctionAttribute] // RVA: 0xB0AA0 Offset: 0xAFEA0 VA: 0x1800B0AA0
	// RVA: 0x18FAB50 Offset: 0x18F9150 VA: 0x1818FAB50
	private static bool IsConnected() { }

	[FreeFunctionAttribute] // RVA: 0xB0B30 Offset: 0xAFF30 VA: 0x1800B0B30
	// RVA: 0x18FAB20 Offset: 0x18F9120 VA: 0x1818FAB20
	private static void Initialize() { }

	[FreeFunctionAttribute] // RVA: 0xB0BD0 Offset: 0xAFFD0 VA: 0x1800B0BD0
	// RVA: 0x18FABB0 Offset: 0x18F91B0 VA: 0x1818FABB0
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB0C30 Offset: 0xB0030 VA: 0x1800B0C30
	// RVA: 0x18FAFD0 Offset: 0x18F95D0 VA: 0x1818FAFD0
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB1F90 Offset: 0xB1390 VA: 0x1800B1F90
	// RVA: 0x18FABF0 Offset: 0x18F91F0 VA: 0x1818FABF0
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB2080 Offset: 0xB1480 VA: 0x1800B2080
	// RVA: 0x18FAC50 Offset: 0x18F9250 VA: 0x1818FAC50
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB22B0 Offset: 0xB16B0 VA: 0x1800B22B0
	// RVA: 0x18FAB80 Offset: 0x18F9180 VA: 0x1818FAB80
	private static void PollInternal() { }

	[FreeFunctionAttribute] // RVA: 0xB2390 Offset: 0xB1790 VA: 0x1800B2390
	// RVA: 0x18FAAF0 Offset: 0x18F90F0 VA: 0x1818FAAF0
	private static void DisconnectAll() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class PlayerPrefsException : Exception // TypeDefIndex: 3476
{	// Methods

	// RVA: 0x18FCDC0 Offset: 0x18FB3C0 VA: 0x1818FCDC0
	public void .ctor(string error) { }

}

public class PlayerPrefs // TypeDefIndex: 3477
{	// Methods

	[NativeMethodAttribute] // RVA: 0xB2540 Offset: 0xB1940 VA: 0x1800B2540
	// RVA: 0x18FD2A0 Offset: 0x18FB8A0 VA: 0x1818FD2A0
	private static bool TrySetInt(string key, int value) { }

	[NativeMethodAttribute] // RVA: 0xB27D0 Offset: 0xB1BD0 VA: 0x1800B27D0
	// RVA: 0x18FD250 Offset: 0x18FB850 VA: 0x1818FD250
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethodAttribute] // RVA: 0xB28E0 Offset: 0xB1CE0 VA: 0x1800B28E0
	// RVA: 0x18FD2E0 Offset: 0x18FB8E0 VA: 0x1818FD2E0
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x18FD120 Offset: 0x18FB720 VA: 0x1818FD120
	public static void SetInt(string key, int value) { }

	// RVA: 0x18FCF00 Offset: 0x18FB500 VA: 0x1818FCF00
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x18FCF40 Offset: 0x18FB540 VA: 0x1818FCF40
	public static int GetInt(string key) { }

	// RVA: 0x18FD080 Offset: 0x18FB680 VA: 0x1818FD080
	public static void SetFloat(string key, float value) { }

	// RVA: 0x18FCE70 Offset: 0x18FB470 VA: 0x1818FCE70
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x18FCEC0 Offset: 0x18FB4C0 VA: 0x1818FCEC0
	public static float GetFloat(string key) { }

	// RVA: 0x18FD1B0 Offset: 0x18FB7B0 VA: 0x1818FD1B0
	public static void SetString(string key, string value) { }

	// RVA: 0x18FCFF0 Offset: 0x18FB5F0 VA: 0x1818FCFF0
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x18FCF80 Offset: 0x18FB580 VA: 0x1818FCF80
	public static string GetString(string key) { }

	// RVA: 0x18FD040 Offset: 0x18FB640 VA: 0x1818FD040
	public static bool HasKey(string key) { }

	// RVA: 0x18FCE30 Offset: 0x18FB430 VA: 0x1818FCE30
	public static void DeleteKey(string key) { }

}

internal struct PlayerLoopSystemInternal // TypeDefIndex: 3662
{	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x8
	public IntPtr updateFunction; // 0x10
	public IntPtr loopConditionFunction; // 0x18
	public int numSubSystems; // 0x20

}

public struct PlayerLoopSystem // TypeDefIndex: 3663
{	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem[] subSystemList; // 0x8
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x10
	public IntPtr updateFunction; // 0x18
	public IntPtr loopConditionFunction; // 0x20

}

public sealed class PlayerLoopSystem.UpdateFunction : MulticastDelegate // TypeDefIndex: 3664
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1464520 Offset: 0x1462B20 VA: 0x181464520 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class PlayerConnection : ScriptableObject // TypeDefIndex: 3789
{	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x18FC440 Offset: 0x18FAA40 VA: 0x1818FC440
	public static PlayerConnection get_instance() { }

	// RVA: 0x18FC5F0 Offset: 0x18FABF0 VA: 0x1818FC5F0
	public bool get_isConnected() { }

	// RVA: 0x18FB300 Offset: 0x18F9900 VA: 0x1818FB300
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x18FB650 Offset: 0x18F9C50 VA: 0x1818FB650
	public void OnEnable() { }

	// RVA: 0x18FB4C0 Offset: 0x18F9AC0 VA: 0x1818FB4C0
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x18FB8B0 Offset: 0x18F9EB0 VA: 0x1818FB8B0 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FC030 Offset: 0x18FA630 VA: 0x1818FC030 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FB6F0 Offset: 0x18F9CF0 VA: 0x1818FB6F0 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18FB850 Offset: 0x18F9E50 VA: 0x1818FB850 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18FBF70 Offset: 0x18FA570 VA: 0x1818FBF70 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18FBFD0 Offset: 0x18FA5D0 VA: 0x1818FBFD0 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18FBC10 Offset: 0x18FA210 VA: 0x1818FBC10 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x18FBDC0 Offset: 0x18FA3C0 VA: 0x1818FBDC0 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x18FB010 Offset: 0x18F9610 VA: 0x1818FB010
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x18FB3B0 Offset: 0x18F99B0 VA: 0x1818FB3B0 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FB520 Offset: 0x18F9B20 VA: 0x1818FB520
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FB280 Offset: 0x18F9880 VA: 0x1818FB280
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FB440 Offset: 0x18F9A40 VA: 0x1818FB440
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x18FC2C0 Offset: 0x18FA8C0 VA: 0x1818FC2C0
	public void .ctor() { }

}

private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 3790
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19013B0 Offset: 0x18FF9B0 VA: 0x1819013B0
	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 3791
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901460 Offset: 0x18FFA60 VA: 0x181901460
	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 3792
{	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1020A70 Offset: 0x101F070 VA: 0x181020A70
	internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

}

internal class PlayerEditorConnectionEvents // TypeDefIndex: 3793
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x18FC860 Offset: 0x18FAE60 VA: 0x1818FC860
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FC680 Offset: 0x18FAC80 VA: 0x1818FC680
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x18FCBB0 Offset: 0x18FB1B0 VA: 0x1818FCBB0
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FCCC0 Offset: 0x18FB2C0 VA: 0x1818FCCC0
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 3794
{	// Methods

	// RVA: 0x18F6E00 Offset: 0x18F5400 VA: 0x1818F6E00
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 3795
{	// Methods

	// RVA: 0x18E9300 Offset: 0x18E7900 VA: 0x1818E9300
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 3796
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20

	// Properties
	public Guid MessageTypeId { get; set; }

	// Methods

	// RVA: 0x18F6ED0 Offset: 0x18F54D0 VA: 0x1818F6ED0
	public Guid get_MessageTypeId() { }

	// RVA: 0x18F6F10 Offset: 0x18F5510 VA: 0x1818F6F10
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x18F6E40 Offset: 0x18F5440 VA: 0x1818F6E40
	public void .ctor() { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 3797
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901510 Offset: 0x18FFB10 VA: 0x181901510
	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 3798
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19015C0 Offset: 0x18FFBC0 VA: 0x1819015C0
	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 3799
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901670 Offset: 0x18FFC70 VA: 0x181901670
	internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

public struct PlayerItemRecipe : IEquatable<PlayerItemRecipe> // TypeDefIndex: 5698
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IReadOnlyList<PlayerItemRecipe.Ingredient> <Ingredients>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IPlayerItemDefinition <Result>k__BackingField; // 0x8

	// Properties
	public IReadOnlyList<PlayerItemRecipe.Ingredient> Ingredients { get; }
	public IPlayerItemDefinition Result { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IReadOnlyList<PlayerItemRecipe.Ingredient> get_Ingredients() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public IPlayerItemDefinition get_Result() { }

	// RVA: 0x23F740 Offset: 0x23EB40 VA: 0x18023F740
	public void .ctor(IReadOnlyList<PlayerItemRecipe.Ingredient> ingredients, IPlayerItemDefinition result) { }

	// RVA: 0x23F5F0 Offset: 0x23E9F0 VA: 0x18023F5F0 Slot: 4
	public bool Equals(PlayerItemRecipe other) { }

	// RVA: 0x23F550 Offset: 0x23E950 VA: 0x18023F550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23F610 Offset: 0x23EA10 VA: 0x18023F610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23002D0 Offset: 0x22FE8D0 VA: 0x1823002D0
	public static bool op_Equality(PlayerItemRecipe left, PlayerItemRecipe right) { }

	// RVA: 0x23002F0 Offset: 0x22FE8F0 VA: 0x1823002F0
	public static bool op_Inequality(PlayerItemRecipe left, PlayerItemRecipe right) { }

}

public struct PlayerItemRecipe.Ingredient : IEquatable<PlayerItemRecipe.Ingredient> // TypeDefIndex: 5699
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <DefinitionId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <Amount>k__BackingField; // 0x4

	// Properties
	public int DefinitionId { get; }
	public int Amount { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_DefinitionId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7E0 Offset: 0x14ABE0 VA: 0x18014B7E0
	public int get_Amount() { }

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int definitionId, int amount) { }

	// RVA: 0xF94A0 Offset: 0xF88A0 VA: 0x1800F94A0 Slot: 4
	public bool Equals(PlayerItemRecipe.Ingredient other) { }

	// RVA: 0x23F4B0 Offset: 0x23E8B0 VA: 0x18023F4B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23F540 Offset: 0x23E940 VA: 0x18023F540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x875300 Offset: 0x873900 VA: 0x180875300
	public static bool op_Equality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

	// RVA: 0x875320 Offset: 0x873920 VA: 0x180875320
	public static bool op_Inequality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

}

private sealed class PlayerItemRecipe.<>c // TypeDefIndex: 5700
{	// Fields
	public static readonly PlayerItemRecipe.<>c <>9; // 0x0
	public static Func<PlayerItemRecipe.Ingredient, int> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x2300B40 Offset: 0x22FF140 VA: 0x182300B40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2300A80 Offset: 0x22FF080 VA: 0x182300A80
	internal int <GetHashCode>b__10_0(PlayerItemRecipe.Ingredient i) { }

}

public static class PlayerItemExtensions // TypeDefIndex: 6156
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2315C90 Offset: 0x2314290 VA: 0x182315C90
	public static IPlayerItemDefinition GetDefinition(IPlayerItem item) { }

}

public struct PlayerInfo // TypeDefIndex: 6250
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Id>k__BackingField; // 0x8

	// Properties
	public string Name { get; set; }
	public string Id { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_Id(string value) { }

}

public class PlayerTick : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6277
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public InputMessage inputState; // 0x18
	public Vector3 position; // 0x20
	public ModelState modelState; // 0x30
	public uint activeItem; // 0x38
	public Vector3 eyePos; // 0x3C
	public uint parentID; // 0x48
	public uint deltaMs; // 0x4C

	// Methods

	// RVA: 0x2021530 Offset: 0x201FB30 VA: 0x182021530
	public static void ResetToPool(PlayerTick instance) { }

	// RVA: 0x2021670 Offset: 0x201FC70 VA: 0x182021670
	public void ResetToPool() { }

	// RVA: 0x2021020 Offset: 0x201F620 VA: 0x182021020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201F580 Offset: 0x201DB80 VA: 0x18201F580
	public void CopyTo(PlayerTick instance) { }

	// RVA: 0x201F7B0 Offset: 0x201DDB0 VA: 0x18201F7B0
	public PlayerTick Copy() { }

	// RVA: 0x2020140 Offset: 0x201E740 VA: 0x182020140
	public static PlayerTick Deserialize(Stream stream) { }

	// RVA: 0x201F830 Offset: 0x201DE30 VA: 0x18201F830
	public static PlayerTick DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201FCC0 Offset: 0x201E2C0 VA: 0x18201FCC0
	public static PlayerTick DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2020C00 Offset: 0x201F200 VA: 0x182020C00
	public static PlayerTick Deserialize(byte[] buffer) { }

	// RVA: 0x20211E0 Offset: 0x201F7E0 VA: 0x1820211E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2022500 Offset: 0x2020B00 VA: 0x182022500 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2022520 Offset: 0x2020B20 VA: 0x182022520 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTick previous) { }

	// RVA: 0x2021510 Offset: 0x201FB10 VA: 0x182021510 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20204B0 Offset: 0x201EAB0 VA: 0x1820204B0
	public static PlayerTick Deserialize(byte[] buffer, PlayerTick instance, bool isDelta = False) { }

	// RVA: 0x20208D0 Offset: 0x201EED0 VA: 0x1820208D0
	public static PlayerTick Deserialize(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x201F8B0 Offset: 0x201DEB0 VA: 0x18201F8B0
	public static PlayerTick DeserializeLengthDelimited(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x201FD50 Offset: 0x201E350 VA: 0x18201FD50
	public static PlayerTick DeserializeLength(Stream stream, int length, PlayerTick instance, bool isDelta) { }

	// RVA: 0x20217B0 Offset: 0x201FDB0 VA: 0x1820217B0
	public static void SerializeDelta(Stream stream, PlayerTick instance, PlayerTick previous) { }

	// RVA: 0x2022020 Offset: 0x2020620 VA: 0x182022020
	public static void Serialize(Stream stream, PlayerTick instance) { }

	// RVA: 0x20224F0 Offset: 0x2020AF0 VA: 0x1820224F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2022500 Offset: 0x2020B00 VA: 0x182022500
	public void ToProto(Stream stream) { }

	// RVA: 0x2021F10 Offset: 0x2020510 VA: 0x182021F10
	public static byte[] SerializeToBytes(PlayerTick instance) { }

	// RVA: 0x2021E60 Offset: 0x2020460 VA: 0x182021E60
	public static void SerializeLengthDelimited(Stream stream, PlayerTick instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class BasePlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6443
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public ulong userid; // 0x20
	public PlayerInventory inventory; // 0x28
	public PlayerMetabolism metabolism; // 0x30
	public ModelState modelState; // 0x38
	public int playerFlags; // 0x40
	public uint heldEntity; // 0x44
	public float health; // 0x48
	public PersistantPlayer persistantData; // 0x50
	public float skinCol; // 0x58
	public float skinTex; // 0x5C
	public float skinMesh; // 0x60
	public PlayerLifeStory currentLife; // 0x68
	public PlayerLifeStory previousLife; // 0x70
	public uint mounted; // 0x78
	public ulong currentTeam; // 0x80
	public uint underwear; // 0x88
	public PlayerModifiers modifiers; // 0x90
	public int reputation; // 0x98
	public uint loopingGesture; // 0x9C
	public Missions missions; // 0xA0

	// Methods

	// RVA: 0x2003BB0 Offset: 0x20021B0 VA: 0x182003BB0
	public static void ResetToPool(BasePlayer instance) { }

	// RVA: 0x2003870 Offset: 0x2001E70 VA: 0x182003870
	public void ResetToPool() { }

	// RVA: 0x20037B0 Offset: 0x2001DB0 VA: 0x1820037B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2001910 Offset: 0x1FFFF10 VA: 0x182001910
	public void CopyTo(BasePlayer instance) { }

	// RVA: 0x2001BC0 Offset: 0x20001C0 VA: 0x182001BC0
	public BasePlayer Copy() { }

	// RVA: 0x2002DB0 Offset: 0x20013B0 VA: 0x182002DB0
	public static BasePlayer Deserialize(Stream stream) { }

	// RVA: 0x2001C40 Offset: 0x2000240 VA: 0x182001C40
	public static BasePlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2002500 Offset: 0x2000B00 VA: 0x182002500
	public static BasePlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2002E30 Offset: 0x2001430 VA: 0x182002E30
	public static BasePlayer Deserialize(byte[] buffer) { }

	// RVA: 0x2003830 Offset: 0x2001E30 VA: 0x182003830
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20059B0 Offset: 0x2003FB0 VA: 0x1820059B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20059D0 Offset: 0x2003FD0 VA: 0x1820059D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BasePlayer previous) { }

	// RVA: 0x2003850 Offset: 0x2001E50 VA: 0x182003850 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20036B0 Offset: 0x2001CB0 VA: 0x1820036B0
	public static BasePlayer Deserialize(byte[] buffer, BasePlayer instance, bool isDelta = False) { }

	// RVA: 0x2002F50 Offset: 0x2001550 VA: 0x182002F50
	public static BasePlayer Deserialize(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x2001CC0 Offset: 0x20002C0 VA: 0x182001CC0
	public static BasePlayer DeserializeLengthDelimited(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x2002590 Offset: 0x2000B90 VA: 0x182002590
	public static BasePlayer DeserializeLength(Stream stream, int length, BasePlayer instance, bool isDelta) { }

	// RVA: 0x2003EF0 Offset: 0x20024F0 VA: 0x182003EF0
	public static void SerializeDelta(Stream stream, BasePlayer instance, BasePlayer previous) { }

	// RVA: 0x2004E60 Offset: 0x2003460 VA: 0x182004E60
	public static void Serialize(Stream stream, BasePlayer instance) { }

	// RVA: 0x20059A0 Offset: 0x2003FA0 VA: 0x1820059A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20059B0 Offset: 0x2003FB0 VA: 0x1820059B0
	public void ToProto(Stream stream) { }

	// RVA: 0x2004D50 Offset: 0x2003350 VA: 0x182004D50
	public static byte[] SerializeToBytes(BasePlayer instance) { }

	// RVA: 0x2004CA0 Offset: 0x20032A0 VA: 0x182004CA0
	public static void SerializeLengthDelimited(Stream stream, BasePlayer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerTeam : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6444
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong teamID; // 0x18
	public string teamName; // 0x20
	public ulong teamLeader; // 0x28
	public List<PlayerTeam.TeamMember> members; // 0x30
	public float teamLifetime; // 0x38
	public MapNote mapNote; // 0x40

	// Methods

	// RVA: 0x20435C0 Offset: 0x2041BC0 VA: 0x1820435C0
	public static void ResetToPool(PlayerTeam instance) { }

	// RVA: 0x2043810 Offset: 0x2041E10 VA: 0x182043810
	public void ResetToPool() { }

	// RVA: 0x20431C0 Offset: 0x20417C0 VA: 0x1820431C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20416D0 Offset: 0x203FCD0 VA: 0x1820416D0
	public void CopyTo(PlayerTeam instance) { }

	// RVA: 0x2041910 Offset: 0x203FF10 VA: 0x182041910
	public PlayerTeam Copy() { }

	// RVA: 0x20426C0 Offset: 0x2040CC0 VA: 0x1820426C0
	public static PlayerTeam Deserialize(Stream stream) { }

	// RVA: 0x2041990 Offset: 0x203FF90 VA: 0x182041990
	public static PlayerTeam DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2041E40 Offset: 0x2040440 VA: 0x182041E40
	public static PlayerTeam DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20422D0 Offset: 0x20408D0 VA: 0x1820422D0
	public static PlayerTeam Deserialize(byte[] buffer) { }

	// RVA: 0x2043240 Offset: 0x2041840 VA: 0x182043240
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2044480 Offset: 0x2042A80 VA: 0x182044480 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20444A0 Offset: 0x2042AA0 VA: 0x1820444A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam previous) { }

	// RVA: 0x20435A0 Offset: 0x2041BA0 VA: 0x1820435A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2042D80 Offset: 0x2041380 VA: 0x182042D80
	public static PlayerTeam Deserialize(byte[] buffer, PlayerTeam instance, bool isDelta = False) { }

	// RVA: 0x2042A20 Offset: 0x2041020 VA: 0x182042A20
	public static PlayerTeam Deserialize(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x2041A10 Offset: 0x2040010 VA: 0x182041A10
	public static PlayerTeam DeserializeLengthDelimited(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x2041ED0 Offset: 0x20404D0 VA: 0x182041ED0
	public static PlayerTeam DeserializeLength(Stream stream, int length, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x2043A70 Offset: 0x2042070 VA: 0x182043A70
	public static void SerializeDelta(Stream stream, PlayerTeam instance, PlayerTeam previous) { }

	// RVA: 0x2044090 Offset: 0x2042690 VA: 0x182044090
	public static void Serialize(Stream stream, PlayerTeam instance) { }

	// RVA: 0x2044470 Offset: 0x2042A70 VA: 0x182044470
	public byte[] ToProtoBytes() { }

	// RVA: 0x2044480 Offset: 0x2042A80 VA: 0x182044480
	public void ToProto(Stream stream) { }

	// RVA: 0x2043F80 Offset: 0x2042580 VA: 0x182043F80
	public static byte[] SerializeToBytes(PlayerTeam instance) { }

	// RVA: 0x2043ED0 Offset: 0x20424D0 VA: 0x182043ED0
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerTeam.TeamMember : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6445
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string displayName; // 0x18
	public ulong userID; // 0x20
	public float healthFraction; // 0x28
	public Vector3 position; // 0x2C
	public bool online; // 0x38
	public bool wounded; // 0x39

	// Methods

	// RVA: 0x2053620 Offset: 0x2051C20 VA: 0x182053620
	public static void ResetToPool(PlayerTeam.TeamMember instance) { }

	// RVA: 0x2053540 Offset: 0x2051B40 VA: 0x182053540
	public void ResetToPool() { }

	// RVA: 0x2053200 Offset: 0x2051800 VA: 0x182053200 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20519A0 Offset: 0x204FFA0 VA: 0x1820519A0
	public void CopyTo(PlayerTeam.TeamMember instance) { }

	// RVA: 0x2051A10 Offset: 0x2050010 VA: 0x182051A10
	public PlayerTeam.TeamMember Copy() { }

	// RVA: 0x2052B90 Offset: 0x2051190 VA: 0x182052B90
	public static PlayerTeam.TeamMember Deserialize(Stream stream) { }

	// RVA: 0x2051AC0 Offset: 0x20500C0 VA: 0x182051AC0
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2051EB0 Offset: 0x20504B0 VA: 0x182051EB0
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2052E70 Offset: 0x2051470 VA: 0x182052E70
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer) { }

	// RVA: 0x2053280 Offset: 0x2051880 VA: 0x182053280
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2053F40 Offset: 0x2052540 VA: 0x182053F40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2053F60 Offset: 0x2052560 VA: 0x182053F60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam.TeamMember previous) { }

	// RVA: 0x2053520 Offset: 0x2051B20 VA: 0x182053520 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2052830 Offset: 0x2050E30 VA: 0x182052830
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer, PlayerTeam.TeamMember instance, bool isDelta = False) { }

	// RVA: 0x2052580 Offset: 0x2050B80 VA: 0x182052580
	public static PlayerTeam.TeamMember Deserialize(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x2051B40 Offset: 0x2050140 VA: 0x182051B40
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x2052240 Offset: 0x2050840 VA: 0x182052240
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x2053700 Offset: 0x2051D00 VA: 0x182053700
	public static void SerializeDelta(Stream stream, PlayerTeam.TeamMember instance, PlayerTeam.TeamMember previous) { }

	// RVA: 0x2053CB0 Offset: 0x20522B0 VA: 0x182053CB0
	public static void Serialize(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x2053F30 Offset: 0x2052530 VA: 0x182053F30
	public byte[] ToProtoBytes() { }

	// RVA: 0x2053F40 Offset: 0x2052540 VA: 0x182053F40
	public void ToProto(Stream stream) { }

	// RVA: 0x2053BA0 Offset: 0x20521A0 VA: 0x182053BA0
	public static byte[] SerializeToBytes(PlayerTeam.TeamMember instance) { }

	// RVA: 0x2053AF0 Offset: 0x20520F0 VA: 0x182053AF0
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerMetabolism : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6446
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float health; // 0x14
	public float calories; // 0x18
	public float hydration; // 0x1C
	public float heartrate; // 0x20
	public float temperature; // 0x24
	public float poison; // 0x28
	public float radiation_level; // 0x2C
	public float wetness; // 0x30
	public float dirtyness; // 0x34
	public float oxygen; // 0x38
	public float bleeding; // 0x3C
	public float radiation_poisoning; // 0x40
	public float comfort; // 0x44
	public float pending_health; // 0x48

	// Methods

	// RVA: 0x1EB5B50 Offset: 0x1EB4150 VA: 0x181EB5B50
	public static void ResetToPool(PlayerMetabolism instance) { }

	// RVA: 0x1EB5A10 Offset: 0x1EB4010 VA: 0x181EB5A10
	public void ResetToPool() { }

	// RVA: 0x1EB5800 Offset: 0x1EB3E00 VA: 0x181EB5800 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB4330 Offset: 0x1EB2930 VA: 0x181EB4330
	public void CopyTo(PlayerMetabolism instance) { }

	// RVA: 0x1EB43A0 Offset: 0x1EB29A0 VA: 0x181EB43A0
	public PlayerMetabolism Copy() { }

	// RVA: 0x1EB5660 Offset: 0x1EB3C60 VA: 0x181EB5660
	public static PlayerMetabolism Deserialize(Stream stream) { }

	// RVA: 0x1EB4A00 Offset: 0x1EB3000 VA: 0x181EB4A00
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB5000 Offset: 0x1EB3600 VA: 0x181EB5000
	public static PlayerMetabolism DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB56E0 Offset: 0x1EB3CE0 VA: 0x181EB56E0
	public static PlayerMetabolism Deserialize(byte[] buffer) { }

	// RVA: 0x1EB59D0 Offset: 0x1EB3FD0 VA: 0x181EB59D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB66F0 Offset: 0x1EB4CF0 VA: 0x181EB66F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB6710 Offset: 0x1EB4D10 VA: 0x181EB6710 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerMetabolism previous) { }

	// RVA: 0x1EB59F0 Offset: 0x1EB3FF0 VA: 0x181EB59F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB5090 Offset: 0x1EB3690 VA: 0x181EB5090
	public static PlayerMetabolism Deserialize(byte[] buffer, PlayerMetabolism instance, bool isDelta = False) { }

	// RVA: 0x1EB5190 Offset: 0x1EB3790 VA: 0x181EB5190
	public static PlayerMetabolism Deserialize(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB4460 Offset: 0x1EB2A60 VA: 0x181EB4460
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB4A80 Offset: 0x1EB3080 VA: 0x181EB4A80
	public static PlayerMetabolism DeserializeLength(Stream stream, int length, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB5C90 Offset: 0x1EB4290 VA: 0x181EB5C90
	public static void SerializeDelta(Stream stream, PlayerMetabolism instance, PlayerMetabolism previous) { }

	// RVA: 0x1EB6420 Offset: 0x1EB4A20 VA: 0x181EB6420
	public static void Serialize(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x1EB66E0 Offset: 0x1EB4CE0 VA: 0x181EB66E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB66F0 Offset: 0x1EB4CF0 VA: 0x181EB66F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB6310 Offset: 0x1EB4910 VA: 0x181EB6310
	public static byte[] SerializeToBytes(PlayerMetabolism instance) { }

	// RVA: 0x1EB6260 Offset: 0x1EB4860 VA: 0x181EB6260
	public static void SerializeLengthDelimited(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerModifiers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6447
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Modifier> modifiers; // 0x18

	// Methods

	// RVA: 0x1EB7650 Offset: 0x1EB5C50 VA: 0x181EB7650
	public static void ResetToPool(PlayerModifiers instance) { }

	// RVA: 0x1EB7800 Offset: 0x1EB5E00 VA: 0x181EB7800
	public void ResetToPool() { }

	// RVA: 0x1EB73D0 Offset: 0x1EB59D0 VA: 0x181EB73D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB6730 Offset: 0x1EB4D30 VA: 0x181EB6730
	public void CopyTo(PlayerModifiers instance) { }

	// RVA: 0x1EB6860 Offset: 0x1EB4E60 VA: 0x181EB6860
	public PlayerModifiers Copy() { }

	// RVA: 0x1EB70C0 Offset: 0x1EB56C0 VA: 0x181EB70C0
	public static PlayerModifiers Deserialize(Stream stream) { }

	// RVA: 0x1EB69D0 Offset: 0x1EB4FD0 VA: 0x181EB69D0
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB6CC0 Offset: 0x1EB52C0 VA: 0x181EB6CC0
	public static PlayerModifiers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB6FA0 Offset: 0x1EB55A0 VA: 0x181EB6FA0
	public static PlayerModifiers Deserialize(byte[] buffer) { }

	// RVA: 0x1EB7610 Offset: 0x1EB5C10 VA: 0x181EB7610
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB7F40 Offset: 0x1EB6540 VA: 0x181EB7F40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB7F60 Offset: 0x1EB6560 VA: 0x181EB7F60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerModifiers previous) { }

	// RVA: 0x1EB7630 Offset: 0x1EB5C30 VA: 0x181EB7630 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB7140 Offset: 0x1EB5740 VA: 0x181EB7140
	public static PlayerModifiers Deserialize(byte[] buffer, PlayerModifiers instance, bool isDelta = False) { }

	// RVA: 0x1EB7240 Offset: 0x1EB5840 VA: 0x181EB7240
	public static PlayerModifiers Deserialize(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB6A50 Offset: 0x1EB5050 VA: 0x181EB6A50
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB6D50 Offset: 0x1EB5350 VA: 0x181EB6D50
	public static PlayerModifiers DeserializeLength(Stream stream, int length, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB79B0 Offset: 0x1EB5FB0 VA: 0x181EB79B0
	public static void SerializeDelta(Stream stream, PlayerModifiers instance, PlayerModifiers previous) { }

	// RVA: 0x1EB7D50 Offset: 0x1EB6350 VA: 0x181EB7D50
	public static void Serialize(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x1EB7F30 Offset: 0x1EB6530 VA: 0x181EB7F30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB7F40 Offset: 0x1EB6540 VA: 0x181EB7F40
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB7C40 Offset: 0x1EB6240 VA: 0x181EB7C40
	public static byte[] SerializeToBytes(PlayerModifiers instance) { }

	// RVA: 0x1EB7B90 Offset: 0x1EB6190 VA: 0x181EB7B90
	public static void SerializeLengthDelimited(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerInventory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6454
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer invMain; // 0x18
	public ItemContainer invBelt; // 0x20
	public ItemContainer invWear; // 0x28

	// Methods

	// RVA: 0x1EAF4D0 Offset: 0x1EADAD0 VA: 0x181EAF4D0
	public static void ResetToPool(PlayerInventory instance) { }

	// RVA: 0x1EAF5F0 Offset: 0x1EADBF0 VA: 0x181EAF5F0
	public void ResetToPool() { }

	// RVA: 0x1EAF130 Offset: 0x1EAD730 VA: 0x181EAF130 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EADF20 Offset: 0x1EAC520 VA: 0x181EADF20
	public void CopyTo(PlayerInventory instance) { }

	// RVA: 0x1EAE020 Offset: 0x1EAC620 VA: 0x181EAE020
	public PlayerInventory Copy() { }

	// RVA: 0x1EAE7C0 Offset: 0x1EACDC0 VA: 0x181EAE7C0
	public static PlayerInventory Deserialize(Stream stream) { }

	// RVA: 0x1EAE160 Offset: 0x1EAC760 VA: 0x181EAE160
	public static PlayerInventory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAE730 Offset: 0x1EACD30 VA: 0x181EAE730
	public static PlayerInventory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAEC80 Offset: 0x1EAD280 VA: 0x181EAEC80
	public static PlayerInventory Deserialize(byte[] buffer) { }

	// RVA: 0x1EAF2D0 Offset: 0x1EAD8D0 VA: 0x181EAF2D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAFFD0 Offset: 0x1EAE5D0 VA: 0x181EAFFD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAFFF0 Offset: 0x1EAE5F0 VA: 0x181EAFFF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerInventory previous) { }

	// RVA: 0x1EAF4B0 Offset: 0x1EADAB0 VA: 0x181EAF4B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAE9E0 Offset: 0x1EACFE0 VA: 0x181EAE9E0
	public static PlayerInventory Deserialize(byte[] buffer, PlayerInventory instance, bool isDelta = False) { }

	// RVA: 0x1EAEF50 Offset: 0x1EAD550 VA: 0x181EAEF50
	public static PlayerInventory Deserialize(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAE1E0 Offset: 0x1EAC7E0 VA: 0x181EAE1E0
	public static PlayerInventory DeserializeLengthDelimited(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAE4A0 Offset: 0x1EACAA0 VA: 0x181EAE4A0
	public static PlayerInventory DeserializeLength(Stream stream, int length, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAF710 Offset: 0x1EADD10 VA: 0x181EAF710
	public static void SerializeDelta(Stream stream, PlayerInventory instance, PlayerInventory previous) { }

	// RVA: 0x1EAFC60 Offset: 0x1EAE260 VA: 0x181EAFC60
	public static void Serialize(Stream stream, PlayerInventory instance) { }

	// RVA: 0x1EAFFC0 Offset: 0x1EAE5C0 VA: 0x181EAFFC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAFFD0 Offset: 0x1EAE5D0 VA: 0x181EAFFD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAFB50 Offset: 0x1EAE150 VA: 0x181EAFB50
	public static byte[] SerializeToBytes(PlayerInventory instance) { }

	// RVA: 0x1EAFAA0 Offset: 0x1EAE0A0 VA: 0x181EAFAA0
	public static void SerializeLengthDelimited(Stream stream, PlayerInventory instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerLifeStory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6456
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float secondsAlive; // 0x14
	public float metersWalked; // 0x18
	public float metersRun; // 0x1C
	public float secondsSleeping; // 0x20
	public uint timeBorn; // 0x24
	public uint timeDied; // 0x28
	public float secondsWilderness; // 0x2C
	public float secondsSwimming; // 0x30
	public float secondsInBase; // 0x34
	public float secondsInMonument; // 0x38
	public float secondsFlying; // 0x3C
	public float secondsBoating; // 0x40
	public float secondsDriving; // 0x44
	public float totalDamageTaken; // 0x48
	public float totalHealing; // 0x4C
	public PlayerLifeStory.DeathInfo deathInfo; // 0x50
	public List<PlayerLifeStory.WeaponStats> weaponStats; // 0x58
	public int killedPlayers; // 0x60
	public int killedScientists; // 0x64
	public int killedAnimals; // 0x68
	public List<PlayerLifeStory.GenericStat> genericStats; // 0x70

	// Methods

	// RVA: 0x1EB27F0 Offset: 0x1EB0DF0 VA: 0x181EB27F0
	public static void ResetToPool(PlayerLifeStory instance) { }

	// RVA: 0x1EB23A0 Offset: 0x1EB09A0 VA: 0x181EB23A0
	public void ResetToPool() { }

	// RVA: 0x1EB22E0 Offset: 0x1EB08E0 VA: 0x181EB22E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB0010 Offset: 0x1EAE610 VA: 0x181EB0010
	public void CopyTo(PlayerLifeStory instance) { }

	// RVA: 0x1EB0490 Offset: 0x1EAEA90 VA: 0x181EB0490
	public PlayerLifeStory Copy() { }

	// RVA: 0x1EB1800 Offset: 0x1EAFE00 VA: 0x181EB1800
	public static PlayerLifeStory Deserialize(Stream stream) { }

	// RVA: 0x1EB0E10 Offset: 0x1EAF410 VA: 0x181EB0E10
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB1770 Offset: 0x1EAFD70 VA: 0x181EB1770
	public static PlayerLifeStory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB21C0 Offset: 0x1EB07C0 VA: 0x181EB21C0
	public static PlayerLifeStory Deserialize(byte[] buffer) { }

	// RVA: 0x1EB2360 Offset: 0x1EB0960 VA: 0x181EB2360
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB42F0 Offset: 0x1EB28F0 VA: 0x181EB42F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB4310 Offset: 0x1EB2910 VA: 0x181EB4310 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory previous) { }

	// RVA: 0x1EB2380 Offset: 0x1EB0980 VA: 0x181EB2380 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB1880 Offset: 0x1EAFE80 VA: 0x181EB1880
	public static PlayerLifeStory Deserialize(byte[] buffer, PlayerLifeStory instance, bool isDelta = False) { }

	// RVA: 0x1EB1980 Offset: 0x1EAFF80 VA: 0x181EB1980
	public static PlayerLifeStory Deserialize(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB0510 Offset: 0x1EAEB10 VA: 0x181EB0510
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB0E90 Offset: 0x1EAF490 VA: 0x181EB0E90
	public static PlayerLifeStory DeserializeLength(Stream stream, int length, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB2C40 Offset: 0x1EB1240 VA: 0x181EB2C40
	public static void SerializeDelta(Stream stream, PlayerLifeStory instance, PlayerLifeStory previous) { }

	// RVA: 0x1EB3A50 Offset: 0x1EB2050 VA: 0x181EB3A50
	public static void Serialize(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x1EB42E0 Offset: 0x1EB28E0 VA: 0x181EB42E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB42F0 Offset: 0x1EB28F0 VA: 0x181EB42F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB3940 Offset: 0x1EB1F40 VA: 0x181EB3940
	public static byte[] SerializeToBytes(PlayerLifeStory instance) { }

	// RVA: 0x1EB3890 Offset: 0x1EB1E90 VA: 0x181EB3890
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerLifeStory.DeathInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6457
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string attackerName; // 0x18
	public ulong attackerSteamID; // 0x20
	public string hitBone; // 0x28
	public string inflictorName; // 0x30
	public int lastDamageType; // 0x38
	public float attackerDistance; // 0x3C

	// Methods

	// RVA: 0x1EA21D0 Offset: 0x1EA07D0 VA: 0x181EA21D0
	public static void ResetToPool(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA2300 Offset: 0x1EA0900 VA: 0x181EA2300
	public void ResetToPool() { }

	// RVA: 0x1EA1E80 Offset: 0x1EA0480 VA: 0x181EA1E80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA0820 Offset: 0x1E9EE20 VA: 0x181EA0820
	public void CopyTo(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA0890 Offset: 0x1E9EE90 VA: 0x181EA0890
	public PlayerLifeStory.DeathInfo Copy() { }

	// RVA: 0x1EA1500 Offset: 0x1E9FB00 VA: 0x181EA1500
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream) { }

	// RVA: 0x1EA0CE0 Offset: 0x1E9F2E0 VA: 0x181EA0CE0
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA10D0 Offset: 0x1E9F6D0 VA: 0x181EA10D0
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA1AC0 Offset: 0x1EA00C0 VA: 0x181EA1AC0
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1EA1F00 Offset: 0x1EA0500 VA: 0x181EA1F00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA2B60 Offset: 0x1EA1160 VA: 0x181EA2B60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA2B80 Offset: 0x1EA1180 VA: 0x181EA2B80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1EA21B0 Offset: 0x1EA07B0 VA: 0x181EA21B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA1160 Offset: 0x1E9F760 VA: 0x181EA1160
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer, PlayerLifeStory.DeathInfo instance, bool isDelta = False) { }

	// RVA: 0x1EA1800 Offset: 0x1E9FE00 VA: 0x181EA1800
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA0950 Offset: 0x1E9EF50 VA: 0x181EA0950
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA0D60 Offset: 0x1E9F360 VA: 0x181EA0D60
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA2430 Offset: 0x1EA0A30 VA: 0x181EA2430
	public static void SerializeDelta(Stream stream, PlayerLifeStory.DeathInfo instance, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1EA2900 Offset: 0x1EA0F00 VA: 0x181EA2900
	public static void Serialize(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA2B50 Offset: 0x1EA1150 VA: 0x181EA2B50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA2B60 Offset: 0x1EA1160 VA: 0x181EA2B60
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA27F0 Offset: 0x1EA0DF0 VA: 0x181EA27F0
	public static byte[] SerializeToBytes(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA2740 Offset: 0x1EA0D40 VA: 0x181EA2740
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerLifeStory.WeaponStats : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6458
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string weaponName; // 0x18
	public ulong shotsFired; // 0x20
	public ulong shotsHit; // 0x28

	// Methods

	// RVA: 0x1EB9280 Offset: 0x1EB7880 VA: 0x181EB9280
	public static void ResetToPool(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB91D0 Offset: 0x1EB77D0 VA: 0x181EB91D0
	public void ResetToPool() { }

	// RVA: 0x1EB8F70 Offset: 0x1EB7570 VA: 0x181EB8F70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB7F80 Offset: 0x1EB6580 VA: 0x181EB7F80
	public void CopyTo(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB7FD0 Offset: 0x1EB65D0 VA: 0x181EB7FD0
	public PlayerLifeStory.WeaponStats Copy() { }

	// RVA: 0x1EB8BB0 Offset: 0x1EB71B0 VA: 0x181EB8BB0
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream) { }

	// RVA: 0x1EB82F0 Offset: 0x1EB68F0 VA: 0x181EB82F0
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB85E0 Offset: 0x1EB6BE0 VA: 0x181EB85E0
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB8670 Offset: 0x1EB6C70 VA: 0x181EB8670
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer) { }

	// RVA: 0x1EB8FF0 Offset: 0x1EB75F0 VA: 0x181EB8FF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB98B0 Offset: 0x1EB7EB0 VA: 0x181EB98B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB98D0 Offset: 0x1EB7ED0 VA: 0x181EB98D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EB91B0 Offset: 0x1EB77B0 VA: 0x181EB91B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB8920 Offset: 0x1EB6F20 VA: 0x181EB8920
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer, PlayerLifeStory.WeaponStats instance, bool isDelta = False) { }

	// RVA: 0x1EB8DB0 Offset: 0x1EB73B0 VA: 0x181EB8DB0
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB8060 Offset: 0x1EB6660 VA: 0x181EB8060
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB8370 Offset: 0x1EB6970 VA: 0x181EB8370
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB9330 Offset: 0x1EB7930 VA: 0x181EB9330
	public static void SerializeDelta(Stream stream, PlayerLifeStory.WeaponStats instance, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EB9710 Offset: 0x1EB7D10 VA: 0x181EB9710
	public static void Serialize(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB98A0 Offset: 0x1EB7EA0 VA: 0x181EB98A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB98B0 Offset: 0x1EB7EB0 VA: 0x181EB98B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB9600 Offset: 0x1EB7C00 VA: 0x181EB9600
	public static byte[] SerializeToBytes(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB9550 Offset: 0x1EB7B50 VA: 0x181EB9550
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerLifeStory.GenericStat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6459
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string key; // 0x18
	public int value; // 0x20

	// Methods

	// RVA: 0x1EA4EC0 Offset: 0x1EA34C0 VA: 0x181EA4EC0
	public static void ResetToPool(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA4E20 Offset: 0x1EA3420 VA: 0x181EA4E20
	public void ResetToPool() { }

	// RVA: 0x1EA4D60 Offset: 0x1EA3360 VA: 0x181EA4D60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA4030 Offset: 0x1EA2630 VA: 0x181EA4030
	public void CopyTo(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA4070 Offset: 0x1EA2670 VA: 0x181EA4070
	public PlayerLifeStory.GenericStat Copy() { }

	// RVA: 0x1EA46B0 Offset: 0x1EA2CB0 VA: 0x181EA46B0
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream) { }

	// RVA: 0x1EA4100 Offset: 0x1EA2700 VA: 0x181EA4100
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA4620 Offset: 0x1EA2C20 VA: 0x181EA4620
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA4AF0 Offset: 0x1EA30F0 VA: 0x181EA4AF0
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer) { }

	// RVA: 0x1EA4DE0 Offset: 0x1EA33E0 VA: 0x181EA4DE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA5450 Offset: 0x1EA3A50 VA: 0x181EA5450 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA5470 Offset: 0x1EA3A70 VA: 0x181EA5470 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1EA4E00 Offset: 0x1EA3400 VA: 0x181EA4E00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA4870 Offset: 0x1EA2E70 VA: 0x181EA4870
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer, PlayerLifeStory.GenericStat instance, bool isDelta = False) { }

	// RVA: 0x1EA4970 Offset: 0x1EA2F70 VA: 0x181EA4970
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA4180 Offset: 0x1EA2780 VA: 0x181EA4180
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA43E0 Offset: 0x1EA29E0 VA: 0x181EA43E0
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA4F60 Offset: 0x1EA3560 VA: 0x181EA4F60
	public static void SerializeDelta(Stream stream, PlayerLifeStory.GenericStat instance, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1EA52E0 Offset: 0x1EA38E0 VA: 0x181EA52E0
	public static void Serialize(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA5440 Offset: 0x1EA3A40 VA: 0x181EA5440
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA5450 Offset: 0x1EA3A50 VA: 0x181EA5450
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA51D0 Offset: 0x1EA37D0 VA: 0x181EA51D0
	public static byte[] SerializeToBytes(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA5120 Offset: 0x1EA3720 VA: 0x181EA5120
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6462
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public double unHostileTimestamp; // 0x18
	public MapNote pointOfInterest; // 0x20
	public MapNote deathMarker; // 0x28
	public Missions missions; // 0x30

	// Methods

	// RVA: 0x2040C10 Offset: 0x203F210 VA: 0x182040C10
	public static void ResetToPool(PlayerState instance) { }

	// RVA: 0x2040AE0 Offset: 0x203F0E0 VA: 0x182040AE0
	public void ResetToPool() { }

	// RVA: 0x20406E0 Offset: 0x203ECE0 VA: 0x1820406E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203F300 Offset: 0x203D900 VA: 0x18203F300
	public void CopyTo(PlayerState instance) { }

	// RVA: 0x203F3F0 Offset: 0x203D9F0 VA: 0x18203F3F0
	public PlayerState Copy() { }

	// RVA: 0x203FF60 Offset: 0x203E560 VA: 0x18203FF60
	public static PlayerState Deserialize(Stream stream) { }

	// RVA: 0x203F850 Offset: 0x203DE50 VA: 0x18203F850
	public static PlayerState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203F8D0 Offset: 0x203DED0 VA: 0x18203F8D0
	public static PlayerState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203FC40 Offset: 0x203E240 VA: 0x18203FC40
	public static PlayerState Deserialize(byte[] buffer) { }

	// RVA: 0x2040890 Offset: 0x203EE90 VA: 0x182040890
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2041690 Offset: 0x203FC90 VA: 0x182041690 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20416B0 Offset: 0x203FCB0 VA: 0x1820416B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerState previous) { }

	// RVA: 0x2040AC0 Offset: 0x203F0C0 VA: 0x182040AC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20401C0 Offset: 0x203E7C0 VA: 0x1820401C0
	public static PlayerState Deserialize(byte[] buffer, PlayerState instance, bool isDelta = False) { }

	// RVA: 0x20404B0 Offset: 0x203EAB0 VA: 0x1820404B0
	public static PlayerState Deserialize(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x203F540 Offset: 0x203DB40 VA: 0x18203F540
	public static PlayerState DeserializeLengthDelimited(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x203F960 Offset: 0x203DF60 VA: 0x18203F960
	public static PlayerState DeserializeLength(Stream stream, int length, PlayerState instance, bool isDelta) { }

	// RVA: 0x2040D40 Offset: 0x203F340 VA: 0x182040D40
	public static void SerializeDelta(Stream stream, PlayerState instance, PlayerState previous) { }

	// RVA: 0x20412E0 Offset: 0x203F8E0 VA: 0x1820412E0
	public static void Serialize(Stream stream, PlayerState instance) { }

	// RVA: 0x2041680 Offset: 0x203FC80 VA: 0x182041680
	public byte[] ToProtoBytes() { }

	// RVA: 0x2041690 Offset: 0x203FC90 VA: 0x182041690
	public void ToProto(Stream stream) { }

	// RVA: 0x20411D0 Offset: 0x203F7D0 VA: 0x1820411D0
	public static byte[] SerializeToBytes(PlayerState instance) { }

	// RVA: 0x2041120 Offset: 0x203F720 VA: 0x182041120
	public static void SerializeLengthDelimited(Stream stream, PlayerState instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerNameID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6463
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string username; // 0x18
	public ulong userid; // 0x20

	// Methods

	// RVA: 0x2037D40 Offset: 0x2036340 VA: 0x182037D40
	public static void ResetToPool(PlayerNameID instance) { }

	// RVA: 0x2037C90 Offset: 0x2036290 VA: 0x182037C90
	public void ResetToPool() { }

	// RVA: 0x2037B30 Offset: 0x2036130 VA: 0x182037B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAD430 Offset: 0x1DABA30 VA: 0x181DAD430
	public void CopyTo(PlayerNameID instance) { }

	// RVA: 0x2036E30 Offset: 0x2035430 VA: 0x182036E30
	public PlayerNameID Copy() { }

	// RVA: 0x2037870 Offset: 0x2035E70 VA: 0x182037870
	public static PlayerNameID Deserialize(Stream stream) { }

	// RVA: 0x2036EC0 Offset: 0x20354C0 VA: 0x182036EC0
	public static PlayerNameID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20373E0 Offset: 0x20359E0 VA: 0x1820373E0
	public static PlayerNameID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20375F0 Offset: 0x2035BF0 VA: 0x1820375F0
	public static PlayerNameID Deserialize(byte[] buffer) { }

	// RVA: 0x2037C50 Offset: 0x2036250 VA: 0x182037C50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20382E0 Offset: 0x20368E0 VA: 0x1820382E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2038300 Offset: 0x2036900 VA: 0x182038300 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerNameID previous) { }

	// RVA: 0x2037C70 Offset: 0x2036270 VA: 0x182037C70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2037A30 Offset: 0x2036030 VA: 0x182037A30
	public static PlayerNameID Deserialize(byte[] buffer, PlayerNameID instance, bool isDelta = False) { }

	// RVA: 0x2037470 Offset: 0x2035A70 VA: 0x182037470
	public static PlayerNameID Deserialize(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2036F40 Offset: 0x2035540 VA: 0x182036F40
	public static PlayerNameID DeserializeLengthDelimited(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x20371A0 Offset: 0x20357A0 VA: 0x1820371A0
	public static PlayerNameID DeserializeLength(Stream stream, int length, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2037DF0 Offset: 0x20363F0 VA: 0x182037DF0
	public static void SerializeDelta(Stream stream, PlayerNameID instance, PlayerNameID previous) { }

	// RVA: 0x2038170 Offset: 0x2036770 VA: 0x182038170
	public static void Serialize(Stream stream, PlayerNameID instance) { }

	// RVA: 0x20382D0 Offset: 0x20368D0 VA: 0x1820382D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20382E0 Offset: 0x20368E0 VA: 0x1820382E0
	public void ToProto(Stream stream) { }

	// RVA: 0x2038060 Offset: 0x2036660 VA: 0x182038060
	public static byte[] SerializeToBytes(PlayerNameID instance) { }

	// RVA: 0x2037FB0 Offset: 0x20365B0 VA: 0x182037FB0
	public static void SerializeLengthDelimited(Stream stream, PlayerNameID instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerUpdateLoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6478
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemID; // 0x14
	public uint entityID; // 0x18
	public List<ItemContainer> containers; // 0x20

	// Methods

	// RVA: 0x2045B20 Offset: 0x2044120 VA: 0x182045B20
	public static void ResetToPool(PlayerUpdateLoot instance) { }

	// RVA: 0x2045CF0 Offset: 0x20442F0 VA: 0x182045CF0
	public void ResetToPool() { }

	// RVA: 0x2045870 Offset: 0x2043E70 VA: 0x182045870 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20444C0 Offset: 0x2042AC0 VA: 0x1820444C0
	public void CopyTo(PlayerUpdateLoot instance) { }

	// RVA: 0x20445F0 Offset: 0x2042BF0 VA: 0x1820445F0
	public PlayerUpdateLoot Copy() { }

	// RVA: 0x2044E40 Offset: 0x2043440 VA: 0x182044E40
	public static PlayerUpdateLoot Deserialize(Stream stream) { }

	// RVA: 0x2044A60 Offset: 0x2043060 VA: 0x182044A60
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2044DB0 Offset: 0x20433B0 VA: 0x182044DB0
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2045590 Offset: 0x2043B90 VA: 0x182045590
	public static PlayerUpdateLoot Deserialize(byte[] buffer) { }

	// RVA: 0x20458F0 Offset: 0x2043EF0 VA: 0x1820458F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2046560 Offset: 0x2044B60 VA: 0x182046560 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2046580 Offset: 0x2044B80 VA: 0x182046580 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerUpdateLoot previous) { }

	// RVA: 0x2045B00 Offset: 0x2044100 VA: 0x182045B00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20452A0 Offset: 0x20438A0 VA: 0x1820452A0
	public static PlayerUpdateLoot Deserialize(byte[] buffer, PlayerUpdateLoot instance, bool isDelta = False) { }

	// RVA: 0x2045080 Offset: 0x2043680 VA: 0x182045080
	public static PlayerUpdateLoot Deserialize(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2044770 Offset: 0x2042D70 VA: 0x182044770
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2044AE0 Offset: 0x20430E0 VA: 0x182044AE0
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2045EC0 Offset: 0x20444C0 VA: 0x182045EC0
	public static void SerializeDelta(Stream stream, PlayerUpdateLoot instance, PlayerUpdateLoot previous) { }

	// RVA: 0x2046310 Offset: 0x2044910 VA: 0x182046310
	public static void Serialize(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x2046550 Offset: 0x2044B50 VA: 0x182046550
	public byte[] ToProtoBytes() { }

	// RVA: 0x2046560 Offset: 0x2044B60 VA: 0x182046560
	public void ToProto(Stream stream) { }

	// RVA: 0x2046200 Offset: 0x2044800 VA: 0x182046200
	public static byte[] SerializeToBytes(PlayerUpdateLoot instance) { }

	// RVA: 0x2046150 Offset: 0x2044750 VA: 0x182046150
	public static void SerializeLengthDelimited(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6484
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Attack attack; // 0x18
	public int projectileID; // 0x20

	// Methods

	// RVA: 0x1EAC6A0 Offset: 0x1EAACA0 VA: 0x181EAC6A0
	public static void ResetToPool(PlayerAttack instance) { }

	// RVA: 0x1EAC750 Offset: 0x1EAAD50 VA: 0x181EAC750
	public void ResetToPool() { }

	// RVA: 0x1EAC530 Offset: 0x1EAAB30 VA: 0x181EAC530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAB750 Offset: 0x1EA9D50 VA: 0x181EAB750
	public void CopyTo(PlayerAttack instance) { }

	// RVA: 0x1EAB7E0 Offset: 0x1EA9DE0 VA: 0x181EAB7E0
	public PlayerAttack Copy() { }

	// RVA: 0x1EABF70 Offset: 0x1EAA570 VA: 0x181EABF70
	public static PlayerAttack Deserialize(Stream stream) { }

	// RVA: 0x1EAB8B0 Offset: 0x1EA9EB0 VA: 0x181EAB8B0
	public static PlayerAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EABDE0 Offset: 0x1EAA3E0 VA: 0x181EABDE0
	public static PlayerAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAC2C0 Offset: 0x1EAA8C0 VA: 0x181EAC2C0
	public static PlayerAttack Deserialize(byte[] buffer) { }

	// RVA: 0x1EAC660 Offset: 0x1EAAC60 VA: 0x181EAC660
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EACDF0 Offset: 0x1EAB3F0 VA: 0x181EACDF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EACE10 Offset: 0x1EAB410 VA: 0x181EACE10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerAttack previous) { }

	// RVA: 0x1EAC680 Offset: 0x1EAAC80 VA: 0x181EAC680 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EABE70 Offset: 0x1EAA470 VA: 0x181EABE70
	public static PlayerAttack Deserialize(byte[] buffer, PlayerAttack instance, bool isDelta = False) { }

	// RVA: 0x1EAC130 Offset: 0x1EAA730 VA: 0x181EAC130
	public static PlayerAttack Deserialize(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EAB930 Offset: 0x1EA9F30 VA: 0x181EAB930
	public static PlayerAttack DeserializeLengthDelimited(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EABBA0 Offset: 0x1EAA1A0 VA: 0x181EABBA0
	public static PlayerAttack DeserializeLength(Stream stream, int length, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EAC800 Offset: 0x1EAAE00 VA: 0x181EAC800
	public static void SerializeDelta(Stream stream, PlayerAttack instance, PlayerAttack previous) { }

	// RVA: 0x1EACBF0 Offset: 0x1EAB1F0 VA: 0x181EACBF0
	public static void Serialize(Stream stream, PlayerAttack instance) { }

	// RVA: 0x1EACDE0 Offset: 0x1EAB3E0 VA: 0x181EACDE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EACDF0 Offset: 0x1EAB3F0 VA: 0x181EACDF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EACAE0 Offset: 0x1EAB0E0 VA: 0x181EACAE0
	public static byte[] SerializeToBytes(PlayerAttack instance) { }

	// RVA: 0x1EACA30 Offset: 0x1EAB030 VA: 0x181EACA30
	public static void SerializeLengthDelimited(Stream stream, PlayerAttack instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerProjectileAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6485
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PlayerAttack playerAttack; // 0x18
	public Vector3 hitVelocity; // 0x20
	public float hitDistance; // 0x2C
	public float travelTime; // 0x30

	// Methods

	// RVA: 0x2039970 Offset: 0x2037F70 VA: 0x182039970
	public static void ResetToPool(PlayerProjectileAttack instance) { }

	// RVA: 0x2039A50 Offset: 0x2038050 VA: 0x182039A50
	public void ResetToPool() { }

	// RVA: 0x20395D0 Offset: 0x2037BD0 VA: 0x1820395D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2038320 Offset: 0x2036920 VA: 0x182038320
	public void CopyTo(PlayerProjectileAttack instance) { }

	// RVA: 0x20383C0 Offset: 0x20369C0 VA: 0x1820383C0
	public PlayerProjectileAttack Copy() { }

	// RVA: 0x2038E60 Offset: 0x2037460 VA: 0x182038E60
	public static PlayerProjectileAttack Deserialize(Stream stream) { }

	// RVA: 0x2038790 Offset: 0x2036D90 VA: 0x182038790
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2038810 Offset: 0x2036E10 VA: 0x182038810
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2038B60 Offset: 0x2037160 VA: 0x182038B60
	public static PlayerProjectileAttack Deserialize(byte[] buffer) { }

	// RVA: 0x2039730 Offset: 0x2037D30 VA: 0x182039730
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203A400 Offset: 0x2038A00 VA: 0x18203A400 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203A420 Offset: 0x2038A20 VA: 0x18203A420 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileAttack previous) { }

	// RVA: 0x2039950 Offset: 0x2037F50 VA: 0x182039950 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20392F0 Offset: 0x20378F0 VA: 0x1820392F0
	public static PlayerProjectileAttack Deserialize(byte[] buffer, PlayerProjectileAttack instance, bool isDelta = False) { }

	// RVA: 0x20390C0 Offset: 0x20376C0 VA: 0x1820390C0
	public static PlayerProjectileAttack Deserialize(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x20384A0 Offset: 0x2036AA0 VA: 0x1820384A0
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x20388A0 Offset: 0x2036EA0 VA: 0x1820388A0
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2039B30 Offset: 0x2038130 VA: 0x182039B30
	public static void SerializeDelta(Stream stream, PlayerProjectileAttack instance, PlayerProjectileAttack previous) { }

	// RVA: 0x203A110 Offset: 0x2038710 VA: 0x18203A110
	public static void Serialize(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x203A3F0 Offset: 0x20389F0 VA: 0x18203A3F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x203A400 Offset: 0x2038A00 VA: 0x18203A400
	public void ToProto(Stream stream) { }

	// RVA: 0x203A000 Offset: 0x2038600 VA: 0x18203A000
	public static byte[] SerializeToBytes(PlayerProjectileAttack instance) { }

	// RVA: 0x2039F50 Offset: 0x2038550 VA: 0x182039F50
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerProjectileRicochet : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6486
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 hitPosition; // 0x18
	public Vector3 inVelocity; // 0x24
	public Vector3 outVelocity; // 0x30
	public Vector3 hitNormal; // 0x3C
	public float travelTime; // 0x48

	// Methods

	// RVA: 0x203C600 Offset: 0x203AC00 VA: 0x18203C600
	public static void ResetToPool(PlayerProjectileRicochet instance) { }

	// RVA: 0x203C530 Offset: 0x203AB30 VA: 0x18203C530
	public void ResetToPool() { }

	// RVA: 0x203BE50 Offset: 0x203A450 VA: 0x18203BE50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203A440 Offset: 0x2038A40 VA: 0x18203A440
	public void CopyTo(PlayerProjectileRicochet instance) { }

	// RVA: 0x203A4A0 Offset: 0x2038AA0 VA: 0x18203A4A0
	public PlayerProjectileRicochet Copy() { }

	// RVA: 0x203B870 Offset: 0x2039E70 VA: 0x18203B870
	public static PlayerProjectileRicochet Deserialize(Stream stream) { }

	// RVA: 0x203A560 Offset: 0x2038B60 VA: 0x18203A560
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203AC20 Offset: 0x2039220 VA: 0x18203AC20
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203B2A0 Offset: 0x20398A0 VA: 0x18203B2A0
	public static PlayerProjectileRicochet Deserialize(byte[] buffer) { }

	// RVA: 0x203BFB0 Offset: 0x203A5B0 VA: 0x18203BFB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203D3A0 Offset: 0x203B9A0 VA: 0x18203D3A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203D3C0 Offset: 0x203B9C0 VA: 0x18203D3C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileRicochet previous) { }

	// RVA: 0x203C220 Offset: 0x203A820 VA: 0x18203C220 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203BB10 Offset: 0x203A110 VA: 0x18203BB10
	public static PlayerProjectileRicochet Deserialize(byte[] buffer, PlayerProjectileRicochet instance, bool isDelta = False) { }

	// RVA: 0x203B600 Offset: 0x2039C00 VA: 0x18203B600
	public static PlayerProjectileRicochet Deserialize(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203A8E0 Offset: 0x2038EE0 VA: 0x18203A8E0
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203AF80 Offset: 0x2039580 VA: 0x18203AF80
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203C6D0 Offset: 0x203ACD0 VA: 0x18203C6D0
	public static void SerializeDelta(Stream stream, PlayerProjectileRicochet instance, PlayerProjectileRicochet previous) { }

	// RVA: 0x203CF80 Offset: 0x203B580 VA: 0x18203CF80
	public static void Serialize(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x203D390 Offset: 0x203B990 VA: 0x18203D390
	public byte[] ToProtoBytes() { }

	// RVA: 0x203D3A0 Offset: 0x203B9A0 VA: 0x18203D3A0
	public void ToProto(Stream stream) { }

	// RVA: 0x203CE70 Offset: 0x203B470 VA: 0x18203CE70
	public static byte[] SerializeToBytes(PlayerProjectileRicochet instance) { }

	// RVA: 0x203CDC0 Offset: 0x203B3C0 VA: 0x18203CDC0
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerProjectileUpdate : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6487
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 curPosition; // 0x18
	public Vector3 curVelocity; // 0x24
	public float travelTime; // 0x30

	// Methods

	// RVA: 0x203E8B0 Offset: 0x203CEB0 VA: 0x18203E8B0
	public static void ResetToPool(PlayerProjectileUpdate instance) { }

	// RVA: 0x203E960 Offset: 0x203CF60 VA: 0x18203E960
	public void ResetToPool() { }

	// RVA: 0x203E550 Offset: 0x203CB50 VA: 0x18203E550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203D3E0 Offset: 0x203B9E0 VA: 0x18203D3E0
	public void CopyTo(PlayerProjectileUpdate instance) { }

	// RVA: 0x203D420 Offset: 0x203BA20 VA: 0x18203D420
	public PlayerProjectileUpdate Copy() { }

	// RVA: 0x203DB50 Offset: 0x203C150 VA: 0x18203DB50
	public static PlayerProjectileUpdate Deserialize(Stream stream) { }

	// RVA: 0x203D4C0 Offset: 0x203BAC0 VA: 0x18203D4C0
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203DAC0 Offset: 0x203C0C0 VA: 0x18203DAC0
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203DD90 Offset: 0x203C390 VA: 0x18203DD90
	public static PlayerProjectileUpdate Deserialize(byte[] buffer) { }

	// RVA: 0x203E680 Offset: 0x203CC80 VA: 0x18203E680
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203F2C0 Offset: 0x203D8C0 VA: 0x18203F2C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203F2E0 Offset: 0x203D8E0 VA: 0x18203F2E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileUpdate previous) { }

	// RVA: 0x203E890 Offset: 0x203CE90 VA: 0x18203E890 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203E280 Offset: 0x203C880 VA: 0x18203E280
	public static PlayerProjectileUpdate Deserialize(byte[] buffer, PlayerProjectileUpdate instance, bool isDelta = False) { }

	// RVA: 0x203E070 Offset: 0x203C670 VA: 0x18203E070
	public static PlayerProjectileUpdate Deserialize(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203D540 Offset: 0x203BB40 VA: 0x18203D540
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203D810 Offset: 0x203BE10 VA: 0x18203D810
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203EA10 Offset: 0x203D010 VA: 0x18203EA10
	public static void SerializeDelta(Stream stream, PlayerProjectileUpdate instance, PlayerProjectileUpdate previous) { }

	// RVA: 0x203F020 Offset: 0x203D620 VA: 0x18203F020
	public static void Serialize(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x203F2B0 Offset: 0x203D8B0 VA: 0x18203F2B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x203F2C0 Offset: 0x203D8C0 VA: 0x18203F2C0
	public void ToProto(Stream stream) { }

	// RVA: 0x203EF10 Offset: 0x203D510 VA: 0x18203EF10
	public static byte[] SerializeToBytes(PlayerProjectileUpdate instance) { }

	// RVA: 0x203EE60 Offset: 0x203D460 VA: 0x18203EE60
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6544
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EAD970 Offset: 0x1EABF70 VA: 0x181EAD970
	public static void ResetToPool(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EAD8F0 Offset: 0x1EABEF0 VA: 0x181EAD8F0
	public void ResetToPool() { }

	// RVA: 0x1EAD7C0 Offset: 0x1EABDC0 VA: 0x181EAD7C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EACE30 Offset: 0x1EAB430 VA: 0x181EACE30
	public PlayerDetectedAIEventData Copy() { }

	// RVA: 0x1EAD740 Offset: 0x1EABD40 VA: 0x181EAD740
	public static PlayerDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EACEA0 Offset: 0x1EAB4A0 VA: 0x181EACEA0
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAD340 Offset: 0x1EAB940 VA: 0x181EAD340
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAD620 Offset: 0x1EABC20 VA: 0x181EAD620
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EAD8B0 Offset: 0x1EABEB0 VA: 0x181EAD8B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EADDC0 Offset: 0x1EAC3C0 VA: 0x181EADDC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EADDE0 Offset: 0x1EAC3E0 VA: 0x181EADDE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EAD8D0 Offset: 0x1EABED0 VA: 0x181EAD8D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAD520 Offset: 0x1EABB20 VA: 0x181EAD520
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer, PlayerDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EAD3D0 Offset: 0x1EAB9D0 VA: 0x181EAD3D0
	public static PlayerDetectedAIEventData Deserialize(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EACF20 Offset: 0x1EAB520 VA: 0x181EACF20
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EAD140 Offset: 0x1EAB740 VA: 0x181EAD140
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EAD9F0 Offset: 0x1EABFF0 VA: 0x181EAD9F0
	public static void SerializeDelta(Stream stream, PlayerDetectedAIEventData instance, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EADCD0 Offset: 0x1EAC2D0 VA: 0x181EADCD0
	public static void Serialize(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EADDB0 Offset: 0x1EAC3B0 VA: 0x181EADDB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EADDC0 Offset: 0x1EAC3C0 VA: 0x181EADDC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EADBC0 Offset: 0x1EAC1C0 VA: 0x181EADBC0
	public static byte[] SerializeToBytes(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EADB10 Offset: 0x1EAC110 VA: 0x181EADB10
	public static void SerializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PlayerIdleAnimationRandomiser : StateMachineBehaviour // TypeDefIndex: 8270
{	// Fields
	public int MaxValue; // 0x18
	public static int Param_Random; // 0x0
	private TimeSince lastRandomisation; // 0x1C

	// Methods

	// RVA: 0xC32510 Offset: 0xC30B10 VA: 0x180C32510 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0xC32740 Offset: 0xC30D40 VA: 0x180C32740
	public void .ctor() { }

	// RVA: 0xC326F0 Offset: 0xC30CF0 VA: 0x180C326F0
	private static void .cctor() { }

}

public class BasePlayer : BaseCombatEntity, LootPanel.IHasLootPanel // TypeDefIndex: 8336
{	// Fields
	private Option __menuOption_Climb; // 0x240
	private Option __menuOption_Drink; // 0x298
	private Option __menuOption_InviteToTeam; // 0x2F0
	private Option __menuOption_Menu_AssistPlayer; // 0x348
	private Option __menuOption_Menu_LootPlayer; // 0x3A0
	private Option __menuOption_Promote; // 0x3F8
	private Option __menuOption_SaltWater; // 0x450
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static string lootPanelOverride; // 0x0
	private TimeSince lastOpenSoundPlay; // 0x4A8
	public BasePlayer.CameraMode currentViewMode; // 0x4AC
	public BasePlayer.CameraMode selectedViewMode; // 0x4B0
	private Vector3 lastRevivePoint; // 0x4B4
	private Vector3 lastReviveDirection; // 0x4C0
	public PlayerModel playerModel; // 0x4D0
	public bool Frozen; // 0x4D8
	public PlayerVoiceRecorder voiceRecorder; // 0x4E0
	public PlayerVoiceSpeaker voiceSpeaker; // 0x4E8
	public PlayerInput input; // 0x4F0
	public BaseMovement movement; // 0x4F8
	public BaseCollision collision; // 0x500
	private static InputState emptyState; // 0x8
	private GameObject _lookingAt; // 0x508
	private BaseEntity _lookingAtEntity; // 0x510
	private Collider _lookingAtCollider; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <lookingAtPoint>k__BackingField; // 0x520
	private const string playerModelPrefab = "assets/prefabs/player/player_model.prefab";
	private const string playerCollisionPrefab = "assets/prefabs/player/player_collision.prefab";
	private float wakeTime; // 0x52C
	private bool needsClothesRebuild; // 0x530
	private bool wasSleeping; // 0x531
	private bool wokeUpBefore; // 0x532
	private bool wasDead; // 0x533
	private uint lastClothesHash; // 0x534
	private static ListDictionary<ulong, BasePlayer> visiblePlayerList; // 0x10
	public static int craftMode; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsWearingDiveGoggles>k__BackingField; // 0x538
	public ViewModel GestureViewModel; // 0x540
	public const float INTERACTION_TICK_RATE = 0,1;
	private RealTimeSince timeSinceUpdatedLookingAt; // 0x548
	private float nextTopologyTestTime; // 0x54C
	private float usePressTime; // 0x550
	private float useHeldTime; // 0x554
	private HitTest lookingAtTest; // 0x558
	public static float lastDeathTimeClient; // 0x1C
	private const float drinkRange = 1,5;
	private const float drinkMovementSpeed = 0,1;
	private Vector3 cachedWaterDrinkingPoint; // 0x560
	public const string GestureCancelString = "cancel";
	public GestureCollection gestureList; // 0x570
	private TimeUntil gestureFinishedTime; // 0x578
	private TimeSince blockHeldInputTimer; // 0x57C
	private GestureConfig currentGesture; // 0x580
	private HeldEntity disabledHeldEntity; // 0x588
	private float nextGestureMenuOpenTime; // 0x590
	private TimeSince lastGestureCancel; // 0x594
	public float client_lastHelloTime; // 0x598
	public ulong currentTeam; // 0x5A0
	public static readonly Translate.Phrase MaxTeamSizeToast; // 0x20
	public PlayerTeam clientTeam; // 0x5A8
	private float lastReceivedTeamTime; // 0x5B0
	private ulong lastPresenceTeamId; // 0x5B8
	private int lastPresenceTeamSize; // 0x5C0
	private string playerGroupKey; // 0x5C8
	private string playerGroupSizeKey; // 0x5D0
	private uint clActiveItem; // 0x5D8
	public MapNote ClientCurrentMapNote; // 0x5E0
	public MapNote ClientCurrentDeathNote; // 0x5E8
	public List<BaseMission.MissionInstance> missions; // 0x5F0
	private int _activeMission; // 0x5F8
	public ModelState modelState; // 0x600
	private EntityRef mounted; // 0x608
	private float nextSeatSwapTime; // 0x618
	public BaseEntity PetEntity; // 0x620
	private float lastPetCommandIssuedTime; // 0x628
	public uint PetPrefabID; // 0x62C
	public uint PetID; // 0x630
	public static bool PetWheelHasBeenOpened; // 0x28
	private float cachedBuildingPrivilegeTime; // 0x634
	private BuildingPrivlidge cachedBuildingPrivilege; // 0x638
	private int maxProjectileID; // 0x640
	private const int WILDERNESS = 1;
	private const int MONUMENT = 2;
	private const int BASE = 4;
	private const int FLYING = 8;
	private const int BOATING = 16;
	private const int SWIMMING = 32;
	private const int DRIVING = 64;
	private float lastUpdateTime; // 0x644
	private float cachedThreatLevel; // 0x648
	public const int serverTickRateDefault = 16;
	public const int clientTickRateDefault = 20;
	public int serverTickRate; // 0x64C
	public int clientTickRate; // 0x650
	public float serverTickInterval; // 0x654
	public float clientTickInterval; // 0x658
	private float lastSentTickTime; // 0x65C
	private Stopwatch lastTickStopwatch; // 0x660
	private PlayerTick lastSentTick; // 0x668
	private float nextVisThink; // 0x670
	private float lastTimeSeen; // 0x674
	private bool debugPrevVisible; // 0x678
	[HeaderAttribute] // RVA: 0xBBBD0 Offset: 0xBAFD0 VA: 0x1800BBBD0
	public GameObjectRef fallDamageEffect; // 0x680
	public GameObjectRef drownEffect; // 0x688
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public BasePlayer.PlayerFlags playerFlags; // 0x690
	public PlayerEyes eyes; // 0x698
	public PlayerInventory inventory; // 0x6A0
	public PlayerBlueprints blueprints; // 0x6A8
	public PlayerMetabolism metabolism; // 0x6B0
	public PlayerModifiers modifiers; // 0x6B8
	private CapsuleCollider playerCollider; // 0x6C0
	public PlayerBelt Belt; // 0x6C8
	private Rigidbody playerRigidbody; // 0x6D0
	public ulong userID; // 0x6D8
	public string UserIDString; // 0x6E0
	public int gamemodeteam; // 0x6E8
	public int reputation; // 0x6EC
	protected string _displayName; // 0x6F0
	private string _lastSetName; // 0x6F8
	public const float crouchSpeed = 1,7;
	public const float walkSpeed = 2,8;
	public const float runSpeed = 5,5;
	public const float crawlSpeed = 0,72;
	private BasePlayer.CapsuleColliderInfo playerColliderStanding; // 0x700
	private BasePlayer.CapsuleColliderInfo playerColliderDucked; // 0x714
	private BasePlayer.CapsuleColliderInfo playerColliderCrawling; // 0x728
	private BasePlayer.CapsuleColliderInfo playerColliderLyingDown; // 0x73C
	private ProtectionProperties cachedProtection; // 0x750
	public static bool oldCameraFix; // 0x29
	private float lastHeadshotSoundTime; // 0x758
	private float nextColliderRefreshTime; // 0x75C
	public bool clothingBlocksAiming; // 0x760
	public float clothingMoveSpeedReduction; // 0x764
	public float clothingWaterSpeedBonus; // 0x768
	public float clothingAccuracyBonus; // 0x76C
	public bool equippingBlocked; // 0x770
	public float eggVision; // 0x774
	private PhoneController activeTelephone; // 0x778
	public BaseEntity designingAIEntity; // 0x780

	// Properties
	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	internal BasePlayer.CameraMode idealViewMode { get; }
	internal bool shouldDrawBody { get; }
	public GameObject lookingAt { get; }
	public BaseEntity lookingAtEntity { get; }
	public Collider lookingAtCollider { get; }
	public Vector3 lookingAtPoint { get; set; }
	public float TimeAwake { get; }
	public static BufferList<BasePlayer> VisiblePlayerList { get; }
	public bool IsWearingDiveGoggles { get; set; }
	public bool IsReceivingSnapshot { get; }
	public bool IsAdmin { get; }
	public bool IsDeveloper { get; }
	public bool IsAiming { get; }
	public bool IsFlying { get; }
	public bool IsConnected { get; }
	public bool InGesture { get; }
	private bool CurrentGestureBlocksMovement { get; }
	public bool CurrentGestureIsDance { get; }
	public bool CurrentGestureIsFullBody { get; }
	private bool InGestureCancelCooldown { get; }
	public float clientTeamLifetime { get; }
	public bool isMounted { get; }
	public bool isMountingHidingWeapon { get; }
	public Connection Connection { get; }
	public string displayName { get; set; }
	public override BaseEntity.TraitFlag Traits { get; }
	public bool HasActiveTelephone { get; }
	public bool IsDesigningAI { get; }

	// Methods

	// RVA: 0x7123A0 Offset: 0x7109A0 VA: 0x1807123A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x72CC60 Offset: 0x72B260 VA: 0x18072CC60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x71A510 Offset: 0x718B10 VA: 0x18071A510 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x708210 Offset: 0x706810 VA: 0x180708210 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x72D1A0 Offset: 0x72B7A0 VA: 0x18072D1A0 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	[BaseEntity.Menu] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.Description] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.Icon] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.ShowIf] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	// RVA: 0x7193F0 Offset: 0x7179F0 VA: 0x1807193F0
	public void Menu_LootPlayer(BasePlayer player) { }

	// RVA: 0x7193D0 Offset: 0x7179D0 VA: 0x1807193D0
	public bool Menu_LootPlayer_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x724DC0 Offset: 0x7233C0 VA: 0x180724DC0
	private void RPC_OpenLootPanel(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x723130 Offset: 0x721730 VA: 0x180723130
	private void PlayOpenSound() { }

	// RVA: 0x7152C0 Offset: 0x7138C0 VA: 0x1807152C0
	public bool InFirstPersonMode() { }

	// RVA: 0x72AF50 Offset: 0x729550 VA: 0x18072AF50
	public void UpdateViewMode() { }

	// RVA: 0x72D310 Offset: 0x72B910 VA: 0x18072D310
	internal BasePlayer.CameraMode get_idealViewMode() { }

	// RVA: 0x72D770 Offset: 0x72BD70 VA: 0x18072D770
	internal bool get_shouldDrawBody() { }

	// RVA: 0x722BF0 Offset: 0x7211F0 VA: 0x180722BF0 Slot: 146
	public virtual void OnViewModeChanged() { }

	// RVA: 0x719460 Offset: 0x717A60 VA: 0x180719460
	public void ModifyCamera() { }

	[BaseEntity.Menu] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.Description] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.Icon] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.ShowIf] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	// RVA: 0x719390 Offset: 0x717990 VA: 0x180719390
	public void Menu_AssistPlayer(BasePlayer player) { }

	// RVA: 0x719350 Offset: 0x717950 VA: 0x180719350
	public void Menu_AssistPlayer_TimeStart() { }

	// RVA: 0x7190C0 Offset: 0x7176C0 VA: 0x1807190C0
	public bool Menu_AssistPlayer_ShowIf(BasePlayer player) { }

	// RVA: 0x72D720 Offset: 0x72BD20 VA: 0x18072D720
	public GameObject get_lookingAt() { }

	// RVA: 0x72D6B0 Offset: 0x72BCB0 VA: 0x18072D6B0
	public BaseEntity get_lookingAtEntity() { }

	// RVA: 0x72D660 Offset: 0x72BC60 VA: 0x18072D660
	public Collider get_lookingAtCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D700 Offset: 0x72BD00 VA: 0x18072D700
	public Vector3 get_lookingAtPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72DB30 Offset: 0x72C130 VA: 0x18072DB30
	private void set_lookingAtPoint(Vector3 value) { }

	// RVA: 0x7116F0 Offset: 0x70FCF0 VA: 0x1807116F0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x7121A0 Offset: 0x7107A0 VA: 0x1807121A0 Slot: 57
	public override Vector3 GetLocalVelocityClient() { }

	// RVA: 0x709D10 Offset: 0x708310 VA: 0x180709D10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x70EA30 Offset: 0x70D030 VA: 0x18070EA30
	private void CreatePlayerModel() { }

	// RVA: 0x70E880 Offset: 0x70CE80 VA: 0x18070E880
	private void CreatePlayerCollision() { }

	// RVA: 0x70EF50 Offset: 0x70D550 VA: 0x18070EF50
	private void CreatePlayerMovement() { }

	// RVA: 0x715310 Offset: 0x713910 VA: 0x180715310
	internal void InitLocalPlayer() { }

	// RVA: 0x7155F0 Offset: 0x713BF0 VA: 0x1807155F0
	internal void InitRemotePlayer() { }

	// RVA: 0x714970 Offset: 0x712F70 VA: 0x180714970
	public bool HasLocalControls() { }

	// RVA: 0x727AF0 Offset: 0x7260F0 VA: 0x180727AF0 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x727BA0 Offset: 0x7261A0 VA: 0x180727BA0 Slot: 60
	public override void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x70F410 Offset: 0x70DA10 VA: 0x18070F410 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7238A0 Offset: 0x721EA0 VA: 0x1807238A0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x719E40 Offset: 0x718440 VA: 0x180719E40
	private void OnFirstWakeUp() { }

	// RVA: 0x72D1D0 Offset: 0x72B7D0 VA: 0x18072D1D0
	public float get_TimeAwake() { }

	// RVA: 0x707810 Offset: 0x705E10 VA: 0x180707810
	public void CL_ClothingChanged() { }

	// RVA: 0x710B00 Offset: 0x70F100 VA: 0x180710B00
	public void ForceRebuild() { }

	// RVA: 0x725260 Offset: 0x723860 VA: 0x180725260
	internal void RebuildWorldModel(PlayerModel pModel) { }

	// RVA: 0x727280 Offset: 0x725880 VA: 0x180727280
	private void SetDefaultFootstepEffects(PlayerModel pModel) { }

	// RVA: 0x722670 Offset: 0x720C70 VA: 0x180722670 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x710110 Offset: 0x70E710 VA: 0x180710110 Slot: 124
	public override Transform FindBone(string strName) { }

	// RVA: 0x710C30 Offset: 0x70F230 VA: 0x180710C30 Slot: 123
	public override Transform[] GetBones() { }

	// RVA: 0x7283B0 Offset: 0x7269B0 VA: 0x1807283B0 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x72D230 Offset: 0x72B830 VA: 0x18072D230
	public static BufferList<BasePlayer> get_VisiblePlayerList() { }

	// RVA: 0x709840 Offset: 0x707E40 VA: 0x180709840
	public static void ClearVisibility() { }

	// RVA: 0x725A00 Offset: 0x724000 VA: 0x180725A00
	public static void RegisterForVisibility(BasePlayer player) { }

	// RVA: 0x728CB0 Offset: 0x7272B0 VA: 0x180728CB0
	public static void UnregisterFromVisibility(ulong userID) { }

	// RVA: 0x710210 Offset: 0x70E810 VA: 0x180710210
	public static BasePlayer FindByID_Clientside(ulong userID) { }

	// RVA: 0x7103E0 Offset: 0x70E9E0 VA: 0x1807103E0
	public static BasePlayer Find_Clientside(string strNameOrIDOrIP) { }

	// RVA: 0x714190 Offset: 0x712790 VA: 0x180714190
	public static float GetRandomFloatBasedOnUserID(ulong steamid, ulong seed) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x728380 Offset: 0x726980 VA: 0x180728380 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x727740 Offset: 0x725D40 VA: 0x180727740
	public void SetInheritedVelocity(Vector3 velocity, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x713ED0 Offset: 0x7124D0 VA: 0x180713ED0
	public void GetPerformanceReport(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x713A50 Offset: 0x712050 VA: 0x180713A50
	public void GetPerformanceReport_Frametime(BaseEntity.RPCMessage msg) { }

	// RVA: 0x719880 Offset: 0x717E80 VA: 0x180719880 Slot: 63
	public override void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x7230F0 Offset: 0x7216F0 VA: 0x1807230F0 Slot: 74
	public override void OnVoiceData(byte[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7255D0 Offset: 0x723BD0 VA: 0x1807255D0
	public void RecieveAchievement(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70E610 Offset: 0x70CC10 VA: 0x18070E610
	public void CraftMode(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7286A0 Offset: 0x726CA0 VA: 0x1807286A0
	public void StartDesigningAI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x719C00 Offset: 0x718200 VA: 0x180719C00
	public void OnDebugAIEventTriggeredStateChange(int previousStateContainerID, int newStateContainerID, int sourceEventID) { }

	// RVA: 0x70ACB0 Offset: 0x7092B0 VA: 0x18070ACB0 Slot: 13
	public override void ClientOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D090 Offset: 0x70B690 VA: 0x18070D090
	private void Client_OnRepairFailedResources(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728910 Offset: 0x726F10 VA: 0x180728910
	private void TakeDamageHit() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x705DE0 Offset: 0x7043E0 VA: 0x180705DE0
	private void AdminReceivedUGC(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x705D20 Offset: 0x704320 VA: 0x180705D20
	private void AdminReceivedPatternFirework(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D190 Offset: 0x72B790 VA: 0x18072D190
	public bool get_IsWearingDiveGoggles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D920 Offset: 0x72BF20 VA: 0x18072D920
	private void set_IsWearingDiveGoggles(bool value) { }

	// RVA: 0x728E00 Offset: 0x727400 VA: 0x180728E00
	protected void UpdateClothesIfNeeded() { }

	// RVA: 0x718DC0 Offset: 0x7173C0 VA: 0x180718DC0 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0x70C170 Offset: 0x70A770 VA: 0x18070C170
	protected void ClientUpdate_Sleeping() { }

	// RVA: 0x70C550 Offset: 0x70AB50 VA: 0x18070C550
	protected void ClientUpdate() { }

	// RVA: 0x725040 Offset: 0x723640 VA: 0x180725040
	public void RebuildClothingItems() { }

	// RVA: 0x7292F0 Offset: 0x7278F0 VA: 0x1807292F0
	public void UpdateClothingItems(SkinnedMultiMesh multiMesh) { }

	// RVA: 0x729A20 Offset: 0x728020 VA: 0x180729A20
	public void UpdateHolsterOffsets() { }

	// RVA: 0x7237E0 Offset: 0x721DE0 VA: 0x1807237E0
	public void PostLateClientCycle() { }

	// RVA: 0x716F40 Offset: 0x715540 VA: 0x180716F40
	public bool IsLocalPlayer() { }

	// RVA: 0x70AE10 Offset: 0x709410 VA: 0x18070AE10
	public void ClientUpdateLocalPlayer() { }

	// RVA: 0x72ADF0 Offset: 0x7293F0 VA: 0x18072ADF0
	public void UpdateTopologyStats() { }

	// RVA: 0x70AD60 Offset: 0x709360 VA: 0x18070AD60
	private void ClientTick() { }

	// RVA: 0x70F700 Offset: 0x70DD00 VA: 0x18070F700
	public void DoMovement() { }

	// RVA: 0x719550 Offset: 0x717B50 VA: 0x180719550
	private void MountableOverrideViewAngles() { }

	// RVA: 0x706D50 Offset: 0x705350 VA: 0x180706D50 Slot: 147
	public virtual void BlockSprint(float duration = 0,2) { }

	// RVA: 0x706CB0 Offset: 0x7052B0 VA: 0x180706CB0 Slot: 148
	public virtual void BlockJump(float duration = 0,5) { }

	// RVA: 0x70A200 Offset: 0x708800 VA: 0x18070A200 Slot: 149
	internal virtual void ClientInput(InputState state) { }

	// RVA: 0x72B2B0 Offset: 0x7298B0 VA: 0x18072B2B0
	internal void UseAction(InputState state) { }

	// RVA: 0x711C90 Offset: 0x710290 VA: 0x180711C90
	internal BaseEntity GetInteractionEntity() { }

	// RVA: 0x724C20 Offset: 0x723220 VA: 0x180724C20
	internal void QuickUse() { }

	// RVA: 0x718D00 Offset: 0x717300 VA: 0x180718D00
	internal void LongUse() { }

	// RVA: 0x72B580 Offset: 0x729B80 VA: 0x18072B580
	internal void UseStop() { }

	// RVA: 0x729BB0 Offset: 0x7281B0 VA: 0x180729BB0
	internal bool UpdateLookingAt(float radius, bool includeSecondaryEntities) { }

	// RVA: 0x725E50 Offset: 0x724450 VA: 0x180725E50
	private void ResetLookingAt() { }

	// RVA: 0x7278D0 Offset: 0x725ED0 VA: 0x1807278D0
	private void SetLookingAt(HitTest lookingAtTest) { }

	// RVA: 0x709040 Offset: 0x707640 VA: 0x180709040
	private bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x7102A0 Offset: 0x70E8A0 VA: 0x1807102A0
	private static BaseVehicle FindVehicleParentFor(BaseEntity entity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x719D70 Offset: 0x718370 VA: 0x180719D70
	private void OnDied(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x71A170 Offset: 0x718770 VA: 0x18071A170
	private void OnRespawnInformation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x725D00 Offset: 0x724300 VA: 0x180725D00
	private void RequestRespawnUpdates() { }

	// RVA: 0x719F80 Offset: 0x718580 VA: 0x180719F80
	public void OnLand(float fVelocity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728830 Offset: 0x726E30 VA: 0x180728830
	private void StartLoading() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x710680 Offset: 0x70EC80 VA: 0x180710680
	private void FinishLoading() { }

	// RVA: 0x710B10 Offset: 0x70F110 VA: 0x180710B10
	private void FullBlack_FadeIn() { }

	[IteratorStateMachineAttribute] // RVA: 0xBE9B0 Offset: 0xBDDB0 VA: 0x1800BE9B0
	// RVA: 0x7107D0 Offset: 0x70EDD0 VA: 0x1807107D0
	private IEnumerator FinishedLoadingRoutine() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70F1F0 Offset: 0x70D7F0 VA: 0x18070F1F0
	private void DirectionalDamage(Vector3 position, int damageType, int damageTotal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728C40 Offset: 0x727240 VA: 0x180728C40
	public void UnlockedBlueprint(BaseEntity.RPCMessage msg) { }

	// RVA: 0x708FD0 Offset: 0x7075D0 VA: 0x180708FD0
	private void CheckForRespawnInfo() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72AB50 Offset: 0x729150 VA: 0x18072AB50
	public void UpdateRichPresenceState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x714470 Offset: 0x712A70 VA: 0x180714470
	public void HandleCompanionPairingResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72AF90 Offset: 0x729590 VA: 0x18072AF90
	public Vector3 UpdateWaterDrinkingPoint() { }

	// RVA: 0x714450 Offset: 0x712A50 VA: 0x180714450
	private Vector3 GetWaterDrinkingPoint() { }

	[BaseEntity.Menu] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.Description] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.Icon] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	// RVA: 0x70F9A0 Offset: 0x70DFA0 VA: 0x18070F9A0
	public void Drink(BasePlayer player) { }

	// RVA: 0x70F7C0 Offset: 0x70DDC0 VA: 0x18070F7C0
	public bool Drink_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.Description] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.Icon] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void SaltWater(BasePlayer player) { }

	// RVA: 0x725FD0 Offset: 0x7245D0 VA: 0x180725FD0
	public bool SaltWater_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.Description] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.Icon] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.ShowIf] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	// RVA: 0x70DD90 Offset: 0x70C390 VA: 0x18070DD90
	public void Climb(BasePlayer player) { }

	// RVA: 0x70DAC0 Offset: 0x70C0C0 VA: 0x18070DAC0
	public bool Climb_ShowIf(BasePlayer player) { }

	// RVA: 0x7149E0 Offset: 0x712FE0 VA: 0x1807149E0
	public bool HasPlayerFlag(BasePlayer.PlayerFlags f) { }

	// RVA: 0x72D180 Offset: 0x72B780 VA: 0x18072D180
	public bool get_IsReceivingSnapshot() { }

	// RVA: 0x72D0A0 Offset: 0x72B6A0 VA: 0x18072D0A0
	public bool get_IsAdmin() { }

	// RVA: 0x72D150 Offset: 0x72B750 VA: 0x18072D150
	public bool get_IsDeveloper() { }

	// RVA: 0x72D0B0 Offset: 0x72B6B0 VA: 0x18072D0B0
	public bool get_IsAiming() { }

	// RVA: 0x72D160 Offset: 0x72B760 VA: 0x18072D160
	public bool get_IsFlying() { }

	// RVA: 0x72D0C0 Offset: 0x72B6C0 VA: 0x18072D0C0
	public bool get_IsConnected() { }

	// RVA: 0x72CFF0 Offset: 0x72B5F0 VA: 0x18072CFF0
	public bool get_InGesture() { }

	// RVA: 0x72CB40 Offset: 0x72B140 VA: 0x18072CB40
	private bool get_CurrentGestureBlocksMovement() { }

	// RVA: 0x72CB80 Offset: 0x72B180 VA: 0x18072CB80
	public bool get_CurrentGestureIsDance() { }

	// RVA: 0x72CBC0 Offset: 0x72B1C0 VA: 0x18072CBC0
	public bool get_CurrentGestureIsFullBody() { }

	// RVA: 0x72CFC0 Offset: 0x72B5C0 VA: 0x18072CFC0
	private bool get_InGestureCancelCooldown() { }

	// RVA: 0x727340 Offset: 0x725940 VA: 0x180727340
	private void SetGestureMenuOpen(bool wantsOpen) { }

	// RVA: 0x725DA0 Offset: 0x7243A0 VA: 0x180725DA0
	private void RequestStartGesture(GestureConfig g) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D5F0 Offset: 0x70BBF0 VA: 0x18070D5F0
	private void Client_StartGesture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x70D650 Offset: 0x70BC50 VA: 0x18070D650
	public void Client_StartGesture(GestureConfig gesture) { }

	// RVA: 0x723F90 Offset: 0x722590 VA: 0x180723F90
	private void ProcessDanceAction() { }

	// RVA: 0x726320 Offset: 0x724920 VA: 0x180726320
	public bool SayingHello() { }

	// RVA: 0x7244A0 Offset: 0x722AA0 VA: 0x1807244A0
	private void ProcessGestureStart() { }

	// RVA: 0x70FCC0 Offset: 0x70E2C0 VA: 0x18070FCC0
	private void EndGesture() { }

	// RVA: 0x70FD60 Offset: 0x70E360 VA: 0x18070FD60
	private void EndLocalGesture() { }

	// RVA: 0x70FB50 Offset: 0x70E150 VA: 0x18070FB50
	private void EndGestureShared() { }

	// RVA: 0x715150 Offset: 0x713750 VA: 0x180715150
	private void HideHeldEntity(bool state) { }

	// RVA: 0x708CF0 Offset: 0x7072F0 VA: 0x180708CF0
	private void CancelGesture() { }

	// RVA: 0x725AF0 Offset: 0x7240F0 VA: 0x180725AF0
	public void RemoteGestureCancel() { }

	// RVA: 0x7088D0 Offset: 0x706ED0 VA: 0x1807088D0
	private bool CancelGestureInput() { }

	// RVA: 0x7096F0 Offset: 0x707CF0 VA: 0x1807096F0
	public void ClearGestureCooldown() { }

	// RVA: 0x70E3A0 Offset: 0x70C9A0 VA: 0x18070E3A0
	public bool ConVarRequestStartGesture(string gestureName) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D5A0 Offset: 0x70BBA0 VA: 0x18070D5A0
	private void Client_RemoteCancelledGesture() { }

	// RVA: 0x716880 Offset: 0x714E80 VA: 0x180716880
	private bool IsGestureBlocked() { }

	// RVA: 0x72D2A0 Offset: 0x72B8A0 VA: 0x18072D2A0
	public float get_clientTeamLifetime() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x707340 Offset: 0x705940 VA: 0x180707340
	public void CLIENT_ReceiveTeamInfo(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72ABA0 Offset: 0x7291A0 VA: 0x18072ABA0
	private void UpdateSteamGroup(ulong teamId, int teamSize) { }

	// RVA: 0x709720 Offset: 0x707D20 VA: 0x180709720
	private void ClearSteamGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x706DF0 Offset: 0x7053F0 VA: 0x180706DF0
	public void CLIENT_ClearTeam(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x706F90 Offset: 0x705590 VA: 0x180706F90
	public void CLIENT_PendingInvite(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.Description] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.Icon] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	// RVA: 0x715660 Offset: 0x713C60 VA: 0x180715660
	public void InviteToTeam(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.Description] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.Icon] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	// RVA: 0x724A90 Offset: 0x723090 VA: 0x180724A90
	public void Promote(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Promote_Start() { }

	// RVA: 0x7246C0 Offset: 0x722CC0 VA: 0x1807246C0
	public bool Promote_ShowIf(BasePlayer player) { }

	// RVA: 0x718800 Offset: 0x716E00 VA: 0x180718800
	public static bool LocalPlayerIsLeader() { }

	// RVA: 0x715BC0 Offset: 0x7141C0 VA: 0x180715BC0
	public bool Invite_ShowIf(BasePlayer player) { }

	// RVA: 0x7117E0 Offset: 0x70FDE0 VA: 0x1807117E0
	public HeldEntity GetHeldEntity() { }

	// RVA: -1 Offset: -1
	public bool IsHoldingEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C890 Offset: 0x125AE90 VA: 0x18125C890
	|-BasePlayer.IsHoldingEntity<Hammer>
	|-BasePlayer.IsHoldingEntity<object>
	|-BasePlayer.IsHoldingEntity<WireTool>
	*/

	// RVA: 0x711A20 Offset: 0x710020 VA: 0x180711A20
	private Item GetHeldItem() { }

	// RVA: 0x7119D0 Offset: 0x70FFD0 VA: 0x1807119D0
	public uint GetHeldItemID() { }

	// RVA: 0x714F30 Offset: 0x713530 VA: 0x180714F30
	private void HeldEntityViewAngles() { }

	// RVA: 0x714AC0 Offset: 0x7130C0 VA: 0x180714AC0
	private void HeldEntityFrame() { }

	// RVA: 0x714C90 Offset: 0x713290 VA: 0x180714C90
	private void HeldEntityInput() { }

	// RVA: 0x715050 Offset: 0x713650 VA: 0x180715050
	private bool HeldItemUse() { }

	// RVA: 0x714E60 Offset: 0x713460 VA: 0x180714E60
	public void HeldEntityStart() { }

	// RVA: 0x7149F0 Offset: 0x712FF0 VA: 0x1807149F0
	public void HeldEntityEnd() { }

	// RVA: 0x716C40 Offset: 0x715240 VA: 0x180716C40
	public bool IsHostileItem(Item item) { }

	// RVA: 0x716DA0 Offset: 0x7153A0 VA: 0x180716DA0
	public bool IsItemHoldRestricted(Item item) { }

	// RVA: 0x718E70 Offset: 0x717470 VA: 0x180718E70
	private void MapInfoOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D260 Offset: 0x70B860 VA: 0x18070D260
	public void Client_ReceiveMarkers(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D990 Offset: 0x70BF90 VA: 0x18070D990
	public void Client_UpdateDeathMarker(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70CF50 Offset: 0x70B550 VA: 0x18070CF50
	public void Client_AddNewDeathMarker(BaseEntity.RPCMessage msg) { }

	// RVA: 0x705C40 Offset: 0x704240 VA: 0x180705C40
	public void AddPointOfInterest(Vector3 position) { }

	// RVA: 0x7095A0 Offset: 0x707BA0 VA: 0x1807095A0
	public void ClearAllPointsOfInterest() { }

	// RVA: 0x709440 Offset: 0x707A40 VA: 0x180709440
	public void ClearAllMapMarkers() { }

	// RVA: 0x714520 Offset: 0x712B20 VA: 0x180714520
	public bool HasAttemptedMission(uint missionID) { }

	// RVA: 0x707B50 Offset: 0x706150 VA: 0x180707B50
	public bool CanAcceptMission(uint missionID) { }

	// RVA: 0x717020 Offset: 0x715620 VA: 0x180717020
	public bool IsMissionActive(uint missionID) { }

	// RVA: 0x714690 Offset: 0x712C90 VA: 0x180714690
	public bool HasCompletedMission(uint missionID) { }

	// RVA: 0x714800 Offset: 0x712E00 VA: 0x180714800
	public bool HasFailedMission(uint missionID) { }

	// RVA: 0x727260 Offset: 0x725860 VA: 0x180727260
	public void SetActiveMission(int index) { }

	// RVA: 0x710C20 Offset: 0x70F220 VA: 0x180710C20
	public int GetActiveMission() { }

	// RVA: 0x714510 Offset: 0x712B10 VA: 0x180714510
	public bool HasActiveMission() { }

	// RVA: 0x717DE0 Offset: 0x7163E0 VA: 0x180717DE0
	private void LoadMissions(Missions loadedMissions) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x71A0E0 Offset: 0x7186E0 VA: 0x18071A0E0
	private void OnModelState(BaseEntity.RPCMessage data) { }

	// RVA: 0x71A040 Offset: 0x718640 VA: 0x18071A040
	private void OnModelStateChanged() { }

	// RVA: 0x72D560 Offset: 0x72BB60 VA: 0x18072D560
	public bool get_isMounted() { }

	// RVA: 0x72D590 Offset: 0x72BB90 VA: 0x18072D590
	public bool get_isMountingHidingWeapon() { }

	// RVA: 0x713510 Offset: 0x711B10 VA: 0x180713510
	public BaseMountable GetMounted() { }

	// RVA: 0x7134C0 Offset: 0x711AC0 VA: 0x1807134C0
	public BaseVehicle GetMountedVehicle() { }

	// RVA: 0x718EC0 Offset: 0x7174C0 VA: 0x180718EC0
	public void MarkSwapSeat() { }

	// RVA: 0x7288E0 Offset: 0x726EE0 VA: 0x1807288E0
	public bool SwapSeatCooldown() { }

	// RVA: 0x70BC30 Offset: 0x70A230 VA: 0x18070BC30
	public void ClientUpdateMounted(uint id) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x707740 Offset: 0x705D40 VA: 0x180707740
	public void CLIENT_SetPetPrefabID(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x707590 Offset: 0x705B90 VA: 0x180707590
	public void CLIENT_SetPetPetLoadedStateIndex(BaseEntity.RPCMessage msg) { }

	// RVA: 0x717C90 Offset: 0x716290 VA: 0x180717C90
	private void LinkPet() { }

	// RVA: 0x727CB0 Offset: 0x7262B0 VA: 0x180727CB0
	private void SetPetMenuOpen(bool wantsOpen) { }

	// RVA: 0x70ABC0 Offset: 0x7091C0 VA: 0x18070ABC0
	private void ClientIssuePetCommand(int cmdType, int param, bool raycast) { }

	// RVA: 0x717300 Offset: 0x715900 VA: 0x180717300
	public bool IsSleeping() { }

	// RVA: 0x717310 Offset: 0x715910 VA: 0x180717310
	public bool IsSpectating() { }

	// RVA: 0x717230 Offset: 0x715830 VA: 0x180717230
	public bool IsRelaxed() { }

	// RVA: 0x7172F0 Offset: 0x7158F0 VA: 0x1807172F0
	public bool IsServerFalling() { }

	// RVA: 0x711040 Offset: 0x70F640 VA: 0x180711040 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x7084E0 Offset: 0x706AE0 VA: 0x1807084E0
	public bool CanBuild() { }

	// RVA: 0x708380 Offset: 0x706980 VA: 0x180708380
	public bool CanBuild(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x7082B0 Offset: 0x7068B0 VA: 0x1807082B0
	public bool CanBuild(OBB obb) { }

	// RVA: 0x716610 Offset: 0x714C10 VA: 0x180716610
	public bool IsBuildingBlocked() { }

	// RVA: 0x7164B0 Offset: 0x714AB0 VA: 0x1807164B0
	public bool IsBuildingBlocked(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x7163D0 Offset: 0x7149D0 VA: 0x1807163D0
	public bool IsBuildingBlocked(OBB obb) { }

	// RVA: 0x7161D0 Offset: 0x7147D0 VA: 0x1807161D0
	public bool IsBuildingAuthed() { }

	// RVA: 0x716270 Offset: 0x714870 VA: 0x180716270
	public bool IsBuildingAuthed(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x716100 Offset: 0x714700 VA: 0x180716100
	public bool IsBuildingAuthed(OBB obb) { }

	// RVA: 0x708670 Offset: 0x706C70 VA: 0x180708670
	public bool CanPlaceBuildingPrivilege() { }

	// RVA: 0x7086E0 Offset: 0x706CE0 VA: 0x1807086E0
	public bool CanPlaceBuildingPrivilege(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x708820 Offset: 0x706E20 VA: 0x180708820
	public bool CanPlaceBuildingPrivilege(OBB obb) { }

	// RVA: 0x7195E0 Offset: 0x717BE0 VA: 0x1807195E0
	public int NewProjectileID() { }

	// RVA: 0x7195F0 Offset: 0x717BF0 VA: 0x1807195F0
	public int NewProjectileSeed() { }

	// RVA: 0x726FB0 Offset: 0x7255B0 VA: 0x180726FB0
	public void SendProjectileAttack(PlayerProjectileAttack attack) { }

	// RVA: 0x727000 Offset: 0x725600 VA: 0x180727000
	public void SendProjectileRicochet(PlayerProjectileRicochet ricochet) { }

	// RVA: 0x727050 Offset: 0x725650 VA: 0x180727050
	public void SendProjectileUpdate(PlayerProjectileUpdate update) { }

	// RVA: 0x7183A0 Offset: 0x7169A0 VA: 0x1807183A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728610 Offset: 0x726C10 VA: 0x180728610
	private void SpectatedPlayerHeadshot() { }

	// RVA: 0x714430 Offset: 0x712A30 VA: 0x180714430 Slot: 141
	public override float GetThreatLevel() { }

	// RVA: 0x70FE80 Offset: 0x70E480 VA: 0x18070FE80
	public void EnsureUpdated() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x727690 Offset: 0x725C90 VA: 0x180727690
	public void SetHostileLength(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7282E0 Offset: 0x7268E0 VA: 0x1807282E0
	public void SetWeaponDrawnDuration(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 150
	protected virtual void ModifyInputState(ref InputState inputState) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x710840 Offset: 0x70EE40 VA: 0x180710840
	private void ForcePositionToParentOffset(Vector3 position, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728DA0 Offset: 0x7273A0 VA: 0x180728DA0
	public void UpdateClientTickRate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x710970 Offset: 0x70EF70 VA: 0x180710970
	private void ForcePositionTo(Vector3 position) { }

	// RVA: 0x7270A0 Offset: 0x7256A0 VA: 0x1807270A0
	internal void SendVoiceData(byte[] data, int len) { }

	// RVA: 0x7268C0 Offset: 0x724EC0 VA: 0x1807268C0
	internal void SendClientTick() { }

	// RVA: 0x719650 Offset: 0x717C50 VA: 0x180719650
	public void NotifyUnderwearChange() { }

	// RVA: 0x72A850 Offset: 0x728E50 VA: 0x18072A850
	public static void UpdatePlayerVisibilities() { }

	// RVA: 0x728A40 Offset: 0x727040 VA: 0x180728A40
	private float TimeSinceSeen() { }

	// RVA: 0x727C80 Offset: 0x726280 VA: 0x180727C80
	private void SetNextVisThink(float addTime) { }

	// RVA: 0x72C0C0 Offset: 0x72A6C0 VA: 0x18072C0C0
	private bool WantsVisUpdate() { }

	// RVA: 0x715E00 Offset: 0x714400 VA: 0x180715E00
	public static bool IsAimingAt(BasePlayer aimer, BasePlayer target, float cone = 0,95) { }

	// RVA: 0x729750 Offset: 0x727D50 VA: 0x180729750 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0x72B700 Offset: 0x729D00 VA: 0x18072B700
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x72B810 Offset: 0x729E10 VA: 0x18072B810
	private void VisUpdateUsingRays(float dist) { }

	// RVA: 0x7189B0 Offset: 0x716FB0 VA: 0x1807189B0
	private void LogDebugCull(float dist) { }

	// RVA: 0x722DF0 Offset: 0x7213F0 VA: 0x180722DF0 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0x72BC30 Offset: 0x72A230 VA: 0x18072BC30
	private void VisUpdate() { }

	// RVA: 0x72B640 Offset: 0x729C40 VA: 0x18072B640
	private bool VisPlayerArmed() { }

	// RVA: 0x7060B0 Offset: 0x7046B0 VA: 0x1807060B0
	private bool AnyPartVisible() { }

	// RVA: 0x707A10 Offset: 0x706010 VA: 0x180707A10
	private float CalcVisUpdateRate(float dist) { }

	// RVA: 0x723510 Offset: 0x721B10 VA: 0x180723510
	private bool PointSeePoint(Vector3 target, Vector3 origin, float dist = 0, bool useGameTrace = False) { }

	// RVA: 0x7175F0 Offset: 0x715BF0 VA: 0x1807175F0
	public bool IsWounded() { }

	// RVA: 0x7166C0 Offset: 0x714CC0 VA: 0x1807166C0
	public bool IsCrawling() { }

	// RVA: 0x716D90 Offset: 0x715390 VA: 0x180716D90
	public bool IsIncapacitated() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 97
	public override BasePlayer ToPlayer() { }

	// RVA: 0x72CB30 Offset: 0x72B130 VA: 0x18072CB30
	public Connection get_Connection() { }

	// RVA: 0x72D2F0 Offset: 0x72B8F0 VA: 0x18072D2F0
	public string get_displayName() { }

	// RVA: 0x72D930 Offset: 0x72BF30 VA: 0x18072D930
	public void set_displayName(string value) { }

	// RVA: 0x7261A0 Offset: 0x7247A0 VA: 0x1807261A0
	public static string SanitizePlayerNameString(string playerName, ulong userId) { }

	// RVA: 0x716B70 Offset: 0x715170 VA: 0x180716B70
	public bool IsGod() { }

	// RVA: 0x7135B0 Offset: 0x711BB0 VA: 0x1807135B0 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	// RVA: 0x708610 Offset: 0x706C10 VA: 0x180708610
	public bool CanInteract() { }

	// RVA: 0x708580 Offset: 0x706B80 VA: 0x180708580
	public bool CanInteract(bool usableWhileCrawling) { }

	// RVA: 0x728810 Offset: 0x726E10 VA: 0x180728810 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x723120 Offset: 0x721720 VA: 0x180723120 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x718F00 Offset: 0x717500 VA: 0x180718F00 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x718FB0 Offset: 0x7175B0 VA: 0x180718FB0 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x72C5A0 Offset: 0x72ABA0 VA: 0x18072C5A0 Slot: 103
	public override OBB WorldSpaceBounds() { }

	// RVA: 0x7133F0 Offset: 0x7119F0 VA: 0x1807133F0
	public Vector3 GetMountVelocity() { }

	// RVA: 0x711B10 Offset: 0x710110 VA: 0x180711B10 Slot: 100
	public override Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x711BD0 Offset: 0x7101D0 VA: 0x180711BD0 Slot: 101
	public override Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x711A50 Offset: 0x710050 VA: 0x180711A50 Slot: 102
	public override Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x723B20 Offset: 0x722120 VA: 0x180723B20 Slot: 29
	public override void PreInitShared() { }

	// RVA: 0x70F170 Offset: 0x70D770 VA: 0x18070F170 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7152E0 Offset: 0x7138E0 VA: 0x1807152E0
	public bool InSafeZone() { }

	// RVA: 0x717600 Offset: 0x715C00 VA: 0x180717600
	public static void LateClientCycle() { }

	// RVA: 0x709A00 Offset: 0x708000 VA: 0x180709A00
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0x710CC0 Offset: 0x70F2C0 VA: 0x180710CC0
	public Bounds GetBounds(bool ducked) { }

	// RVA: 0x710E50 Offset: 0x70F450 VA: 0x180710E50
	public Bounds GetBounds() { }

	// RVA: 0x711110 Offset: 0x70F710 VA: 0x180711110
	public Vector3 GetCenter(bool ducked) { }

	// RVA: 0x711230 Offset: 0x70F830 VA: 0x180711230
	public Vector3 GetCenter() { }

	// RVA: 0x7136D0 Offset: 0x711CD0 VA: 0x1807136D0
	public Vector3 GetOffset(bool ducked) { }

	// RVA: 0x713650 Offset: 0x711C50 VA: 0x180713650
	public Vector3 GetOffset() { }

	// RVA: 0x714290 Offset: 0x712890 VA: 0x180714290
	public Vector3 GetSize(bool ducked) { }

	// RVA: 0x714210 Offset: 0x712810 VA: 0x180714210
	public Vector3 GetSize() { }

	// RVA: 0x7117C0 Offset: 0x70FDC0 VA: 0x1807117C0
	public float GetHeight(bool ducked) { }

	// RVA: 0x711780 Offset: 0x70FD80 VA: 0x180711780
	public float GetHeight() { }

	// RVA: 0x714180 Offset: 0x712780 VA: 0x180714180
	public float GetRadius() { }

	// RVA: 0x712190 Offset: 0x710790 VA: 0x180712190
	public float GetJumpHeight() { }

	// RVA: 0x728B40 Offset: 0x727140 VA: 0x180728B40 Slot: 104
	public override Vector3 TriggerPoint() { }

	// RVA: 0x719600 Offset: 0x717C00 VA: 0x180719600
	public Vector3 NoClipOffset() { }

	// RVA: 0x719640 Offset: 0x717C40 VA: 0x180719640
	public float NoClipRadius(float margin) { }

	// RVA: 0x718EF0 Offset: 0x7174F0 VA: 0x180718EF0
	public float MaxDeployDistance(Item item) { }

	// RVA: 0x70C140 Offset: 0x70A740 VA: 0x18070C140
	public void ClientUpdatePersistantData(PersistantPlayer data) { }

	// RVA: 0x7133C0 Offset: 0x7119C0 VA: 0x1807133C0
	public float GetMinSpeed() { }

	// RVA: 0x712370 Offset: 0x710970 VA: 0x180712370
	public float GetMaxSpeed() { }

	// RVA: 0x7142F0 Offset: 0x7128F0 VA: 0x1807142F0
	public float GetSpeed(float running, float ducking, float crawling) { }

	// RVA: 0x719690 Offset: 0x717C90 VA: 0x180719690 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x70FAF0 Offset: 0x70E0F0 VA: 0x18070FAF0
	private void EnablePlayerCollider() { }

	// RVA: 0x70F3B0 Offset: 0x70D9B0 VA: 0x18070F3B0
	private void DisablePlayerCollider() { }

	// RVA: 0x7256F0 Offset: 0x723CF0 VA: 0x1807256F0
	private void RefreshColliderSize(bool forced) { }

	// RVA: 0x7282C0 Offset: 0x7268C0 VA: 0x1807282C0
	private void SetPlayerRigidbodyState(bool isEnabled) { }

	// RVA: 0x705AC0 Offset: 0x7040C0 VA: 0x180705AC0
	private void AddPlayerRigidbody() { }

	// RVA: 0x725BD0 Offset: 0x7241D0 VA: 0x180725BD0
	private void RemovePlayerRigidbody() { }

	// RVA: 0x716790 Offset: 0x714D90 VA: 0x180716790
	public bool IsEnsnared() { }

	// RVA: 0x715FD0 Offset: 0x7145D0 VA: 0x180715FD0
	public bool IsAttacking() { }

	// RVA: 0x707FC0 Offset: 0x7065C0 VA: 0x180707FC0
	public bool CanAttack() { }

	// RVA: 0x719EF0 Offset: 0x7184F0 VA: 0x180719EF0
	public bool OnLadder() { }

	// RVA: 0x7175A0 Offset: 0x715BA0 VA: 0x1807175A0
	public bool IsSwimming() { }

	// RVA: 0x716BF0 Offset: 0x7151F0 VA: 0x180716BF0
	public bool IsHeadUnderwater() { }

	// RVA: 0x717190 Offset: 0x715790 VA: 0x180717190 Slot: 151
	public virtual bool IsOnGround() { }

	// RVA: 0x717240 Offset: 0x715840 VA: 0x180717240
	public bool IsRunning() { }

	// RVA: 0x7166E0 Offset: 0x714CE0 VA: 0x1807166E0
	public bool IsDucked() { }

	// RVA: 0x725540 Offset: 0x723B40 VA: 0x180725540
	public bool RecentlyTeleported() { }

	// RVA: 0x728410 Offset: 0x726A10 VA: 0x180728410
	public void ShowToast(int style, Translate.Phrase phrase) { }

	// RVA: 0x708DC0 Offset: 0x7073C0 VA: 0x180708DC0
	public void ChatMessage(string msg) { }

	// RVA: 0x70E550 Offset: 0x70CB50 VA: 0x18070E550
	public void ConsoleMessage(string msg) { }

	// RVA: 0x723120 Offset: 0x721720 VA: 0x180723120 Slot: 114
	public override float PenetrationResistance(HitInfo info) { }

	// RVA: 0x726630 Offset: 0x724C30 VA: 0x180726630 Slot: 142
	public override void ScaleDamage(HitInfo info) { }

	// RVA: 0x72A480 Offset: 0x728A80 VA: 0x18072A480
	private void UpdateMoveSpeedFromClothing() { }

	// RVA: 0x72AA30 Offset: 0x729030 VA: 0x18072AA30 Slot: 152
	public virtual void UpdateProtectionFromClothing() { }

	// RVA: 0x708D90 Offset: 0x707390 VA: 0x180708D90 Slot: 122
	public override string Categorize() { }

	// RVA: 0x728A60 Offset: 0x727060 VA: 0x180728A60 Slot: 3
	public override string ToString() { }

	// RVA: 0x7113A0 Offset: 0x70F9A0 VA: 0x1807113A0
	public string GetDebugStatus() { }

	// RVA: 0x7120E0 Offset: 0x7106E0 VA: 0x1807120E0 Slot: 118
	public override Item GetItem(uint itemId) { }

	// RVA: 0x72D210 Offset: 0x72B810 VA: 0x18072D210 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x72C0E0 Offset: 0x72A6E0 VA: 0x18072C0E0 Slot: 107
	public override float WaterFactor() { }

	// RVA: 0x706000 Offset: 0x704600 VA: 0x180706000 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x713720 Offset: 0x711D20 VA: 0x180713720
	public float GetOxygenTime(out ItemModGiveOxygen.AirSupplyType airSupplyType) { }

	// RVA: 0x717310 Offset: 0x715910 VA: 0x180717310 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x7066F0 Offset: 0x704CF0 VA: 0x1807066F0
	public static bool AnyPlayersVisibleToEntity(Vector3 pos, float radius, BaseEntity source, Vector3 entityEyePos, bool ignorePlayersWithPriv = False) { }

	// RVA: 0x717320 Offset: 0x715920 VA: 0x180717320
	public bool IsStandingOnEntity(BaseEntity standingOn, int layerMask) { }

	// RVA: 0x727270 Offset: 0x725870 VA: 0x180727270
	public void SetActiveTelephone(PhoneController t) { }

	// RVA: 0x72CC00 Offset: 0x72B200 VA: 0x18072CC00
	public bool get_HasActiveTelephone() { }

	// RVA: 0x72D0F0 Offset: 0x72B6F0 VA: 0x18072D0F0
	public bool get_IsDesigningAI() { }

	// RVA: 0x7096D0 Offset: 0x707CD0 VA: 0x1807096D0
	public void ClearDesigningAIEntity() { }

	// RVA: 0x72C980 Offset: 0x72AF80 VA: 0x18072C980
	public void .ctor() { }

	// RVA: 0x72C830 Offset: 0x72AE30 VA: 0x18072C830
	private static void .cctor() { }

}

public enum BasePlayer.CameraMode // TypeDefIndex: 8337
{	// Fields
	public int value__; // 0x0
	public const BasePlayer.CameraMode FirstPerson = 0;
	public const BasePlayer.CameraMode ThirdPerson = 1;
	public const BasePlayer.CameraMode Eyes = 2;
	public const BasePlayer.CameraMode FirstPersonWithArms = 3;
	public const BasePlayer.CameraMode DeathCamClassic = 4;
	public const BasePlayer.CameraMode Last = 3;

}

public enum BasePlayer.PlayerFlags // TypeDefIndex: 8338
{	// Fields
	public int value__; // 0x0
	public const BasePlayer.PlayerFlags Unused1 = 1;
	public const BasePlayer.PlayerFlags Unused2 = 2;
	public const BasePlayer.PlayerFlags IsAdmin = 4;
	public const BasePlayer.PlayerFlags ReceivingSnapshot = 8;
	public const BasePlayer.PlayerFlags Sleeping = 16;
	public const BasePlayer.PlayerFlags Spectating = 32;
	public const BasePlayer.PlayerFlags Wounded = 64;
	public const BasePlayer.PlayerFlags IsDeveloper = 128;
	public const BasePlayer.PlayerFlags Connected = 256;
	public const BasePlayer.PlayerFlags ThirdPersonViewmode = 1024;
	public const BasePlayer.PlayerFlags EyesViewmode = 2048;
	public const BasePlayer.PlayerFlags ChatMute = 4096;
	public const BasePlayer.PlayerFlags NoSprint = 8192;
	public const BasePlayer.PlayerFlags Aiming = 16384;
	public const BasePlayer.PlayerFlags DisplaySash = 32768;
	public const BasePlayer.PlayerFlags Relaxed = 65536;
	public const BasePlayer.PlayerFlags SafeZone = 131072;
	public const BasePlayer.PlayerFlags ServerFall = 262144;
	public const BasePlayer.PlayerFlags Incapacitated = 524288;
	public const BasePlayer.PlayerFlags Workbench1 = 1048576;
	public const BasePlayer.PlayerFlags Workbench2 = 2097152;
	public const BasePlayer.PlayerFlags Workbench3 = 4194304;

}

public enum BasePlayer.MapNoteType // TypeDefIndex: 8339
{	// Fields
	public int value__; // 0x0
	public const BasePlayer.MapNoteType Death = 0;
	public const BasePlayer.MapNoteType PointOfInterest = 1;

}

public enum BasePlayer.TimeCategory // TypeDefIndex: 8340
{	// Fields
	public int value__; // 0x0
	public const BasePlayer.TimeCategory Wilderness = 1;
	public const BasePlayer.TimeCategory Monument = 2;
	public const BasePlayer.TimeCategory Base = 4;
	public const BasePlayer.TimeCategory Flying = 8;
	public const BasePlayer.TimeCategory Boating = 16;
	public const BasePlayer.TimeCategory Swimming = 32;
	public const BasePlayer.TimeCategory Driving = 64;

}

public struct BasePlayer.CapsuleColliderInfo // TypeDefIndex: 8341
{	// Fields
	public float height; // 0x0
	public float radius; // 0x4
	public Vector3 center; // 0x8

	// Methods

	// RVA: 0xFA1A0 Offset: 0xF95A0 VA: 0x1800FA1A0
	public void .ctor(float height, float radius, Vector3 center) { }

}

private sealed class BasePlayer.<>c // TypeDefIndex: 8342
{	// Fields
	public static readonly BasePlayer.<>c <>9; // 0x0
	public static Func<PlayerTeam.TeamMember, ulong> <>9__103_0; // 0x8
	public static Comparison<TraceInfo> <>9__148_0; // 0x10
	public static Predicate<RespawnInformation.SpawnOptions> <>9__155_0; // 0x18

	// Methods

	// RVA: 0x93B380 Offset: 0x939980 VA: 0x18093B380
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B100 Offset: 0x939700 VA: 0x18093B100
	internal ulong <OnBecameRagdoll>b__103_0(PlayerTeam.TeamMember m) { }

	// RVA: 0x93B1D0 Offset: 0x9397D0 VA: 0x18093B1D0
	internal int <UpdateLookingAt>b__148_0(TraceInfo a, TraceInfo b) { }

	// RVA: 0x93B120 Offset: 0x939720 VA: 0x18093B120
	internal bool <OnRespawnInformation>b__155_0(RespawnInformation.SpawnOptions p) { }

}

private sealed class BasePlayer.<FinishedLoadingRoutine>d__161 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8343
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BasePlayer <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x93A840 Offset: 0x938E40 VA: 0x18093A840 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93ADA0 Offset: 0x9393A0 VA: 0x18093ADA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class BasePlayer.<>c__DisplayClass210_0 // TypeDefIndex: 8344
{	// Fields
	public GestureConfig g; // 0x10
	public BasePlayer <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B1F0 Offset: 0x9397F0 VA: 0x18093B1F0
	internal void <SetGestureMenuOpen>b__0(BasePlayer ply) { }

}

private sealed class BasePlayer.<>c__DisplayClass304_0 // TypeDefIndex: 8345
{	// Fields
	public uint index; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B220 Offset: 0x939820 VA: 0x18093B220
	internal bool <CLIENT_SetPetPetLoadedStateIndex>b__0(PetCommandList.PetCommandDesc c) { }

}

private sealed class BasePlayer.<>c__DisplayClass306_0 // TypeDefIndex: 8346
{	// Fields
	public PetCommandList.PetCommandDesc desc; // 0x10
	public BasePlayer <>4__this; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B240 Offset: 0x939840 VA: 0x18093B240
	internal void <SetPetMenuOpen>b__0(BasePlayer ply) { }

}

public class PlayerInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8620
{	// Fields
	public ItemContainer containerMain; // 0x20
	public ItemContainer containerBelt; // 0x28
	public ItemContainer containerWear; // 0x30
	public ItemCrafter crafting; // 0x38
	public PlayerLoot loot; // 0x40

	// Methods

	// RVA: 0xC36710 Offset: 0xC34D10 VA: 0x180C36710 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC36360 Offset: 0xC34960 VA: 0x180C36360
	protected void Initialize() { }

	// RVA: 0xC35B40 Offset: 0xC34140 VA: 0x180C35B40
	public void DoDestroy() { }

	// RVA: 0xC35AC0 Offset: 0xC340C0 VA: 0x180C35AC0
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC36B60 Offset: 0xC35160 VA: 0x180C36B60
	private void UpdatedItemContainer(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC36180 Offset: 0xC34780 VA: 0x180C36180
	public Item FindItemUID(uint id) { }

	// RVA: 0xC35EA0 Offset: 0xC344A0 VA: 0x180C35EA0
	public Item FindItemID(string itemName) { }

	// RVA: 0xC35FC0 Offset: 0xC345C0 VA: 0x180C35FC0
	public Item FindItemID(int id) { }

	// RVA: 0xC35C20 Offset: 0xC34220 VA: 0x180C35C20
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xC36090 Offset: 0xC34690 VA: 0x180C36090
	public List<Item> FindItemIDs(int id) { }

	// RVA: 0xC35CF0 Offset: 0xC342F0 VA: 0x180C35CF0
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC362E0 Offset: 0xC348E0 VA: 0x180C362E0
	public ItemContainer GetContainer(PlayerInventory.Type id) { }

	// RVA: 0xC365C0 Offset: 0xC34BC0 VA: 0x180C365C0
	public void Load(PlayerInventory msg) { }

	// RVA: 0xC36260 Offset: 0xC34860 VA: 0x180C36260
	public int GetAmount(int itemid) { }

	// RVA: 0xC359F0 Offset: 0xC33FF0 VA: 0x180C359F0
	public Item[] AllItems() { }

	// RVA: 0xC35920 Offset: 0xC33F20 VA: 0x180C35920
	public int AllItemsNoAlloc(ref List<Item> items) { }

	// RVA: 0xC35BD0 Offset: 0xC341D0 VA: 0x180C35BD0
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xC36300 Offset: 0xC34900 VA: 0x180C36300
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xC36D50 Offset: 0xC35350 VA: 0x180C36D50
	public void .ctor() { }

}

public enum PlayerInventory.Type // TypeDefIndex: 8621
{	// Fields
	public int value__; // 0x0
	public const PlayerInventory.Type Main = 0;
	public const PlayerInventory.Type Belt = 1;
	public const PlayerInventory.Type Wear = 2;

}

public class PlayerLoot : EntityComponent<BasePlayer> // TypeDefIndex: 8622
{	// Fields
	public BaseEntity entitySource; // 0x20
	public Item itemSource; // 0x28
	public List<ItemContainer> containers; // 0x30
	private EntityRef clientEntity; // 0x38

	// Methods

	// RVA: 0xC371A0 Offset: 0xC357A0 VA: 0x180C371A0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC37160 Offset: 0xC35760 VA: 0x180C37160
	public bool IsLooting() { }

	// RVA: 0xC36D90 Offset: 0xC35390 VA: 0x180C36D90
	public void Clear() { }

	// RVA: 0xC36E20 Offset: 0xC35420 VA: 0x180C36E20
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC36FB0 Offset: 0xC355B0 VA: 0x180C36FB0
	public Item FindItem(uint id) { }

	// RVA: 0xC37150 Offset: 0xC35750 VA: 0x180C37150
	public BaseEntity GetClientEntity() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC375F0 Offset: 0xC35BF0 VA: 0x180C375F0
	private void UpdateLoot(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xC37880 Offset: 0xC35E80 VA: 0x180C37880
	public void .ctor() { }

}

public class PlayerMetabolism : BaseMetabolism<BasePlayer> // TypeDefIndex: 8623
{	// Fields
	public const float HotThreshold = 40;
	public const float ColdThreshold = 5;
	public const float OxygenHurtThreshold = 0,5;
	public const float OxygenDepleteTime = 10;
	public const float OxygenRefillTime = 1;
	public MetabolismAttribute temperature; // 0x40
	public MetabolismAttribute poison; // 0x48
	public MetabolismAttribute radiation_level; // 0x50
	public MetabolismAttribute radiation_poison; // 0x58
	public MetabolismAttribute wetness; // 0x60
	public MetabolismAttribute dirtyness; // 0x68
	public MetabolismAttribute oxygen; // 0x70
	public MetabolismAttribute bleeding; // 0x78
	public MetabolismAttribute comfort; // 0x80
	public MetabolismAttribute pending_health; // 0x88
	public bool isDirty; // 0x90
	private float lastConsumeTime; // 0x94
	private float lastUpdateTime; // 0x98

	// Methods

	// RVA: 0xC37F00 Offset: 0xC36500 VA: 0x180C37F00 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC38350 Offset: 0xC36950 VA: 0x180C38350 Slot: 10
	public override void Reset() { }

	// RVA: 0xC378F0 Offset: 0xC35EF0 VA: 0x180C378F0
	public bool CanConsume() { }

	// RVA: 0xC37CC0 Offset: 0xC362C0 VA: 0x180C37CC0
	public void MarkConsumption() { }

	// RVA: 0xC379A0 Offset: 0xC35FA0 VA: 0x180C379A0
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC38610 Offset: 0xC36C10 VA: 0x180C38610
	public void UpdateMetabolism(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC38460 Offset: 0xC36A60 VA: 0x180C38460
	public PlayerMetabolism Save() { }

	// RVA: 0xC37AA0 Offset: 0xC360A0 VA: 0x180C37AA0
	public void Load(PlayerMetabolism s) { }

	// RVA: 0xC379F0 Offset: 0xC35FF0 VA: 0x180C379F0 Slot: 12
	public override MetabolismAttribute FindAttribute(MetabolismAttribute.Type type) { }

	// RVA: 0xC37CE0 Offset: 0xC362E0 VA: 0x180C37CE0
	public void OnLocalMetabolismUpdated() { }

	// RVA: 0xC386F0 Offset: 0xC36CF0 VA: 0x180C386F0
	public void .ctor() { }

}

public class PlayerModifiers : BaseModifiers<BasePlayer> // TypeDefIndex: 8624
{	// Methods

	// RVA: 0x98D640 Offset: 0x98BC40 VA: 0x18098D640 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x98D290 Offset: 0x98B890 VA: 0x18098D290
	public void Load(PlayerModifiers m) { }

	// RVA: 0x98D230 Offset: 0x98B830 VA: 0x18098D230
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x98DA90 Offset: 0x98C090 VA: 0x18098DA90
	public void UpdateModifiers(BaseEntity.RPCMessage packet) { }

	// RVA: 0x98DB70 Offset: 0x98C170 VA: 0x18098DB70
	public void .ctor() { }

}

public class PlayerDetectionTrigger : TriggerBase // TypeDefIndex: 8703
{	// Fields
	public BaseDetector myDetector; // 0x30

	// Methods

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

public class PlayerModelHair : MonoBehaviour // TypeDefIndex: 9214
{	// Fields
	public HairType type; // 0x18
	private Dictionary<Renderer, PlayerModelHair.RendererMaterials> materials; // 0x20

	// Properties
	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> Materials { get; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> get_Materials() { }

	// RVA: 0xC389C0 Offset: 0xC36FC0 VA: 0x180C389C0
	private void CacheOriginalMaterials() { }

	// RVA: 0xC39160 Offset: 0xC37760 VA: 0x180C39160
	private void Setup(HairType type, HairSetCollection hair, int meshIndex, float typeNum, float dyeNum, MaterialPropertyBlock block) { }

	// RVA: 0xC38DC0 Offset: 0xC373C0 VA: 0x180C38DC0
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0xC38CA0 Offset: 0xC372A0 VA: 0x180C38CA0
	public static void GetRandomVariation(float hairNum, int typeIndex, int meshIndex, out float typeNum, out float dyeNum) { }

	// RVA: 0xC38C10 Offset: 0xC37210 VA: 0x180C38C10
	public static float GetRandomHairType(float hairNum, int typeIndex) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public struct PlayerModelHair.RendererMaterials // TypeDefIndex: 9215
{	// Fields
	public string[] names; // 0x0
	public Material[] original; // 0x8
	public Material[] replacement; // 0x10

	// Methods

	// RVA: 0xFAD90 Offset: 0xFA190 VA: 0x1800FAD90
	public void .ctor(Renderer r) { }

}

public class PlayerModelHairCap : MonoBehaviour // TypeDefIndex: 9217
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public HairCapMask hairCapMask; // 0x18

	// Methods

	// RVA: 0x98CD20 Offset: 0x98B320 VA: 0x18098CD20
	public void SetupHairCap(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class PlayerModelSkin : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9218
{	// Fields
	public PlayerModelSkin.SkinMaterialType MaterialType; // 0x18
	public Renderer SkinRenderer; // 0x20

	// Methods

	// RVA: 0x98D0F0 Offset: 0x98B6F0 VA: 0x18098D0F0
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum) { }

	// RVA: 0x98D090 Offset: 0x98B690 VA: 0x18098D090 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum PlayerModelSkin.SkinMaterialType // TypeDefIndex: 9219
{	// Fields
	public int value__; // 0x0
	public const PlayerModelSkin.SkinMaterialType HEAD = 0;
	public const PlayerModelSkin.SkinMaterialType EYE = 1;
	public const PlayerModelSkin.SkinMaterialType BODY = 2;

}

public class PlayerDetectedAIEvent : BaseAIEvent // TypeDefIndex: 9408
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Range>k__BackingField; // 0x40

	// Properties
	public float Range { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_Range() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	public void set_Range(float value) { }

	// RVA: 0xC2CF90 Offset: 0xC2B590 VA: 0x180C2CF90
	public void .ctor() { }

}

public class PlayerAnimationEvents : MonoBehaviour // TypeDefIndex: 9645
{	// Fields
	private BasePlayer player; // 0x18

	// Methods

	// RVA: 0x91E490 Offset: 0x91CA90 VA: 0x18091E490
	protected void OnEnable() { }

	// RVA: 0x91EBF0 Offset: 0x91D1F0 VA: 0x18091EBF0
	public void ThirdPersonReloadSound(AnimationEvent animEvent) { }

	// RVA: 0x91EAA0 Offset: 0x91D0A0 VA: 0x18091EAA0
	public void ThirdPersonMeleeAttackSound(AnimationEvent animEvent) { }

	// RVA: 0x91E830 Offset: 0x91CE30 VA: 0x18091E830
	public void ThirdPersonDeploySound(AnimationEvent animEvent) { }

	// RVA: 0x91E950 Offset: 0x91CF50 VA: 0x18091E950
	public void ThirdPersonLiquidThrowSound(AnimationEvent animEvent) { }

	// RVA: 0x91E530 Offset: 0x91CB30 VA: 0x18091E530
	public void PlayThirdPersonSound(SoundDefinition def) { }

	// RVA: 0x91E5E0 Offset: 0x91CBE0 VA: 0x18091E5E0
	public bool ShouldPlayThirdPersonSounds() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void SleepingEvent(AnimationEvent animEvent) { }

	// RVA: 0x91E6E0 Offset: 0x91CCE0 VA: 0x18091E6E0
	public void SplashEvent(string splashType) { }

	// RVA: 0x91EEB0 Offset: 0x91D4B0 VA: 0x18091EEB0
	public void WaterInflatableMovementSound(string type) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class PlayerBelt // TypeDefIndex: 9646
{	// Fields
	public static int SelectedSlot; // 0x0
	protected BasePlayer player; // 0x10

	// Properties
	public static int MaxBeltSlots { get; }

	// Methods

	// RVA: 0x91FBF0 Offset: 0x91E1F0 VA: 0x18091FBF0
	public static int get_MaxBeltSlots() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(BasePlayer player) { }

	// RVA: 0x91FAC0 Offset: 0x91E0C0 VA: 0x18091FAC0
	public Item GetItemInSlot(int slot) { }

	// RVA: 0x91FA20 Offset: 0x91E020 VA: 0x18091FA20
	public Item GetActiveItem() { }

	// RVA: 0x91EFC0 Offset: 0x91D5C0 VA: 0x18091EFC0
	public bool CanHoldItem() { }

	// RVA: 0x91F960 Offset: 0x91DF60 VA: 0x18091F960
	public void FrameUpdate() { }

	// RVA: 0x91F0B0 Offset: 0x91D6B0 VA: 0x18091F0B0
	public void ChangeSelect(int iSlot, bool allowRunAction = False) { }

	// RVA: 0x91F830 Offset: 0x91DE30 VA: 0x18091F830
	public void DoNextItemDirection(InputState state, int direction) { }

	// RVA: 0x91F360 Offset: 0x91D960 VA: 0x18091F360
	public void ClientInput(InputState state) { }

	// RVA: 0x91FBB0 Offset: 0x91E1B0 VA: 0x18091FBB0
	private static void .cctor() { }

}

public class PlayerBlueprints : EntityComponent<BasePlayer> // TypeDefIndex: 9647
{	// Fields
	public SteamInventory steamInventory; // 0x20
	private int[] craftableItems; // 0x28

	// Methods

	// RVA: 0x91FEF0 Offset: 0x91E4F0 VA: 0x18091FEF0
	public void ClientInit() { }

	// RVA: 0x91FFA0 Offset: 0x91E5A0 VA: 0x18091FFA0
	public void ClientUpdate(PersistantPlayer info) { }

	// RVA: 0x920060 Offset: 0x91E660 VA: 0x180920060
	public bool HasUnlocked(ItemDefinition targetItem) { }

	// RVA: 0x91FC00 Offset: 0x91E200 VA: 0x18091FC00
	public bool CanCraft(int itemid, int skinItemId, ulong playerId) { }

	// RVA: 0x91FDF0 Offset: 0x91E3F0 VA: 0x18091FDF0
	public bool CheckSkinOwnership(int skinItemId, ulong playerId) { }

	// RVA: 0x920450 Offset: 0x91EA50 VA: 0x180920450
	public void .ctor() { }

}

public class PlayerEyes : EntityComponent<BasePlayer> // TypeDefIndex: 9648
{	// Fields
	public static readonly Vector3 EyeOffset; // 0x0
	public static readonly Vector3 DuckOffset; // 0xC
	public static readonly Vector3 CrawlOffset; // 0x18
	public Vector3 thirdPersonSleepingOffset; // 0x20
	public LazyAimProperties defaultLazyAim; // 0x30
	private Vector3 viewOffset; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Quaternion <bodyRotation>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <headAngles>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Quaternion <rotationLook>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsAltLookingLegsThreshold>k__BackingField; // 0x70

	// Properties
	public Vector3 worldMountedPosition { get; }
	public Vector3 worldStandingPosition { get; }
	public Vector3 worldCrouchedPosition { get; }
	public Vector3 worldCrawlingPosition { get; }
	public Vector3 position { get; }
	private Vector3 BodyLeanOffset { get; }
	public Vector3 center { get; }
	public Vector3 offset { get; }
	public Quaternion rotation { get; set; }
	public Quaternion bodyRotation { get; set; }
	public Vector3 headAngles { get; set; }
	public Quaternion rotationLook { get; set; }
	public Quaternion parentRotation { get; }
	public bool canUpdateViewAngles { get; }
	public bool IsAltLookingLegsThreshold { get; set; }

	// Methods

	// RVA: 0xC32100 Offset: 0xC30700 VA: 0x180C32100
	public Vector3 get_worldMountedPosition() { }

	// RVA: 0xC322F0 Offset: 0xC308F0 VA: 0x180C322F0
	public Vector3 get_worldStandingPosition() { }

	// RVA: 0xC32000 Offset: 0xC30600 VA: 0x180C32000
	public Vector3 get_worldCrouchedPosition() { }

	// RVA: 0xC31F00 Offset: 0xC30500 VA: 0x180C31F00
	public Vector3 get_worldCrawlingPosition() { }

	// RVA: 0xC319C0 Offset: 0xC2FFC0 VA: 0x180C319C0
	public Vector3 get_position() { }

	// RVA: 0xC31080 Offset: 0xC2F680 VA: 0x180C31080
	private Vector3 get_BodyLeanOffset() { }

	// RVA: 0xC313E0 Offset: 0xC2F9E0 VA: 0x180C313E0
	public Vector3 get_center() { }

	// RVA: 0xC31700 Offset: 0xC2FD00 VA: 0x180C31700
	public Vector3 get_offset() { }

	// RVA: 0xC31E50 Offset: 0xC30450 VA: 0x180C31E50
	public Quaternion get_rotation() { }

	// RVA: 0xC32450 Offset: 0xC30A50 VA: 0x180C32450
	public void set_rotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC31300 Offset: 0xC2F900 VA: 0x180C31300
	public Quaternion get_bodyRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32420 Offset: 0xC30A20 VA: 0x180C32420
	public void set_bodyRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC316E0 Offset: 0xC2FCE0 VA: 0x180C316E0
	public Vector3 get_headAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32430 Offset: 0xC30A30 VA: 0x180C32430
	public void set_headAngles(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC31E40 Offset: 0xC30440 VA: 0x180C31E40
	public Quaternion get_rotationLook() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32440 Offset: 0xC30A40 VA: 0x180C32440
	public void set_rotationLook(Quaternion value) { }

	// RVA: 0xC31830 Offset: 0xC2FE30 VA: 0x180C31830
	public Quaternion get_parentRotation() { }

	// RVA: 0xC31310 Offset: 0xC2F910 VA: 0x180C31310
	public bool get_canUpdateViewAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC312F0 Offset: 0xC2F8F0 VA: 0x180C312F0
	public bool get_IsAltLookingLegsThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32410 Offset: 0xC30A10 VA: 0x180C32410
	private void set_IsAltLookingLegsThreshold(bool value) { }

	// RVA: 0xC2FC10 Offset: 0xC2E210 VA: 0x180C2FC10
	public void FrameUpdate(Camera cam) { }

	// RVA: 0xC30CA0 Offset: 0xC2F2A0 VA: 0x180C30CA0
	public void UpdateAltLegsThreshold(float yAngle) { }

	// RVA: 0xC30D10 Offset: 0xC2F310 VA: 0x180C30D10
	private void UpdateCamera(Camera cam) { }

	// RVA: 0xC2DCF0 Offset: 0xC2C2F0 VA: 0x180C2DCF0
	private void DoFirstPersonCamera(Camera cam) { }

	// RVA: 0xC2E340 Offset: 0xC2C940 VA: 0x180C2E340
	private void DoInEyeCamera(Camera cam) { }

	// RVA: 0xC2E690 Offset: 0xC2CC90 VA: 0x180C2E690
	private void DoThirdPersonCamera(Camera cam) { }

	// RVA: 0xC2D710 Offset: 0xC2BD10 VA: 0x180C2D710
	private void DoDeathCamera(Camera cam) { }

	// RVA: 0xC2D0E0 Offset: 0xC2B6E0 VA: 0x180C2D0E0
	private void ApplyCameraMoves(Camera cam) { }

	// RVA: 0xC30920 Offset: 0xC2EF20 VA: 0x180C30920
	public Vector3 MovementForward() { }

	// RVA: 0xC30AE0 Offset: 0xC2F0E0 VA: 0x180C30AE0
	public Vector3 MovementRight() { }

	// RVA: 0xC2D2C0 Offset: 0xC2B8C0 VA: 0x180C2D2C0
	public Ray BodyRay() { }

	// RVA: 0xC2D170 Offset: 0xC2B770 VA: 0x180C2D170
	public Vector3 BodyForward() { }

	// RVA: 0xC2D470 Offset: 0xC2BA70 VA: 0x180C2D470
	public Vector3 BodyRight() { }

	// RVA: 0xC2D5C0 Offset: 0xC2BBC0 VA: 0x180C2D5C0
	public Vector3 BodyUp() { }

	// RVA: 0xC30560 Offset: 0xC2EB60 VA: 0x180C30560
	public Ray HeadRay() { }

	// RVA: 0xC30470 Offset: 0xC2EA70 VA: 0x180C30470
	public Vector3 HeadForward() { }

	// RVA: 0xC30740 Offset: 0xC2ED40 VA: 0x180C30740
	public Vector3 HeadRight() { }

	// RVA: 0xC30830 Offset: 0xC2EE30 VA: 0x180C30830
	public Vector3 HeadUp() { }

	// RVA: 0xC302F0 Offset: 0xC2E8F0 VA: 0x180C302F0
	public Quaternion GetLookRotation() { }

	// RVA: 0xC30230 Offset: 0xC2E830 VA: 0x180C30230
	public Quaternion GetAimRotation() { }

	// RVA: 0xC30FC0 Offset: 0xC2F5C0 VA: 0x180C30FC0
	public void .ctor() { }

	// RVA: 0xC30EC0 Offset: 0xC2F4C0 VA: 0x180C30EC0
	private static void .cctor() { }

}

public class PlayerInput : EntityComponent<BasePlayer> // TypeDefIndex: 9649
{	// Fields
	public InputState state; // 0x20
	public bool hadInputBuffer; // 0x28
	private Quaternion bodyRotation; // 0x2C
	private Vector3 bodyAngles; // 0x3C
	private Quaternion headRotation; // 0x48
	private Vector3 headAngles; // 0x58
	public Vector3 recoilAngles; // 0x64
	public Vector2 viewDelta; // 0x70
	private float headLerp; // 0x78
	private int mouseWheelUp; // 0x7C
	private int mouseWheelDn; // 0x80
	private bool autorun; // 0x84
	private bool toggleDuck; // 0x85
	private bool toggleAds; // 0x86
	private uint lastAdsEntity; // 0x88
	private Vector3 pendingMouseDelta; // 0x8C
	public Vector3 offsetAngles; // 0x98
	private int ignoredButtons; // 0xA4
	private bool hasKeyFocus; // 0xA8

	// Properties
	private bool hasOnlyPartialKeyInput { get; }
	public static bool hasNoKeyInput { get; }

	// Methods

	// RVA: 0xC35320 Offset: 0xC33920 VA: 0x180C35320
	protected void OnDisable() { }

	// RVA: 0xC344D0 Offset: 0xC32AD0 VA: 0x180C344D0
	public void FrameUpdate() { }

	// RVA: 0xC33EF0 Offset: 0xC324F0 VA: 0x180C33EF0
	private bool CanToggleAds() { }

	// RVA: 0xC34360 Offset: 0xC32960 VA: 0x180C34360
	private void Flip() { }

	// RVA: 0xC353A0 Offset: 0xC339A0 VA: 0x180C353A0
	public void ResetMouseDelta() { }

	// RVA: 0xC32750 Offset: 0xC30D50 VA: 0x180C32750
	private void AddMouseDelta() { }

	// RVA: 0xC32A20 Offset: 0xC31020 VA: 0x180C32A20
	private void AdjustMouseMovement(ref Vector2 mm) { }

	// RVA: 0xC355A0 Offset: 0xC33BA0 VA: 0x180C355A0
	private void UpdateViewAngles() { }

	// RVA: 0xC32C60 Offset: 0xC31260 VA: 0x180C32C60
	public void ApplyViewAngles() { }

	// RVA: 0xC35480 Offset: 0xC33A80 VA: 0x180C35480
	public void SetViewVars(Vector3 newAngles) { }

	// RVA: 0xC34180 Offset: 0xC32780 VA: 0x180C34180
	public void FinalizeRecoil() { }

	// RVA: 0xC35410 Offset: 0xC33A10 VA: 0x180C35410
	public void ResetOffsetAngles() { }

	// RVA: 0xC34150 Offset: 0xC32750 VA: 0x180C34150
	public Quaternion ClientAngles() { }

	// RVA: 0xC34160 Offset: 0xC32760 VA: 0x180C34160
	public Vector3 ClientLookVars() { }

	// RVA: 0xC23AF0 Offset: 0xC220F0 VA: 0x180C23AF0
	public Quaternion HeadAngles() { }

	// RVA: 0xC34920 Offset: 0xC32F20 VA: 0x180C34920
	public Vector3 HeadLookVars() { }

	// RVA: 0xC35290 Offset: 0xC33890 VA: 0x180C35290
	private void ModifyInputState(InputMessage state) { }

	// RVA: 0xC34D90 Offset: 0xC33390 VA: 0x180C34D90
	internal bool IsButtonDownNative(BUTTON btn) { }

	// RVA: 0xC33800 Offset: 0xC31E00 VA: 0x180C33800
	private InputMessage BuildInputState(bool allowModify = True) { }

	// RVA: 0xC34C40 Offset: 0xC33240 VA: 0x180C34C40
	private bool IsAiming() { }

	// RVA: 0xC35510 Offset: 0xC33B10 VA: 0x180C35510
	private void UpdateButton(InputMessage state, BUTTON btn) { }

	// RVA: 0xC34940 Offset: 0xC32F40 VA: 0x180C34940
	public void IgnoreCurrentButtons() { }

	// RVA: 0xC358B0 Offset: 0xC33EB0 VA: 0x180C358B0
	private bool get_hasOnlyPartialKeyInput() { }

	// RVA: 0xC35720 Offset: 0xC33D20 VA: 0x180C35720
	public static bool get_hasNoKeyInput() { }

	// RVA: 0xC35580 Offset: 0xC33B80 VA: 0x180C35580
	private void UpdateKeyFocus(bool hasFocus) { }

	// RVA: 0xC34A50 Offset: 0xC33050 VA: 0x180C34A50
	public static void IgnoreCurrentKeys() { }

	// RVA: 0xC356B0 Offset: 0xC33CB0 VA: 0x180C356B0
	public void .ctor() { }

}

public class PlayerModel : ListComponent<PlayerModel>, IOnParentDestroying // TypeDefIndex: 9650
{	// Fields
	public static float pm_uplimit; // 0x0
	public static float pm_downlimit; // 0x4
	public static float pm_upspine; // 0x8
	public static float pm_downspine; // 0xC
	public static Vector3 pm_lookoffset; // 0x10
	public static float pm_anglesmoothspeed; // 0x1C
	public static float pm_nohold; // 0x20
	public static float pm_ladder; // 0x24
	public static float pm_minweight; // 0x28
	private float _smoothAimWeight; // 0x18
	private float _smoothVelocity; // 0x1C
	private Vector3 _smoothlookAngle; // 0x20
	private bool allowMountedHeadLook; // 0x2C
	private Vector3 smoothLookDir; // 0x30
	private Vector3 lastSafeLookDir; // 0x3C
	public Transform[] Shoulders; // 0x48
	public Transform[] AdditionalSpineBones; // 0x50
	private static readonly HashSet<Wearable> FinishedLegWearables; // 0x30
	protected List<SkinnedMeshRenderer> LegParts; // 0x58
	private Transform[] fakeSpineBones; // 0x60
	private float extraLeanBack; // 0x68
	private Nullable<bool> drawState; // 0x6C
	private float timeInArmsMode; // 0x70
	protected static int speed; // 0x38
	protected static int acceleration; // 0x3C
	protected static int rotationYaw; // 0x40
	protected static int forward; // 0x44
	protected static int right; // 0x48
	protected static int up; // 0x4C
	protected static int ducked; // 0x50
	protected static int grounded; // 0x54
	protected static int crawling; // 0x58
	protected static int waterlevel; // 0x5C
	protected static int attack; // 0x60
	protected static int attack_alt; // 0x64
	protected static int deploy; // 0x68
	protected static int reload; // 0x6C
	protected static int throwWeapon; // 0x70
	protected static int holster; // 0x74
	protected static int aiming; // 0x78
	protected static int onLadder; // 0x7C
	protected static int posing; // 0x80
	protected static int poseType; // 0x84
	protected static int relaxGunPose; // 0x88
	protected static int vehicle_aim_yaw; // 0x8C
	protected static int vehicle_aim_speed; // 0x90
	protected static int onPhone; // 0x94
	protected static int usePoseTransition; // 0x98
	protected static int leftFootIK; // 0x9C
	protected static int rightFootIK; // 0xA0
	protected static int vehicleSteering; // 0xA4
	protected static int sitReaction; // 0xA8
	protected static int forwardReaction; // 0xAC
	protected static int rightReaction; // 0xB0
	public BoxCollider collision; // 0x78
	public GameObject censorshipCube; // 0x80
	public GameObject censorshipCubeBreasts; // 0x88
	public GameObject jawBone; // 0x90
	public GameObject neckBone; // 0x98
	public GameObject headBone; // 0xA0
	public EyeController eyeController; // 0xA8
	public EyeBlink blinkController; // 0xB0
	public Transform[] SpineBones; // 0xB8
	public Transform leftFootBone; // 0xC0
	public Transform rightFootBone; // 0xC8
	public Transform leftHandPropBone; // 0xD0
	public Transform rightHandPropBone; // 0xD8
	public Vector3 rightHandTarget; // 0xE0
	[HeaderAttribute] // RVA: 0x7F560 Offset: 0x7E960 VA: 0x18007F560
	public Vector3 leftHandTargetPosition; // 0xEC
	public Quaternion leftHandTargetRotation; // 0xF8
	public Vector3 rightHandTargetPosition; // 0x108
	public Quaternion rightHandTargetRotation; // 0x114
	public float steeringTargetDegrees; // 0x124
	public Vector3 rightFootTargetPosition; // 0x128
	public Quaternion rightFootTargetRotation; // 0x134
	public Vector3 leftFootTargetPosition; // 0x144
	public Quaternion leftFootTargetRotation; // 0x150
	public RuntimeAnimatorController CinematicAnimationController; // 0x160
	public Avatar DefaultAvatar; // 0x168
	public Avatar CinematicAvatar; // 0x170
	public RuntimeAnimatorController DefaultHoldType; // 0x178
	public RuntimeAnimatorController SleepGesture; // 0x180
	public RuntimeAnimatorController CrawlToIncapacitatedGesture; // 0x188
	public RuntimeAnimatorController StandToIncapacitatedGesture; // 0x190
	public RuntimeAnimatorController CurrentGesture; // 0x198
	[HeaderAttribute] // RVA: 0x7F5E0 Offset: 0x7E9E0 VA: 0x18007F5E0
	public SkinSetCollection MaleSkin; // 0x1A0
	public SkinSetCollection FemaleSkin; // 0x1A8
	public SubsurfaceProfile subsurfaceProfile; // 0x1B0
	[HeaderAttribute] // RVA: 0x7F7C0 Offset: 0x7EBC0 VA: 0x18007F7C0
	[RangeAttribute] // RVA: 0x7F7C0 Offset: 0x7EBC0 VA: 0x18007F7C0
	public float voiceVolume; // 0x1B8
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float skinColor; // 0x1BC
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float skinNumber; // 0x1C0
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float meshNumber; // 0x1C4
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float hairNumber; // 0x1C8
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public int skinType; // 0x1CC
	public MovementSounds movementSounds; // 0x1D0
	public bool showSash; // 0x1D8
	public int tempPoseType; // 0x1DC
	public uint underwearSkin; // 0x1E0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <overrideSkinSeed>k__BackingField; // 0x1E8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Quaternion <AimAngles>k__BackingField; // 0x1F0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Quaternion <LookAngles>k__BackingField; // 0x200
	private const int LayerHands = 1;
	private const int LayerGestures = 2;
	private const int LayerPlayerGesturesUpperBody = 3;
	private const int LayerPlayerGesturesFullBody = 4;
	private const int LayerReactions = 5;
	private ModelState modelState; // 0x210
	internal Vector3 position; // 0x218
	internal Vector3 velocity; // 0x224
	internal Vector3 speedOverride; // 0x230
	private Vector3 newVelocity; // 0x23C
	internal Quaternion rotation; // 0x248
	internal Quaternion mountedRotation; // 0x258
	internal Vector3 smoothLeftFootIK; // 0x268
	internal Vector3 smoothRightFootIK; // 0x274
	internal bool drawShadowOnly; // 0x280
	internal bool isIncapacitated; // 0x281
	internal uint flinchLocation; // 0x284
	internal bool visible; // 0x288
	internal PlayerNameTag nameTag; // 0x290
	private bool animatorNeedsWarmup; // 0x298
	internal bool isLocalPlayer; // 0x299
	private SoundDefinition aimSoundDef; // 0x2A0
	private SoundDefinition aimEndSoundDef; // 0x2A8
	private bool InGesture; // 0x2B0
	private GestureConfig CurrentGestureConfig; // 0x2B8
	private bool InCinematic; // 0x2C0
	private RuntimeAnimatorController defaultAnimatorController; // 0x2C8
	private SkinnedMultiMesh _multiMesh; // 0x2D0
	private Animator _animator; // 0x2D8
	private LODGroup _lodGroup; // 0x2E0
	private RuntimeAnimatorController _currentGesture; // 0x2E8
	private float holdTypeLock; // 0x2F0
	private bool hasHeldEntity; // 0x2F4
	private bool wasMountedRightAim; // 0x2F5
	private int cachedMask; // 0x2F8
	private int cachedConstructionMask; // 0x2FC
	private HeldEntity WorkshopHeldEntity; // 0x300
	private bool wasCrawling; // 0x308
	private float mountedSpineLookWeight; // 0x30C
	private float mountedAnimSpeed; // 0x310
	private bool preserveBones; // 0x314
	private Nullable<float> downLimitOverride; // 0x318
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsNpc>k__BackingField; // 0x320
	private TimeSince timeSinceReactionStart; // 0x324
	private TimeSince timeSinceLeftFootTest; // 0x328
	private Vector3 cachedLeftFootPos; // 0x32C
	private Vector3 cachedLeftFootNormal; // 0x338
	private TimeSince timeSinceRightFootTest; // 0x344
	private Vector3 cachedRightFootPos; // 0x348
	private Vector3 cachedRightFootNormal; // 0x354

	// Properties
	public bool ShouldDoLegs { get; }
	public bool ShouldShowHands { get; }
	public ulong overrideSkinSeed { get; set; }
	public bool IsFemale { get; }
	public SkinSetCollection SkinSet { get; }
	public Quaternion AimAngles { get; set; }
	public Quaternion LookAngles { get; set; }
	private bool GestureAllowsSpineMovement { get; }
	private bool GestureAllowsRootMotion { get; }
	public bool IsFirstPerson { get; }
	public bool IsNpc { get; set; }
	public SkinnedMultiMesh multiMesh { get; }
	public Animator animator { get; }
	public LODGroup lodGroup { get; }

	// Methods

	// RVA: 0xC42A80 Offset: 0xC41080 VA: 0x180C42A80
	public void SetMountedLookAtOverride(bool state) { }

	// RVA: 0xC42EA0 Offset: 0xC414A0 VA: 0x180C42EA0
	private void SpineIk() { }

	// RVA: 0xC40C90 Offset: 0xC3F290 VA: 0x180C40C90
	private void ParentArmsToCamera() { }

	// RVA: 0xC40300 Offset: 0xC3E900 VA: 0x180C40300
	private void OnAnimatorIK() { }

	// RVA: 0xC3E960 Offset: 0xC3CF60 VA: 0x180C3E960
	private void HandIK(float cameraDistSq) { }

	// RVA: 0xC3B170 Offset: 0xC39770 VA: 0x180C3B170
	private void FootIK(float cameraDistSq) { }

	// RVA: 0xC3EDC0 Offset: 0xC3D3C0 VA: 0x180C3EDC0
	private void HeadIK(float cameraDistSq) { }

	// RVA: 0xC48790 Offset: 0xC46D90 VA: 0x180C48790
	public bool get_ShouldDoLegs() { }

	// RVA: 0xC48810 Offset: 0xC46E10 VA: 0x180C48810
	public bool get_ShouldShowHands() { }

	// RVA: 0xC39E10 Offset: 0xC38410 VA: 0x180C39E10
	private void ClearLegs() { }

	// RVA: 0xC41640 Offset: 0xC3FC40 VA: 0x180C41640
	public void RebuildLegs() { }

	// RVA: 0xC3F4A0 Offset: 0xC3DAA0 VA: 0x180C3F4A0
	private void InitializeLegSpineBones() { }

	// RVA: 0xC446B0 Offset: 0xC42CB0 VA: 0x180C446B0
	private void UpdateLegsBeforeRender() { }

	// RVA: 0xC455A0 Offset: 0xC43BA0 VA: 0x180C455A0
	private void UpdateLegsDisable(bool forceDisable = False) { }

	// RVA: 0xC39340 Offset: 0xC37940 VA: 0x180C39340
	private void AddLegRenderer(SkinnedMeshRenderer renderer, PaintableItem paintable) { }

	// RVA: 0xC43890 Offset: 0xC41E90 VA: 0x180C43890
	private Transform SwapLegBone(Transform bone) { }

	// RVA: 0xC3DDD0 Offset: 0xC3C3D0 VA: 0x180C3DDD0
	private static Vector3 GetFlat(Vector3 dir) { }

	// RVA: 0xC41240 Offset: 0xC3F840 VA: 0x180C41240
	public static void RebuildAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48AF0 Offset: 0xC470F0 VA: 0x180C48AF0
	public ulong get_overrideSkinSeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48B30 Offset: 0xC47130 VA: 0x180C48B30
	private void set_overrideSkinSeed(ulong value) { }

	// RVA: 0xC48740 Offset: 0xC46D40 VA: 0x180C48740
	public bool get_IsFemale() { }

	// RVA: 0xC488F0 Offset: 0xC46EF0 VA: 0x180C488F0
	public SkinSetCollection get_SkinSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC485F0 Offset: 0xC46BF0 VA: 0x180C485F0
	public Quaternion get_AimAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48B00 Offset: 0xC47100 VA: 0x180C48B00
	public void set_AimAngles(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48780 Offset: 0xC46D80 VA: 0x180C48780
	public Quaternion get_LookAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48B20 Offset: 0xC47120 VA: 0x180C48B20
	public void set_LookAngles(Quaternion value) { }

	// RVA: 0xC486A0 Offset: 0xC46CA0 VA: 0x180C486A0
	private bool get_GestureAllowsSpineMovement() { }

	// RVA: 0xC48600 Offset: 0xC46C00 VA: 0x180C48600
	private bool get_GestureAllowsRootMotion() { }

	// RVA: 0xC48750 Offset: 0xC46D50 VA: 0x180C48750
	public bool get_IsFirstPerson() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48770 Offset: 0xC46D70 VA: 0x180C48770
	public bool get_IsNpc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48B10 Offset: 0xC47110 VA: 0x180C48B10
	public void set_IsNpc(bool value) { }

	// RVA: 0xC48A50 Offset: 0xC47050 VA: 0x180C48A50
	public SkinnedMultiMesh get_multiMesh() { }

	// RVA: 0xC48910 Offset: 0xC46F10 VA: 0x180C48910
	public Animator get_animator() { }

	// RVA: 0xC489B0 Offset: 0xC46FB0 VA: 0x180C489B0
	public LODGroup get_lodGroup() { }

	// RVA: 0xC3E800 Offset: 0xC3CE00 VA: 0x180C3E800
	public Vector3 GetTargetVelocity() { }

	// RVA: 0xC39D70 Offset: 0xC38370 VA: 0x180C39D70
	protected void Awake() { }

	// RVA: 0xC40720 Offset: 0xC3ED20 VA: 0x180C40720 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC40430 Offset: 0xC3EA30 VA: 0x180C40430 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC42360 Offset: 0xC40960 VA: 0x180C42360
	private void SetDefaultAnimatorWeights() { }

	// RVA: 0xC45C40 Offset: 0xC44240 VA: 0x180C45C40
	private void UpdateMultiMesh(bool reset) { }

	// RVA: 0xC43DD0 Offset: 0xC423D0 VA: 0x180C43DD0
	private void UpdateCensorship() { }

	// RVA: 0xC44250 Offset: 0xC42850 VA: 0x180C44250
	public void UpdateCollider(bool visible, bool sleeping, bool ducking, bool crawling, bool incapacitated) { }

	// RVA: 0xC45BF0 Offset: 0xC441F0 VA: 0x180C45BF0
	public void UpdateModelState(ModelState ms) { }

	// RVA: 0xC466B0 Offset: 0xC44CB0 VA: 0x180C466B0
	public void UpdatePosition() { }

	// RVA: 0xC467D0 Offset: 0xC44DD0 VA: 0x180C467D0
	internal void UpdateRotation() { }

	// RVA: 0xC45B20 Offset: 0xC44120 VA: 0x180C45B20
	public void UpdateLocalVelocity(Vector3 velocity, Transform parent) { }

	// RVA: 0xC47150 Offset: 0xC45750 VA: 0x180C47150
	public void UpdateVelocity() { }

	// RVA: 0xC45DD0 Offset: 0xC443D0 VA: 0x180C45DD0
	private void UpdateParameters() { }

	// RVA: 0xC444C0 Offset: 0xC42AC0 VA: 0x180C444C0
	public void UpdateFrom(PlayerModel mdl) { }

	// RVA: 0xC44520 Offset: 0xC42B20 VA: 0x180C44520
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0xC3FC80 Offset: 0xC3E280 VA: 0x180C3FC80
	public void LateCycle() { }

	// RVA: 0xC3D3E0 Offset: 0xC3B9E0 VA: 0x180C3D3E0
	public void FrameUpdate() { }

	// RVA: 0xC3CA00 Offset: 0xC3B000 VA: 0x180C3CA00
	private void FrameUpdate_Default() { }

	// RVA: 0xC3D110 Offset: 0xC3B710 VA: 0x180C3D110
	private void FrameUpdate_Sleeping() { }

	// RVA: 0xC3CB70 Offset: 0xC3B170 VA: 0x180C3CB70
	private void FrameUpdate_Incapacitated() { }

	// RVA: 0xC3CE40 Offset: 0xC3B440 VA: 0x180C3CE40
	private void FrameUpdate_OnLadder() { }

	// RVA: 0xC3DB60 Offset: 0xC3C160 VA: 0x180C3DB60
	public float GetAim360() { }

	// RVA: 0xC46C60 Offset: 0xC45260 VA: 0x180C46C60
	public void UpdateVehicleAim360() { }

	// RVA: 0xC42210 Offset: 0xC40810 VA: 0x180C42210
	public void ResetCurrentState(int layer = 0) { }

	// RVA: 0xC3A910 Offset: 0xC38F10 VA: 0x180C3A910
	private void DoAimingSounds(float prevAiming, float currentAiming) { }

	// RVA: 0xC42320 Offset: 0xC40920 VA: 0x180C42320
	public void SetAimSounds(SoundDefinition aimDef, SoundDefinition aimEndDef) { }

	// RVA: 0xC42A90 Offset: 0xC41090 VA: 0x180C42A90
	public void SetMountedLookAtWeight(float weight) { }

	// RVA: 0xC42A70 Offset: 0xC41070 VA: 0x180C42A70
	public void SetMountedAnimationSpeed(float speed) { }

	// RVA: 0xC457D0 Offset: 0xC43DD0 VA: 0x180C457D0
	internal void UpdateLocalPlayerPosition(Vector3 position, Quaternion quaternion) { }

	// RVA: 0xC39CF0 Offset: 0xC382F0 VA: 0x180C39CF0
	public void Attack() { }

	// RVA: 0xC399B0 Offset: 0xC37FB0 VA: 0x180C399B0
	public void AltAttack() { }

	// RVA: 0xC3A860 Offset: 0xC38E60 VA: 0x180C3A860
	public void Deploy() { }

	// RVA: 0xC41F90 Offset: 0xC40590 VA: 0x180C41F90
	public void Reload() { }

	// RVA: 0xC3F420 Offset: 0xC3DA20 VA: 0x180C3F420
	public void Holster() { }

	// RVA: 0xC3B110 Offset: 0xC39710 VA: 0x180C3B110
	public void Flinch(uint location) { }

	// RVA: 0xC3B140 Offset: 0xC39740 VA: 0x180C3B140
	public void Flinch() { }

	// RVA: 0xC42AA0 Offset: 0xC410A0 VA: 0x180C42AA0
	public void SetReactionAnim(PlayerModel.ReactionDir direction, float weight) { }

	// RVA: 0xC40C60 Offset: 0xC3F260 VA: 0x180C40C60
	public void OnReactionEnded() { }

	// RVA: 0xC43BC0 Offset: 0xC421C0 VA: 0x180C43BC0
	public void Throw() { }

	// RVA: 0xC3D7D0 Offset: 0xC3BDD0 VA: 0x180C3D7D0
	public void Gesture(string gesture, GestureConfig forConfig) { }

	// RVA: 0xC3AB70 Offset: 0xC39170 VA: 0x180C3AB70
	private void FadeInGestureUpperBodyLayer() { }

	// RVA: 0xC3AE60 Offset: 0xC39460 VA: 0x180C3AE60
	private void FadeOutGestureUpperBodyLayer() { }

	// RVA: 0xC3AA50 Offset: 0xC39050 VA: 0x180C3AA50
	private void FadeInGestureFullBodyLayer() { }

	// RVA: 0xC3AC90 Offset: 0xC39290 VA: 0x180C3AC90
	private void FadeOutGestureFullBodyLayer() { }

	// RVA: 0xC39A60 Offset: 0xC38060 VA: 0x180C39A60
	private void AnimatorWarmup() { }

	// RVA: 0xC39A30 Offset: 0xC38030 VA: 0x180C39A30
	public void AlwaysAnimate(bool b) { }

	// RVA: 0xC426F0 Offset: 0xC40CF0 VA: 0x180C426F0
	public void SetHoldType(RuntimeAnimatorController holdType, bool suppressHandLayer = False) { }

	// RVA: 0xC426E0 Offset: 0xC40CE0 VA: 0x180C426E0
	public void SetHasHeldEntity(bool state) { }

	[IteratorStateMachineAttribute] // RVA: 0x80940 Offset: 0x7FD40 VA: 0x180080940
	// RVA: 0xC3ADF0 Offset: 0xC393F0 VA: 0x180C3ADF0
	public IEnumerator FadeOutGestureLayer() { }

	// RVA: 0xC42490 Offset: 0xC40A90 VA: 0x180C42490
	public void SetGesture() { }

	// RVA: 0xC3AFC0 Offset: 0xC395C0 VA: 0x180C3AFC0
	public void FadeOutPlayerGestureLayers() { }

	// RVA: 0xC43790 Offset: 0xC41D90 VA: 0x180C43790
	public void StopGesture() { }

	// RVA: 0xC410B0 Offset: 0xC3F6B0 VA: 0x180C410B0
	public void PlayCinematic(string name, float overrideSpeed = 1) { }

	// RVA: 0xC43730 Offset: 0xC41D30 VA: 0x180C43730
	public void StopCinematic() { }

	// RVA: 0xC42E80 Offset: 0xC41480 VA: 0x180C42E80
	public void SetSpeedOverride(Vector3 speed) { }

	// RVA: 0xC3E740 Offset: 0xC3CD40 VA: 0x180C3E740
	public Underwear GetReplacementUnderwear() { }

	// RVA: 0xC420E0 Offset: 0xC406E0 VA: 0x180C420E0
	public void RemoveUnderwearParts(SkinReplacement.SkinType typeToRemove) { }

	// RVA: 0xC39F70 Offset: 0xC38570 VA: 0x180C39F70
	public void Clear() { }

	// RVA: 0xC41A00 Offset: 0xC40000 VA: 0x180C41A00
	public void Rebuild(bool reset = True) { }

	// RVA: 0xC396D0 Offset: 0xC37CD0 VA: 0x180C396D0
	public void AddPart(string strName, Item item) { }

	// RVA: 0xC42010 Offset: 0xC40610 VA: 0x180C42010
	public void RemovePart(string strName) { }

	// RVA: 0xC3ED00 Offset: 0xC3D300 VA: 0x180C3ED00
	public bool HasPart(string strName) { }

	// RVA: 0xC3FBF0 Offset: 0xC3E1F0 VA: 0x180C3FBF0
	public bool IsBarefoot() { }

	// RVA: 0xC3E780 Offset: 0xC3CD80 VA: 0x180C3E780
	public Color GetSkinColor() { }

	// RVA: 0xC42D60 Offset: 0xC41360 VA: 0x180C42D60
	public void SetSkinProperties(MaterialPropertyBlock block) { }

	// RVA: 0xC41C00 Offset: 0xC40200 VA: 0x180C41C00
	public void RefreshUnderwear() { }

	// RVA: 0xC3C7D0 Offset: 0xC3ADD0 VA: 0x180C3C7D0
	public void ForceModelSeed(ulong userID) { }

	// RVA: 0xC3C8E0 Offset: 0xC3AEE0 VA: 0x180C3C8E0
	public void ForceModelSeed(ulong userID, bool storeSkinChange) { }

	// RVA: 0xC3B0E0 Offset: 0xC396E0 VA: 0x180C3B0E0
	public Transform FindBone(string strName) { }

	// RVA: 0xC3DDA0 Offset: 0xC3C3A0 VA: 0x180C3DDA0
	public Transform[] GetBones() { }

	// RVA: 0xC3DE10 Offset: 0xC3C410 VA: 0x180C3DE10
	private Vector3 GetFootPlacement(Vector3 footPos, out Vector3 surfaceNormal) { }

	// RVA: 0xC39AC0 Offset: 0xC380C0 VA: 0x180C39AC0
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0xC43C60 Offset: 0xC42260 VA: 0x180C43C60
	public void ToggleUpdateOffscreen(bool state) { }

	// RVA: 0xC40B60 Offset: 0xC3F160 VA: 0x180C40B60 Slot: 8
	public void OnParentDestroying() { }

	// RVA: 0xC47560 Offset: 0xC45B60 VA: 0x180C47560
	public void WorkshopPreviewSetup(GameObject[] objects) { }

	// RVA: 0xC48440 Offset: 0xC46A40 VA: 0x180C48440
	public void .ctor() { }

	// RVA: 0xC47F00 Offset: 0xC46500 VA: 0x180C47F00
	private static void .cctor() { }

}

public enum PlayerModel.MountPoses // TypeDefIndex: 9651
{	// Fields
	public int value__; // 0x0
	public const PlayerModel.MountPoses Chair = 0;
	public const PlayerModel.MountPoses Driving = 1;
	public const PlayerModel.MountPoses Horseback = 2;
	public const PlayerModel.MountPoses HeliUnarmed = 3;
	public const PlayerModel.MountPoses HeliArmed = 4;
	public const PlayerModel.MountPoses HandMotorBoat = 5;
	public const PlayerModel.MountPoses MotorBoatPassenger = 6;
	public const PlayerModel.MountPoses SitGeneric = 7;
	public const PlayerModel.MountPoses SitRaft = 8;
	public const PlayerModel.MountPoses StandDrive = 9;
	public const PlayerModel.MountPoses SitShootingGeneric = 10;
	public const PlayerModel.MountPoses SitMinicopter_Pilot = 11;
	public const PlayerModel.MountPoses SitMinicopter_Passenger = 12;
	public const PlayerModel.MountPoses ArcadeLeft = 13;
	public const PlayerModel.MountPoses ArcadeRight = 14;
	public const PlayerModel.MountPoses SitSummer_Ring = 15;
	public const PlayerModel.MountPoses SitSummer_BoogieBoard = 16;
	public const PlayerModel.MountPoses SitCarPassenger = 17;
	public const PlayerModel.MountPoses SitSummer_Chair = 18;
	public const PlayerModel.MountPoses SitRaft_NoPaddle = 19;
	public const PlayerModel.MountPoses Sit_SecretLab = 20;
	public const PlayerModel.MountPoses Sit_Workcart = 21;
	public const PlayerModel.MountPoses Sit_Cardgame = 22;
	public const PlayerModel.MountPoses Sit_Crane = 23;
	public const PlayerModel.MountPoses Sit_Snowmobile_Shooting = 24;
	public const PlayerModel.MountPoses Sit_RetroSnowmobile_Shooting = 25;
	public const PlayerModel.MountPoses Driving_Snowmobile = 26;
	public const PlayerModel.MountPoses ZiplineHold = 27;
	public const PlayerModel.MountPoses Sit_Locomotive = 28;
	public const PlayerModel.MountPoses Standing = 128;

}

public enum PlayerModel.ReactionDir // TypeDefIndex: 9652
{	// Fields
	public int value__; // 0x0
	public const PlayerModel.ReactionDir North = 0;
	public const PlayerModel.ReactionDir South = 1;
	public const PlayerModel.ReactionDir East = 2;
	public const PlayerModel.ReactionDir West = 3;

}

private sealed class PlayerModel.<>c // TypeDefIndex: 9653
{	// Fields
	public static readonly PlayerModel.<>c <>9; // 0x0
	public static Func<Wearable, bool> <>9__199_0; // 0x8
	public static Func<Wearable, bool> <>9__199_1; // 0x10
	public static Func<Wearable, bool> <>9__199_2; // 0x18

	// Methods

	// RVA: 0xC48F80 Offset: 0xC47580 VA: 0x180C48F80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC48F20 Offset: 0xC47520 VA: 0x180C48F20
	internal bool <UpdateCensorship>b__199_0(Wearable x) { }

	// RVA: 0xC48F40 Offset: 0xC47540 VA: 0x180C48F40
	internal bool <UpdateCensorship>b__199_1(Wearable x) { }

	// RVA: 0xC48F60 Offset: 0xC47560 VA: 0x180C48F60
	internal bool <UpdateCensorship>b__199_2(Wearable y) { }

}

private sealed class PlayerModel.<FadeOutGestureLayer>d__244 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9654
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerModel <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xC48B40 Offset: 0xC47140 VA: 0x180C48B40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48ED0 Offset: 0xC474D0 VA: 0x180C48ED0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PlayerModel.<>c__DisplayClass256_0 // TypeDefIndex: 9655
{	// Fields
	public string strName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C4740 Offset: 0x5C2D40 VA: 0x1805C4740
	internal bool <RemovePart>b__0(SkinnedMultiMesh.Part x) { }

}

private sealed class PlayerModel.<>c__DisplayClass257_0 // TypeDefIndex: 9656
{	// Fields
	public string strName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C4740 Offset: 0x5C2D40 VA: 0x1805C4740
	internal bool <HasPart>b__0(SkinnedMultiMesh.Part x) { }

}

public class PlayerModelCinematicList : PrefabAttribute, IClientComponent // TypeDefIndex: 9657
{	// Fields
	public PlayerModelCinematicList.PlayerModelCinematicAnimation[] Animations; // 0x98

	// Methods

	// RVA: 0xC388D0 Offset: 0xC36ED0 VA: 0x180C388D0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0xC38930 Offset: 0xC36F30 VA: 0x180C38930 Slot: 5
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xC38960 Offset: 0xC36F60 VA: 0x180C38960
	public void .ctor() { }

}

public struct PlayerModelCinematicList.PlayerModelCinematicAnimation // TypeDefIndex: 9658
{	// Fields
	public string StateName; // 0x0
	public string ClipName; // 0x8
	public float Length; // 0x10

}

public class PlayerModelReactionEnded : StateMachineBehaviour // TypeDefIndex: 9659
{	// Fields
	private PlayerModel playerModel; // 0x18

	// Methods

	// RVA: 0x98CF90 Offset: 0x98B590 VA: 0x18098CF90 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7A30 Offset: 0x6A6030 VA: 0x1806A7A30
	public void .ctor() { }

}

public class PlayerNameTag : MonoBehaviour // TypeDefIndex: 9660
{	// Fields
	public CanvasGroup canvasGroup; // 0x18
	public Text text; // 0x20
	public Gradient color; // 0x28
	public float minDistance; // 0x30
	public float maxDistance; // 0x34
	public Vector3 positionOffset; // 0x38
	public Transform parentBone; // 0x48
	private float distanceFromCamera; // 0x50
	internal string lastName; // 0x58

	// Methods

	// RVA: 0x98DBB0 Offset: 0x98C1B0 VA: 0x18098DBB0
	public void Initialize(BasePlayer player, Transform parent) { }

	// RVA: 0x98E0D0 Offset: 0x98C6D0 VA: 0x18098E0D0
	public void UpdateFrom(BasePlayer player) { }

	// RVA: 0x98DE60 Offset: 0x98C460 VA: 0x18098DE60
	private void LateUpdate() { }

	// RVA: 0x98E230 Offset: 0x98C830 VA: 0x18098E230
	private void UpdateNameColor() { }

	// RVA: 0x98DFB0 Offset: 0x98C5B0 VA: 0x18098DFB0
	public void PositionUpdate(bool visible) { }

	// RVA: 0x98E480 Offset: 0x98CA80 VA: 0x18098E480
	public void .ctor() { }

}

public class PlayerVoiceRecorder : EntityComponent<BasePlayer> // TypeDefIndex: 9662
{	// Fields
	internal static byte[] readBuffer; // 0x0
	internal static byte[] readBufferUncompressed; // 0x8
	private RealTimeSince timeSinceLastSpeak; // 0x20
	private RealTimeSince timeSinceLastCheck; // 0x24
	private Stopwatch TalkTimer; // 0x28

	// Properties
	public bool IsSpeaking { get; }

	// Methods

	// RVA: 0x98F360 Offset: 0x98D960 VA: 0x18098F360
	public bool get_IsSpeaking() { }

	// RVA: 0x98E5C0 Offset: 0x98CBC0 VA: 0x18098E5C0
	public void ClientFrame(BasePlayer player) { }

	// RVA: 0x98EB80 Offset: 0x98D180 VA: 0x18098EB80
	public void ClientInput(InputState state) { }

	// RVA: 0x98ECF0 Offset: 0x98D2F0 VA: 0x18098ECF0
	private bool DoesUserWantToTalk() { }

	// RVA: 0x98E4E0 Offset: 0x98CAE0 VA: 0x18098E4E0
	public bool CanTalk() { }

	// RVA: 0x98F070 Offset: 0x98D670 VA: 0x18098F070
	public void StopRecording() { }

	// RVA: 0x98EEC0 Offset: 0x98D4C0 VA: 0x18098EEC0
	public void StartRecording() { }

	// RVA: 0x98F2F0 Offset: 0x98D8F0 VA: 0x18098F2F0
	public void .ctor() { }

	// RVA: 0x98F270 Offset: 0x98D870 VA: 0x18098F270
	private static void .cctor() { }

}

public class PlayerVoiceSpeaker : EntityComponent<BasePlayer> // TypeDefIndex: 9663
{	// Fields
	public VoiceProcessor voiceProcessor; // 0x20
	private float nextSpeechFakeChange; // 0x28
	private float speechFakeChangeMulti; // 0x2C
	private bool isFakingVolume; // 0x30
	private float fakedVolume; // 0x34
	private static bool hasAwardedRecordVoicesAchievement; // 0x0

	// Properties
	public float currentVolume { get; }

	// Methods

	// RVA: 0x990390 Offset: 0x98E990 VA: 0x180990390
	public float get_currentVolume() { }

	// RVA: 0x98FBF0 Offset: 0x98E1F0 VA: 0x18098FBF0
	public bool IsSpeaking() { }

	// RVA: 0x98FC80 Offset: 0x98E280 VA: 0x18098FC80
	public void Receive(byte[] data) { }

	// RVA: 0x98F880 Offset: 0x98DE80 VA: 0x18098F880
	public float GetMouthVolume() { }

	// RVA: 0x98F390 Offset: 0x98D990 VA: 0x18098F390
	public void ClientFrame() { }

	// RVA: 0x990010 Offset: 0x98E610 VA: 0x180990010
	public bool ShouldMuteVoice() { }

	// RVA: 0x98FAF0 Offset: 0x98E0F0 VA: 0x18098FAF0
	private bool IsPlayingLocalVoice() { }

	// RVA: 0x990130 Offset: 0x98E730 VA: 0x180990130
	public bool ShouldReceiveVoice() { }

	// RVA: 0x990350 Offset: 0x98E950 VA: 0x180990350
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class PlayerWalkMovement : BaseMovement // TypeDefIndex: 9669
{	// Fields
	public const float WaterLevelHead = 0,75;
	public const float WaterLevelNeck = 0,65;
	public PhysicMaterial zeroFrictionMaterial; // 0x58
	public PhysicMaterial highFrictionMaterial; // 0x60
	public float capsuleHeight; // 0x68
	public float capsuleCenter; // 0x6C
	public float capsuleHeightDucked; // 0x70
	public float capsuleCenterDucked; // 0x74
	public float capsuleHeightCrawling; // 0x78
	public float capsuleCenterCrawling; // 0x7C
	public float gravityTestRadius; // 0x80
	public float gravityMultiplier; // 0x84
	public float gravityMultiplierSwimming; // 0x88
	public float maxAngleWalking; // 0x8C
	public float maxAngleClimbing; // 0x90
	public float maxAngleSliding; // 0x94
	public float maxStepHeight; // 0x98
	private Rigidbody body; // 0xA0
	private CollisionDetectionMode initialColDetectionMode; // 0xA8
	private CapsuleCollider capsule; // 0xB0
	private TriggerLadder ladder; // 0xB8
	private float maxVelocity; // 0xC0
	private float groundAngle; // 0xC4
	private float groundAngleNew; // 0xC8
	private float groundTime; // 0xCC
	private float jumpTime; // 0xD0
	private float landTime; // 0xD4
	private Vector3 previousPosition; // 0xD8
	private Vector3 previousVelocity; // 0xE4
	private Vector3 previousInheritedVelocity; // 0xF0
	private Vector3 groundNormal; // 0xFC
	private Vector3 groundNormalNew; // 0x108
	private Vector3 groundVelocity; // 0x114
	private Vector3 groundVelocityNew; // 0x120
	private float nextSprintTime; // 0x12C
	private float lastSprintTime; // 0x130
	private bool sprintForced; // 0x134
	private TimeSince attemptedMountTime; // 0x138
	private BaseEntity.MovementModify modify; // 0x13C
	private bool grounded; // 0x140
	private bool climbing; // 0x141
	private bool sliding; // 0x142
	private bool swimming; // 0x143
	private bool wasSwimming; // 0x144
	private bool jumping; // 0x145
	private bool wasJumping; // 0x146
	private bool falling; // 0x147
	private bool wasFalling; // 0x148
	private bool flying; // 0x149
	private bool wasFlying; // 0x14A
	private float forcedDuckDelta; // 0x14C

	// Methods

	// RVA: 0x990470 Offset: 0x98EA70 VA: 0x180990470
	protected void Awake() { }

	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0 Slot: 6
	public override Collider GetCollider() { }

	// RVA: 0x995360 Offset: 0x993960 VA: 0x180995360
	protected void OnDisable() { }

	// RVA: 0x992B90 Offset: 0x991190 VA: 0x180992B90 Slot: 7
	public override void Init(BasePlayer player) { }

	// RVA: 0x9951A0 Offset: 0x9937A0 VA: 0x1809951A0
	protected void OnCollisionEnter(Collision collision) { }

	// RVA: 0x995280 Offset: 0x993880 VA: 0x180995280
	protected void OnCollisionStay(Collision collision) { }

	// RVA: 0x992350 Offset: 0x990950 VA: 0x180992350
	private void GroundCheck(Collision collision) { }

	// RVA: 0x995A10 Offset: 0x994010 VA: 0x180995A10 Slot: 13
	public override void TeleportTo(Vector3 position, BasePlayer player) { }

	// RVA: 0x995D40 Offset: 0x994340 VA: 0x180995D40
	public void UpdateCurrentLadder(InputState input, bool force = False) { }

	// RVA: 0x996DB0 Offset: 0x9953B0 VA: 0x180996DB0
	public static bool WantsSprint(InputState input) { }

	// RVA: 0x990760 Offset: 0x98ED60 VA: 0x180990760 Slot: 10
	public override void ClientInput(InputState input, ModelState modelState) { }

	// RVA: 0x9945F0 Offset: 0x992BF0 VA: 0x1809945F0
	private void Movement_Water(InputState input, ModelState modelState) { }

	// RVA: 0x9936D0 Offset: 0x991CD0 VA: 0x1809936D0
	private void Movement_Mounted(InputState input, ModelState modelState) { }

	// RVA: 0x993080 Offset: 0x991680 VA: 0x180993080
	private void Movement_Ladder(InputState input, ModelState modelState) { }

	// RVA: 0x9937E0 Offset: 0x991DE0 VA: 0x1809937E0
	private void Movement_Noclip(InputState input, ModelState modelState) { }

	// RVA: 0x993D70 Offset: 0x992370 VA: 0x180993D70
	private void Movement_Walking(InputState input, ModelState modelState) { }

	// RVA: 0x9922A0 Offset: 0x9908A0 VA: 0x1809922A0
	private float GetHeldEntityMovementMultiplier() { }

	// RVA: 0x992620 Offset: 0x990C20 VA: 0x180992620
	private void HandleGrounded(ModelState state, bool wantsGrounded) { }

	// RVA: 0x9927A0 Offset: 0x990DA0 VA: 0x1809927A0
	private void HandleRunDuckCrawl(ModelState state, bool wantsRun, bool wantsDuck, bool wantsCrawl) { }

	// RVA: 0x9921B0 Offset: 0x9907B0 VA: 0x1809921B0
	private float GetForcedDuck() { }

	// RVA: 0x992670 Offset: 0x990C70 VA: 0x180992670
	private void HandleJumping(ModelState state, bool wantsJump, bool jumpInDirection = False) { }

	// RVA: 0x9905E0 Offset: 0x98EBE0 VA: 0x1809905E0
	private bool CanJump() { }

	// RVA: 0x990550 Offset: 0x98EB50 VA: 0x180990550 Slot: 8
	public override void BlockJump(float duration) { }

	// RVA: 0x990590 Offset: 0x98EB90 VA: 0x180990590 Slot: 9
	public override void BlockSprint(float duration) { }

	// RVA: 0x9957E0 Offset: 0x993DE0 VA: 0x1809957E0
	public void SetKinematic(bool kinematic) { }

	// RVA: 0x990430 Offset: 0x98EA30 VA: 0x180990430
	public void ApplyForce(Vector3 force) { }

	// RVA: 0x9906F0 Offset: 0x98ECF0 VA: 0x1809906F0
	private bool CanSprint() { }

	// RVA: 0x992D60 Offset: 0x991360 VA: 0x180992D60
	private void Jump(ModelState state, bool inDirection) { }

	// RVA: 0x990B10 Offset: 0x98F110 VA: 0x180990B10 Slot: 11
	public override void DoFixedUpdate(ModelState modelState) { }

	// RVA: 0x991330 Offset: 0x98F930 VA: 0x180991330
	public void DoStepUp() { }

	// RVA: 0x996260 Offset: 0x994860 VA: 0x180996260
	private void UpdateVelocity() { }

	// RVA: 0x995F10 Offset: 0x994510 VA: 0x180995F10
	private void UpdateGravity(ModelState modelState) { }

	// RVA: 0x991D00 Offset: 0x990300 VA: 0x180991D00 Slot: 12
	public override void FrameUpdate(BasePlayer player, ModelState state) { }

	// RVA: 0x995B30 Offset: 0x994130 VA: 0x180995B30
	private void TransformState(Matrix4x4 matrix) { }

	// RVA: 0x995810 Offset: 0x993E10 VA: 0x180995810 Slot: 15
	public override void SetParent(Transform parent) { }

	// RVA: 0x991C50 Offset: 0x990250 VA: 0x180991C50
	private Vector3 FallVelocity() { }

	// RVA: 0x990AD0 Offset: 0x98F0D0 VA: 0x180990AD0 Slot: 4
	public override Vector3 CurrentVelocity() { }

	// RVA: 0x990A80 Offset: 0x98F080 VA: 0x180990A80 Slot: 5
	public override float CurrentMoveSpeed() { }

	// RVA: 0x995780 Offset: 0x993D80 VA: 0x180995780 Slot: 16
	public override void PlayerAttemptedMount() { }

	// RVA: 0x9957B0 Offset: 0x993DB0 VA: 0x1809957B0 Slot: 17
	public override void PlayerCompletedMount() { }

	// RVA: 0x996E40 Offset: 0x995440 VA: 0x180996E40
	public void .ctor() { }

}

public class PlayerCorpse : LootableCorpse // TypeDefIndex: 9670
{	// Fields
	public Buoyancy buoyancy; // 0x2D0
	public const BaseEntity.Flags Flag_Buoyant = 16384;
	public uint underwearSkin; // 0x2D8
	private ItemContainer clientClothing; // 0x2E0
	private uint lastClothes; // 0x2E8

	// Methods

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool IsBuoyant() { }

	// RVA: 0xC2C740 Offset: 0xC2AD40 VA: 0x180C2C740 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xC2CA30 Offset: 0xC2B030 VA: 0x180C2CA30
	private void RebuildWorldModel() { }

	// RVA: 0xC2C760 Offset: 0xC2AD60 VA: 0x180C2C760 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xC2C8F0 Offset: 0xC2AEF0 VA: 0x180C2C8F0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xC2CE50 Offset: 0xC2B450 VA: 0x180C2CE50
	private void ToggleClientBuoyancy(bool isBuoyant) { }

	// RVA: 0xC2C710 Offset: 0xC2AD10 VA: 0x180C2C710 Slot: 122
	public override string Categorize() { }

	// RVA: 0xC2CF70 Offset: 0xC2B570 VA: 0x180C2CF70
	public void .ctor() { }

}

public class PlayerInventoryProperties : ScriptableObject // TypeDefIndex: 10749
{	// Fields
	public string niceName; // 0x18
	public int order; // 0x20
	public List<PlayerInventoryProperties.ItemAmountSkinned> belt; // 0x28
	public List<PlayerInventoryProperties.ItemAmountSkinned> main; // 0x30
	public List<PlayerInventoryProperties.ItemAmountSkinned> wear; // 0x38
	public PlayerInventoryProperties giveBase; // 0x40

	// Methods

	// RVA: 0xC35910 Offset: 0xC33F10 VA: 0x180C35910
	public void .ctor() { }

}

public class PlayerInventoryProperties.ItemAmountSkinned : ItemAmount // TypeDefIndex: 10750
{	// Fields
	public ulong skinOverride; // 0x20

	// Methods

	// RVA: 0xC2C700 Offset: 0xC2AD00 VA: 0x180C2C700
	public void .ctor() { }

}

public class PlayerDetectedEventUI : BaseEventUI // TypeDefIndex: 10807
{	// Methods

	// RVA: 0x88B080 Offset: 0x889680 VA: 0x18088B080 Slot: 4
	public override void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0xC2D030 Offset: 0xC2B630 VA: 0x180C2D030 Slot: 5
	public override AIEventData Save() { }

	// RVA: 0xC2CFC0 Offset: 0xC2B5C0 VA: 0x180C2CFC0 Slot: 6
	public override void Load(AIEventData data) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class Player : ConsoleSystem // TypeDefIndex: 11953
{	// Fields
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int tickrate_cl; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int tickrate_sv; // 0x4
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool recoilcomp; // 0x8
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool footik; // 0x9
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float footikdistance; // 0xC
	[ClientVar] // RVA: 0xB0630 Offset: 0xAFA30 VA: 0x1800B0630
	public static float footikrate; // 0x10
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool triggerfix; // 0x14
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool eye_blinking; // 0x15
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool eye_movement; // 0x16
	[ClientVar] // RVA: 0xB0820 Offset: 0xAFC20 VA: 0x1800B0820
	public static bool useCinematicAvatar; // 0x17
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float noclipspeed; // 0x18
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float noclipspeedslow; // 0x1C
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float noclipspeedfast; // 0x20

	// Methods

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x368350 Offset: 0x366950 VA: 0x180368350
	public static void cinematic_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x368AB0 Offset: 0x3670B0 VA: 0x180368AB0
	public static void gesture(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x368BF0 Offset: 0x3671F0 VA: 0x180368BF0
	public static void petcmd(ConsoleSystem.Arg arg) { }

	[ServerUserVar] // RVA: 0xB0B90 Offset: 0xAFF90 VA: 0x1800B0B90
	[ClientVar] // RVA: 0xB0B90 Offset: 0xAFF90 VA: 0x1800B0B90
	// RVA: 0x3687E0 Offset: 0x366DE0 VA: 0x1803687E0
	public static void cinematic_play(ConsoleSystem.Arg arg) { }

	[ServerUserVar] // RVA: 0xB0B90 Offset: 0xAFF90 VA: 0x1800B0B90
	[ClientVar] // RVA: 0xB0B90 Offset: 0xAFF90 VA: 0x1800B0B90
	// RVA: 0x3689B0 Offset: 0x366FB0 VA: 0x1803689B0
	public static void cinematic_stop(ConsoleSystem.Arg arg) { }

	// RVA: 0x3682F0 Offset: 0x3668F0 VA: 0x1803682F0
	public void .ctor() { }

	// RVA: 0x3681C0 Offset: 0x3667C0 VA: 0x1803681C0
	private static void .cctor() { }

}

public class PlayerCull : ConsoleSystem // TypeDefIndex: 11954
{	// Fields
	private static bool _enabled; // 0x0
	[ClientVar] // RVA: 0x91330 Offset: 0x90730 VA: 0x180091330
	public static float updateRate; // 0x4
	[ClientVar] // RVA: 0xB2040 Offset: 0xB1440 VA: 0x1800B2040
	public static float minCullDist; // 0x8
	[ClientVar] // RVA: 0xB2270 Offset: 0xB1670 VA: 0x1800B2270
	public static float maxSleeperDist; // 0xC
	[ClientVar] // RVA: 0x914B0 Offset: 0x908B0 VA: 0x1800914B0
	public static float maxPlayerDist; // 0x10
	[ClientVar] // RVA: 0xB23C0 Offset: 0xB17C0 VA: 0x1800B23C0
	public static int visQuality; // 0x14
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool debug; // 0x18

	// Properties
	[ClientVar] // RVA: 0xB2740 Offset: 0xB1B40 VA: 0x1800B2740
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x367FB0 Offset: 0x3665B0 VA: 0x180367FB0
	public static bool get_enabled() { }

	// RVA: 0x368010 Offset: 0x366610 VA: 0x180368010
	public static void set_enabled(bool value) { }

	// RVA: 0x367F50 Offset: 0x366550 VA: 0x180367F50
	public void .ctor() { }

	// RVA: 0x367EA0 Offset: 0x3664A0 VA: 0x180367EA0
	private static void .cctor() { }

}

public enum PlayerMenuAnimation.Layers // TypeDefIndex: 12151
{
// Namespace: 
public enum PlayerMenuAnimation.Layers // TypeDefIndex: 12151
	// Fields
	public int value__; // 0x0
	public const PlayerMenuAnimation.Layers Movement = 0;

}

