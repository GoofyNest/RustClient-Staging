public class ConversationManager : MonoBehaviour // TypeDefIndex: 8846
{	// Fields
	private static ConversationManager.Conversation activeConversation; // 0x1BB0

	// Methods

	// RVA: 0x6BB410 Offset: 0x6B9A10 VA: 0x1806BB410
	public static bool InConversation() { }

	// RVA: 0x6BB3D0 Offset: 0x6B99D0 VA: 0x1806BB3D0
	public static ConversationManager.Conversation GetActiveConversation() { }

	// RVA: 0x6BB2D0 Offset: 0x6B98D0 VA: 0x1806BB2D0
	public static void FastForward() { }

	// RVA: 0x6BB480 Offset: 0x6B9A80 VA: 0x1806BB480
	public static void ModifyCamera() { }

	// RVA: 0x6BB7B0 Offset: 0x6B9DB0 VA: 0x1806BB7B0
	public static void StartConversation(ConversationData conversationData, IConversationProvider provider, string startIndex = "intro") { }

	// RVA: 0x6BB120 Offset: 0x6B9720 VA: 0x1806BB120
	public static void CancelConversation(bool fromServer) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ConversationManager.Conversation : MonoBehaviour // TypeDefIndex: 8847
{	// Fields
	public ConversationData data; // 0x18
	public int currentSpeechNodeIndex; // 0x20
	public IConversationProvider provider; // 0x28
	private float age; // 0x30
	private float speechNodeAge; // 0x34
	private int speechCharacterIndex; // 0x38
	private float timeOnChar; // 0x3C

	// Methods

	// RVA: 0x6BBA60 Offset: 0x6BA060 VA: 0x1806BBA60
	public int GetSpeechNodeIndex(string name) { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public int GetSpeechCharacterIndex() { }

	// RVA: 0x6BBB80 Offset: 0x6BA180 VA: 0x1806BBB80
	public bool IsTalking() { }

	// RVA: 0x6BBCB0 Offset: 0x6BA2B0 VA: 0x1806BBCB0
	public void SwitchToSpeechNode(int index) { }

	// RVA: 0x6BBC00 Offset: 0x6BA200 VA: 0x1806BBC00
	public void ResponsePressed(int index) { }

	// RVA: 0x6BBA40 Offset: 0x6BA040 VA: 0x1806BBA40
	public float GetConversationAge() { }

	// RVA: 0x6BBB70 Offset: 0x6BA170 VA: 0x1806BBB70
	public bool HasConversationStarted() { }

	// RVA: 0x6BBEA0 Offset: 0x6BA4A0 VA: 0x1806BBEA0
	public void Update() { }

	// RVA: 0x6BB9D0 Offset: 0x6B9FD0 VA: 0x1806BB9D0
	public void FastFowardSpeech() { }

	// RVA: 0x6BBCC0 Offset: 0x6BA2C0 VA: 0x1806BBCC0
	public void UpdateSpeechCharacterIndex(float delta) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

