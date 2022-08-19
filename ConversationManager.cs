public class ConversationManager : MonoBehaviour // TypeDefIndex: 8846
{	// Fields
	private static ConversationManager.Conversation activeConversation; // 0x1BB0

	// Methods

	// RVA: 0x6BB300 Offset: 0x6B9900 VA: 0x1806BB300
	public static bool InConversation() { }

	// RVA: 0x6BB2C0 Offset: 0x6B98C0 VA: 0x1806BB2C0
	public static ConversationManager.Conversation GetActiveConversation() { }

	// RVA: 0x6BB1C0 Offset: 0x6B97C0 VA: 0x1806BB1C0
	public static void FastForward() { }

	// RVA: 0x6BB370 Offset: 0x6B9970 VA: 0x1806BB370
	public static void ModifyCamera() { }

	// RVA: 0x6BB6A0 Offset: 0x6B9CA0 VA: 0x1806BB6A0
	public static void StartConversation(ConversationData conversationData, IConversationProvider provider, string startIndex = "intro") { }

	// RVA: 0x6BB010 Offset: 0x6B9610 VA: 0x1806BB010
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

	// RVA: 0x6BB950 Offset: 0x6B9F50 VA: 0x1806BB950
	public int GetSpeechNodeIndex(string name) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public int GetSpeechCharacterIndex() { }

	// RVA: 0x6BBA70 Offset: 0x6BA070 VA: 0x1806BBA70
	public bool IsTalking() { }

	// RVA: 0x6BBBA0 Offset: 0x6BA1A0 VA: 0x1806BBBA0
	public void SwitchToSpeechNode(int index) { }

	// RVA: 0x6BBAF0 Offset: 0x6BA0F0 VA: 0x1806BBAF0
	public void ResponsePressed(int index) { }

	// RVA: 0x6BB930 Offset: 0x6B9F30 VA: 0x1806BB930
	public float GetConversationAge() { }

	// RVA: 0x6BBA60 Offset: 0x6BA060 VA: 0x1806BBA60
	public bool HasConversationStarted() { }

	// RVA: 0x6BBD90 Offset: 0x6BA390 VA: 0x1806BBD90
	public void Update() { }

	// RVA: 0x6BB8C0 Offset: 0x6B9EC0 VA: 0x1806BB8C0
	public void FastFowardSpeech() { }

	// RVA: 0x6BBBB0 Offset: 0x6BA1B0 VA: 0x1806BBBB0
	public void UpdateSpeechCharacterIndex(float delta) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

