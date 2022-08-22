internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 3475
{	// Methods

	// RVA: 0x18FA700 Offset: 0x18F8D00 VA: 0x1818FA700 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FA820 Offset: 0x18F8E20 VA: 0x1818FA820 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FA560 Offset: 0x18F8B60 VA: 0x1818FA560 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x18FA690 Offset: 0x18F8C90 VA: 0x1818FA690 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x18FA940 Offset: 0x18F8F40 VA: 0x1818FA940 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x18FA500 Offset: 0x18F8B00 VA: 0x1818FA500 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x18FA530 Offset: 0x18F8B30 VA: 0x1818FA530 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x18FA4D0 Offset: 0x18F8AD0 VA: 0x1818FA4D0 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunctionAttribute] // RVA: 0xB0AA0 Offset: 0xAFEA0 VA: 0x1800B0AA0
	// RVA: 0x18FA530 Offset: 0x18F8B30 VA: 0x1818FA530
	private static bool IsConnected() { }

	[FreeFunctionAttribute] // RVA: 0xB0B30 Offset: 0xAFF30 VA: 0x1800B0B30
	// RVA: 0x18FA500 Offset: 0x18F8B00 VA: 0x1818FA500
	private static void Initialize() { }

	[FreeFunctionAttribute] // RVA: 0xB0BD0 Offset: 0xAFFD0 VA: 0x1800B0BD0
	// RVA: 0x18FA590 Offset: 0x18F8B90 VA: 0x1818FA590
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB0C30 Offset: 0xB0030 VA: 0x1800B0C30
	// RVA: 0x18FA9B0 Offset: 0x18F8FB0 VA: 0x1818FA9B0
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB1F90 Offset: 0xB1390 VA: 0x1800B1F90
	// RVA: 0x18FA5D0 Offset: 0x18F8BD0 VA: 0x1818FA5D0
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB2080 Offset: 0xB1480 VA: 0x1800B2080
	// RVA: 0x18FA630 Offset: 0x18F8C30 VA: 0x1818FA630
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB22B0 Offset: 0xB16B0 VA: 0x1800B22B0
	// RVA: 0x18FA560 Offset: 0x18F8B60 VA: 0x1818FA560
	private static void PollInternal() { }

	[FreeFunctionAttribute] // RVA: 0xB2390 Offset: 0xB1790 VA: 0x1800B2390
	// RVA: 0x18FA4D0 Offset: 0x18F8AD0 VA: 0x1818FA4D0
	private static void DisconnectAll() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class PlayerPrefsException : Exception // TypeDefIndex: 3476
{	// Methods

	// RVA: 0x18FC7A0 Offset: 0x18FADA0 VA: 0x1818FC7A0
	public void .ctor(string error) { }

}

public class PlayerPrefs // TypeDefIndex: 3477
{	// Methods

	[NativeMethodAttribute] // RVA: 0xB2540 Offset: 0xB1940 VA: 0x1800B2540
	// RVA: 0x18FCC80 Offset: 0x18FB280 VA: 0x1818FCC80
	private static bool TrySetInt(string key, int value) { }

	[NativeMethodAttribute] // RVA: 0xB27D0 Offset: 0xB1BD0 VA: 0x1800B27D0
	// RVA: 0x18FCC30 Offset: 0x18FB230 VA: 0x1818FCC30
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethodAttribute] // RVA: 0xB28E0 Offset: 0xB1CE0 VA: 0x1800B28E0
	// RVA: 0x18FCCC0 Offset: 0x18FB2C0 VA: 0x1818FCCC0
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x18FCB00 Offset: 0x18FB100 VA: 0x1818FCB00
	public static void SetInt(string key, int value) { }

	// RVA: 0x18FC8E0 Offset: 0x18FAEE0 VA: 0x1818FC8E0
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x18FC920 Offset: 0x18FAF20 VA: 0x1818FC920
	public static int GetInt(string key) { }

	// RVA: 0x18FCA60 Offset: 0x18FB060 VA: 0x1818FCA60
	public static void SetFloat(string key, float value) { }

	// RVA: 0x18FC850 Offset: 0x18FAE50 VA: 0x1818FC850
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x18FC8A0 Offset: 0x18FAEA0 VA: 0x1818FC8A0
	public static float GetFloat(string key) { }

	// RVA: 0x18FCB90 Offset: 0x18FB190 VA: 0x1818FCB90
	public static void SetString(string key, string value) { }

	// RVA: 0x18FC9D0 Offset: 0x18FAFD0 VA: 0x1818FC9D0
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x18FC960 Offset: 0x18FAF60 VA: 0x1818FC960
	public static string GetString(string key) { }

	// RVA: 0x18FCA20 Offset: 0x18FB020 VA: 0x1818FCA20
	public static bool HasKey(string key) { }

	// RVA: 0x18FC810 Offset: 0x18FAE10 VA: 0x1818FC810
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

	// RVA: 0x14638B0 Offset: 0x1461EB0 VA: 0x1814638B0 Slot: 12
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

	// RVA: 0x18FBE20 Offset: 0x18FA420 VA: 0x1818FBE20
	public static PlayerConnection get_instance() { }

	// RVA: 0x18FBFD0 Offset: 0x18FA5D0 VA: 0x1818FBFD0
	public bool get_isConnected() { }

	// RVA: 0x18FACE0 Offset: 0x18F92E0 VA: 0x1818FACE0
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x18FB030 Offset: 0x18F9630 VA: 0x1818FB030
	public void OnEnable() { }

	// RVA: 0x18FAEA0 Offset: 0x18F94A0 VA: 0x1818FAEA0
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x18FB290 Offset: 0x18F9890 VA: 0x1818FB290 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FBA10 Offset: 0x18FA010 VA: 0x1818FBA10 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FB0D0 Offset: 0x18F96D0 VA: 0x1818FB0D0 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18FB230 Offset: 0x18F9830 VA: 0x1818FB230 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18FB950 Offset: 0x18F9F50 VA: 0x1818FB950 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18FB9B0 Offset: 0x18F9FB0 VA: 0x1818FB9B0 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18FB5F0 Offset: 0x18F9BF0 VA: 0x1818FB5F0 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x18FB7A0 Offset: 0x18F9DA0 VA: 0x1818FB7A0 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x18FA9F0 Offset: 0x18F8FF0 VA: 0x1818FA9F0
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x18FAD90 Offset: 0x18F9390 VA: 0x1818FAD90 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FAF00 Offset: 0x18F9500 VA: 0x1818FAF00
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FAC60 Offset: 0x18F9260 VA: 0x1818FAC60
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FAE20 Offset: 0x18F9420 VA: 0x1818FAE20
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x18FBCA0 Offset: 0x18FA2A0 VA: 0x1818FBCA0
	public void .ctor() { }

}

private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 3790
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1900D90 Offset: 0x18FF390 VA: 0x181900D90
	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 3791
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1900E40 Offset: 0x18FF440 VA: 0x181900E40
	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 3792
{	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10217D0 Offset: 0x101FDD0 VA: 0x1810217D0
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

	// RVA: 0x18FC240 Offset: 0x18FA840 VA: 0x1818FC240
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18FC060 Offset: 0x18FA660 VA: 0x1818FC060
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x18FC590 Offset: 0x18FAB90 VA: 0x1818FC590
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18FC6A0 Offset: 0x18FACA0 VA: 0x1818FC6A0
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 3794
{	// Methods

	// RVA: 0x18F67E0 Offset: 0x18F4DE0 VA: 0x1818F67E0
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 3795
{	// Methods

	// RVA: 0x18E8CE0 Offset: 0x18E72E0 VA: 0x1818E8CE0
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

	// RVA: 0x18F68B0 Offset: 0x18F4EB0 VA: 0x1818F68B0
	public Guid get_MessageTypeId() { }

	// RVA: 0x18F68F0 Offset: 0x18F4EF0 VA: 0x1818F68F0
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x18F6820 Offset: 0x18F4E20 VA: 0x1818F6820
	public void .ctor() { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 3797
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1900EF0 Offset: 0x18FF4F0 VA: 0x181900EF0
	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 3798
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1900FA0 Offset: 0x18FF5A0 VA: 0x181900FA0
	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 3799
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1901050 Offset: 0x18FF650 VA: 0x181901050
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

	// RVA: 0x2300DB0 Offset: 0x22FF3B0 VA: 0x182300DB0
	public static bool op_Equality(PlayerItemRecipe left, PlayerItemRecipe right) { }

	// RVA: 0x2300DD0 Offset: 0x22FF3D0 VA: 0x182300DD0
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
	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	public int get_Amount() { }

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int definitionId, int amount) { }

	// RVA: 0xF9CF0 Offset: 0xF90F0 VA: 0x1800F9CF0 Slot: 4
	public bool Equals(PlayerItemRecipe.Ingredient other) { }

	// RVA: 0x23F4B0 Offset: 0x23E8B0 VA: 0x18023F4B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23F540 Offset: 0x23E940 VA: 0x18023F540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x890B30 Offset: 0x88F130 VA: 0x180890B30
	public static bool op_Equality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

	// RVA: 0x890B50 Offset: 0x88F150 VA: 0x180890B50
	public static bool op_Inequality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

}

private sealed class PlayerItemRecipe.<>c // TypeDefIndex: 5700
{	// Fields
	public static readonly PlayerItemRecipe.<>c <>9; // 0x0
	public static Func<PlayerItemRecipe.Ingredient, int> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x2301620 Offset: 0x22FFC20 VA: 0x182301620
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2301560 Offset: 0x22FFB60 VA: 0x182301560
	internal int <GetHashCode>b__10_0(PlayerItemRecipe.Ingredient i) { }

}

public static class PlayerItemExtensions // TypeDefIndex: 6156
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2316770 Offset: 0x2314D70 VA: 0x182316770
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

	// RVA: 0x2022010 Offset: 0x2020610 VA: 0x182022010
	public static void ResetToPool(PlayerTick instance) { }

	// RVA: 0x2022150 Offset: 0x2020750 VA: 0x182022150
	public void ResetToPool() { }

	// RVA: 0x2021B00 Offset: 0x2020100 VA: 0x182021B00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2020060 Offset: 0x201E660 VA: 0x182020060
	public void CopyTo(PlayerTick instance) { }

	// RVA: 0x2020290 Offset: 0x201E890 VA: 0x182020290
	public PlayerTick Copy() { }

	// RVA: 0x2020C20 Offset: 0x201F220 VA: 0x182020C20
	public static PlayerTick Deserialize(Stream stream) { }

	// RVA: 0x2020310 Offset: 0x201E910 VA: 0x182020310
	public static PlayerTick DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20207A0 Offset: 0x201EDA0 VA: 0x1820207A0
	public static PlayerTick DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20216E0 Offset: 0x201FCE0 VA: 0x1820216E0
	public static PlayerTick Deserialize(byte[] buffer) { }

	// RVA: 0x2021CC0 Offset: 0x20202C0 VA: 0x182021CC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2022FE0 Offset: 0x20215E0 VA: 0x182022FE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2023000 Offset: 0x2021600 VA: 0x182023000 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTick previous) { }

	// RVA: 0x2021FF0 Offset: 0x20205F0 VA: 0x182021FF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2020F90 Offset: 0x201F590 VA: 0x182020F90
	public static PlayerTick Deserialize(byte[] buffer, PlayerTick instance, bool isDelta = False) { }

	// RVA: 0x20213B0 Offset: 0x201F9B0 VA: 0x1820213B0
	public static PlayerTick Deserialize(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x2020390 Offset: 0x201E990 VA: 0x182020390
	public static PlayerTick DeserializeLengthDelimited(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x2020830 Offset: 0x201EE30 VA: 0x182020830
	public static PlayerTick DeserializeLength(Stream stream, int length, PlayerTick instance, bool isDelta) { }

	// RVA: 0x2022290 Offset: 0x2020890 VA: 0x182022290
	public static void SerializeDelta(Stream stream, PlayerTick instance, PlayerTick previous) { }

	// RVA: 0x2022B00 Offset: 0x2021100 VA: 0x182022B00
	public static void Serialize(Stream stream, PlayerTick instance) { }

	// RVA: 0x2022FD0 Offset: 0x20215D0 VA: 0x182022FD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2022FE0 Offset: 0x20215E0 VA: 0x182022FE0
	public void ToProto(Stream stream) { }

	// RVA: 0x20229F0 Offset: 0x2020FF0 VA: 0x1820229F0
	public static byte[] SerializeToBytes(PlayerTick instance) { }

	// RVA: 0x2022940 Offset: 0x2020F40 VA: 0x182022940
	public static void SerializeLengthDelimited(Stream stream, PlayerTick instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2004690 Offset: 0x2002C90 VA: 0x182004690
	public static void ResetToPool(BasePlayer instance) { }

	// RVA: 0x2004350 Offset: 0x2002950 VA: 0x182004350
	public void ResetToPool() { }

	// RVA: 0x2004290 Offset: 0x2002890 VA: 0x182004290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20023F0 Offset: 0x20009F0 VA: 0x1820023F0
	public void CopyTo(BasePlayer instance) { }

	// RVA: 0x20026A0 Offset: 0x2000CA0 VA: 0x1820026A0
	public BasePlayer Copy() { }

	// RVA: 0x2003890 Offset: 0x2001E90 VA: 0x182003890
	public static BasePlayer Deserialize(Stream stream) { }

	// RVA: 0x2002720 Offset: 0x2000D20 VA: 0x182002720
	public static BasePlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2002FE0 Offset: 0x20015E0 VA: 0x182002FE0
	public static BasePlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2003910 Offset: 0x2001F10 VA: 0x182003910
	public static BasePlayer Deserialize(byte[] buffer) { }

	// RVA: 0x2004310 Offset: 0x2002910 VA: 0x182004310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2006490 Offset: 0x2004A90 VA: 0x182006490 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20064B0 Offset: 0x2004AB0 VA: 0x1820064B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BasePlayer previous) { }

	// RVA: 0x2004330 Offset: 0x2002930 VA: 0x182004330 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2004190 Offset: 0x2002790 VA: 0x182004190
	public static BasePlayer Deserialize(byte[] buffer, BasePlayer instance, bool isDelta = False) { }

	// RVA: 0x2003A30 Offset: 0x2002030 VA: 0x182003A30
	public static BasePlayer Deserialize(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x20027A0 Offset: 0x2000DA0 VA: 0x1820027A0
	public static BasePlayer DeserializeLengthDelimited(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x2003070 Offset: 0x2001670 VA: 0x182003070
	public static BasePlayer DeserializeLength(Stream stream, int length, BasePlayer instance, bool isDelta) { }

	// RVA: 0x20049D0 Offset: 0x2002FD0 VA: 0x1820049D0
	public static void SerializeDelta(Stream stream, BasePlayer instance, BasePlayer previous) { }

	// RVA: 0x2005940 Offset: 0x2003F40 VA: 0x182005940
	public static void Serialize(Stream stream, BasePlayer instance) { }

	// RVA: 0x2006480 Offset: 0x2004A80 VA: 0x182006480
	public byte[] ToProtoBytes() { }

	// RVA: 0x2006490 Offset: 0x2004A90 VA: 0x182006490
	public void ToProto(Stream stream) { }

	// RVA: 0x2005830 Offset: 0x2003E30 VA: 0x182005830
	public static byte[] SerializeToBytes(BasePlayer instance) { }

	// RVA: 0x2005780 Offset: 0x2003D80 VA: 0x182005780
	public static void SerializeLengthDelimited(Stream stream, BasePlayer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x20440A0 Offset: 0x20426A0 VA: 0x1820440A0
	public static void ResetToPool(PlayerTeam instance) { }

	// RVA: 0x20442F0 Offset: 0x20428F0 VA: 0x1820442F0
	public void ResetToPool() { }

	// RVA: 0x2043CA0 Offset: 0x20422A0 VA: 0x182043CA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20421B0 Offset: 0x20407B0 VA: 0x1820421B0
	public void CopyTo(PlayerTeam instance) { }

	// RVA: 0x20423F0 Offset: 0x20409F0 VA: 0x1820423F0
	public PlayerTeam Copy() { }

	// RVA: 0x20431A0 Offset: 0x20417A0 VA: 0x1820431A0
	public static PlayerTeam Deserialize(Stream stream) { }

	// RVA: 0x2042470 Offset: 0x2040A70 VA: 0x182042470
	public static PlayerTeam DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2042920 Offset: 0x2040F20 VA: 0x182042920
	public static PlayerTeam DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2042DB0 Offset: 0x20413B0 VA: 0x182042DB0
	public static PlayerTeam Deserialize(byte[] buffer) { }

	// RVA: 0x2043D20 Offset: 0x2042320 VA: 0x182043D20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2044F60 Offset: 0x2043560 VA: 0x182044F60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2044F80 Offset: 0x2043580 VA: 0x182044F80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam previous) { }

	// RVA: 0x2044080 Offset: 0x2042680 VA: 0x182044080 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2043860 Offset: 0x2041E60 VA: 0x182043860
	public static PlayerTeam Deserialize(byte[] buffer, PlayerTeam instance, bool isDelta = False) { }

	// RVA: 0x2043500 Offset: 0x2041B00 VA: 0x182043500
	public static PlayerTeam Deserialize(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x20424F0 Offset: 0x2040AF0 VA: 0x1820424F0
	public static PlayerTeam DeserializeLengthDelimited(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x20429B0 Offset: 0x2040FB0 VA: 0x1820429B0
	public static PlayerTeam DeserializeLength(Stream stream, int length, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x2044550 Offset: 0x2042B50 VA: 0x182044550
	public static void SerializeDelta(Stream stream, PlayerTeam instance, PlayerTeam previous) { }

	// RVA: 0x2044B70 Offset: 0x2043170 VA: 0x182044B70
	public static void Serialize(Stream stream, PlayerTeam instance) { }

	// RVA: 0x2044F50 Offset: 0x2043550 VA: 0x182044F50
	public byte[] ToProtoBytes() { }

	// RVA: 0x2044F60 Offset: 0x2043560 VA: 0x182044F60
	public void ToProto(Stream stream) { }

	// RVA: 0x2044A60 Offset: 0x2043060 VA: 0x182044A60
	public static byte[] SerializeToBytes(PlayerTeam instance) { }

	// RVA: 0x20449B0 Offset: 0x2042FB0 VA: 0x1820449B0
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2054100 Offset: 0x2052700 VA: 0x182054100
	public static void ResetToPool(PlayerTeam.TeamMember instance) { }

	// RVA: 0x2054020 Offset: 0x2052620 VA: 0x182054020
	public void ResetToPool() { }

	// RVA: 0x2053CE0 Offset: 0x20522E0 VA: 0x182053CE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2052480 Offset: 0x2050A80 VA: 0x182052480
	public void CopyTo(PlayerTeam.TeamMember instance) { }

	// RVA: 0x20524F0 Offset: 0x2050AF0 VA: 0x1820524F0
	public PlayerTeam.TeamMember Copy() { }

	// RVA: 0x2053670 Offset: 0x2051C70 VA: 0x182053670
	public static PlayerTeam.TeamMember Deserialize(Stream stream) { }

	// RVA: 0x20525A0 Offset: 0x2050BA0 VA: 0x1820525A0
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2052990 Offset: 0x2050F90 VA: 0x182052990
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2053950 Offset: 0x2051F50 VA: 0x182053950
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer) { }

	// RVA: 0x2053D60 Offset: 0x2052360 VA: 0x182053D60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2054A20 Offset: 0x2053020 VA: 0x182054A20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2054A40 Offset: 0x2053040 VA: 0x182054A40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam.TeamMember previous) { }

	// RVA: 0x2054000 Offset: 0x2052600 VA: 0x182054000 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2053310 Offset: 0x2051910 VA: 0x182053310
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer, PlayerTeam.TeamMember instance, bool isDelta = False) { }

	// RVA: 0x2053060 Offset: 0x2051660 VA: 0x182053060
	public static PlayerTeam.TeamMember Deserialize(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x2052620 Offset: 0x2050C20 VA: 0x182052620
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x2052D20 Offset: 0x2051320 VA: 0x182052D20
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x20541E0 Offset: 0x20527E0 VA: 0x1820541E0
	public static void SerializeDelta(Stream stream, PlayerTeam.TeamMember instance, PlayerTeam.TeamMember previous) { }

	// RVA: 0x2054790 Offset: 0x2052D90 VA: 0x182054790
	public static void Serialize(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x2054A10 Offset: 0x2053010 VA: 0x182054A10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2054A20 Offset: 0x2053020 VA: 0x182054A20
	public void ToProto(Stream stream) { }

	// RVA: 0x2054680 Offset: 0x2052C80 VA: 0x182054680
	public static byte[] SerializeToBytes(PlayerTeam.TeamMember instance) { }

	// RVA: 0x20545D0 Offset: 0x2052BD0 VA: 0x1820545D0
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EB6630 Offset: 0x1EB4C30 VA: 0x181EB6630
	public static void ResetToPool(PlayerMetabolism instance) { }

	// RVA: 0x1EB64F0 Offset: 0x1EB4AF0 VA: 0x181EB64F0
	public void ResetToPool() { }

	// RVA: 0x1EB62E0 Offset: 0x1EB48E0 VA: 0x181EB62E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB4E10 Offset: 0x1EB3410 VA: 0x181EB4E10
	public void CopyTo(PlayerMetabolism instance) { }

	// RVA: 0x1EB4E80 Offset: 0x1EB3480 VA: 0x181EB4E80
	public PlayerMetabolism Copy() { }

	// RVA: 0x1EB6140 Offset: 0x1EB4740 VA: 0x181EB6140
	public static PlayerMetabolism Deserialize(Stream stream) { }

	// RVA: 0x1EB54E0 Offset: 0x1EB3AE0 VA: 0x181EB54E0
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB5AE0 Offset: 0x1EB40E0 VA: 0x181EB5AE0
	public static PlayerMetabolism DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB61C0 Offset: 0x1EB47C0 VA: 0x181EB61C0
	public static PlayerMetabolism Deserialize(byte[] buffer) { }

	// RVA: 0x1EB64B0 Offset: 0x1EB4AB0 VA: 0x181EB64B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB71D0 Offset: 0x1EB57D0 VA: 0x181EB71D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB71F0 Offset: 0x1EB57F0 VA: 0x181EB71F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerMetabolism previous) { }

	// RVA: 0x1EB64D0 Offset: 0x1EB4AD0 VA: 0x181EB64D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB5B70 Offset: 0x1EB4170 VA: 0x181EB5B70
	public static PlayerMetabolism Deserialize(byte[] buffer, PlayerMetabolism instance, bool isDelta = False) { }

	// RVA: 0x1EB5C70 Offset: 0x1EB4270 VA: 0x181EB5C70
	public static PlayerMetabolism Deserialize(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB4F40 Offset: 0x1EB3540 VA: 0x181EB4F40
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB5560 Offset: 0x1EB3B60 VA: 0x181EB5560
	public static PlayerMetabolism DeserializeLength(Stream stream, int length, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB6770 Offset: 0x1EB4D70 VA: 0x181EB6770
	public static void SerializeDelta(Stream stream, PlayerMetabolism instance, PlayerMetabolism previous) { }

	// RVA: 0x1EB6F00 Offset: 0x1EB5500 VA: 0x181EB6F00
	public static void Serialize(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x1EB71C0 Offset: 0x1EB57C0 VA: 0x181EB71C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB71D0 Offset: 0x1EB57D0 VA: 0x181EB71D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB6DF0 Offset: 0x1EB53F0 VA: 0x181EB6DF0
	public static byte[] SerializeToBytes(PlayerMetabolism instance) { }

	// RVA: 0x1EB6D40 Offset: 0x1EB5340 VA: 0x181EB6D40
	public static void SerializeLengthDelimited(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PlayerModifiers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6447
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Modifier> modifiers; // 0x18

	// Methods

	// RVA: 0x1EB8130 Offset: 0x1EB6730 VA: 0x181EB8130
	public static void ResetToPool(PlayerModifiers instance) { }

	// RVA: 0x1EB82E0 Offset: 0x1EB68E0 VA: 0x181EB82E0
	public void ResetToPool() { }

	// RVA: 0x1EB7EB0 Offset: 0x1EB64B0 VA: 0x181EB7EB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB7210 Offset: 0x1EB5810 VA: 0x181EB7210
	public void CopyTo(PlayerModifiers instance) { }

	// RVA: 0x1EB7340 Offset: 0x1EB5940 VA: 0x181EB7340
	public PlayerModifiers Copy() { }

	// RVA: 0x1EB7BA0 Offset: 0x1EB61A0 VA: 0x181EB7BA0
	public static PlayerModifiers Deserialize(Stream stream) { }

	// RVA: 0x1EB74B0 Offset: 0x1EB5AB0 VA: 0x181EB74B0
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB77A0 Offset: 0x1EB5DA0 VA: 0x181EB77A0
	public static PlayerModifiers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB7A80 Offset: 0x1EB6080 VA: 0x181EB7A80
	public static PlayerModifiers Deserialize(byte[] buffer) { }

	// RVA: 0x1EB80F0 Offset: 0x1EB66F0 VA: 0x181EB80F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB8A20 Offset: 0x1EB7020 VA: 0x181EB8A20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB8A40 Offset: 0x1EB7040 VA: 0x181EB8A40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerModifiers previous) { }

	// RVA: 0x1EB8110 Offset: 0x1EB6710 VA: 0x181EB8110 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB7C20 Offset: 0x1EB6220 VA: 0x181EB7C20
	public static PlayerModifiers Deserialize(byte[] buffer, PlayerModifiers instance, bool isDelta = False) { }

	// RVA: 0x1EB7D20 Offset: 0x1EB6320 VA: 0x181EB7D20
	public static PlayerModifiers Deserialize(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB7530 Offset: 0x1EB5B30 VA: 0x181EB7530
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB7830 Offset: 0x1EB5E30 VA: 0x181EB7830
	public static PlayerModifiers DeserializeLength(Stream stream, int length, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB8490 Offset: 0x1EB6A90 VA: 0x181EB8490
	public static void SerializeDelta(Stream stream, PlayerModifiers instance, PlayerModifiers previous) { }

	// RVA: 0x1EB8830 Offset: 0x1EB6E30 VA: 0x181EB8830
	public static void Serialize(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x1EB8A10 Offset: 0x1EB7010 VA: 0x181EB8A10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB8A20 Offset: 0x1EB7020 VA: 0x181EB8A20
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB8720 Offset: 0x1EB6D20 VA: 0x181EB8720
	public static byte[] SerializeToBytes(PlayerModifiers instance) { }

	// RVA: 0x1EB8670 Offset: 0x1EB6C70 VA: 0x181EB8670
	public static void SerializeLengthDelimited(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EAFFB0 Offset: 0x1EAE5B0 VA: 0x181EAFFB0
	public static void ResetToPool(PlayerInventory instance) { }

	// RVA: 0x1EB00D0 Offset: 0x1EAE6D0 VA: 0x181EB00D0
	public void ResetToPool() { }

	// RVA: 0x1EAFC10 Offset: 0x1EAE210 VA: 0x181EAFC10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAEA00 Offset: 0x1EAD000 VA: 0x181EAEA00
	public void CopyTo(PlayerInventory instance) { }

	// RVA: 0x1EAEB00 Offset: 0x1EAD100 VA: 0x181EAEB00
	public PlayerInventory Copy() { }

	// RVA: 0x1EAF2A0 Offset: 0x1EAD8A0 VA: 0x181EAF2A0
	public static PlayerInventory Deserialize(Stream stream) { }

	// RVA: 0x1EAEC40 Offset: 0x1EAD240 VA: 0x181EAEC40
	public static PlayerInventory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAF210 Offset: 0x1EAD810 VA: 0x181EAF210
	public static PlayerInventory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAF760 Offset: 0x1EADD60 VA: 0x181EAF760
	public static PlayerInventory Deserialize(byte[] buffer) { }

	// RVA: 0x1EAFDB0 Offset: 0x1EAE3B0 VA: 0x181EAFDB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB0AB0 Offset: 0x1EAF0B0 VA: 0x181EB0AB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB0AD0 Offset: 0x1EAF0D0 VA: 0x181EB0AD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerInventory previous) { }

	// RVA: 0x1EAFF90 Offset: 0x1EAE590 VA: 0x181EAFF90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAF4C0 Offset: 0x1EADAC0 VA: 0x181EAF4C0
	public static PlayerInventory Deserialize(byte[] buffer, PlayerInventory instance, bool isDelta = False) { }

	// RVA: 0x1EAFA30 Offset: 0x1EAE030 VA: 0x181EAFA30
	public static PlayerInventory Deserialize(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAECC0 Offset: 0x1EAD2C0 VA: 0x181EAECC0
	public static PlayerInventory DeserializeLengthDelimited(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAEF80 Offset: 0x1EAD580 VA: 0x181EAEF80
	public static PlayerInventory DeserializeLength(Stream stream, int length, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EB01F0 Offset: 0x1EAE7F0 VA: 0x181EB01F0
	public static void SerializeDelta(Stream stream, PlayerInventory instance, PlayerInventory previous) { }

	// RVA: 0x1EB0740 Offset: 0x1EAED40 VA: 0x181EB0740
	public static void Serialize(Stream stream, PlayerInventory instance) { }

	// RVA: 0x1EB0AA0 Offset: 0x1EAF0A0 VA: 0x181EB0AA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB0AB0 Offset: 0x1EAF0B0 VA: 0x181EB0AB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB0630 Offset: 0x1EAEC30 VA: 0x181EB0630
	public static byte[] SerializeToBytes(PlayerInventory instance) { }

	// RVA: 0x1EB0580 Offset: 0x1EAEB80 VA: 0x181EB0580
	public static void SerializeLengthDelimited(Stream stream, PlayerInventory instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EB32D0 Offset: 0x1EB18D0 VA: 0x181EB32D0
	public static void ResetToPool(PlayerLifeStory instance) { }

	// RVA: 0x1EB2E80 Offset: 0x1EB1480 VA: 0x181EB2E80
	public void ResetToPool() { }

	// RVA: 0x1EB2DC0 Offset: 0x1EB13C0 VA: 0x181EB2DC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB0AF0 Offset: 0x1EAF0F0 VA: 0x181EB0AF0
	public void CopyTo(PlayerLifeStory instance) { }

	// RVA: 0x1EB0F70 Offset: 0x1EAF570 VA: 0x181EB0F70
	public PlayerLifeStory Copy() { }

	// RVA: 0x1EB22E0 Offset: 0x1EB08E0 VA: 0x181EB22E0
	public static PlayerLifeStory Deserialize(Stream stream) { }

	// RVA: 0x1EB18F0 Offset: 0x1EAFEF0 VA: 0x181EB18F0
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB2250 Offset: 0x1EB0850 VA: 0x181EB2250
	public static PlayerLifeStory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB2CA0 Offset: 0x1EB12A0 VA: 0x181EB2CA0
	public static PlayerLifeStory Deserialize(byte[] buffer) { }

	// RVA: 0x1EB2E40 Offset: 0x1EB1440 VA: 0x181EB2E40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB4DD0 Offset: 0x1EB33D0 VA: 0x181EB4DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB4DF0 Offset: 0x1EB33F0 VA: 0x181EB4DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory previous) { }

	// RVA: 0x1EB2E60 Offset: 0x1EB1460 VA: 0x181EB2E60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB2360 Offset: 0x1EB0960 VA: 0x181EB2360
	public static PlayerLifeStory Deserialize(byte[] buffer, PlayerLifeStory instance, bool isDelta = False) { }

	// RVA: 0x1EB2460 Offset: 0x1EB0A60 VA: 0x181EB2460
	public static PlayerLifeStory Deserialize(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB0FF0 Offset: 0x1EAF5F0 VA: 0x181EB0FF0
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB1970 Offset: 0x1EAFF70 VA: 0x181EB1970
	public static PlayerLifeStory DeserializeLength(Stream stream, int length, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EB3720 Offset: 0x1EB1D20 VA: 0x181EB3720
	public static void SerializeDelta(Stream stream, PlayerLifeStory instance, PlayerLifeStory previous) { }

	// RVA: 0x1EB4530 Offset: 0x1EB2B30 VA: 0x181EB4530
	public static void Serialize(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x1EB4DC0 Offset: 0x1EB33C0 VA: 0x181EB4DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB4DD0 Offset: 0x1EB33D0 VA: 0x181EB4DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB4420 Offset: 0x1EB2A20 VA: 0x181EB4420
	public static byte[] SerializeToBytes(PlayerLifeStory instance) { }

	// RVA: 0x1EB4370 Offset: 0x1EB2970 VA: 0x181EB4370
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EA2CB0 Offset: 0x1EA12B0 VA: 0x181EA2CB0
	public static void ResetToPool(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA2DE0 Offset: 0x1EA13E0 VA: 0x181EA2DE0
	public void ResetToPool() { }

	// RVA: 0x1EA2960 Offset: 0x1EA0F60 VA: 0x181EA2960 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA1300 Offset: 0x1E9F900 VA: 0x181EA1300
	public void CopyTo(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA1370 Offset: 0x1E9F970 VA: 0x181EA1370
	public PlayerLifeStory.DeathInfo Copy() { }

	// RVA: 0x1EA1FE0 Offset: 0x1EA05E0 VA: 0x181EA1FE0
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream) { }

	// RVA: 0x1EA17C0 Offset: 0x1E9FDC0 VA: 0x181EA17C0
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA1BB0 Offset: 0x1EA01B0 VA: 0x181EA1BB0
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA25A0 Offset: 0x1EA0BA0 VA: 0x181EA25A0
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1EA29E0 Offset: 0x1EA0FE0 VA: 0x181EA29E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA3640 Offset: 0x1EA1C40 VA: 0x181EA3640 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA3660 Offset: 0x1EA1C60 VA: 0x181EA3660 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1EA2C90 Offset: 0x1EA1290 VA: 0x181EA2C90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA1C40 Offset: 0x1EA0240 VA: 0x181EA1C40
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer, PlayerLifeStory.DeathInfo instance, bool isDelta = False) { }

	// RVA: 0x1EA22E0 Offset: 0x1EA08E0 VA: 0x181EA22E0
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA1430 Offset: 0x1E9FA30 VA: 0x181EA1430
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA1840 Offset: 0x1E9FE40 VA: 0x181EA1840
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1EA2F10 Offset: 0x1EA1510 VA: 0x181EA2F10
	public static void SerializeDelta(Stream stream, PlayerLifeStory.DeathInfo instance, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1EA33E0 Offset: 0x1EA19E0 VA: 0x181EA33E0
	public static void Serialize(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA3630 Offset: 0x1EA1C30 VA: 0x181EA3630
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA3640 Offset: 0x1EA1C40 VA: 0x181EA3640
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA32D0 Offset: 0x1EA18D0 VA: 0x181EA32D0
	public static byte[] SerializeToBytes(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1EA3220 Offset: 0x1EA1820 VA: 0x181EA3220
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EB9D60 Offset: 0x1EB8360 VA: 0x181EB9D60
	public static void ResetToPool(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB9CB0 Offset: 0x1EB82B0 VA: 0x181EB9CB0
	public void ResetToPool() { }

	// RVA: 0x1EB9A50 Offset: 0x1EB8050 VA: 0x181EB9A50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB8A60 Offset: 0x1EB7060 VA: 0x181EB8A60
	public void CopyTo(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB8AB0 Offset: 0x1EB70B0 VA: 0x181EB8AB0
	public PlayerLifeStory.WeaponStats Copy() { }

	// RVA: 0x1EB9690 Offset: 0x1EB7C90 VA: 0x181EB9690
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream) { }

	// RVA: 0x1EB8DD0 Offset: 0x1EB73D0 VA: 0x181EB8DD0
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB90C0 Offset: 0x1EB76C0 VA: 0x181EB90C0
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB9150 Offset: 0x1EB7750 VA: 0x181EB9150
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer) { }

	// RVA: 0x1EB9AD0 Offset: 0x1EB80D0 VA: 0x181EB9AD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EBA390 Offset: 0x1EB8990 VA: 0x181EBA390 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EBA3B0 Offset: 0x1EB89B0 VA: 0x181EBA3B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EB9C90 Offset: 0x1EB8290 VA: 0x181EB9C90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB9400 Offset: 0x1EB7A00 VA: 0x181EB9400
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer, PlayerLifeStory.WeaponStats instance, bool isDelta = False) { }

	// RVA: 0x1EB9890 Offset: 0x1EB7E90 VA: 0x181EB9890
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB8B40 Offset: 0x1EB7140 VA: 0x181EB8B40
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB8E50 Offset: 0x1EB7450 VA: 0x181EB8E50
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB9E10 Offset: 0x1EB8410 VA: 0x181EB9E10
	public static void SerializeDelta(Stream stream, PlayerLifeStory.WeaponStats instance, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EBA1F0 Offset: 0x1EB87F0 VA: 0x181EBA1F0
	public static void Serialize(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EBA380 Offset: 0x1EB8980 VA: 0x181EBA380
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EBA390 Offset: 0x1EB8990 VA: 0x181EBA390
	public void ToProto(Stream stream) { }

	// RVA: 0x1EBA0E0 Offset: 0x1EB86E0 VA: 0x181EBA0E0
	public static byte[] SerializeToBytes(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EBA030 Offset: 0x1EB8630 VA: 0x181EBA030
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PlayerLifeStory.GenericStat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6459
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string key; // 0x18
	public int value; // 0x20

	// Methods

	// RVA: 0x1EA59A0 Offset: 0x1EA3FA0 VA: 0x181EA59A0
	public static void ResetToPool(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA5900 Offset: 0x1EA3F00 VA: 0x181EA5900
	public void ResetToPool() { }

	// RVA: 0x1EA5840 Offset: 0x1EA3E40 VA: 0x181EA5840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA4B10 Offset: 0x1EA3110 VA: 0x181EA4B10
	public void CopyTo(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA4B50 Offset: 0x1EA3150 VA: 0x181EA4B50
	public PlayerLifeStory.GenericStat Copy() { }

	// RVA: 0x1EA5190 Offset: 0x1EA3790 VA: 0x181EA5190
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream) { }

	// RVA: 0x1EA4BE0 Offset: 0x1EA31E0 VA: 0x181EA4BE0
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA5100 Offset: 0x1EA3700 VA: 0x181EA5100
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA55D0 Offset: 0x1EA3BD0 VA: 0x181EA55D0
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer) { }

	// RVA: 0x1EA58C0 Offset: 0x1EA3EC0 VA: 0x181EA58C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA5F30 Offset: 0x1EA4530 VA: 0x181EA5F30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA5F50 Offset: 0x1EA4550 VA: 0x181EA5F50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1EA58E0 Offset: 0x1EA3EE0 VA: 0x181EA58E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA5350 Offset: 0x1EA3950 VA: 0x181EA5350
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer, PlayerLifeStory.GenericStat instance, bool isDelta = False) { }

	// RVA: 0x1EA5450 Offset: 0x1EA3A50 VA: 0x181EA5450
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA4C60 Offset: 0x1EA3260 VA: 0x181EA4C60
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA4EC0 Offset: 0x1EA34C0 VA: 0x181EA4EC0
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1EA5A40 Offset: 0x1EA4040 VA: 0x181EA5A40
	public static void SerializeDelta(Stream stream, PlayerLifeStory.GenericStat instance, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1EA5DC0 Offset: 0x1EA43C0 VA: 0x181EA5DC0
	public static void Serialize(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA5F20 Offset: 0x1EA4520 VA: 0x181EA5F20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA5F30 Offset: 0x1EA4530 VA: 0x181EA5F30
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA5CB0 Offset: 0x1EA42B0 VA: 0x181EA5CB0
	public static byte[] SerializeToBytes(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA5C00 Offset: 0x1EA4200 VA: 0x181EA5C00
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x20416F0 Offset: 0x203FCF0 VA: 0x1820416F0
	public static void ResetToPool(PlayerState instance) { }

	// RVA: 0x20415C0 Offset: 0x203FBC0 VA: 0x1820415C0
	public void ResetToPool() { }

	// RVA: 0x20411C0 Offset: 0x203F7C0 VA: 0x1820411C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203FDE0 Offset: 0x203E3E0 VA: 0x18203FDE0
	public void CopyTo(PlayerState instance) { }

	// RVA: 0x203FED0 Offset: 0x203E4D0 VA: 0x18203FED0
	public PlayerState Copy() { }

	// RVA: 0x2040A40 Offset: 0x203F040 VA: 0x182040A40
	public static PlayerState Deserialize(Stream stream) { }

	// RVA: 0x2040330 Offset: 0x203E930 VA: 0x182040330
	public static PlayerState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20403B0 Offset: 0x203E9B0 VA: 0x1820403B0
	public static PlayerState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2040720 Offset: 0x203ED20 VA: 0x182040720
	public static PlayerState Deserialize(byte[] buffer) { }

	// RVA: 0x2041370 Offset: 0x203F970 VA: 0x182041370
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2042170 Offset: 0x2040770 VA: 0x182042170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2042190 Offset: 0x2040790 VA: 0x182042190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerState previous) { }

	// RVA: 0x20415A0 Offset: 0x203FBA0 VA: 0x1820415A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2040CA0 Offset: 0x203F2A0 VA: 0x182040CA0
	public static PlayerState Deserialize(byte[] buffer, PlayerState instance, bool isDelta = False) { }

	// RVA: 0x2040F90 Offset: 0x203F590 VA: 0x182040F90
	public static PlayerState Deserialize(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x2040020 Offset: 0x203E620 VA: 0x182040020
	public static PlayerState DeserializeLengthDelimited(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x2040440 Offset: 0x203EA40 VA: 0x182040440
	public static PlayerState DeserializeLength(Stream stream, int length, PlayerState instance, bool isDelta) { }

	// RVA: 0x2041820 Offset: 0x203FE20 VA: 0x182041820
	public static void SerializeDelta(Stream stream, PlayerState instance, PlayerState previous) { }

	// RVA: 0x2041DC0 Offset: 0x20403C0 VA: 0x182041DC0
	public static void Serialize(Stream stream, PlayerState instance) { }

	// RVA: 0x2042160 Offset: 0x2040760 VA: 0x182042160
	public byte[] ToProtoBytes() { }

	// RVA: 0x2042170 Offset: 0x2040770 VA: 0x182042170
	public void ToProto(Stream stream) { }

	// RVA: 0x2041CB0 Offset: 0x20402B0 VA: 0x182041CB0
	public static byte[] SerializeToBytes(PlayerState instance) { }

	// RVA: 0x2041C00 Offset: 0x2040200 VA: 0x182041C00
	public static void SerializeLengthDelimited(Stream stream, PlayerState instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PlayerNameID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6463
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string username; // 0x18
	public ulong userid; // 0x20

	// Methods

	// RVA: 0x2038820 Offset: 0x2036E20 VA: 0x182038820
	public static void ResetToPool(PlayerNameID instance) { }

	// RVA: 0x2038770 Offset: 0x2036D70 VA: 0x182038770
	public void ResetToPool() { }

	// RVA: 0x2038610 Offset: 0x2036C10 VA: 0x182038610 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DADEE0 Offset: 0x1DAC4E0 VA: 0x181DADEE0
	public void CopyTo(PlayerNameID instance) { }

	// RVA: 0x2037910 Offset: 0x2035F10 VA: 0x182037910
	public PlayerNameID Copy() { }

	// RVA: 0x2038350 Offset: 0x2036950 VA: 0x182038350
	public static PlayerNameID Deserialize(Stream stream) { }

	// RVA: 0x20379A0 Offset: 0x2035FA0 VA: 0x1820379A0
	public static PlayerNameID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2037EC0 Offset: 0x20364C0 VA: 0x182037EC0
	public static PlayerNameID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20380D0 Offset: 0x20366D0 VA: 0x1820380D0
	public static PlayerNameID Deserialize(byte[] buffer) { }

	// RVA: 0x2038730 Offset: 0x2036D30 VA: 0x182038730
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2038DC0 Offset: 0x20373C0 VA: 0x182038DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2038DE0 Offset: 0x20373E0 VA: 0x182038DE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerNameID previous) { }

	// RVA: 0x2038750 Offset: 0x2036D50 VA: 0x182038750 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2038510 Offset: 0x2036B10 VA: 0x182038510
	public static PlayerNameID Deserialize(byte[] buffer, PlayerNameID instance, bool isDelta = False) { }

	// RVA: 0x2037F50 Offset: 0x2036550 VA: 0x182037F50
	public static PlayerNameID Deserialize(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2037A20 Offset: 0x2036020 VA: 0x182037A20
	public static PlayerNameID DeserializeLengthDelimited(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2037C80 Offset: 0x2036280 VA: 0x182037C80
	public static PlayerNameID DeserializeLength(Stream stream, int length, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x20388D0 Offset: 0x2036ED0 VA: 0x1820388D0
	public static void SerializeDelta(Stream stream, PlayerNameID instance, PlayerNameID previous) { }

	// RVA: 0x2038C50 Offset: 0x2037250 VA: 0x182038C50
	public static void Serialize(Stream stream, PlayerNameID instance) { }

	// RVA: 0x2038DB0 Offset: 0x20373B0 VA: 0x182038DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2038DC0 Offset: 0x20373C0 VA: 0x182038DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x2038B40 Offset: 0x2037140 VA: 0x182038B40
	public static byte[] SerializeToBytes(PlayerNameID instance) { }

	// RVA: 0x2038A90 Offset: 0x2037090 VA: 0x182038A90
	public static void SerializeLengthDelimited(Stream stream, PlayerNameID instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2046600 Offset: 0x2044C00 VA: 0x182046600
	public static void ResetToPool(PlayerUpdateLoot instance) { }

	// RVA: 0x20467D0 Offset: 0x2044DD0 VA: 0x1820467D0
	public void ResetToPool() { }

	// RVA: 0x2046350 Offset: 0x2044950 VA: 0x182046350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2044FA0 Offset: 0x20435A0 VA: 0x182044FA0
	public void CopyTo(PlayerUpdateLoot instance) { }

	// RVA: 0x20450D0 Offset: 0x20436D0 VA: 0x1820450D0
	public PlayerUpdateLoot Copy() { }

	// RVA: 0x2045920 Offset: 0x2043F20 VA: 0x182045920
	public static PlayerUpdateLoot Deserialize(Stream stream) { }

	// RVA: 0x2045540 Offset: 0x2043B40 VA: 0x182045540
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2045890 Offset: 0x2043E90 VA: 0x182045890
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2046070 Offset: 0x2044670 VA: 0x182046070
	public static PlayerUpdateLoot Deserialize(byte[] buffer) { }

	// RVA: 0x20463D0 Offset: 0x20449D0 VA: 0x1820463D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2047040 Offset: 0x2045640 VA: 0x182047040 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2047060 Offset: 0x2045660 VA: 0x182047060 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerUpdateLoot previous) { }

	// RVA: 0x20465E0 Offset: 0x2044BE0 VA: 0x1820465E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2045D80 Offset: 0x2044380 VA: 0x182045D80
	public static PlayerUpdateLoot Deserialize(byte[] buffer, PlayerUpdateLoot instance, bool isDelta = False) { }

	// RVA: 0x2045B60 Offset: 0x2044160 VA: 0x182045B60
	public static PlayerUpdateLoot Deserialize(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2045250 Offset: 0x2043850 VA: 0x182045250
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x20455C0 Offset: 0x2043BC0 VA: 0x1820455C0
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x20469A0 Offset: 0x2044FA0 VA: 0x1820469A0
	public static void SerializeDelta(Stream stream, PlayerUpdateLoot instance, PlayerUpdateLoot previous) { }

	// RVA: 0x2046DF0 Offset: 0x20453F0 VA: 0x182046DF0
	public static void Serialize(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x2047030 Offset: 0x2045630 VA: 0x182047030
	public byte[] ToProtoBytes() { }

	// RVA: 0x2047040 Offset: 0x2045640 VA: 0x182047040
	public void ToProto(Stream stream) { }

	// RVA: 0x2046CE0 Offset: 0x20452E0 VA: 0x182046CE0
	public static byte[] SerializeToBytes(PlayerUpdateLoot instance) { }

	// RVA: 0x2046C30 Offset: 0x2045230 VA: 0x182046C30
	public static void SerializeLengthDelimited(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PlayerAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6484
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Attack attack; // 0x18
	public int projectileID; // 0x20

	// Methods

	// RVA: 0x1EAD180 Offset: 0x1EAB780 VA: 0x181EAD180
	public static void ResetToPool(PlayerAttack instance) { }

	// RVA: 0x1EAD230 Offset: 0x1EAB830 VA: 0x181EAD230
	public void ResetToPool() { }

	// RVA: 0x1EAD010 Offset: 0x1EAB610 VA: 0x181EAD010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAC230 Offset: 0x1EAA830 VA: 0x181EAC230
	public void CopyTo(PlayerAttack instance) { }

	// RVA: 0x1EAC2C0 Offset: 0x1EAA8C0 VA: 0x181EAC2C0
	public PlayerAttack Copy() { }

	// RVA: 0x1EACA50 Offset: 0x1EAB050 VA: 0x181EACA50
	public static PlayerAttack Deserialize(Stream stream) { }

	// RVA: 0x1EAC390 Offset: 0x1EAA990 VA: 0x181EAC390
	public static PlayerAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAC8C0 Offset: 0x1EAAEC0 VA: 0x181EAC8C0
	public static PlayerAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EACDA0 Offset: 0x1EAB3A0 VA: 0x181EACDA0
	public static PlayerAttack Deserialize(byte[] buffer) { }

	// RVA: 0x1EAD140 Offset: 0x1EAB740 VA: 0x181EAD140
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAD8D0 Offset: 0x1EABED0 VA: 0x181EAD8D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAD8F0 Offset: 0x1EABEF0 VA: 0x181EAD8F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerAttack previous) { }

	// RVA: 0x1EAD160 Offset: 0x1EAB760 VA: 0x181EAD160 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAC950 Offset: 0x1EAAF50 VA: 0x181EAC950
	public static PlayerAttack Deserialize(byte[] buffer, PlayerAttack instance, bool isDelta = False) { }

	// RVA: 0x1EACC10 Offset: 0x1EAB210 VA: 0x181EACC10
	public static PlayerAttack Deserialize(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EAC410 Offset: 0x1EAAA10 VA: 0x181EAC410
	public static PlayerAttack DeserializeLengthDelimited(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EAC680 Offset: 0x1EAAC80 VA: 0x181EAC680
	public static PlayerAttack DeserializeLength(Stream stream, int length, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EAD2E0 Offset: 0x1EAB8E0 VA: 0x181EAD2E0
	public static void SerializeDelta(Stream stream, PlayerAttack instance, PlayerAttack previous) { }

	// RVA: 0x1EAD6D0 Offset: 0x1EABCD0 VA: 0x181EAD6D0
	public static void Serialize(Stream stream, PlayerAttack instance) { }

	// RVA: 0x1EAD8C0 Offset: 0x1EABEC0 VA: 0x181EAD8C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAD8D0 Offset: 0x1EABED0 VA: 0x181EAD8D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAD5C0 Offset: 0x1EABBC0 VA: 0x181EAD5C0
	public static byte[] SerializeToBytes(PlayerAttack instance) { }

	// RVA: 0x1EAD510 Offset: 0x1EABB10 VA: 0x181EAD510
	public static void SerializeLengthDelimited(Stream stream, PlayerAttack instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x203A450 Offset: 0x2038A50 VA: 0x18203A450
	public static void ResetToPool(PlayerProjectileAttack instance) { }

	// RVA: 0x203A530 Offset: 0x2038B30 VA: 0x18203A530
	public void ResetToPool() { }

	// RVA: 0x203A0B0 Offset: 0x20386B0 VA: 0x18203A0B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2038E00 Offset: 0x2037400 VA: 0x182038E00
	public void CopyTo(PlayerProjectileAttack instance) { }

	// RVA: 0x2038EA0 Offset: 0x20374A0 VA: 0x182038EA0
	public PlayerProjectileAttack Copy() { }

	// RVA: 0x2039940 Offset: 0x2037F40 VA: 0x182039940
	public static PlayerProjectileAttack Deserialize(Stream stream) { }

	// RVA: 0x2039270 Offset: 0x2037870 VA: 0x182039270
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20392F0 Offset: 0x20378F0 VA: 0x1820392F0
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2039640 Offset: 0x2037C40 VA: 0x182039640
	public static PlayerProjectileAttack Deserialize(byte[] buffer) { }

	// RVA: 0x203A210 Offset: 0x2038810 VA: 0x18203A210
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203AEE0 Offset: 0x20394E0 VA: 0x18203AEE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203AF00 Offset: 0x2039500 VA: 0x18203AF00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileAttack previous) { }

	// RVA: 0x203A430 Offset: 0x2038A30 VA: 0x18203A430 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2039DD0 Offset: 0x20383D0 VA: 0x182039DD0
	public static PlayerProjectileAttack Deserialize(byte[] buffer, PlayerProjectileAttack instance, bool isDelta = False) { }

	// RVA: 0x2039BA0 Offset: 0x20381A0 VA: 0x182039BA0
	public static PlayerProjectileAttack Deserialize(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2038F80 Offset: 0x2037580 VA: 0x182038F80
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2039380 Offset: 0x2037980 VA: 0x182039380
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x203A610 Offset: 0x2038C10 VA: 0x18203A610
	public static void SerializeDelta(Stream stream, PlayerProjectileAttack instance, PlayerProjectileAttack previous) { }

	// RVA: 0x203ABF0 Offset: 0x20391F0 VA: 0x18203ABF0
	public static void Serialize(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x203AED0 Offset: 0x20394D0 VA: 0x18203AED0
	public byte[] ToProtoBytes() { }

	// RVA: 0x203AEE0 Offset: 0x20394E0 VA: 0x18203AEE0
	public void ToProto(Stream stream) { }

	// RVA: 0x203AAE0 Offset: 0x20390E0 VA: 0x18203AAE0
	public static byte[] SerializeToBytes(PlayerProjectileAttack instance) { }

	// RVA: 0x203AA30 Offset: 0x2039030 VA: 0x18203AA30
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x203D0E0 Offset: 0x203B6E0 VA: 0x18203D0E0
	public static void ResetToPool(PlayerProjectileRicochet instance) { }

	// RVA: 0x203D010 Offset: 0x203B610 VA: 0x18203D010
	public void ResetToPool() { }

	// RVA: 0x203C930 Offset: 0x203AF30 VA: 0x18203C930 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203AF20 Offset: 0x2039520 VA: 0x18203AF20
	public void CopyTo(PlayerProjectileRicochet instance) { }

	// RVA: 0x203AF80 Offset: 0x2039580 VA: 0x18203AF80
	public PlayerProjectileRicochet Copy() { }

	// RVA: 0x203C350 Offset: 0x203A950 VA: 0x18203C350
	public static PlayerProjectileRicochet Deserialize(Stream stream) { }

	// RVA: 0x203B040 Offset: 0x2039640 VA: 0x18203B040
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203B700 Offset: 0x2039D00 VA: 0x18203B700
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203BD80 Offset: 0x203A380 VA: 0x18203BD80
	public static PlayerProjectileRicochet Deserialize(byte[] buffer) { }

	// RVA: 0x203CA90 Offset: 0x203B090 VA: 0x18203CA90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203DE80 Offset: 0x203C480 VA: 0x18203DE80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203DEA0 Offset: 0x203C4A0 VA: 0x18203DEA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileRicochet previous) { }

	// RVA: 0x203CD00 Offset: 0x203B300 VA: 0x18203CD00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203C5F0 Offset: 0x203ABF0 VA: 0x18203C5F0
	public static PlayerProjectileRicochet Deserialize(byte[] buffer, PlayerProjectileRicochet instance, bool isDelta = False) { }

	// RVA: 0x203C0E0 Offset: 0x203A6E0 VA: 0x18203C0E0
	public static PlayerProjectileRicochet Deserialize(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203B3C0 Offset: 0x20399C0 VA: 0x18203B3C0
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203BA60 Offset: 0x203A060 VA: 0x18203BA60
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x203D1B0 Offset: 0x203B7B0 VA: 0x18203D1B0
	public static void SerializeDelta(Stream stream, PlayerProjectileRicochet instance, PlayerProjectileRicochet previous) { }

	// RVA: 0x203DA60 Offset: 0x203C060 VA: 0x18203DA60
	public static void Serialize(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x203DE70 Offset: 0x203C470 VA: 0x18203DE70
	public byte[] ToProtoBytes() { }

	// RVA: 0x203DE80 Offset: 0x203C480 VA: 0x18203DE80
	public void ToProto(Stream stream) { }

	// RVA: 0x203D950 Offset: 0x203BF50 VA: 0x18203D950
	public static byte[] SerializeToBytes(PlayerProjectileRicochet instance) { }

	// RVA: 0x203D8A0 Offset: 0x203BEA0 VA: 0x18203D8A0
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x203F390 Offset: 0x203D990 VA: 0x18203F390
	public static void ResetToPool(PlayerProjectileUpdate instance) { }

	// RVA: 0x203F440 Offset: 0x203DA40 VA: 0x18203F440
	public void ResetToPool() { }

	// RVA: 0x203F030 Offset: 0x203D630 VA: 0x18203F030 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203DEC0 Offset: 0x203C4C0 VA: 0x18203DEC0
	public void CopyTo(PlayerProjectileUpdate instance) { }

	// RVA: 0x203DF00 Offset: 0x203C500 VA: 0x18203DF00
	public PlayerProjectileUpdate Copy() { }

	// RVA: 0x203E630 Offset: 0x203CC30 VA: 0x18203E630
	public static PlayerProjectileUpdate Deserialize(Stream stream) { }

	// RVA: 0x203DFA0 Offset: 0x203C5A0 VA: 0x18203DFA0
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203E5A0 Offset: 0x203CBA0 VA: 0x18203E5A0
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203E870 Offset: 0x203CE70 VA: 0x18203E870
	public static PlayerProjectileUpdate Deserialize(byte[] buffer) { }

	// RVA: 0x203F160 Offset: 0x203D760 VA: 0x18203F160
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203FDA0 Offset: 0x203E3A0 VA: 0x18203FDA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203FDC0 Offset: 0x203E3C0 VA: 0x18203FDC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileUpdate previous) { }

	// RVA: 0x203F370 Offset: 0x203D970 VA: 0x18203F370 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203ED60 Offset: 0x203D360 VA: 0x18203ED60
	public static PlayerProjectileUpdate Deserialize(byte[] buffer, PlayerProjectileUpdate instance, bool isDelta = False) { }

	// RVA: 0x203EB50 Offset: 0x203D150 VA: 0x18203EB50
	public static PlayerProjectileUpdate Deserialize(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203E020 Offset: 0x203C620 VA: 0x18203E020
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203E2F0 Offset: 0x203C8F0 VA: 0x18203E2F0
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x203F4F0 Offset: 0x203DAF0 VA: 0x18203F4F0
	public static void SerializeDelta(Stream stream, PlayerProjectileUpdate instance, PlayerProjectileUpdate previous) { }

	// RVA: 0x203FB00 Offset: 0x203E100 VA: 0x18203FB00
	public static void Serialize(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x203FD90 Offset: 0x203E390 VA: 0x18203FD90
	public byte[] ToProtoBytes() { }

	// RVA: 0x203FDA0 Offset: 0x203E3A0 VA: 0x18203FDA0
	public void ToProto(Stream stream) { }

	// RVA: 0x203F9F0 Offset: 0x203DFF0 VA: 0x18203F9F0
	public static byte[] SerializeToBytes(PlayerProjectileUpdate instance) { }

	// RVA: 0x203F940 Offset: 0x203DF40 VA: 0x18203F940
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PlayerDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6544
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EAE450 Offset: 0x1EACA50 VA: 0x181EAE450
	public static void ResetToPool(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EAE3D0 Offset: 0x1EAC9D0 VA: 0x181EAE3D0
	public void ResetToPool() { }

	// RVA: 0x1EAE2A0 Offset: 0x1EAC8A0 VA: 0x181EAE2A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EAD910 Offset: 0x1EABF10 VA: 0x181EAD910
	public PlayerDetectedAIEventData Copy() { }

	// RVA: 0x1EAE220 Offset: 0x1EAC820 VA: 0x181EAE220
	public static PlayerDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EAD980 Offset: 0x1EABF80 VA: 0x181EAD980
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EADE20 Offset: 0x1EAC420 VA: 0x181EADE20
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAE100 Offset: 0x1EAC700 VA: 0x181EAE100
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EAE390 Offset: 0x1EAC990 VA: 0x181EAE390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAE8A0 Offset: 0x1EACEA0 VA: 0x181EAE8A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAE8C0 Offset: 0x1EACEC0 VA: 0x181EAE8C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EAE3B0 Offset: 0x1EAC9B0 VA: 0x181EAE3B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAE000 Offset: 0x1EAC600 VA: 0x181EAE000
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer, PlayerDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EADEB0 Offset: 0x1EAC4B0 VA: 0x181EADEB0
	public static PlayerDetectedAIEventData Deserialize(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EADA00 Offset: 0x1EAC000 VA: 0x181EADA00
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EADC20 Offset: 0x1EAC220 VA: 0x181EADC20
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EAE4D0 Offset: 0x1EACAD0 VA: 0x181EAE4D0
	public static void SerializeDelta(Stream stream, PlayerDetectedAIEventData instance, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EAE7B0 Offset: 0x1EACDB0 VA: 0x181EAE7B0
	public static void Serialize(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EAE890 Offset: 0x1EACE90 VA: 0x181EAE890
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAE8A0 Offset: 0x1EACEA0 VA: 0x181EAE8A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAE6A0 Offset: 0x1EACCA0 VA: 0x181EAE6A0
	public static byte[] SerializeToBytes(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EAE5F0 Offset: 0x1EACBF0 VA: 0x181EAE5F0
	public static void SerializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PlayerIdleAnimationRandomiser : StateMachineBehaviour // TypeDefIndex: 8270
{	// Fields
	public int MaxValue; // 0x18
	public static int Param_Random; // 0x0
	private TimeSince lastRandomisation; // 0x1C

	// Methods

	// RVA: 0xC32CA0 Offset: 0xC312A0 VA: 0x180C32CA0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0xC32ED0 Offset: 0xC314D0 VA: 0x180C32ED0
	public void .ctor() { }

	// RVA: 0xC32E80 Offset: 0xC31480 VA: 0x180C32E80
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

	// RVA: 0x712400 Offset: 0x710A00 VA: 0x180712400 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x72CCC0 Offset: 0x72B2C0 VA: 0x18072CCC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x71A570 Offset: 0x718B70 VA: 0x18071A570 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x708270 Offset: 0x706870 VA: 0x180708270 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x72D200 Offset: 0x72B800 VA: 0x18072D200 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	[BaseEntity.Menu] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.Description] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.Icon] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	[BaseEntity.Menu.ShowIf] // RVA: 0xBBD00 Offset: 0xBB100 VA: 0x1800BBD00
	// RVA: 0x719450 Offset: 0x717A50 VA: 0x180719450
	public void Menu_LootPlayer(BasePlayer player) { }

	// RVA: 0x719430 Offset: 0x717A30 VA: 0x180719430
	public bool Menu_LootPlayer_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x724E20 Offset: 0x723420 VA: 0x180724E20
	private void RPC_OpenLootPanel(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x723190 Offset: 0x721790 VA: 0x180723190
	private void PlayOpenSound() { }

	// RVA: 0x715320 Offset: 0x713920 VA: 0x180715320
	public bool InFirstPersonMode() { }

	// RVA: 0x72AFB0 Offset: 0x7295B0 VA: 0x18072AFB0
	public void UpdateViewMode() { }

	// RVA: 0x72D370 Offset: 0x72B970 VA: 0x18072D370
	internal BasePlayer.CameraMode get_idealViewMode() { }

	// RVA: 0x72D7D0 Offset: 0x72BDD0 VA: 0x18072D7D0
	internal bool get_shouldDrawBody() { }

	// RVA: 0x722C50 Offset: 0x721250 VA: 0x180722C50 Slot: 146
	public virtual void OnViewModeChanged() { }

	// RVA: 0x7194C0 Offset: 0x717AC0 VA: 0x1807194C0
	public void ModifyCamera() { }

	[BaseEntity.Menu] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.Description] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.Icon] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	[BaseEntity.Menu.ShowIf] // RVA: 0xBC060 Offset: 0xBB460 VA: 0x1800BC060
	// RVA: 0x7193F0 Offset: 0x7179F0 VA: 0x1807193F0
	public void Menu_AssistPlayer(BasePlayer player) { }

	// RVA: 0x7193B0 Offset: 0x7179B0 VA: 0x1807193B0
	public void Menu_AssistPlayer_TimeStart() { }

	// RVA: 0x719120 Offset: 0x717720 VA: 0x180719120
	public bool Menu_AssistPlayer_ShowIf(BasePlayer player) { }

	// RVA: 0x72D780 Offset: 0x72BD80 VA: 0x18072D780
	public GameObject get_lookingAt() { }

	// RVA: 0x72D710 Offset: 0x72BD10 VA: 0x18072D710
	public BaseEntity get_lookingAtEntity() { }

	// RVA: 0x72D6C0 Offset: 0x72BCC0 VA: 0x18072D6C0
	public Collider get_lookingAtCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D760 Offset: 0x72BD60 VA: 0x18072D760
	public Vector3 get_lookingAtPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72DB90 Offset: 0x72C190 VA: 0x18072DB90
	private void set_lookingAtPoint(Vector3 value) { }

	// RVA: 0x711750 Offset: 0x70FD50 VA: 0x180711750 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x712200 Offset: 0x710800 VA: 0x180712200 Slot: 57
	public override Vector3 GetLocalVelocityClient() { }

	// RVA: 0x709D70 Offset: 0x708370 VA: 0x180709D70 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x70EA90 Offset: 0x70D090 VA: 0x18070EA90
	private void CreatePlayerModel() { }

	// RVA: 0x70E8E0 Offset: 0x70CEE0 VA: 0x18070E8E0
	private void CreatePlayerCollision() { }

	// RVA: 0x70EFB0 Offset: 0x70D5B0 VA: 0x18070EFB0
	private void CreatePlayerMovement() { }

	// RVA: 0x715370 Offset: 0x713970 VA: 0x180715370
	internal void InitLocalPlayer() { }

	// RVA: 0x715650 Offset: 0x713C50 VA: 0x180715650
	internal void InitRemotePlayer() { }

	// RVA: 0x7149D0 Offset: 0x712FD0 VA: 0x1807149D0
	public bool HasLocalControls() { }

	// RVA: 0x727B50 Offset: 0x726150 VA: 0x180727B50 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x727C00 Offset: 0x726200 VA: 0x180727C00 Slot: 60
	public override void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x70F470 Offset: 0x70DA70 VA: 0x18070F470 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x723900 Offset: 0x721F00 VA: 0x180723900 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x719EA0 Offset: 0x7184A0 VA: 0x180719EA0
	private void OnFirstWakeUp() { }

	// RVA: 0x72D230 Offset: 0x72B830 VA: 0x18072D230
	public float get_TimeAwake() { }

	// RVA: 0x707870 Offset: 0x705E70 VA: 0x180707870
	public void CL_ClothingChanged() { }

	// RVA: 0x710B60 Offset: 0x70F160 VA: 0x180710B60
	public void ForceRebuild() { }

	// RVA: 0x7252C0 Offset: 0x7238C0 VA: 0x1807252C0
	internal void RebuildWorldModel(PlayerModel pModel) { }

	// RVA: 0x7272E0 Offset: 0x7258E0 VA: 0x1807272E0
	private void SetDefaultFootstepEffects(PlayerModel pModel) { }

	// RVA: 0x7226D0 Offset: 0x720CD0 VA: 0x1807226D0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x710170 Offset: 0x70E770 VA: 0x180710170 Slot: 124
	public override Transform FindBone(string strName) { }

	// RVA: 0x710C90 Offset: 0x70F290 VA: 0x180710C90 Slot: 123
	public override Transform[] GetBones() { }

	// RVA: 0x728410 Offset: 0x726A10 VA: 0x180728410 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x72D290 Offset: 0x72B890 VA: 0x18072D290
	public static BufferList<BasePlayer> get_VisiblePlayerList() { }

	// RVA: 0x7098A0 Offset: 0x707EA0 VA: 0x1807098A0
	public static void ClearVisibility() { }

	// RVA: 0x725A60 Offset: 0x724060 VA: 0x180725A60
	public static void RegisterForVisibility(BasePlayer player) { }

	// RVA: 0x728D10 Offset: 0x727310 VA: 0x180728D10
	public static void UnregisterFromVisibility(ulong userID) { }

	// RVA: 0x710270 Offset: 0x70E870 VA: 0x180710270
	public static BasePlayer FindByID_Clientside(ulong userID) { }

	// RVA: 0x710440 Offset: 0x70EA40 VA: 0x180710440
	public static BasePlayer Find_Clientside(string strNameOrIDOrIP) { }

	// RVA: 0x7141F0 Offset: 0x7127F0 VA: 0x1807141F0
	public static float GetRandomFloatBasedOnUserID(ulong steamid, ulong seed) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7283E0 Offset: 0x7269E0 VA: 0x1807283E0 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7277A0 Offset: 0x725DA0 VA: 0x1807277A0
	public void SetInheritedVelocity(Vector3 velocity, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x713F30 Offset: 0x712530 VA: 0x180713F30
	public void GetPerformanceReport(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x713AB0 Offset: 0x7120B0 VA: 0x180713AB0
	public void GetPerformanceReport_Frametime(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7198E0 Offset: 0x717EE0 VA: 0x1807198E0 Slot: 63
	public override void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x723150 Offset: 0x721750 VA: 0x180723150 Slot: 74
	public override void OnVoiceData(byte[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x725630 Offset: 0x723C30 VA: 0x180725630
	public void RecieveAchievement(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70E670 Offset: 0x70CC70 VA: 0x18070E670
	public void CraftMode(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728700 Offset: 0x726D00 VA: 0x180728700
	public void StartDesigningAI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x719C60 Offset: 0x718260 VA: 0x180719C60
	public void OnDebugAIEventTriggeredStateChange(int previousStateContainerID, int newStateContainerID, int sourceEventID) { }

	// RVA: 0x70AD10 Offset: 0x709310 VA: 0x18070AD10 Slot: 13
	public override void ClientOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D0F0 Offset: 0x70B6F0 VA: 0x18070D0F0
	private void Client_OnRepairFailedResources(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728970 Offset: 0x726F70 VA: 0x180728970
	private void TakeDamageHit() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x705E40 Offset: 0x704440 VA: 0x180705E40
	private void AdminReceivedUGC(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x705D80 Offset: 0x704380 VA: 0x180705D80
	private void AdminReceivedPatternFirework(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D1F0 Offset: 0x72B7F0 VA: 0x18072D1F0
	public bool get_IsWearingDiveGoggles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72D980 Offset: 0x72BF80 VA: 0x18072D980
	private void set_IsWearingDiveGoggles(bool value) { }

	// RVA: 0x728E60 Offset: 0x727460 VA: 0x180728E60
	protected void UpdateClothesIfNeeded() { }

	// RVA: 0x718E20 Offset: 0x717420 VA: 0x180718E20 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0x70C1D0 Offset: 0x70A7D0 VA: 0x18070C1D0
	protected void ClientUpdate_Sleeping() { }

	// RVA: 0x70C5B0 Offset: 0x70ABB0 VA: 0x18070C5B0
	protected void ClientUpdate() { }

	// RVA: 0x7250A0 Offset: 0x7236A0 VA: 0x1807250A0
	public void RebuildClothingItems() { }

	// RVA: 0x729350 Offset: 0x727950 VA: 0x180729350
	public void UpdateClothingItems(SkinnedMultiMesh multiMesh) { }

	// RVA: 0x729A80 Offset: 0x728080 VA: 0x180729A80
	public void UpdateHolsterOffsets() { }

	// RVA: 0x723840 Offset: 0x721E40 VA: 0x180723840
	public void PostLateClientCycle() { }

	// RVA: 0x716FA0 Offset: 0x7155A0 VA: 0x180716FA0
	public bool IsLocalPlayer() { }

	// RVA: 0x70AE70 Offset: 0x709470 VA: 0x18070AE70
	public void ClientUpdateLocalPlayer() { }

	// RVA: 0x72AE50 Offset: 0x729450 VA: 0x18072AE50
	public void UpdateTopologyStats() { }

	// RVA: 0x70ADC0 Offset: 0x7093C0 VA: 0x18070ADC0
	private void ClientTick() { }

	// RVA: 0x70F760 Offset: 0x70DD60 VA: 0x18070F760
	public void DoMovement() { }

	// RVA: 0x7195B0 Offset: 0x717BB0 VA: 0x1807195B0
	private void MountableOverrideViewAngles() { }

	// RVA: 0x706DB0 Offset: 0x7053B0 VA: 0x180706DB0 Slot: 147
	public virtual void BlockSprint(float duration = 0,2) { }

	// RVA: 0x706D10 Offset: 0x705310 VA: 0x180706D10 Slot: 148
	public virtual void BlockJump(float duration = 0,5) { }

	// RVA: 0x70A260 Offset: 0x708860 VA: 0x18070A260 Slot: 149
	internal virtual void ClientInput(InputState state) { }

	// RVA: 0x72B310 Offset: 0x729910 VA: 0x18072B310
	internal void UseAction(InputState state) { }

	// RVA: 0x711CF0 Offset: 0x7102F0 VA: 0x180711CF0
	internal BaseEntity GetInteractionEntity() { }

	// RVA: 0x724C80 Offset: 0x723280 VA: 0x180724C80
	internal void QuickUse() { }

	// RVA: 0x718D60 Offset: 0x717360 VA: 0x180718D60
	internal void LongUse() { }

	// RVA: 0x72B5E0 Offset: 0x729BE0 VA: 0x18072B5E0
	internal void UseStop() { }

	// RVA: 0x729C10 Offset: 0x728210 VA: 0x180729C10
	internal bool UpdateLookingAt(float radius, bool includeSecondaryEntities) { }

	// RVA: 0x725EB0 Offset: 0x7244B0 VA: 0x180725EB0
	private void ResetLookingAt() { }

	// RVA: 0x727930 Offset: 0x725F30 VA: 0x180727930
	private void SetLookingAt(HitTest lookingAtTest) { }

	// RVA: 0x7090A0 Offset: 0x7076A0 VA: 0x1807090A0
	private bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x710300 Offset: 0x70E900 VA: 0x180710300
	private static BaseVehicle FindVehicleParentFor(BaseEntity entity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x719DD0 Offset: 0x7183D0 VA: 0x180719DD0
	private void OnDied(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x71A1D0 Offset: 0x7187D0 VA: 0x18071A1D0
	private void OnRespawnInformation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x725D60 Offset: 0x724360 VA: 0x180725D60
	private void RequestRespawnUpdates() { }

	// RVA: 0x719FE0 Offset: 0x7185E0 VA: 0x180719FE0
	public void OnLand(float fVelocity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728890 Offset: 0x726E90 VA: 0x180728890
	private void StartLoading() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7106E0 Offset: 0x70ECE0 VA: 0x1807106E0
	private void FinishLoading() { }

	// RVA: 0x710B70 Offset: 0x70F170 VA: 0x180710B70
	private void FullBlack_FadeIn() { }

	[IteratorStateMachineAttribute] // RVA: 0xBE9B0 Offset: 0xBDDB0 VA: 0x1800BE9B0
	// RVA: 0x710830 Offset: 0x70EE30 VA: 0x180710830
	private IEnumerator FinishedLoadingRoutine() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70F250 Offset: 0x70D850 VA: 0x18070F250
	private void DirectionalDamage(Vector3 position, int damageType, int damageTotal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728CA0 Offset: 0x7272A0 VA: 0x180728CA0
	public void UnlockedBlueprint(BaseEntity.RPCMessage msg) { }

	// RVA: 0x709030 Offset: 0x707630 VA: 0x180709030
	private void CheckForRespawnInfo() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72ABB0 Offset: 0x7291B0 VA: 0x18072ABB0
	public void UpdateRichPresenceState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7144D0 Offset: 0x712AD0 VA: 0x1807144D0
	public void HandleCompanionPairingResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72AFF0 Offset: 0x7295F0 VA: 0x18072AFF0
	public Vector3 UpdateWaterDrinkingPoint() { }

	// RVA: 0x7144B0 Offset: 0x712AB0 VA: 0x1807144B0
	private Vector3 GetWaterDrinkingPoint() { }

	[BaseEntity.Menu] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.Description] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.Icon] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEE00 Offset: 0xBE200 VA: 0x1800BEE00
	// RVA: 0x70FA00 Offset: 0x70E000 VA: 0x18070FA00
	public void Drink(BasePlayer player) { }

	// RVA: 0x70F820 Offset: 0x70DE20 VA: 0x18070F820
	public bool Drink_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.Description] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.Icon] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEFB0 Offset: 0xBE3B0 VA: 0x1800BEFB0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void SaltWater(BasePlayer player) { }

	// RVA: 0x726030 Offset: 0x724630 VA: 0x180726030
	public bool SaltWater_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.Description] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.Icon] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	[BaseEntity.Menu.ShowIf] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	// RVA: 0x70DDF0 Offset: 0x70C3F0 VA: 0x18070DDF0
	public void Climb(BasePlayer player) { }

	// RVA: 0x70DB20 Offset: 0x70C120 VA: 0x18070DB20
	public bool Climb_ShowIf(BasePlayer player) { }

	// RVA: 0x714A40 Offset: 0x713040 VA: 0x180714A40
	public bool HasPlayerFlag(BasePlayer.PlayerFlags f) { }

	// RVA: 0x72D1E0 Offset: 0x72B7E0 VA: 0x18072D1E0
	public bool get_IsReceivingSnapshot() { }

	// RVA: 0x72D100 Offset: 0x72B700 VA: 0x18072D100
	public bool get_IsAdmin() { }

	// RVA: 0x72D1B0 Offset: 0x72B7B0 VA: 0x18072D1B0
	public bool get_IsDeveloper() { }

	// RVA: 0x72D110 Offset: 0x72B710 VA: 0x18072D110
	public bool get_IsAiming() { }

	// RVA: 0x72D1C0 Offset: 0x72B7C0 VA: 0x18072D1C0
	public bool get_IsFlying() { }

	// RVA: 0x72D120 Offset: 0x72B720 VA: 0x18072D120
	public bool get_IsConnected() { }

	// RVA: 0x72D050 Offset: 0x72B650 VA: 0x18072D050
	public bool get_InGesture() { }

	// RVA: 0x72CBA0 Offset: 0x72B1A0 VA: 0x18072CBA0
	private bool get_CurrentGestureBlocksMovement() { }

	// RVA: 0x72CBE0 Offset: 0x72B1E0 VA: 0x18072CBE0
	public bool get_CurrentGestureIsDance() { }

	// RVA: 0x72CC20 Offset: 0x72B220 VA: 0x18072CC20
	public bool get_CurrentGestureIsFullBody() { }

	// RVA: 0x72D020 Offset: 0x72B620 VA: 0x18072D020
	private bool get_InGestureCancelCooldown() { }

	// RVA: 0x7273A0 Offset: 0x7259A0 VA: 0x1807273A0
	private void SetGestureMenuOpen(bool wantsOpen) { }

	// RVA: 0x725E00 Offset: 0x724400 VA: 0x180725E00
	private void RequestStartGesture(GestureConfig g) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D650 Offset: 0x70BC50 VA: 0x18070D650
	private void Client_StartGesture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x70D6B0 Offset: 0x70BCB0 VA: 0x18070D6B0
	public void Client_StartGesture(GestureConfig gesture) { }

	// RVA: 0x723FF0 Offset: 0x7225F0 VA: 0x180723FF0
	private void ProcessDanceAction() { }

	// RVA: 0x726380 Offset: 0x724980 VA: 0x180726380
	public bool SayingHello() { }

	// RVA: 0x724500 Offset: 0x722B00 VA: 0x180724500
	private void ProcessGestureStart() { }

	// RVA: 0x70FD20 Offset: 0x70E320 VA: 0x18070FD20
	private void EndGesture() { }

	// RVA: 0x70FDC0 Offset: 0x70E3C0 VA: 0x18070FDC0
	private void EndLocalGesture() { }

	// RVA: 0x70FBB0 Offset: 0x70E1B0 VA: 0x18070FBB0
	private void EndGestureShared() { }

	// RVA: 0x7151B0 Offset: 0x7137B0 VA: 0x1807151B0
	private void HideHeldEntity(bool state) { }

	// RVA: 0x708D50 Offset: 0x707350 VA: 0x180708D50
	private void CancelGesture() { }

	// RVA: 0x725B50 Offset: 0x724150 VA: 0x180725B50
	public void RemoteGestureCancel() { }

	// RVA: 0x708930 Offset: 0x706F30 VA: 0x180708930
	private bool CancelGestureInput() { }

	// RVA: 0x709750 Offset: 0x707D50 VA: 0x180709750
	public void ClearGestureCooldown() { }

	// RVA: 0x70E400 Offset: 0x70CA00 VA: 0x18070E400
	public bool ConVarRequestStartGesture(string gestureName) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D600 Offset: 0x70BC00 VA: 0x18070D600
	private void Client_RemoteCancelledGesture() { }

	// RVA: 0x7168E0 Offset: 0x714EE0 VA: 0x1807168E0
	private bool IsGestureBlocked() { }

	// RVA: 0x72D300 Offset: 0x72B900 VA: 0x18072D300
	public float get_clientTeamLifetime() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7073A0 Offset: 0x7059A0 VA: 0x1807073A0
	public void CLIENT_ReceiveTeamInfo(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72AC00 Offset: 0x729200 VA: 0x18072AC00
	private void UpdateSteamGroup(ulong teamId, int teamSize) { }

	// RVA: 0x709780 Offset: 0x707D80 VA: 0x180709780
	private void ClearSteamGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x706E50 Offset: 0x705450 VA: 0x180706E50
	public void CLIENT_ClearTeam(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x706FF0 Offset: 0x7055F0 VA: 0x180706FF0
	public void CLIENT_PendingInvite(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.Description] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.Icon] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0AB0 Offset: 0xBFEB0 VA: 0x1800C0AB0
	// RVA: 0x7156C0 Offset: 0x713CC0 VA: 0x1807156C0
	public void InviteToTeam(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.Description] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.Icon] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0F20 Offset: 0xC0320 VA: 0x1800C0F20
	// RVA: 0x724AF0 Offset: 0x7230F0 VA: 0x180724AF0
	public void Promote(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Promote_Start() { }

	// RVA: 0x724720 Offset: 0x722D20 VA: 0x180724720
	public bool Promote_ShowIf(BasePlayer player) { }

	// RVA: 0x718860 Offset: 0x716E60 VA: 0x180718860
	public static bool LocalPlayerIsLeader() { }

	// RVA: 0x715C20 Offset: 0x714220 VA: 0x180715C20
	public bool Invite_ShowIf(BasePlayer player) { }

	// RVA: 0x711840 Offset: 0x70FE40 VA: 0x180711840
	public HeldEntity GetHeldEntity() { }

	// RVA: -1 Offset: -1
	public bool IsHoldingEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D1F0 Offset: 0x125B7F0 VA: 0x18125D1F0
	|-BasePlayer.IsHoldingEntity<Hammer>
	|-BasePlayer.IsHoldingEntity<object>
	|-BasePlayer.IsHoldingEntity<WireTool>
	*/

	// RVA: 0x711A80 Offset: 0x710080 VA: 0x180711A80
	private Item GetHeldItem() { }

	// RVA: 0x711A30 Offset: 0x710030 VA: 0x180711A30
	public uint GetHeldItemID() { }

	// RVA: 0x714F90 Offset: 0x713590 VA: 0x180714F90
	private void HeldEntityViewAngles() { }

	// RVA: 0x714B20 Offset: 0x713120 VA: 0x180714B20
	private void HeldEntityFrame() { }

	// RVA: 0x714CF0 Offset: 0x7132F0 VA: 0x180714CF0
	private void HeldEntityInput() { }

	// RVA: 0x7150B0 Offset: 0x7136B0 VA: 0x1807150B0
	private bool HeldItemUse() { }

	// RVA: 0x714EC0 Offset: 0x7134C0 VA: 0x180714EC0
	public void HeldEntityStart() { }

	// RVA: 0x714A50 Offset: 0x713050 VA: 0x180714A50
	public void HeldEntityEnd() { }

	// RVA: 0x716CA0 Offset: 0x7152A0 VA: 0x180716CA0
	public bool IsHostileItem(Item item) { }

	// RVA: 0x716E00 Offset: 0x715400 VA: 0x180716E00
	public bool IsItemHoldRestricted(Item item) { }

	// RVA: 0x718ED0 Offset: 0x7174D0 VA: 0x180718ED0
	private void MapInfoOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D2C0 Offset: 0x70B8C0 VA: 0x18070D2C0
	public void Client_ReceiveMarkers(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70D9F0 Offset: 0x70BFF0 VA: 0x18070D9F0
	public void Client_UpdateDeathMarker(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x70CFB0 Offset: 0x70B5B0 VA: 0x18070CFB0
	public void Client_AddNewDeathMarker(BaseEntity.RPCMessage msg) { }

	// RVA: 0x705CA0 Offset: 0x7042A0 VA: 0x180705CA0
	public void AddPointOfInterest(Vector3 position) { }

	// RVA: 0x709600 Offset: 0x707C00 VA: 0x180709600
	public void ClearAllPointsOfInterest() { }

	// RVA: 0x7094A0 Offset: 0x707AA0 VA: 0x1807094A0
	public void ClearAllMapMarkers() { }

	// RVA: 0x714580 Offset: 0x712B80 VA: 0x180714580
	public bool HasAttemptedMission(uint missionID) { }

	// RVA: 0x707BB0 Offset: 0x7061B0 VA: 0x180707BB0
	public bool CanAcceptMission(uint missionID) { }

	// RVA: 0x717080 Offset: 0x715680 VA: 0x180717080
	public bool IsMissionActive(uint missionID) { }

	// RVA: 0x7146F0 Offset: 0x712CF0 VA: 0x1807146F0
	public bool HasCompletedMission(uint missionID) { }

	// RVA: 0x714860 Offset: 0x712E60 VA: 0x180714860
	public bool HasFailedMission(uint missionID) { }

	// RVA: 0x7272C0 Offset: 0x7258C0 VA: 0x1807272C0
	public void SetActiveMission(int index) { }

	// RVA: 0x710C80 Offset: 0x70F280 VA: 0x180710C80
	public int GetActiveMission() { }

	// RVA: 0x714570 Offset: 0x712B70 VA: 0x180714570
	public bool HasActiveMission() { }

	// RVA: 0x717E40 Offset: 0x716440 VA: 0x180717E40
	private void LoadMissions(Missions loadedMissions) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x71A140 Offset: 0x718740 VA: 0x18071A140
	private void OnModelState(BaseEntity.RPCMessage data) { }

	// RVA: 0x71A0A0 Offset: 0x7186A0 VA: 0x18071A0A0
	private void OnModelStateChanged() { }

	// RVA: 0x72D5C0 Offset: 0x72BBC0 VA: 0x18072D5C0
	public bool get_isMounted() { }

	// RVA: 0x72D5F0 Offset: 0x72BBF0 VA: 0x18072D5F0
	public bool get_isMountingHidingWeapon() { }

	// RVA: 0x713570 Offset: 0x711B70 VA: 0x180713570
	public BaseMountable GetMounted() { }

	// RVA: 0x713520 Offset: 0x711B20 VA: 0x180713520
	public BaseVehicle GetMountedVehicle() { }

	// RVA: 0x718F20 Offset: 0x717520 VA: 0x180718F20
	public void MarkSwapSeat() { }

	// RVA: 0x728940 Offset: 0x726F40 VA: 0x180728940
	public bool SwapSeatCooldown() { }

	// RVA: 0x70BC90 Offset: 0x70A290 VA: 0x18070BC90
	public void ClientUpdateMounted(uint id) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7077A0 Offset: 0x705DA0 VA: 0x1807077A0
	public void CLIENT_SetPetPrefabID(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7075F0 Offset: 0x705BF0 VA: 0x1807075F0
	public void CLIENT_SetPetPetLoadedStateIndex(BaseEntity.RPCMessage msg) { }

	// RVA: 0x717CF0 Offset: 0x7162F0 VA: 0x180717CF0
	private void LinkPet() { }

	// RVA: 0x727D10 Offset: 0x726310 VA: 0x180727D10
	private void SetPetMenuOpen(bool wantsOpen) { }

	// RVA: 0x70AC20 Offset: 0x709220 VA: 0x18070AC20
	private void ClientIssuePetCommand(int cmdType, int param, bool raycast) { }

	// RVA: 0x717360 Offset: 0x715960 VA: 0x180717360
	public bool IsSleeping() { }

	// RVA: 0x717370 Offset: 0x715970 VA: 0x180717370
	public bool IsSpectating() { }

	// RVA: 0x717290 Offset: 0x715890 VA: 0x180717290
	public bool IsRelaxed() { }

	// RVA: 0x717350 Offset: 0x715950 VA: 0x180717350
	public bool IsServerFalling() { }

	// RVA: 0x7110A0 Offset: 0x70F6A0 VA: 0x1807110A0 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x708540 Offset: 0x706B40 VA: 0x180708540
	public bool CanBuild() { }

	// RVA: 0x7083E0 Offset: 0x7069E0 VA: 0x1807083E0
	public bool CanBuild(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x708310 Offset: 0x706910 VA: 0x180708310
	public bool CanBuild(OBB obb) { }

	// RVA: 0x716670 Offset: 0x714C70 VA: 0x180716670
	public bool IsBuildingBlocked() { }

	// RVA: 0x716510 Offset: 0x714B10 VA: 0x180716510
	public bool IsBuildingBlocked(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x716430 Offset: 0x714A30 VA: 0x180716430
	public bool IsBuildingBlocked(OBB obb) { }

	// RVA: 0x716230 Offset: 0x714830 VA: 0x180716230
	public bool IsBuildingAuthed() { }

	// RVA: 0x7162D0 Offset: 0x7148D0 VA: 0x1807162D0
	public bool IsBuildingAuthed(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x716160 Offset: 0x714760 VA: 0x180716160
	public bool IsBuildingAuthed(OBB obb) { }

	// RVA: 0x7086D0 Offset: 0x706CD0 VA: 0x1807086D0
	public bool CanPlaceBuildingPrivilege() { }

	// RVA: 0x708740 Offset: 0x706D40 VA: 0x180708740
	public bool CanPlaceBuildingPrivilege(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x708880 Offset: 0x706E80 VA: 0x180708880
	public bool CanPlaceBuildingPrivilege(OBB obb) { }

	// RVA: 0x719640 Offset: 0x717C40 VA: 0x180719640
	public int NewProjectileID() { }

	// RVA: 0x719650 Offset: 0x717C50 VA: 0x180719650
	public int NewProjectileSeed() { }

	// RVA: 0x727010 Offset: 0x725610 VA: 0x180727010
	public void SendProjectileAttack(PlayerProjectileAttack attack) { }

	// RVA: 0x727060 Offset: 0x725660 VA: 0x180727060
	public void SendProjectileRicochet(PlayerProjectileRicochet ricochet) { }

	// RVA: 0x7270B0 Offset: 0x7256B0 VA: 0x1807270B0
	public void SendProjectileUpdate(PlayerProjectileUpdate update) { }

	// RVA: 0x718400 Offset: 0x716A00 VA: 0x180718400 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728670 Offset: 0x726C70 VA: 0x180728670
	private void SpectatedPlayerHeadshot() { }

	// RVA: 0x714490 Offset: 0x712A90 VA: 0x180714490 Slot: 141
	public override float GetThreatLevel() { }

	// RVA: 0x70FEE0 Offset: 0x70E4E0 VA: 0x18070FEE0
	public void EnsureUpdated() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7276F0 Offset: 0x725CF0 VA: 0x1807276F0
	public void SetHostileLength(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728340 Offset: 0x726940 VA: 0x180728340
	public void SetWeaponDrawnDuration(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 150
	protected virtual void ModifyInputState(ref InputState inputState) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7108A0 Offset: 0x70EEA0 VA: 0x1807108A0
	private void ForcePositionToParentOffset(Vector3 position, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x728E00 Offset: 0x727400 VA: 0x180728E00
	public void UpdateClientTickRate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7109D0 Offset: 0x70EFD0 VA: 0x1807109D0
	private void ForcePositionTo(Vector3 position) { }

	// RVA: 0x727100 Offset: 0x725700 VA: 0x180727100
	internal void SendVoiceData(byte[] data, int len) { }

	// RVA: 0x726920 Offset: 0x724F20 VA: 0x180726920
	internal void SendClientTick() { }

	// RVA: 0x7196B0 Offset: 0x717CB0 VA: 0x1807196B0
	public void NotifyUnderwearChange() { }

	// RVA: 0x72A8B0 Offset: 0x728EB0 VA: 0x18072A8B0
	public static void UpdatePlayerVisibilities() { }

	// RVA: 0x728AA0 Offset: 0x7270A0 VA: 0x180728AA0
	private float TimeSinceSeen() { }

	// RVA: 0x727CE0 Offset: 0x7262E0 VA: 0x180727CE0
	private void SetNextVisThink(float addTime) { }

	// RVA: 0x72C120 Offset: 0x72A720 VA: 0x18072C120
	private bool WantsVisUpdate() { }

	// RVA: 0x715E60 Offset: 0x714460 VA: 0x180715E60
	public static bool IsAimingAt(BasePlayer aimer, BasePlayer target, float cone = 0,95) { }

	// RVA: 0x7297B0 Offset: 0x727DB0 VA: 0x1807297B0 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0x72B760 Offset: 0x729D60 VA: 0x18072B760
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x72B870 Offset: 0x729E70 VA: 0x18072B870
	private void VisUpdateUsingRays(float dist) { }

	// RVA: 0x718A10 Offset: 0x717010 VA: 0x180718A10
	private void LogDebugCull(float dist) { }

	// RVA: 0x722E50 Offset: 0x721450 VA: 0x180722E50 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0x72BC90 Offset: 0x72A290 VA: 0x18072BC90
	private void VisUpdate() { }

	// RVA: 0x72B6A0 Offset: 0x729CA0 VA: 0x18072B6A0
	private bool VisPlayerArmed() { }

	// RVA: 0x706110 Offset: 0x704710 VA: 0x180706110
	private bool AnyPartVisible() { }

	// RVA: 0x707A70 Offset: 0x706070 VA: 0x180707A70
	private float CalcVisUpdateRate(float dist) { }

	// RVA: 0x723570 Offset: 0x721B70 VA: 0x180723570
	private bool PointSeePoint(Vector3 target, Vector3 origin, float dist = 0, bool useGameTrace = False) { }

	// RVA: 0x717650 Offset: 0x715C50 VA: 0x180717650
	public bool IsWounded() { }

	// RVA: 0x716720 Offset: 0x714D20 VA: 0x180716720
	public bool IsCrawling() { }

	// RVA: 0x716DF0 Offset: 0x7153F0 VA: 0x180716DF0
	public bool IsIncapacitated() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 97
	public override BasePlayer ToPlayer() { }

	// RVA: 0x72CB90 Offset: 0x72B190 VA: 0x18072CB90
	public Connection get_Connection() { }

	// RVA: 0x72D350 Offset: 0x72B950 VA: 0x18072D350
	public string get_displayName() { }

	// RVA: 0x72D990 Offset: 0x72BF90 VA: 0x18072D990
	public void set_displayName(string value) { }

	// RVA: 0x726200 Offset: 0x724800 VA: 0x180726200
	public static string SanitizePlayerNameString(string playerName, ulong userId) { }

	// RVA: 0x716BD0 Offset: 0x7151D0 VA: 0x180716BD0
	public bool IsGod() { }

	// RVA: 0x713610 Offset: 0x711C10 VA: 0x180713610 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	// RVA: 0x708670 Offset: 0x706C70 VA: 0x180708670
	public bool CanInteract() { }

	// RVA: 0x7085E0 Offset: 0x706BE0 VA: 0x1807085E0
	public bool CanInteract(bool usableWhileCrawling) { }

	// RVA: 0x728870 Offset: 0x726E70 VA: 0x180728870 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x723180 Offset: 0x721780 VA: 0x180723180 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x718F60 Offset: 0x717560 VA: 0x180718F60 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x719010 Offset: 0x717610 VA: 0x180719010 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x72C600 Offset: 0x72AC00 VA: 0x18072C600 Slot: 103
	public override OBB WorldSpaceBounds() { }

	// RVA: 0x713450 Offset: 0x711A50 VA: 0x180713450
	public Vector3 GetMountVelocity() { }

	// RVA: 0x711B70 Offset: 0x710170 VA: 0x180711B70 Slot: 100
	public override Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x711C30 Offset: 0x710230 VA: 0x180711C30 Slot: 101
	public override Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x711AB0 Offset: 0x7100B0 VA: 0x180711AB0 Slot: 102
	public override Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x723B80 Offset: 0x722180 VA: 0x180723B80 Slot: 29
	public override void PreInitShared() { }

	// RVA: 0x70F1D0 Offset: 0x70D7D0 VA: 0x18070F1D0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x715340 Offset: 0x713940 VA: 0x180715340
	public bool InSafeZone() { }

	// RVA: 0x717660 Offset: 0x715C60 VA: 0x180717660
	public static void LateClientCycle() { }

	// RVA: 0x709A60 Offset: 0x708060 VA: 0x180709A60
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0x710D20 Offset: 0x70F320 VA: 0x180710D20
	public Bounds GetBounds(bool ducked) { }

	// RVA: 0x710EB0 Offset: 0x70F4B0 VA: 0x180710EB0
	public Bounds GetBounds() { }

	// RVA: 0x711170 Offset: 0x70F770 VA: 0x180711170
	public Vector3 GetCenter(bool ducked) { }

	// RVA: 0x711290 Offset: 0x70F890 VA: 0x180711290
	public Vector3 GetCenter() { }

	// RVA: 0x713730 Offset: 0x711D30 VA: 0x180713730
	public Vector3 GetOffset(bool ducked) { }

	// RVA: 0x7136B0 Offset: 0x711CB0 VA: 0x1807136B0
	public Vector3 GetOffset() { }

	// RVA: 0x7142F0 Offset: 0x7128F0 VA: 0x1807142F0
	public Vector3 GetSize(bool ducked) { }

	// RVA: 0x714270 Offset: 0x712870 VA: 0x180714270
	public Vector3 GetSize() { }

	// RVA: 0x711820 Offset: 0x70FE20 VA: 0x180711820
	public float GetHeight(bool ducked) { }

	// RVA: 0x7117E0 Offset: 0x70FDE0 VA: 0x1807117E0
	public float GetHeight() { }

	// RVA: 0x7141E0 Offset: 0x7127E0 VA: 0x1807141E0
	public float GetRadius() { }

	// RVA: 0x7121F0 Offset: 0x7107F0 VA: 0x1807121F0
	public float GetJumpHeight() { }

	// RVA: 0x728BA0 Offset: 0x7271A0 VA: 0x180728BA0 Slot: 104
	public override Vector3 TriggerPoint() { }

	// RVA: 0x719660 Offset: 0x717C60 VA: 0x180719660
	public Vector3 NoClipOffset() { }

	// RVA: 0x7196A0 Offset: 0x717CA0 VA: 0x1807196A0
	public float NoClipRadius(float margin) { }

	// RVA: 0x718F50 Offset: 0x717550 VA: 0x180718F50
	public float MaxDeployDistance(Item item) { }

	// RVA: 0x70C1A0 Offset: 0x70A7A0 VA: 0x18070C1A0
	public void ClientUpdatePersistantData(PersistantPlayer data) { }

	// RVA: 0x713420 Offset: 0x711A20 VA: 0x180713420
	public float GetMinSpeed() { }

	// RVA: 0x7123D0 Offset: 0x7109D0 VA: 0x1807123D0
	public float GetMaxSpeed() { }

	// RVA: 0x714350 Offset: 0x712950 VA: 0x180714350
	public float GetSpeed(float running, float ducking, float crawling) { }

	// RVA: 0x7196F0 Offset: 0x717CF0 VA: 0x1807196F0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x70FB50 Offset: 0x70E150 VA: 0x18070FB50
	private void EnablePlayerCollider() { }

	// RVA: 0x70F410 Offset: 0x70DA10 VA: 0x18070F410
	private void DisablePlayerCollider() { }

	// RVA: 0x725750 Offset: 0x723D50 VA: 0x180725750
	private void RefreshColliderSize(bool forced) { }

	// RVA: 0x728320 Offset: 0x726920 VA: 0x180728320
	private void SetPlayerRigidbodyState(bool isEnabled) { }

	// RVA: 0x705B20 Offset: 0x704120 VA: 0x180705B20
	private void AddPlayerRigidbody() { }

	// RVA: 0x725C30 Offset: 0x724230 VA: 0x180725C30
	private void RemovePlayerRigidbody() { }

	// RVA: 0x7167F0 Offset: 0x714DF0 VA: 0x1807167F0
	public bool IsEnsnared() { }

	// RVA: 0x716030 Offset: 0x714630 VA: 0x180716030
	public bool IsAttacking() { }

	// RVA: 0x708020 Offset: 0x706620 VA: 0x180708020
	public bool CanAttack() { }

	// RVA: 0x719F50 Offset: 0x718550 VA: 0x180719F50
	public bool OnLadder() { }

	// RVA: 0x717600 Offset: 0x715C00 VA: 0x180717600
	public bool IsSwimming() { }

	// RVA: 0x716C50 Offset: 0x715250 VA: 0x180716C50
	public bool IsHeadUnderwater() { }

	// RVA: 0x7171F0 Offset: 0x7157F0 VA: 0x1807171F0 Slot: 151
	public virtual bool IsOnGround() { }

	// RVA: 0x7172A0 Offset: 0x7158A0 VA: 0x1807172A0
	public bool IsRunning() { }

	// RVA: 0x716740 Offset: 0x714D40 VA: 0x180716740
	public bool IsDucked() { }

	// RVA: 0x7255A0 Offset: 0x723BA0 VA: 0x1807255A0
	public bool RecentlyTeleported() { }

	// RVA: 0x728470 Offset: 0x726A70 VA: 0x180728470
	public void ShowToast(int style, Translate.Phrase phrase) { }

	// RVA: 0x708E20 Offset: 0x707420 VA: 0x180708E20
	public void ChatMessage(string msg) { }

	// RVA: 0x70E5B0 Offset: 0x70CBB0 VA: 0x18070E5B0
	public void ConsoleMessage(string msg) { }

	// RVA: 0x723180 Offset: 0x721780 VA: 0x180723180 Slot: 114
	public override float PenetrationResistance(HitInfo info) { }

	// RVA: 0x726690 Offset: 0x724C90 VA: 0x180726690 Slot: 142
	public override void ScaleDamage(HitInfo info) { }

	// RVA: 0x72A4E0 Offset: 0x728AE0 VA: 0x18072A4E0
	private void UpdateMoveSpeedFromClothing() { }

	// RVA: 0x72AA90 Offset: 0x729090 VA: 0x18072AA90 Slot: 152
	public virtual void UpdateProtectionFromClothing() { }

	// RVA: 0x708DF0 Offset: 0x7073F0 VA: 0x180708DF0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x728AC0 Offset: 0x7270C0 VA: 0x180728AC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x711400 Offset: 0x70FA00 VA: 0x180711400
	public string GetDebugStatus() { }

	// RVA: 0x712140 Offset: 0x710740 VA: 0x180712140 Slot: 118
	public override Item GetItem(uint itemId) { }

	// RVA: 0x72D270 Offset: 0x72B870 VA: 0x18072D270 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x72C140 Offset: 0x72A740 VA: 0x18072C140 Slot: 107
	public override float WaterFactor() { }

	// RVA: 0x706060 Offset: 0x704660 VA: 0x180706060 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x713780 Offset: 0x711D80 VA: 0x180713780
	public float GetOxygenTime(out ItemModGiveOxygen.AirSupplyType airSupplyType) { }

	// RVA: 0x717370 Offset: 0x715970 VA: 0x180717370 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x706750 Offset: 0x704D50 VA: 0x180706750
	public static bool AnyPlayersVisibleToEntity(Vector3 pos, float radius, BaseEntity source, Vector3 entityEyePos, bool ignorePlayersWithPriv = False) { }

	// RVA: 0x717380 Offset: 0x715980 VA: 0x180717380
	public bool IsStandingOnEntity(BaseEntity standingOn, int layerMask) { }

	// RVA: 0x7272D0 Offset: 0x7258D0 VA: 0x1807272D0
	public void SetActiveTelephone(PhoneController t) { }

	// RVA: 0x72CC60 Offset: 0x72B260 VA: 0x18072CC60
	public bool get_HasActiveTelephone() { }

	// RVA: 0x72D150 Offset: 0x72B750 VA: 0x18072D150
	public bool get_IsDesigningAI() { }

	// RVA: 0x709730 Offset: 0x707D30 VA: 0x180709730
	public void ClearDesigningAIEntity() { }

	// RVA: 0x72C9E0 Offset: 0x72AFE0 VA: 0x18072C9E0
	public void .ctor() { }

	// RVA: 0x72C890 Offset: 0x72AE90 VA: 0x18072C890
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

	// RVA: 0x93B9A0 Offset: 0x939FA0 VA: 0x18093B9A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B720 Offset: 0x939D20 VA: 0x18093B720
	internal ulong <OnBecameRagdoll>b__103_0(PlayerTeam.TeamMember m) { }

	// RVA: 0x93B7F0 Offset: 0x939DF0 VA: 0x18093B7F0
	internal int <UpdateLookingAt>b__148_0(TraceInfo a, TraceInfo b) { }

	// RVA: 0x93B740 Offset: 0x939D40 VA: 0x18093B740
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

	// RVA: 0x93AE60 Offset: 0x939460 VA: 0x18093AE60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93B3C0 Offset: 0x9399C0 VA: 0x18093B3C0 Slot: 8
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

	// RVA: 0x93B810 Offset: 0x939E10 VA: 0x18093B810
	internal void <SetGestureMenuOpen>b__0(BasePlayer ply) { }

}

private sealed class BasePlayer.<>c__DisplayClass304_0 // TypeDefIndex: 8345
{	// Fields
	public uint index; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B840 Offset: 0x939E40 VA: 0x18093B840
	internal bool <CLIENT_SetPetPetLoadedStateIndex>b__0(PetCommandList.PetCommandDesc c) { }

}

private sealed class BasePlayer.<>c__DisplayClass306_0 // TypeDefIndex: 8346
{	// Fields
	public PetCommandList.PetCommandDesc desc; // 0x10
	public BasePlayer <>4__this; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x93B860 Offset: 0x939E60 VA: 0x18093B860
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

	// RVA: 0xC36EA0 Offset: 0xC354A0 VA: 0x180C36EA0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC36AF0 Offset: 0xC350F0 VA: 0x180C36AF0
	protected void Initialize() { }

	// RVA: 0xC362D0 Offset: 0xC348D0 VA: 0x180C362D0
	public void DoDestroy() { }

	// RVA: 0xC36250 Offset: 0xC34850 VA: 0x180C36250
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC372F0 Offset: 0xC358F0 VA: 0x180C372F0
	private void UpdatedItemContainer(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC36910 Offset: 0xC34F10 VA: 0x180C36910
	public Item FindItemUID(uint id) { }

	// RVA: 0xC36630 Offset: 0xC34C30 VA: 0x180C36630
	public Item FindItemID(string itemName) { }

	// RVA: 0xC36750 Offset: 0xC34D50 VA: 0x180C36750
	public Item FindItemID(int id) { }

	// RVA: 0xC363B0 Offset: 0xC349B0 VA: 0x180C363B0
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xC36820 Offset: 0xC34E20 VA: 0x180C36820
	public List<Item> FindItemIDs(int id) { }

	// RVA: 0xC36480 Offset: 0xC34A80 VA: 0x180C36480
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC36A70 Offset: 0xC35070 VA: 0x180C36A70
	public ItemContainer GetContainer(PlayerInventory.Type id) { }

	// RVA: 0xC36D50 Offset: 0xC35350 VA: 0x180C36D50
	public void Load(PlayerInventory msg) { }

	// RVA: 0xC369F0 Offset: 0xC34FF0 VA: 0x180C369F0
	public int GetAmount(int itemid) { }

	// RVA: 0xC36180 Offset: 0xC34780 VA: 0x180C36180
	public Item[] AllItems() { }

	// RVA: 0xC360B0 Offset: 0xC346B0 VA: 0x180C360B0
	public int AllItemsNoAlloc(ref List<Item> items) { }

	// RVA: 0xC36360 Offset: 0xC34960 VA: 0x180C36360
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xC36A90 Offset: 0xC35090 VA: 0x180C36A90
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xC374E0 Offset: 0xC35AE0 VA: 0x180C374E0
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

	// RVA: 0xC37930 Offset: 0xC35F30 VA: 0x180C37930 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC378F0 Offset: 0xC35EF0 VA: 0x180C378F0
	public bool IsLooting() { }

	// RVA: 0xC37520 Offset: 0xC35B20 VA: 0x180C37520
	public void Clear() { }

	// RVA: 0xC375B0 Offset: 0xC35BB0 VA: 0x180C375B0
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC37740 Offset: 0xC35D40 VA: 0x180C37740
	public Item FindItem(uint id) { }

	// RVA: 0xC378E0 Offset: 0xC35EE0 VA: 0x180C378E0
	public BaseEntity GetClientEntity() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC37D80 Offset: 0xC36380 VA: 0x180C37D80
	private void UpdateLoot(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xC38010 Offset: 0xC36610 VA: 0x180C38010
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

	// RVA: 0xC38690 Offset: 0xC36C90 VA: 0x180C38690 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC38AE0 Offset: 0xC370E0 VA: 0x180C38AE0 Slot: 10
	public override void Reset() { }

	// RVA: 0xC38080 Offset: 0xC36680 VA: 0x180C38080
	public bool CanConsume() { }

	// RVA: 0xC38450 Offset: 0xC36A50 VA: 0x180C38450
	public void MarkConsumption() { }

	// RVA: 0xC38130 Offset: 0xC36730 VA: 0x180C38130
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC38DA0 Offset: 0xC373A0 VA: 0x180C38DA0
	public void UpdateMetabolism(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC38BF0 Offset: 0xC371F0 VA: 0x180C38BF0
	public PlayerMetabolism Save() { }

	// RVA: 0xC38230 Offset: 0xC36830 VA: 0x180C38230
	public void Load(PlayerMetabolism s) { }

	// RVA: 0xC38180 Offset: 0xC36780 VA: 0x180C38180 Slot: 12
	public override MetabolismAttribute FindAttribute(MetabolismAttribute.Type type) { }

	// RVA: 0xC38470 Offset: 0xC36A70 VA: 0x180C38470
	public void OnLocalMetabolismUpdated() { }

	// RVA: 0xC38E80 Offset: 0xC37480 VA: 0x180C38E80
	public void .ctor() { }

}

public class PlayerModifiers : BaseModifiers<BasePlayer> // TypeDefIndex: 8624
{	// Methods

	// RVA: 0x98DC50 Offset: 0x98C250 VA: 0x18098DC50 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x98D8A0 Offset: 0x98BEA0 VA: 0x18098D8A0
	public void Load(PlayerModifiers m) { }

	// RVA: 0x98D840 Offset: 0x98BE40 VA: 0x18098D840
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x98E0A0 Offset: 0x98C6A0 VA: 0x18098E0A0
	public void UpdateModifiers(BaseEntity.RPCMessage packet) { }

	// RVA: 0x98E180 Offset: 0x98C780 VA: 0x18098E180
	public void .ctor() { }

}

public class PlayerDetectionTrigger : TriggerBase // TypeDefIndex: 8703
{	// Fields
	public BaseDetector myDetector; // 0x30

	// Methods

	// RVA: 0x4D3840 Offset: 0x4D1E40 VA: 0x1804D3840
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

	// RVA: 0xC39150 Offset: 0xC37750 VA: 0x180C39150
	private void CacheOriginalMaterials() { }

	// RVA: 0xC398F0 Offset: 0xC37EF0 VA: 0x180C398F0
	private void Setup(HairType type, HairSetCollection hair, int meshIndex, float typeNum, float dyeNum, MaterialPropertyBlock block) { }

	// RVA: 0xC39550 Offset: 0xC37B50 VA: 0x180C39550
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0xC39430 Offset: 0xC37A30 VA: 0x180C39430
	public static void GetRandomVariation(float hairNum, int typeIndex, int meshIndex, out float typeNum, out float dyeNum) { }

	// RVA: 0xC393A0 Offset: 0xC379A0 VA: 0x180C393A0
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

	// RVA: 0x98D330 Offset: 0x98B930 VA: 0x18098D330
	public void SetupHairCap(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class PlayerModelSkin : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9218
{	// Fields
	public PlayerModelSkin.SkinMaterialType MaterialType; // 0x18
	public Renderer SkinRenderer; // 0x20

	// Methods

	// RVA: 0x98D700 Offset: 0x98BD00 VA: 0x18098D700
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum) { }

	// RVA: 0x98D6A0 Offset: 0x98BCA0 VA: 0x18098D6A0 Slot: 4
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
	// RVA: 0x533DF0 Offset: 0x5323F0 VA: 0x180533DF0
	public float get_Range() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E00 Offset: 0x532400 VA: 0x180533E00
	public void set_Range(float value) { }

	// RVA: 0xC2D720 Offset: 0xC2BD20 VA: 0x180C2D720
	public void .ctor() { }

}

public class PlayerAnimationEvents : MonoBehaviour // TypeDefIndex: 9645
{	// Fields
	private BasePlayer player; // 0x18

	// Methods

	// RVA: 0x91EAB0 Offset: 0x91D0B0 VA: 0x18091EAB0
	protected void OnEnable() { }

	// RVA: 0x91F210 Offset: 0x91D810 VA: 0x18091F210
	public void ThirdPersonReloadSound(AnimationEvent animEvent) { }

	// RVA: 0x91F0C0 Offset: 0x91D6C0 VA: 0x18091F0C0
	public void ThirdPersonMeleeAttackSound(AnimationEvent animEvent) { }

	// RVA: 0x91EE50 Offset: 0x91D450 VA: 0x18091EE50
	public void ThirdPersonDeploySound(AnimationEvent animEvent) { }

	// RVA: 0x91EF70 Offset: 0x91D570 VA: 0x18091EF70
	public void ThirdPersonLiquidThrowSound(AnimationEvent animEvent) { }

	// RVA: 0x91EB50 Offset: 0x91D150 VA: 0x18091EB50
	public void PlayThirdPersonSound(SoundDefinition def) { }

	// RVA: 0x91EC00 Offset: 0x91D200 VA: 0x18091EC00
	public bool ShouldPlayThirdPersonSounds() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void SleepingEvent(AnimationEvent animEvent) { }

	// RVA: 0x91ED00 Offset: 0x91D300 VA: 0x18091ED00
	public void SplashEvent(string splashType) { }

	// RVA: 0x91F4D0 Offset: 0x91DAD0 VA: 0x18091F4D0
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

	// RVA: 0x920210 Offset: 0x91E810 VA: 0x180920210
	public static int get_MaxBeltSlots() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(BasePlayer player) { }

	// RVA: 0x9200E0 Offset: 0x91E6E0 VA: 0x1809200E0
	public Item GetItemInSlot(int slot) { }

	// RVA: 0x920040 Offset: 0x91E640 VA: 0x180920040
	public Item GetActiveItem() { }

	// RVA: 0x91F5E0 Offset: 0x91DBE0 VA: 0x18091F5E0
	public bool CanHoldItem() { }

	// RVA: 0x91FF80 Offset: 0x91E580 VA: 0x18091FF80
	public void FrameUpdate() { }

	// RVA: 0x91F6D0 Offset: 0x91DCD0 VA: 0x18091F6D0
	public void ChangeSelect(int iSlot, bool allowRunAction = False) { }

	// RVA: 0x91FE50 Offset: 0x91E450 VA: 0x18091FE50
	public void DoNextItemDirection(InputState state, int direction) { }

	// RVA: 0x91F980 Offset: 0x91DF80 VA: 0x18091F980
	public void ClientInput(InputState state) { }

	// RVA: 0x9201D0 Offset: 0x91E7D0 VA: 0x1809201D0
	private static void .cctor() { }

}

public class PlayerBlueprints : EntityComponent<BasePlayer> // TypeDefIndex: 9647
{	// Fields
	public SteamInventory steamInventory; // 0x20
	private int[] craftableItems; // 0x28

	// Methods

	// RVA: 0x920510 Offset: 0x91EB10 VA: 0x180920510
	public void ClientInit() { }

	// RVA: 0x9205C0 Offset: 0x91EBC0 VA: 0x1809205C0
	public void ClientUpdate(PersistantPlayer info) { }

	// RVA: 0x920680 Offset: 0x91EC80 VA: 0x180920680
	public bool HasUnlocked(ItemDefinition targetItem) { }

	// RVA: 0x920220 Offset: 0x91E820 VA: 0x180920220
	public bool CanCraft(int itemid, int skinItemId, ulong playerId) { }

	// RVA: 0x920410 Offset: 0x91EA10 VA: 0x180920410
	public bool CheckSkinOwnership(int skinItemId, ulong playerId) { }

	// RVA: 0x920A70 Offset: 0x91F070 VA: 0x180920A70
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

	// RVA: 0xC32890 Offset: 0xC30E90 VA: 0x180C32890
	public Vector3 get_worldMountedPosition() { }

	// RVA: 0xC32A80 Offset: 0xC31080 VA: 0x180C32A80
	public Vector3 get_worldStandingPosition() { }

	// RVA: 0xC32790 Offset: 0xC30D90 VA: 0x180C32790
	public Vector3 get_worldCrouchedPosition() { }

	// RVA: 0xC32690 Offset: 0xC30C90 VA: 0x180C32690
	public Vector3 get_worldCrawlingPosition() { }

	// RVA: 0xC32150 Offset: 0xC30750 VA: 0x180C32150
	public Vector3 get_position() { }

	// RVA: 0xC31810 Offset: 0xC2FE10 VA: 0x180C31810
	private Vector3 get_BodyLeanOffset() { }

	// RVA: 0xC31B70 Offset: 0xC30170 VA: 0x180C31B70
	public Vector3 get_center() { }

	// RVA: 0xC31E90 Offset: 0xC30490 VA: 0x180C31E90
	public Vector3 get_offset() { }

	// RVA: 0xC325E0 Offset: 0xC30BE0 VA: 0x180C325E0
	public Quaternion get_rotation() { }

	// RVA: 0xC32BE0 Offset: 0xC311E0 VA: 0x180C32BE0
	public void set_rotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC31A90 Offset: 0xC30090 VA: 0x180C31A90
	public Quaternion get_bodyRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32BB0 Offset: 0xC311B0 VA: 0x180C32BB0
	public void set_bodyRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC31E70 Offset: 0xC30470 VA: 0x180C31E70
	public Vector3 get_headAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32BC0 Offset: 0xC311C0 VA: 0x180C32BC0
	public void set_headAngles(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC325D0 Offset: 0xC30BD0 VA: 0x180C325D0
	public Quaternion get_rotationLook() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32BD0 Offset: 0xC311D0 VA: 0x180C32BD0
	public void set_rotationLook(Quaternion value) { }

	// RVA: 0xC31FC0 Offset: 0xC305C0 VA: 0x180C31FC0
	public Quaternion get_parentRotation() { }

	// RVA: 0xC31AA0 Offset: 0xC300A0 VA: 0x180C31AA0
	public bool get_canUpdateViewAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC31A80 Offset: 0xC30080 VA: 0x180C31A80
	public bool get_IsAltLookingLegsThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32BA0 Offset: 0xC311A0 VA: 0x180C32BA0
	private void set_IsAltLookingLegsThreshold(bool value) { }

	// RVA: 0xC303A0 Offset: 0xC2E9A0 VA: 0x180C303A0
	public void FrameUpdate(Camera cam) { }

	// RVA: 0xC31430 Offset: 0xC2FA30 VA: 0x180C31430
	public void UpdateAltLegsThreshold(float yAngle) { }

	// RVA: 0xC314A0 Offset: 0xC2FAA0 VA: 0x180C314A0
	private void UpdateCamera(Camera cam) { }

	// RVA: 0xC2E480 Offset: 0xC2CA80 VA: 0x180C2E480
	private void DoFirstPersonCamera(Camera cam) { }

	// RVA: 0xC2EAD0 Offset: 0xC2D0D0 VA: 0x180C2EAD0
	private void DoInEyeCamera(Camera cam) { }

	// RVA: 0xC2EE20 Offset: 0xC2D420 VA: 0x180C2EE20
	private void DoThirdPersonCamera(Camera cam) { }

	// RVA: 0xC2DEA0 Offset: 0xC2C4A0 VA: 0x180C2DEA0
	private void DoDeathCamera(Camera cam) { }

	// RVA: 0xC2D870 Offset: 0xC2BE70 VA: 0x180C2D870
	private void ApplyCameraMoves(Camera cam) { }

	// RVA: 0xC310B0 Offset: 0xC2F6B0 VA: 0x180C310B0
	public Vector3 MovementForward() { }

	// RVA: 0xC31270 Offset: 0xC2F870 VA: 0x180C31270
	public Vector3 MovementRight() { }

	// RVA: 0xC2DA50 Offset: 0xC2C050 VA: 0x180C2DA50
	public Ray BodyRay() { }

	// RVA: 0xC2D900 Offset: 0xC2BF00 VA: 0x180C2D900
	public Vector3 BodyForward() { }

	// RVA: 0xC2DC00 Offset: 0xC2C200 VA: 0x180C2DC00
	public Vector3 BodyRight() { }

	// RVA: 0xC2DD50 Offset: 0xC2C350 VA: 0x180C2DD50
	public Vector3 BodyUp() { }

	// RVA: 0xC30CF0 Offset: 0xC2F2F0 VA: 0x180C30CF0
	public Ray HeadRay() { }

	// RVA: 0xC30C00 Offset: 0xC2F200 VA: 0x180C30C00
	public Vector3 HeadForward() { }

	// RVA: 0xC30ED0 Offset: 0xC2F4D0 VA: 0x180C30ED0
	public Vector3 HeadRight() { }

	// RVA: 0xC30FC0 Offset: 0xC2F5C0 VA: 0x180C30FC0
	public Vector3 HeadUp() { }

	// RVA: 0xC30A80 Offset: 0xC2F080 VA: 0x180C30A80
	public Quaternion GetLookRotation() { }

	// RVA: 0xC309C0 Offset: 0xC2EFC0 VA: 0x180C309C0
	public Quaternion GetAimRotation() { }

	// RVA: 0xC31750 Offset: 0xC2FD50 VA: 0x180C31750
	public void .ctor() { }

	// RVA: 0xC31650 Offset: 0xC2FC50 VA: 0x180C31650
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

	// RVA: 0xC35AB0 Offset: 0xC340B0 VA: 0x180C35AB0
	protected void OnDisable() { }

	// RVA: 0xC34C60 Offset: 0xC33260 VA: 0x180C34C60
	public void FrameUpdate() { }

	// RVA: 0xC34680 Offset: 0xC32C80 VA: 0x180C34680
	private bool CanToggleAds() { }

	// RVA: 0xC34AF0 Offset: 0xC330F0 VA: 0x180C34AF0
	private void Flip() { }

	// RVA: 0xC35B30 Offset: 0xC34130 VA: 0x180C35B30
	public void ResetMouseDelta() { }

	// RVA: 0xC32EE0 Offset: 0xC314E0 VA: 0x180C32EE0
	private void AddMouseDelta() { }

	// RVA: 0xC331B0 Offset: 0xC317B0 VA: 0x180C331B0
	private void AdjustMouseMovement(ref Vector2 mm) { }

	// RVA: 0xC35D30 Offset: 0xC34330 VA: 0x180C35D30
	private void UpdateViewAngles() { }

	// RVA: 0xC333F0 Offset: 0xC319F0 VA: 0x180C333F0
	public void ApplyViewAngles() { }

	// RVA: 0xC35C10 Offset: 0xC34210 VA: 0x180C35C10
	public void SetViewVars(Vector3 newAngles) { }

	// RVA: 0xC34910 Offset: 0xC32F10 VA: 0x180C34910
	public void FinalizeRecoil() { }

	// RVA: 0xC35BA0 Offset: 0xC341A0 VA: 0x180C35BA0
	public void ResetOffsetAngles() { }

	// RVA: 0xC348E0 Offset: 0xC32EE0 VA: 0x180C348E0
	public Quaternion ClientAngles() { }

	// RVA: 0xC348F0 Offset: 0xC32EF0 VA: 0x180C348F0
	public Vector3 ClientLookVars() { }

	// RVA: 0xC24280 Offset: 0xC22880 VA: 0x180C24280
	public Quaternion HeadAngles() { }

	// RVA: 0xC350B0 Offset: 0xC336B0 VA: 0x180C350B0
	public Vector3 HeadLookVars() { }

	// RVA: 0xC35A20 Offset: 0xC34020 VA: 0x180C35A20
	private void ModifyInputState(InputMessage state) { }

	// RVA: 0xC35520 Offset: 0xC33B20 VA: 0x180C35520
	internal bool IsButtonDownNative(BUTTON btn) { }

	// RVA: 0xC33F90 Offset: 0xC32590 VA: 0x180C33F90
	private InputMessage BuildInputState(bool allowModify = True) { }

	// RVA: 0xC353D0 Offset: 0xC339D0 VA: 0x180C353D0
	private bool IsAiming() { }

	// RVA: 0xC35CA0 Offset: 0xC342A0 VA: 0x180C35CA0
	private void UpdateButton(InputMessage state, BUTTON btn) { }

	// RVA: 0xC350D0 Offset: 0xC336D0 VA: 0x180C350D0
	public void IgnoreCurrentButtons() { }

	// RVA: 0xC36040 Offset: 0xC34640 VA: 0x180C36040
	private bool get_hasOnlyPartialKeyInput() { }

	// RVA: 0xC35EB0 Offset: 0xC344B0 VA: 0x180C35EB0
	public static bool get_hasNoKeyInput() { }

	// RVA: 0xC35D10 Offset: 0xC34310 VA: 0x180C35D10
	private void UpdateKeyFocus(bool hasFocus) { }

	// RVA: 0xC351E0 Offset: 0xC337E0 VA: 0x180C351E0
	public static void IgnoreCurrentKeys() { }

	// RVA: 0xC35E40 Offset: 0xC34440 VA: 0x180C35E40
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

	// RVA: 0xC43210 Offset: 0xC41810 VA: 0x180C43210
	public void SetMountedLookAtOverride(bool state) { }

	// RVA: 0xC43630 Offset: 0xC41C30 VA: 0x180C43630
	private void SpineIk() { }

	// RVA: 0xC41420 Offset: 0xC3FA20 VA: 0x180C41420
	private void ParentArmsToCamera() { }

	// RVA: 0xC40A90 Offset: 0xC3F090 VA: 0x180C40A90
	private void OnAnimatorIK() { }

	// RVA: 0xC3F0F0 Offset: 0xC3D6F0 VA: 0x180C3F0F0
	private void HandIK(float cameraDistSq) { }

	// RVA: 0xC3B900 Offset: 0xC39F00 VA: 0x180C3B900
	private void FootIK(float cameraDistSq) { }

	// RVA: 0xC3F550 Offset: 0xC3DB50 VA: 0x180C3F550
	private void HeadIK(float cameraDistSq) { }

	// RVA: 0xC48F20 Offset: 0xC47520 VA: 0x180C48F20
	public bool get_ShouldDoLegs() { }

	// RVA: 0xC48FA0 Offset: 0xC475A0 VA: 0x180C48FA0
	public bool get_ShouldShowHands() { }

	// RVA: 0xC3A5A0 Offset: 0xC38BA0 VA: 0x180C3A5A0
	private void ClearLegs() { }

	// RVA: 0xC41DD0 Offset: 0xC403D0 VA: 0x180C41DD0
	public void RebuildLegs() { }

	// RVA: 0xC3FC30 Offset: 0xC3E230 VA: 0x180C3FC30
	private void InitializeLegSpineBones() { }

	// RVA: 0xC44E40 Offset: 0xC43440 VA: 0x180C44E40
	private void UpdateLegsBeforeRender() { }

	// RVA: 0xC45D30 Offset: 0xC44330 VA: 0x180C45D30
	private void UpdateLegsDisable(bool forceDisable = False) { }

	// RVA: 0xC39AD0 Offset: 0xC380D0 VA: 0x180C39AD0
	private void AddLegRenderer(SkinnedMeshRenderer renderer, PaintableItem paintable) { }

	// RVA: 0xC44020 Offset: 0xC42620 VA: 0x180C44020
	private Transform SwapLegBone(Transform bone) { }

	// RVA: 0xC3E560 Offset: 0xC3CB60 VA: 0x180C3E560
	private static Vector3 GetFlat(Vector3 dir) { }

	// RVA: 0xC419D0 Offset: 0xC3FFD0 VA: 0x180C419D0
	public static void RebuildAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC49280 Offset: 0xC47880 VA: 0x180C49280
	public ulong get_overrideSkinSeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC492C0 Offset: 0xC478C0 VA: 0x180C492C0
	private void set_overrideSkinSeed(ulong value) { }

	// RVA: 0xC48ED0 Offset: 0xC474D0 VA: 0x180C48ED0
	public bool get_IsFemale() { }

	// RVA: 0xC49080 Offset: 0xC47680 VA: 0x180C49080
	public SkinSetCollection get_SkinSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48D80 Offset: 0xC47380 VA: 0x180C48D80
	public Quaternion get_AimAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC49290 Offset: 0xC47890 VA: 0x180C49290
	public void set_AimAngles(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48F10 Offset: 0xC47510 VA: 0x180C48F10
	public Quaternion get_LookAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC492B0 Offset: 0xC478B0 VA: 0x180C492B0
	public void set_LookAngles(Quaternion value) { }

	// RVA: 0xC48E30 Offset: 0xC47430 VA: 0x180C48E30
	private bool get_GestureAllowsSpineMovement() { }

	// RVA: 0xC48D90 Offset: 0xC47390 VA: 0x180C48D90
	private bool get_GestureAllowsRootMotion() { }

	// RVA: 0xC48EE0 Offset: 0xC474E0 VA: 0x180C48EE0
	public bool get_IsFirstPerson() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC48F00 Offset: 0xC47500 VA: 0x180C48F00
	public bool get_IsNpc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC492A0 Offset: 0xC478A0 VA: 0x180C492A0
	public void set_IsNpc(bool value) { }

	// RVA: 0xC491E0 Offset: 0xC477E0 VA: 0x180C491E0
	public SkinnedMultiMesh get_multiMesh() { }

	// RVA: 0xC490A0 Offset: 0xC476A0 VA: 0x180C490A0
	public Animator get_animator() { }

	// RVA: 0xC49140 Offset: 0xC47740 VA: 0x180C49140
	public LODGroup get_lodGroup() { }

	// RVA: 0xC3EF90 Offset: 0xC3D590 VA: 0x180C3EF90
	public Vector3 GetTargetVelocity() { }

	// RVA: 0xC3A500 Offset: 0xC38B00 VA: 0x180C3A500
	protected void Awake() { }

	// RVA: 0xC40EB0 Offset: 0xC3F4B0 VA: 0x180C40EB0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC40BC0 Offset: 0xC3F1C0 VA: 0x180C40BC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC42AF0 Offset: 0xC410F0 VA: 0x180C42AF0
	private void SetDefaultAnimatorWeights() { }

	// RVA: 0xC463D0 Offset: 0xC449D0 VA: 0x180C463D0
	private void UpdateMultiMesh(bool reset) { }

	// RVA: 0xC44560 Offset: 0xC42B60 VA: 0x180C44560
	private void UpdateCensorship() { }

	// RVA: 0xC449E0 Offset: 0xC42FE0 VA: 0x180C449E0
	public void UpdateCollider(bool visible, bool sleeping, bool ducking, bool crawling, bool incapacitated) { }

	// RVA: 0xC46380 Offset: 0xC44980 VA: 0x180C46380
	public void UpdateModelState(ModelState ms) { }

	// RVA: 0xC46E40 Offset: 0xC45440 VA: 0x180C46E40
	public void UpdatePosition() { }

	// RVA: 0xC46F60 Offset: 0xC45560 VA: 0x180C46F60
	internal void UpdateRotation() { }

	// RVA: 0xC462B0 Offset: 0xC448B0 VA: 0x180C462B0
	public void UpdateLocalVelocity(Vector3 velocity, Transform parent) { }

	// RVA: 0xC478E0 Offset: 0xC45EE0 VA: 0x180C478E0
	public void UpdateVelocity() { }

	// RVA: 0xC46560 Offset: 0xC44B60 VA: 0x180C46560
	private void UpdateParameters() { }

	// RVA: 0xC44C50 Offset: 0xC43250 VA: 0x180C44C50
	public void UpdateFrom(PlayerModel mdl) { }

	// RVA: 0xC44CB0 Offset: 0xC432B0 VA: 0x180C44CB0
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0xC40410 Offset: 0xC3EA10 VA: 0x180C40410
	public void LateCycle() { }

	// RVA: 0xC3DB70 Offset: 0xC3C170 VA: 0x180C3DB70
	public void FrameUpdate() { }

	// RVA: 0xC3D190 Offset: 0xC3B790 VA: 0x180C3D190
	private void FrameUpdate_Default() { }

	// RVA: 0xC3D8A0 Offset: 0xC3BEA0 VA: 0x180C3D8A0
	private void FrameUpdate_Sleeping() { }

	// RVA: 0xC3D300 Offset: 0xC3B900 VA: 0x180C3D300
	private void FrameUpdate_Incapacitated() { }

	// RVA: 0xC3D5D0 Offset: 0xC3BBD0 VA: 0x180C3D5D0
	private void FrameUpdate_OnLadder() { }

	// RVA: 0xC3E2F0 Offset: 0xC3C8F0 VA: 0x180C3E2F0
	public float GetAim360() { }

	// RVA: 0xC473F0 Offset: 0xC459F0 VA: 0x180C473F0
	public void UpdateVehicleAim360() { }

	// RVA: 0xC429A0 Offset: 0xC40FA0 VA: 0x180C429A0
	public void ResetCurrentState(int layer = 0) { }

	// RVA: 0xC3B0A0 Offset: 0xC396A0 VA: 0x180C3B0A0
	private void DoAimingSounds(float prevAiming, float currentAiming) { }

	// RVA: 0xC42AB0 Offset: 0xC410B0 VA: 0x180C42AB0
	public void SetAimSounds(SoundDefinition aimDef, SoundDefinition aimEndDef) { }

	// RVA: 0xC43220 Offset: 0xC41820 VA: 0x180C43220
	public void SetMountedLookAtWeight(float weight) { }

	// RVA: 0xC43200 Offset: 0xC41800 VA: 0x180C43200
	public void SetMountedAnimationSpeed(float speed) { }

	// RVA: 0xC45F60 Offset: 0xC44560 VA: 0x180C45F60
	internal void UpdateLocalPlayerPosition(Vector3 position, Quaternion quaternion) { }

	// RVA: 0xC3A480 Offset: 0xC38A80 VA: 0x180C3A480
	public void Attack() { }

	// RVA: 0xC3A140 Offset: 0xC38740 VA: 0x180C3A140
	public void AltAttack() { }

	// RVA: 0xC3AFF0 Offset: 0xC395F0 VA: 0x180C3AFF0
	public void Deploy() { }

	// RVA: 0xC42720 Offset: 0xC40D20 VA: 0x180C42720
	public void Reload() { }

	// RVA: 0xC3FBB0 Offset: 0xC3E1B0 VA: 0x180C3FBB0
	public void Holster() { }

	// RVA: 0xC3B8A0 Offset: 0xC39EA0 VA: 0x180C3B8A0
	public void Flinch(uint location) { }

	// RVA: 0xC3B8D0 Offset: 0xC39ED0 VA: 0x180C3B8D0
	public void Flinch() { }

	// RVA: 0xC43230 Offset: 0xC41830 VA: 0x180C43230
	public void SetReactionAnim(PlayerModel.ReactionDir direction, float weight) { }

	// RVA: 0xC413F0 Offset: 0xC3F9F0 VA: 0x180C413F0
	public void OnReactionEnded() { }

	// RVA: 0xC44350 Offset: 0xC42950 VA: 0x180C44350
	public void Throw() { }

	// RVA: 0xC3DF60 Offset: 0xC3C560 VA: 0x180C3DF60
	public void Gesture(string gesture, GestureConfig forConfig) { }

	// RVA: 0xC3B300 Offset: 0xC39900 VA: 0x180C3B300
	private void FadeInGestureUpperBodyLayer() { }

	// RVA: 0xC3B5F0 Offset: 0xC39BF0 VA: 0x180C3B5F0
	private void FadeOutGestureUpperBodyLayer() { }

	// RVA: 0xC3B1E0 Offset: 0xC397E0 VA: 0x180C3B1E0
	private void FadeInGestureFullBodyLayer() { }

	// RVA: 0xC3B420 Offset: 0xC39A20 VA: 0x180C3B420
	private void FadeOutGestureFullBodyLayer() { }

	// RVA: 0xC3A1F0 Offset: 0xC387F0 VA: 0x180C3A1F0
	private void AnimatorWarmup() { }

	// RVA: 0xC3A1C0 Offset: 0xC387C0 VA: 0x180C3A1C0
	public void AlwaysAnimate(bool b) { }

	// RVA: 0xC42E80 Offset: 0xC41480 VA: 0x180C42E80
	public void SetHoldType(RuntimeAnimatorController holdType, bool suppressHandLayer = False) { }

	// RVA: 0xC42E70 Offset: 0xC41470 VA: 0x180C42E70
	public void SetHasHeldEntity(bool state) { }

	[IteratorStateMachineAttribute] // RVA: 0x80940 Offset: 0x7FD40 VA: 0x180080940
	// RVA: 0xC3B580 Offset: 0xC39B80 VA: 0x180C3B580
	public IEnumerator FadeOutGestureLayer() { }

	// RVA: 0xC42C20 Offset: 0xC41220 VA: 0x180C42C20
	public void SetGesture() { }

	// RVA: 0xC3B750 Offset: 0xC39D50 VA: 0x180C3B750
	public void FadeOutPlayerGestureLayers() { }

	// RVA: 0xC43F20 Offset: 0xC42520 VA: 0x180C43F20
	public void StopGesture() { }

	// RVA: 0xC41840 Offset: 0xC3FE40 VA: 0x180C41840
	public void PlayCinematic(string name, float overrideSpeed = 1) { }

	// RVA: 0xC43EC0 Offset: 0xC424C0 VA: 0x180C43EC0
	public void StopCinematic() { }

	// RVA: 0xC43610 Offset: 0xC41C10 VA: 0x180C43610
	public void SetSpeedOverride(Vector3 speed) { }

	// RVA: 0xC3EED0 Offset: 0xC3D4D0 VA: 0x180C3EED0
	public Underwear GetReplacementUnderwear() { }

	// RVA: 0xC42870 Offset: 0xC40E70 VA: 0x180C42870
	public void RemoveUnderwearParts(SkinReplacement.SkinType typeToRemove) { }

	// RVA: 0xC3A700 Offset: 0xC38D00 VA: 0x180C3A700
	public void Clear() { }

	// RVA: 0xC42190 Offset: 0xC40790 VA: 0x180C42190
	public void Rebuild(bool reset = True) { }

	// RVA: 0xC39E60 Offset: 0xC38460 VA: 0x180C39E60
	public void AddPart(string strName, Item item) { }

	// RVA: 0xC427A0 Offset: 0xC40DA0 VA: 0x180C427A0
	public void RemovePart(string strName) { }

	// RVA: 0xC3F490 Offset: 0xC3DA90 VA: 0x180C3F490
	public bool HasPart(string strName) { }

	// RVA: 0xC40380 Offset: 0xC3E980 VA: 0x180C40380
	public bool IsBarefoot() { }

	// RVA: 0xC3EF10 Offset: 0xC3D510 VA: 0x180C3EF10
	public Color GetSkinColor() { }

	// RVA: 0xC434F0 Offset: 0xC41AF0 VA: 0x180C434F0
	public void SetSkinProperties(MaterialPropertyBlock block) { }

	// RVA: 0xC42390 Offset: 0xC40990 VA: 0x180C42390
	public void RefreshUnderwear() { }

	// RVA: 0xC3CF60 Offset: 0xC3B560 VA: 0x180C3CF60
	public void ForceModelSeed(ulong userID) { }

	// RVA: 0xC3D070 Offset: 0xC3B670 VA: 0x180C3D070
	public void ForceModelSeed(ulong userID, bool storeSkinChange) { }

	// RVA: 0xC3B870 Offset: 0xC39E70 VA: 0x180C3B870
	public Transform FindBone(string strName) { }

	// RVA: 0xC3E530 Offset: 0xC3CB30 VA: 0x180C3E530
	public Transform[] GetBones() { }

	// RVA: 0xC3E5A0 Offset: 0xC3CBA0 VA: 0x180C3E5A0
	private Vector3 GetFootPlacement(Vector3 footPos, out Vector3 surfaceNormal) { }

	// RVA: 0xC3A250 Offset: 0xC38850 VA: 0x180C3A250
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0xC443F0 Offset: 0xC429F0 VA: 0x180C443F0
	public void ToggleUpdateOffscreen(bool state) { }

	// RVA: 0xC412F0 Offset: 0xC3F8F0 VA: 0x180C412F0 Slot: 8
	public void OnParentDestroying() { }

	// RVA: 0xC47CF0 Offset: 0xC462F0 VA: 0x180C47CF0
	public void WorkshopPreviewSetup(GameObject[] objects) { }

	// RVA: 0xC48BD0 Offset: 0xC471D0 VA: 0x180C48BD0
	public void .ctor() { }

	// RVA: 0xC48690 Offset: 0xC46C90 VA: 0x180C48690
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

	// RVA: 0xC49710 Offset: 0xC47D10 VA: 0x180C49710
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xC496B0 Offset: 0xC47CB0 VA: 0x180C496B0
	internal bool <UpdateCensorship>b__199_0(Wearable x) { }

	// RVA: 0xC496D0 Offset: 0xC47CD0 VA: 0x180C496D0
	internal bool <UpdateCensorship>b__199_1(Wearable x) { }

	// RVA: 0xC496F0 Offset: 0xC47CF0 VA: 0x180C496F0
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

	// RVA: 0xC492D0 Offset: 0xC478D0 VA: 0x180C492D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC49660 Offset: 0xC47C60 VA: 0x180C49660 Slot: 8
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

	// RVA: 0x5C46D0 Offset: 0x5C2CD0 VA: 0x1805C46D0
	internal bool <RemovePart>b__0(SkinnedMultiMesh.Part x) { }

}

private sealed class PlayerModel.<>c__DisplayClass257_0 // TypeDefIndex: 9656
{	// Fields
	public string strName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C46D0 Offset: 0x5C2CD0 VA: 0x1805C46D0
	internal bool <HasPart>b__0(SkinnedMultiMesh.Part x) { }

}

public class PlayerModelCinematicList : PrefabAttribute, IClientComponent // TypeDefIndex: 9657
{	// Fields
	public PlayerModelCinematicList.PlayerModelCinematicAnimation[] Animations; // 0x98

	// Methods

	// RVA: 0xC39060 Offset: 0xC37660 VA: 0x180C39060 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0xC390C0 Offset: 0xC376C0 VA: 0x180C390C0 Slot: 5
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xC390F0 Offset: 0xC376F0 VA: 0x180C390F0
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

	// RVA: 0x98D5A0 Offset: 0x98BBA0 VA: 0x18098D5A0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7AD0 Offset: 0x6A60D0 VA: 0x1806A7AD0
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

	// RVA: 0x98E1C0 Offset: 0x98C7C0 VA: 0x18098E1C0
	public void Initialize(BasePlayer player, Transform parent) { }

	// RVA: 0x98E6E0 Offset: 0x98CCE0 VA: 0x18098E6E0
	public void UpdateFrom(BasePlayer player) { }

	// RVA: 0x98E470 Offset: 0x98CA70 VA: 0x18098E470
	private void LateUpdate() { }

	// RVA: 0x98E840 Offset: 0x98CE40 VA: 0x18098E840
	private void UpdateNameColor() { }

	// RVA: 0x98E5C0 Offset: 0x98CBC0 VA: 0x18098E5C0
	public void PositionUpdate(bool visible) { }

	// RVA: 0x98EA90 Offset: 0x98D090 VA: 0x18098EA90
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

	// RVA: 0x98F970 Offset: 0x98DF70 VA: 0x18098F970
	public bool get_IsSpeaking() { }

	// RVA: 0x98EBD0 Offset: 0x98D1D0 VA: 0x18098EBD0
	public void ClientFrame(BasePlayer player) { }

	// RVA: 0x98F190 Offset: 0x98D790 VA: 0x18098F190
	public void ClientInput(InputState state) { }

	// RVA: 0x98F300 Offset: 0x98D900 VA: 0x18098F300
	private bool DoesUserWantToTalk() { }

	// RVA: 0x98EAF0 Offset: 0x98D0F0 VA: 0x18098EAF0
	public bool CanTalk() { }

	// RVA: 0x98F680 Offset: 0x98DC80 VA: 0x18098F680
	public void StopRecording() { }

	// RVA: 0x98F4D0 Offset: 0x98DAD0 VA: 0x18098F4D0
	public void StartRecording() { }

	// RVA: 0x98F900 Offset: 0x98DF00 VA: 0x18098F900
	public void .ctor() { }

	// RVA: 0x98F880 Offset: 0x98DE80 VA: 0x18098F880
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

	// RVA: 0x9909A0 Offset: 0x98EFA0 VA: 0x1809909A0
	public float get_currentVolume() { }

	// RVA: 0x990200 Offset: 0x98E800 VA: 0x180990200
	public bool IsSpeaking() { }

	// RVA: 0x990290 Offset: 0x98E890 VA: 0x180990290
	public void Receive(byte[] data) { }

	// RVA: 0x98FE90 Offset: 0x98E490 VA: 0x18098FE90
	public float GetMouthVolume() { }

	// RVA: 0x98F9A0 Offset: 0x98DFA0 VA: 0x18098F9A0
	public void ClientFrame() { }

	// RVA: 0x990620 Offset: 0x98EC20 VA: 0x180990620
	public bool ShouldMuteVoice() { }

	// RVA: 0x990100 Offset: 0x98E700 VA: 0x180990100
	private bool IsPlayingLocalVoice() { }

	// RVA: 0x990740 Offset: 0x98ED40 VA: 0x180990740
	public bool ShouldReceiveVoice() { }

	// RVA: 0x990960 Offset: 0x98EF60 VA: 0x180990960
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

	// RVA: 0x990A80 Offset: 0x98F080 VA: 0x180990A80
	protected void Awake() { }

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0 Slot: 6
	public override Collider GetCollider() { }

	// RVA: 0x995960 Offset: 0x993F60 VA: 0x180995960
	protected void OnDisable() { }

	// RVA: 0x993190 Offset: 0x991790 VA: 0x180993190 Slot: 7
	public override void Init(BasePlayer player) { }

	// RVA: 0x9957A0 Offset: 0x993DA0 VA: 0x1809957A0
	protected void OnCollisionEnter(Collision collision) { }

	// RVA: 0x995880 Offset: 0x993E80 VA: 0x180995880
	protected void OnCollisionStay(Collision collision) { }

	// RVA: 0x992950 Offset: 0x990F50 VA: 0x180992950
	private void GroundCheck(Collision collision) { }

	// RVA: 0x996010 Offset: 0x994610 VA: 0x180996010 Slot: 13
	public override void TeleportTo(Vector3 position, BasePlayer player) { }

	// RVA: 0x996340 Offset: 0x994940 VA: 0x180996340
	public void UpdateCurrentLadder(InputState input, bool force = False) { }

	// RVA: 0x9973B0 Offset: 0x9959B0 VA: 0x1809973B0
	public static bool WantsSprint(InputState input) { }

	// RVA: 0x990D70 Offset: 0x98F370 VA: 0x180990D70 Slot: 10
	public override void ClientInput(InputState input, ModelState modelState) { }

	// RVA: 0x994BF0 Offset: 0x9931F0 VA: 0x180994BF0
	private void Movement_Water(InputState input, ModelState modelState) { }

	// RVA: 0x993CD0 Offset: 0x9922D0 VA: 0x180993CD0
	private void Movement_Mounted(InputState input, ModelState modelState) { }

	// RVA: 0x993680 Offset: 0x991C80 VA: 0x180993680
	private void Movement_Ladder(InputState input, ModelState modelState) { }

	// RVA: 0x993DE0 Offset: 0x9923E0 VA: 0x180993DE0
	private void Movement_Noclip(InputState input, ModelState modelState) { }

	// RVA: 0x994370 Offset: 0x992970 VA: 0x180994370
	private void Movement_Walking(InputState input, ModelState modelState) { }

	// RVA: 0x9928A0 Offset: 0x990EA0 VA: 0x1809928A0
	private float GetHeldEntityMovementMultiplier() { }

	// RVA: 0x992C20 Offset: 0x991220 VA: 0x180992C20
	private void HandleGrounded(ModelState state, bool wantsGrounded) { }

	// RVA: 0x992DA0 Offset: 0x9913A0 VA: 0x180992DA0
	private void HandleRunDuckCrawl(ModelState state, bool wantsRun, bool wantsDuck, bool wantsCrawl) { }

	// RVA: 0x9927B0 Offset: 0x990DB0 VA: 0x1809927B0
	private float GetForcedDuck() { }

	// RVA: 0x992C70 Offset: 0x991270 VA: 0x180992C70
	private void HandleJumping(ModelState state, bool wantsJump, bool jumpInDirection = False) { }

	// RVA: 0x990BF0 Offset: 0x98F1F0 VA: 0x180990BF0
	private bool CanJump() { }

	// RVA: 0x990B60 Offset: 0x98F160 VA: 0x180990B60 Slot: 8
	public override void BlockJump(float duration) { }

	// RVA: 0x990BA0 Offset: 0x98F1A0 VA: 0x180990BA0 Slot: 9
	public override void BlockSprint(float duration) { }

	// RVA: 0x995DE0 Offset: 0x9943E0 VA: 0x180995DE0
	public void SetKinematic(bool kinematic) { }

	// RVA: 0x990A40 Offset: 0x98F040 VA: 0x180990A40
	public void ApplyForce(Vector3 force) { }

	// RVA: 0x990D00 Offset: 0x98F300 VA: 0x180990D00
	private bool CanSprint() { }

	// RVA: 0x993360 Offset: 0x991960 VA: 0x180993360
	private void Jump(ModelState state, bool inDirection) { }

	// RVA: 0x991120 Offset: 0x98F720 VA: 0x180991120 Slot: 11
	public override void DoFixedUpdate(ModelState modelState) { }

	// RVA: 0x991940 Offset: 0x98FF40 VA: 0x180991940
	public void DoStepUp() { }

	// RVA: 0x996860 Offset: 0x994E60 VA: 0x180996860
	private void UpdateVelocity() { }

	// RVA: 0x996510 Offset: 0x994B10 VA: 0x180996510
	private void UpdateGravity(ModelState modelState) { }

	// RVA: 0x992310 Offset: 0x990910 VA: 0x180992310 Slot: 12
	public override void FrameUpdate(BasePlayer player, ModelState state) { }

	// RVA: 0x996130 Offset: 0x994730 VA: 0x180996130
	private void TransformState(Matrix4x4 matrix) { }

	// RVA: 0x995E10 Offset: 0x994410 VA: 0x180995E10 Slot: 15
	public override void SetParent(Transform parent) { }

	// RVA: 0x992260 Offset: 0x990860 VA: 0x180992260
	private Vector3 FallVelocity() { }

	// RVA: 0x9910E0 Offset: 0x98F6E0 VA: 0x1809910E0 Slot: 4
	public override Vector3 CurrentVelocity() { }

	// RVA: 0x991090 Offset: 0x98F690 VA: 0x180991090 Slot: 5
	public override float CurrentMoveSpeed() { }

	// RVA: 0x995D80 Offset: 0x994380 VA: 0x180995D80 Slot: 16
	public override void PlayerAttemptedMount() { }

	// RVA: 0x995DB0 Offset: 0x9943B0 VA: 0x180995DB0 Slot: 17
	public override void PlayerCompletedMount() { }

	// RVA: 0x997440 Offset: 0x995A40 VA: 0x180997440
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

	// RVA: 0x557EE0 Offset: 0x5564E0 VA: 0x180557EE0
	public bool IsBuoyant() { }

	// RVA: 0xC2CED0 Offset: 0xC2B4D0 VA: 0x180C2CED0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xC2D1C0 Offset: 0xC2B7C0 VA: 0x180C2D1C0
	private void RebuildWorldModel() { }

	// RVA: 0xC2CEF0 Offset: 0xC2B4F0 VA: 0x180C2CEF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xC2D080 Offset: 0xC2B680 VA: 0x180C2D080 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xC2D5E0 Offset: 0xC2BBE0 VA: 0x180C2D5E0
	private void ToggleClientBuoyancy(bool isBuoyant) { }

	// RVA: 0xC2CEA0 Offset: 0xC2B4A0 VA: 0x180C2CEA0 Slot: 122
	public override string Categorize() { }

	// RVA: 0xC2D700 Offset: 0xC2BD00 VA: 0x180C2D700
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

	// RVA: 0xC360A0 Offset: 0xC346A0 VA: 0x180C360A0
	public void .ctor() { }

}

public class PlayerInventoryProperties.ItemAmountSkinned : ItemAmount // TypeDefIndex: 10750
{	// Fields
	public ulong skinOverride; // 0x20

	// Methods

	// RVA: 0xC2CE90 Offset: 0xC2B490 VA: 0x180C2CE90
	public void .ctor() { }

}

public class PlayerDetectedEventUI : BaseEventUI // TypeDefIndex: 10807
{	// Methods

	// RVA: 0x86E4D0 Offset: 0x86CAD0 VA: 0x18086E4D0 Slot: 4
	public override void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0xC2D7C0 Offset: 0xC2BDC0 VA: 0x180C2D7C0 Slot: 5
	public override AIEventData Save() { }

	// RVA: 0xC2D750 Offset: 0xC2BD50 VA: 0x180C2D750 Slot: 6
	public override void Load(AIEventData data) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
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

