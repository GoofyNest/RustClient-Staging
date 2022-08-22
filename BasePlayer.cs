internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 3475
{	// Methods

	// RVA: 0x18FAFE0 Offset: 0x18F95E0 VA: 0x1818FAFE0 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FB100 Offset: 0x18F9700 VA: 0x1818FB100 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FAE40 Offset: 0x18F9440 VA: 0x1818FAE40 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x18FAF70 Offset: 0x18F9570 VA: 0x1818FAF70 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x18FB220 Offset: 0x18F9820 VA: 0x1818FB220 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x18FADE0 Offset: 0x18F93E0 VA: 0x1818FADE0 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x18FAE10 Offset: 0x18F9410 VA: 0x1818FAE10 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x18FADB0 Offset: 0x18F93B0 VA: 0x1818FADB0 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunctionAttribute] // RVA: 0xB0AA0 Offset: 0xAFEA0 VA: 0x1800B0AA0
	// RVA: 0x18FAE10 Offset: 0x18F9410 VA: 0x1818FAE10
	private static bool IsConnected() { }

	[FreeFunctionAttribute] // RVA: 0xB0B30 Offset: 0xAFF30 VA: 0x1800B0B30
	// RVA: 0x18FADE0 Offset: 0x18F93E0 VA: 0x1818FADE0
	private static void Initialize() { }

	[FreeFunctionAttribute] // RVA: 0xB0BD0 Offset: 0xAFFD0 VA: 0x1800B0BD0
	// RVA: 0x18FAE70 Offset: 0x18F9470 VA: 0x1818FAE70
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB0C30 Offset: 0xB0030 VA: 0x1800B0C30
	// RVA: 0x18FB290 Offset: 0x18F9890 VA: 0x1818FB290
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB1F90 Offset: 0xB1390 VA: 0x1800B1F90
	// RVA: 0x18FAEB0 Offset: 0x18F94B0 VA: 0x1818FAEB0
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB2080 Offset: 0xB1480 VA: 0x1800B2080
	// RVA: 0x18FAF10 Offset: 0x18F9510 VA: 0x1818FAF10
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB22B0 Offset: 0xB16B0 VA: 0x1800B22B0
	// RVA: 0x18FAE40 Offset: 0x18F9440 VA: 0x1818FAE40
	private static void PollInternal() { }

	[FreeFunctionAttribute] // RVA: 0xB2390 Offset: 0xB1790 VA: 0x1800B2390
	// RVA: 0x18FADB0 Offset: 0x18F93B0 VA: 0x1818FADB0
	private static void DisconnectAll() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class PlayerPrefsException : Exception // TypeDefIndex: 3476
{	// Methods

	// RVA: 0x18FD080 Offset: 0x18FB680 VA: 0x1818FD080
	public void .ctor(string error) { }

}

public class PlayerPrefs // TypeDefIndex: 3477
{	// Methods

	[NativeMethodAttribute] // RVA: 0xB2540 Offset: 0xB1940 VA: 0x1800B2540
	// RVA: 0x18FD560 Offset: 0x18FBB60 VA: 0x1818FD560
	private static bool TrySetInt(string key, int value) { }

	[NativeMethodAttribute] // RVA: 0xB27D0 Offset: 0xB1BD0 VA: 0x1800B27D0
	// RVA: 0x18FD510 Offset: 0x18FBB10 VA: 0x1818FD510
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethodAttribute] // RVA: 0xB28E0 Offset: 0xB1CE0 VA: 0x1800B28E0
	// RVA: 0x18FD5A0 Offset: 0x18FBBA0 VA: 0x1818FD5A0
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x18FD3E0 Offset: 0x18FB9E0 VA: 0x1818FD3E0
	public static void SetInt(string key, int value) { }

	// RVA: 0x18FD1C0 Offset: 0x18FB7C0 VA: 0x1818FD1C0
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x18FD200 Offset: 0x18FB800 VA: 0x1818FD200
	public static int GetInt(string key) { }

	// RVA: 0x18FD340 Offset: 0x18FB940 VA: 0x1818FD340
	public static void SetFloat(string key, float value) { }

	// RVA: 0x18FD130 Offset: 0x18FB730 VA: 0x1818FD130
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x18FD180 Offset: 0x18FB780 VA: 0x1818FD180
	public static float GetFloat(string key) { }

	// RVA: 0x18FD470 Offset: 0x18FBA70 VA: 0x1818FD470
	public static void SetString(string key, string value) { }

	// RVA: 0x18FD2B0 Offset: 0x18FB8B0 VA: 0x1818FD2B0
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x18FD240 Offset: 0x18FB840 VA: 0x1818FD240
	public static string GetString(string key) { }

	// RVA: 0x18FD300 Offset: 0x18FB900 VA: 0x1818FD300
	public static bool HasKey(string key) { }

	// RVA: 0x18FD0F0 Offset: 0x18FB6F0 VA: 0x1818FD0F0
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

	// RVA: 0x14647E0 Offset: 0x1462DE0 VA: 0x1814647E0 Slot: 12
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

	// RVA: 0x18FC700 Offset: 0x18FAD00 VA: 0x1818FC700
	public static PlayerConnection get_instance() { }

	// RVA: 0x18FC8B0 Offset: 0x18FAEB0 VA: 0x1818FC8B0
	public bool get_isConnected() { }

	// RVA: 0x18FB5C0 Offset: 0x18F9BC0 VA: 0x1818FB5C0
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x18FB910 Offset: 0x18F9F10 VA: 0x1818FB910
	public void OnEnable() { }

	// RVA: 0x18FB780 Offset: 0x18F9D80 VA: 0x1818FB780
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x18FBB70 Offset: 0x18FA170 VA: 0x1818FBB70 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FC2F0 Offset: 0x18FA8F0 VA: 0x1818FC2F0 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FB9B0 Offset: 0x18F9FB0 VA: 0x1818FB9B0 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18FBB10 Offset: 0x18FA110 VA: 0x1818FBB10 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18FC230 Offset: 0x18FA830 VA: 0x1818FC230 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18FC290 Offset: 0x18FA890 VA: 0x1818FC290 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18FBED0 Offset: 0x18FA4D0 VA: 0x1818FBED0 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x18FC080 Offset: 0x18FA680 VA: 0x1818FC080 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x18FB2D0 Offset: 0x18F98D0 VA: 0x1818FB2D0
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x18FB670 Offset: 0x18F9C70 VA: 0x1818FB670 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FB7E0 Offset: 0x18F9DE0 VA: 0x1818FB7E0
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FB540 Offset: 0x18F9B40 VA: 0x1818FB540
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FB700 Offset: 0x18F9D00 VA: 0x1818FB700
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x18FC580 Offset: 0x18FAB80 VA: 0x1818FC580
	public void .ctor() { }

}

private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 3790
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901670 Offset: 0x18FFC70 VA: 0x181901670
	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 3791
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901720 Offset: 0x18FFD20 VA: 0x181901720
	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 3792
{	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1020D30 Offset: 0x101F330 VA: 0x181020D30
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

	// RVA: 0x18FCB20 Offset: 0x18FB120 VA: 0x1818FCB20
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FC940 Offset: 0x18FAF40 VA: 0x1818FC940
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x18FCE70 Offset: 0x18FB470 VA: 0x1818FCE70
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FCF80 Offset: 0x18FB580 VA: 0x1818FCF80
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 3794
{	// Methods

	// RVA: 0x18F70C0 Offset: 0x18F56C0 VA: 0x1818F70C0
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 3795
{	// Methods

	// RVA: 0x18E95C0 Offset: 0x18E7BC0 VA: 0x1818E95C0
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

	// RVA: 0x18F7190 Offset: 0x18F5790 VA: 0x1818F7190
	public Guid get_MessageTypeId() { }

	// RVA: 0x18F71D0 Offset: 0x18F57D0 VA: 0x1818F71D0
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x18F7100 Offset: 0x18F5700 VA: 0x1818F7100
	public void .ctor() { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 3797
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19017D0 Offset: 0x18FFDD0 VA: 0x1819017D0
	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 3798
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901880 Offset: 0x18FFE80 VA: 0x181901880
	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 3799
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901930 Offset: 0x18FFF30 VA: 0x181901930
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

	// RVA: 0x2300590 Offset: 0x22FEB90 VA: 0x182300590
	public static bool op_Equality(PlayerItemRecipe left, PlayerItemRecipe right) { }

	// RVA: 0x23005B0 Offset: 0x22FEBB0 VA: 0x1823005B0
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

	// RVA: 0x875410 Offset: 0x873A10 VA: 0x180875410
	public static bool op_Equality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

	// RVA: 0x875430 Offset: 0x873A30 VA: 0x180875430
	public static bool op_Inequality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

}

private sealed class PlayerItemRecipe.<>c // TypeDefIndex: 5700
{	// Fields
	public static readonly PlayerItemRecipe.<>c <>9; // 0x0
	public static Func<PlayerItemRecipe.Ingredient, int> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x2300E00 Offset: 0x22FF400 VA: 0x182300E00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2300D40 Offset: 0x22FF340 VA: 0x182300D40
	internal int <GetHashCode>b__10_0(PlayerItemRecipe.Ingredient i) { }

}

public static class PlayerItemExtensions // TypeDefIndex: 6156
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2315F50 Offset: 0x2314550 VA: 0x182315F50
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

	// RVA: 0x20217F0 Offset: 0x201FDF0 VA: 0x1820217F0
	public static void ResetToPool(PlayerTick instance) { }

	// RVA: 0x2021930 Offset: 0x201FF30 VA: 0x182021930
	public void ResetToPool() { }

	// RVA: 0x20212E0 Offset: 0x201F8E0 VA: 0x1820212E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201F840 Offset: 0x201DE40 VA: 0x18201F840
	public void CopyTo(PlayerTick instance) { }

	// RVA: 0x201FA70 Offset: 0x201E070 VA: 0x18201FA70
	public PlayerTick Copy() { }

	// RVA: 0x2020400 Offset: 0x201EA00 VA: 0x182020400
	public static PlayerTick Deserialize(Stream stream) { }

	// RVA: 0x201FAF0 Offset: 0x201E0F0 VA: 0x18201FAF0
	public static PlayerTick DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201FF80 Offset: 0x201E580 VA: 0x18201FF80
	public static PlayerTick DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2020EC0 Offset: 0x201F4C0 VA: 0x182020EC0
	public static PlayerTick Deserialize(byte[] buffer) { }

	// RVA: 0x20214A0 Offset: 0x201FAA0 VA: 0x1820214A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20227C0 Offset: 0x2020DC0 VA: 0x1820227C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20227E0 Offset: 0x2020DE0 VA: 0x1820227E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTick previous) { }

	// RVA: 0x20217D0 Offset: 0x201FDD0 VA: 0x1820217D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2020770 Offset: 0x201ED70 VA: 0x182020770
	public static PlayerTick Deserialize(byte[] buffer, PlayerTick instance, bool isDelta = False) { }

	// RVA: 0x2020B90 Offset: 0x201F190 VA: 0x182020B90
	public static PlayerTick Deserialize(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x201FB70 Offset: 0x201E170 VA: 0x18201FB70
	public static PlayerTick DeserializeLengthDelimited(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x2020010 Offset: 0x201E610 VA: 0x182020010
	public static PlayerTick DeserializeLength(Stream stream, int length, PlayerTick instance, bool isDelta) { }

	// RVA: 0x2021A70 Offset: 0x2020070 VA: 0x182021A70
	public static void SerializeDelta(Stream stream, PlayerTick instance, PlayerTick previous) { }

	// RVA: 0x20222E0 Offset: 0x20208E0 VA: 0x1820222E0
	public static void Serialize(Stream stream, PlayerTick instance) { }

	// RVA: 0x20227B0 Offset: 0x2020DB0 VA: 0x1820227B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20227C0 Offset: 0x2020DC0 VA: 0x1820227C0
	public void ToProto(Stream stream) { }

	// RVA: 0x20221D0 Offset: 0x20207D0 VA: 0x1820221D0
	public static byte[] SerializeToBytes(PlayerTick instance) { }

	// RVA: 0x2022120 Offset: 0x2020720 VA: 0x182022120
	public static void SerializeLengthDelimited(Stream stream, PlayerTick instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x2003E70 Offset: 0x2002470 VA: 0x182003E70
	public static void ResetToPool(BasePlayer instance) { }

	// RVA: 0x2003B30 Offset: 0x2002130 VA: 0x182003B30
	public void ResetToPool() { }

	// RVA: 0x2003A70 Offset: 0x2002070 VA: 0x182003A70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2001BD0 Offset: 0x20001D0 VA: 0x182001BD0
	public void CopyTo(BasePlayer instance) { }

	// RVA: 0x2001E80 Offset: 0x2000480 VA: 0x182001E80
	public BasePlayer Copy() { }

	// RVA: 0x2003070 Offset: 0x2001670 VA: 0x182003070
	public static BasePlayer Deserialize(Stream stream) { }

	// RVA: 0x2001F00 Offset: 0x2000500 VA: 0x182001F00
	public static BasePlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20027C0 Offset: 0x2000DC0 VA: 0x1820027C0
	public static BasePlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20030F0 Offset: 0x20016F0 VA: 0x1820030F0
	public static BasePlayer Deserialize(byte[] buffer) { }

	// RVA: 0x2003AF0 Offset: 0x20020F0 VA: 0x182003AF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2005C70 Offset: 0x2004270 VA: 0x182005C70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2005C90 Offset: 0x2004290 VA: 0x182005C90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BasePlayer previous) { }

	// RVA: 0x2003B10 Offset: 0x2002110 VA: 0x182003B10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2003970 Offset: 0x2001F70 VA: 0x182003970
	public static BasePlayer Deserialize(byte[] buffer, BasePlayer instance, bool isDelta = False) { }

	// RVA: 0x2003210 Offset: 0x2001810 VA: 0x182003210
	public static BasePlayer Deserialize(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x2001F80 Offset: 0x2000580 VA: 0x182001F80
	public static BasePlayer DeserializeLengthDelimited(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x2002850 Offset: 0x2000E50 VA: 0x182002850
	public static BasePlayer DeserializeLength(Stream stream, int length, BasePlayer instance, bool isDelta) { }

	// RVA: 0x20041B0 Offset: 0x20027B0 VA: 0x1820041B0
	public static void SerializeDelta(Stream stream, BasePlayer instance, BasePlayer previous) { }

	// RVA: 0x2005120 Offset: 0x2003720 VA: 0x182005120
	public static void Serialize(Stream stream, BasePlayer instance) { }

	// RVA: 0x2005C60 Offset: 0x2004260 VA: 0x182005C60
	public byte[] ToProtoBytes() { }

	// RVA: 0x2005C70 Offset: 0x2004270 VA: 0x182005C70
	public void ToProto(Stream stream) { }

	// RVA: 0x2005010 Offset: 0x2003610 VA: 0x182005010
	public static byte[] SerializeToBytes(BasePlayer instance) { }

	// RVA: 0x2004F60 Offset: 0x2003560 VA: 0x182004F60
	public static void SerializeLengthDelimited(Stream stream, BasePlayer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x2043880 Offset: 0x2041E80 VA: 0x182043880
	public static void ResetToPool(PlayerTeam instance) { }

	// RVA: 0x2043AD0 Offset: 0x20420D0 VA: 0x182043AD0
	public void ResetToPool() { }

	// RVA: 0x2043480 Offset: 0x2041A80 VA: 0x182043480 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2041990 Offset: 0x203FF90 VA: 0x182041990
	public void CopyTo(PlayerTeam instance) { }

	// RVA: 0x2041BD0 Offset: 0x20401D0 VA: 0x182041BD0
	public PlayerTeam Copy() { }

	// RVA: 0x2042980 Offset: 0x2040F80 VA: 0x182042980
	public static PlayerTeam Deserialize(Stream stream) { }

	// RVA: 0x2041C50 Offset: 0x2040250 VA: 0x182041C50
	public static PlayerTeam DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2042100 Offset: 0x2040700 VA: 0x182042100
	public static PlayerTeam DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2042590 Offset: 0x2040B90 VA: 0x182042590
	public static PlayerTeam Deserialize(byte[] buffer) { }

	// RVA: 0x2043500 Offset: 0x2041B00 VA: 0x182043500
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2044740 Offset: 0x2042D40 VA: 0x182044740 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2044760 Offset: 0x2042D60 VA: 0x182044760 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam previous) { }

	// RVA: 0x2043860 Offset: 0x2041E60 VA: 0x182043860 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2043040 Offset: 0x2041640 VA: 0x182043040
	public static PlayerTeam Deserialize(byte[] buffer, PlayerTeam instance, bool isDelta = False) { }

	// RVA: 0x2042CE0 Offset: 0x20412E0 VA: 0x182042CE0
	public static PlayerTeam Deserialize(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x2041CD0 Offset: 0x20402D0 VA: 0x182041CD0
	public static PlayerTeam DeserializeLengthDelimited(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x2042190 Offset: 0x2040790 VA: 0x182042190
	public static PlayerTeam DeserializeLength(Stream stream, int length, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x2043D30 Offset: 0x2042330 VA: 0x182043D30
	public static void SerializeDelta(Stream stream, PlayerTeam instance, PlayerTeam previous) { }

	// RVA: 0x2044350 Offset: 0x2042950 VA: 0x182044350
	public static void Serialize(Stream stream, PlayerTeam instance) { }

	// RVA: 0x2044730 Offset: 0x2042D30 VA: 0x182044730
	public byte[] ToProtoBytes() { }

	// RVA: 0x2044740 Offset: 0x2042D40 VA: 0x182044740
	public void ToProto(Stream stream) { }

	// RVA: 0x2044240 Offset: 0x2042840 VA: 0x182044240
	public static byte[] SerializeToBytes(PlayerTeam instance) { }

	// RVA: 0x2044190 Offset: 0x2042790 VA: 0x182044190
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x20538E0 Offset: 0x2051EE0 VA: 0x1820538E0
	public static void ResetToPool(PlayerTeam.TeamMember instance) { }

	// RVA: 0x2053800 Offset: 0x2051E00 VA: 0x182053800
	public void ResetToPool() { }

	// RVA: 0x20534C0 Offset: 0x2051AC0 VA: 0x1820534C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2051C60 Offset: 0x2050260 VA: 0x182051C60
	public void CopyTo(PlayerTeam.TeamMember instance) { }

	// RVA: 0x2051CD0 Offset: 0x20502D0 VA: 0x182051CD0
	public PlayerTeam.TeamMember Copy() { }

	// RVA: 0x2052E50 Offset: 0x2051450 VA: 0x182052E50
	public static PlayerTeam.TeamMember Deserialize(Stream stream) { }

	// RVA: 0x2051D80 Offset: 0x2050380 VA: 0x182051D80
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2052170 Offset: 0x2050770 VA: 0x182052170
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2053130 Offset: 0x2051730 VA: 0x182053130
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer) { }

	// RVA: 0x2053540 Offset: 0x2051B40 VA: 0x182053540
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2054200 Offset: 0x2052800 VA: 0x182054200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2054220 Offset: 0x2052820 VA: 0x182054220 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam.TeamMember previous) { }

	// RVA: 0x20537E0 Offset: 0x2051DE0 VA: 0x1820537E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2052AF0 Offset: 0x20510F0 VA: 0x182052AF0
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer, PlayerTeam.TeamMember instance, bool isDelta = False) { }

	// RVA: 0x2052840 Offset: 0x2050E40 VA: 0x182052840
	public static PlayerTeam.TeamMember Deserialize(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x2051E00 Offset: 0x2050400 VA: 0x182051E00
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x2052500 Offset: 0x2050B00 VA: 0x182052500
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x20539C0 Offset: 0x2051FC0 VA: 0x1820539C0
	public static void SerializeDelta(Stream stream, PlayerTeam.TeamMember instance, PlayerTeam.TeamMember previous) { }

	// RVA: 0x2053F70 Offset: 0x2052570 VA: 0x182053F70
	public static void Serialize(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x20541F0 Offset: 0x20527F0 VA: 0x1820541F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2054200 Offset: 0x2052800 VA: 0x182054200
	public void ToProto(Stream stream) { }

	// RVA: 0x2053E60 Offset: 0x2052460 VA: 0x182053E60
	public static byte[] SerializeToBytes(PlayerTeam.TeamMember instance) { }

	// RVA: 0x2053DB0 Offset: 0x20523B0 VA: 0x182053DB0
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1EB5E10 Offset: 0x1EB4410 VA: 0x181EB5E10
	public static void ResetToPool(PlayerMetabolism instance) { }

	// RVA: 0x1EB5CD0 Offset: 0x1EB42D0 VA: 0x181EB5CD0
	public void ResetToPool() { }

	// RVA: 0x1EB5AC0 Offset: 0x1EB40C0 VA: 0x181EB5AC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB45F0 Offset: 0x1EB2BF0 VA: 0x181EB45F0
	public void CopyTo(PlayerMetabolism instance) { }

	// RVA: 0x1EB4660 Offset: 0x1EB2C60 VA: 0x181EB4660
	public PlayerMetabolism Copy() { }

	// RVA: 0x1EB5920 Offset: 0x1EB3F20 VA: 0x181EB5920
	public static PlayerMetabolism Deserialize(Stream stream) { }

	// RVA: 0x1EB4CC0 Offset: 0x1EB32C0 VA: 0x181EB4CC0
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB52C0 Offset: 0x1EB38C0 VA: 0x181EB52C0
	public static PlayerMetabolism DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB59A0 Offset: 0x1EB3FA0 VA: 0x181EB59A0
	public static PlayerMetabolism Deserialize(byte[] buffer) { }

	// RVA: 0x1EB5C90 Offset: 0x1EB4290 VA: 0x181EB5C90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB69B0 Offset: 0x1EB4FB0 VA: 0x181EB69B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB69D0 Offset: 0x1EB4FD0 VA: 0x181EB69D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerMetabolism previous) { }

	// RVA: 0x1EB5CB0 Offset: 0x1EB42B0 VA: 0x181EB5CB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB5350 Offset: 0x1EB3950 VA: 0x181EB5350
	public static PlayerMetabolism Deserialize(byte[] buffer, PlayerMetabolism instance, bool isDelta = False) { }

	// RVA: 0x1EB5450 Offset: 0x1EB3A50 VA: 0x181EB5450
	public static PlayerMetabolism Deserialize(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB4720 Offset: 0x1EB2D20 VA: 0x181EB4720
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB4D40 Offset: 0x1EB3340 VA: 0x181EB4D40
	public static PlayerMetabolism DeserializeLength(Stream stream, int length, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB5F50 Offset: 0x1EB4550 VA: 0x181EB5F50
	public static void SerializeDelta(Stream stream, PlayerMetabolism instance, PlayerMetabolism previous) { }

	// RVA: 0x1EB66E0 Offset: 0x1EB4CE0 VA: 0x181EB66E0
	public static void Serialize(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x1EB69A0 Offset: 0x1EB4FA0 VA: 0x181EB69A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB69B0 Offset: 0x1EB4FB0 VA: 0x181EB69B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB65D0 Offset: 0x1EB4BD0 VA: 0x181EB65D0
	public static byte[] SerializeToBytes(PlayerMetabolism instance) { }

	// RVA: 0x1EB6520 Offset: 0x1EB4B20 VA: 0x181EB6520
	public static void SerializeLengthDelimited(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PlayerModifiers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6447
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Modifier> modifiers; // 0x18

	// Methods

	// RVA: 0x1EB7910 Offset: 0x1EB5F10 VA: 0x181EB7910
	public static void ResetToPool(PlayerModifiers instance) { }

	// RVA: 0x1EB7AC0 Offset: 0x1EB60C0 VA: 0x181EB7AC0
	public void ResetToPool() { }

	// RVA: 0x1EB7690 Offset: 0x1EB5C90 VA: 0x181EB7690 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB69F0 Offset: 0x1EB4FF0 VA: 0x181EB69F0
	public void CopyTo(PlayerModifiers instance) { }

	// RVA: 0x1EB6B20 Offset: 0x1EB5120 VA: 0x181EB6B20
	public PlayerModifiers Copy() { }

	// RVA: 0x1EB7380 Offset: 0x1EB5980 VA: 0x181EB7380
	public static PlayerModifiers Deserialize(Stream stream) { }

	// RVA: 0x1EB6C90 Offset: 0x1EB5290 VA: 0x181EB6C90
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB6F80 Offset: 0x1EB5580 VA: 0x181EB6F80
	public static PlayerModifiers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB7260 Offset: 0x1EB5860 VA: 0x181EB7260
	public static PlayerModifiers Deserialize(byte[] buffer) { }

	// RVA: 0x1EB78D0 Offset: 0x1EB5ED0 VA: 0x181EB78D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB8200 Offset: 0x1EB6800 VA: 0x181EB8200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB8220 Offset: 0x1EB6820 VA: 0x181EB8220 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerModifiers previous) { }

	// RVA: 0x1EB78F0 Offset: 0x1EB5EF0 VA: 0x181EB78F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB7400 Offset: 0x1EB5A00 VA: 0x181EB7400
	public static PlayerModifiers Deserialize(byte[] buffer, PlayerModifiers instance, bool isDelta = False) { }

	// RVA: 0x1EB7500 Offset: 0x1EB5B00 VA: 0x181EB7500
	public static PlayerModifiers Deserialize(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB6D10 Offset: 0x1EB5310 VA: 0x181EB6D10
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB7010 Offset: 0x1EB5610 VA: 0x181EB7010
	public static PlayerModifiers DeserializeLength(Stream stream, int length, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB7C70 Offset: 0x1EB6270 VA: 0x181EB7C70
	public static void SerializeDelta(Stream stream, PlayerModifiers instance, PlayerModifiers previous) { }

	// RVA: 0x1EB8010 Offset: 0x1EB6610 VA: 0x181EB8010
	public static void Serialize(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x1EB81F0 Offset: 0x1EB67F0 VA: 0x181EB81F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB8200 Offset: 0x1EB6800 VA: 0x181EB8200
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB7F00 Offset: 0x1EB6500 VA: 0x181EB7F00
	public static byte[] SerializeToBytes(PlayerModifiers instance) { }

	// RVA: 0x1EB7E50 Offset: 0x1EB6450 VA: 0x181EB7E50
	public static void SerializeLengthDelimited(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1EAF790 Offset: 0x1EADD90 VA: 0x181EAF790
	public static void ResetToPool(PlayerInventory instance) { }

	// RVA: 0x1EAF8B0 Offset: 0x1EADEB0 VA: 0x181EAF8B0
	public void ResetToPool() { }

	// RVA: 0x1EAF3F0 Offset: 0x1EAD9F0 VA: 0x181EAF3F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAE1E0 Offset: 0x1EAC7E0 VA: 0x181EAE1E0
	public void CopyTo(PlayerInventory instance) { }

	// RVA: 0x1EAE2E0 Offset: 0x1EAC8E0 VA: 0x181EAE2E0
	public PlayerInventory Copy() { }

	// RVA: 0x1EAEA80 Offset: 0x1EAD080 VA: 0x181EAEA80
	public static PlayerInventory Deserialize(Stream stream) { }

	// RVA: 0x1EAE420 Offset: 0x1EACA20 VA: 0x181EAE420
	public static PlayerInventory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAE9F0 Offset: 0x1EACFF0 VA: 0x181EAE9F0
	public static PlayerInventory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAEF40 Offset: 0x1EAD540 VA: 0x181EAEF40
	public static PlayerInventory Deserialize(byte[] buffer) { }

	// RVA: 0x1EAF590 Offset: 0x1EADB90 VA: 0x181EAF590
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB0290 Offset: 0x1EAE890 VA: 0x181EB0290 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB02B0 Offset: 0x1EAE8B0 VA: 0x181EB02B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerInventory previous) { }

	// RVA: 0x1EAF770 Offset: 0x1EADD70 VA: 0x181EAF770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAECA0 Offset: 0x1EAD2A0 VA: 0x181EAECA0
	public static PlayerInventory Deserialize(byte[] buffer, PlayerInventory instance, bool isDelta = False) { }

	// RVA: 0x1EAF210 Offset: 0x1EAD810 VA: 0x181EAF210
	public static PlayerInventory Deserialize(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAE4A0 Offset: 0x1EACAA0 VA: 0x181EAE4A0
	public static PlayerInventory DeserializeLengthDelimited(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAE760 Offset: 0x1EACD60 VA: 0x181EAE760
	public static PlayerInventory DeserializeLength(Stream stream, int length, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAF9D0 Offset: 0x1EADFD0 VA: 0x181EAF9D0
	public static void SerializeDelta(Stream stream, PlayerInventory instance, PlayerInventory previous) { }

	// RVA: 0x1EAFF20 Offset: 0x1EAE520 VA: 0x181EAFF20
	public static void Serialize(Stream stream, PlayerInventory instance) { }

	// RVA: 0x1EB0280 Offset: 0x1EAE880 VA: 0x181EB0280
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB0290 Offset: 0x1EAE890 VA: 0x181EB0290
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAFE10 Offset: 0x1EAE410 VA: 0x181EAFE10
	public static byte[] SerializeToBytes(PlayerInventory instance) { }

	// RVA: 0x1EAFD60 Offset: 0x1EAE360 VA: 0x181EAFD60
	public static void SerializeLengthDelimited(Stream stream, PlayerInventory instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1EB2AB0 Offset: 0x1EB10B0 VA: 0x181EB2AB0
	public static void ResetToPool(PlayerLifeStory instance) { }

	// RVA: 0x1EB2660 Offset: 0x1EB0C60 VA: 0x181EB2660
	public void ResetToPool() { }

	// RVA: 0x1EB25A0 Offset: 0x1EB0BA0 VA: 0x181EB25A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB02D0 Offset: 0x1EAE8D0 VA: 0x181EB02D0
	public void CopyTo(PlayerLifeStory instance) { }

	// RVA: 0x1EB0750 Offset: 0x1EAED50 VA: 0x181EB0750
	public PlayerLifeStory Copy() { }

	// RVA: 0x1EB1AC0 Offset: 0x1EB00C0 VA: 0x181EB1AC0
	public static PlayerLifeStory Deserialize(Stream stream) { }

	// RVA: 0x1EB10D0 Offset: 0x1EAF6D0 VA: 0x181EB10D0
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB1A30 Offset: 0x1EB0030 VA: 0x181EB1A30
	public static PlayerLifeStory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB2480 Offset: 0x1EB0A80 VA: 0x181EB2480
	public static PlayerLifeStory Deserialize(byte[] buffer) { }

	// RVA: 0x1EB2620 Offset: 0x1EB0C20 VA: 0x181EB2620
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB45B0 Offset: 0x1EB2BB0 VA: 0x181EB45B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB45D0 Offset: 0x1EB2BD0 VA: 0x181EB45D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory previous) { }

	// RVA: 0x1EB2640 Offset: 0x1EB0C40 VA: 0x181EB2640 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB1B40 Offset: 0x1EB0140 VA: 0x181EB1B40
	public static PlayerLifeStory Deserialize(byte[] buffer, PlayerLifeStory instance, bool isDelta = False) { }

	// RVA: 0x1EB1C40 Offset: 0x1EB0240 VA: 0x181EB1C40
	public static PlayerLifeStory Deserialize(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB07D0 Offset: 0x1EAEDD0 VA: 0x181EB07D0
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB1150 Offset: 0x1EAF750 VA: 0x181EB1150
	public static PlayerLifeStory DeserializeLength(Stream stream, int length, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB2F00 Offset: 0x1EB1500 VA: 0x181EB2F00
	public static void SerializeDelta(Stream stream, PlayerLifeStory instance, PlayerLifeStory previous) { }

	// RVA: 0x1EB3D10 Offset: 0x1EB2310 VA: 0x181EB3D10
	public static void Serialize(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x1EB45A0 Offset: 0x1EB2BA0 VA: 0x181EB45A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB45B0 Offset: 0x1EB2BB0 VA: 0x181EB45B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB3C00 Offset: 0x1EB2200 VA: 0x181EB3C00
	public static byte[] SerializeToBytes(PlayerLifeStory instance) { }

	// RVA: 0x1EB3B50 Offset: 0x1EB2150 VA: 0x181EB3B50
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1EA2490 Offset: 0x1EA0A90 VA: 0x181EA2490
	public static void ResetToPool(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA25C0 Offset: 0x1EA0BC0 VA: 0x181EA25C0
	public void ResetToPool() { }

	// RVA: 0x1EA2140 Offset: 0x1EA0740 VA: 0x181EA2140 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA0AE0 Offset: 0x1E9F0E0 VA: 0x181EA0AE0
	public void CopyTo(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA0B50 Offset: 0x1E9F150 VA: 0x181EA0B50
	public PlayerLifeStory.DeathInfo Copy() { }

	// RVA: 0x1EA17C0 Offset: 0x1E9FDC0 VA: 0x181EA17C0
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream) { }

	// RVA: 0x1EA0FA0 Offset: 0x1E9F5A0 VA: 0x181EA0FA0
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA1390 Offset: 0x1E9F990 VA: 0x181EA1390
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA1D80 Offset: 0x1EA0380 VA: 0x181EA1D80
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1EA21C0 Offset: 0x1EA07C0 VA: 0x181EA21C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA2E20 Offset: 0x1EA1420 VA: 0x181EA2E20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA2E40 Offset: 0x1EA1440 VA: 0x181EA2E40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1EA2470 Offset: 0x1EA0A70 VA: 0x181EA2470 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA1420 Offset: 0x1E9FA20 VA: 0x181EA1420
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer, PlayerLifeStory.DeathInfo instance, bool isDelta = False) { }

	// RVA: 0x1EA1AC0 Offset: 0x1EA00C0 VA: 0x181EA1AC0
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA0C10 Offset: 0x1E9F210 VA: 0x181EA0C10
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA1020 Offset: 0x1E9F620 VA: 0x181EA1020
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA26F0 Offset: 0x1EA0CF0 VA: 0x181EA26F0
	public static void SerializeDelta(Stream stream, PlayerLifeStory.DeathInfo instance, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1EA2BC0 Offset: 0x1EA11C0 VA: 0x181EA2BC0
	public static void Serialize(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA2E10 Offset: 0x1EA1410 VA: 0x181EA2E10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA2E20 Offset: 0x1EA1420 VA: 0x181EA2E20
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA2AB0 Offset: 0x1EA10B0 VA: 0x181EA2AB0
	public static byte[] SerializeToBytes(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA2A00 Offset: 0x1EA1000 VA: 0x181EA2A00
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1EB9540 Offset: 0x1EB7B40 VA: 0x181EB9540
	public static void ResetToPool(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB9490 Offset: 0x1EB7A90 VA: 0x181EB9490
	public void ResetToPool() { }

	// RVA: 0x1EB9230 Offset: 0x1EB7830 VA: 0x181EB9230 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB8240 Offset: 0x1EB6840 VA: 0x181EB8240
	public void CopyTo(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB8290 Offset: 0x1EB6890 VA: 0x181EB8290
	public PlayerLifeStory.WeaponStats Copy() { }

	// RVA: 0x1EB8E70 Offset: 0x1EB7470 VA: 0x181EB8E70
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream) { }

	// RVA: 0x1EB85B0 Offset: 0x1EB6BB0 VA: 0x181EB85B0
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB88A0 Offset: 0x1EB6EA0 VA: 0x181EB88A0
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB8930 Offset: 0x1EB6F30 VA: 0x181EB8930
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer) { }

	// RVA: 0x1EB92B0 Offset: 0x1EB78B0 VA: 0x181EB92B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB9B70 Offset: 0x1EB8170 VA: 0x181EB9B70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB9B90 Offset: 0x1EB8190 VA: 0x181EB9B90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EB9470 Offset: 0x1EB7A70 VA: 0x181EB9470 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB8BE0 Offset: 0x1EB71E0 VA: 0x181EB8BE0
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer, PlayerLifeStory.WeaponStats instance, bool isDelta = False) { }

	// RVA: 0x1EB9070 Offset: 0x1EB7670 VA: 0x181EB9070
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB8320 Offset: 0x1EB6920 VA: 0x181EB8320
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB8630 Offset: 0x1EB6C30 VA: 0x181EB8630
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB95F0 Offset: 0x1EB7BF0 VA: 0x181EB95F0
	public static void SerializeDelta(Stream stream, PlayerLifeStory.WeaponStats instance, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EB99D0 Offset: 0x1EB7FD0 VA: 0x181EB99D0
	public static void Serialize(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB9B60 Offset: 0x1EB8160 VA: 0x181EB9B60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB9B70 Offset: 0x1EB8170 VA: 0x181EB9B70
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB98C0 Offset: 0x1EB7EC0 VA: 0x181EB98C0
	public static byte[] SerializeToBytes(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB9810 Offset: 0x1EB7E10 VA: 0x181EB9810
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PlayerLifeStory.GenericStat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6459
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string key; // 0x18
	public int value; // 0x20

	// Methods

	// RVA: 0x1EA5180 Offset: 0x1EA3780 VA: 0x181EA5180
	public static void ResetToPool(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA50E0 Offset: 0x1EA36E0 VA: 0x181EA50E0
	public void ResetToPool() { }

	// RVA: 0x1EA5020 Offset: 0x1EA3620 VA: 0x181EA5020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA42F0 Offset: 0x1EA28F0 VA: 0x181EA42F0
	public void CopyTo(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA4330 Offset: 0x1EA2930 VA: 0x181EA4330
	public PlayerLifeStory.GenericStat Copy() { }

	// RVA: 0x1EA4970 Offset: 0x1EA2F70 VA: 0x181EA4970
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream) { }

	// RVA: 0x1EA43C0 Offset: 0x1EA29C0 VA: 0x181EA43C0
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA48E0 Offset: 0x1EA2EE0 VA: 0x181EA48E0
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA4DB0 Offset: 0x1EA33B0 VA: 0x181EA4DB0
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer) { }

	// RVA: 0x1EA50A0 Offset: 0x1EA36A0 VA: 0x181EA50A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA5710 Offset: 0x1EA3D10 VA: 0x181EA5710 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA5730 Offset: 0x1EA3D30 VA: 0x181EA5730 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1EA50C0 Offset: 0x1EA36C0 VA: 0x181EA50C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA4B30 Offset: 0x1EA3130 VA: 0x181EA4B30
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer, PlayerLifeStory.GenericStat instance, bool isDelta = False) { }

	// RVA: 0x1EA4C30 Offset: 0x1EA3230 VA: 0x181EA4C30
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA4440 Offset: 0x1EA2A40 VA: 0x181EA4440
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA46A0 Offset: 0x1EA2CA0 VA: 0x181EA46A0
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA5220 Offset: 0x1EA3820 VA: 0x181EA5220
	public static void SerializeDelta(Stream stream, PlayerLifeStory.GenericStat instance, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1EA55A0 Offset: 0x1EA3BA0 VA: 0x181EA55A0
	public static void Serialize(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA5700 Offset: 0x1EA3D00 VA: 0x181EA5700
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA5710 Offset: 0x1EA3D10 VA: 0x181EA5710
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA5490 Offset: 0x1EA3A90 VA: 0x181EA5490
	public static byte[] SerializeToBytes(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA53E0 Offset: 0x1EA39E0 VA: 0x181EA53E0
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x2040ED0 Offset: 0x203F4D0 VA: 0x182040ED0
	public static void ResetToPool(PlayerState instance) { }

	// RVA: 0x2040DA0 Offset: 0x203F3A0 VA: 0x182040DA0
	public void ResetToPool() { }

	// RVA: 0x20409A0 Offset: 0x203EFA0 VA: 0x1820409A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203F5C0 Offset: 0x203DBC0 VA: 0x18203F5C0
	public void CopyTo(PlayerState instance) { }

	// RVA: 0x203F6B0 Offset: 0x203DCB0 VA: 0x18203F6B0
	public PlayerState Copy() { }

	// RVA: 0x2040220 Offset: 0x203E820 VA: 0x182040220
	public static PlayerState Deserialize(Stream stream) { }

	// RVA: 0x203FB10 Offset: 0x203E110 VA: 0x18203FB10
	public static PlayerState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203FB90 Offset: 0x203E190 VA: 0x18203FB90
	public static PlayerState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203FF00 Offset: 0x203E500 VA: 0x18203FF00
	public static PlayerState Deserialize(byte[] buffer) { }

	// RVA: 0x2040B50 Offset: 0x203F150 VA: 0x182040B50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2041950 Offset: 0x203FF50 VA: 0x182041950 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2041970 Offset: 0x203FF70 VA: 0x182041970 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerState previous) { }

	// RVA: 0x2040D80 Offset: 0x203F380 VA: 0x182040D80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2040480 Offset: 0x203EA80 VA: 0x182040480
	public static PlayerState Deserialize(byte[] buffer, PlayerState instance, bool isDelta = False) { }

	// RVA: 0x2040770 Offset: 0x203ED70 VA: 0x182040770
	public static PlayerState Deserialize(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x203F800 Offset: 0x203DE00 VA: 0x18203F800
	public static PlayerState DeserializeLengthDelimited(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x203FC20 Offset: 0x203E220 VA: 0x18203FC20
	public static PlayerState DeserializeLength(Stream stream, int length, PlayerState instance, bool isDelta) { }

	// RVA: 0x2041000 Offset: 0x203F600 VA: 0x182041000
	public static void SerializeDelta(Stream stream, PlayerState instance, PlayerState previous) { }

	// RVA: 0x20415A0 Offset: 0x203FBA0 VA: 0x1820415A0
	public static void Serialize(Stream stream, PlayerState instance) { }

	// RVA: 0x2041940 Offset: 0x203FF40 VA: 0x182041940
	public byte[] ToProtoBytes() { }

	// RVA: 0x2041950 Offset: 0x203FF50 VA: 0x182041950
	public void ToProto(Stream stream) { }

	// RVA: 0x2041490 Offset: 0x203FA90 VA: 0x182041490
	public static byte[] SerializeToBytes(PlayerState instance) { }

	// RVA: 0x20413E0 Offset: 0x203F9E0 VA: 0x1820413E0
	public static void SerializeLengthDelimited(Stream stream, PlayerState instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PlayerNameID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6463
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string username; // 0x18
	public ulong userid; // 0x20

	// Methods

	// RVA: 0x2038000 Offset: 0x2036600 VA: 0x182038000
	public static void ResetToPool(PlayerNameID instance) { }

	// RVA: 0x2037F50 Offset: 0x2036550 VA: 0x182037F50
	public void ResetToPool() { }

	// RVA: 0x2037DF0 Offset: 0x20363F0 VA: 0x182037DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAD6F0 Offset: 0x1DABCF0 VA: 0x181DAD6F0
	public void CopyTo(PlayerNameID instance) { }

	// RVA: 0x20370F0 Offset: 0x20356F0 VA: 0x1820370F0
	public PlayerNameID Copy() { }

	// RVA: 0x2037B30 Offset: 0x2036130 VA: 0x182037B30
	public static PlayerNameID Deserialize(Stream stream) { }

	// RVA: 0x2037180 Offset: 0x2035780 VA: 0x182037180
	public static PlayerNameID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20376A0 Offset: 0x2035CA0 VA: 0x1820376A0
	public static PlayerNameID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20378B0 Offset: 0x2035EB0 VA: 0x1820378B0
	public static PlayerNameID Deserialize(byte[] buffer) { }

	// RVA: 0x2037F10 Offset: 0x2036510 VA: 0x182037F10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20385A0 Offset: 0x2036BA0 VA: 0x1820385A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20385C0 Offset: 0x2036BC0 VA: 0x1820385C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerNameID previous) { }

	// RVA: 0x2037F30 Offset: 0x2036530 VA: 0x182037F30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2037CF0 Offset: 0x20362F0 VA: 0x182037CF0
	public static PlayerNameID Deserialize(byte[] buffer, PlayerNameID instance, bool isDelta = False) { }

	// RVA: 0x2037730 Offset: 0x2035D30 VA: 0x182037730
	public static PlayerNameID Deserialize(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2037200 Offset: 0x2035800 VA: 0x182037200
	public static PlayerNameID DeserializeLengthDelimited(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2037460 Offset: 0x2035A60 VA: 0x182037460
	public static PlayerNameID DeserializeLength(Stream stream, int length, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x20380B0 Offset: 0x20366B0 VA: 0x1820380B0
	public static void SerializeDelta(Stream stream, PlayerNameID instance, PlayerNameID previous) { }

	// RVA: 0x2038430 Offset: 0x2036A30 VA: 0x182038430
	public static void Serialize(Stream stream, PlayerNameID instance) { }

	// RVA: 0x2038590 Offset: 0x2036B90 VA: 0x182038590
	public byte[] ToProtoBytes() { }

	// RVA: 0x20385A0 Offset: 0x2036BA0 VA: 0x1820385A0
	public void ToProto(Stream stream) { }

	// RVA: 0x2038320 Offset: 0x2036920 VA: 0x182038320
	public static byte[] SerializeToBytes(PlayerNameID instance) { }

	// RVA: 0x2038270 Offset: 0x2036870 VA: 0x182038270
	public static void SerializeLengthDelimited(Stream stream, PlayerNameID instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x2045DE0 Offset: 0x20443E0 VA: 0x182045DE0
	public static void ResetToPool(PlayerUpdateLoot instance) { }

	// RVA: 0x2045FB0 Offset: 0x20445B0 VA: 0x182045FB0
	public void ResetToPool() { }

	// RVA: 0x2045B30 Offset: 0x2044130 VA: 0x182045B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2044780 Offset: 0x2042D80 VA: 0x182044780
	public void CopyTo(PlayerUpdateLoot instance) { }

	// RVA: 0x20448B0 Offset: 0x2042EB0 VA: 0x1820448B0
	public PlayerUpdateLoot Copy() { }

	// RVA: 0x2045100 Offset: 0x2043700 VA: 0x182045100
	public static PlayerUpdateLoot Deserialize(Stream stream) { }

	// RVA: 0x2044D20 Offset: 0x2043320 VA: 0x182044D20
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2045070 Offset: 0x2043670 VA: 0x182045070
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2045850 Offset: 0x2043E50 VA: 0x182045850
	public static PlayerUpdateLoot Deserialize(byte[] buffer) { }

	// RVA: 0x2045BB0 Offset: 0x20441B0 VA: 0x182045BB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2046820 Offset: 0x2044E20 VA: 0x182046820 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2046840 Offset: 0x2044E40 VA: 0x182046840 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerUpdateLoot previous) { }

	// RVA: 0x2045DC0 Offset: 0x20443C0 VA: 0x182045DC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2045560 Offset: 0x2043B60 VA: 0x182045560
	public static PlayerUpdateLoot Deserialize(byte[] buffer, PlayerUpdateLoot instance, bool isDelta = False) { }

	// RVA: 0x2045340 Offset: 0x2043940 VA: 0x182045340
	public static PlayerUpdateLoot Deserialize(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2044A30 Offset: 0x2043030 VA: 0x182044A30
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2044DA0 Offset: 0x20433A0 VA: 0x182044DA0
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2046180 Offset: 0x2044780 VA: 0x182046180
	public static void SerializeDelta(Stream stream, PlayerUpdateLoot instance, PlayerUpdateLoot previous) { }

	// RVA: 0x20465D0 Offset: 0x2044BD0 VA: 0x1820465D0
	public static void Serialize(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x2046810 Offset: 0x2044E10 VA: 0x182046810
	public byte[] ToProtoBytes() { }

	// RVA: 0x2046820 Offset: 0x2044E20 VA: 0x182046820
	public void ToProto(Stream stream) { }

	// RVA: 0x20464C0 Offset: 0x2044AC0 VA: 0x1820464C0
	public static byte[] SerializeToBytes(PlayerUpdateLoot instance) { }

	// RVA: 0x2046410 Offset: 0x2044A10 VA: 0x182046410
	public static void SerializeLengthDelimited(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PlayerAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6484
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Attack attack; // 0x18
	public int projectileID; // 0x20

	// Methods

	// RVA: 0x1EAC960 Offset: 0x1EAAF60 VA: 0x181EAC960
	public static void ResetToPool(PlayerAttack instance) { }

	// RVA: 0x1EACA10 Offset: 0x1EAB010 VA: 0x181EACA10
	public void ResetToPool() { }

	// RVA: 0x1EAC7F0 Offset: 0x1EAADF0 VA: 0x181EAC7F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EABA10 Offset: 0x1EAA010 VA: 0x181EABA10
	public void CopyTo(PlayerAttack instance) { }

	// RVA: 0x1EABAA0 Offset: 0x1EAA0A0 VA: 0x181EABAA0
	public PlayerAttack Copy() { }

	// RVA: 0x1EAC230 Offset: 0x1EAA830 VA: 0x181EAC230
	public static PlayerAttack Deserialize(Stream stream) { }

	// RVA: 0x1EABB70 Offset: 0x1EAA170 VA: 0x181EABB70
	public static PlayerAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAC0A0 Offset: 0x1EAA6A0 VA: 0x181EAC0A0
	public static PlayerAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAC580 Offset: 0x1EAAB80 VA: 0x181EAC580
	public static PlayerAttack Deserialize(byte[] buffer) { }

	// RVA: 0x1EAC920 Offset: 0x1EAAF20 VA: 0x181EAC920
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAD0B0 Offset: 0x1EAB6B0 VA: 0x181EAD0B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAD0D0 Offset: 0x1EAB6D0 VA: 0x181EAD0D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerAttack previous) { }

	// RVA: 0x1EAC940 Offset: 0x1EAAF40 VA: 0x181EAC940 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAC130 Offset: 0x1EAA730 VA: 0x181EAC130
	public static PlayerAttack Deserialize(byte[] buffer, PlayerAttack instance, bool isDelta = False) { }

	// RVA: 0x1EAC3F0 Offset: 0x1EAA9F0 VA: 0x181EAC3F0
	public static PlayerAttack Deserialize(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EABBF0 Offset: 0x1EAA1F0 VA: 0x181EABBF0
	public static PlayerAttack DeserializeLengthDelimited(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EABE60 Offset: 0x1EAA460 VA: 0x181EABE60
	public static PlayerAttack DeserializeLength(Stream stream, int length, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EACAC0 Offset: 0x1EAB0C0 VA: 0x181EACAC0
	public static void SerializeDelta(Stream stream, PlayerAttack instance, PlayerAttack previous) { }

	// RVA: 0x1EACEB0 Offset: 0x1EAB4B0 VA: 0x181EACEB0
	public static void Serialize(Stream stream, PlayerAttack instance) { }

	// RVA: 0x1EAD0A0 Offset: 0x1EAB6A0 VA: 0x181EAD0A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAD0B0 Offset: 0x1EAB6B0 VA: 0x181EAD0B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EACDA0 Offset: 0x1EAB3A0 VA: 0x181EACDA0
	public static byte[] SerializeToBytes(PlayerAttack instance) { }

	// RVA: 0x1EACCF0 Offset: 0x1EAB2F0 VA: 0x181EACCF0
	public static void SerializeLengthDelimited(Stream stream, PlayerAttack instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x2039C30 Offset: 0x2038230 VA: 0x182039C30
	public static void ResetToPool(PlayerProjectileAttack instance) { }

	// RVA: 0x2039D10 Offset: 0x2038310 VA: 0x182039D10
	public void ResetToPool() { }

	// RVA: 0x2039890 Offset: 0x2037E90 VA: 0x182039890 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20385E0 Offset: 0x2036BE0 VA: 0x1820385E0
	public void CopyTo(PlayerProjectileAttack instance) { }

	// RVA: 0x2038680 Offset: 0x2036C80 VA: 0x182038680
	public PlayerProjectileAttack Copy() { }

	// RVA: 0x2039120 Offset: 0x2037720 VA: 0x182039120
	public static PlayerProjectileAttack Deserialize(Stream stream) { }

	// RVA: 0x2038A50 Offset: 0x2037050 VA: 0x182038A50
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2038AD0 Offset: 0x20370D0 VA: 0x182038AD0
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2038E20 Offset: 0x2037420 VA: 0x182038E20
	public static PlayerProjectileAttack Deserialize(byte[] buffer) { }

	// RVA: 0x20399F0 Offset: 0x2037FF0 VA: 0x1820399F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203A6C0 Offset: 0x2038CC0 VA: 0x18203A6C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203A6E0 Offset: 0x2038CE0 VA: 0x18203A6E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileAttack previous) { }

	// RVA: 0x2039C10 Offset: 0x2038210 VA: 0x182039C10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20395B0 Offset: 0x2037BB0 VA: 0x1820395B0
	public static PlayerProjectileAttack Deserialize(byte[] buffer, PlayerProjectileAttack instance, bool isDelta = False) { }

	// RVA: 0x2039380 Offset: 0x2037980 VA: 0x182039380
	public static PlayerProjectileAttack Deserialize(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2038760 Offset: 0x2036D60 VA: 0x182038760
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2038B60 Offset: 0x2037160 VA: 0x182038B60
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2039DF0 Offset: 0x20383F0 VA: 0x182039DF0
	public static void SerializeDelta(Stream stream, PlayerProjectileAttack instance, PlayerProjectileAttack previous) { }

	// RVA: 0x203A3D0 Offset: 0x20389D0 VA: 0x18203A3D0
	public static void Serialize(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x203A6B0 Offset: 0x2038CB0 VA: 0x18203A6B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x203A6C0 Offset: 0x2038CC0 VA: 0x18203A6C0
	public void ToProto(Stream stream) { }

	// RVA: 0x203A2C0 Offset: 0x20388C0 VA: 0x18203A2C0
	public static byte[] SerializeToBytes(PlayerProjectileAttack instance) { }

	// RVA: 0x203A210 Offset: 0x2038810 VA: 0x18203A210
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x203C8C0 Offset: 0x203AEC0 VA: 0x18203C8C0
	public static void ResetToPool(PlayerProjectileRicochet instance) { }

	// RVA: 0x203C7F0 Offset: 0x203ADF0 VA: 0x18203C7F0
	public void ResetToPool() { }

	// RVA: 0x203C110 Offset: 0x203A710 VA: 0x18203C110 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203A700 Offset: 0x2038D00 VA: 0x18203A700
	public void CopyTo(PlayerProjectileRicochet instance) { }

	// RVA: 0x203A760 Offset: 0x2038D60 VA: 0x18203A760
	public PlayerProjectileRicochet Copy() { }

	// RVA: 0x203BB30 Offset: 0x203A130 VA: 0x18203BB30
	public static PlayerProjectileRicochet Deserialize(Stream stream) { }

	// RVA: 0x203A820 Offset: 0x2038E20 VA: 0x18203A820
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203AEE0 Offset: 0x20394E0 VA: 0x18203AEE0
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203B560 Offset: 0x2039B60 VA: 0x18203B560
	public static PlayerProjectileRicochet Deserialize(byte[] buffer) { }

	// RVA: 0x203C270 Offset: 0x203A870 VA: 0x18203C270
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203D660 Offset: 0x203BC60 VA: 0x18203D660 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203D680 Offset: 0x203BC80 VA: 0x18203D680 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileRicochet previous) { }

	// RVA: 0x203C4E0 Offset: 0x203AAE0 VA: 0x18203C4E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203BDD0 Offset: 0x203A3D0 VA: 0x18203BDD0
	public static PlayerProjectileRicochet Deserialize(byte[] buffer, PlayerProjectileRicochet instance, bool isDelta = False) { }

	// RVA: 0x203B8C0 Offset: 0x2039EC0 VA: 0x18203B8C0
	public static PlayerProjectileRicochet Deserialize(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203ABA0 Offset: 0x20391A0 VA: 0x18203ABA0
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203B240 Offset: 0x2039840 VA: 0x18203B240
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203C990 Offset: 0x203AF90 VA: 0x18203C990
	public static void SerializeDelta(Stream stream, PlayerProjectileRicochet instance, PlayerProjectileRicochet previous) { }

	// RVA: 0x203D240 Offset: 0x203B840 VA: 0x18203D240
	public static void Serialize(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x203D650 Offset: 0x203BC50 VA: 0x18203D650
	public byte[] ToProtoBytes() { }

	// RVA: 0x203D660 Offset: 0x203BC60 VA: 0x18203D660
	public void ToProto(Stream stream) { }

	// RVA: 0x203D130 Offset: 0x203B730 VA: 0x18203D130
	public static byte[] SerializeToBytes(PlayerProjectileRicochet instance) { }

	// RVA: 0x203D080 Offset: 0x203B680 VA: 0x18203D080
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x203EB70 Offset: 0x203D170 VA: 0x18203EB70
	public static void ResetToPool(PlayerProjectileUpdate instance) { }

	// RVA: 0x203EC20 Offset: 0x203D220 VA: 0x18203EC20
	public void ResetToPool() { }

	// RVA: 0x203E810 Offset: 0x203CE10 VA: 0x18203E810 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203D6A0 Offset: 0x203BCA0 VA: 0x18203D6A0
	public void CopyTo(PlayerProjectileUpdate instance) { }

	// RVA: 0x203D6E0 Offset: 0x203BCE0 VA: 0x18203D6E0
	public PlayerProjectileUpdate Copy() { }

	// RVA: 0x203DE10 Offset: 0x203C410 VA: 0x18203DE10
	public static PlayerProjectileUpdate Deserialize(Stream stream) { }

	// RVA: 0x203D780 Offset: 0x203BD80 VA: 0x18203D780
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203DD80 Offset: 0x203C380 VA: 0x18203DD80
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203E050 Offset: 0x203C650 VA: 0x18203E050
	public static PlayerProjectileUpdate Deserialize(byte[] buffer) { }

	// RVA: 0x203E940 Offset: 0x203CF40 VA: 0x18203E940
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203F580 Offset: 0x203DB80 VA: 0x18203F580 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203F5A0 Offset: 0x203DBA0 VA: 0x18203F5A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileUpdate previous) { }

	// RVA: 0x203EB50 Offset: 0x203D150 VA: 0x18203EB50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203E540 Offset: 0x203CB40 VA: 0x18203E540
	public static PlayerProjectileUpdate Deserialize(byte[] buffer, PlayerProjectileUpdate instance, bool isDelta = False) { }

	// RVA: 0x203E330 Offset: 0x203C930 VA: 0x18203E330
	public static PlayerProjectileUpdate Deserialize(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203D800 Offset: 0x203BE00 VA: 0x18203D800
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203DAD0 Offset: 0x203C0D0 VA: 0x18203DAD0
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203ECD0 Offset: 0x203D2D0 VA: 0x18203ECD0
	public static void SerializeDelta(Stream stream, PlayerProjectileUpdate instance, PlayerProjectileUpdate previous) { }

	// RVA: 0x203F2E0 Offset: 0x203D8E0 VA: 0x18203F2E0
	public static void Serialize(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x203F570 Offset: 0x203DB70 VA: 0x18203F570
	public byte[] ToProtoBytes() { }

	// RVA: 0x203F580 Offset: 0x203DB80 VA: 0x18203F580
	public void ToProto(Stream stream) { }

	// RVA: 0x203F1D0 Offset: 0x203D7D0 VA: 0x18203F1D0
	public static byte[] SerializeToBytes(PlayerProjectileUpdate instance) { }

	// RVA: 0x203F120 Offset: 0x203D720 VA: 0x18203F120
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PlayerDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6544
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EADC30 Offset: 0x1EAC230 VA: 0x181EADC30
	public static void ResetToPool(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EADBB0 Offset: 0x1EAC1B0 VA: 0x181EADBB0
	public void ResetToPool() { }

	// RVA: 0x1EADA80 Offset: 0x1EAC080 VA: 0x181EADA80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EAD0F0 Offset: 0x1EAB6F0 VA: 0x181EAD0F0
	public PlayerDetectedAIEventData Copy() { }

	// RVA: 0x1EADA00 Offset: 0x1EAC000 VA: 0x181EADA00
	public static PlayerDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EAD160 Offset: 0x1EAB760 VA: 0x181EAD160
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAD600 Offset: 0x1EABC00 VA: 0x181EAD600
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAD8E0 Offset: 0x1EABEE0 VA: 0x181EAD8E0
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EADB70 Offset: 0x1EAC170 VA: 0x181EADB70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAE080 Offset: 0x1EAC680 VA: 0x181EAE080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAE0A0 Offset: 0x1EAC6A0 VA: 0x181EAE0A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EADB90 Offset: 0x1EAC190 VA: 0x181EADB90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAD7E0 Offset: 0x1EABDE0 VA: 0x181EAD7E0
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer, PlayerDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EAD690 Offset: 0x1EABC90 VA: 0x181EAD690
	public static PlayerDetectedAIEventData Deserialize(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EAD1E0 Offset: 0x1EAB7E0 VA: 0x181EAD1E0
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EAD400 Offset: 0x1EABA00 VA: 0x181EAD400
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EADCB0 Offset: 0x1EAC2B0 VA: 0x181EADCB0
	public static void SerializeDelta(Stream stream, PlayerDetectedAIEventData instance, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EADF90 Offset: 0x1EAC590 VA: 0x181EADF90
	public static void Serialize(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EAE070 Offset: 0x1EAC670 VA: 0x181EAE070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAE080 Offset: 0x1EAC680 VA: 0x181EAE080
	public void ToProto(Stream stream) { }

	// RVA: 0x1EADE80 Offset: 0x1EAC480 VA: 0x181EADE80
	public static byte[] SerializeToBytes(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EADDD0 Offset: 0x1EAC3D0 VA: 0x181EADDD0
	public static void SerializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PlayerIdleAnimationRandomiser : StateMachineBehaviour // TypeDefIndex: 8270
{	// Fields
	public int MaxValue; // 0x18
	public static int Param_Random; // 0x0
	private TimeSince lastRandomisation; // 0x1C

	// Methods

	// RVA: 0xC327D0 Offset: 0xC30DD0 VA: 0x180C327D0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0xC32A00 Offset: 0xC31000 VA: 0x180C32A00
	public void .ctor() { }

	// RVA: 0xC329B0 Offset: 0xC30FB0 VA: 0x180C329B0
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

	// RVA: 0x7124B0 Offset: 0x710AB0 VA: 0x1807124B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x72CD70 Offset: 0x72B370 VA: 0x18072CD70 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x71A620 Offset: 0x718C20 VA: 0x18071A620 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x708320 Offset: 0x706920 VA: 0x180708320 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x72D2B0 Offset: 0x72B8B0 VA: 0x18072D2B0 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	[BaseEntity.Menu] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.Description] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.Icon] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.ShowIf] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	// RVA: 0x719500 Offset: 0x717B00 VA: 0x180719500
	public void Menu_LootPlayer(BasePlayer player) { }

	// RVA: 0x7194E0 Offset: 0x717AE0 VA: 0x1807194E0
	public bool Menu_LootPlayer_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x724ED0 Offset: 0x7234D0 VA: 0x180724ED0
	private void RPC_OpenLootPanel(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x723240 Offset: 0x721840 VA: 0x180723240
	private void PlayOpenSound() { }

	// RVA: 0x7153D0 Offset: 0x7139D0 VA: 0x1807153D0
	public bool InFirstPersonMode() { }

	// RVA: 0x72B060 Offset: 0x729660 VA: 0x18072B060
	public void UpdateViewMode() { }

	// RVA: 0x72D420 Offset: 0x72BA20 VA: 0x18072D420
	internal BasePlayer.CameraMode get_idealViewMode() { }

	// RVA: 0x72D880 Offset: 0x72BE80 VA: 0x18072D880
	internal bool get_shouldDrawBody() { }

	// RVA: 0x722D00 Offset: 0x721300 VA: 0x180722D00 Slot: 146
	public virtual void OnViewModeChanged() { }

	// RVA: 0x719570 Offset: 0x717B70 VA: 0x180719570
	public void ModifyCamera() { }

	[BaseEntity.Menu] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.Description] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.Icon] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.ShowIf] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	// RVA: 0x7194A0 Offset: 0x717AA0 VA: 0x1807194A0
	public void Menu_AssistPlayer(BasePlayer player) { }

	// RVA: 0x719460 Offset: 0x717A60 VA: 0x180719460
	public void Menu_AssistPlayer_TimeStart() { }

	// RVA: 0x7191D0 Offset: 0x7177D0 VA: 0x1807191D0
	public bool Menu_AssistPlayer_ShowIf(BasePlayer player) { }

	// RVA: 0x72D830 Offset: 0x72BE30 VA: 0x18072D830
	public GameObject get_lookingAt() { }

	// RVA: 0x72D7C0 Offset: 0x72BDC0 VA: 0x18072D7C0
	public BaseEntity get_lookingAtEntity() { }

	// RVA: 0x72D770 Offset: 0x72BD70 VA: 0x18072D770
	public Collider get_lookingAtCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D810 Offset: 0x72BE10 VA: 0x18072D810
	public Vector3 get_lookingAtPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72DC40 Offset: 0x72C240 VA: 0x18072DC40
	private void set_lookingAtPoint(Vector3 value) { }

	// RVA: 0x711800 Offset: 0x70FE00 VA: 0x180711800 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x7122B0 Offset: 0x7108B0 VA: 0x1807122B0 Slot: 57
	public override Vector3 GetLocalVelocityClient() { }

	// RVA: 0x709E20 Offset: 0x708420 VA: 0x180709E20 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x70EB40 Offset: 0x70D140 VA: 0x18070EB40
	private void CreatePlayerModel() { }

	// RVA: 0x70E990 Offset: 0x70CF90 VA: 0x18070E990
	private void CreatePlayerCollision() { }

	// RVA: 0x70F060 Offset: 0x70D660 VA: 0x18070F060
	private void CreatePlayerMovement() { }

	// RVA: 0x715420 Offset: 0x713A20 VA: 0x180715420
	internal void InitLocalPlayer() { }

	// RVA: 0x715700 Offset: 0x713D00 VA: 0x180715700
	internal void InitRemotePlayer() { }

	// RVA: 0x714A80 Offset: 0x713080 VA: 0x180714A80
	public bool HasLocalControls() { }

	// RVA: 0x727C00 Offset: 0x726200 VA: 0x180727C00 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x727CB0 Offset: 0x7262B0 VA: 0x180727CB0 Slot: 60
	public override void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x70F520 Offset: 0x70DB20 VA: 0x18070F520 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7239B0 Offset: 0x721FB0 VA: 0x1807239B0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x719F50 Offset: 0x718550 VA: 0x180719F50
	private void OnFirstWakeUp() { }

	// RVA: 0x72D2E0 Offset: 0x72B8E0 VA: 0x18072D2E0
	public float get_TimeAwake() { }

	// RVA: 0x707920 Offset: 0x705F20 VA: 0x180707920
	public void CL_ClothingChanged() { }

	// RVA: 0x710C10 Offset: 0x70F210 VA: 0x180710C10
	public void ForceRebuild() { }

	// RVA: 0x725370 Offset: 0x723970 VA: 0x180725370
	internal void RebuildWorldModel(PlayerModel pModel) { }

	// RVA: 0x727390 Offset: 0x725990 VA: 0x180727390
	private void SetDefaultFootstepEffects(PlayerModel pModel) { }

	// RVA: 0x722780 Offset: 0x720D80 VA: 0x180722780 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x710220 Offset: 0x70E820 VA: 0x180710220 Slot: 124
	public override Transform FindBone(string strName) { }

	// RVA: 0x710D40 Offset: 0x70F340 VA: 0x180710D40 Slot: 123
	public override Transform[] GetBones() { }

	// RVA: 0x7284C0 Offset: 0x726AC0 VA: 0x1807284C0 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x72D340 Offset: 0x72B940 VA: 0x18072D340
	public static BufferList<BasePlayer> get_VisiblePlayerList() { }

	// RVA: 0x709950 Offset: 0x707F50 VA: 0x180709950
	public static void ClearVisibility() { }

	// RVA: 0x725B10 Offset: 0x724110 VA: 0x180725B10
	public static void RegisterForVisibility(BasePlayer player) { }

	// RVA: 0x728DC0 Offset: 0x7273C0 VA: 0x180728DC0
	public static void UnregisterFromVisibility(ulong userID) { }

	// RVA: 0x710320 Offset: 0x70E920 VA: 0x180710320
	public static BasePlayer FindByID_Clientside(ulong userID) { }

	// RVA: 0x7104F0 Offset: 0x70EAF0 VA: 0x1807104F0
	public static BasePlayer Find_Clientside(string strNameOrIDOrIP) { }

	// RVA: 0x7142A0 Offset: 0x7128A0 VA: 0x1807142A0
	public static float GetRandomFloatBasedOnUserID(ulong steamid, ulong seed) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x728490 Offset: 0x726A90 VA: 0x180728490 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x727850 Offset: 0x725E50 VA: 0x180727850
	public void SetInheritedVelocity(Vector3 velocity, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x713FE0 Offset: 0x7125E0 VA: 0x180713FE0
	public void GetPerformanceReport(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x713B60 Offset: 0x712160 VA: 0x180713B60
	public void GetPerformanceReport_Frametime(BaseEntity.RPCMessage msg) { }

	// RVA: 0x719990 Offset: 0x717F90 VA: 0x180719990 Slot: 63
	public override void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x723200 Offset: 0x721800 VA: 0x180723200 Slot: 74
	public override void OnVoiceData(byte[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7256E0 Offset: 0x723CE0 VA: 0x1807256E0
	public void RecieveAchievement(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70E720 Offset: 0x70CD20 VA: 0x18070E720
	public void CraftMode(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7287B0 Offset: 0x726DB0 VA: 0x1807287B0
	public void StartDesigningAI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x719D10 Offset: 0x718310 VA: 0x180719D10
	public void OnDebugAIEventTriggeredStateChange(int previousStateContainerID, int newStateContainerID, int sourceEventID) { }

	// RVA: 0x70ADC0 Offset: 0x7093C0 VA: 0x18070ADC0 Slot: 13
	public override void ClientOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D1A0 Offset: 0x70B7A0 VA: 0x18070D1A0
	private void Client_OnRepairFailedResources(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728A20 Offset: 0x727020 VA: 0x180728A20
	private void TakeDamageHit() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x705EF0 Offset: 0x7044F0 VA: 0x180705EF0
	private void AdminReceivedUGC(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x705E30 Offset: 0x704430 VA: 0x180705E30
	private void AdminReceivedPatternFirework(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D2A0 Offset: 0x72B8A0 VA: 0x18072D2A0
	public bool get_IsWearingDiveGoggles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72DA30 Offset: 0x72C030 VA: 0x18072DA30
	private void set_IsWearingDiveGoggles(bool value) { }

	// RVA: 0x728F10 Offset: 0x727510 VA: 0x180728F10
	protected void UpdateClothesIfNeeded() { }

	// RVA: 0x718ED0 Offset: 0x7174D0 VA: 0x180718ED0 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0x70C280 Offset: 0x70A880 VA: 0x18070C280
	protected void ClientUpdate_Sleeping() { }

	// RVA: 0x70C660 Offset: 0x70AC60 VA: 0x18070C660
	protected void ClientUpdate() { }

	// RVA: 0x725150 Offset: 0x723750 VA: 0x180725150
	public void RebuildClothingItems() { }

	// RVA: 0x729400 Offset: 0x727A00 VA: 0x180729400
	public void UpdateClothingItems(SkinnedMultiMesh multiMesh) { }

	// RVA: 0x729B30 Offset: 0x728130 VA: 0x180729B30
	public void UpdateHolsterOffsets() { }

	// RVA: 0x7238F0 Offset: 0x721EF0 VA: 0x1807238F0
	public void PostLateClientCycle() { }

	// RVA: 0x717050 Offset: 0x715650 VA: 0x180717050
	public bool IsLocalPlayer() { }

	// RVA: 0x70AF20 Offset: 0x709520 VA: 0x18070AF20
	public void ClientUpdateLocalPlayer() { }

	// RVA: 0x72AF00 Offset: 0x729500 VA: 0x18072AF00
	public void UpdateTopologyStats() { }

	// RVA: 0x70AE70 Offset: 0x709470 VA: 0x18070AE70
	private void ClientTick() { }

	// RVA: 0x70F810 Offset: 0x70DE10 VA: 0x18070F810
	public void DoMovement() { }

	// RVA: 0x719660 Offset: 0x717C60 VA: 0x180719660
	private void MountableOverrideViewAngles() { }

	// RVA: 0x706E60 Offset: 0x705460 VA: 0x180706E60 Slot: 147
	public virtual void BlockSprint(float duration = 0,2) { }

	// RVA: 0x706DC0 Offset: 0x7053C0 VA: 0x180706DC0 Slot: 148
	public virtual void BlockJump(float duration = 0,5) { }

	// RVA: 0x70A310 Offset: 0x708910 VA: 0x18070A310 Slot: 149
	internal virtual void ClientInput(InputState state) { }

	// RVA: 0x72B3C0 Offset: 0x7299C0 VA: 0x18072B3C0
	internal void UseAction(InputState state) { }

	// RVA: 0x711DA0 Offset: 0x7103A0 VA: 0x180711DA0
	internal BaseEntity GetInteractionEntity() { }

	// RVA: 0x724D30 Offset: 0x723330 VA: 0x180724D30
	internal void QuickUse() { }

	// RVA: 0x718E10 Offset: 0x717410 VA: 0x180718E10
	internal void LongUse() { }

	// RVA: 0x72B690 Offset: 0x729C90 VA: 0x18072B690
	internal void UseStop() { }

	// RVA: 0x729CC0 Offset: 0x7282C0 VA: 0x180729CC0
	internal bool UpdateLookingAt(float radius, bool includeSecondaryEntities) { }

	// RVA: 0x725F60 Offset: 0x724560 VA: 0x180725F60
	private void ResetLookingAt() { }

	// RVA: 0x7279E0 Offset: 0x725FE0 VA: 0x1807279E0
	private void SetLookingAt(HitTest lookingAtTest) { }

	// RVA: 0x709150 Offset: 0x707750 VA: 0x180709150
	private bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x7103B0 Offset: 0x70E9B0 VA: 0x1807103B0
	private static BaseVehicle FindVehicleParentFor(BaseEntity entity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x719E80 Offset: 0x718480 VA: 0x180719E80
	private void OnDied(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x71A280 Offset: 0x718880 VA: 0x18071A280
	private void OnRespawnInformation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x725E10 Offset: 0x724410 VA: 0x180725E10
	private void RequestRespawnUpdates() { }

	// RVA: 0x71A090 Offset: 0x718690 VA: 0x18071A090
	public void OnLand(float fVelocity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728940 Offset: 0x726F40 VA: 0x180728940
	private void StartLoading() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x710790 Offset: 0x70ED90 VA: 0x180710790
	private void FinishLoading() { }

	// RVA: 0x710C20 Offset: 0x70F220 VA: 0x180710C20
	private void FullBlack_FadeIn() { }

	[IteratorStateMachineAttribute] // RVA: 0xBE9B0 Offset: 0xBDDB0 VA: 0x1800BE9B0
	// RVA: 0x7108E0 Offset: 0x70EEE0 VA: 0x1807108E0
	private IEnumerator FinishedLoadingRoutine() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70F300 Offset: 0x70D900 VA: 0x18070F300
	private void DirectionalDamage(Vector3 position, int damageType, int damageTotal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728D50 Offset: 0x727350 VA: 0x180728D50
	public void UnlockedBlueprint(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7090E0 Offset: 0x7076E0 VA: 0x1807090E0
	private void CheckForRespawnInfo() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72AC60 Offset: 0x729260 VA: 0x18072AC60
	public void UpdateRichPresenceState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x714580 Offset: 0x712B80 VA: 0x180714580
	public void HandleCompanionPairingResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72B0A0 Offset: 0x7296A0 VA: 0x18072B0A0
	public Vector3 UpdateWaterDrinkingPoint() { }

	// RVA: 0x714560 Offset: 0x712B60 VA: 0x180714560
	private Vector3 GetWaterDrinkingPoint() { }

	[BaseEntity.Menu] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.Description] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.Icon] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	// RVA: 0x70FAB0 Offset: 0x70E0B0 VA: 0x18070FAB0
	public void Drink(BasePlayer player) { }

	// RVA: 0x70F8D0 Offset: 0x70DED0 VA: 0x18070F8D0
	public bool Drink_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.Description] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.Icon] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void SaltWater(BasePlayer player) { }

	// RVA: 0x7260E0 Offset: 0x7246E0 VA: 0x1807260E0
	public bool SaltWater_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.Description] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.Icon] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.ShowIf] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	// RVA: 0x70DEA0 Offset: 0x70C4A0 VA: 0x18070DEA0
	public void Climb(BasePlayer player) { }

	// RVA: 0x70DBD0 Offset: 0x70C1D0 VA: 0x18070DBD0
	public bool Climb_ShowIf(BasePlayer player) { }

	// RVA: 0x714AF0 Offset: 0x7130F0 VA: 0x180714AF0
	public bool HasPlayerFlag(BasePlayer.PlayerFlags f) { }

	// RVA: 0x72D290 Offset: 0x72B890 VA: 0x18072D290
	public bool get_IsReceivingSnapshot() { }

	// RVA: 0x72D1B0 Offset: 0x72B7B0 VA: 0x18072D1B0
	public bool get_IsAdmin() { }

	// RVA: 0x72D260 Offset: 0x72B860 VA: 0x18072D260
	public bool get_IsDeveloper() { }

	// RVA: 0x72D1C0 Offset: 0x72B7C0 VA: 0x18072D1C0
	public bool get_IsAiming() { }

	// RVA: 0x72D270 Offset: 0x72B870 VA: 0x18072D270
	public bool get_IsFlying() { }

	// RVA: 0x72D1D0 Offset: 0x72B7D0 VA: 0x18072D1D0
	public bool get_IsConnected() { }

	// RVA: 0x72D100 Offset: 0x72B700 VA: 0x18072D100
	public bool get_InGesture() { }

	// RVA: 0x72CC50 Offset: 0x72B250 VA: 0x18072CC50
	private bool get_CurrentGestureBlocksMovement() { }

	// RVA: 0x72CC90 Offset: 0x72B290 VA: 0x18072CC90
	public bool get_CurrentGestureIsDance() { }

	// RVA: 0x72CCD0 Offset: 0x72B2D0 VA: 0x18072CCD0
	public bool get_CurrentGestureIsFullBody() { }

	// RVA: 0x72D0D0 Offset: 0x72B6D0 VA: 0x18072D0D0
	private bool get_InGestureCancelCooldown() { }

	// RVA: 0x727450 Offset: 0x725A50 VA: 0x180727450
	private void SetGestureMenuOpen(bool wantsOpen) { }

	// RVA: 0x725EB0 Offset: 0x7244B0 VA: 0x180725EB0
	private void RequestStartGesture(GestureConfig g) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D700 Offset: 0x70BD00 VA: 0x18070D700
	private void Client_StartGesture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x70D760 Offset: 0x70BD60 VA: 0x18070D760
	public void Client_StartGesture(GestureConfig gesture) { }

	// RVA: 0x7240A0 Offset: 0x7226A0 VA: 0x1807240A0
	private void ProcessDanceAction() { }

	// RVA: 0x726430 Offset: 0x724A30 VA: 0x180726430
	public bool SayingHello() { }

	// RVA: 0x7245B0 Offset: 0x722BB0 VA: 0x1807245B0
	private void ProcessGestureStart() { }

	// RVA: 0x70FDD0 Offset: 0x70E3D0 VA: 0x18070FDD0
	private void EndGesture() { }

	// RVA: 0x70FE70 Offset: 0x70E470 VA: 0x18070FE70
	private void EndLocalGesture() { }

	// RVA: 0x70FC60 Offset: 0x70E260 VA: 0x18070FC60
	private void EndGestureShared() { }

	// RVA: 0x715260 Offset: 0x713860 VA: 0x180715260
	private void HideHeldEntity(bool state) { }

	// RVA: 0x708E00 Offset: 0x707400 VA: 0x180708E00
	private void CancelGesture() { }

	// RVA: 0x725C00 Offset: 0x724200 VA: 0x180725C00
	public void RemoteGestureCancel() { }

	// RVA: 0x7089E0 Offset: 0x706FE0 VA: 0x1807089E0
	private bool CancelGestureInput() { }

	// RVA: 0x709800 Offset: 0x707E00 VA: 0x180709800
	public void ClearGestureCooldown() { }

	// RVA: 0x70E4B0 Offset: 0x70CAB0 VA: 0x18070E4B0
	public bool ConVarRequestStartGesture(string gestureName) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D6B0 Offset: 0x70BCB0 VA: 0x18070D6B0
	private void Client_RemoteCancelledGesture() { }

	// RVA: 0x716990 Offset: 0x714F90 VA: 0x180716990
	private bool IsGestureBlocked() { }

	// RVA: 0x72D3B0 Offset: 0x72B9B0 VA: 0x18072D3B0
	public float get_clientTeamLifetime() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x707450 Offset: 0x705A50 VA: 0x180707450
	public void CLIENT_ReceiveTeamInfo(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72ACB0 Offset: 0x7292B0 VA: 0x18072ACB0
	private void UpdateSteamGroup(ulong teamId, int teamSize) { }

	// RVA: 0x709830 Offset: 0x707E30 VA: 0x180709830
	private void ClearSteamGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x706F00 Offset: 0x705500 VA: 0x180706F00
	public void CLIENT_ClearTeam(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7070A0 Offset: 0x7056A0 VA: 0x1807070A0
	public void CLIENT_PendingInvite(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.Description] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.Icon] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	// RVA: 0x715770 Offset: 0x713D70 VA: 0x180715770
	public void InviteToTeam(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.Description] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.Icon] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	// RVA: 0x724BA0 Offset: 0x7231A0 VA: 0x180724BA0
	public void Promote(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Promote_Start() { }

	// RVA: 0x7247D0 Offset: 0x722DD0 VA: 0x1807247D0
	public bool Promote_ShowIf(BasePlayer player) { }

	// RVA: 0x718910 Offset: 0x716F10 VA: 0x180718910
	public static bool LocalPlayerIsLeader() { }

	// RVA: 0x715CD0 Offset: 0x7142D0 VA: 0x180715CD0
	public bool Invite_ShowIf(BasePlayer player) { }

	// RVA: 0x7118F0 Offset: 0x70FEF0 VA: 0x1807118F0
	public HeldEntity GetHeldEntity() { }

	// RVA: -1 Offset: -1
	public bool IsHoldingEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CB50 Offset: 0x125B150 VA: 0x18125CB50
	|-BasePlayer.IsHoldingEntity<Hammer>
	|-BasePlayer.IsHoldingEntity<object>
	|-BasePlayer.IsHoldingEntity<WireTool>
	*/

	// RVA: 0x711B30 Offset: 0x710130 VA: 0x180711B30
	private Item GetHeldItem() { }

	// RVA: 0x711AE0 Offset: 0x7100E0 VA: 0x180711AE0
	public uint GetHeldItemID() { }

	// RVA: 0x715040 Offset: 0x713640 VA: 0x180715040
	private void HeldEntityViewAngles() { }

	// RVA: 0x714BD0 Offset: 0x7131D0 VA: 0x180714BD0
	private void HeldEntityFrame() { }

	// RVA: 0x714DA0 Offset: 0x7133A0 VA: 0x180714DA0
	private void HeldEntityInput() { }

	// RVA: 0x715160 Offset: 0x713760 VA: 0x180715160
	private bool HeldItemUse() { }

	// RVA: 0x714F70 Offset: 0x713570 VA: 0x180714F70
	public void HeldEntityStart() { }

	// RVA: 0x714B00 Offset: 0x713100 VA: 0x180714B00
	public void HeldEntityEnd() { }

	// RVA: 0x716D50 Offset: 0x715350 VA: 0x180716D50
	public bool IsHostileItem(Item item) { }

	// RVA: 0x716EB0 Offset: 0x7154B0 VA: 0x180716EB0
	public bool IsItemHoldRestricted(Item item) { }

	// RVA: 0x718F80 Offset: 0x717580 VA: 0x180718F80
	private void MapInfoOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D370 Offset: 0x70B970 VA: 0x18070D370
	public void Client_ReceiveMarkers(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70DAA0 Offset: 0x70C0A0 VA: 0x18070DAA0
	public void Client_UpdateDeathMarker(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D060 Offset: 0x70B660 VA: 0x18070D060
	public void Client_AddNewDeathMarker(BaseEntity.RPCMessage msg) { }

	// RVA: 0x705D50 Offset: 0x704350 VA: 0x180705D50
	public void AddPointOfInterest(Vector3 position) { }

	// RVA: 0x7096B0 Offset: 0x707CB0 VA: 0x1807096B0
	public void ClearAllPointsOfInterest() { }

	// RVA: 0x709550 Offset: 0x707B50 VA: 0x180709550
	public void ClearAllMapMarkers() { }

	// RVA: 0x714630 Offset: 0x712C30 VA: 0x180714630
	public bool HasAttemptedMission(uint missionID) { }

	// RVA: 0x707C60 Offset: 0x706260 VA: 0x180707C60
	public bool CanAcceptMission(uint missionID) { }

	// RVA: 0x717130 Offset: 0x715730 VA: 0x180717130
	public bool IsMissionActive(uint missionID) { }

	// RVA: 0x7147A0 Offset: 0x712DA0 VA: 0x1807147A0
	public bool HasCompletedMission(uint missionID) { }

	// RVA: 0x714910 Offset: 0x712F10 VA: 0x180714910
	public bool HasFailedMission(uint missionID) { }

	// RVA: 0x727370 Offset: 0x725970 VA: 0x180727370
	public void SetActiveMission(int index) { }

	// RVA: 0x710D30 Offset: 0x70F330 VA: 0x180710D30
	public int GetActiveMission() { }

	// RVA: 0x714620 Offset: 0x712C20 VA: 0x180714620
	public bool HasActiveMission() { }

	// RVA: 0x717EF0 Offset: 0x7164F0 VA: 0x180717EF0
	private void LoadMissions(Missions loadedMissions) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x71A1F0 Offset: 0x7187F0 VA: 0x18071A1F0
	private void OnModelState(BaseEntity.RPCMessage data) { }

	// RVA: 0x71A150 Offset: 0x718750 VA: 0x18071A150
	private void OnModelStateChanged() { }

	// RVA: 0x72D670 Offset: 0x72BC70 VA: 0x18072D670
	public bool get_isMounted() { }

	// RVA: 0x72D6A0 Offset: 0x72BCA0 VA: 0x18072D6A0
	public bool get_isMountingHidingWeapon() { }

	// RVA: 0x713620 Offset: 0x711C20 VA: 0x180713620
	public BaseMountable GetMounted() { }

	// RVA: 0x7135D0 Offset: 0x711BD0 VA: 0x1807135D0
	public BaseVehicle GetMountedVehicle() { }

	// RVA: 0x718FD0 Offset: 0x7175D0 VA: 0x180718FD0
	public void MarkSwapSeat() { }

	// RVA: 0x7289F0 Offset: 0x726FF0 VA: 0x1807289F0
	public bool SwapSeatCooldown() { }

	// RVA: 0x70BD40 Offset: 0x70A340 VA: 0x18070BD40
	public void ClientUpdateMounted(uint id) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x707850 Offset: 0x705E50 VA: 0x180707850
	public void CLIENT_SetPetPrefabID(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7076A0 Offset: 0x705CA0 VA: 0x1807076A0
	public void CLIENT_SetPetPetLoadedStateIndex(BaseEntity.RPCMessage msg) { }

	// RVA: 0x717DA0 Offset: 0x7163A0 VA: 0x180717DA0
	private void LinkPet() { }

	// RVA: 0x727DC0 Offset: 0x7263C0 VA: 0x180727DC0
	private void SetPetMenuOpen(bool wantsOpen) { }

	// RVA: 0x70ACD0 Offset: 0x7092D0 VA: 0x18070ACD0
	private void ClientIssuePetCommand(int cmdType, int param, bool raycast) { }

	// RVA: 0x717410 Offset: 0x715A10 VA: 0x180717410
	public bool IsSleeping() { }

	// RVA: 0x717420 Offset: 0x715A20 VA: 0x180717420
	public bool IsSpectating() { }

	// RVA: 0x717340 Offset: 0x715940 VA: 0x180717340
	public bool IsRelaxed() { }

	// RVA: 0x717400 Offset: 0x715A00 VA: 0x180717400
	public bool IsServerFalling() { }

	// RVA: 0x711150 Offset: 0x70F750 VA: 0x180711150 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x7085F0 Offset: 0x706BF0 VA: 0x1807085F0
	public bool CanBuild() { }

	// RVA: 0x708490 Offset: 0x706A90 VA: 0x180708490
	public bool CanBuild(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x7083C0 Offset: 0x7069C0 VA: 0x1807083C0
	public bool CanBuild(OBB obb) { }

	// RVA: 0x716720 Offset: 0x714D20 VA: 0x180716720
	public bool IsBuildingBlocked() { }

	// RVA: 0x7165C0 Offset: 0x714BC0 VA: 0x1807165C0
	public bool IsBuildingBlocked(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x7164E0 Offset: 0x714AE0 VA: 0x1807164E0
	public bool IsBuildingBlocked(OBB obb) { }

	// RVA: 0x7162E0 Offset: 0x7148E0 VA: 0x1807162E0
	public bool IsBuildingAuthed() { }

	// RVA: 0x716380 Offset: 0x714980 VA: 0x180716380
	public bool IsBuildingAuthed(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x716210 Offset: 0x714810 VA: 0x180716210
	public bool IsBuildingAuthed(OBB obb) { }

	// RVA: 0x708780 Offset: 0x706D80 VA: 0x180708780
	public bool CanPlaceBuildingPrivilege() { }

	// RVA: 0x7087F0 Offset: 0x706DF0 VA: 0x1807087F0
	public bool CanPlaceBuildingPrivilege(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x708930 Offset: 0x706F30 VA: 0x180708930
	public bool CanPlaceBuildingPrivilege(OBB obb) { }

	// RVA: 0x7196F0 Offset: 0x717CF0 VA: 0x1807196F0
	public int NewProjectileID() { }

	// RVA: 0x719700 Offset: 0x717D00 VA: 0x180719700
	public int NewProjectileSeed() { }

	// RVA: 0x7270C0 Offset: 0x7256C0 VA: 0x1807270C0
	public void SendProjectileAttack(PlayerProjectileAttack attack) { }

	// RVA: 0x727110 Offset: 0x725710 VA: 0x180727110
	public void SendProjectileRicochet(PlayerProjectileRicochet ricochet) { }

	// RVA: 0x727160 Offset: 0x725760 VA: 0x180727160
	public void SendProjectileUpdate(PlayerProjectileUpdate update) { }

	// RVA: 0x7184B0 Offset: 0x716AB0 VA: 0x1807184B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728720 Offset: 0x726D20 VA: 0x180728720
	private void SpectatedPlayerHeadshot() { }

	// RVA: 0x714540 Offset: 0x712B40 VA: 0x180714540 Slot: 141
	public override float GetThreatLevel() { }

	// RVA: 0x70FF90 Offset: 0x70E590 VA: 0x18070FF90
	public void EnsureUpdated() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7277A0 Offset: 0x725DA0 VA: 0x1807277A0
	public void SetHostileLength(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7283F0 Offset: 0x7269F0 VA: 0x1807283F0
	public void SetWeaponDrawnDuration(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 150
	protected virtual void ModifyInputState(ref InputState inputState) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x710950 Offset: 0x70EF50 VA: 0x180710950
	private void ForcePositionToParentOffset(Vector3 position, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728EB0 Offset: 0x7274B0 VA: 0x180728EB0
	public void UpdateClientTickRate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x710A80 Offset: 0x70F080 VA: 0x180710A80
	private void ForcePositionTo(Vector3 position) { }

	// RVA: 0x7271B0 Offset: 0x7257B0 VA: 0x1807271B0
	internal void SendVoiceData(byte[] data, int len) { }

	// RVA: 0x7269D0 Offset: 0x724FD0 VA: 0x1807269D0
	internal void SendClientTick() { }

	// RVA: 0x719760 Offset: 0x717D60 VA: 0x180719760
	public void NotifyUnderwearChange() { }

	// RVA: 0x72A960 Offset: 0x728F60 VA: 0x18072A960
	public static void UpdatePlayerVisibilities() { }

	// RVA: 0x728B50 Offset: 0x727150 VA: 0x180728B50
	private float TimeSinceSeen() { }

	// RVA: 0x727D90 Offset: 0x726390 VA: 0x180727D90
	private void SetNextVisThink(float addTime) { }

	// RVA: 0x72C1D0 Offset: 0x72A7D0 VA: 0x18072C1D0
	private bool WantsVisUpdate() { }

	// RVA: 0x715F10 Offset: 0x714510 VA: 0x180715F10
	public static bool IsAimingAt(BasePlayer aimer, BasePlayer target, float cone = 0,95) { }

	// RVA: 0x729860 Offset: 0x727E60 VA: 0x180729860 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0x72B810 Offset: 0x729E10 VA: 0x18072B810
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x72B920 Offset: 0x729F20 VA: 0x18072B920
	private void VisUpdateUsingRays(float dist) { }

	// RVA: 0x718AC0 Offset: 0x7170C0 VA: 0x180718AC0
	private void LogDebugCull(float dist) { }

	// RVA: 0x722F00 Offset: 0x721500 VA: 0x180722F00 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0x72BD40 Offset: 0x72A340 VA: 0x18072BD40
	private void VisUpdate() { }

	// RVA: 0x72B750 Offset: 0x729D50 VA: 0x18072B750
	private bool VisPlayerArmed() { }

	// RVA: 0x7061C0 Offset: 0x7047C0 VA: 0x1807061C0
	private bool AnyPartVisible() { }

	// RVA: 0x707B20 Offset: 0x706120 VA: 0x180707B20
	private float CalcVisUpdateRate(float dist) { }

	// RVA: 0x723620 Offset: 0x721C20 VA: 0x180723620
	private bool PointSeePoint(Vector3 target, Vector3 origin, float dist = 0, bool useGameTrace = False) { }

	// RVA: 0x717700 Offset: 0x715D00 VA: 0x180717700
	public bool IsWounded() { }

	// RVA: 0x7167D0 Offset: 0x714DD0 VA: 0x1807167D0
	public bool IsCrawling() { }

	// RVA: 0x716EA0 Offset: 0x7154A0 VA: 0x180716EA0
	public bool IsIncapacitated() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 97
	public override BasePlayer ToPlayer() { }

	// RVA: 0x72CC40 Offset: 0x72B240 VA: 0x18072CC40
	public Connection get_Connection() { }

	// RVA: 0x72D400 Offset: 0x72BA00 VA: 0x18072D400
	public string get_displayName() { }

	// RVA: 0x72DA40 Offset: 0x72C040 VA: 0x18072DA40
	public void set_displayName(string value) { }

	// RVA: 0x7262B0 Offset: 0x7248B0 VA: 0x1807262B0
	public static string SanitizePlayerNameString(string playerName, ulong userId) { }

	// RVA: 0x716C80 Offset: 0x715280 VA: 0x180716C80
	public bool IsGod() { }

	// RVA: 0x7136C0 Offset: 0x711CC0 VA: 0x1807136C0 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	// RVA: 0x708720 Offset: 0x706D20 VA: 0x180708720
	public bool CanInteract() { }

	// RVA: 0x708690 Offset: 0x706C90 VA: 0x180708690
	public bool CanInteract(bool usableWhileCrawling) { }

	// RVA: 0x728920 Offset: 0x726F20 VA: 0x180728920 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x723230 Offset: 0x721830 VA: 0x180723230 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x719010 Offset: 0x717610 VA: 0x180719010 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x7190C0 Offset: 0x7176C0 VA: 0x1807190C0 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x72C6B0 Offset: 0x72ACB0 VA: 0x18072C6B0 Slot: 103
	public override OBB WorldSpaceBounds() { }

	// RVA: 0x713500 Offset: 0x711B00 VA: 0x180713500
	public Vector3 GetMountVelocity() { }

	// RVA: 0x711C20 Offset: 0x710220 VA: 0x180711C20 Slot: 100
	public override Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x711CE0 Offset: 0x7102E0 VA: 0x180711CE0 Slot: 101
	public override Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x711B60 Offset: 0x710160 VA: 0x180711B60 Slot: 102
	public override Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x723C30 Offset: 0x722230 VA: 0x180723C30 Slot: 29
	public override void PreInitShared() { }

	// RVA: 0x70F280 Offset: 0x70D880 VA: 0x18070F280 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7153F0 Offset: 0x7139F0 VA: 0x1807153F0
	public bool InSafeZone() { }

	// RVA: 0x717710 Offset: 0x715D10 VA: 0x180717710
	public static void LateClientCycle() { }

	// RVA: 0x709B10 Offset: 0x708110 VA: 0x180709B10
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0x710DD0 Offset: 0x70F3D0 VA: 0x180710DD0
	public Bounds GetBounds(bool ducked) { }

	// RVA: 0x710F60 Offset: 0x70F560 VA: 0x180710F60
	public Bounds GetBounds() { }

	// RVA: 0x711220 Offset: 0x70F820 VA: 0x180711220
	public Vector3 GetCenter(bool ducked) { }

	// RVA: 0x711340 Offset: 0x70F940 VA: 0x180711340
	public Vector3 GetCenter() { }

	// RVA: 0x7137E0 Offset: 0x711DE0 VA: 0x1807137E0
	public Vector3 GetOffset(bool ducked) { }

	// RVA: 0x713760 Offset: 0x711D60 VA: 0x180713760
	public Vector3 GetOffset() { }

	// RVA: 0x7143A0 Offset: 0x7129A0 VA: 0x1807143A0
	public Vector3 GetSize(bool ducked) { }

	// RVA: 0x714320 Offset: 0x712920 VA: 0x180714320
	public Vector3 GetSize() { }

	// RVA: 0x7118D0 Offset: 0x70FED0 VA: 0x1807118D0
	public float GetHeight(bool ducked) { }

	// RVA: 0x711890 Offset: 0x70FE90 VA: 0x180711890
	public float GetHeight() { }

	// RVA: 0x714290 Offset: 0x712890 VA: 0x180714290
	public float GetRadius() { }

	// RVA: 0x7122A0 Offset: 0x7108A0 VA: 0x1807122A0
	public float GetJumpHeight() { }

	// RVA: 0x728C50 Offset: 0x727250 VA: 0x180728C50 Slot: 104
	public override Vector3 TriggerPoint() { }

	// RVA: 0x719710 Offset: 0x717D10 VA: 0x180719710
	public Vector3 NoClipOffset() { }

	// RVA: 0x719750 Offset: 0x717D50 VA: 0x180719750
	public float NoClipRadius(float margin) { }

	// RVA: 0x719000 Offset: 0x717600 VA: 0x180719000
	public float MaxDeployDistance(Item item) { }

	// RVA: 0x70C250 Offset: 0x70A850 VA: 0x18070C250
	public void ClientUpdatePersistantData(PersistantPlayer data) { }

	// RVA: 0x7134D0 Offset: 0x711AD0 VA: 0x1807134D0
	public float GetMinSpeed() { }

	// RVA: 0x712480 Offset: 0x710A80 VA: 0x180712480
	public float GetMaxSpeed() { }

	// RVA: 0x714400 Offset: 0x712A00 VA: 0x180714400
	public float GetSpeed(float running, float ducking, float crawling) { }

	// RVA: 0x7197A0 Offset: 0x717DA0 VA: 0x1807197A0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x70FC00 Offset: 0x70E200 VA: 0x18070FC00
	private void EnablePlayerCollider() { }

	// RVA: 0x70F4C0 Offset: 0x70DAC0 VA: 0x18070F4C0
	private void DisablePlayerCollider() { }

	// RVA: 0x725800 Offset: 0x723E00 VA: 0x180725800
	private void RefreshColliderSize(bool forced) { }

	// RVA: 0x7283D0 Offset: 0x7269D0 VA: 0x1807283D0
	private void SetPlayerRigidbodyState(bool isEnabled) { }

	// RVA: 0x705BD0 Offset: 0x7041D0 VA: 0x180705BD0
	private void AddPlayerRigidbody() { }

	// RVA: 0x725CE0 Offset: 0x7242E0 VA: 0x180725CE0
	private void RemovePlayerRigidbody() { }

	// RVA: 0x7168A0 Offset: 0x714EA0 VA: 0x1807168A0
	public bool IsEnsnared() { }

	// RVA: 0x7160E0 Offset: 0x7146E0 VA: 0x1807160E0
	public bool IsAttacking() { }

	// RVA: 0x7080D0 Offset: 0x7066D0 VA: 0x1807080D0
	public bool CanAttack() { }

	// RVA: 0x71A000 Offset: 0x718600 VA: 0x18071A000
	public bool OnLadder() { }

	// RVA: 0x7176B0 Offset: 0x715CB0 VA: 0x1807176B0
	public bool IsSwimming() { }

	// RVA: 0x716D00 Offset: 0x715300 VA: 0x180716D00
	public bool IsHeadUnderwater() { }

	// RVA: 0x7172A0 Offset: 0x7158A0 VA: 0x1807172A0 Slot: 151
	public virtual bool IsOnGround() { }

	// RVA: 0x717350 Offset: 0x715950 VA: 0x180717350
	public bool IsRunning() { }

	// RVA: 0x7167F0 Offset: 0x714DF0 VA: 0x1807167F0
	public bool IsDucked() { }

	// RVA: 0x725650 Offset: 0x723C50 VA: 0x180725650
	public bool RecentlyTeleported() { }

	// RVA: 0x728520 Offset: 0x726B20 VA: 0x180728520
	public void ShowToast(int style, Translate.Phrase phrase) { }

	// RVA: 0x708ED0 Offset: 0x7074D0 VA: 0x180708ED0
	public void ChatMessage(string msg) { }

	// RVA: 0x70E660 Offset: 0x70CC60 VA: 0x18070E660
	public void ConsoleMessage(string msg) { }

	// RVA: 0x723230 Offset: 0x721830 VA: 0x180723230 Slot: 114
	public override float PenetrationResistance(HitInfo info) { }

	// RVA: 0x726740 Offset: 0x724D40 VA: 0x180726740 Slot: 142
	public override void ScaleDamage(HitInfo info) { }

	// RVA: 0x72A590 Offset: 0x728B90 VA: 0x18072A590
	private void UpdateMoveSpeedFromClothing() { }

	// RVA: 0x72AB40 Offset: 0x729140 VA: 0x18072AB40 Slot: 152
	public virtual void UpdateProtectionFromClothing() { }

	// RVA: 0x708EA0 Offset: 0x7074A0 VA: 0x180708EA0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x728B70 Offset: 0x727170 VA: 0x180728B70 Slot: 3
	public override string ToString() { }

	// RVA: 0x7114B0 Offset: 0x70FAB0 VA: 0x1807114B0
	public string GetDebugStatus() { }

	// RVA: 0x7121F0 Offset: 0x7107F0 VA: 0x1807121F0 Slot: 118
	public override Item GetItem(uint itemId) { }

	// RVA: 0x72D320 Offset: 0x72B920 VA: 0x18072D320 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x72C1F0 Offset: 0x72A7F0 VA: 0x18072C1F0 Slot: 107
	public override float WaterFactor() { }

	// RVA: 0x706110 Offset: 0x704710 VA: 0x180706110 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x713830 Offset: 0x711E30 VA: 0x180713830
	public float GetOxygenTime(out ItemModGiveOxygen.AirSupplyType airSupplyType) { }

	// RVA: 0x717420 Offset: 0x715A20 VA: 0x180717420 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x706800 Offset: 0x704E00 VA: 0x180706800
	public static bool AnyPlayersVisibleToEntity(Vector3 pos, float radius, BaseEntity source, Vector3 entityEyePos, bool ignorePlayersWithPriv = False) { }

	// RVA: 0x717430 Offset: 0x715A30 VA: 0x180717430
	public bool IsStandingOnEntity(BaseEntity standingOn, int layerMask) { }

	// RVA: 0x727380 Offset: 0x725980 VA: 0x180727380
	public void SetActiveTelephone(PhoneController t) { }

	// RVA: 0x72CD10 Offset: 0x72B310 VA: 0x18072CD10
	public bool get_HasActiveTelephone() { }

	// RVA: 0x72D200 Offset: 0x72B800 VA: 0x18072D200
	public bool get_IsDesigningAI() { }

	// RVA: 0x7097E0 Offset: 0x707DE0 VA: 0x1807097E0
	public void ClearDesigningAIEntity() { }

	// RVA: 0x72CA90 Offset: 0x72B090 VA: 0x18072CA90
	public void .ctor() { }

	// RVA: 0x72C940 Offset: 0x72AF40 VA: 0x18072C940
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

	// RVA: 0x93B490 Offset: 0x939A90 VA: 0x18093B490
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B210 Offset: 0x939810 VA: 0x18093B210
	internal ulong <OnBecameRagdoll>b__103_0(PlayerTeam.TeamMember m) { }

	// RVA: 0x93B2E0 Offset: 0x9398E0 VA: 0x18093B2E0
	internal int <UpdateLookingAt>b__148_0(TraceInfo a, TraceInfo b) { }

	// RVA: 0x93B230 Offset: 0x939830 VA: 0x18093B230
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

	// RVA: 0x93A950 Offset: 0x938F50 VA: 0x18093A950 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93AEB0 Offset: 0x9394B0 VA: 0x18093AEB0 Slot: 8
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

	// RVA: 0x93B300 Offset: 0x939900 VA: 0x18093B300
	internal void <SetGestureMenuOpen>b__0(BasePlayer ply) { }

}

private sealed class BasePlayer.<>c__DisplayClass304_0 // TypeDefIndex: 8345
{	// Fields
	public uint index; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B330 Offset: 0x939930 VA: 0x18093B330
	internal bool <CLIENT_SetPetPetLoadedStateIndex>b__0(PetCommandList.PetCommandDesc c) { }

}

private sealed class BasePlayer.<>c__DisplayClass306_0 // TypeDefIndex: 8346
{	// Fields
	public PetCommandList.PetCommandDesc desc; // 0x10
	public BasePlayer <>4__this; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B350 Offset: 0x939950 VA: 0x18093B350
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

	// RVA: 0xC369D0 Offset: 0xC34FD0 VA: 0x180C369D0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC36620 Offset: 0xC34C20 VA: 0x180C36620
	protected void Initialize() { }

	// RVA: 0xC35E00 Offset: 0xC34400 VA: 0x180C35E00
	public void DoDestroy() { }

	// RVA: 0xC35D80 Offset: 0xC34380 VA: 0x180C35D80
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC36E20 Offset: 0xC35420 VA: 0x180C36E20
	private void UpdatedItemContainer(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC36440 Offset: 0xC34A40 VA: 0x180C36440
	public Item FindItemUID(uint id) { }

	// RVA: 0xC36160 Offset: 0xC34760 VA: 0x180C36160
	public Item FindItemID(string itemName) { }

	// RVA: 0xC36280 Offset: 0xC34880 VA: 0x180C36280
	public Item FindItemID(int id) { }

	// RVA: 0xC35EE0 Offset: 0xC344E0 VA: 0x180C35EE0
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xC36350 Offset: 0xC34950 VA: 0x180C36350
	public List<Item> FindItemIDs(int id) { }

	// RVA: 0xC35FB0 Offset: 0xC345B0 VA: 0x180C35FB0
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC365A0 Offset: 0xC34BA0 VA: 0x180C365A0
	public ItemContainer GetContainer(PlayerInventory.Type id) { }

	// RVA: 0xC36880 Offset: 0xC34E80 VA: 0x180C36880
	public void Load(PlayerInventory msg) { }

	// RVA: 0xC36520 Offset: 0xC34B20 VA: 0x180C36520
	public int GetAmount(int itemid) { }

	// RVA: 0xC35CB0 Offset: 0xC342B0 VA: 0x180C35CB0
	public Item[] AllItems() { }

	// RVA: 0xC35BE0 Offset: 0xC341E0 VA: 0x180C35BE0
	public int AllItemsNoAlloc(ref List<Item> items) { }

	// RVA: 0xC35E90 Offset: 0xC34490 VA: 0x180C35E90
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xC365C0 Offset: 0xC34BC0 VA: 0x180C365C0
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xC37010 Offset: 0xC35610 VA: 0x180C37010
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

	// RVA: 0xC37460 Offset: 0xC35A60 VA: 0x180C37460 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC37420 Offset: 0xC35A20 VA: 0x180C37420
	public bool IsLooting() { }

	// RVA: 0xC37050 Offset: 0xC35650 VA: 0x180C37050
	public void Clear() { }

	// RVA: 0xC370E0 Offset: 0xC356E0 VA: 0x180C370E0
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC37270 Offset: 0xC35870 VA: 0x180C37270
	public Item FindItem(uint id) { }

	// RVA: 0xC37410 Offset: 0xC35A10 VA: 0x180C37410
	public BaseEntity GetClientEntity() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC378B0 Offset: 0xC35EB0 VA: 0x180C378B0
	private void UpdateLoot(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xC37B40 Offset: 0xC36140 VA: 0x180C37B40
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

	// RVA: 0xC381C0 Offset: 0xC367C0 VA: 0x180C381C0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC38610 Offset: 0xC36C10 VA: 0x180C38610 Slot: 10
	public override void Reset() { }

	// RVA: 0xC37BB0 Offset: 0xC361B0 VA: 0x180C37BB0
	public bool CanConsume() { }

	// RVA: 0xC37F80 Offset: 0xC36580 VA: 0x180C37F80
	public void MarkConsumption() { }

	// RVA: 0xC37C60 Offset: 0xC36260 VA: 0x180C37C60
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC388D0 Offset: 0xC36ED0 VA: 0x180C388D0
	public void UpdateMetabolism(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC38720 Offset: 0xC36D20 VA: 0x180C38720
	public PlayerMetabolism Save() { }

	// RVA: 0xC37D60 Offset: 0xC36360 VA: 0x180C37D60
	public void Load(PlayerMetabolism s) { }

	// RVA: 0xC37CB0 Offset: 0xC362B0 VA: 0x180C37CB0 Slot: 12
	public override MetabolismAttribute FindAttribute(MetabolismAttribute.Type type) { }

	// RVA: 0xC37FA0 Offset: 0xC365A0 VA: 0x180C37FA0
	public void OnLocalMetabolismUpdated() { }

	// RVA: 0xC389B0 Offset: 0xC36FB0 VA: 0x180C389B0
	public void .ctor() { }

}

public class PlayerModifiers : BaseModifiers<BasePlayer> // TypeDefIndex: 8624
{	// Methods

	// RVA: 0x98D750 Offset: 0x98BD50 VA: 0x18098D750 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x98D3A0 Offset: 0x98B9A0 VA: 0x18098D3A0
	public void Load(PlayerModifiers m) { }

	// RVA: 0x98D340 Offset: 0x98B940 VA: 0x18098D340
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x98DBA0 Offset: 0x98C1A0 VA: 0x18098DBA0
	public void UpdateModifiers(BaseEntity.RPCMessage packet) { }

	// RVA: 0x98DC80 Offset: 0x98C280 VA: 0x18098DC80
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

	// RVA: 0xC38C80 Offset: 0xC37280 VA: 0x180C38C80
	private void CacheOriginalMaterials() { }

	// RVA: 0xC39420 Offset: 0xC37A20 VA: 0x180C39420
	private void Setup(HairType type, HairSetCollection hair, int meshIndex, float typeNum, float dyeNum, MaterialPropertyBlock block) { }

	// RVA: 0xC39080 Offset: 0xC37680 VA: 0x180C39080
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0xC38F60 Offset: 0xC37560 VA: 0x180C38F60
	public static void GetRandomVariation(float hairNum, int typeIndex, int meshIndex, out float typeNum, out float dyeNum) { }

	// RVA: 0xC38ED0 Offset: 0xC374D0 VA: 0x180C38ED0
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

	// RVA: 0x98CE30 Offset: 0x98B430 VA: 0x18098CE30
	public void SetupHairCap(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class PlayerModelSkin : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9218
{	// Fields
	public PlayerModelSkin.SkinMaterialType MaterialType; // 0x18
	public Renderer SkinRenderer; // 0x20

	// Methods

	// RVA: 0x98D200 Offset: 0x98B800 VA: 0x18098D200
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum) { }

	// RVA: 0x98D1A0 Offset: 0x98B7A0 VA: 0x18098D1A0 Slot: 4
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

	// RVA: 0xC2D250 Offset: 0xC2B850 VA: 0x180C2D250
	public void .ctor() { }

}

public class PlayerAnimationEvents : MonoBehaviour // TypeDefIndex: 9645
{	// Fields
	private BasePlayer player; // 0x18

	// Methods

	// RVA: 0x91E5A0 Offset: 0x91CBA0 VA: 0x18091E5A0
	protected void OnEnable() { }

	// RVA: 0x91ED00 Offset: 0x91D300 VA: 0x18091ED00
	public void ThirdPersonReloadSound(AnimationEvent animEvent) { }

	// RVA: 0x91EBB0 Offset: 0x91D1B0 VA: 0x18091EBB0
	public void ThirdPersonMeleeAttackSound(AnimationEvent animEvent) { }

	// RVA: 0x91E940 Offset: 0x91CF40 VA: 0x18091E940
	public void ThirdPersonDeploySound(AnimationEvent animEvent) { }

	// RVA: 0x91EA60 Offset: 0x91D060 VA: 0x18091EA60
	public void ThirdPersonLiquidThrowSound(AnimationEvent animEvent) { }

	// RVA: 0x91E640 Offset: 0x91CC40 VA: 0x18091E640
	public void PlayThirdPersonSound(SoundDefinition def) { }

	// RVA: 0x91E6F0 Offset: 0x91CCF0 VA: 0x18091E6F0
	public bool ShouldPlayThirdPersonSounds() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void SleepingEvent(AnimationEvent animEvent) { }

	// RVA: 0x91E7F0 Offset: 0x91CDF0 VA: 0x18091E7F0
	public void SplashEvent(string splashType) { }

	// RVA: 0x91EFC0 Offset: 0x91D5C0 VA: 0x18091EFC0
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

	// RVA: 0x91FD00 Offset: 0x91E300 VA: 0x18091FD00
	public static int get_MaxBeltSlots() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(BasePlayer player) { }

	// RVA: 0x91FBD0 Offset: 0x91E1D0 VA: 0x18091FBD0
	public Item GetItemInSlot(int slot) { }

	// RVA: 0x91FB30 Offset: 0x91E130 VA: 0x18091FB30
	public Item GetActiveItem() { }

	// RVA: 0x91F0D0 Offset: 0x91D6D0 VA: 0x18091F0D0
	public bool CanHoldItem() { }

	// RVA: 0x91FA70 Offset: 0x91E070 VA: 0x18091FA70
	public void FrameUpdate() { }

	// RVA: 0x91F1C0 Offset: 0x91D7C0 VA: 0x18091F1C0
	public void ChangeSelect(int iSlot, bool allowRunAction = False) { }

	// RVA: 0x91F940 Offset: 0x91DF40 VA: 0x18091F940
	public void DoNextItemDirection(InputState state, int direction) { }

	// RVA: 0x91F470 Offset: 0x91DA70 VA: 0x18091F470
	public void ClientInput(InputState state) { }

	// RVA: 0x91FCC0 Offset: 0x91E2C0 VA: 0x18091FCC0
	private static void .cctor() { }

}

public class PlayerBlueprints : EntityComponent<BasePlayer> // TypeDefIndex: 9647
{	// Fields
	public SteamInventory steamInventory; // 0x20
	private int[] craftableItems; // 0x28

	// Methods

	// RVA: 0x920000 Offset: 0x91E600 VA: 0x180920000
	public void ClientInit() { }

	// RVA: 0x9200B0 Offset: 0x91E6B0 VA: 0x1809200B0
	public void ClientUpdate(PersistantPlayer info) { }

	// RVA: 0x920170 Offset: 0x91E770 VA: 0x180920170
	public bool HasUnlocked(ItemDefinition targetItem) { }

	// RVA: 0x91FD10 Offset: 0x91E310 VA: 0x18091FD10
	public bool CanCraft(int itemid, int skinItemId, ulong playerId) { }

	// RVA: 0x91FF00 Offset: 0x91E500 VA: 0x18091FF00
	public bool CheckSkinOwnership(int skinItemId, ulong playerId) { }

	// RVA: 0x920560 Offset: 0x91EB60 VA: 0x180920560
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

	// RVA: 0xC323C0 Offset: 0xC309C0 VA: 0x180C323C0
	public Vector3 get_worldMountedPosition() { }

	// RVA: 0xC325B0 Offset: 0xC30BB0 VA: 0x180C325B0
	public Vector3 get_worldStandingPosition() { }

	// RVA: 0xC322C0 Offset: 0xC308C0 VA: 0x180C322C0
	public Vector3 get_worldCrouchedPosition() { }

	// RVA: 0xC321C0 Offset: 0xC307C0 VA: 0x180C321C0
	public Vector3 get_worldCrawlingPosition() { }

	// RVA: 0xC31C80 Offset: 0xC30280 VA: 0x180C31C80
	public Vector3 get_position() { }

	// RVA: 0xC31340 Offset: 0xC2F940 VA: 0x180C31340
	private Vector3 get_BodyLeanOffset() { }

	// RVA: 0xC316A0 Offset: 0xC2FCA0 VA: 0x180C316A0
	public Vector3 get_center() { }

	// RVA: 0xC319C0 Offset: 0xC2FFC0 VA: 0x180C319C0
	public Vector3 get_offset() { }

	// RVA: 0xC32110 Offset: 0xC30710 VA: 0x180C32110
	public Quaternion get_rotation() { }

	// RVA: 0xC32710 Offset: 0xC30D10 VA: 0x180C32710
	public void set_rotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC315C0 Offset: 0xC2FBC0 VA: 0x180C315C0
	public Quaternion get_bodyRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC326E0 Offset: 0xC30CE0 VA: 0x180C326E0
	public void set_bodyRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC319A0 Offset: 0xC2FFA0 VA: 0x180C319A0
	public Vector3 get_headAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC326F0 Offset: 0xC30CF0 VA: 0x180C326F0
	public void set_headAngles(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32100 Offset: 0xC30700 VA: 0x180C32100
	public Quaternion get_rotationLook() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32700 Offset: 0xC30D00 VA: 0x180C32700
	public void set_rotationLook(Quaternion value) { }

	// RVA: 0xC31AF0 Offset: 0xC300F0 VA: 0x180C31AF0
	public Quaternion get_parentRotation() { }

	// RVA: 0xC315D0 Offset: 0xC2FBD0 VA: 0x180C315D0
	public bool get_canUpdateViewAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC315B0 Offset: 0xC2FBB0 VA: 0x180C315B0
	public bool get_IsAltLookingLegsThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC326D0 Offset: 0xC30CD0 VA: 0x180C326D0
	private void set_IsAltLookingLegsThreshold(bool value) { }

	// RVA: 0xC2FED0 Offset: 0xC2E4D0 VA: 0x180C2FED0
	public void FrameUpdate(Camera cam) { }

	// RVA: 0xC30F60 Offset: 0xC2F560 VA: 0x180C30F60
	public void UpdateAltLegsThreshold(float yAngle) { }

	// RVA: 0xC30FD0 Offset: 0xC2F5D0 VA: 0x180C30FD0
	private void UpdateCamera(Camera cam) { }

	// RVA: 0xC2DFB0 Offset: 0xC2C5B0 VA: 0x180C2DFB0
	private void DoFirstPersonCamera(Camera cam) { }

	// RVA: 0xC2E600 Offset: 0xC2CC00 VA: 0x180C2E600
	private void DoInEyeCamera(Camera cam) { }

	// RVA: 0xC2E950 Offset: 0xC2CF50 VA: 0x180C2E950
	private void DoThirdPersonCamera(Camera cam) { }

	// RVA: 0xC2D9D0 Offset: 0xC2BFD0 VA: 0x180C2D9D0
	private void DoDeathCamera(Camera cam) { }

	// RVA: 0xC2D3A0 Offset: 0xC2B9A0 VA: 0x180C2D3A0
	private void ApplyCameraMoves(Camera cam) { }

	// RVA: 0xC30BE0 Offset: 0xC2F1E0 VA: 0x180C30BE0
	public Vector3 MovementForward() { }

	// RVA: 0xC30DA0 Offset: 0xC2F3A0 VA: 0x180C30DA0
	public Vector3 MovementRight() { }

	// RVA: 0xC2D580 Offset: 0xC2BB80 VA: 0x180C2D580
	public Ray BodyRay() { }

	// RVA: 0xC2D430 Offset: 0xC2BA30 VA: 0x180C2D430
	public Vector3 BodyForward() { }

	// RVA: 0xC2D730 Offset: 0xC2BD30 VA: 0x180C2D730
	public Vector3 BodyRight() { }

	// RVA: 0xC2D880 Offset: 0xC2BE80 VA: 0x180C2D880
	public Vector3 BodyUp() { }

	// RVA: 0xC30820 Offset: 0xC2EE20 VA: 0x180C30820
	public Ray HeadRay() { }

	// RVA: 0xC30730 Offset: 0xC2ED30 VA: 0x180C30730
	public Vector3 HeadForward() { }

	// RVA: 0xC30A00 Offset: 0xC2F000 VA: 0x180C30A00
	public Vector3 HeadRight() { }

	// RVA: 0xC30AF0 Offset: 0xC2F0F0 VA: 0x180C30AF0
	public Vector3 HeadUp() { }

	// RVA: 0xC305B0 Offset: 0xC2EBB0 VA: 0x180C305B0
	public Quaternion GetLookRotation() { }

	// RVA: 0xC304F0 Offset: 0xC2EAF0 VA: 0x180C304F0
	public Quaternion GetAimRotation() { }

	// RVA: 0xC31280 Offset: 0xC2F880 VA: 0x180C31280
	public void .ctor() { }

	// RVA: 0xC31180 Offset: 0xC2F780 VA: 0x180C31180
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

	// RVA: 0xC355E0 Offset: 0xC33BE0 VA: 0x180C355E0
	protected void OnDisable() { }

	// RVA: 0xC34790 Offset: 0xC32D90 VA: 0x180C34790
	public void FrameUpdate() { }

	// RVA: 0xC341B0 Offset: 0xC327B0 VA: 0x180C341B0
	private bool CanToggleAds() { }

	// RVA: 0xC34620 Offset: 0xC32C20 VA: 0x180C34620
	private void Flip() { }

	// RVA: 0xC35660 Offset: 0xC33C60 VA: 0x180C35660
	public void ResetMouseDelta() { }

	// RVA: 0xC32A10 Offset: 0xC31010 VA: 0x180C32A10
	private void AddMouseDelta() { }

	// RVA: 0xC32CE0 Offset: 0xC312E0 VA: 0x180C32CE0
	private void AdjustMouseMovement(ref Vector2 mm) { }

	// RVA: 0xC35860 Offset: 0xC33E60 VA: 0x180C35860
	private void UpdateViewAngles() { }

	// RVA: 0xC32F20 Offset: 0xC31520 VA: 0x180C32F20
	public void ApplyViewAngles() { }

	// RVA: 0xC35740 Offset: 0xC33D40 VA: 0x180C35740
	public void SetViewVars(Vector3 newAngles) { }

	// RVA: 0xC34440 Offset: 0xC32A40 VA: 0x180C34440
	public void FinalizeRecoil() { }

	// RVA: 0xC356D0 Offset: 0xC33CD0 VA: 0x180C356D0
	public void ResetOffsetAngles() { }

	// RVA: 0xC34410 Offset: 0xC32A10 VA: 0x180C34410
	public Quaternion ClientAngles() { }

	// RVA: 0xC34420 Offset: 0xC32A20 VA: 0x180C34420
	public Vector3 ClientLookVars() { }

	// RVA: 0xC23DB0 Offset: 0xC223B0 VA: 0x180C23DB0
	public Quaternion HeadAngles() { }

	// RVA: 0xC34BE0 Offset: 0xC331E0 VA: 0x180C34BE0
	public Vector3 HeadLookVars() { }

	// RVA: 0xC35550 Offset: 0xC33B50 VA: 0x180C35550
	private void ModifyInputState(InputMessage state) { }

	// RVA: 0xC35050 Offset: 0xC33650 VA: 0x180C35050
	internal bool IsButtonDownNative(BUTTON btn) { }

	// RVA: 0xC33AC0 Offset: 0xC320C0 VA: 0x180C33AC0
	private InputMessage BuildInputState(bool allowModify = True) { }

	// RVA: 0xC34F00 Offset: 0xC33500 VA: 0x180C34F00
	private bool IsAiming() { }

	// RVA: 0xC357D0 Offset: 0xC33DD0 VA: 0x180C357D0
	private void UpdateButton(InputMessage state, BUTTON btn) { }

	// RVA: 0xC34C00 Offset: 0xC33200 VA: 0x180C34C00
	public void IgnoreCurrentButtons() { }

	// RVA: 0xC35B70 Offset: 0xC34170 VA: 0x180C35B70
	private bool get_hasOnlyPartialKeyInput() { }

	// RVA: 0xC359E0 Offset: 0xC33FE0 VA: 0x180C359E0
	public static bool get_hasNoKeyInput() { }

	// RVA: 0xC35840 Offset: 0xC33E40 VA: 0x180C35840
	private void UpdateKeyFocus(bool hasFocus) { }

	// RVA: 0xC34D10 Offset: 0xC33310 VA: 0x180C34D10
	public static void IgnoreCurrentKeys() { }

	// RVA: 0xC35970 Offset: 0xC33F70 VA: 0x180C35970
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

	// RVA: 0xC42D40 Offset: 0xC41340 VA: 0x180C42D40
	public void SetMountedLookAtOverride(bool state) { }

	// RVA: 0xC43160 Offset: 0xC41760 VA: 0x180C43160
	private void SpineIk() { }

	// RVA: 0xC40F50 Offset: 0xC3F550 VA: 0x180C40F50
	private void ParentArmsToCamera() { }

	// RVA: 0xC405C0 Offset: 0xC3EBC0 VA: 0x180C405C0
	private void OnAnimatorIK() { }

	// RVA: 0xC3EC20 Offset: 0xC3D220 VA: 0x180C3EC20
	private void HandIK(float cameraDistSq) { }

	// RVA: 0xC3B430 Offset: 0xC39A30 VA: 0x180C3B430
	private void FootIK(float cameraDistSq) { }

	// RVA: 0xC3F080 Offset: 0xC3D680 VA: 0x180C3F080
	private void HeadIK(float cameraDistSq) { }

	// RVA: 0xC48A50 Offset: 0xC47050 VA: 0x180C48A50
	public bool get_ShouldDoLegs() { }

	// RVA: 0xC48AD0 Offset: 0xC470D0 VA: 0x180C48AD0
	public bool get_ShouldShowHands() { }

	// RVA: 0xC3A0D0 Offset: 0xC386D0 VA: 0x180C3A0D0
	private void ClearLegs() { }

	// RVA: 0xC41900 Offset: 0xC3FF00 VA: 0x180C41900
	public void RebuildLegs() { }

	// RVA: 0xC3F760 Offset: 0xC3DD60 VA: 0x180C3F760
	private void InitializeLegSpineBones() { }

	// RVA: 0xC44970 Offset: 0xC42F70 VA: 0x180C44970
	private void UpdateLegsBeforeRender() { }

	// RVA: 0xC45860 Offset: 0xC43E60 VA: 0x180C45860
	private void UpdateLegsDisable(bool forceDisable = False) { }

	// RVA: 0xC39600 Offset: 0xC37C00 VA: 0x180C39600
	private void AddLegRenderer(SkinnedMeshRenderer renderer, PaintableItem paintable) { }

	// RVA: 0xC43B50 Offset: 0xC42150 VA: 0x180C43B50
	private Transform SwapLegBone(Transform bone) { }

	// RVA: 0xC3E090 Offset: 0xC3C690 VA: 0x180C3E090
	private static Vector3 GetFlat(Vector3 dir) { }

	// RVA: 0xC41500 Offset: 0xC3FB00 VA: 0x180C41500
	public static void RebuildAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48DB0 Offset: 0xC473B0 VA: 0x180C48DB0
	public ulong get_overrideSkinSeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48DF0 Offset: 0xC473F0 VA: 0x180C48DF0
	private void set_overrideSkinSeed(ulong value) { }

	// RVA: 0xC48A00 Offset: 0xC47000 VA: 0x180C48A00
	public bool get_IsFemale() { }

	// RVA: 0xC48BB0 Offset: 0xC471B0 VA: 0x180C48BB0
	public SkinSetCollection get_SkinSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC488B0 Offset: 0xC46EB0 VA: 0x180C488B0
	public Quaternion get_AimAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48DC0 Offset: 0xC473C0 VA: 0x180C48DC0
	public void set_AimAngles(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48A40 Offset: 0xC47040 VA: 0x180C48A40
	public Quaternion get_LookAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48DE0 Offset: 0xC473E0 VA: 0x180C48DE0
	public void set_LookAngles(Quaternion value) { }

	// RVA: 0xC48960 Offset: 0xC46F60 VA: 0x180C48960
	private bool get_GestureAllowsSpineMovement() { }

	// RVA: 0xC488C0 Offset: 0xC46EC0 VA: 0x180C488C0
	private bool get_GestureAllowsRootMotion() { }

	// RVA: 0xC48A10 Offset: 0xC47010 VA: 0x180C48A10
	public bool get_IsFirstPerson() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48A30 Offset: 0xC47030 VA: 0x180C48A30
	public bool get_IsNpc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48DD0 Offset: 0xC473D0 VA: 0x180C48DD0
	public void set_IsNpc(bool value) { }

	// RVA: 0xC48D10 Offset: 0xC47310 VA: 0x180C48D10
	public SkinnedMultiMesh get_multiMesh() { }

	// RVA: 0xC48BD0 Offset: 0xC471D0 VA: 0x180C48BD0
	public Animator get_animator() { }

	// RVA: 0xC48C70 Offset: 0xC47270 VA: 0x180C48C70
	public LODGroup get_lodGroup() { }

	// RVA: 0xC3EAC0 Offset: 0xC3D0C0 VA: 0x180C3EAC0
	public Vector3 GetTargetVelocity() { }

	// RVA: 0xC3A030 Offset: 0xC38630 VA: 0x180C3A030
	protected void Awake() { }

	// RVA: 0xC409E0 Offset: 0xC3EFE0 VA: 0x180C409E0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC406F0 Offset: 0xC3ECF0 VA: 0x180C406F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC42620 Offset: 0xC40C20 VA: 0x180C42620
	private void SetDefaultAnimatorWeights() { }

	// RVA: 0xC45F00 Offset: 0xC44500 VA: 0x180C45F00
	private void UpdateMultiMesh(bool reset) { }

	// RVA: 0xC44090 Offset: 0xC42690 VA: 0x180C44090
	private void UpdateCensorship() { }

	// RVA: 0xC44510 Offset: 0xC42B10 VA: 0x180C44510
	public void UpdateCollider(bool visible, bool sleeping, bool ducking, bool crawling, bool incapacitated) { }

	// RVA: 0xC45EB0 Offset: 0xC444B0 VA: 0x180C45EB0
	public void UpdateModelState(ModelState ms) { }

	// RVA: 0xC46970 Offset: 0xC44F70 VA: 0x180C46970
	public void UpdatePosition() { }

	// RVA: 0xC46A90 Offset: 0xC45090 VA: 0x180C46A90
	internal void UpdateRotation() { }

	// RVA: 0xC45DE0 Offset: 0xC443E0 VA: 0x180C45DE0
	public void UpdateLocalVelocity(Vector3 velocity, Transform parent) { }

	// RVA: 0xC47410 Offset: 0xC45A10 VA: 0x180C47410
	public void UpdateVelocity() { }

	// RVA: 0xC46090 Offset: 0xC44690 VA: 0x180C46090
	private void UpdateParameters() { }

	// RVA: 0xC44780 Offset: 0xC42D80 VA: 0x180C44780
	public void UpdateFrom(PlayerModel mdl) { }

	// RVA: 0xC447E0 Offset: 0xC42DE0 VA: 0x180C447E0
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0xC3FF40 Offset: 0xC3E540 VA: 0x180C3FF40
	public void LateCycle() { }

	// RVA: 0xC3D6A0 Offset: 0xC3BCA0 VA: 0x180C3D6A0
	public void FrameUpdate() { }

	// RVA: 0xC3CCC0 Offset: 0xC3B2C0 VA: 0x180C3CCC0
	private void FrameUpdate_Default() { }

	// RVA: 0xC3D3D0 Offset: 0xC3B9D0 VA: 0x180C3D3D0
	private void FrameUpdate_Sleeping() { }

	// RVA: 0xC3CE30 Offset: 0xC3B430 VA: 0x180C3CE30
	private void FrameUpdate_Incapacitated() { }

	// RVA: 0xC3D100 Offset: 0xC3B700 VA: 0x180C3D100
	private void FrameUpdate_OnLadder() { }

	// RVA: 0xC3DE20 Offset: 0xC3C420 VA: 0x180C3DE20
	public float GetAim360() { }

	// RVA: 0xC46F20 Offset: 0xC45520 VA: 0x180C46F20
	public void UpdateVehicleAim360() { }

	// RVA: 0xC424D0 Offset: 0xC40AD0 VA: 0x180C424D0
	public void ResetCurrentState(int layer = 0) { }

	// RVA: 0xC3ABD0 Offset: 0xC391D0 VA: 0x180C3ABD0
	private void DoAimingSounds(float prevAiming, float currentAiming) { }

	// RVA: 0xC425E0 Offset: 0xC40BE0 VA: 0x180C425E0
	public void SetAimSounds(SoundDefinition aimDef, SoundDefinition aimEndDef) { }

	// RVA: 0xC42D50 Offset: 0xC41350 VA: 0x180C42D50
	public void SetMountedLookAtWeight(float weight) { }

	// RVA: 0xC42D30 Offset: 0xC41330 VA: 0x180C42D30
	public void SetMountedAnimationSpeed(float speed) { }

	// RVA: 0xC45A90 Offset: 0xC44090 VA: 0x180C45A90
	internal void UpdateLocalPlayerPosition(Vector3 position, Quaternion quaternion) { }

	// RVA: 0xC39FB0 Offset: 0xC385B0 VA: 0x180C39FB0
	public void Attack() { }

	// RVA: 0xC39C70 Offset: 0xC38270 VA: 0x180C39C70
	public void AltAttack() { }

	// RVA: 0xC3AB20 Offset: 0xC39120 VA: 0x180C3AB20
	public void Deploy() { }

	// RVA: 0xC42250 Offset: 0xC40850 VA: 0x180C42250
	public void Reload() { }

	// RVA: 0xC3F6E0 Offset: 0xC3DCE0 VA: 0x180C3F6E0
	public void Holster() { }

	// RVA: 0xC3B3D0 Offset: 0xC399D0 VA: 0x180C3B3D0
	public void Flinch(uint location) { }

	// RVA: 0xC3B400 Offset: 0xC39A00 VA: 0x180C3B400
	public void Flinch() { }

	// RVA: 0xC42D60 Offset: 0xC41360 VA: 0x180C42D60
	public void SetReactionAnim(PlayerModel.ReactionDir direction, float weight) { }

	// RVA: 0xC40F20 Offset: 0xC3F520 VA: 0x180C40F20
	public void OnReactionEnded() { }

	// RVA: 0xC43E80 Offset: 0xC42480 VA: 0x180C43E80
	public void Throw() { }

	// RVA: 0xC3DA90 Offset: 0xC3C090 VA: 0x180C3DA90
	public void Gesture(string gesture, GestureConfig forConfig) { }

	// RVA: 0xC3AE30 Offset: 0xC39430 VA: 0x180C3AE30
	private void FadeInGestureUpperBodyLayer() { }

	// RVA: 0xC3B120 Offset: 0xC39720 VA: 0x180C3B120
	private void FadeOutGestureUpperBodyLayer() { }

	// RVA: 0xC3AD10 Offset: 0xC39310 VA: 0x180C3AD10
	private void FadeInGestureFullBodyLayer() { }

	// RVA: 0xC3AF50 Offset: 0xC39550 VA: 0x180C3AF50
	private void FadeOutGestureFullBodyLayer() { }

	// RVA: 0xC39D20 Offset: 0xC38320 VA: 0x180C39D20
	private void AnimatorWarmup() { }

	// RVA: 0xC39CF0 Offset: 0xC382F0 VA: 0x180C39CF0
	public void AlwaysAnimate(bool b) { }

	// RVA: 0xC429B0 Offset: 0xC40FB0 VA: 0x180C429B0
	public void SetHoldType(RuntimeAnimatorController holdType, bool suppressHandLayer = False) { }

	// RVA: 0xC429A0 Offset: 0xC40FA0 VA: 0x180C429A0
	public void SetHasHeldEntity(bool state) { }

	[IteratorStateMachineAttribute] // RVA: 0x80940 Offset: 0x7FD40 VA: 0x180080940
	// RVA: 0xC3B0B0 Offset: 0xC396B0 VA: 0x180C3B0B0
	public IEnumerator FadeOutGestureLayer() { }

	// RVA: 0xC42750 Offset: 0xC40D50 VA: 0x180C42750
	public void SetGesture() { }

	// RVA: 0xC3B280 Offset: 0xC39880 VA: 0x180C3B280
	public void FadeOutPlayerGestureLayers() { }

	// RVA: 0xC43A50 Offset: 0xC42050 VA: 0x180C43A50
	public void StopGesture() { }

	// RVA: 0xC41370 Offset: 0xC3F970 VA: 0x180C41370
	public void PlayCinematic(string name, float overrideSpeed = 1) { }

	// RVA: 0xC439F0 Offset: 0xC41FF0 VA: 0x180C439F0
	public void StopCinematic() { }

	// RVA: 0xC43140 Offset: 0xC41740 VA: 0x180C43140
	public void SetSpeedOverride(Vector3 speed) { }

	// RVA: 0xC3EA00 Offset: 0xC3D000 VA: 0x180C3EA00
	public Underwear GetReplacementUnderwear() { }

	// RVA: 0xC423A0 Offset: 0xC409A0 VA: 0x180C423A0
	public void RemoveUnderwearParts(SkinReplacement.SkinType typeToRemove) { }

	// RVA: 0xC3A230 Offset: 0xC38830 VA: 0x180C3A230
	public void Clear() { }

	// RVA: 0xC41CC0 Offset: 0xC402C0 VA: 0x180C41CC0
	public void Rebuild(bool reset = True) { }

	// RVA: 0xC39990 Offset: 0xC37F90 VA: 0x180C39990
	public void AddPart(string strName, Item item) { }

	// RVA: 0xC422D0 Offset: 0xC408D0 VA: 0x180C422D0
	public void RemovePart(string strName) { }

	// RVA: 0xC3EFC0 Offset: 0xC3D5C0 VA: 0x180C3EFC0
	public bool HasPart(string strName) { }

	// RVA: 0xC3FEB0 Offset: 0xC3E4B0 VA: 0x180C3FEB0
	public bool IsBarefoot() { }

	// RVA: 0xC3EA40 Offset: 0xC3D040 VA: 0x180C3EA40
	public Color GetSkinColor() { }

	// RVA: 0xC43020 Offset: 0xC41620 VA: 0x180C43020
	public void SetSkinProperties(MaterialPropertyBlock block) { }

	// RVA: 0xC41EC0 Offset: 0xC404C0 VA: 0x180C41EC0
	public void RefreshUnderwear() { }

	// RVA: 0xC3CA90 Offset: 0xC3B090 VA: 0x180C3CA90
	public void ForceModelSeed(ulong userID) { }

	// RVA: 0xC3CBA0 Offset: 0xC3B1A0 VA: 0x180C3CBA0
	public void ForceModelSeed(ulong userID, bool storeSkinChange) { }

	// RVA: 0xC3B3A0 Offset: 0xC399A0 VA: 0x180C3B3A0
	public Transform FindBone(string strName) { }

	// RVA: 0xC3E060 Offset: 0xC3C660 VA: 0x180C3E060
	public Transform[] GetBones() { }

	// RVA: 0xC3E0D0 Offset: 0xC3C6D0 VA: 0x180C3E0D0
	private Vector3 GetFootPlacement(Vector3 footPos, out Vector3 surfaceNormal) { }

	// RVA: 0xC39D80 Offset: 0xC38380 VA: 0x180C39D80
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0xC43F20 Offset: 0xC42520 VA: 0x180C43F20
	public void ToggleUpdateOffscreen(bool state) { }

	// RVA: 0xC40E20 Offset: 0xC3F420 VA: 0x180C40E20 Slot: 8
	public void OnParentDestroying() { }

	// RVA: 0xC47820 Offset: 0xC45E20 VA: 0x180C47820
	public void WorkshopPreviewSetup(GameObject[] objects) { }

	// RVA: 0xC48700 Offset: 0xC46D00 VA: 0x180C48700
	public void .ctor() { }

	// RVA: 0xC481C0 Offset: 0xC467C0 VA: 0x180C481C0
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

	// RVA: 0xC49240 Offset: 0xC47840 VA: 0x180C49240
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC491E0 Offset: 0xC477E0 VA: 0x180C491E0
	internal bool <UpdateCensorship>b__199_0(Wearable x) { }

	// RVA: 0xC49200 Offset: 0xC47800 VA: 0x180C49200
	internal bool <UpdateCensorship>b__199_1(Wearable x) { }

	// RVA: 0xC49220 Offset: 0xC47820 VA: 0x180C49220
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

	// RVA: 0xC48E00 Offset: 0xC47400 VA: 0x180C48E00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC49190 Offset: 0xC47790 VA: 0x180C49190 Slot: 8
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

	// RVA: 0xC38B90 Offset: 0xC37190 VA: 0x180C38B90 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0xC38BF0 Offset: 0xC371F0 VA: 0x180C38BF0 Slot: 5
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xC38C20 Offset: 0xC37220 VA: 0x180C38C20
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

	// RVA: 0x98D0A0 Offset: 0x98B6A0 VA: 0x18098D0A0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7B40 Offset: 0x6A6140 VA: 0x1806A7B40
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

	// RVA: 0x98DCC0 Offset: 0x98C2C0 VA: 0x18098DCC0
	public void Initialize(BasePlayer player, Transform parent) { }

	// RVA: 0x98E1E0 Offset: 0x98C7E0 VA: 0x18098E1E0
	public void UpdateFrom(BasePlayer player) { }

	// RVA: 0x98DF70 Offset: 0x98C570 VA: 0x18098DF70
	private void LateUpdate() { }

	// RVA: 0x98E340 Offset: 0x98C940 VA: 0x18098E340
	private void UpdateNameColor() { }

	// RVA: 0x98E0C0 Offset: 0x98C6C0 VA: 0x18098E0C0
	public void PositionUpdate(bool visible) { }

	// RVA: 0x98E590 Offset: 0x98CB90 VA: 0x18098E590
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

	// RVA: 0x98F470 Offset: 0x98DA70 VA: 0x18098F470
	public bool get_IsSpeaking() { }

	// RVA: 0x98E6D0 Offset: 0x98CCD0 VA: 0x18098E6D0
	public void ClientFrame(BasePlayer player) { }

	// RVA: 0x98EC90 Offset: 0x98D290 VA: 0x18098EC90
	public void ClientInput(InputState state) { }

	// RVA: 0x98EE00 Offset: 0x98D400 VA: 0x18098EE00
	private bool DoesUserWantToTalk() { }

	// RVA: 0x98E5F0 Offset: 0x98CBF0 VA: 0x18098E5F0
	public bool CanTalk() { }

	// RVA: 0x98F180 Offset: 0x98D780 VA: 0x18098F180
	public void StopRecording() { }

	// RVA: 0x98EFD0 Offset: 0x98D5D0 VA: 0x18098EFD0
	public void StartRecording() { }

	// RVA: 0x98F400 Offset: 0x98DA00 VA: 0x18098F400
	public void .ctor() { }

	// RVA: 0x98F380 Offset: 0x98D980 VA: 0x18098F380
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

	// RVA: 0x9904A0 Offset: 0x98EAA0 VA: 0x1809904A0
	public float get_currentVolume() { }

	// RVA: 0x98FD00 Offset: 0x98E300 VA: 0x18098FD00
	public bool IsSpeaking() { }

	// RVA: 0x98FD90 Offset: 0x98E390 VA: 0x18098FD90
	public void Receive(byte[] data) { }

	// RVA: 0x98F990 Offset: 0x98DF90 VA: 0x18098F990
	public float GetMouthVolume() { }

	// RVA: 0x98F4A0 Offset: 0x98DAA0 VA: 0x18098F4A0
	public void ClientFrame() { }

	// RVA: 0x990120 Offset: 0x98E720 VA: 0x180990120
	public bool ShouldMuteVoice() { }

	// RVA: 0x98FC00 Offset: 0x98E200 VA: 0x18098FC00
	private bool IsPlayingLocalVoice() { }

	// RVA: 0x990240 Offset: 0x98E840 VA: 0x180990240
	public bool ShouldReceiveVoice() { }

	// RVA: 0x990460 Offset: 0x98EA60 VA: 0x180990460
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

	// RVA: 0x990580 Offset: 0x98EB80 VA: 0x180990580
	protected void Awake() { }

	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0 Slot: 6
	public override Collider GetCollider() { }

	// RVA: 0x995470 Offset: 0x993A70 VA: 0x180995470
	protected void OnDisable() { }

	// RVA: 0x992CA0 Offset: 0x9912A0 VA: 0x180992CA0 Slot: 7
	public override void Init(BasePlayer player) { }

	// RVA: 0x9952B0 Offset: 0x9938B0 VA: 0x1809952B0
	protected void OnCollisionEnter(Collision collision) { }

	// RVA: 0x995390 Offset: 0x993990 VA: 0x180995390
	protected void OnCollisionStay(Collision collision) { }

	// RVA: 0x992460 Offset: 0x990A60 VA: 0x180992460
	private void GroundCheck(Collision collision) { }

	// RVA: 0x995B20 Offset: 0x994120 VA: 0x180995B20 Slot: 13
	public override void TeleportTo(Vector3 position, BasePlayer player) { }

	// RVA: 0x995E50 Offset: 0x994450 VA: 0x180995E50
	public void UpdateCurrentLadder(InputState input, bool force = False) { }

	// RVA: 0x996EC0 Offset: 0x9954C0 VA: 0x180996EC0
	public static bool WantsSprint(InputState input) { }

	// RVA: 0x990870 Offset: 0x98EE70 VA: 0x180990870 Slot: 10
	public override void ClientInput(InputState input, ModelState modelState) { }

	// RVA: 0x994700 Offset: 0x992D00 VA: 0x180994700
	private void Movement_Water(InputState input, ModelState modelState) { }

	// RVA: 0x9937E0 Offset: 0x991DE0 VA: 0x1809937E0
	private void Movement_Mounted(InputState input, ModelState modelState) { }

	// RVA: 0x993190 Offset: 0x991790 VA: 0x180993190
	private void Movement_Ladder(InputState input, ModelState modelState) { }

	// RVA: 0x9938F0 Offset: 0x991EF0 VA: 0x1809938F0
	private void Movement_Noclip(InputState input, ModelState modelState) { }

	// RVA: 0x993E80 Offset: 0x992480 VA: 0x180993E80
	private void Movement_Walking(InputState input, ModelState modelState) { }

	// RVA: 0x9923B0 Offset: 0x9909B0 VA: 0x1809923B0
	private float GetHeldEntityMovementMultiplier() { }

	// RVA: 0x992730 Offset: 0x990D30 VA: 0x180992730
	private void HandleGrounded(ModelState state, bool wantsGrounded) { }

	// RVA: 0x9928B0 Offset: 0x990EB0 VA: 0x1809928B0
	private void HandleRunDuckCrawl(ModelState state, bool wantsRun, bool wantsDuck, bool wantsCrawl) { }

	// RVA: 0x9922C0 Offset: 0x9908C0 VA: 0x1809922C0
	private float GetForcedDuck() { }

	// RVA: 0x992780 Offset: 0x990D80 VA: 0x180992780
	private void HandleJumping(ModelState state, bool wantsJump, bool jumpInDirection = False) { }

	// RVA: 0x9906F0 Offset: 0x98ECF0 VA: 0x1809906F0
	private bool CanJump() { }

	// RVA: 0x990660 Offset: 0x98EC60 VA: 0x180990660 Slot: 8
	public override void BlockJump(float duration) { }

	// RVA: 0x9906A0 Offset: 0x98ECA0 VA: 0x1809906A0 Slot: 9
	public override void BlockSprint(float duration) { }

	// RVA: 0x9958F0 Offset: 0x993EF0 VA: 0x1809958F0
	public void SetKinematic(bool kinematic) { }

	// RVA: 0x990540 Offset: 0x98EB40 VA: 0x180990540
	public void ApplyForce(Vector3 force) { }

	// RVA: 0x990800 Offset: 0x98EE00 VA: 0x180990800
	private bool CanSprint() { }

	// RVA: 0x992E70 Offset: 0x991470 VA: 0x180992E70
	private void Jump(ModelState state, bool inDirection) { }

	// RVA: 0x990C20 Offset: 0x98F220 VA: 0x180990C20 Slot: 11
	public override void DoFixedUpdate(ModelState modelState) { }

	// RVA: 0x991440 Offset: 0x98FA40 VA: 0x180991440
	public void DoStepUp() { }

	// RVA: 0x996370 Offset: 0x994970 VA: 0x180996370
	private void UpdateVelocity() { }

	// RVA: 0x996020 Offset: 0x994620 VA: 0x180996020
	private void UpdateGravity(ModelState modelState) { }

	// RVA: 0x991E10 Offset: 0x990410 VA: 0x180991E10 Slot: 12
	public override void FrameUpdate(BasePlayer player, ModelState state) { }

	// RVA: 0x995C40 Offset: 0x994240 VA: 0x180995C40
	private void TransformState(Matrix4x4 matrix) { }

	// RVA: 0x995920 Offset: 0x993F20 VA: 0x180995920 Slot: 15
	public override void SetParent(Transform parent) { }

	// RVA: 0x991D60 Offset: 0x990360 VA: 0x180991D60
	private Vector3 FallVelocity() { }

	// RVA: 0x990BE0 Offset: 0x98F1E0 VA: 0x180990BE0 Slot: 4
	public override Vector3 CurrentVelocity() { }

	// RVA: 0x990B90 Offset: 0x98F190 VA: 0x180990B90 Slot: 5
	public override float CurrentMoveSpeed() { }

	// RVA: 0x995890 Offset: 0x993E90 VA: 0x180995890 Slot: 16
	public override void PlayerAttemptedMount() { }

	// RVA: 0x9958C0 Offset: 0x993EC0 VA: 0x1809958C0 Slot: 17
	public override void PlayerCompletedMount() { }

	// RVA: 0x996F50 Offset: 0x995550 VA: 0x180996F50
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

	// RVA: 0xC2CA00 Offset: 0xC2B000 VA: 0x180C2CA00 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xC2CCF0 Offset: 0xC2B2F0 VA: 0x180C2CCF0
	private void RebuildWorldModel() { }

	// RVA: 0xC2CA20 Offset: 0xC2B020 VA: 0x180C2CA20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xC2CBB0 Offset: 0xC2B1B0 VA: 0x180C2CBB0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xC2D110 Offset: 0xC2B710 VA: 0x180C2D110
	private void ToggleClientBuoyancy(bool isBuoyant) { }

	// RVA: 0xC2C9D0 Offset: 0xC2AFD0 VA: 0x180C2C9D0 Slot: 122
	public override string Categorize() { }

	// RVA: 0xC2D230 Offset: 0xC2B830 VA: 0x180C2D230
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

	// RVA: 0xC35BD0 Offset: 0xC341D0 VA: 0x180C35BD0
	public void .ctor() { }

}

public class PlayerInventoryProperties.ItemAmountSkinned : ItemAmount // TypeDefIndex: 10750
{	// Fields
	public ulong skinOverride; // 0x20

	// Methods

	// RVA: 0xC2C9C0 Offset: 0xC2AFC0 VA: 0x180C2C9C0
	public void .ctor() { }

}

public class PlayerDetectedEventUI : BaseEventUI // TypeDefIndex: 10807
{	// Methods

	// RVA: 0x88B190 Offset: 0x889790 VA: 0x18088B190 Slot: 4
	public override void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0xC2D2F0 Offset: 0xC2B8F0 VA: 0x180C2D2F0 Slot: 5
	public override AIEventData Save() { }

	// RVA: 0xC2D280 Offset: 0xC2B880 VA: 0x180C2D280 Slot: 6
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

