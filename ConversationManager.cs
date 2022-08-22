public class ConversationManager : MonoBehaviour // TypeDefIndex: 8846
{	// Fields
	private static ConversationManager.Conversation activeConversation; // 0x2B10368

	// Methods

	// RVA: 0x6BB3A0 Offset: 0x6B99A0 VA: 0x1806BB3A0
	public static bool InConversation() { }

	// RVA: 0x6BB360 Offset: 0x6B9960 VA: 0x1806BB360
	public static ConversationManager.Conversation GetActiveConversation() { }

	// RVA: 0x6BB260 Offset: 0x6B9860 VA: 0x1806BB260
	public static void FastForward() { }

	// RVA: 0x6BB410 Offset: 0x6B9A10 VA: 0x1806BB410
	public static void ModifyCamera() { }

	// RVA: 0x6BB740 Offset: 0x6B9D40 VA: 0x1806BB740
	public static void StartConversation(ConversationData conversationData, IConversationProvider provider, string startIndex = "intro") { }

	// RVA: 0x6BB0B0 Offset: 0x6B96B0 VA: 0x1806BB0B0
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

	// RVA: 0x6BB9F0 Offset: 0x6B9FF0 VA: 0x1806BB9F0
	public int GetSpeechNodeIndex(string name) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public int GetSpeechCharacterIndex() { }

	// RVA: 0x6BBB10 Offset: 0x6BA110 VA: 0x1806BBB10
	public bool IsTalking() { }

	// RVA: 0x6BBC40 Offset: 0x6BA240 VA: 0x1806BBC40
	public void SwitchToSpeechNode(int index) { }

	// RVA: 0x6BBB90 Offset: 0x6BA190 VA: 0x1806BBB90
	public void ResponsePressed(int index) { }

	// RVA: 0x6BB9D0 Offset: 0x6B9FD0 VA: 0x1806BB9D0
	public float GetConversationAge() { }

	// RVA: 0x6BBB00 Offset: 0x6BA100 VA: 0x1806BBB00
	public bool HasConversationStarted() { }

	// RVA: 0x6BBE30 Offset: 0x6BA430 VA: 0x1806BBE30
	public void Update() { }

	// RVA: 0x6BB960 Offset: 0x6B9F60 VA: 0x1806BB960
	public void FastFowardSpeech() { }

	// RVA: 0x6BBC50 Offset: 0x6BA250 VA: 0x1806BBC50
	public void UpdateSpeechCharacterIndex(float delta) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

